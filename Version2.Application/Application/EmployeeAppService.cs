using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Payroll.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Interface;
using Version2.Data.Models;
using Version2.Framework;

namespace Version2.Application
{

    public interface IEmployeeAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditEmployeeDto product);
        Task Delete(int id);
        EmployeeDto Get(GetEmployee getEmployee);
        Task<List<EmployeeDto>> GetAll();
        CreateorEditEmployeeDto createorEditDto(GetEmployee getEmployee);
    }
    public class EmployeeAppService : IEmployeeAppService
    {
        private readonly IRepository<Employee> _EmployeeRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public EmployeeAppService(IRepository<Employee> EmployeeRepository,
            IMapper mapper,
            IUnitofWork unitofWork)
        {
            _EmployeeRepository = EmployeeRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task CreateorEdit(CreateorEditEmployeeDto input)
        {
            if (input.Id == 0)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }

        }
        protected async Task Create(CreateorEditEmployeeDto input)
        {
            //var messages = _mapper.Map<Employee>(input);
            var employee = Employee.Create(input.EmployeeId, input.EmployeeName,
                input.Rate, input.Company);
            await _EmployeeRepository.Add(employee.Value);
            await Complete();
        }
        protected async Task Update(CreateorEditEmployeeDto input)
        {
            Employee _category = _EmployeeRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _EmployeeRepository.Update(_category);
            await Complete();
        }
        public EmployeeDto Get(GetEmployee getEmployee)
        {
            Employee log = _EmployeeRepository.GetAll()
                .WhereIf(getEmployee.Id.HasValue, m => m.Id == getEmployee.Id)
                .WhereIf(string.IsNullOrEmpty(getEmployee.EmpCode) == false, m => m.EmployeeId == getEmployee.EmpCode)
                .FirstOrDefault();
            var msgdto = _mapper.Map<EmployeeDto>(log);
            return msgdto;
        }

        public async Task Delete(int id)
        {
            var msg1 = _EmployeeRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _EmployeeRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<EmployeeDto>> GetAll()
        {
            var categorydtolist = from a in _EmployeeRepository.GetAll()
                                  select new EmployeeDto()
                                  {
                                       Id = a.Id,
                                       EmployeeId = a.EmployeeId,
                                       EmployeeName = a.EmployeeName,
                                       Rate = a.Rate ,
                                       Company = a.Company,
                                       Department = a.Department

                                  };
            return await categorydtolist.ToListAsync();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }
        CreateorEditEmployeeDto getEditDto(GetEmployee getEmployee)
        {
            var input = Get(getEmployee);
            var createorEditEmployeeDto = _mapper.Map<CreateorEditEmployeeDto>(input);
            return createorEditEmployeeDto;
        }
        public CreateorEditEmployeeDto createorEditDto(GetEmployee getEmployee)
        {
            CreateorEditEmployeeDto createorEditEmployeeDto = new CreateorEditEmployeeDto(); 
            if (getEmployee.Id > 0)
            {
                createorEditEmployeeDto= getEditDto(getEmployee);
            }
            return createorEditEmployeeDto;
        }
    }
}

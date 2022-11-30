using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Application;
using Version2.Data;
using Version2.Data.Interface;
using Version2.Data.Models;
using Version2.Framework;

namespace Version2.Application
{

    public interface IDTRAppService : ICompleteWork
    {
        Task<Result> CreateorEdit(CreateorEditDTRDto product);
        Task Delete(int id);
        DTRDto Get(int id);
        Task<List<DTRDto>> GetAll();
        CreateorEditDTRDto createorEditDto(int id);
        Task SaveChangesAsync();
    }
    public class DTRAppService : IDTRAppService
    {
        private readonly IRepository<DTR> _DTRRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IEmployeeAppService _employeeAppService;

        public DTRAppService(IRepository<DTR> DTRRepository,
            IMapper mapper,
            IUnitofWork unitofWork,
            IEmployeeAppService employeeAppService)
        {
            _DTRRepository = DTRRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
            this._employeeAppService = employeeAppService;
        }

        public async Task<Result> CreateorEdit(CreateorEditDTRDto input)
        {
            if (input.Id == 0)
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }

        }
      
        protected async Task<Result> Create(CreateorEditDTRDto input)
        {
            var employee = Employee.Create(input.EmployeeId,
                input.EmployeeName,
                input.Rate, input.Company);
             var messages = DTR.Create(input.TimeIn, input.TimeOut, employee.Value);
            if (messages.isFailed)
            {
                return Result.Failed(messages.Message);
            }
            else
            {
                await _DTRRepository.Add(messages.Value);
                await Complete();
            }
            return Result.Ok();
        }
        protected async Task<Result> Update(CreateorEditDTRDto input)
        {
            DTR dtr = _DTRRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, dtr);
            try
            {
                await _DTRRepository.Update(dtr);
            }
            catch (Exception err)
            {
                return Result.Failed(err.Message);
            }
            return Result.Ok();
        }
        public DTRDto Get(int id)
        {
            DTR log = _DTRRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
            var msgdto = _mapper.Map<DTRDto>(log);
            return msgdto;
        }
        public async Task Delete(int id)
        {
            var msg1 = _DTRRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _DTRRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<DTRDto>> GetAll()
        {
            var input = _DTRRepository.GetAll();
            var map = _mapper.Map<List<DTRDto>>(input);
            return map;
        }
        public async Task SaveChangesAsync()
        {
            await _unitofWork.SaveChangesAsync();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }
        CreateorEditDTRDto getEditDto(int id)
        {
            var input = Get(id);
            var createorEditDTRDto = _mapper.Map<CreateorEditDTRDto>(input);
            return createorEditDTRDto;
        }
        public CreateorEditDTRDto createorEditDto(int id)
        {
            CreateorEditDTRDto createorEditDTRDto = new CreateorEditDTRDto(); 
            if (id > 0)
            {
                createorEditDTRDto= getEditDto(id);
            }
            return createorEditDTRDto;
        }
    }
}

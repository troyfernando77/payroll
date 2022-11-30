using AutoMapper;
using Payroll.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Interface;
using Version2.Data.Models;
using Version2.Framework;

namespace Version2.Application
{

    public interface ICompanyAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditCompanyDto product);
        Task Delete(int id);
        CompanyDto Get(GetCompany getCompany);
        Task<List<CompanyDto>> GetAll();
        CreateorEditCompanyDto createorEditDto(GetCompany getCompany);
    }
    public class CompanyAppService : ICompanyAppService
    {
        private readonly IRepository<Company> _CompanyRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public CompanyAppService(IRepository<Company> CompanyRepository,
            IMapper mapper,
            IUnitofWork unitofWork)
        {
            _CompanyRepository = CompanyRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task CreateorEdit(CreateorEditCompanyDto input)
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
        protected async Task Create(CreateorEditCompanyDto input)
        {
            var messages = _mapper.Map<Company>(input);
            await _CompanyRepository.Add(messages);
            await Complete();
        }
        protected async Task Update(CreateorEditCompanyDto input)
        {
            Company _category = _CompanyRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _CompanyRepository.Update(_category);
            await Complete();
        }
        public CompanyDto Get(GetCompany getCompany)
        {
            Company log = _CompanyRepository.GetAll()
                .WhereIf(getCompany.Id.HasValue, m => m.Id == getCompany.Id)
                .WhereIf(string.IsNullOrEmpty(getCompany.Name) == false, m => m.Name == getCompany.Name)
                .FirstOrDefault();
            var msgdto = _mapper.Map<CompanyDto>(log);
            return msgdto;
        }

        public async Task Delete(int id)
        {
            var msg1 = _CompanyRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _CompanyRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<CompanyDto>> GetAll()
        {
            var categorydtolist = from a in _CompanyRepository.GetAll()
                                  select new CompanyDto()
                                  {
                                       Id = a.Id,
                                       Name=a.Name

                                  };
            return categorydtolist.ToList();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }
        CreateorEditCompanyDto getEditDto(GetCompany getCompany)
        {
            var input = Get(getCompany);
            var createorEditEmployeeDto = _mapper.Map<CreateorEditCompanyDto>(input);
            return createorEditEmployeeDto;
        }
        public CreateorEditCompanyDto createorEditDto(GetCompany getCompany)
        {
            CreateorEditCompanyDto createorEditCompanyDto = new CreateorEditCompanyDto(); 
            if (getCompany.Id > 0)
            {
                createorEditCompanyDto = getEditDto(getCompany);
            }
            return createorEditCompanyDto;
        }
    }
}

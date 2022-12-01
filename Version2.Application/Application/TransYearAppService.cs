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

    public interface ITransYearAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditTransYearDto product);
        Task Delete(int id);
        TransYearDto Get(GetTransYear getCompany);
        Task<List<TransYearDto>> GetAll();
        CreateorEditTransYearDto createorEditDto(GetTransYear getCompany);
    }
    public class TransYearAppService : ITransYearAppService 
    {
        private readonly IRepository<TransYear> _TransYearRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public TransYearAppService(IRepository<TransYear> TransYearRepository,
            IMapper mapper,
            IUnitofWork unitofWork)
        {
            _TransYearRepository = TransYearRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task CreateorEdit(CreateorEditTransYearDto input)
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
        protected async Task Create(CreateorEditTransYearDto input)
        {
            var messages = _mapper.Map<TransYear>(input);
            await _TransYearRepository.Add(messages);
            await Complete();
        }
        protected async Task Update(CreateorEditTransYearDto input)
        {
            TransYear _category = _TransYearRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _TransYearRepository.Update(_category);
            await Complete();
        }
        public TransYearDto Get(GetTransYear getTransYear)
        {
            TransYear log = _TransYearRepository.GetAll()
                .WhereIf(getTransYear.Id.HasValue, m => m.Id == getTransYear.Id)
                .FirstOrDefault();
            var msgdto = _mapper.Map<TransYearDto>(log);
            return msgdto;
        }

        public async Task Delete(int id)
        {
            var msg1 = _TransYearRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _TransYearRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<TransYearDto>> GetAll()
        {
            var categorydtolist = from a in _TransYearRepository.GetAll()
                                  select new TransYearDto()
                                  {
                                       Id = a.Id,
                                       Status = a.Status,
                                       Year = a.Year

                                  };
            return categorydtolist.ToList();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }
        CreateorEditTransYearDto getEditDto(GetTransYear getCompany)
        {
            var input = Get(getCompany);
            var createorEditEmployeeDto = _mapper.Map<CreateorEditTransYearDto>(input);
            return createorEditEmployeeDto;
        }
        public CreateorEditTransYearDto createorEditDto(GetTransYear getCompany)
        {
            CreateorEditTransYearDto createorEditCompanyDto = new CreateorEditTransYearDto(); 
            if (getCompany.Id > 0)
            {
                createorEditCompanyDto = getEditDto(getCompany);
            }
            return createorEditCompanyDto;
        }
    }
}

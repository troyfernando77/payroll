using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Interface;
using Version2.Data.Models;
using Version2.Framework;

namespace Version2.Application
{

    public interface IDTRHeadAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditDTRHeadDTO product);
        Task Delete(int id);
        DTRHeadDTO Get(int id);
        Task<List<DTRHeadDTO>> GetAll();
        CreateorEditDTRHeadDTO createorEditDto(int id);

    }
    public class DTRHeadAppService : IDTRHeadAppService
    {
        private readonly IRepository<DTRHead> _DTRHeadRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public DTRHeadAppService(
            IRepository<DTRHead> DTRHeadRepository,
            IMapper mapper,
            IUnitofWork unitofWork,
            IEmployeeAppService employeeAppService)
        {
            _DTRHeadRepository = DTRHeadRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task CreateorEdit(CreateorEditDTRHeadDTO input)
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
        
        protected async Task Create(CreateorEditDTRHeadDTO input)
        {
            var messages = DTRHead.Create(input.Id, input.Startdate, input.Cutoffdate);
            if (messages.isFailed)
            {
                throw new System.Exception(messages.Message);
            }
            else
            {
                await _DTRHeadRepository.Add(messages.Value);
                await Complete();
            }
        }
        protected async Task Update(CreateorEditDTRHeadDTO input)
        {
            DTRHead _category = _DTRHeadRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _DTRHeadRepository.Update(_category);
            await Complete();
        }
        public DTRHeadDTO Get(int id)
        {
            DTRHead log = _DTRHeadRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
            var msgdto = _mapper.Map<DTRHeadDTO>(log);
            return msgdto;
        }
        public async Task Delete(int id)
        {
            var msg1 = _DTRHeadRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _DTRHeadRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<DTRHeadDTO>> GetAll()
        {
            var input = _DTRHeadRepository.GetAll();
            var map = _mapper.Map<List<DTRHeadDTO>>(input);
            return map;
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }
        CreateorEditDTRHeadDTO getEditDto(int id)
        {
            var input = Get(id);
            var createorEditDTRHeadDto = _mapper.Map<CreateorEditDTRHeadDTO>(input);
            return createorEditDTRHeadDto;
        }
        public CreateorEditDTRHeadDTO createorEditDto(int id)
        {
            CreateorEditDTRHeadDTO createorEditDTRHeadDto = new CreateorEditDTRHeadDTO(); 
            if (id > 0)
            {
                createorEditDTRHeadDto= getEditDto(id);
            }
            return createorEditDTRHeadDto;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Models;
using Version2.Data.Interface;
using Version2.Framework;
using AutoMapper;
using Version2.Data.Enum;

namespace Version2.Application
{

    public interface IDTRSummaryAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditDTRSummaryDto product);
        Task Delete(int id);
        Task DeleteDTR(int dtrid);
        DTRSummaryDto Get(int id);
        Task<List<DTRSummaryDto>> GetAll();
        CreateorEditDTRSummaryDto createorEditDto(int id);
        Task  SaveDTR(DTRDto[] dTRDtos, int DTRHeadId);
        Task<List<DTRDto>> GetAllDTR(int summaryid);
        Task<decimal> ComputeTotal(int summaryid);
        Task UpdateTotal(int summaryid);
    }
    public class DTRSummaryAppService : IDTRSummaryAppService
    {
        private readonly IRepository<DTRSummary> _DTRSummaryRepository;
        private readonly IDTRAppService _DTRAppService;

        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IEmployeeAppService _employeeAppService;
        public DTRSummaryAppService(IRepository<DTRSummary> DTRSummaryRepository,
            IMapper mapper,
            IUnitofWork unitofWork,
            IEmployeeAppService employeeAppService,
            IDTRAppService dTRAppService)
        {
            _DTRSummaryRepository = DTRSummaryRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
            this._employeeAppService = employeeAppService;
            _DTRAppService = dTRAppService;
        }

        public async Task CreateorEdit(CreateorEditDTRSummaryDto input)
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
       
        protected async Task Create(CreateorEditDTRSummaryDto input)
        {
            var employee = _employeeAppService.Get(new GetEmployee() { EmpCode = input.EmployeeId });
            var messages = DTRSummary.Create(input.DTRHeadId,input.EmployeeId);
            if (messages.isFailed)
            {
                throw new System.Exception(messages.Message);
            }
            else
            {
                await _DTRSummaryRepository.Add(messages.Value);
                await Complete();
            }
        }
        protected async Task Update(CreateorEditDTRSummaryDto input)
        {
            DTRSummary _category = _DTRSummaryRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _DTRSummaryRepository.Update(_category);
            
        }
        public DTRSummaryDto Get(int id)
        {
            DTRSummary log = _DTRSummaryRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
            var msgdto = _mapper.Map<DTRSummaryDto>(log);
            return msgdto;
        }

        public async Task DeleteDTR(int dtrid)
        {
            var dto = _DTRAppService.createorEditDto(dtrid);
            dto.DTRSummaryId = 0;
            await _DTRAppService.CreateorEdit(dto);
            await _DTRAppService.SaveChangesAsync();

            
        }

        public async Task SaveDTR(DTRDto[] dTRDtos, int DTRHeadId)
        {
            foreach (DTRDto dTRDto in dTRDtos)
            {
                if (dTRDto.isChecked)
                {
                    SaveDTR:
                    var dtr = _DTRAppService.Get(dTRDto.Id);
                    var summary = _DTRSummaryRepository.GetAll().Where(m => m.DTRHeadId == DTRHeadId && m.EmployeeId == dtr.EmployeeId);
                    if (summary.Count() > 0)
                    {
                        dtr.DTRSummaryId = summary.First().Id;
                        var dto = _mapper.Map<CreateorEditDTRDto>(dtr);
                        await _DTRAppService.CreateorEdit(dto);
                        await UpdateTotal(dtr.DTRSummaryId);
                    }
                    else
                    {
                        var dtrsummary= DTRSummary.Create(DTRHeadId, dtr.EmployeeId).Value;
                        await _DTRSummaryRepository.AddGetId(dtrsummary);
                        goto SaveDTR;
                    }
                }
            }
            await Complete();
        }
        public async Task Delete(int id)
        {
            var msg1 = _DTRSummaryRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _DTRSummaryRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<DTRSummaryDto>> GetAll()
        {
            var input = _DTRSummaryRepository.GetAll();
            var map = _mapper.Map<List<DTRSummaryDto>>(input);
            return map;
        }
        public async Task<decimal>  ComputeTotal(int summaryid)
        {
            decimal total = 0;
            var dtrs = await GetAllDTR(summaryid);
            total= dtrs.Sum(m => m.NetPay);
            return total;
        }
        public async Task UpdateTotal(int summaryid)
        {
            decimal total = await ComputeTotal(summaryid);
            var creatoredit = createorEditDto(summaryid);
            creatoredit.Amount = total;
            await CreateorEdit(creatoredit);
        }
        public async Task<List<DTRDto>> GetAllDTR(int summaryid)
        {
            var input =await _DTRAppService.GetAll();
            var dtrs = input.Where(m => m.DTRSummaryId == summaryid);
            return dtrs.ToList();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }
        CreateorEditDTRSummaryDto getEditDto(int id)
        {
            var input = Get(id);
            var createorEditDTRSummaryDto = _mapper.Map<CreateorEditDTRSummaryDto>(input);
            return createorEditDTRSummaryDto;
        }
        public CreateorEditDTRSummaryDto createorEditDto(int id)
        {
            CreateorEditDTRSummaryDto createorEditDTRSummaryDto = new CreateorEditDTRSummaryDto(); 
            if (id > 0)
            {
                createorEditDTRSummaryDto= getEditDto(id);
            }
            return createorEditDTRSummaryDto;
        }

    }
}

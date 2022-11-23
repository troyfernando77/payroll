using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Framework;
using Version2.Data.Models;
using Version2.Data.Interface;

namespace Version2.Application
{
   
    public interface IRulessAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditRulesDto product);
        Task Delete(int id);
        RulesDto Get(int id);
        Task<List<RulesDto>> GetAll(string category);
    }
    public class RulesAppService : IRulessAppService
    {
        private readonly IRepository<Rule> _RulesRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public RulesAppService(IRepository<Rule> RulesRepository,
            IMapper mapper,
            IUnitofWork unitofWork)
        {
            _RulesRepository = RulesRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task CreateorEdit(CreateorEditRulesDto input)
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
        protected async Task Create(CreateorEditRulesDto input)
        {
            var messages = _mapper.Map<Rule>(input);
            await _RulesRepository.Add(messages);
            await Complete();
        }
        public CreateorEditRulesDto createorEditRulesDto(int id, string category, int itemno)
        {
            CreateorEditRulesDto createorEditMessagesDto = new CreateorEditRulesDto()
            {
                Category = category,
                ItemNo = itemno 
            };
            if (id > 0)
            {
                var msg = Get(id);
                createorEditMessagesDto = _mapper.Map<CreateorEditRulesDto>(msg);

            }
            return createorEditMessagesDto;
        }
        protected async Task Update(CreateorEditRulesDto input)
        {
            Rule _category = _RulesRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _RulesRepository.Update(_category);
            await Complete();
        }
        public RulesDto Get(int id)
        {
            Rule log = _RulesRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
            var msgdto = _mapper.Map<RulesDto>(log);
            return msgdto;
        }
        public async Task Delete(int id)
        {
            var msg1 = _RulesRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();

            if (msg1 == null)

                return;
            await _RulesRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<RulesDto>> GetAll(string category)
        {
            var categorydtolist = from a in _RulesRepository.GetAll()
                                  where a.Category == category
                                  select new RulesDto()
                                  {
                                      Id = a.Id,
                                      RuleName = a.RuleName,
                                      RuleTarget = a.RuleTarget,
                                      Category = a.Category,
                                      Priority = a.Priority,
                                      Status = a.Status,
                                      ItemNo = a.ItemNo
                                  };
            return categorydtolist.ToList();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }

    }
}

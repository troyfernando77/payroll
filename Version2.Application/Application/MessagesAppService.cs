using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Interface;
using Version2.Data.Models;
using Version2.Framework;

namespace Version2.Application
{
    public interface IMessagesAppService : ICompleteWork
    {
        Task CreateorEdit(CreateorEditMessagesDto product);
        Task Delete(int id);
        MessagesDto Get(int id);
        Task<List<MessagesDto>> GetAll();
    }
    public class MessagesAppService : IMessagesAppService
    {
        private readonly IRepository<Messages> _MessagesRepository;
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public MessagesAppService(IRepository<Messages> MessagesRepository,
            IMapper mapper,
            IUnitofWork unitofWork)
        {
            _MessagesRepository = MessagesRepository;
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task CreateorEdit(CreateorEditMessagesDto input)
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
        protected async Task Create(CreateorEditMessagesDto input)
        {
            var messages = _mapper.Map<Messages>(input);
            await _MessagesRepository.Add(messages);
            await Complete();
        }
        protected async Task Update(CreateorEditMessagesDto input)
        {
            Messages _category = _MessagesRepository.GetAll().Where(m => m.Id == input.Id).FirstOrDefault();
            _mapper.Map(input, _category);
            await _MessagesRepository.Update(_category);
            await Complete();
        }
        public MessagesDto Get(int id)
        {
            Messages log = _MessagesRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
            var msgdto = _mapper.Map<MessagesDto>(log);
            return msgdto;
        }
        public async Task Delete(int id)
        {
            var msg1 =  _MessagesRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();
           
            if (msg1 == null)

                return;
            await _MessagesRepository.Delete(msg1);
            await Complete();

        }
        public async Task<List<MessagesDto>> GetAll()
        {
            var categorydtolist = from a in _MessagesRepository.GetAll()
                                  select new MessagesDto()
                                  {
                                      Id = a.Id,
                                      Message = a.Message,
                                      MessageCode = a.MessageCode
                                  };
            return categorydtolist.ToList();
        }
        public async Task Complete()
        {
            await _unitofWork.Complete();
        }

    }
}

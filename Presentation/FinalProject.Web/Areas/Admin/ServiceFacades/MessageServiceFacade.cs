
namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class MessageServiceFacade
    {
        private readonly IMessageService _messageService;

        public MessageServiceFacade(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<ICollection<MessageViewDTO>> GetAllAsync()
        {
            return await _messageService.GetAllAsync();
        }

        public async Task<MessageUpdateDTO> GetByIdAsync(int id)
        {
            return await _messageService.GetByIdAsync(id);
        }

        public async Task<int> AddAsync(MessageAddDTO addModel)
        {
            return await _messageService.AddAsync(addModel);
        }

        public async Task<int> UpdateAsync(MessageUpdateDTO updateModel)
        {
            return await _messageService.UpdateAsync(updateModel);
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await _messageService.DeleteAsync(id);
        }

        public MessageAddDTO Initialize()
        {
            return new MessageAddDTO();
        }
    }
}

using FinalProject.Application.DTOs.General;

namespace FinalProject.Infrastructure.Services
{
    public class MessageService : CoreService<Message, MessageViewDTO, MessageAddDTO, MessageUpdateDTO, BaseDeletedDTO>, IMessageService
    {
        public MessageService(IMessageRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
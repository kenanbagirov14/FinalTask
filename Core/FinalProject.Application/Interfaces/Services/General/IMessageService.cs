using FinalProject.Application.DTOs.General;


namespace FinalProject.Application.Interfaces.Services
{
    public interface IMessageService : ICoreService<Message,MessageViewDTO,MessageAddDTO,MessageUpdateDTO,BaseDeletedDTO>
    {
    }
}

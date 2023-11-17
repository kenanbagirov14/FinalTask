
namespace FinalProject.Application.DTOs.General
{
    public class MessageViewDTO : BaseDTO
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsView { get; set; }
    }
}

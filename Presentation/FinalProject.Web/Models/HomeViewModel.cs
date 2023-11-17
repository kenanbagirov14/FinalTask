namespace FinalProject.Web.Models
{
    public class HomeViewModel
    {
        public SettingAddDTO Setting { get; set; }
        public ICollection<TeacherViewDTO> Teachers { get; set; }
    }
}

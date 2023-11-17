
using FinalProject.Application.Extensions;

namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class StudentServiceFacade
    {
        private readonly IStudentService _studentService;
        private readonly IWebHostEnvironment _env;

        public StudentServiceFacade(IStudentService studentService, IWebHostEnvironment env)
        {
            _studentService = studentService;
            _env = env;
        }

        public async Task<ICollection<StudentViewDTO>> GetAllAsync()
        {
            return await _studentService.GetAllAsync();
        }

        public async Task<StudentUpdateDTO> GetByIdAsync(int id)
        {
            return await _studentService.GetByIdAsync(id);
        }

        public async Task<int> AddAsync(StudentAddDTO addModel)
        {
            if (addModel.File != null)
            {
                var filePaths = await addModel.File.SaveFileAsync(_env);
                addModel.ImagaPath = filePaths.Item1;
                addModel.ImagaFullPath = filePaths.Item2;
            }

            return await _studentService.AddAsync(addModel);
        }

        public async Task<int> UpdateAsync(StudentUpdateDTO updateModel)
        {
            if (updateModel.File != null)
            {
                var filePaths = await updateModel.File.SaveFileAsync(_env);
                updateModel.ImagaPath = filePaths.Item1;
                updateModel.ImagaFullPath = filePaths.Item2;
            }
            return await _studentService.UpdateAsync(updateModel);
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await _studentService.DeleteAsync(id);
        }

        public StudentAddDTO Initialize()
        {
            return new StudentAddDTO();
        }
    }
}

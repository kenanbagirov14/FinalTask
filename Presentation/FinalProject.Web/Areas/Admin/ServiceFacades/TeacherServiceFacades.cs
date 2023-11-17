



using FinalProject.Application.Extensions;

namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class TeacherServiceFacade
    {
        private readonly ITeacherService _serviceFacade;
        private readonly IWebHostEnvironment _env;

        public TeacherServiceFacade(ITeacherService serviceFacade, IWebHostEnvironment env)
        {
            _serviceFacade = serviceFacade;
            _env = env;
        }

        public async Task<ICollection<TeacherViewDTO>> GetAllAsync()
        {
            return await _serviceFacade.GetAllAsync();
        }

        public async Task<TeacherUpdateDTO> GetByIdAsync(int id)
        {
            return await _serviceFacade.GetByIdAsync(id);
        }

        public async Task<int> AddAsync(TeacherAddDTO addModel)
        {
            if (addModel.File != null)
            {
               var filePaths = await addModel.File.SaveFileAsync(_env);
               addModel.ImagaPath = filePaths.Item1;
               addModel.ImagaFullPath = filePaths.Item2;
            }
            if (addModel.FrontImage != null)
            {
                var frontImage = await addModel.FrontImage.SaveFileAsync(_env);
                addModel.FrontImagaPath = frontImage.Item1;
                addModel.FrontImagaFullPath = frontImage.Item2;
            }
            return await _serviceFacade.AddAsync(addModel);
        }

        public async Task<int> UpdateAsync(TeacherUpdateDTO updateModel)
        {
            if (updateModel.File != null)
            {
                var filePaths = await updateModel.File.SaveFileAsync(_env);
                updateModel.ImagaPath = filePaths.Item1;
                updateModel.ImagaFullPath = filePaths.Item2;
            }
            if (updateModel.FrontImage != null)
            {
                var frontImage = await updateModel.FrontImage.SaveFileAsync(_env);
                updateModel.FrontImagaPath = frontImage.Item1;
                updateModel.FrontImagaFullPath = frontImage.Item2;
            }
            return await _serviceFacade.UpdateAsync(updateModel);
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await _serviceFacade.DeleteAsync(id);
        }

        public TeacherAddDTO Initialize()
        {
            return new TeacherAddDTO();
        }
    }
}

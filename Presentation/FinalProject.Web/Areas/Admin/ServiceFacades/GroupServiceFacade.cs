namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class GroupServiceFacade
    {
        private readonly IGroupService _service;
        private readonly CommonServiceFacade _commonServiceFacade;

        public GroupServiceFacade(IGroupService service, CommonServiceFacade commonServiceFacade)
        {
            _service = service;
            _commonServiceFacade = commonServiceFacade;
        }

        public async Task<ICollection<GroupViewDTO>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<GroupUpdateDTO> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        public async Task<int> AddAsync(GroupAddDTO addModel)
        {
            return await _service.AddAsync(addModel);
        }

        public async Task<int> UpdateAsync(GroupUpdateDTO updateModel)
        {
            return await _service.UpdateAsync(updateModel);
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        public  GroupAddDTO Initialize()
        {
            var group = new GroupAddDTO();
            return group;
        }
    }
}

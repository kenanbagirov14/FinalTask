using FinalProject.Application.DTOs.Identity;
using FinalProject.Application.DTOs.Identity.User;
using FinalProject.Application.Interfaces.Repositories.Identity;
using FinalProject.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
using System.Text;

namespace FinalProject.Infrastructure.Services
{
    public class UserService : CoreService<User, UserViewDTO, UserAddDTO, UserUpdateDTO, BaseDeletedDTO>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository, IMapper mapper, IUserRepository userRepository) : base(repository, mapper)
        {
            _userRepository = userRepository;
        }

        public override Task<int> AddAsync(UserAddDTO createModel)
        {
            StringBuilder sb = new StringBuilder();

            if (createModel == null)
                return Task.FromResult<int>(0);

            if (CheckUserName(createModel.UserName))
                return Task.FromResult<int>(2);

            if (createModel.Password != createModel.PasswordConfirm)
                return Task.FromResult<int>(3);

            var userModel = _mapper.Map<User>(createModel);
            userModel.HashPassword = createModel.Password;

            return _repository.AddAsync(userModel);
        }

        public UserViewDTO AuthenticateUser(Login user)
        {
            throw new NotImplementedException();
        }

        public bool CheckUserName(string UserName)
        {
            return _userRepository.Users.Any(x => x.UserName == UserName);
        }

        public async Task<UserViewDTO> FindUserByLoginAsync(Login user)
        {
            var findUser = await _userRepository.Users.FirstOrDefaultAsync(f=>f.UserName == user.UserName && f.HashPassword==user.Password);
            if (findUser!=null)
            {
                return _mapper.Map<UserViewDTO>(findUser);
            }

            return null;
        }
    }
}
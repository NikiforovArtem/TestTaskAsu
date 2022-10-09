using AsuTask.Common;
using AsuTask.DAL.Repositories;

namespace AsuTask.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IUserRepository _userRepository;

        public UserService(IJwtTokenService jwtTokenService, IUserRepository userRepository)
        {
            _jwtTokenService = jwtTokenService;
            _userRepository = userRepository;
        }

        public async Task<string> Authenticate(AuthenticateRequestModel requestModel)
        {
            var user = await _userRepository.FindUserByLoginAndPasswordAsync(requestModel.Login, requestModel.Password);

            if (user == null) 
            {
                return null;
            } 

            return _jwtTokenService.GenerateToken();
        }
    }
}

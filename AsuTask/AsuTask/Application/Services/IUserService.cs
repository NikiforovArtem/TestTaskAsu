using AsuTask.Common;

namespace AsuTask.Application.Services
{
    public interface IUserService
    {
        Task<string> Authenticate(AuthenticateRequestModel requestModel);
    }
}

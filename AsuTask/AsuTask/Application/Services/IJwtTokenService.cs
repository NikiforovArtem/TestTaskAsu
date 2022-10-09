using AsuTask.Common;

namespace AsuTask.Application.Services
{
    public interface IJwtTokenService
    {
        string GenerateToken();
    }
}

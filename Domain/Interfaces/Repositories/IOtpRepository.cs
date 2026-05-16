using Domain.Entities;
using Domain.Enums;

namespace Domain.Interfaces.Repositories
{
    public interface IOtpRepository:IBaseRepository<OtpCode>
    {
        Task<OtpCode?> GetValidOtpAsync(Guid userId,string code,OtpType type);
        Task    InvalidateUserOtpsAsync(Guid userId, OtpType type);
    }
}

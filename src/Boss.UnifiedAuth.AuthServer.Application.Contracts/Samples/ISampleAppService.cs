using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Boss.UnifiedAuth.AuthServer.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}

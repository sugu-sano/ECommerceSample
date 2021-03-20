using Microsoft.AspNetCore.Mvc;

namespace ECommerceSample.WebApi.Controllers
{
    /// <summary>
    /// APIコントローラー規定クラスVersion1.0
    /// </summary>
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class ApiControllerBaseV1 : ControllerBase { }
}

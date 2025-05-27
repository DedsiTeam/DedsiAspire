using Dedsi.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace DedsiServiceA;

[ApiController]
[Area(DedsiServiceADomainConsts.ApplicationName)]
[Route("api/DedsiServiceA/[controller]/[action]")]
[ApiExplorerSettings(GroupName = DedsiServiceADomainConsts.ApplicationName)]
public abstract class DedsiServiceAController : DedsiControllerBase;
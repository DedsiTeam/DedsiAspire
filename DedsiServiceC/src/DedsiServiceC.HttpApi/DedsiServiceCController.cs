using Dedsi.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace DedsiServiceC;

[ApiController]
[Area(DedsiServiceCDomainConsts.ApplicationName)]
[Route("api/DedsiServiceC/[controller]/[action]")]
[ApiExplorerSettings(GroupName = DedsiServiceCDomainConsts.ApplicationName)]
public abstract class DedsiServiceCController : DedsiControllerBase;
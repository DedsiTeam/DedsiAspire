using Dedsi.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace DedsiServiceB;

[ApiController]
[Area(DedsiServiceBDomainConsts.ApplicationName)]
[Route("api/DedsiServiceB/[controller]/[action]")]
[ApiExplorerSettings(GroupName = DedsiServiceBDomainConsts.ApplicationName)]
public abstract class DedsiServiceBController : DedsiControllerBase;
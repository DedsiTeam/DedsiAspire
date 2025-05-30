using Dedsi.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace DedsiLogs;

[ApiController]
[Area(DedsiLogsDomainConsts.ApplicationName)]
[Route("api/DedsiLog/[controller]/[action]")]
[ApiExplorerSettings(GroupName = DedsiLogsDomainConsts.ApplicationName)]
public abstract class DedsiLogsController : DedsiControllerBase;
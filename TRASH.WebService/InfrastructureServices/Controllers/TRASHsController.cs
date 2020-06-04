using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TRASH.DomainObjects;
using TRASH.ApplicationServices.GetYardAreaListUseCase;
using TRASH.InfrastructureServices.Presenters;

namespace TRASH.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TRASHsController : ControllerBase
    {
        private readonly ILogger<TRASHsController> _logger;
        private readonly IGetTRASHListUseCase _getTRASHListUseCase;

        public TRASHsController(ILogger<TRASHsController> logger,
                                IGetTRASHListUseCase getTRASHListUseCase)
        {
            _logger = logger;
            _getTRASHListUseCase = getTRASHListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTRASHs()
        {
            var presenter = new TRASHListPresenter();
            await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateAllTRASHsRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{trashId}")]
        public async Task<ActionResult> GetTRASH(long trashId)
        {
            var presenter = new TRASHListPresenter();
            await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateTRASHRequest(trashId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("yardarea/{yardarea}")]
        public async Task<ActionResult> GetMetroLineTRASHs(string YardArea)
        {
            var presenter = new TRASHListPresenter();
            await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateTRASHsRequest(YardArea), presenter);
            return presenter.ContentResult;
        }
    }
}

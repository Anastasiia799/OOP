using System.Threading.Tasks;
using System.Collections.Generic;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using TRASH.ApplicationServices.Ports;

namespace TRASH.ApplicationServices.GetYardAreaListUseCase
{
    public class GetTRASHListUseCase : IGetTRASHListUseCase
    {
        private readonly IReadOnlyTRASHRepository _readOnlyTRASHRepository;

        public GetTRASHListUseCase(IReadOnlyTRASHRepository readOnlyTRASHRepository) 
            => _readOnlyTRASHRepository = readOnlyTRASHRepository;
        
        public async Task<bool> Handle(GetTRASHListUseCaseRequest request, IOutputPort<GetTRASHListUseCaseResponse> outputPort)
        {
            IEnumerable<trash> trashs = null;
            if (request.TRASHId != null)
            {
                var trash = await _readOnlyTRASHRepository.GetTRASH(request.TRASHId.Value);
                trashs = (trash != null) ? new List<trash>() { trash } : new List<trash>();
                
            }
            else if (request.YardArea != null)
            {
                trashs = await _readOnlyTRASHRepository.QueryTRASHs(new YardAreaCriteria(request.YardArea));
            }
            else
            {
                trashs = await _readOnlyTRASHRepository.GetAllTRASHs();
            }
            outputPort.Handle(new GetTRASHListUseCaseResponse(trashs));
            return true;
        }
    }
}

using TRASH.DomainObjects;
using TRASH.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRASH.ApplicationServices.GetYardAreaListUseCase
{
    public class GetTRASHListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<trash> TRASHs { get; }

        public GetTRASHListUseCaseResponse(IEnumerable<trash> trashs) => TRASHs = trashs;
    }
}

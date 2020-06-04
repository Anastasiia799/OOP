using TRASH.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRASH.ApplicationServices.GetYardAreaListUseCase
{
    public class GetTRASHListUseCaseRequest : IUseCaseRequest<GetTRASHListUseCaseResponse>
    {
        public string YardArea { get; private set; }
        public long? TRASHId { get; private set; }

        private GetTRASHListUseCaseRequest()
        { }

        public static GetTRASHListUseCaseRequest CreateAllTRASHsRequest()
        {
            return new GetTRASHListUseCaseRequest();
        }

        public static GetTRASHListUseCaseRequest CreateTRASHRequest(long trashId)
        {
            return new GetTRASHListUseCaseRequest() { TRASHId = trashId };
        }
        public static GetTRASHListUseCaseRequest CreateTRASHsRequest(string yardarea)
        {
            return new GetTRASHListUseCaseRequest() { YardArea = yardarea };
        }
    }
}

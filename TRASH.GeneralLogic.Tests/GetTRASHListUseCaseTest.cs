using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using TRASH.ApplicationServices.GetYardAreaListUseCase;
using System.Linq.Expressions;
using TRASH.ApplicationServices.Ports;
using TRASH.DomainObjects.Ports;
using TRASH.ApplicationServices.Repositories;

namespace TRASH.WebService.Core.Tests
{
    public class GetTRASHListUseCaseTest
    {
        private InMemoryTRASHRepository CreateTRASHRepository()
        {
            var repo = new InMemoryTRASHRepository(new List<trash> {
                new trash { Id = 1, YardArea = "контейнерная площадка", YardName = "Контейнерная площадка № 1987645"},
                new trash { Id = 2, YardArea = "контейнерная площадка", YardName = "Контейнерная площадка № 1987649"},
                new trash { Id = 3, YardArea = "контейнерная площадка", YardName = "Контейнерная площадка № 1987653"},
                new trash { Id = 4, YardArea = "контейнерная площадка", YardName = "Контейнерная площадка № 1987654"},
            });
            return repo;
        }
        [Fact]
        public void TestGetAllTRASH()
        {
            var useCase = new GetTRASHListUseCase(CreateTRASHRepository());
            var outputPort = new OutputPort();
                        
            Assert.True(useCase.Handle(GetTRASHListUseCaseRequest.CreateAllTRASHsRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.TRASHs.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.TRASHs.Select(mp => mp.Id));
        }

        [Fact]
        public void TestGetAllTRASHsFromEmptyRepository()
        {
            var useCase = new GetTRASHListUseCase(new InMemoryTRASHRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetTRASHListUseCaseRequest.CreateAllTRASHsRequest(), outputPort).Result);
            Assert.Empty(outputPort.TRASHs);
        }

        [Fact]
        public void TestGetTRASH()
        {
            var useCase = new GetTRASHListUseCase(CreateTRASHRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetTRASHListUseCaseRequest.CreateTRASHRequest(2), outputPort).Result);
            Assert.Single(outputPort.TRASHs, pn => 2 == pn.Id);
        }

        [Fact]
        public void TestTryGetNotExistingTRASH()
        {
            var useCase = new GetTRASHListUseCase(CreateTRASHRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetTRASHListUseCaseRequest.CreateTRASHRequest(999), outputPort).Result);
            Assert.Empty(outputPort.TRASHs);
        }
      
    }

    class OutputPort : IOutputPort<GetTRASHListUseCaseResponse>
    {
        public IEnumerable<trash> TRASHs { get; private set; }

        public void Handle(GetTRASHListUseCaseResponse response)
        {
            TRASHs = response.TRASHs;
        }
    }
}

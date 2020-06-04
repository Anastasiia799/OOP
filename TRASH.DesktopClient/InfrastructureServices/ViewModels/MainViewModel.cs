using TRASH.ApplicationServices.GetYardAreaListUseCase;
using TRASH.ApplicationServices.Ports;
using TRASH.DomainObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace TRASH.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IGetTRASHListUseCase _getTRASHListUseCase;

        public MainViewModel(IGetTRASHListUseCase getTRASHListUseCase)
            => _getTRASHListUseCase = getTRASHListUseCase;

        private Task<bool> _loadingTask;
        private trash _currentTRASH;
        private ObservableCollection<trash> _trashs;

        public event PropertyChangedEventHandler PropertyChanged;

        public trash CurrentTRASH
        {
            get => _currentTRASH; 
            set
            {
                if (_currentTRASH != value)
                {
                    _currentTRASH = value;

                    OnPropertyChanged(nameof(CurrentTRASH));
                }
            }
        }

        private async Task<bool> LoadTRASHs()
        {
            var outputPort = new OutputPort();
            bool result = await _getTRASHListUseCase.Handle(GetTRASHListUseCaseRequest.CreateAllTRASHsRequest(), outputPort);
            if (result)
            {
                TRASHs = new ObservableCollection<trash>(outputPort.TRASHs);
            }
            return result;
        }

        public ObservableCollection<trash> TRASHs
        {
            get 
            {
                if (_loadingTask == null)
                {
                    _loadingTask = LoadTRASHs();
                }
                
                return _trashs; 
            }
            set
            {
                if (_trashs != value)
                {
                    _trashs = value;
                    OnPropertyChanged(nameof(TRASHs));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class OutputPort : IOutputPort<GetTRASHListUseCaseResponse>
        {
            public IEnumerable<trash> TRASHs { get; private set; }

            public void Handle(GetTRASHListUseCaseResponse response)
            {
                if (response.Success)
                {
                    TRASHs = new ObservableCollection<trash>(response.TRASHs);
                }
            }
        }
    }
}

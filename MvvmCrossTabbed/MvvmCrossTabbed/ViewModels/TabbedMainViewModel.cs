using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossTabbed.ViewModels
{
    public class TabbedMainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public TabbedMainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        }

        private IMvxAsyncCommand showInitialViewModelsCommand;
        public IMvxAsyncCommand ShowInitialViewModelsCommand
        {
            get
            {
                return showInitialViewModelsCommand ?? (showInitialViewModelsCommand = new MvxAsyncCommand(async () => 
                {
                    var tasks = new List<Task>();
                    tasks.Add(_navigationService.Navigate<Tab1ViewModel>());
                    tasks.Add(_navigationService.Navigate<Tab2ViewModel>());
                    await Task.WhenAll(tasks);
                }));
            }
        }

        private int _itemIndex;

        public int ItemIndex
        {
            get { return _itemIndex; }
            set
            {
                if (_itemIndex == value) return;
                _itemIndex = value;
                Debug.WriteLine("Tab item changed to {0}", _itemIndex.ToString());
                //MvxTrace.Trace("Tab item changed to {0}", _itemIndex.ToString());
                RaisePropertyChanged(() => ItemIndex);
            }
        }
    }
}

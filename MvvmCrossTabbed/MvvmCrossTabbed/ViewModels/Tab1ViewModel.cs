using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTabbed.ViewModels
{
    public class Tab1ViewModel : MvxViewModel
    {
        IMvxNavigationService navigationService;

        public Tab1ViewModel(IMvxNavigationService _navigationService)
        {
            VMTitle = "Title Tab 1!";
            navigationService = _navigationService;
        }

        private string vmTitle;
        public string VMTitle
        {
            get { return vmTitle; }
            set { vmTitle = value; RaisePropertyChanged(); }
        }

        private IMvxCommand navigateTo11Command;
        public IMvxCommand NavigateTo11Command
        {
            get
            {
                return navigateTo11Command ?? (navigateTo11Command = new MvxCommand(async () => 
                {
                    Page12ViewModel vm = new Page12ViewModel();
                    await navigationService.Navigate(vm);
                }));
            }
        }


    }
}

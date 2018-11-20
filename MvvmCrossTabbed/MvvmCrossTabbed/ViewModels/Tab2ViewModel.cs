using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTabbed.ViewModels
{
    public class Tab2ViewModel : MvxViewModel
    {
        IMvxNavigationService navigationService;

        public Tab2ViewModel(IMvxNavigationService _navigationService)
        {
            VMTitle = "Title Tab 2!";
            navigationService = _navigationService;
        }

        private string vmTitle;
        public string VMTitle
        {
            get { return vmTitle; }
            set { vmTitle = value; }
        }

        private IMvxCommand navigateTo11Command;
        public IMvxCommand NavigateTo11Command
        {
            get
            {
                return navigateTo11Command ?? (navigateTo11Command = new MvxCommand(async () =>
                {
                    await navigationService.Navigate(typeof(Page21ViewModel));
                }));
            }
        }
    }
}

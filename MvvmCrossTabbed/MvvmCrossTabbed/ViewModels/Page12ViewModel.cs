using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTabbed.ViewModels
{
    public class Page12ViewModel : MvxViewModel
    {
        public Page12ViewModel()
        {
            Page12Title = "PAGE 12 TITLE";
        }

        private string page12Title;
        public string Page12Title
        {
            get { return page12Title; }
            set { page12Title = value; RaisePropertyChanged(); }
        }
    }
}

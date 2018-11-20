using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTabbed.ViewModels
{
    public class Page21ViewModel : MvxViewModel
    {
        public Page21ViewModel()
        {
            Page21Title = "PAGE 21 TITLE";
        }

        private string page21Title;
        public string Page21Title
        {
            get { return page21Title; }
            set { page21Title = value; RaisePropertyChanged(); }
        }

    }
}

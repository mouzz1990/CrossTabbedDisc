using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCrossTabbed.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTabbed
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            
            RegisterAppStart<TabbedMainViewModel>();
        }
    }
}

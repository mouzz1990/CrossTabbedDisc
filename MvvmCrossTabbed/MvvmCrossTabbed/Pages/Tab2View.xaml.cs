using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvvmCrossTabbed.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmCrossTabbed.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxTabbedPagePresentation(TabbedPosition.Tab, WrapInNavigationPage = true, Title = "Tab 2", Icon = "Icon.png")]
    public partial class Tab2View : MvxContentPage<Tab2ViewModel>
    {
		public Tab2View ()
		{
			InitializeComponent ();
		}
	}
}
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
    [MvxContentPagePresentation()]
    public partial class Page12 : MvxContentPage<Page12ViewModel>
	{
		public Page12 ()
		{
			InitializeComponent ();
		}
	}
}
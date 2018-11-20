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
	public partial class HomeView : MvxContentPage<HomeViewModel>
    {
		public HomeView ()
		{
			InitializeComponent ();
		}
	}
}
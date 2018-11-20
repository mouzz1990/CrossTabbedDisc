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
	public partial class Page21 : MvxContentPage<Page21ViewModel>
    {
		public Page21 ()
		{
			InitializeComponent ();
		}
	}
}
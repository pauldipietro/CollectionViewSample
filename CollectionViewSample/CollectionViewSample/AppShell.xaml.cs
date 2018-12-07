using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        void Handle_Navigating(object sender, Xamarin.Forms.ShellNavigatingEventArgs e)
        {
            if ((Device.RuntimePlatform == "iOS") && e.Target.Location.AbsolutePath.IndexOf("carousel") > -1)
            {
                (App.Current.MainPage as Shell).DisplayAlert(
                    title: "Not Yet!",
                    message: "iOS doesn't yet support CarouselView.",
                    cancel: "Okay"
                );
                e.Cancel();
            }
        }
    }
}
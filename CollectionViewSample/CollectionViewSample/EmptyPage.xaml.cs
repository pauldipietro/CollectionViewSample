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
    public partial class EmptyPage : ContentPage
    {
        public List<string> People { get; set; }
        public EmptyPage()
        {
            InitializeComponent();
        }
    }
}
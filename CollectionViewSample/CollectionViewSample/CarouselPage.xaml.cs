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
    public partial class CarouselPage : ContentPage
    {
        public List<string> People { get; set; }
        public CarouselPage()
        {
            InitializeComponent();
            People = new List<string>
            {
                "Alan",
                "Betty",
                "Charles",
                "David",
                "Edward",
                "Francis",
                "Gary",
                "Helen",
                "Ivan",
                "Joel",
                "Kelly",
                "Larry",
                "Mary",
                "Nancy",
                "Olivia",
                "Peter",
                "Quincy",
                "Robert",
                "Stephen",
                "Timothy",
                "Ursula",
                "Vincent",
                "William",
                "Xavier",
                "Yvonne",
                "Zack"
            };
            CV.BindingContext = this;
        }

        void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CV.ScrollTo((int)Math.Floor(e.NewValue));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewSample
{
    public partial class BasicListPage : ContentPage
    {
        public List<string> People { get; set; }
        public BasicListPage()
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
            CV.ItemsLayout = new ListItemsLayout(ItemsLayoutOrientation.Vertical); // Vertical is default
        }
    }
}
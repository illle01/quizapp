using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace quizapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Final_page : ContentPage
    {
        public Final_page()
        {
            InitializeComponent();


            ScoreLabel.Text = "Total poängen är" + " " + pointsum.total + " " + "Va glad du fick iallafall ett rätt";

        }
    }
}
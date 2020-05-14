using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace quizapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class question4 : ContentPage
    {
        public question4()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Final_page());
            pointsum.total += 1;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Final_page());
            pointsum.total += 1;
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Final_page());
            pointsum.total += 1;
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Final_page());
            pointsum.total += 1;

        }
    }
}
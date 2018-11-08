using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyClassLibrary;

namespace XamarinFormCallFsharp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var text = NameEntry.Text;
            var helloText = Say.hello(text);
            DisplayAlert("call F#", helloText, "OK");
        }
    }
}

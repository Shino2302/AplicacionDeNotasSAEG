using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplicacionDeNotasSAEG.Views;


namespace AplicacionDeNotasSAEG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TusNotas();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

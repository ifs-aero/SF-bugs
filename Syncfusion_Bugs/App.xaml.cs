using System;
using Syncfusion.Licensing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syncfusion_Bugs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            SyncfusionLicenseProvider.RegisterLicense(
               "NDgwMjQ0QDMxMzkyZTMyMmUzMGxmbHIxaHVlUThCT2JLcDRiMVM0a1Z0cEtQUnJ4RlFENEN5djdvNWZLcDQ9");

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

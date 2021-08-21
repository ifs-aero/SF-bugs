using Syncfusion_Bugs.Bugs;
using Xamarin.Forms;

namespace Syncfusion_Bugs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void PDFBug_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Bug1_PDFPageNumber_Page());
        }
        async void Keyboard_Return_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Bug2_SFControlReturnType_Page());
        }

    }
}

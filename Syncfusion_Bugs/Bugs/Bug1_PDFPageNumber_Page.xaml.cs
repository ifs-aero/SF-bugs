using System.Diagnostics;
using System.Reflection;
using Xamarin.Forms;

namespace Syncfusion_Bugs.Bugs
{
    public partial class Bug1_PDFPageNumber_Page : ContentPage
    {
        public class PDFViewModel : Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
        {
            private int _pageNumber;
            public int PageNumber
            {
                get => _pageNumber;
                set
                {
                    SetProperty(ref _pageNumber, value);
                    Debug.Print($"Property PageNumber Changed ==> {value}");
                }
            }
        }

        public Bug1_PDFPageNumber_Page()
        {
            InitializeComponent();
        }
        PDFViewModel vm;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm = new PDFViewModel();
            this.BindingContext = vm;
            var m_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("Syncfusion_Bugs.Assets.Sample.pdf");
            sfPdfViewer.InputFileStream = m_pdfDocumentStream;
        }

        async void sfPdfViewer_PageChanged(System.Object sender, Syncfusion.SfPdfViewer.XForms.PageChangedEventArgs args)
        {
            Debug.Print($"PageNumber:{args.PageNumber} , OldPageNumber:{args.OldPageNumber},  NewPageNumber:{args.NewPageNumber}");
        }

        async void sfPdfViewer_DocumentLoaded(System.Object sender, System.EventArgs e)
        {
            Debug.Print("Document Loaded and Setting PageNumber to 10");
            vm.PageNumber = 10;
        }


        async void back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}

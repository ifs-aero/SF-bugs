
using System.Collections.Generic;
using Xamarin.Forms;

namespace Syncfusion_Bugs.Bugs
{
    public partial class Bug2_SFControlReturnType_Page : ContentPage
    {
        public class ItemsViewModel : Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
        {
            public ItemsViewModel()
            {
                Items = new List<Item>() {
                    new Item { Type = "TextField",Position=1 },
                    new Item { Type = "TextField",Position=2  },
                    new Item { Type = "TextField",Position=3  },
                    new Item { Type = "MaskEdit" ,Position=4 },
                    new Item { Type = "TextField",Position=5  },
                    new Item { Type = "MaskEdit" ,Position=6 },
                   new Item { Type = "TextField",Position=7 },
                    new Item { Type = "TextField",Position=8  },
                    new Item { Type = "TextField",Position=9  },
                   new Item { Type = "TextField",Position=10 },
                    new Item { Type = "TextField",Position=11  },
                    new Item { Type = "TextField",Position=12 },};
            }
            private List<Item> _items;
            public List<Item> Items
            {
                get => _items;
                set => SetProperty(ref _items, value);
            }
        }
        public class Item : Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
        {
            private string _type;
            public string Type
            {
                get => _type;
                set => SetProperty(ref _type, value);
            }

            private int _position;
            public int Position
            {
                get => _position;
                set => SetProperty(ref _position, value);
            }
        }

        public Bug2_SFControlReturnType_Page()
        {
            InitializeComponent();
        }

        ItemsViewModel vm;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm = new ItemsViewModel();
            this.BindingContext = vm;
            ;
        }
        async void back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}

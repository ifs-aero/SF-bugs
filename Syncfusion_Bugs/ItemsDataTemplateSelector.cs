using Xamarin.Forms;
using static Syncfusion_Bugs.Bugs.Bug2_SFControlReturnType_Page;

namespace Syncfusion_Bugs
{
    public class ItemsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MaskEditTemplate { get; set; }
        public DataTemplate TextFieldTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var type = ((Item)item).Type;
            switch (type)
            {
                case "TextField":
                    return TextFieldTemplate;
                case "MaskEdit":
                    return MaskEditTemplate;
                default:
                    return TextFieldTemplate;
            }

        }
    }
}

//using Microsoft.Maui;
//using Microsoft.Maui.Handlers;
//using Microsoft.UI.Xaml;
//using System;

//namespace GenAlphaMaui.Platforms.Windows;

//public class HoverButtonRenderer : Button
//{
//    public PillButton PillButtonElement => Element as PillButton;

//    protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
//    {
//        base.OnElementChanged(e);

//        if (Control != null)
//        {
//            Windows.UI.Xaml.Controls.Button button = Control;

//            Resources = (Windows.UI.Xaml.ResourceDictionary)XamlReader.Load(PullButtonStyleDictionary);

//            Resources["PillCornerRadius"] = PillButtonElement.CornerRadius;
//            Resources["PillBorderWidth"] = PillButtonElement.BorderWidth;

//            Resources["PillFillColorOnHover"] =
//                new SolidColorBrush(PillButtonElement.ActiveColor.ToUwp());

//            Resources["PillFillColorOnPressed"] =
//                new SolidColorBrush(Color.Green.ToUwp());

//            Resources["PillTextColorOnHoverOrPressed"] = new SolidColorBrush(Color.Wheat.ToUwp());

//            button.Style = this.Resources["PillButtonStyle"] as Windows.UI.Xaml.Style;
//        }
//    }
//}

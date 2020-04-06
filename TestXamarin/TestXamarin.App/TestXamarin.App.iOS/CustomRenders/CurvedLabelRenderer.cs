using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TestXamarin.App.CustomRenders;
using TestXamarin.App.iOS.CustomRenders;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CurvedLabelRenderer))]
namespace TestXamarin.App.iOS.CustomRenders
{
    class CurvedLabelRenderer : LabelRenderer  
    {  
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
    {
        base.OnElementChanged(e);
        if (e.NewElement != null)
        {
            var _xfViewReference = (CustomLabel)Element;
            this.Layer.CornerRadius = (float)_xfViewReference.CurvedCornerRadius;
            this.Layer.BackgroundColor = _xfViewReference.CurvedBackgroundColor.ToCGColor();
        }
    }
}  
}
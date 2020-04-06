using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using System;
using TestXamarin.App.CustomRenders;
using TestXamarin.App.Droid.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelDroid))]
namespace TestXamarin.App.Droid.CustomRenders
{
    class CustomLabelDroid : LabelRenderer
    {
        private GradientDrawable _gradientBackground;
        public CustomLabelDroid(Context context) : base(context)
        {
        }
            
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var view = (CustomLabel)Element;
            if (view == null) return;

            _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(view.CurvedBackgroundColor.ToAndroid());

            _gradientBackground.SetStroke(4, view.BackgroundColor.ToAndroid());

            _gradientBackground.SetCornerRadius(DpToPixels(this.Context,
                Convert.ToSingle(view.CurvedCornerRadius)));
            Control.SetBackground(_gradientBackground);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}
using CoreGraphics;
using Foundation;
using GaHealthcareNurses.CustomControls;
using GaHealthcareNurses.iOS.Renderers;
using System;
using System.Drawing;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomBorderlessDatePicker), typeof(CustomBorderlessDatePickerRenderer))]
namespace GaHealthcareNurses.iOS.Renderers
{
    public class CustomBorderlessDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (this.Control == null)
                return;
            Control.Layer.BorderColor = UIColor.Black.CGColor;
        }
    }
}
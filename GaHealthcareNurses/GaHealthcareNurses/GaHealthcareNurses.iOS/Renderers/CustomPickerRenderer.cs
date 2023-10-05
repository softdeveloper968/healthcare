using CoreGraphics;
using Foundation;
using GaHealthcareNurses.CustomControls;
using GaHealthcareNurses.iOS.Renderers;
using System;
using System.Drawing;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace GaHealthcareNurses.iOS.Renderers
{
    public class CustomPickerRenderer : PickerRenderer
    {
        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            try
            {
                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.None;
                Control.BackgroundColor = UIKit.UIColor.White;
            }
            catch (Exception ex)
            { }
        }
        #endregion
    }
}
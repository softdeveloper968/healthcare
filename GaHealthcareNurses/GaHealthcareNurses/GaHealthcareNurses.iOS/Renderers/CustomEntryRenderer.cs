using CoreGraphics;
using Foundation;
using GaHealthcareNurses.CustomControls;
using GaHealthcareNurses.iOS.Renderers;
using System;
using System.ComponentModel;
using System.Drawing;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))] 
namespace GaHealthcareNurses.iOS.Renderers
{ 
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
                Control.TintColor = UIColor.Black; 
            }
        }
    }
}
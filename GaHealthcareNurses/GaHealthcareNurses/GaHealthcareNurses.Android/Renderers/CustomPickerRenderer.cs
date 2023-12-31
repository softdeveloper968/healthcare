﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GaHealthcareNurses.CustomControls;
using GaHealthcareNurses.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace GaHealthcareNurses.Droid.Renderers
{
    public class CustomPickerRenderer : PickerRenderer
    {
        #region Constructor
        public CustomPickerRenderer(Context context) : base(context)
        {

        }
        #endregion

        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {

                if (e.OldElement == null || e.NewElement != null)
                {
                    Control.Background = null;
                    var armPicker = e.NewElement as CustomPicker;
                    var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                    layoutParams.SetMargins(0, 0, 0, 0);
                    LayoutParameters = layoutParams;
                    Control.LayoutParameters = layoutParams;
                    Control.SetPadding(0, 0, 0, 0);
                    SetPadding(0, 0, 0, 0);
                    Control.TextSize *= (armPicker.FontSize * 0.01f);
                    Control.SetHintTextColor(Android.Graphics.Color.ParseColor(armPicker.PlaceholderColor));
                }
                if (Control != null)
                {
                    Control.Background = null;
                    Element.BackgroundColor = System.Drawing.Color.Transparent;
                    Control.Gravity = GravityFlags.Start;
                    Control.TextSize = 16;
                }

            }
        }
        #endregion
    }
}
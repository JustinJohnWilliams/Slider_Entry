using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider_Entry.CustomControls
{
    public class AccurateSlider : Slider
    {
        public static readonly BindableProperty AccurateValueProperty
            = BindableProperty.Create<AccurateSlider, Double>(s => s.AccurateValue, 0, BindingMode.TwoWay, coerceValue: CoerceValue);

        public double AccurateValue
        {
            get
            {
                return (double)this.GetValue(AccurateSlider.AccurateValueProperty);
            }
            set
            {
                { this.SetValue(AccurateSlider.AccurateValueProperty, value); }
            }
        }

        private bool locked;

        protected override async void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == AccurateSlider.AccurateValueProperty.PropertyName)
            {
                locked = true;
                Value = AccurateValue;
                await Task.Yield(); //fix for deferred setter
                locked = false;
            }
            else if (propertyName == AccurateSlider.ValueProperty.PropertyName && !locked)
            {
                AccurateValue = Value;
            }
        }

        private static double CoerceValue(BindableObject bindableObject, double value)
        {
            var slider = (Slider)bindableObject;
            return Math.Min(slider.Maximum, Math.Max(value, slider.Minimum));
        }
    }
}

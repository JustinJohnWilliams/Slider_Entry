using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Slider_Entry.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {

        private decimal _somePositiveValue;
        public decimal SomePositiveValue
        {
            get
            {
                return _somePositiveValue;
            }
            set
            {
                if (_somePositiveValue != value)
                {
                    _somePositiveValue = value;
                    RaisePropertyChanged();
                }
            }
        }

        private decimal _someNegativeValue;
        public decimal SomeNegativeValue
        {
            get
            {
                return _someNegativeValue;
            }
            set
            {
                if (_someNegativeValue != value)
                {
                    _someNegativeValue = value;
                    RaisePropertyChanged();
                }
            }
        }

        private decimal _someAccurateValue;
        public decimal SomeAccurateValue
        {
            get
            {
                return _someAccurateValue;
            }
            set
            {
                if (_someAccurateValue != value)
                {
                    _someAccurateValue = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string propName = "")
        {
            if (!string.IsNullOrEmpty(propName))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}

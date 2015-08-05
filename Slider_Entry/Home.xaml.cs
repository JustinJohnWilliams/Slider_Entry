using Slider_Entry.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider_Entry
{
    public partial class Home : ContentPage
    {

        private readonly HomeViewModel _viewModel;

        public Home()
        {
            _viewModel = new HomeViewModel();

            BindingContext = _viewModel;

            InitializeComponent();

        }
    }
}

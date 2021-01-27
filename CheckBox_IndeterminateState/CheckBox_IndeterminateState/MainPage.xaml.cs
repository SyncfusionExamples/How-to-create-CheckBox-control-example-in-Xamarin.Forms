using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckBox_IndeterminateState
{
    public partial class MainPage : ContentPage
    {
        private bool skip = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void SelectAll_StateChanged(object sender, StateChangedEventArgs e)
        {
            if (!skip)
            {
                skip = true;
                pepperoni.IsChecked = beef.IsChecked = mushroom.IsChecked = onion.IsChecked = e.IsChecked;
                skip = false;
            }
        }

        private void CheckBox_StateChanged(object sender, StateChangedEventArgs e)
        {
            if (!skip)
            {
                skip = true;
                if (pepperoni.IsChecked.Value && beef.IsChecked.Value && mushroom.IsChecked.Value && onion.IsChecked.Value)
                    selectAll.IsChecked = true;
                else if (!pepperoni.IsChecked.Value && !beef.IsChecked.Value && !mushroom.IsChecked.Value && !onion.IsChecked.Value)
                    selectAll.IsChecked = false;
                else
                    selectAll.IsChecked = null;
                skip = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabPageMaster
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        void valor_slider(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            valor.Text = Math.Ceiling(bola.Value).ToString();
        }
    }
}

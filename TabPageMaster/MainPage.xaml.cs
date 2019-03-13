using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabPageMaster
{
    public partial class MainPage : ContentPage
    {
        void concat(object sender, System.EventArgs e)
        {
            textComplet.Text = Part1.Text +" "+ Part2.Text;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}

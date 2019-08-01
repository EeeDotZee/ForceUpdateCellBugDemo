using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForceUpdateSizeDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(AppearingCell.Height > 0)
            {
                AppearingCell.Height = 0;
            }
            else
            {
                AppearingCell.Height = 42;
            }
            AppearingCell.ForceUpdateSize();
        }
    }
}

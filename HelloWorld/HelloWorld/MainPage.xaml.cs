using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        Stopwatch stopWatch;
        public MainPage()
        {
            InitializeComponent();

            stopWatch = new Stopwatch();
        }

        private void BtnStart_Clicked(object sender, EventArgs e)
        {
            stopWatch.Start();

            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                lblStopWatch.Text = stopWatch.Elapsed.ToString();

                if (stopWatch.IsRunning)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        private void BtnStop_Clicked(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BejeweledBot
{
    public partial class MainWindow : Form
    {
        private BejeweledWindowManager bwm;

        public MainWindow()
        {
            InitializeComponent();
            bwm = new BejeweledWindowManager();
            captureTimer = new Timer {};
            captureTimer.Tick += TickCapture;
        }

        private void calibrateBtn_Click(object sender, EventArgs e)
        {
            bwm.Calibrate();
            
            //searchThread.Start();

            //Thread.Sleep(1);

            //searchThread.Abort();

            colourGridPicture.Image = bwm.ColourGrid;

        }

        private void TickCapture(object sender, EventArgs e)
        {
            bwm.BejewledBoard = ScreenCapture.GetScreen(bwm.BoardLocation);
            AI.CalculateMove(bwm);
            bwm.PopulateBoard();

            long memory = GC.GetTotalMemory(false);

            if (memory / 1000 > 2000)
                GC.Collect();

            colourGridPicture.Image = bwm.ColourGrid;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            captureTimer.Stop();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            captureTimer.Start();
        }
    }
}

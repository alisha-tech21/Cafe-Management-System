using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Splash : Form
    {
        private Timer moveTimer;
        private int targetX;
        private bool isMoving = true;
        //private Timer fadeTimer;
        public Splash()
        {
            InitializeComponent();
            Piclogo.Left = -Piclogo.Width;
            Lblcafe.Left = -Lblcafe.Width;

            // Set the target position (center of the form)
            targetX = (this.ClientSize.Width - Piclogo.Width) / 2;

            // Create and configure move timer
            moveTimer = new Timer { Interval = 50 };
            moveTimer.Tick += timer1_Tick;
            moveTimer.Start();
        }

        private void StartProgressBar()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 20; // Adjust speed as needed

            // Start a timer to close the splash screen and show the login form
            Timer closeTimer = new Timer { Interval = 3000 }; // Adjust duration as needed
            closeTimer.Tick += (s, e) =>
            {
                closeTimer.Stop();
                this.Hide(); // Hide the splash screen
                Login l = new Login();
                l.Show(); // Show the login form
            };
            closeTimer.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                // Move PictureBox
                if (Piclogo.Left < targetX)
                {
                    Piclogo.Left += 14;
                }
                else
                {
                    Piclogo.Left = targetX;
                    // Move Label
                    if (Lblcafe.Left < targetX)
                    {
                        Lblcafe.Left += 14;
                    }
                    else
                    {
                        Lblcafe.Left = targetX;
                    }

                    // Check if both PictureBox and Label have stopped
                    if (Piclogo.Left == targetX && Lblcafe.Left == targetX)
                    {
                        isMoving = false;
                        moveTimer.Stop();
                        StartProgressBar();
                    }
                }
            }
        }
    }
}

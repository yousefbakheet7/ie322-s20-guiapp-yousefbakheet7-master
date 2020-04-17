﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yousef_IE322_P1
{
    class Car
    {
        public int speed = 0;
        public String Color = "Red";

        public void Start()
        {
            MessageBox.Show("Car has been started");
            speed = speed + 10;

        }
        public void Stop()
        {
            speed = 0;
            MessageBox.Show("Car has been stopped");

        }

        public void Accelerate(int increase)
        {
            speed = speed + increase;
            MessageBox.Show("Car has been accelerated by " + increase);
        }


    } // end class Car

}

/* Form1.cs
 * ==========
 * 
 * VolatilityTradingSimulation
 * Copyright © 2008, 2009 Gaurav Bansal (gaurav3@gmail.com). All Rights Reserved.
 * 
 *  This file is part of VolatilityTradingSimulation.

 *  VolatilityTradingSimulation is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  VolatilityTradingSimulation is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with StopLossSimulation.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolatilityTradingSimulation
{
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int length = 100000;
            double upMargin = 0.001;
            double downMargin = 0.01;
            double volatility = 0.4;

            int.TryParse ( txtLength.Text, out length );
            double.TryParse ( txtUp.Text, out upMargin );
            double.TryParse ( txtDown.Text, out downMargin );
            double.TryParse ( txtDistr.Text, out volatility );

            SimulationEngine se = new SimulationEngine ( length, upMargin, downMargin, volatility );

            //run test
            int ups, downs;
            se.Simulate ( out ups, out downs );

            lblUpResult.Text = ups.ToString();
            lblDownResult.Text = downs.ToString();
            lblMarginResult.Text = ((double)(ups * upMargin - downs * downMargin)/(length)).ToString();
        }
    }
}
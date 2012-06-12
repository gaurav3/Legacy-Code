/* FormRunTests.Designer.cs
 * ==========
 * 
 * StopLossSimulation
 * Copyright © 2008, 2009 Gaurav Bansal (gaurav3@gmail.com). All Rights Reserved.
 * 
 *  This file is part of StopLossSimulation.

 *  StopLossSimulation is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  StopLossSimulation is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with StopLossSimulation.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace StopLossSimulation
{
    partial class Simulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAverageProfit = new System.Windows.Forms.Label ( );
            this.txtAverageProfit = new System.Windows.Forms.Label ( );
            this.lblLossmakingTrades = new System.Windows.Forms.Label ( );
            this.txtLossmakingTrades = new System.Windows.Forms.Label ( );
            this.lblProfitableTrades = new System.Windows.Forms.Label ( );
            this.txtProfitablesTrades = new System.Windows.Forms.Label ( );
            this.txtVolatility = new System.Windows.Forms.TextBox ( );
            this.lblVolatility = new System.Windows.Forms.Label ( );
            this.btnTest = new System.Windows.Forms.Button ( );
            this.txtStoplossLimit = new System.Windows.Forms.TextBox ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.lblStoppedOut = new System.Windows.Forms.Label ( );
            this.txtStoppedOut = new System.Windows.Forms.Label ( );
            this.btnNewData = new System.Windows.Forms.Button ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // lblAverageProfit
            // 
            this.lblAverageProfit.AutoSize = true;
            this.lblAverageProfit.Location = new System.Drawing.Point ( 16, 55 );
            this.lblAverageProfit.Name = "lblAverageProfit";
            this.lblAverageProfit.Size = new System.Drawing.Size ( 120, 13 );
            this.lblAverageProfit.TabIndex = 0;
            this.lblAverageProfit.Text = "Average Profit (in %age)";
            // 
            // txtAverageProfit
            // 
            this.txtAverageProfit.Location = new System.Drawing.Point ( 142, 55 );
            this.txtAverageProfit.Name = "txtAverageProfit";
            this.txtAverageProfit.Size = new System.Drawing.Size ( 59, 13 );
            this.txtAverageProfit.TabIndex = 0;
            this.txtAverageProfit.Text = "...";
            this.txtAverageProfit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLossmakingTrades
            // 
            this.lblLossmakingTrades.AutoSize = true;
            this.lblLossmakingTrades.Location = new System.Drawing.Point ( 16, 42 );
            this.lblLossmakingTrades.Name = "lblLossmakingTrades";
            this.lblLossmakingTrades.Size = new System.Drawing.Size ( 103, 13 );
            this.lblLossmakingTrades.TabIndex = 0;
            this.lblLossmakingTrades.Text = "Loss Making Trades";
            // 
            // txtLossmakingTrades
            // 
            this.txtLossmakingTrades.Location = new System.Drawing.Point ( 142, 42 );
            this.txtLossmakingTrades.Name = "txtLossmakingTrades";
            this.txtLossmakingTrades.Size = new System.Drawing.Size ( 59, 13 );
            this.txtLossmakingTrades.TabIndex = 0;
            this.txtLossmakingTrades.Text = "...";
            this.txtLossmakingTrades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfitableTrades
            // 
            this.lblProfitableTrades.AutoSize = true;
            this.lblProfitableTrades.Location = new System.Drawing.Point ( 16, 29 );
            this.lblProfitableTrades.Name = "lblProfitableTrades";
            this.lblProfitableTrades.Size = new System.Drawing.Size ( 87, 13 );
            this.lblProfitableTrades.TabIndex = 0;
            this.lblProfitableTrades.Text = "Profitable Trades";
            // 
            // txtProfitablesTrades
            // 
            this.txtProfitablesTrades.Location = new System.Drawing.Point ( 142, 29 );
            this.txtProfitablesTrades.Name = "txtProfitablesTrades";
            this.txtProfitablesTrades.Size = new System.Drawing.Size ( 59, 13 );
            this.txtProfitablesTrades.TabIndex = 0;
            this.txtProfitablesTrades.Text = "...";
            this.txtProfitablesTrades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVolatility
            // 
            this.txtVolatility.Location = new System.Drawing.Point ( 123, 13 );
            this.txtVolatility.Name = "txtVolatility";
            this.txtVolatility.Size = new System.Drawing.Size ( 57, 20 );
            this.txtVolatility.TabIndex = 1;
            this.txtVolatility.Text = "2";
            // 
            // lblVolatility
            // 
            this.lblVolatility.AutoSize = true;
            this.lblVolatility.Location = new System.Drawing.Point ( 6, 16 );
            this.lblVolatility.Name = "lblVolatility";
            this.lblVolatility.Size = new System.Drawing.Size ( 84, 13 );
            this.lblVolatility.TabIndex = 2;
            this.lblVolatility.Text = "Volatility (0.1-10)";
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Location = new System.Drawing.Point ( 153, 108 );
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size ( 75, 23 );
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler ( this.btnTest_Click );
            // 
            // txtStoplossLimit
            // 
            this.txtStoplossLimit.Location = new System.Drawing.Point ( 123, 37 );
            this.txtStoplossLimit.Name = "txtStoplossLimit";
            this.txtStoplossLimit.Size = new System.Drawing.Size ( 57, 20 );
            this.txtStoplossLimit.TabIndex = 1;
            this.txtStoplossLimit.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point ( 6, 40 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size ( 78, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Stop Loss Limit";
            // 
            // lblStoppedOut
            // 
            this.lblStoppedOut.AutoSize = true;
            this.lblStoppedOut.Location = new System.Drawing.Point ( 16, 16 );
            this.lblStoppedOut.Name = "lblStoppedOut";
            this.lblStoppedOut.Size = new System.Drawing.Size ( 67, 13 );
            this.lblStoppedOut.TabIndex = 0;
            this.lblStoppedOut.Text = "Stopped Out";
            // 
            // txtStoppedOut
            // 
            this.txtStoppedOut.Location = new System.Drawing.Point ( 142, 16 );
            this.txtStoppedOut.Name = "txtStoppedOut";
            this.txtStoppedOut.Size = new System.Drawing.Size ( 59, 13 );
            this.txtStoppedOut.TabIndex = 0;
            this.txtStoppedOut.Text = "...";
            this.txtStoppedOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewData
            // 
            this.btnNewData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewData.Location = new System.Drawing.Point ( 72, 108 );
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size ( 75, 23 );
            this.btnNewData.TabIndex = 3;
            this.btnNewData.Text = "New data";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler ( this.btnNewData_Click );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add ( this.lblStoppedOut );
            this.groupBox1.Controls.Add ( this.lblAverageProfit );
            this.groupBox1.Controls.Add ( this.lblLossmakingTrades );
            this.groupBox1.Controls.Add ( this.lblProfitableTrades );
            this.groupBox1.Controls.Add ( this.txtAverageProfit );
            this.groupBox1.Controls.Add ( this.txtLossmakingTrades );
            this.groupBox1.Controls.Add ( this.txtProfitablesTrades );
            this.groupBox1.Controls.Add ( this.txtStoppedOut );
            this.groupBox1.Location = new System.Drawing.Point ( 12, 137 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size ( 216, 82 );
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add ( this.lblVolatility );
            this.groupBox2.Controls.Add ( this.txtVolatility );
            this.groupBox2.Controls.Add ( this.txtStoplossLimit );
            this.groupBox2.Controls.Add ( this.label1 );
            this.groupBox2.Location = new System.Drawing.Point ( 12, 12 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size ( 216, 90 );
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // FormRunTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size ( 237, 231 );
            this.Controls.Add ( this.groupBox2 );
            this.Controls.Add ( this.groupBox1 );
            this.Controls.Add ( this.btnNewData );
            this.Controls.Add ( this.btnTest );
            this.Name = "FormRunTest";
            this.Text = "Run Tests";
            this.groupBox1.ResumeLayout ( false );
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout ( false );
            this.groupBox2.PerformLayout ( );
            this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.Label lblAverageProfit;
        private System.Windows.Forms.Label txtAverageProfit;
        private System.Windows.Forms.Label lblLossmakingTrades;
        private System.Windows.Forms.Label txtLossmakingTrades;
        private System.Windows.Forms.Label lblProfitableTrades;
        private System.Windows.Forms.Label txtProfitablesTrades;
        private System.Windows.Forms.TextBox txtVolatility;
        private System.Windows.Forms.Label lblVolatility;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtStoplossLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStoppedOut;
        private System.Windows.Forms.Label txtStoppedOut;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


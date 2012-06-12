/* Form1.Designer.cs
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

namespace VolatilityTradingSimulation
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
            this.btnTest = new System.Windows.Forms.Button ( );
            this.lblUps = new System.Windows.Forms.Label ( );
            this.lblDowns = new System.Windows.Forms.Label ( );
            this.lblMargin = new System.Windows.Forms.Label ( );
            this.txtDistr = new System.Windows.Forms.TextBox ( );
            this.lblUpResult = new System.Windows.Forms.Label ( );
            this.lblDownResult = new System.Windows.Forms.Label ( );
            this.lblMarginResult = new System.Windows.Forms.Label ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.txtUp = new System.Windows.Forms.TextBox ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.txtDown = new System.Windows.Forms.TextBox ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.txtLength = new System.Windows.Forms.TextBox ( );
            this.label4 = new System.Windows.Forms.Label ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point ( 67, 142 );
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size ( 75, 23 );
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler ( this.btnTest_Click );
            // 
            // lblUps
            // 
            this.lblUps.AutoSize = true;
            this.lblUps.Location = new System.Drawing.Point ( 3, 17 );
            this.lblUps.Name = "lblUps";
            this.lblUps.Size = new System.Drawing.Size ( 87, 13 );
            this.lblUps.TabIndex = 1;
            this.lblUps.Text = "Profitable Trades";
            // 
            // lblDowns
            // 
            this.lblDowns.AutoSize = true;
            this.lblDowns.Location = new System.Drawing.Point ( 3, 43 );
            this.lblDowns.Name = "lblDowns";
            this.lblDowns.Size = new System.Drawing.Size ( 98, 13 );
            this.lblDowns.TabIndex = 1;
            this.lblDowns.Text = "Loss making trades";
            // 
            // lblMargin
            // 
            this.lblMargin.AutoSize = true;
            this.lblMargin.Location = new System.Drawing.Point ( 3, 69 );
            this.lblMargin.Name = "lblMargin";
            this.lblMargin.Size = new System.Drawing.Size ( 106, 13 );
            this.lblMargin.TabIndex = 2;
            this.lblMargin.Text = "Avg Margin per trade";
            // 
            // txtDistr
            // 
            this.txtDistr.Location = new System.Drawing.Point ( 73, 13 );
            this.txtDistr.Name = "txtDistr";
            this.txtDistr.Size = new System.Drawing.Size ( 100, 20 );
            this.txtDistr.TabIndex = 3;
            this.txtDistr.Text = "0.4";
            // 
            // lblUpResult
            // 
            this.lblUpResult.AutoSize = true;
            this.lblUpResult.Location = new System.Drawing.Point ( 120, 17 );
            this.lblUpResult.Name = "lblUpResult";
            this.lblUpResult.Size = new System.Drawing.Size ( 16, 13 );
            this.lblUpResult.TabIndex = 4;
            this.lblUpResult.Text = "...";
            // 
            // lblDownResult
            // 
            this.lblDownResult.AutoSize = true;
            this.lblDownResult.Location = new System.Drawing.Point ( 120, 43 );
            this.lblDownResult.Name = "lblDownResult";
            this.lblDownResult.Size = new System.Drawing.Size ( 16, 13 );
            this.lblDownResult.TabIndex = 4;
            this.lblDownResult.Text = "...";
            // 
            // lblMarginResult
            // 
            this.lblMarginResult.AutoSize = true;
            this.lblMarginResult.Location = new System.Drawing.Point ( 120, 69 );
            this.lblMarginResult.Name = "lblMarginResult";
            this.lblMarginResult.Size = new System.Drawing.Size ( 16, 13 );
            this.lblMarginResult.TabIndex = 4;
            this.lblMarginResult.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point ( 4, 16 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size ( 45, 13 );
            this.label1.TabIndex = 5;
            this.label1.Text = "Volatility";
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point ( 73, 39 );
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size ( 100, 20 );
            this.txtUp.TabIndex = 3;
            this.txtUp.Text = "0.001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point ( 4, 42 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size ( 45, 13 );
            this.label2.TabIndex = 5;
            this.label2.Text = "Up Limit";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point ( 73, 65 );
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size ( 100, 20 );
            this.txtDown.TabIndex = 3;
            this.txtDown.Text = "0.01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point ( 4, 68 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size ( 59, 13 );
            this.label3.TabIndex = 5;
            this.label3.Text = "Down Limit";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point ( 73, 93 );
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size ( 100, 20 );
            this.txtLength.TabIndex = 3;
            this.txtLength.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point ( 4, 96 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size ( 66, 13 );
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Length";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add ( this.lblUps );
            this.groupBox1.Controls.Add ( this.lblDowns );
            this.groupBox1.Controls.Add ( this.lblMarginResult );
            this.groupBox1.Controls.Add ( this.lblMargin );
            this.groupBox1.Controls.Add ( this.lblDownResult );
            this.groupBox1.Controls.Add ( this.lblUpResult );
            this.groupBox1.Location = new System.Drawing.Point ( 12, 171 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size ( 185, 89 );
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add ( this.label1 );
            this.groupBox2.Controls.Add ( this.txtDistr );
            this.groupBox2.Controls.Add ( this.label4 );
            this.groupBox2.Controls.Add ( this.txtUp );
            this.groupBox2.Controls.Add ( this.label3 );
            this.groupBox2.Controls.Add ( this.txtDown );
            this.groupBox2.Controls.Add ( this.label2 );
            this.groupBox2.Controls.Add ( this.txtLength );
            this.groupBox2.Location = new System.Drawing.Point ( 12, 12 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size ( 185, 124 );
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size ( 212, 268 );
            this.Controls.Add ( this.groupBox2 );
            this.Controls.Add ( this.groupBox1 );
            this.Controls.Add ( this.btnTest );
            this.Name = "Form1";
            this.Text = "Simulator";
            this.groupBox1.ResumeLayout ( false );
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout ( false );
            this.groupBox2.PerformLayout ( );
            this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblUps;
        private System.Windows.Forms.Label lblDowns;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.TextBox txtDistr;
        private System.Windows.Forms.Label lblUpResult;
        private System.Windows.Forms.Label lblDownResult;
        private System.Windows.Forms.Label lblMarginResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


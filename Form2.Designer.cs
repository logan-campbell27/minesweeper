
namespace MilestoneMinesweeperConsole
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.grpbx_minesweeper = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpbx_minesweeper
            // 
            this.grpbx_minesweeper.Location = new System.Drawing.Point(18, 18);
            this.grpbx_minesweeper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_minesweeper.Name = "grpbx_minesweeper";
            this.grpbx_minesweeper.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_minesweeper.Size = new System.Drawing.Size(400, 416);
            this.grpbx_minesweeper.TabIndex = 0;
            this.grpbx_minesweeper.TabStop = false;
            this.grpbx_minesweeper.Text = "This is to show to box";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(359, 3);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(35, 13);
            this.lbl_timer.TabIndex = 1;
            this.lbl_timer.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 480);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.grpbx_minesweeper);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_minesweeper;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
    }
}
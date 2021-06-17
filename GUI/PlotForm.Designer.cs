
namespace GUI
{
    partial class PlotForm
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
            this.PlotWindow = new ScottPlot.FormsPlot();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // PlotWindow
            // 
            this.PlotWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotWindow.BackColor = System.Drawing.Color.Transparent;
            this.PlotWindow.Location = new System.Drawing.Point(64, 39);
            this.PlotWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlotWindow.Name = "PlotWindow";
            this.PlotWindow.Size = new System.Drawing.Size(650, 372);
            this.PlotWindow.TabIndex = 0;
            this.PlotWindow.Load += new System.EventHandler(this.Plot_Load);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(239, 416);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(301, 26);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // PlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 462);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.PlotWindow);
            this.Name = "PlotForm";
            this.Text = "PlotForm";
            this.Load += new System.EventHandler(this.PlotForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot PlotWindow;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}
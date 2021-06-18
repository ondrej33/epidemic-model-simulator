
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
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlotWindow
            // 
            this.PlotWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotWindow.BackColor = System.Drawing.Color.Transparent;
            this.PlotWindow.Location = new System.Drawing.Point(41, 29);
            this.PlotWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlotWindow.Name = "PlotWindow";
            this.PlotWindow.Size = new System.Drawing.Size(673, 393);
            this.PlotWindow.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextButton.Location = new System.Drawing.Point(324, 430);
            this.NextButton.MaximumSize = new System.Drawing.Size(100, 40);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 37);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PlotWindow);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "PlotForm";
            this.Text = "PlotForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot PlotWindow;
        private System.Windows.Forms.Button NextButton;
    }
}
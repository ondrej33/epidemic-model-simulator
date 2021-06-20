
namespace Project
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
            this.ParamsList = new System.Windows.Forms.ListView();
            this.Parameter = new System.Windows.Forms.ColumnHeader();
            this.Value = new System.Windows.Forms.ColumnHeader();
            this.EventsList = new System.Windows.Forms.ListView();
            this.Param = new System.Windows.Forms.ColumnHeader();
            this.NewVal = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.ParamsLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlotWindow
            // 
            this.PlotWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotWindow.BackColor = System.Drawing.Color.Transparent;
            this.PlotWindow.Location = new System.Drawing.Point(4, 8);
            this.PlotWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlotWindow.Name = "PlotWindow";
            this.PlotWindow.Size = new System.Drawing.Size(687, 448);
            this.PlotWindow.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextButton.Location = new System.Drawing.Point(339, 451);
            this.NextButton.MaximumSize = new System.Drawing.Size(100, 40);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 40);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ParamsList
            // 
            this.ParamsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParamsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Parameter,
            this.Value});
            this.ParamsList.FullRowSelect = true;
            this.ParamsList.GridLines = true;
            this.ParamsList.HideSelection = false;
            this.ParamsList.Location = new System.Drawing.Point(696, 50);
            this.ParamsList.Name = "ParamsList";
            this.ParamsList.Size = new System.Drawing.Size(184, 124);
            this.ParamsList.TabIndex = 2;
            this.ParamsList.UseCompatibleStateImageBehavior = false;
            this.ParamsList.View = System.Windows.Forms.View.Details;
            // 
            // Parameter
            // 
            this.Parameter.Text = "Param";
            this.Parameter.Width = 91;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 91;
            // 
            // EventsList
            // 
            this.EventsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Param,
            this.NewVal,
            this.Time});
            this.EventsList.GridLines = true;
            this.EventsList.HideSelection = false;
            this.EventsList.Location = new System.Drawing.Point(696, 228);
            this.EventsList.Name = "EventsList";
            this.EventsList.Size = new System.Drawing.Size(184, 190);
            this.EventsList.TabIndex = 3;
            this.EventsList.UseCompatibleStateImageBehavior = false;
            this.EventsList.View = System.Windows.Forms.View.Details;
            // 
            // Param
            // 
            this.Param.Text = "Param";
            this.Param.Width = 62;
            // 
            // NewVal
            // 
            this.NewVal.Text = "Value";
            this.NewVal.Width = 61;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 61;
            // 
            // ParamsLabel
            // 
            this.ParamsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParamsLabel.AutoSize = true;
            this.ParamsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParamsLabel.Location = new System.Drawing.Point(689, 19);
            this.ParamsLabel.Name = "ParamsLabel";
            this.ParamsLabel.Size = new System.Drawing.Size(112, 28);
            this.ParamsLabel.TabIndex = 4;
            this.ParamsLabel.Text = "Parameters:";
            // 
            // EventLabel
            // 
            this.EventLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventLabel.Location = new System.Drawing.Point(689, 197);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(72, 28);
            this.EventLabel.TabIndex = 5;
            this.EventLabel.Text = "Events:";
            // 
            // PlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 503);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.ParamsLabel);
            this.Controls.Add(this.EventsList);
            this.Controls.Add(this.ParamsList);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PlotWindow);
            this.MinimumSize = new System.Drawing.Size(910, 550);
            this.Name = "PlotForm";
            this.Text = "PlotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot PlotWindow;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListView ParamsList;
        private System.Windows.Forms.ListView EventsList;
        private System.Windows.Forms.Label ParamsLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.ColumnHeader Parameter;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Param;
        private System.Windows.Forms.ColumnHeader NewVal;
        private System.Windows.Forms.ColumnHeader Time;
    }
}

namespace GUI
{
    partial class CreativeForm
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
            this.PopulationLabel = new System.Windows.Forms.Label();
            this.TinfLabel = new System.Windows.Forms.Label();
            this.R0Label = new System.Windows.Forms.Label();
            this.SLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.ITB = new System.Windows.Forms.TextBox();
            this.STB = new System.Windows.Forms.TextBox();
            this.R0TB = new System.Windows.Forms.TextBox();
            this.TinfTB = new System.Windows.Forms.TextBox();
            this.PopTB = new System.Windows.Forms.TextBox();
            this.RTB = new System.Windows.Forms.TextBox();
            this.TimmuTB = new System.Windows.Forms.TextBox();
            this.EventsList = new System.Windows.Forms.ListView();
            this.Parameter = new System.Windows.Forms.ColumnHeader();
            this.Value = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.EventLabel = new System.Windows.Forms.Label();
            this.AddEventBtn = new System.Windows.Forms.Button();
            this.EventValueTB = new System.Windows.Forms.TextBox();
            this.EventParamTB = new System.Windows.Forms.TextBox();
            this.EventTimeTB = new System.Windows.Forms.TextBox();
            this.EventValueLabel = new System.Windows.Forms.Label();
            this.EventTimeLabel = new System.Windows.Forms.Label();
            this.EventParamLabel = new System.Windows.Forms.Label();
            this.TimeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimmuLabel = new System.Windows.Forms.Label();
            this.SimulateNewBtn = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AddToSameBtn = new System.Windows.Forms.Button();
            this.RemoveEventBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlotWindow
            // 
            this.PlotWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotWindow.BackColor = System.Drawing.Color.Transparent;
            this.PlotWindow.Location = new System.Drawing.Point(-6, 141);
            this.PlotWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlotWindow.Name = "PlotWindow";
            this.PlotWindow.Size = new System.Drawing.Size(703, 367);
            this.PlotWindow.TabIndex = 0;
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Location = new System.Drawing.Point(382, 17);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(83, 20);
            this.PopulationLabel.TabIndex = 1;
            this.PopulationLabel.Text = "Population:";
            // 
            // TinfLabel
            // 
            this.TinfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TinfLabel.AutoSize = true;
            this.TinfLabel.Location = new System.Drawing.Point(52, 69);
            this.TinfLabel.Name = "TinfLabel";
            this.TinfLabel.Size = new System.Drawing.Size(112, 20);
            this.TinfLabel.TabIndex = 2;
            this.TinfLabel.Text = "Inefection time:";
            // 
            // R0Label
            // 
            this.R0Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.R0Label.AutoSize = true;
            this.R0Label.Location = new System.Drawing.Point(52, 43);
            this.R0Label.Name = "R0Label";
            this.R0Label.Size = new System.Drawing.Size(29, 20);
            this.R0Label.TabIndex = 3;
            this.R0Label.Text = "R0:";
            // 
            // SLabel
            // 
            this.SLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SLabel.AutoSize = true;
            this.SLabel.Location = new System.Drawing.Point(382, 43);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(45, 20);
            this.SLabel.TabIndex = 4;
            this.SLabel.Text = "S init:";
            // 
            // ILabel
            // 
            this.ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(382, 69);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(41, 20);
            this.ILabel.TabIndex = 5;
            this.ILabel.Text = "I init:";
            // 
            // RLabel
            // 
            this.RLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(382, 96);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(46, 20);
            this.RLabel.TabIndex = 6;
            this.RLabel.Text = "R init:";
            // 
            // ITB
            // 
            this.ITB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ITB.Location = new System.Drawing.Point(479, 66);
            this.ITB.Name = "ITB";
            this.ITB.Size = new System.Drawing.Size(119, 27);
            this.ITB.TabIndex = 7;
            // 
            // STB
            // 
            this.STB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.STB.Location = new System.Drawing.Point(479, 40);
            this.STB.Name = "STB";
            this.STB.Size = new System.Drawing.Size(119, 27);
            this.STB.TabIndex = 8;
            // 
            // R0TB
            // 
            this.R0TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.R0TB.Location = new System.Drawing.Point(171, 40);
            this.R0TB.Name = "R0TB";
            this.R0TB.Size = new System.Drawing.Size(115, 27);
            this.R0TB.TabIndex = 9;
            // 
            // TinfTB
            // 
            this.TinfTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TinfTB.Location = new System.Drawing.Point(171, 66);
            this.TinfTB.Name = "TinfTB";
            this.TinfTB.Size = new System.Drawing.Size(115, 27);
            this.TinfTB.TabIndex = 10;
            // 
            // PopTB
            // 
            this.PopTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PopTB.Location = new System.Drawing.Point(479, 14);
            this.PopTB.Name = "PopTB";
            this.PopTB.Size = new System.Drawing.Size(119, 27);
            this.PopTB.TabIndex = 11;
            // 
            // RTB
            // 
            this.RTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RTB.Location = new System.Drawing.Point(479, 92);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(119, 27);
            this.RTB.TabIndex = 12;
            // 
            // TimmuTB
            // 
            this.TimmuTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimmuTB.Location = new System.Drawing.Point(171, 92);
            this.TimmuTB.Name = "TimmuTB";
            this.TimmuTB.Size = new System.Drawing.Size(115, 27);
            this.TimmuTB.TabIndex = 14;
            // 
            // EventsList
            // 
            this.EventsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Parameter,
            this.Value,
            this.Time});
            this.EventsList.GridLines = true;
            this.EventsList.HideSelection = false;
            this.EventsList.Location = new System.Drawing.Point(704, 160);
            this.EventsList.Name = "EventsList";
            this.EventsList.Size = new System.Drawing.Size(306, 173);
            this.EventsList.TabIndex = 15;
            this.EventsList.UseCompatibleStateImageBehavior = false;
            this.EventsList.View = System.Windows.Forms.View.Details;
            // 
            // Parameter
            // 
            this.Parameter.Text = "Parameter";
            this.Parameter.Width = 101;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 101;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 101;
            // 
            // EventLabel
            // 
            this.EventLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventLabel.Location = new System.Drawing.Point(700, 13);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(72, 28);
            this.EventLabel.TabIndex = 16;
            this.EventLabel.Text = "Events:";
            // 
            // AddEventBtn
            // 
            this.AddEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEventBtn.Location = new System.Drawing.Point(896, 111);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.Size = new System.Drawing.Size(114, 30);
            this.AddEventBtn.TabIndex = 17;
            this.AddEventBtn.Text = "Add event";
            this.AddEventBtn.UseVisualStyleBackColor = true;
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_Click);
            // 
            // EventValueTB
            // 
            this.EventValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventValueTB.Location = new System.Drawing.Point(896, 43);
            this.EventValueTB.Name = "EventValueTB";
            this.EventValueTB.Size = new System.Drawing.Size(114, 27);
            this.EventValueTB.TabIndex = 23;
            // 
            // EventParamTB
            // 
            this.EventParamTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventParamTB.Location = new System.Drawing.Point(896, 17);
            this.EventParamTB.Name = "EventParamTB";
            this.EventParamTB.Size = new System.Drawing.Size(114, 27);
            this.EventParamTB.TabIndex = 22;
            // 
            // EventTimeTB
            // 
            this.EventTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTimeTB.Location = new System.Drawing.Point(896, 69);
            this.EventTimeTB.Name = "EventTimeTB";
            this.EventTimeTB.Size = new System.Drawing.Size(114, 27);
            this.EventTimeTB.TabIndex = 21;
            // 
            // EventValueLabel
            // 
            this.EventValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventValueLabel.AutoSize = true;
            this.EventValueLabel.Location = new System.Drawing.Point(798, 46);
            this.EventValueLabel.Name = "EventValueLabel";
            this.EventValueLabel.Size = new System.Drawing.Size(81, 20);
            this.EventValueLabel.TabIndex = 20;
            this.EventValueLabel.Text = "New value:";
            // 
            // EventTimeLabel
            // 
            this.EventTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTimeLabel.AutoSize = true;
            this.EventTimeLabel.Location = new System.Drawing.Point(798, 72);
            this.EventTimeLabel.Name = "EventTimeLabel";
            this.EventTimeLabel.Size = new System.Drawing.Size(45, 20);
            this.EventTimeLabel.TabIndex = 19;
            this.EventTimeLabel.Text = "Time:";
            // 
            // EventParamLabel
            // 
            this.EventParamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventParamLabel.AutoSize = true;
            this.EventParamLabel.Location = new System.Drawing.Point(796, 20);
            this.EventParamLabel.Name = "EventParamLabel";
            this.EventParamLabel.Size = new System.Drawing.Size(79, 20);
            this.EventParamLabel.TabIndex = 18;
            this.EventParamLabel.Text = "Parameter:";
            // 
            // TimeTB
            // 
            this.TimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeTB.Location = new System.Drawing.Point(171, 14);
            this.TimeTB.Name = "TimeTB";
            this.TimeTB.Size = new System.Drawing.Size(115, 27);
            this.TimeTB.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-205, -58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "immunity time:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(52, 20);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(93, 20);
            this.TimeLabel.TabIndex = 26;
            this.TimeLabel.Text = "Time period:";
            // 
            // TimmuLabel
            // 
            this.TimmuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimmuLabel.AutoSize = true;
            this.TimmuLabel.Location = new System.Drawing.Point(52, 95);
            this.TimmuLabel.Name = "TimmuLabel";
            this.TimmuLabel.Size = new System.Drawing.Size(108, 20);
            this.TimmuLabel.TabIndex = 27;
            this.TimmuLabel.Text = "Immunity time:";
            // 
            // SimulateNewBtn
            // 
            this.SimulateNewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SimulateNewBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SimulateNewBtn.Location = new System.Drawing.Point(798, 398);
            this.SimulateNewBtn.Name = "SimulateNewBtn";
            this.SimulateNewBtn.Size = new System.Drawing.Size(142, 45);
            this.SimulateNewBtn.TabIndex = 28;
            this.SimulateNewBtn.Text = "Simulate new";
            this.SimulateNewBtn.UseVisualStyleBackColor = true;
            this.SimulateNewBtn.Click += new System.EventHandler(this.SimulateNewBtn_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(171, 122);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(129, 19);
            this.InfoLabel.TabIndex = 29;
            this.InfoLabel.Text = "*put -1 here for SIR";
            // 
            // AddToSameBtn
            // 
            this.AddToSameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToSameBtn.Enabled = false;
            this.AddToSameBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddToSameBtn.Location = new System.Drawing.Point(798, 446);
            this.AddToSameBtn.Name = "AddToSameBtn";
            this.AddToSameBtn.Size = new System.Drawing.Size(142, 45);
            this.AddToSameBtn.TabIndex = 30;
            this.AddToSameBtn.Text = "Add to previous";
            this.AddToSameBtn.UseVisualStyleBackColor = true;
            this.AddToSameBtn.Click += new System.EventHandler(this.AddToSameBtn_Click);
            // 
            // RemoveEventBtn
            // 
            this.RemoveEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEventBtn.Location = new System.Drawing.Point(763, 111);
            this.RemoveEventBtn.Name = "RemoveEventBtn";
            this.RemoveEventBtn.Size = new System.Drawing.Size(114, 30);
            this.RemoveEventBtn.TabIndex = 31;
            this.RemoveEventBtn.Text = "Remove event";
            this.RemoveEventBtn.UseVisualStyleBackColor = true;
            this.RemoveEventBtn.Click += new System.EventHandler(this.RemoveEventBtn_Click);
            // 
            // CreativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 503);
            this.Controls.Add(this.RemoveEventBtn);
            this.Controls.Add(this.AddToSameBtn);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.SimulateNewBtn);
            this.Controls.Add(this.TimmuLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventValueTB);
            this.Controls.Add(this.EventParamTB);
            this.Controls.Add(this.EventTimeTB);
            this.Controls.Add(this.EventValueLabel);
            this.Controls.Add(this.EventTimeLabel);
            this.Controls.Add(this.EventParamLabel);
            this.Controls.Add(this.AddEventBtn);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventsList);
            this.Controls.Add(this.TimmuTB);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.PopTB);
            this.Controls.Add(this.TinfTB);
            this.Controls.Add(this.R0TB);
            this.Controls.Add(this.STB);
            this.Controls.Add(this.ITB);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.ILabel);
            this.Controls.Add(this.SLabel);
            this.Controls.Add(this.R0Label);
            this.Controls.Add(this.TinfLabel);
            this.Controls.Add(this.PopulationLabel);
            this.Controls.Add(this.PlotWindow);
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "CreativeForm";
            this.Text = "CreateModelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot PlotWindow;
        private System.Windows.Forms.Label PopulationLabel;
        private System.Windows.Forms.Label TinfLabel;
        private System.Windows.Forms.Label R0Label;
        private System.Windows.Forms.Label SLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.TextBox ITB;
        private System.Windows.Forms.TextBox STB;
        private System.Windows.Forms.TextBox R0TB;
        private System.Windows.Forms.TextBox TinfTB;
        private System.Windows.Forms.TextBox PopTB;
        private System.Windows.Forms.TextBox RTB;
        private System.Windows.Forms.TextBox TimmuTB;
        private System.Windows.Forms.ListView EventsList;
        private System.Windows.Forms.ColumnHeader Parameter;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Button AddEventBtn;
        private System.Windows.Forms.TextBox EventValueTB;
        private System.Windows.Forms.TextBox EventParamTB;
        private System.Windows.Forms.TextBox EventTimeTB;
        private System.Windows.Forms.Label EventValueLabel;
        private System.Windows.Forms.Label EventTimeLabel;
        private System.Windows.Forms.Label EventParamLabel;
        private System.Windows.Forms.TextBox TimeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimmuLabel;
        private System.Windows.Forms.Button SimulateNewBtn;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button AddToSameBtn;
        private System.Windows.Forms.Button RemoveEventBtn;
    }
}
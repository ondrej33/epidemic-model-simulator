
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileBrowser = new GUI.FileBrowser();
            this.StartButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ModeSwitchRadio = new System.Windows.Forms.RadioButton();
            this.CreateModelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileBrowser
            // 
            this.FileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBrowser.Location = new System.Drawing.Point(77, 106);
            this.FileBrowser.Name = "FileBrowser";
            this.FileBrowser.Size = new System.Drawing.Size(769, 43);
            this.FileBrowser.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(389, 174);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(145, 44);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start computation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(270, 240);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(382, 25);
            this.ProgressBar.TabIndex = 2;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(158, 240);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(68, 20);
            this.ProgressLabel.TabIndex = 3;
            this.ProgressLabel.Text = "Progress:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModeSwitchRadio
            // 
            this.ModeSwitchRadio.AutoSize = true;
            this.ModeSwitchRadio.Location = new System.Drawing.Point(379, 310);
            this.ModeSwitchRadio.Name = "ModeSwitchRadio";
            this.ModeSwitchRadio.Size = new System.Drawing.Size(188, 24);
            this.ModeSwitchRadio.TabIndex = 4;
            this.ModeSwitchRadio.TabStop = true;
            this.ModeSwitchRadio.Text = "Interactive mode results";
            this.ModeSwitchRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModeSwitchRadio.UseVisualStyleBackColor = true;
            this.ModeSwitchRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CreateModelBtn
            // 
            this.CreateModelBtn.Location = new System.Drawing.Point(391, 31);
            this.CreateModelBtn.Name = "CreateModelBtn";
            this.CreateModelBtn.Size = new System.Drawing.Size(140, 45);
            this.CreateModelBtn.TabIndex = 5;
            this.CreateModelBtn.Text = "Create new model";
            this.CreateModelBtn.UseVisualStyleBackColor = true;
            this.CreateModelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 485);
            this.Controls.Add(this.CreateModelBtn);
            this.Controls.Add(this.ModeSwitchRadio);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.FileBrowser);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "Create new model";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileBrowser FileBrowser;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton ModeSwitchRadio;
        private System.Windows.Forms.Button CreateModelBtn;
    }
}



namespace Project
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
            this.InputFileBrowser = new Project.FileBrowser();
            this.StartButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.ErrorProviderFormat = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreativeModeBtn = new System.Windows.Forms.Button();
            this.InteractiveResultsBtn = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputDirBrowser = new Project.DirBrowser();
            this.OutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // InputFileBrowser
            // 
            this.InputFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFileBrowser.Location = new System.Drawing.Point(77, 106);
            this.InputFileBrowser.Name = "InputFileBrowser";
            this.InputFileBrowser.Size = new System.Drawing.Size(732, 43);
            this.InputFileBrowser.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(674, 260);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(144, 43);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start computation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(290, 268);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(338, 24);
            this.ProgressBar.TabIndex = 2;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(182, 271);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(68, 20);
            this.ProgressLabel.TabIndex = 3;
            this.ProgressLabel.Text = "Progress:";
            // 
            // ErrorProviderFormat
            // 
            this.ErrorProviderFormat.ContainerControl = this;
            // 
            // CreativeModeBtn
            // 
            this.CreativeModeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreativeModeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreativeModeBtn.Location = new System.Drawing.Point(372, 39);
            this.CreativeModeBtn.Name = "CreativeModeBtn";
            this.CreativeModeBtn.Size = new System.Drawing.Size(143, 45);
            this.CreativeModeBtn.TabIndex = 5;
            this.CreativeModeBtn.Text = "Creative mode";
            this.CreativeModeBtn.UseVisualStyleBackColor = true;
            this.CreativeModeBtn.Click += new System.EventHandler(this.CreativeModeBtn_Click);
            // 
            // InteractiveResultsBtn
            // 
            this.InteractiveResultsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InteractiveResultsBtn.Enabled = false;
            this.InteractiveResultsBtn.Location = new System.Drawing.Point(675, 319);
            this.InteractiveResultsBtn.Name = "InteractiveResultsBtn";
            this.InteractiveResultsBtn.Size = new System.Drawing.Size(143, 45);
            this.InteractiveResultsBtn.TabIndex = 6;
            this.InteractiveResultsBtn.Text = "See results in app";
            this.InteractiveResultsBtn.UseVisualStyleBackColor = true;
            this.InteractiveResultsBtn.Click += new System.EventHandler(this.InteractiveResultsBtn_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(37, 117);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(71, 20);
            this.InputLabel.TabIndex = 8;
            this.InputLabel.Text = "Input file:";
            // 
            // OutputDirBrowser
            // 
            this.OutputDirBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirBrowser.Location = new System.Drawing.Point(104, 169);
            this.OutputDirBrowser.Name = "OutputDirBrowser";
            this.OutputDirBrowser.Size = new System.Drawing.Size(724, 59);
            this.OutputDirBrowser.TabIndex = 10;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(37, 181);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(80, 20);
            this.OutputLabel.TabIndex = 11;
            this.OutputLabel.Text = "Output dir:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 383);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputDirBrowser);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InteractiveResultsBtn);
            this.Controls.Add(this.CreativeModeBtn);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InputFileBrowser);
            this.MaximumSize = new System.Drawing.Size(1100, 450);
            this.MinimumSize = new System.Drawing.Size(750, 430);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFormat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileBrowser InputFileBrowser;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ErrorProvider ErrorProviderFormat;
        private System.Windows.Forms.Button CreativeModeBtn;
        private System.Windows.Forms.Button InteractiveResultsBtn;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private DirBrowser OutputDirBrowser;
    }
}



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
            this.ErrorProviderFormat = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreateModelBtn = new System.Windows.Forms.Button();
            this.InteractiveResultsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // FileBrowser
            // 
            this.FileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBrowser.Location = new System.Drawing.Point(77, 106);
            this.FileBrowser.Name = "FileBrowser";
            this.FileBrowser.Size = new System.Drawing.Size(791, 43);
            this.FileBrowser.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(713, 197);
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
            this.ProgressBar.Location = new System.Drawing.Point(270, 205);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(397, 24);
            this.ProgressBar.TabIndex = 2;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(162, 208);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(68, 20);
            this.ProgressLabel.TabIndex = 3;
            this.ProgressLabel.Text = "Progress:";
            // 
            // ErrorProviderFormat
            // 
            this.ErrorProviderFormat.ContainerControl = this;
            // 
            // CreateModelBtn
            // 
            this.CreateModelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateModelBtn.Location = new System.Drawing.Point(401, 39);
            this.CreateModelBtn.Name = "CreateModelBtn";
            this.CreateModelBtn.Size = new System.Drawing.Size(143, 45);
            this.CreateModelBtn.TabIndex = 5;
            this.CreateModelBtn.Text = "Creative mode";
            this.CreateModelBtn.UseVisualStyleBackColor = true;
            this.CreateModelBtn.Click += new System.EventHandler(this.CreateModelBtn_Click);
            // 
            // InteractiveResultsBtn
            // 
            this.InteractiveResultsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InteractiveResultsBtn.Enabled = false;
            this.InteractiveResultsBtn.Location = new System.Drawing.Point(714, 256);
            this.InteractiveResultsBtn.Name = "InteractiveResultsBtn";
            this.InteractiveResultsBtn.Size = new System.Drawing.Size(143, 45);
            this.InteractiveResultsBtn.TabIndex = 6;
            this.InteractiveResultsBtn.Text = "See results in app";
            this.InteractiveResultsBtn.UseVisualStyleBackColor = true;
            this.InteractiveResultsBtn.Click += new System.EventHandler(this.InteractiveResultsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 342);
            this.Controls.Add(this.InteractiveResultsBtn);
            this.Controls.Add(this.CreateModelBtn);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.FileBrowser);
            this.MaximumSize = new System.Drawing.Size(1100, 450);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFormat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileBrowser FileBrowser;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ErrorProvider ErrorProviderFormat;
        private System.Windows.Forms.Button CreateModelBtn;
        private System.Windows.Forms.Button InteractiveResultsBtn;
    }
}


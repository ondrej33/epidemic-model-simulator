using System;
using System.Windows.Forms;

namespace Project
{
    public partial class FileBrowser : UserControl
    {
        public string Path
        {
            get => textBoxPath.Text;
            private set
            {
                textBoxPath.Text = value;
            }
        }
        public FileBrowser()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog(ParentForm) != DialogResult.OK)
            {
                return;
            }
            Path = dialog.FileName;
        }
    }
}

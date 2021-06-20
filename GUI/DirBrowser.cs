using System;
using System.Windows.Forms;

namespace Project
{
    public partial class DirBrowser : UserControl
    {
        public DirBrowser()
        {
            InitializeComponent();
        }
        public string DirPath
        {
            get => textBoxPath.Text;
            private set
            {
                textBoxPath.Text = value;
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog(ParentForm) != DialogResult.OK)
            {
                return;
            }
            DirPath = dialog.SelectedPath;
        }
    }
}

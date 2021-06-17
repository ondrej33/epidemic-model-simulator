using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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
            if (dialog.ShowDialog(this.ParentForm) != DialogResult.OK)
            {
                return;
            }
            Path = dialog.FileName;
        }
    }
}

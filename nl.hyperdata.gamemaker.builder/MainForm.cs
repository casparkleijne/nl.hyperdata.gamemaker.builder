using nl.hyperdata.gamemaker.yy.Resources;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nl.hyperdata.gamemaker.builder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void bt_GameMakerProject_Click(object sender, EventArgs e)
        {
            var file = ChooseFile();
            toolTip.SetToolTip(sender as Control, file);
            ResourceProvider provider = new ResourceProvider(file);

            var result = await provider.GameResource();
            var resources = result.Resources().Extensions();

            
        }

        private void bt_Process_Click(object sender, EventArgs e)
        {
            if (extensionList.SelectedIndex < 0)
            {
                return;
            }

            var confirmResult = MessageBox.Show(extensionList.SelectedItem.ToString(),
                                    "Are you sure to update this extension?",
                                     MessageBoxButtons.OKCancel);

            if (confirmResult == DialogResult.OK)
            {

            }
            else
            {

            }
        }

        private void bt_DllExportFile_Click(object sender, EventArgs e)
        {
            toolTip.SetToolTip(sender as Control, ChooseFile());
        }

        private void bt_DllExtensionFile_Click(object sender, EventArgs e)
        {
            toolTip.SetToolTip(sender as Control, ChooseFile());
        }

        public string ChooseFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "n/a";
        }

        public string ChooseFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            return "n/a";
        }

        private void extensionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_Process.Enabled = extensionList.SelectedIndex >= 0;
        }
    }
}

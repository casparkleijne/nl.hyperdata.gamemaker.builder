using nl.hyperdata.gamemaker.builder.GameMaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_GameMakerProject_Click(object sender, EventArgs e)
        {
            var file = ChooseFile();
            toolTip.SetToolTip(sender as Control,file);
            string path = Path.GetDirectoryName(file);

            ResourceProvider provider = new ResourceProvider(file);

            provider.LoadFromFile();
            var u = provider.Resources
                .AllExtensions()
                .FirstOrDefault();


       

            foreach (var item in provider.Resources.AllExtensionNames().Distinct())
            {
                listBox1.Items.Add(item);
            }

            provider.SaveChanges();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using PictureView.ViewModels;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PictureView
{
    public partial class PictureView : Form
    {
        public PictureView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = fbSource.ShowDialog();


            if (result == DialogResult.OK)
            {
                tbFolder.Text = fbSource.SelectedPath;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbNotes.Text = "In progress...";
            tbNotes.Refresh();
            lvResults.Clear();

            var di = new DirectoryInfo(tbFolder.Text);
            var extensionCounts = di.EnumerateFiles("*.*", SearchOption.AllDirectories)
                                    .GroupBy(x => x.Extension)
                                    .Select(g => new { Extension = g.Key, Count = g.Count() })
                                    .ToList();

            lvResults.View = View.Details;
            lvResults.Columns.Add("Ext");
            lvResults.Columns.Add("Count");
            lvResults.FullRowSelect = true;


            foreach (var group in extensionCounts)
            {
                ListViewItem item = new ListViewItem(group.Extension);
                item.SubItems.Add(group.Count.ToString());

                lvResults.Items.Add(item);
            }
            tbNotes.Text = "End";
            tbNotes.Refresh();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(tbFile.Text);
            MessageBox.Show(img.Width + "x" + img.Height);
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            DialogResult result = fdSource.ShowDialog();


            if (result == DialogResult.OK)
            {
                tbFile.Text = fdSource.FileName;
            }
        }

        private void btnSaveToDatabae_Click(object sender, EventArgs e)
        {
            int Count = 0;
            DatabaseManager dbManager = new DatabaseManager();
            DirectoryInfo d = new DirectoryInfo(tbFolder.Text);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.jpg"); //Getting files
            foreach (FileInfo file in Files)
            {
                Image img = Image.FromFile(file.FullName);

                dbManager.SaveData(file.Name, file.DirectoryName, img.Width + "x" + img.Height);
                Count += 1;
                tbCount.Text = Count.ToString();
                tbCount.Refresh();
            }
            tbNotes.Text = "Inserted in DB";
            tbNotes.Refresh();
        }
    }
}

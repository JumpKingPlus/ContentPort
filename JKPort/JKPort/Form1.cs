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

namespace JKPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region data
        public struct ItemData
        {
            public string Title;
            public string Directory;
            public string[] Files;
            public object Data;
            public Type DataType;
            public string Output;
        }

        private static ItemData data = new ItemData();
        public static ItemData Data { get { return data; } set { data = value; } }

        private void FlushData()
        {
            data = new ItemData();
        }
        #endregion

        private void input_button_Click(object sender, EventArgs e)
        {
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                data.Directory = folder_dialog.SelectedPath;
                // if succeeded
                output_dir.Text = folder_dialog.SelectedPath + $"/bin";
            }
        }

        private void files_button_Click(object sender, EventArgs e)
        {
            string message = "";
            if (files_dialog.ShowDialog() == DialogResult.OK)
            {
                // quantity file check
                if (files_dialog.FileNames.Length < 2)
                {
                    MessageBox.Show(
                        "The items you chose do not correspond to a structure of an item. " +
                        "You need to select all the packed files and the configuration file.",
                        "You can't select one file only!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                foreach (string file in files_dialog.FileNames)
                {
                    message += Path.GetFileName(file) + " - " + file + Environment.NewLine;
                }
                MessageBox.Show(message);
            }
        }

        private void output_folder_Click(object sender, EventArgs e)
        {
            if (folder_dialog.ShowDialog() == DialogResult.OK)
                output_dir.Text = folder_dialog.SelectedPath;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            progress_box.Visible = true;
        }
    }
}

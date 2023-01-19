using JKPort.Properties;
using JumpKing;
using JumpKingPlus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public enum ItemType
        {
            Level,
            Skin,
            Set
        }

        public struct ItemData
        {
            public string Title;
            public string Directory;
            public string[] Files;
            public object Data;
            public ItemType Type;
            public string Output;
        }

        private static ItemData data = new ItemData();
        public static ItemData Data { get { return data; } set { data = value; } }

        private void FlushData()
        {
            data = new ItemData();
        }
        private void FlushUIData()
        {
            details.Text = "Item details";
            item_type.Text = null;
            item_dir.Text = null;
            item_size.Text = null;
            output_dir.Text = null;
            convert.Enabled = false;
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

                var files = files_dialog.FileNames;
                var directory = Path.GetDirectoryName(files[0]);

                // deadass used select files for levels 💀
                if (files.Contains($"{directory}\\mod.xml"))
                {
                    MessageBox.Show(
                        "Select files is made only for reskins and collections.\n" +
                        "Use the \"Select folder...\" button to convert levels!",
                        "Wrong conversion button",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                    return;
                }

                bool has_xml = false;
                long size = 0;
                string config_path = null;

                foreach (string path in files)
                {
                    if (path.EndsWith(".xml"))
                    {
                        // too many xmls
                        if (has_xml)
                        {
                            MessageBox.Show(
                                "You selected more than one configuration file.\n" +
                                "Make sure you ONLY select the configuration file (the xml file) that your item needs.",
                                "Redundant XML files",
                                MessageBoxButtons.OK, MessageBoxIcon.Error
                            );
                            return;
                        }
                        config_path = path;
                        has_xml = true;
                    }
                    size += new FileInfo(path).Length;
                }

                // no xml
                if (!has_xml)
                {
                    MessageBox.Show(
                        "You didn't select any configuration file.\n" +
                        "Make sure you select the configuration file (the xml file).",
                        "Missing XML file",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                    return;
                }

                float f_size = size / 1048576f;

                data.Files = files;
                data.Directory = directory;

                WardrobeSettings settings = XmlSerializerHelper.Deserialize<WardrobeSettings>(config_path);
                data.Data = settings;
                data.Type = settings.isCollection ? ItemType.Set : ItemType.Skin;
                data.Title = settings.isCollection ? settings.collection.Value.name : settings.name;

                // show data
                details.Text = data.Title;
                item_type.Text = data.Type.ToString();
                if (settings.isCollection)
                    item_type.Text += $" (with {settings.collection.Value.Reskins.Length} skins)";
                item_dir.Text = data.Directory;
                output_dir.Text = data.Directory + "\\bin";
                item_size.Text = f_size.ToString("#.##") + " MB";
                details.Visible = true;
                convert.Enabled = true;
            }
        }

        private void output_folder_Click(object sender, EventArgs e)
        {
            if (folder_dialog.ShowDialog() == DialogResult.OK)
                output_dir.Text = folder_dialog.SelectedPath;
        }

        private void output_dir_TextChanged(object sender, EventArgs e)
        {
            data.Output = output_dir.Text;
            var void_text = string.IsNullOrWhiteSpace(output_dir.Text);
            if (!void_text && !convert.Enabled)
            {
                convert.Enabled = true;
                return;
            }
            if (void_text && convert.Enabled)
            {
                convert.Enabled = false;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            progressBarTotal.Visible = true;
            /* why did i need this???
             * if (MessageBox.Show($"{Settings.Default.is_first_time}", "setting?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Settings.Default.is_first_time = false;
            }*/

            // create folder
            if (!Directory.Exists(data.Output))
                Directory.CreateDirectory(data.Output);

            // convert based on item
            if (data.Type != ItemType.Level)
            {
                WardrobeSettings wardrobe_settings = (WardrobeSettings)data.Data;
                if (wardrobe_settings.isCollection)
                {
                    // convert xml of collection
                } else
                {
                    // convert xml of reskin
                }
            }
            else
            {
                // convert xml of level
            }

            // move files
        }
    }
}

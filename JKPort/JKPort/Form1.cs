using JKPort.DataStructure;
using JKPort.Extract;
using JKPort.Properties;
using JumpKing;
using JumpKingPlus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
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
            details.Visible = false;
            item_type.Text = null;
            item_dir.Text = null;
            item_size.Text = null;
            output_dir.Text = null;
            convert.Text = "Convert!";
            convert.Enabled = false;
            progressBarTotal.Value = 0;
            progressBarTotal.Visible = false;
        }
        #endregion

        private void input_button_Click(object sender, EventArgs e)
        {
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                var directory = folder_dialog.SelectedPath;

                // quantity file check
                if (Directory.GetFiles(directory).Length < 2)
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

                // if there are more or less than 1 xml files
                var root_files = Directory.GetFiles(directory, "*.xml", SearchOption.TopDirectoryOnly);
                if (root_files.Length != 1)
                {
                    MessageBox.Show(
                        "You must select ONE configuration file for converting your item.\n" +
                        "Make sure you ONLY select the configuration file (the xml file) that your item needs.",
                        "Missing or redundant XML files",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                    return;
                }

                // separate level from cosmetic
                if (root_files[0].EndsWith("\\mod.xml"))
                {
                    Mod settings = XmlSerializerHelper.Deserialize<Mod>(root_files[0]);
                    data.Data = settings;
                    data.Type = ItemType.Level;
                    data.Title = settings.About.title;
                } else
                {
                    WardrobeSettings settings = XmlSerializerHelper.Deserialize<WardrobeSettings>(root_files[0]);
                    data.Data = settings;
                    data.Type = settings.isCollection ? ItemType.Set : ItemType.Skin;
                    data.Title = settings.isCollection ? settings.collection.Value.name : settings.name;
                }

                long size = 0;
                foreach (string path in Directory.GetFiles(directory,"*.*", SearchOption.AllDirectories))
                    size += new FileInfo(path).Length;

                float f_size = size / 1048576f;
                data.Directory = directory;

                // show data
                details.Text = data.Title;
                item_type.Text = data.Type.ToString();

                if (data.Type == ItemType.Set)
                {
                    WardrobeSettings settings = (WardrobeSettings)data.Data;
                    item_type.Text += $" (with {settings.collection.Value.Reskins.Length} skins)";
                }

                item_dir.Text = data.Directory;
                output_dir.Text = data.Directory + "\\bin";
                item_size.Text = f_size.ToString("#.##") + " MB";
                details.Visible = true;
                convert.Enabled = true;
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
            Console.WriteLine(output_dir.Text.Length);
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
            convert.Text = "Creating folder...";
            progressBarTotal.Value = 20;
            if (!Directory.Exists(data.Output))
                Directory.CreateDirectory(data.Output);

            // convert based on item
            convert.Text = "Converting configuration...";
            progressBarTotal.Value = 40;
            if (data.Type != ItemType.Level)
            {
                WardrobeSettings wardrobe_settings = (WardrobeSettings)data.Data;
                if (wardrobe_settings.isCollection)
                {
                    // convert xml of collection
                    SetSettings set = Converter.ToSet(wardrobe_settings);
                    XmlSerializerHelper.Serialize(data.Output+ "\\set_settings.xml", set);
                } else
                {
                    // convert xml of reskin
                    ReskinSettings skin = Converter.ToSkin(wardrobe_settings);
                    XmlSerializerHelper.Serialize(data.Output + "\\cosmetic_settings.xml", skin);
                }
            }
            else
            {
                // convert xml of level
                Mod level_settings = (Mod)data.Data;
                LevelSettings level = Converter.ToLevel(level_settings);
                XmlSerializerHelper.Serialize(data.Output + "\\level_settings.xml", level);
            }

            // move files
            convert.Text = "Moving files in the output folder...";
            progressBarTotal.Value = 60;
            if (data.Files != null)
            {
                foreach (string file in data.Files)
                {
                    if (file.EndsWith(".xml"))
                        continue;

                    convert.Text = $"Extracting: {file}";
                    
                    if (file.EndsWith(".xnb"))
                    {
                        // depack
                        try
                        {
                            XnbExtractor.Extract(file, data.Output + "\\" + Path.GetFileName(file), true, true, true, false);
                        }
                        catch (Exception args)
                        {
                            MessageBox.Show(
                                $"{args.Message}\n\n{args.StackTrace}",
                                "An exception has been thrown!", 
                                MessageBoxButtons.OK
                            );
                        }
                        continue;
                    }
                    File.Copy(file, data.Output + "\\" + Path.GetFileName(file), true);
                }

                // done
                convert.Text = "Done!";
                progressBarTotal.Value = 100;

                if (MessageBox.Show(
                "Your item has successfully converted to be compatible with Jump King.\n\n" +
                "Would you like to open the folder containing your item?",
                "Item successfully converted!",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Process.Start($@"{data.Output}");

                // clear
                FlushData();
                FlushUIData();
                return;
            }

            Copy(data.Directory, data.Output);
            if (FailedExtracting.Count > 0)
            {
                string text = "Content Port couldn't decompile the following files:\n";
                foreach (string item in FailedExtracting)
                {
                    text += "\n";
                    text += item.Replace(data.Directory+"\\", "");
                }
                text += "\n\nIf you want to open the following item on Worldsmith, you will need to find and place the original non-XNB (not compiled) files in their respective folders in order to open it on Worldsmith!" +
                    "\n\nIf you HAVE access to all your original/not-compiled missing files listed above, click \"Yes\"." +
                    "\n\nIf you DON'T KNOW or DON'T HAVE access to your original/not-compiled missing files listed above, click \"No\".";

                var result = MessageBox.Show(
                    text: text,
                    caption: "Some files couldn't be extracted/decompiled!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string txtfile = "Content Port left off for you to find the following files:\n";
                    foreach (string item in FailedExtracting)
                    {
                        txtfile += "\n";
                        txtfile += item.Replace(".xnb", "");
                    }
                    txtfile += "\n\nOnce you have found all the files and placed them in their relative folders, your item is ready to be used on Worldsmith.\nIf you don't have the following files, convert your item again and follow the details on screen." +
                        "\n\njingsupalike sorry for the inconvenience.";
                    
                    string fileName = $@"{data.Directory}\FILES_MISSING.txt";
                    File.Delete(fileName);
                    File.WriteAllText($@"{data.Directory}\FILES_MISSING.txt", txtfile);
                    Process.Start("notepad.exe", fileName);
                }
                else
                {
                    // this is held by duct tape but works
                    Directory.CreateDirectory(data.Directory + "\\temp\\");
                    File.Move(data.Output + "\\level_settings.xml", data.Directory + $"\\temp\\level_settings.xml");
                    Directory.Delete(data.Output, true);
                    Directory.CreateDirectory(data.Output);
                    File.Move(data.Directory + $"\\temp\\level_settings.xml", data.Output + "\\level_settings.xml");
                    Directory.Delete(data.Directory + "\\temp", true);

                    Copy(data.Directory, data.Output, true);

                    var open_website = MessageBox.Show("In order to upload your item, you will need to use the legacy version of Worldsmith.", "Not compatible with Worldsmith", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (open_website == DialogResult.Yes)
                    {
                        //Process.Start(url);
                    }
                }
            }

            if (data.Type == ItemType.Level)
            {
                // should work
                File.Move(data.Output + "/props/textures/raven/gold_ring.png", data.Output + "/props/worlditems/gold_ring.png");
                File.Move(data.Output + "/props/textures/raven/ruby.png", data.Output + "/props/worlditems/ruby.png");
            }

            // clearing out folder
            convert.Text = "Clearing out folder...";
            progressBarTotal.Value = 80;
            foreach (string path in Directory.GetFiles(data.Output, "*.xml", SearchOption.TopDirectoryOnly))
            {
                var name = Path.GetFileName(path);
                if (!(name == "level_settings.xml" || name == "cosmetic_settings.xml" || name == "set_settings.xml"))
                {
                    File.Delete(path);
                }
            }

            // done
            convert.Text = "Done!";
            progressBarTotal.Value = 100;

            if (MessageBox.Show(
                "Your item has successfully converted to be compatible with Jump King.\n\n" +
                "Would you like to open the folder containing your item?",
                "Item successfully converted!",
                MessageBoxButtons.YesNo ) == DialogResult.Yes)
                Process.Start($@"{data.Output}");

            // clear
            FlushData();
            FlushUIData();
            FailedExtracting.Clear();
        }

        public static List<string> FailedExtracting = new List<string>();


        #region copy folder
    private void Copy(string sourceDir, string targetDir, bool forceCopy = false)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                if (file.StartsWith(targetDir))
                    continue;

                if (!file.EndsWith(".xnb") || forceCopy)
                    File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);
                else
                {
                    try
                    {
                        XnbExtractor.Extract(file, Path.Combine(targetDir, Path.GetFileName(file)), true, true, true, false);
                    }
                    catch (Exception args)
                    {
                        FailedExtracting.Add(file);
                        //MessageBox.Show(
                        //    $"{args.Message}\n\n{args.StackTrace}",
                        //    "An exception has been thrown!",
                        //    MessageBoxButtons.OK
                        //);
                    }
                }
            }

            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                if (directory.StartsWith(targetDir) || directory.EndsWith("\\font"))
                    continue;
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
            }
        }
        #endregion
    }
}

namespace JKPort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.banner_panel = new System.Windows.Forms.TableLayoutPanel();
            this.banner_label = new System.Windows.Forms.Label();
            this.banner_image = new System.Windows.Forms.PictureBox();
            this.porting_table_input = new System.Windows.Forms.TableLayoutPanel();
            this.folder_button_label = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.files_button_label = new System.Windows.Forms.Label();
            this.input_button = new System.Windows.Forms.Button();
            this.files_button = new System.Windows.Forms.Button();
            this.output_panel = new System.Windows.Forms.TableLayoutPanel();
            this.output_label = new System.Windows.Forms.Label();
            this.output_folder = new System.Windows.Forms.Button();
            this.output_dir = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.GroupBox();
            this.details_table = new System.Windows.Forms.TableLayoutPanel();
            this.item_size = new System.Windows.Forms.Label();
            this.item_dir = new System.Windows.Forms.Label();
            this.item_type = new System.Windows.Forms.Label();
            this.item_dir_label = new System.Windows.Forms.PictureBox();
            this.item_type_label = new System.Windows.Forms.PictureBox();
            this.item_size_label = new System.Windows.Forms.PictureBox();
            this.convert = new System.Windows.Forms.Button();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.files_dialog = new System.Windows.Forms.OpenFileDialog();
            this.folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.main_panel.SuspendLayout();
            this.banner_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner_image)).BeginInit();
            this.porting_table_input.SuspendLayout();
            this.output_panel.SuspendLayout();
            this.details.SuspendLayout();
            this.details_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_dir_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_type_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_size_label)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_panel.Controls.Add(this.banner_panel);
            this.main_panel.Controls.Add(this.porting_table_input);
            this.main_panel.Controls.Add(this.output_panel);
            this.main_panel.Controls.Add(this.details);
            this.main_panel.Controls.Add(this.convert);
            this.main_panel.Controls.Add(this.progressBarTotal);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Padding = new System.Windows.Forms.Padding(5);
            this.main_panel.Size = new System.Drawing.Size(1067, 836);
            this.main_panel.TabIndex = 0;
            // 
            // banner_panel
            // 
            this.banner_panel.BackColor = System.Drawing.Color.LemonChiffon;
            this.banner_panel.ColumnCount = 2;
            this.banner_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.banner_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.banner_panel.Controls.Add(this.banner_label, 1, 0);
            this.banner_panel.Controls.Add(this.banner_image, 0, 0);
            this.banner_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banner_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banner_panel.Location = new System.Drawing.Point(9, 9);
            this.banner_panel.Margin = new System.Windows.Forms.Padding(4);
            this.banner_panel.Name = "banner_panel";
            this.banner_panel.RowCount = 1;
            this.banner_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.banner_panel.Size = new System.Drawing.Size(588, 87);
            this.banner_panel.TabIndex = 12;
            this.banner_panel.Visible = false;
            // 
            // banner_label
            // 
            this.banner_label.AutoSize = true;
            this.banner_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banner_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.banner_label.Location = new System.Drawing.Point(84, 7);
            this.banner_label.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.banner_label.Name = "banner_label";
            this.banner_label.Padding = new System.Windows.Forms.Padding(4);
            this.banner_label.Size = new System.Drawing.Size(500, 73);
            this.banner_label.TabIndex = 11;
            this.banner_label.Text = "\'JumpKingPlus Content Port\' is currently in beta.\r\nLet us know if you find any is" +
    "sues or bugs over on the official Jump King Discord server.\r\nJumpKingPlus, 2023." +
    "";
            // 
            // banner_image
            // 
            this.banner_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banner_image.Image = global::JKPort.Properties.Resources.favicon;
            this.banner_image.Location = new System.Drawing.Point(12, 11);
            this.banner_image.Margin = new System.Windows.Forms.Padding(12, 11, 4, 11);
            this.banner_image.Name = "banner_image";
            this.banner_image.Size = new System.Drawing.Size(64, 65);
            this.banner_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner_image.TabIndex = 12;
            this.banner_image.TabStop = false;
            // 
            // porting_table_input
            // 
            this.porting_table_input.AutoSize = true;
            this.porting_table_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.porting_table_input.ColumnCount = 2;
            this.porting_table_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.porting_table_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.porting_table_input.Controls.Add(this.folder_button_label, 1, 2);
            this.porting_table_input.Controls.Add(this.input_label, 0, 0);
            this.porting_table_input.Controls.Add(this.files_button_label, 1, 1);
            this.porting_table_input.Controls.Add(this.input_button, 0, 2);
            this.porting_table_input.Controls.Add(this.files_button, 0, 1);
            this.porting_table_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.porting_table_input.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.porting_table_input.Location = new System.Drawing.Point(9, 107);
            this.porting_table_input.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.porting_table_input.Name = "porting_table_input";
            this.porting_table_input.RowCount = 3;
            this.porting_table_input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.porting_table_input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.porting_table_input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.porting_table_input.Size = new System.Drawing.Size(588, 102);
            this.porting_table_input.TabIndex = 2;
            // 
            // folder_button_label
            // 
            this.folder_button_label.AutoSize = true;
            this.folder_button_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folder_button_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder_button_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.folder_button_label.Location = new System.Drawing.Point(129, 75);
            this.folder_button_label.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.folder_button_label.Name = "folder_button_label";
            this.folder_button_label.Size = new System.Drawing.Size(455, 20);
            this.folder_button_label.TabIndex = 7;
            this.folder_button_label.Text = "Works for everything.";
            this.folder_button_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.porting_table_input.SetColumnSpan(this.input_label, 2);
            this.input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label.Location = new System.Drawing.Point(4, 7);
            this.input_label.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(280, 20);
            this.input_label.TabIndex = 3;
            this.input_label.Text = "Select your item\'s files or folder";
            // 
            // files_button_label
            // 
            this.files_button_label.AutoSize = true;
            this.files_button_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files_button_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_button_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.files_button_label.Location = new System.Drawing.Point(129, 41);
            this.files_button_label.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.files_button_label.Name = "files_button_label";
            this.files_button_label.Size = new System.Drawing.Size(455, 20);
            this.files_button_label.TabIndex = 6;
            this.files_button_label.Text = "Optimized for reskins and collections.";
            this.files_button_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_button
            // 
            this.input_button.AutoSize = true;
            this.input_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_button.Image = global::JKPort.Properties.Resources.OpenFolder;
            this.input_button.Location = new System.Drawing.Point(4, 72);
            this.input_button.Margin = new System.Windows.Forms.Padding(4);
            this.input_button.Name = "input_button";
            this.input_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_button.Size = new System.Drawing.Size(117, 26);
            this.input_button.TabIndex = 0;
            this.input_button.Text = "Select folder...";
            this.input_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // files_button
            // 
            this.files_button.AutoSize = true;
            this.files_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.files_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files_button.Image = global::JKPort.Properties.Resources.DocumentCollection;
            this.files_button.Location = new System.Drawing.Point(4, 38);
            this.files_button.Margin = new System.Windows.Forms.Padding(4);
            this.files_button.Name = "files_button";
            this.files_button.Size = new System.Drawing.Size(117, 26);
            this.files_button.TabIndex = 4;
            this.files_button.Text = "Select files...";
            this.files_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.files_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.files_button.UseVisualStyleBackColor = true;
            this.files_button.Click += new System.EventHandler(this.files_button_Click);
            // 
            // output_panel
            // 
            this.output_panel.AutoSize = true;
            this.output_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.output_panel.ColumnCount = 2;
            this.output_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.output_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.output_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.output_panel.Controls.Add(this.output_label, 0, 0);
            this.output_panel.Controls.Add(this.output_folder, 1, 1);
            this.output_panel.Controls.Add(this.output_dir, 0, 1);
            this.output_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.output_panel.Location = new System.Drawing.Point(9, 220);
            this.output_panel.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.output_panel.Name = "output_panel";
            this.output_panel.RowCount = 2;
            this.output_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.output_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.output_panel.Size = new System.Drawing.Size(588, 68);
            this.output_panel.TabIndex = 3;
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_panel.SetColumnSpan(this.output_label, 2);
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.Location = new System.Drawing.Point(4, 7);
            this.output_label.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(119, 20);
            this.output_label.TabIndex = 3;
            this.output_label.Text = "Output folder";
            // 
            // output_folder
            // 
            this.output_folder.AutoSize = true;
            this.output_folder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.output_folder.Image = global::JKPort.Properties.Resources.ReplaceInFolder;
            this.output_folder.Location = new System.Drawing.Point(467, 38);
            this.output_folder.Margin = new System.Windows.Forms.Padding(4);
            this.output_folder.Name = "output_folder";
            this.output_folder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output_folder.Size = new System.Drawing.Size(117, 26);
            this.output_folder.TabIndex = 0;
            this.output_folder.Text = "Select folder...";
            this.output_folder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.output_folder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.output_folder.UseVisualStyleBackColor = true;
            this.output_folder.Click += new System.EventHandler(this.output_folder_Click);
            // 
            // output_dir
            // 
            this.output_dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_dir.Location = new System.Drawing.Point(4, 38);
            this.output_dir.Margin = new System.Windows.Forms.Padding(4);
            this.output_dir.Name = "output_dir";
            this.output_dir.Size = new System.Drawing.Size(455, 22);
            this.output_dir.TabIndex = 1;
            this.output_dir.TextChanged += new System.EventHandler(this.output_dir_TextChanged);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.details.Controls.Add(this.details_table);
            this.details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(9, 299);
            this.details.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.details.Name = "details";
            this.details.Padding = new System.Windows.Forms.Padding(4);
            this.details.Size = new System.Drawing.Size(588, 131);
            this.details.TabIndex = 10;
            this.details.TabStop = false;
            this.details.Text = "Item details";
            this.details.Visible = false;
            // 
            // details_table
            // 
            this.details_table.AutoSize = true;
            this.details_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.details_table.ColumnCount = 2;
            this.details_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.details_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.details_table.Controls.Add(this.item_size, 1, 2);
            this.details_table.Controls.Add(this.item_dir, 1, 1);
            this.details_table.Controls.Add(this.item_type, 1, 0);
            this.details_table.Controls.Add(this.item_dir_label, 0, 1);
            this.details_table.Controls.Add(this.item_type_label, 0, 0);
            this.details_table.Controls.Add(this.item_size_label, 0, 2);
            this.details_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.details_table.Location = new System.Drawing.Point(4, 23);
            this.details_table.Margin = new System.Windows.Forms.Padding(4);
            this.details_table.Name = "details_table";
            this.details_table.Padding = new System.Windows.Forms.Padding(4);
            this.details_table.RowCount = 3;
            this.details_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.details_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.details_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.details_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.details_table.Size = new System.Drawing.Size(580, 104);
            this.details_table.TabIndex = 0;
            // 
            // item_size
            // 
            this.item_size.AutoSize = true;
            this.item_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_size.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_size.Location = new System.Drawing.Point(44, 76);
            this.item_size.Margin = new System.Windows.Forms.Padding(8, 8, 4, 4);
            this.item_size.Name = "item_size";
            this.item_size.Size = new System.Drawing.Size(19, 16);
            this.item_size.TabIndex = 5;
            this.item_size.Text = "---";
            // 
            // item_dir
            // 
            this.item_dir.AutoSize = true;
            this.item_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_dir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_dir.Location = new System.Drawing.Point(44, 44);
            this.item_dir.Margin = new System.Windows.Forms.Padding(8, 8, 4, 4);
            this.item_dir.MaximumSize = new System.Drawing.Size(480, 82);
            this.item_dir.Name = "item_dir";
            this.item_dir.Size = new System.Drawing.Size(19, 16);
            this.item_dir.TabIndex = 7;
            this.item_dir.Text = "---";
            // 
            // item_type
            // 
            this.item_type.AutoSize = true;
            this.item_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.item_type.Location = new System.Drawing.Point(44, 10);
            this.item_type.Margin = new System.Windows.Forms.Padding(8, 6, 4, 4);
            this.item_type.Name = "item_type";
            this.item_type.Size = new System.Drawing.Size(23, 18);
            this.item_type.TabIndex = 3;
            this.item_type.Text = "---";
            // 
            // item_dir_label
            // 
            this.item_dir_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_dir_label.Image = global::JKPort.Properties.Resources.FolderInformation;
            this.item_dir_label.Location = new System.Drawing.Point(12, 44);
            this.item_dir_label.Margin = new System.Windows.Forms.Padding(8);
            this.item_dir_label.Name = "item_dir_label";
            this.item_dir_label.Size = new System.Drawing.Size(16, 16);
            this.item_dir_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item_dir_label.TabIndex = 14;
            this.item_dir_label.TabStop = false;
            // 
            // item_type_label
            // 
            this.item_type_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_type_label.Image = global::JKPort.Properties.Resources.StatusInformation;
            this.item_type_label.Location = new System.Drawing.Point(12, 12);
            this.item_type_label.Margin = new System.Windows.Forms.Padding(8);
            this.item_type_label.Name = "item_type_label";
            this.item_type_label.Size = new System.Drawing.Size(16, 16);
            this.item_type_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item_type_label.TabIndex = 8;
            this.item_type_label.TabStop = false;
            // 
            // item_size_label
            // 
            this.item_size_label.Image = global::JKPort.Properties.Resources.FolderSuppressed;
            this.item_size_label.Location = new System.Drawing.Point(12, 76);
            this.item_size_label.Margin = new System.Windows.Forms.Padding(8);
            this.item_size_label.Name = "item_size_label";
            this.item_size_label.Size = new System.Drawing.Size(16, 16);
            this.item_size_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item_size_label.TabIndex = 15;
            this.item_size_label.TabStop = false;
            // 
            // convert
            // 
            this.convert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convert.Enabled = false;
            this.convert.Location = new System.Drawing.Point(9, 441);
            this.convert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(588, 28);
            this.convert.TabIndex = 13;
            this.convert.Text = "Convert!";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarTotal.Location = new System.Drawing.Point(9, 480);
            this.progressBarTotal.Margin = new System.Windows.Forms.Padding(4, 4, 7, 4);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(585, 30);
            this.progressBarTotal.Step = 0;
            this.progressBarTotal.TabIndex = 5;
            this.progressBarTotal.Visible = false;
            // 
            // files_dialog
            // 
            this.files_dialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 836);
            this.Controls.Add(this.main_panel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpKingPlus Content Port";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.banner_panel.ResumeLayout(false);
            this.banner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner_image)).EndInit();
            this.porting_table_input.ResumeLayout(false);
            this.porting_table_input.PerformLayout();
            this.output_panel.ResumeLayout(false);
            this.output_panel.PerformLayout();
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.details_table.ResumeLayout(false);
            this.details_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_dir_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_type_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_size_label)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_panel;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.TableLayoutPanel porting_table_input;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.TableLayoutPanel details_table;
        private System.Windows.Forms.Label item_type;
        private System.Windows.Forms.Label item_size;
        private System.Windows.Forms.Label banner_label;
        private System.Windows.Forms.Label item_dir;
        private System.Windows.Forms.TableLayoutPanel banner_panel;
        private System.Windows.Forms.PictureBox banner_image;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TableLayoutPanel output_panel;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Button output_folder;
        private System.Windows.Forms.TextBox output_dir;
        private System.Windows.Forms.Button files_button;
        private System.Windows.Forms.Label files_button_label;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label folder_button_label;
        private System.Windows.Forms.OpenFileDialog files_dialog;
        private System.Windows.Forms.FolderBrowserDialog folder_dialog;
        private System.Windows.Forms.PictureBox item_type_label;
        private System.Windows.Forms.PictureBox item_dir_label;
        private System.Windows.Forms.PictureBox item_size_label;
    }
}


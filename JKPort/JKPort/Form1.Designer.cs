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
            this.porting_table_input = new System.Windows.Forms.TableLayoutPanel();
            this.details = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.item_size = new System.Windows.Forms.Label();
            this.item_size_label = new System.Windows.Forms.Label();
            this.item_dir_label = new System.Windows.Forms.Label();
            this.item_title = new System.Windows.Forms.Label();
            this.item_dir = new System.Windows.Forms.Label();
            this.item_type = new System.Windows.Forms.Label();
            this.progress_box = new System.Windows.Forms.GroupBox();
            this.progress_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.total_task_layout = new System.Windows.Forms.TableLayoutPanel();
            this.progress_total = new System.Windows.Forms.Label();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.input_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.input_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.total_task_image = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.porting_table_input.SuspendLayout();
            this.details.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.progress_box.SuspendLayout();
            this.progress_panel.SuspendLayout();
            this.total_task_layout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_task_image)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_panel.Controls.Add(this.tableLayoutPanel2);
            this.main_panel.Controls.Add(this.porting_table_input);
            this.main_panel.Controls.Add(this.tableLayoutPanel3);
            this.main_panel.Controls.Add(this.details);
            this.main_panel.Controls.Add(this.button2);
            this.main_panel.Controls.Add(this.progress_box);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Padding = new System.Windows.Forms.Padding(4);
            this.main_panel.Size = new System.Drawing.Size(800, 679);
            this.main_panel.TabIndex = 0;
            // 
            // porting_table_input
            // 
            this.porting_table_input.AutoSize = true;
            this.porting_table_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.porting_table_input.ColumnCount = 2;
            this.porting_table_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.porting_table_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.porting_table_input.Controls.Add(this.label3, 1, 2);
            this.porting_table_input.Controls.Add(this.input_label, 0, 0);
            this.porting_table_input.Controls.Add(this.label4, 1, 1);
            this.porting_table_input.Controls.Add(this.input_button, 0, 2);
            this.porting_table_input.Controls.Add(this.button3, 0, 1);
            this.porting_table_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.porting_table_input.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.porting_table_input.Location = new System.Drawing.Point(7, 87);
            this.porting_table_input.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.porting_table_input.Name = "porting_table_input";
            this.porting_table_input.RowCount = 3;
            this.porting_table_input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.porting_table_input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.porting_table_input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.porting_table_input.Size = new System.Drawing.Size(441, 86);
            this.porting_table_input.TabIndex = 2;
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.details.Controls.Add(this.tableLayoutPanel1);
            this.details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.details.Location = new System.Drawing.Point(7, 248);
            this.details.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(441, 100);
            this.details.TabIndex = 10;
            this.details.TabStop = false;
            this.details.Text = "Item details";
            this.details.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.item_size, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.item_size_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.item_dir_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.item_title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.item_dir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.item_type, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // item_size
            // 
            this.item_size.AutoSize = true;
            this.item_size.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_size.Location = new System.Drawing.Point(69, 59);
            this.item_size.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.item_size.Name = "item_size";
            this.item_size.Size = new System.Drawing.Size(16, 13);
            this.item_size.TabIndex = 5;
            this.item_size.Text = "---";
            // 
            // item_size_label
            // 
            this.item_size_label.AutoSize = true;
            this.item_size_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_size_label.Location = new System.Drawing.Point(6, 59);
            this.item_size_label.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.item_size_label.Name = "item_size_label";
            this.item_size_label.Size = new System.Drawing.Size(57, 13);
            this.item_size_label.TabIndex = 4;
            this.item_size_label.Text = "Folder size";
            // 
            // item_dir_label
            // 
            this.item_dir_label.AutoSize = true;
            this.item_dir_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_dir_label.Location = new System.Drawing.Point(6, 34);
            this.item_dir_label.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.item_dir_label.Name = "item_dir_label";
            this.item_dir_label.Size = new System.Drawing.Size(49, 13);
            this.item_dir_label.TabIndex = 6;
            this.item_dir_label.Text = "Directory";
            // 
            // item_title
            // 
            this.item_title.AutoSize = true;
            this.item_title.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_title.Location = new System.Drawing.Point(6, 9);
            this.item_title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.item_title.Name = "item_title";
            this.item_title.Size = new System.Drawing.Size(27, 13);
            this.item_title.TabIndex = 0;
            this.item_title.Text = "Title";
            // 
            // item_dir
            // 
            this.item_dir.AutoSize = true;
            this.item_dir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_dir.Location = new System.Drawing.Point(69, 34);
            this.item_dir.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.item_dir.Name = "item_dir";
            this.item_dir.Size = new System.Drawing.Size(16, 13);
            this.item_dir.TabIndex = 7;
            this.item_dir.Text = "---";
            // 
            // item_type
            // 
            this.item_type.AutoSize = true;
            this.item_type.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_type.Location = new System.Drawing.Point(69, 9);
            this.item_type.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.item_type.Name = "item_type";
            this.item_type.Size = new System.Drawing.Size(16, 13);
            this.item_type.TabIndex = 3;
            this.item_type.Text = "---";
            // 
            // progress_box
            // 
            this.progress_box.AutoSize = true;
            this.progress_box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progress_box.Controls.Add(this.progress_panel);
            this.progress_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_box.Location = new System.Drawing.Point(7, 392);
            this.progress_box.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.progress_box.Name = "progress_box";
            this.progress_box.Size = new System.Drawing.Size(441, 71);
            this.progress_box.TabIndex = 7;
            this.progress_box.TabStop = false;
            this.progress_box.Text = "Progress";
            this.progress_box.Visible = false;
            // 
            // progress_panel
            // 
            this.progress_panel.AutoSize = true;
            this.progress_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progress_panel.Controls.Add(this.total_task_layout);
            this.progress_panel.Controls.Add(this.progressBarTotal);
            this.progress_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.progress_panel.Location = new System.Drawing.Point(3, 16);
            this.progress_panel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.progress_panel.Name = "progress_panel";
            this.progress_panel.Size = new System.Drawing.Size(435, 52);
            this.progress_panel.TabIndex = 0;
            // 
            // total_task_layout
            // 
            this.total_task_layout.AutoSize = true;
            this.total_task_layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.total_task_layout.ColumnCount = 2;
            this.total_task_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.total_task_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.total_task_layout.Controls.Add(this.total_task_image, 0, 0);
            this.total_task_layout.Controls.Add(this.progress_total, 1, 0);
            this.total_task_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_task_layout.Location = new System.Drawing.Point(3, 3);
            this.total_task_layout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.total_task_layout.Name = "total_task_layout";
            this.total_task_layout.RowCount = 1;
            this.total_task_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.total_task_layout.Size = new System.Drawing.Size(429, 19);
            this.total_task_layout.TabIndex = 10;
            // 
            // progress_total
            // 
            this.progress_total.AutoSize = true;
            this.progress_total.Location = new System.Drawing.Point(21, 3);
            this.progress_total.Margin = new System.Windows.Forms.Padding(3);
            this.progress_total.Name = "progress_total";
            this.progress_total.Size = new System.Drawing.Size(54, 13);
            this.progress_total.TabIndex = 6;
            this.progress_total.Text = "Total task";
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(3, 25);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(429, 24);
            this.progressBarTotal.Step = 0;
            this.progressBarTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(63, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(375, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "\'JumpKingPlus Content Port\' is currently in beta.\r\nLet us know if you find any is" +
    "sues or bugs over on the official Jump King Discord server.\r\nJumpKingPlus, 2023." +
    "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 71);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.porting_table_input.SetColumnSpan(this.input_label, 2);
            this.input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label.Location = new System.Drawing.Point(3, 6);
            this.input_label.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(225, 16);
            this.input_label.TabIndex = 3;
            this.input_label.Text = "Select your item\'s files or folder";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 182);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(441, 57);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output folder";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(7, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(441, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Convert!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(110, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Optimized for reskins and collections.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::JKPort.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9, 9, 3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // input_button
            // 
            this.input_button.AutoSize = true;
            this.input_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_button.Image = global::JKPort.Properties.Resources.OpenFolder;
            this.input_button.Location = new System.Drawing.Point(3, 60);
            this.input_button.Name = "input_button";
            this.input_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_button.Size = new System.Drawing.Size(101, 23);
            this.input_button.TabIndex = 0;
            this.input_button.Text = "Select folder...";
            this.input_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.input_button.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Image = global::JKPort.Properties.Resources.DocumentCollection;
            this.button3.Location = new System.Drawing.Point(3, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Select files...";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = global::JKPort.Properties.Resources.ReplaceInFolder;
            this.button1.Location = new System.Drawing.Point(337, 31);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select folder...";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // total_task_image
            // 
            this.total_task_image.Image = global::JKPort.Properties.Resources.TaskList;
            this.total_task_image.Location = new System.Drawing.Point(1, 1);
            this.total_task_image.Margin = new System.Windows.Forms.Padding(1);
            this.total_task_image.Name = "total_task_image";
            this.total_task_image.Size = new System.Drawing.Size(16, 16);
            this.total_task_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.total_task_image.TabIndex = 9;
            this.total_task_image.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(110, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Works for everything.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 679);
            this.Controls.Add(this.main_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpKingPlus Content Port";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.porting_table_input.ResumeLayout(false);
            this.porting_table_input.PerformLayout();
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.progress_box.ResumeLayout(false);
            this.progress_box.PerformLayout();
            this.progress_panel.ResumeLayout(false);
            this.progress_panel.PerformLayout();
            this.total_task_layout.ResumeLayout(false);
            this.total_task_layout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_task_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_panel;
        private System.Windows.Forms.GroupBox progress_box;
        private System.Windows.Forms.FlowLayoutPanel progress_panel;
        private System.Windows.Forms.TableLayoutPanel total_task_layout;
        private System.Windows.Forms.PictureBox total_task_image;
        private System.Windows.Forms.Label progress_total;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.TableLayoutPanel porting_table_input;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label item_title;
        private System.Windows.Forms.Label item_type;
        private System.Windows.Forms.Label item_size_label;
        private System.Windows.Forms.Label item_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label item_dir_label;
        private System.Windows.Forms.Label item_dir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}


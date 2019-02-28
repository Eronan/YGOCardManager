namespace YGOCardManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picBox_Image = new System.Windows.Forms.PictureBox();
            this.button_Pic = new System.Windows.Forms.Button();
            this.group_Search = new System.Windows.Forms.GroupBox();
            this.textbox_Search = new System.Windows.Forms.TextBox();
            this.list_Search = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.group_CardInfo = new System.Windows.Forms.GroupBox();
            this.numUpDown_DEF = new System.Windows.Forms.NumericUpDown();
            this.label_DEF = new System.Windows.Forms.Label();
            this.numUpDown_ATK = new System.Windows.Forms.NumericUpDown();
            this.label_ATK = new System.Windows.Forms.Label();
            this.select_Attribute = new System.Windows.Forms.ComboBox();
            this.label_Attribute = new System.Windows.Forms.Label();
            this.select_Race = new System.Windows.Forms.ComboBox();
            this.label_Race = new System.Windows.Forms.Label();
            this.numUpDown_RightScale = new System.Windows.Forms.NumericUpDown();
            this.label_RightScale = new System.Windows.Forms.Label();
            this.numUpDown_LeftScale = new System.Windows.Forms.NumericUpDown();
            this.label_LeftScale = new System.Windows.Forms.Label();
            this.label_Pendulum = new System.Windows.Forms.Label();
            this.numUpDown_Level = new System.Windows.Forms.NumericUpDown();
            this.label_Level = new System.Windows.Forms.Label();
            this.select_SetCode4 = new System.Windows.Forms.ComboBox();
            this.select_SetCode3 = new System.Windows.Forms.ComboBox();
            this.select_SetCode2 = new System.Windows.Forms.ComboBox();
            this.select_SetCode1 = new System.Windows.Forms.ComboBox();
            this.label_SetCode = new System.Windows.Forms.Label();
            this.select_Format = new System.Windows.Forms.ComboBox();
            this.label_Format = new System.Windows.Forms.Label();
            this.numUpDown_Alias = new System.Windows.Forms.NumericUpDown();
            this.label_Alias = new System.Windows.Forms.Label();
            this.numUpDown_CardID = new System.Windows.Forms.NumericUpDown();
            this.label_ID = new System.Windows.Forms.Label();
            this.group_CardText = new System.Windows.Forms.GroupBox();
            this.textbox_Effect = new System.Windows.Forms.RichTextBox();
            this.label_Effect = new System.Windows.Forms.Label();
            this.textbox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.group_CardTypes = new System.Windows.Forms.GroupBox();
            this.list_Types = new System.Windows.Forms.CheckedListBox();
            this.group_Categories = new System.Windows.Forms.GroupBox();
            this.list_Categories = new System.Windows.Forms.CheckedListBox();
            this.group_GameText = new System.Windows.Forms.GroupBox();
            this.button_DeleteText = new System.Windows.Forms.Button();
            this.button_AddText = new System.Windows.Forms.Button();
            this.textbox_GameText = new System.Windows.Forms.TextBox();
            this.list_GameText = new System.Windows.Forms.ListBox();
            this.button_CreateScript = new System.Windows.Forms.Button();
            this.button_OpenScript = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).BeginInit();
            this.group_Search.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.group_CardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ATK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RightScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LeftScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Alias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CardID)).BeginInit();
            this.group_CardText.SuspendLayout();
            this.group_CardTypes.SuspendLayout();
            this.group_Categories.SuspendLayout();
            this.group_GameText.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox_Image
            // 
            this.picBox_Image.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBox_Image.Location = new System.Drawing.Point(12, 27);
            this.picBox_Image.Name = "picBox_Image";
            this.picBox_Image.Size = new System.Drawing.Size(177, 254);
            this.picBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Image.TabIndex = 0;
            this.picBox_Image.TabStop = false;
            // 
            // button_Pic
            // 
            this.button_Pic.Location = new System.Drawing.Point(62, 287);
            this.button_Pic.Name = "button_Pic";
            this.button_Pic.Size = new System.Drawing.Size(75, 23);
            this.button_Pic.TabIndex = 1;
            this.button_Pic.Text = "Set Image";
            this.button_Pic.UseVisualStyleBackColor = true;
            this.button_Pic.Click += new System.EventHandler(this.button_Pic_Click);
            // 
            // group_Search
            // 
            this.group_Search.Controls.Add(this.textbox_Search);
            this.group_Search.Controls.Add(this.list_Search);
            this.group_Search.Location = new System.Drawing.Point(12, 316);
            this.group_Search.Name = "group_Search";
            this.group_Search.Size = new System.Drawing.Size(177, 238);
            this.group_Search.TabIndex = 2;
            this.group_Search.TabStop = false;
            this.group_Search.Text = "Search";
            // 
            // textbox_Search
            // 
            this.textbox_Search.Location = new System.Drawing.Point(6, 212);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.Size = new System.Drawing.Size(165, 20);
            this.textbox_Search.TabIndex = 4;
            this.textbox_Search.TextChanged += new System.EventHandler(this.textbox_Search_TextChanged);
            // 
            // list_Search
            // 
            this.list_Search.FormattingEnabled = true;
            this.list_Search.Location = new System.Drawing.Point(6, 20);
            this.list_Search.Name = "list_Search";
            this.list_Search.Size = new System.Drawing.Size(165, 186);
            this.list_Search.TabIndex = 3;
            this.list_Search.DoubleClick += new System.EventHandler(this.list_Search_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_File,
            this.toolStrip_Edit,
            this.MenuItem_About});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(759, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStrip_File
            // 
            this.toolStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Close});
            this.toolStrip_File.Name = "toolStrip_File";
            this.toolStrip_File.Size = new System.Drawing.Size(37, 20);
            this.toolStrip_File.Text = "File";
            // 
            // menuItem_Close
            // 
            this.menuItem_Close.Name = "menuItem_Close";
            this.menuItem_Close.Size = new System.Drawing.Size(103, 22);
            this.menuItem_Close.Text = "Close";
            // 
            // toolStrip_Edit
            // 
            this.toolStrip_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Preferences});
            this.toolStrip_Edit.Name = "toolStrip_Edit";
            this.toolStrip_Edit.Size = new System.Drawing.Size(39, 20);
            this.toolStrip_Edit.Text = "Edit";
            // 
            // menuItem_Preferences
            // 
            this.menuItem_Preferences.Name = "menuItem_Preferences";
            this.menuItem_Preferences.Size = new System.Drawing.Size(135, 22);
            this.menuItem_Preferences.Text = "Preferences";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(52, 20);
            this.MenuItem_About.Text = "About";
            // 
            // group_CardInfo
            // 
            this.group_CardInfo.Controls.Add(this.numUpDown_DEF);
            this.group_CardInfo.Controls.Add(this.label_DEF);
            this.group_CardInfo.Controls.Add(this.numUpDown_ATK);
            this.group_CardInfo.Controls.Add(this.label_ATK);
            this.group_CardInfo.Controls.Add(this.select_Attribute);
            this.group_CardInfo.Controls.Add(this.label_Attribute);
            this.group_CardInfo.Controls.Add(this.select_Race);
            this.group_CardInfo.Controls.Add(this.label_Race);
            this.group_CardInfo.Controls.Add(this.numUpDown_RightScale);
            this.group_CardInfo.Controls.Add(this.label_RightScale);
            this.group_CardInfo.Controls.Add(this.numUpDown_LeftScale);
            this.group_CardInfo.Controls.Add(this.label_LeftScale);
            this.group_CardInfo.Controls.Add(this.label_Pendulum);
            this.group_CardInfo.Controls.Add(this.numUpDown_Level);
            this.group_CardInfo.Controls.Add(this.label_Level);
            this.group_CardInfo.Controls.Add(this.select_SetCode4);
            this.group_CardInfo.Controls.Add(this.select_SetCode3);
            this.group_CardInfo.Controls.Add(this.select_SetCode2);
            this.group_CardInfo.Controls.Add(this.select_SetCode1);
            this.group_CardInfo.Controls.Add(this.label_SetCode);
            this.group_CardInfo.Controls.Add(this.select_Format);
            this.group_CardInfo.Controls.Add(this.label_Format);
            this.group_CardInfo.Controls.Add(this.numUpDown_Alias);
            this.group_CardInfo.Controls.Add(this.label_Alias);
            this.group_CardInfo.Controls.Add(this.numUpDown_CardID);
            this.group_CardInfo.Controls.Add(this.label_ID);
            this.group_CardInfo.Location = new System.Drawing.Point(195, 27);
            this.group_CardInfo.Name = "group_CardInfo";
            this.group_CardInfo.Size = new System.Drawing.Size(223, 343);
            this.group_CardInfo.TabIndex = 4;
            this.group_CardInfo.TabStop = false;
            this.group_CardInfo.Text = "Card Info";
            // 
            // numUpDown_DEF
            // 
            this.numUpDown_DEF.Location = new System.Drawing.Point(164, 314);
            this.numUpDown_DEF.Maximum = new decimal(new int[] {
            999900,
            0,
            0,
            0});
            this.numUpDown_DEF.Name = "numUpDown_DEF";
            this.numUpDown_DEF.Size = new System.Drawing.Size(53, 20);
            this.numUpDown_DEF.TabIndex = 25;
            // 
            // label_DEF
            // 
            this.label_DEF.AutoSize = true;
            this.label_DEF.Location = new System.Drawing.Point(133, 317);
            this.label_DEF.Name = "label_DEF";
            this.label_DEF.Size = new System.Drawing.Size(28, 13);
            this.label_DEF.TabIndex = 24;
            this.label_DEF.Text = "DEF";
            this.label_DEF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUpDown_ATK
            // 
            this.numUpDown_ATK.Location = new System.Drawing.Point(76, 314);
            this.numUpDown_ATK.Maximum = new decimal(new int[] {
            999900,
            0,
            0,
            0});
            this.numUpDown_ATK.Name = "numUpDown_ATK";
            this.numUpDown_ATK.Size = new System.Drawing.Size(53, 20);
            this.numUpDown_ATK.TabIndex = 23;
            // 
            // label_ATK
            // 
            this.label_ATK.AutoSize = true;
            this.label_ATK.Location = new System.Drawing.Point(42, 316);
            this.label_ATK.Name = "label_ATK";
            this.label_ATK.Size = new System.Drawing.Size(28, 13);
            this.label_ATK.TabIndex = 22;
            this.label_ATK.Text = "ATK";
            this.label_ATK.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // select_Attribute
            // 
            this.select_Attribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_Attribute.FormattingEnabled = true;
            this.select_Attribute.Location = new System.Drawing.Point(76, 287);
            this.select_Attribute.Name = "select_Attribute";
            this.select_Attribute.Size = new System.Drawing.Size(141, 21);
            this.select_Attribute.TabIndex = 21;
            // 
            // label_Attribute
            // 
            this.label_Attribute.AutoSize = true;
            this.label_Attribute.Location = new System.Drawing.Point(24, 290);
            this.label_Attribute.Name = "label_Attribute";
            this.label_Attribute.Size = new System.Drawing.Size(46, 13);
            this.label_Attribute.TabIndex = 20;
            this.label_Attribute.Text = "Attribute";
            this.label_Attribute.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // select_Race
            // 
            this.select_Race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_Race.FormattingEnabled = true;
            this.select_Race.Location = new System.Drawing.Point(76, 260);
            this.select_Race.Name = "select_Race";
            this.select_Race.Size = new System.Drawing.Size(141, 21);
            this.select_Race.TabIndex = 19;
            // 
            // label_Race
            // 
            this.label_Race.AutoSize = true;
            this.label_Race.Location = new System.Drawing.Point(37, 265);
            this.label_Race.Name = "label_Race";
            this.label_Race.Size = new System.Drawing.Size(33, 13);
            this.label_Race.TabIndex = 18;
            this.label_Race.Text = "Race";
            this.label_Race.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUpDown_RightScale
            // 
            this.numUpDown_RightScale.Location = new System.Drawing.Point(147, 234);
            this.numUpDown_RightScale.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numUpDown_RightScale.Name = "numUpDown_RightScale";
            this.numUpDown_RightScale.Size = new System.Drawing.Size(44, 20);
            this.numUpDown_RightScale.TabIndex = 17;
            this.numUpDown_RightScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_RightScale
            // 
            this.label_RightScale.AutoSize = true;
            this.label_RightScale.Location = new System.Drawing.Point(126, 236);
            this.label_RightScale.Name = "label_RightScale";
            this.label_RightScale.Size = new System.Drawing.Size(15, 13);
            this.label_RightScale.TabIndex = 16;
            this.label_RightScale.Text = "R";
            this.label_RightScale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUpDown_LeftScale
            // 
            this.numUpDown_LeftScale.Location = new System.Drawing.Point(76, 234);
            this.numUpDown_LeftScale.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numUpDown_LeftScale.Name = "numUpDown_LeftScale";
            this.numUpDown_LeftScale.Size = new System.Drawing.Size(44, 20);
            this.numUpDown_LeftScale.TabIndex = 15;
            this.numUpDown_LeftScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_LeftScale
            // 
            this.label_LeftScale.AutoSize = true;
            this.label_LeftScale.Location = new System.Drawing.Point(57, 236);
            this.label_LeftScale.Name = "label_LeftScale";
            this.label_LeftScale.Size = new System.Drawing.Size(13, 13);
            this.label_LeftScale.TabIndex = 14;
            this.label_LeftScale.Text = "L";
            this.label_LeftScale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Pendulum
            // 
            this.label_Pendulum.AutoSize = true;
            this.label_Pendulum.Location = new System.Drawing.Point(7, 236);
            this.label_Pendulum.Name = "label_Pendulum";
            this.label_Pendulum.Size = new System.Drawing.Size(44, 13);
            this.label_Pendulum.TabIndex = 13;
            this.label_Pendulum.Text = "P Scale";
            this.label_Pendulum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUpDown_Level
            // 
            this.numUpDown_Level.Location = new System.Drawing.Point(76, 208);
            this.numUpDown_Level.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numUpDown_Level.Name = "numUpDown_Level";
            this.numUpDown_Level.Size = new System.Drawing.Size(65, 20);
            this.numUpDown_Level.TabIndex = 12;
            this.numUpDown_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(37, 210);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(33, 13);
            this.label_Level.TabIndex = 11;
            this.label_Level.Text = "Level";
            this.label_Level.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // select_SetCode4
            // 
            this.select_SetCode4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_SetCode4.FormattingEnabled = true;
            this.select_SetCode4.Location = new System.Drawing.Point(76, 181);
            this.select_SetCode4.Name = "select_SetCode4";
            this.select_SetCode4.Size = new System.Drawing.Size(141, 21);
            this.select_SetCode4.TabIndex = 10;
            // 
            // select_SetCode3
            // 
            this.select_SetCode3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_SetCode3.FormattingEnabled = true;
            this.select_SetCode3.Location = new System.Drawing.Point(76, 154);
            this.select_SetCode3.Name = "select_SetCode3";
            this.select_SetCode3.Size = new System.Drawing.Size(141, 21);
            this.select_SetCode3.TabIndex = 9;
            // 
            // select_SetCode2
            // 
            this.select_SetCode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_SetCode2.FormattingEnabled = true;
            this.select_SetCode2.Location = new System.Drawing.Point(76, 127);
            this.select_SetCode2.Name = "select_SetCode2";
            this.select_SetCode2.Size = new System.Drawing.Size(141, 21);
            this.select_SetCode2.TabIndex = 8;
            // 
            // select_SetCode1
            // 
            this.select_SetCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_SetCode1.FormattingEnabled = true;
            this.select_SetCode1.Location = new System.Drawing.Point(76, 100);
            this.select_SetCode1.Name = "select_SetCode1";
            this.select_SetCode1.Size = new System.Drawing.Size(141, 21);
            this.select_SetCode1.TabIndex = 7;
            // 
            // label_SetCode
            // 
            this.label_SetCode.AutoSize = true;
            this.label_SetCode.Location = new System.Drawing.Point(14, 103);
            this.label_SetCode.Name = "label_SetCode";
            this.label_SetCode.Size = new System.Drawing.Size(56, 13);
            this.label_SetCode.TabIndex = 6;
            this.label_SetCode.Text = "Set Codes";
            this.label_SetCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // select_Format
            // 
            this.select_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_Format.FormattingEnabled = true;
            this.select_Format.Items.AddRange(new object[] {
            "OCG - 1",
            "TCG - 2",
            "OCG/TCG - 3",
            "Anime - 4"});
            this.select_Format.Location = new System.Drawing.Point(76, 73);
            this.select_Format.Name = "select_Format";
            this.select_Format.Size = new System.Drawing.Size(141, 21);
            this.select_Format.TabIndex = 5;
            // 
            // label_Format
            // 
            this.label_Format.AutoSize = true;
            this.label_Format.Location = new System.Drawing.Point(6, 76);
            this.label_Format.Name = "label_Format";
            this.label_Format.Size = new System.Drawing.Size(64, 13);
            this.label_Format.TabIndex = 4;
            this.label_Format.Text = "Card Format";
            this.label_Format.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUpDown_Alias
            // 
            this.numUpDown_Alias.Location = new System.Drawing.Point(76, 47);
            this.numUpDown_Alias.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpDown_Alias.Name = "numUpDown_Alias";
            this.numUpDown_Alias.Size = new System.Drawing.Size(141, 20);
            this.numUpDown_Alias.TabIndex = 3;
            this.numUpDown_Alias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Alias
            // 
            this.label_Alias.AutoSize = true;
            this.label_Alias.Location = new System.Drawing.Point(41, 49);
            this.label_Alias.Name = "label_Alias";
            this.label_Alias.Size = new System.Drawing.Size(29, 13);
            this.label_Alias.TabIndex = 2;
            this.label_Alias.Text = "Alias";
            this.label_Alias.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUpDown_CardID
            // 
            this.numUpDown_CardID.Location = new System.Drawing.Point(76, 19);
            this.numUpDown_CardID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpDown_CardID.Name = "numUpDown_CardID";
            this.numUpDown_CardID.Size = new System.Drawing.Size(141, 20);
            this.numUpDown_CardID.TabIndex = 1;
            this.numUpDown_CardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(52, 21);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // group_CardText
            // 
            this.group_CardText.Controls.Add(this.textbox_Effect);
            this.group_CardText.Controls.Add(this.label_Effect);
            this.group_CardText.Controls.Add(this.textbox_Name);
            this.group_CardText.Controls.Add(this.label_Name);
            this.group_CardText.Location = new System.Drawing.Point(424, 27);
            this.group_CardText.Name = "group_CardText";
            this.group_CardText.Size = new System.Drawing.Size(323, 228);
            this.group_CardText.TabIndex = 5;
            this.group_CardText.TabStop = false;
            this.group_CardText.Text = "Card Text";
            // 
            // textbox_Effect
            // 
            this.textbox_Effect.Location = new System.Drawing.Point(72, 44);
            this.textbox_Effect.Name = "textbox_Effect";
            this.textbox_Effect.Size = new System.Drawing.Size(245, 178);
            this.textbox_Effect.TabIndex = 3;
            this.textbox_Effect.Text = "";
            // 
            // label_Effect
            // 
            this.label_Effect.AutoSize = true;
            this.label_Effect.Location = new System.Drawing.Point(6, 49);
            this.label_Effect.Name = "label_Effect";
            this.label_Effect.Size = new System.Drawing.Size(60, 13);
            this.label_Effect.TabIndex = 2;
            this.label_Effect.Text = "Description";
            // 
            // textbox_Name
            // 
            this.textbox_Name.Location = new System.Drawing.Point(72, 18);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.Size = new System.Drawing.Size(245, 20);
            this.textbox_Name.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(31, 21);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // group_CardTypes
            // 
            this.group_CardTypes.Controls.Add(this.list_Types);
            this.group_CardTypes.Location = new System.Drawing.Point(195, 376);
            this.group_CardTypes.Name = "group_CardTypes";
            this.group_CardTypes.Size = new System.Drawing.Size(141, 172);
            this.group_CardTypes.TabIndex = 6;
            this.group_CardTypes.TabStop = false;
            this.group_CardTypes.Text = "Card Types";
            // 
            // list_Types
            // 
            this.list_Types.FormattingEnabled = true;
            this.list_Types.Location = new System.Drawing.Point(6, 19);
            this.list_Types.Name = "list_Types";
            this.list_Types.Size = new System.Drawing.Size(129, 139);
            this.list_Types.TabIndex = 0;
            // 
            // group_Categories
            // 
            this.group_Categories.Controls.Add(this.list_Categories);
            this.group_Categories.Location = new System.Drawing.Point(342, 376);
            this.group_Categories.Name = "group_Categories";
            this.group_Categories.Size = new System.Drawing.Size(141, 172);
            this.group_Categories.TabIndex = 7;
            this.group_Categories.TabStop = false;
            this.group_Categories.Text = "Card Categories";
            // 
            // list_Categories
            // 
            this.list_Categories.FormattingEnabled = true;
            this.list_Categories.Items.AddRange(new object[] {
            "S/T Destroy",
            "Destroy Monster",
            "Banish",
            "Graveyard",
            "Back to Hand",
            "Back to Deck",
            "Destroy Hand",
            "Destroy Deck",
            "Draw",
            "Search",
            "Recovery",
            "Position",
            "Control",
            "Change ATK/DEF",
            "Piercing",
            "Repeat Attack",
            "Limit Attack",
            "Direct Attack",
            "Special Summon",
            "Token",
            "Type-Related",
            "Property-Related",
            "Damage LP",
            "Recover LP",
            "Destory",
            "Select",
            "Counter",
            "Gamble",
            "Fusion-Related",
            "Tuner-Related",
            "Xyz-Related",
            "Negate Effect"});
            this.list_Categories.Location = new System.Drawing.Point(6, 17);
            this.list_Categories.Name = "list_Categories";
            this.list_Categories.Size = new System.Drawing.Size(129, 139);
            this.list_Categories.TabIndex = 1;
            // 
            // group_GameText
            // 
            this.group_GameText.Controls.Add(this.button_DeleteText);
            this.group_GameText.Controls.Add(this.button_AddText);
            this.group_GameText.Controls.Add(this.textbox_GameText);
            this.group_GameText.Controls.Add(this.list_GameText);
            this.group_GameText.Location = new System.Drawing.Point(489, 263);
            this.group_GameText.Name = "group_GameText";
            this.group_GameText.Size = new System.Drawing.Size(258, 180);
            this.group_GameText.TabIndex = 8;
            this.group_GameText.TabStop = false;
            this.group_GameText.Text = "Card Effect Text";
            // 
            // button_DeleteText
            // 
            this.button_DeleteText.Location = new System.Drawing.Point(177, 120);
            this.button_DeleteText.Name = "button_DeleteText";
            this.button_DeleteText.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteText.TabIndex = 3;
            this.button_DeleteText.Text = "Delete";
            this.button_DeleteText.UseVisualStyleBackColor = true;
            this.button_DeleteText.Click += new System.EventHandler(this.button_DeleteText_Click);
            // 
            // button_AddText
            // 
            this.button_AddText.Location = new System.Drawing.Point(96, 120);
            this.button_AddText.Name = "button_AddText";
            this.button_AddText.Size = new System.Drawing.Size(75, 23);
            this.button_AddText.TabIndex = 2;
            this.button_AddText.Text = "Add";
            this.button_AddText.UseVisualStyleBackColor = true;
            this.button_AddText.Click += new System.EventHandler(this.button_AddText_Click);
            // 
            // textbox_GameText
            // 
            this.textbox_GameText.Location = new System.Drawing.Point(6, 94);
            this.textbox_GameText.Name = "textbox_GameText";
            this.textbox_GameText.Size = new System.Drawing.Size(246, 20);
            this.textbox_GameText.TabIndex = 1;
            // 
            // list_GameText
            // 
            this.list_GameText.FormattingEnabled = true;
            this.list_GameText.Location = new System.Drawing.Point(6, 19);
            this.list_GameText.Name = "list_GameText";
            this.list_GameText.Size = new System.Drawing.Size(246, 69);
            this.list_GameText.TabIndex = 0;
            // 
            // button_CreateScript
            // 
            this.button_CreateScript.Location = new System.Drawing.Point(489, 449);
            this.button_CreateScript.Name = "button_CreateScript";
            this.button_CreateScript.Size = new System.Drawing.Size(114, 23);
            this.button_CreateScript.TabIndex = 9;
            this.button_CreateScript.Text = "Create Script";
            this.button_CreateScript.UseVisualStyleBackColor = true;
            this.button_CreateScript.Click += new System.EventHandler(this.button_CreateScript_Click);
            // 
            // button_OpenScript
            // 
            this.button_OpenScript.Location = new System.Drawing.Point(489, 478);
            this.button_OpenScript.Name = "button_OpenScript";
            this.button_OpenScript.Size = new System.Drawing.Size(114, 23);
            this.button_OpenScript.TabIndex = 10;
            this.button_OpenScript.Text = "Open Script";
            this.button_OpenScript.UseVisualStyleBackColor = true;
            this.button_OpenScript.Click += new System.EventHandler(this.button_OpenScript_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(666, 449);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(81, 23);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save Card";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(666, 478);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(81, 23);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Delete Card";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(666, 507);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(81, 23);
            this.button_Clear.TabIndex = 13;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 566);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_OpenScript);
            this.Controls.Add(this.button_CreateScript);
            this.Controls.Add(this.group_GameText);
            this.Controls.Add(this.group_Categories);
            this.Controls.Add(this.group_CardTypes);
            this.Controls.Add(this.group_CardText);
            this.Controls.Add(this.group_CardInfo);
            this.Controls.Add(this.group_Search);
            this.Controls.Add(this.button_Pic);
            this.Controls.Add(this.picBox_Image);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "YGOPro Card Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).EndInit();
            this.group_Search.ResumeLayout(false);
            this.group_Search.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.group_CardInfo.ResumeLayout(false);
            this.group_CardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ATK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RightScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LeftScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Alias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CardID)).EndInit();
            this.group_CardText.ResumeLayout(false);
            this.group_CardText.PerformLayout();
            this.group_CardTypes.ResumeLayout(false);
            this.group_Categories.ResumeLayout(false);
            this.group_GameText.ResumeLayout(false);
            this.group_GameText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Image;
        private System.Windows.Forms.Button button_Pic;
        private System.Windows.Forms.GroupBox group_Search;
        private System.Windows.Forms.ListBox list_Search;
        private System.Windows.Forms.TextBox textbox_Search;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.GroupBox group_CardInfo;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.NumericUpDown numUpDown_CardID;
        private System.Windows.Forms.NumericUpDown numUpDown_Alias;
        private System.Windows.Forms.Label label_Alias;
        private System.Windows.Forms.ComboBox select_Format;
        private System.Windows.Forms.Label label_Format;
        private System.Windows.Forms.ComboBox select_SetCode1;
        private System.Windows.Forms.Label label_SetCode;
        private System.Windows.Forms.ComboBox select_SetCode4;
        private System.Windows.Forms.ComboBox select_SetCode3;
        private System.Windows.Forms.ComboBox select_SetCode2;
        private System.Windows.Forms.NumericUpDown numUpDown_Level;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.Label label_Pendulum;
        private System.Windows.Forms.Label label_LeftScale;
        private System.Windows.Forms.NumericUpDown numUpDown_LeftScale;
        private System.Windows.Forms.NumericUpDown numUpDown_RightScale;
        private System.Windows.Forms.Label label_RightScale;
        private System.Windows.Forms.ComboBox select_Race;
        private System.Windows.Forms.Label label_Race;
        private System.Windows.Forms.ComboBox select_Attribute;
        private System.Windows.Forms.Label label_Attribute;
        private System.Windows.Forms.NumericUpDown numUpDown_DEF;
        private System.Windows.Forms.Label label_DEF;
        private System.Windows.Forms.NumericUpDown numUpDown_ATK;
        private System.Windows.Forms.Label label_ATK;
        private System.Windows.Forms.GroupBox group_CardText;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textbox_Name;
        private System.Windows.Forms.Label label_Effect;
        private System.Windows.Forms.RichTextBox textbox_Effect;
        private System.Windows.Forms.GroupBox group_CardTypes;
        private System.Windows.Forms.GroupBox group_Categories;
        private System.Windows.Forms.GroupBox group_GameText;
        private System.Windows.Forms.ListBox list_GameText;
        private System.Windows.Forms.CheckedListBox list_Types;
        private System.Windows.Forms.CheckedListBox list_Categories;
        private System.Windows.Forms.TextBox textbox_GameText;
        private System.Windows.Forms.Button button_AddText;
        private System.Windows.Forms.Button button_DeleteText;
        private System.Windows.Forms.Button button_CreateScript;
        private System.Windows.Forms.Button button_OpenScript;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Edit;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Preferences;
    }
}


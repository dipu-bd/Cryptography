namespace Cryptography
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
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "a",
            "b",
            "c",
            "d",
            "e",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "f",
            "g",
            "h",
            "i",
            "k",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("6");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plainCaesar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.caesarNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.caesarDistance = new System.Windows.Forms.TrackBar();
            this.caesarNumeric = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.plainPolyaplha = new System.Windows.Forms.TextBox();
            this.cipherPolyalpha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.polyalphaDecryptRadio = new System.Windows.Forms.RadioButton();
            this.polyalphaKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.polyalphaEncryptRadio = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.plainPolybius = new System.Windows.Forms.TextBox();
            this.cipherPolybius = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.sixPolyCheck = new System.Windows.Forms.CheckBox();
            this.fivePolyCheck = new System.Windows.Forms.CheckBox();
            this.listContainer = new System.Windows.Forms.Panel();
            this.polybiusSquare = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.polybiusDecryptRadio = new System.Windows.Forms.RadioButton();
            this.polybiusEncryptRadio = new System.Windows.Forms.RadioButton();
            this.transposeButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caesarDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caesarNumeric)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.listContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.plainCaesar);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Caesar Cipher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // plainCaesar
            // 
            this.plainCaesar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainCaesar.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainCaesar.Location = new System.Drawing.Point(64, 3);
            this.plainCaesar.Multiline = true;
            this.plainCaesar.Name = "plainCaesar";
            this.plainCaesar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.plainCaesar.Size = new System.Drawing.Size(709, 371);
            this.plainCaesar.TabIndex = 0;
            this.plainCaesar.Text = resources.GetString("plainCaesar.Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.caesarNumeric2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.caesarDistance, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.caesarNumeric, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(61, 371);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // caesarNumeric2
            // 
            this.caesarNumeric2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caesarNumeric2.Location = new System.Drawing.Point(4, 345);
            this.caesarNumeric2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.caesarNumeric2.Name = "caesarNumeric2";
            this.caesarNumeric2.Size = new System.Drawing.Size(53, 23);
            this.caesarNumeric2.TabIndex = 4;
            this.caesarNumeric2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caesarNumeric2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // caesarDistance
            // 
            this.caesarDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.caesarDistance.Location = new System.Drawing.Point(8, 33);
            this.caesarDistance.Maximum = 26;
            this.caesarDistance.Minimum = 1;
            this.caesarDistance.Name = "caesarDistance";
            this.caesarDistance.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.caesarDistance.Size = new System.Drawing.Size(45, 305);
            this.caesarDistance.TabIndex = 2;
            this.caesarDistance.Value = 26;
            this.caesarDistance.Scroll += new System.EventHandler(this.caesarDistance_Scroll);
            // 
            // caesarNumeric
            // 
            this.caesarNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caesarNumeric.Location = new System.Drawing.Point(4, 4);
            this.caesarNumeric.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.caesarNumeric.Name = "caesarNumeric";
            this.caesarNumeric.Size = new System.Drawing.Size(53, 23);
            this.caesarNumeric.TabIndex = 3;
            this.caesarNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caesarNumeric.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polyalphabetic Cipher";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 35);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.plainPolyaplha);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cipherPolyalpha);
            this.splitContainer2.Size = new System.Drawing.Size(770, 339);
            this.splitContainer2.SplitterDistance = 174;
            this.splitContainer2.TabIndex = 3;
            // 
            // plainPolyaplha
            // 
            this.plainPolyaplha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainPolyaplha.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainPolyaplha.Location = new System.Drawing.Point(0, 0);
            this.plainPolyaplha.Multiline = true;
            this.plainPolyaplha.Name = "plainPolyaplha";
            this.plainPolyaplha.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.plainPolyaplha.Size = new System.Drawing.Size(770, 174);
            this.plainPolyaplha.TabIndex = 0;
            this.plainPolyaplha.Text = "specify a keyword to create a polyalphabetic cipher from this text.";
            this.plainPolyaplha.TextChanged += new System.EventHandler(this.plainPoly_TextChanged);
            // 
            // cipherPolyalpha
            // 
            this.cipherPolyalpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cipherPolyalpha.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherPolyalpha.Location = new System.Drawing.Point(0, 0);
            this.cipherPolyalpha.Multiline = true;
            this.cipherPolyalpha.Name = "cipherPolyalpha";
            this.cipherPolyalpha.ReadOnly = true;
            this.cipherPolyalpha.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cipherPolyalpha.Size = new System.Drawing.Size(770, 161);
            this.cipherPolyalpha.TabIndex = 1;
            this.cipherPolyalpha.TextChanged += new System.EventHandler(this.cipherPoly_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.26617F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.73383F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Controls.Add(this.polyalphaDecryptRadio, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.polyalphaKeyword, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.polyalphaEncryptRadio, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // polyalphaDecryptRadio
            // 
            this.polyalphaDecryptRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.polyalphaDecryptRadio.AutoSize = true;
            this.polyalphaDecryptRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polyalphaDecryptRadio.Location = new System.Drawing.Point(635, 3);
            this.polyalphaDecryptRadio.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.polyalphaDecryptRadio.Name = "polyalphaDecryptRadio";
            this.polyalphaDecryptRadio.Size = new System.Drawing.Size(131, 26);
            this.polyalphaDecryptRadio.TabIndex = 4;
            this.polyalphaDecryptRadio.TabStop = true;
            this.polyalphaDecryptRadio.Text = "Decrypt";
            this.polyalphaDecryptRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.polyalphaDecryptRadio.UseVisualStyleBackColor = true;
            this.polyalphaDecryptRadio.CheckedChanged += new System.EventHandler(this.polyRadio_CheckedChanged);
            // 
            // polyalphaKeyword
            // 
            this.polyalphaKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polyalphaKeyword.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polyalphaKeyword.Location = new System.Drawing.Point(90, 4);
            this.polyalphaKeyword.Name = "polyalphaKeyword";
            this.polyalphaKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.polyalphaKeyword.Size = new System.Drawing.Size(436, 25);
            this.polyalphaKeyword.TabIndex = 1;
            this.polyalphaKeyword.TextChanged += new System.EventHandler(this.polyKeyword_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keyword :";
            // 
            // polyalphaEncryptRadio
            // 
            this.polyalphaEncryptRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.polyalphaEncryptRadio.AutoSize = true;
            this.polyalphaEncryptRadio.Checked = true;
            this.polyalphaEncryptRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polyalphaEncryptRadio.Location = new System.Drawing.Point(533, 3);
            this.polyalphaEncryptRadio.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.polyalphaEncryptRadio.Name = "polyalphaEncryptRadio";
            this.polyalphaEncryptRadio.Size = new System.Drawing.Size(101, 26);
            this.polyalphaEncryptRadio.TabIndex = 3;
            this.polyalphaEncryptRadio.TabStop = true;
            this.polyalphaEncryptRadio.Text = "Encrypt";
            this.polyalphaEncryptRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.polyalphaEncryptRadio.UseVisualStyleBackColor = true;
            this.polyalphaEncryptRadio.CheckedChanged += new System.EventHandler(this.polyRadio_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Polybius Squared Cipher";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(183, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.plainPolybius);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cipherPolybius);
            this.splitContainer3.Size = new System.Drawing.Size(590, 371);
            this.splitContainer3.SplitterDistance = 183;
            this.splitContainer3.TabIndex = 4;
            // 
            // plainPolybius
            // 
            this.plainPolybius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainPolybius.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainPolybius.Location = new System.Drawing.Point(0, 0);
            this.plainPolybius.Multiline = true;
            this.plainPolybius.Name = "plainPolybius";
            this.plainPolybius.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.plainPolybius.Size = new System.Drawing.Size(590, 183);
            this.plainPolybius.TabIndex = 0;
            this.plainPolybius.Text = "numbers that are not valid will be ignored or a ? mark will appear in the text if" +
    " decipher failed.";
            this.plainPolybius.TextChanged += new System.EventHandler(this.plainPolybius_TextChanged);
            // 
            // cipherPolybius
            // 
            this.cipherPolybius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cipherPolybius.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherPolybius.Location = new System.Drawing.Point(0, 0);
            this.cipherPolybius.Multiline = true;
            this.cipherPolybius.Name = "cipherPolybius";
            this.cipherPolybius.ReadOnly = true;
            this.cipherPolybius.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cipherPolybius.Size = new System.Drawing.Size(590, 184);
            this.cipherPolybius.TabIndex = 1;
            this.cipherPolybius.TextChanged += new System.EventHandler(this.cipherPolybius_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.sixPolyCheck, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.fivePolyCheck, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.listContainer, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.polybiusDecryptRadio, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.polybiusEncryptRadio, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.transposeButton, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 371);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // sixPolyCheck
            // 
            this.sixPolyCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixPolyCheck.AutoSize = true;
            this.sixPolyCheck.Location = new System.Drawing.Point(46, 95);
            this.sixPolyCheck.Name = "sixPolyCheck";
            this.sixPolyCheck.Size = new System.Drawing.Size(88, 19);
            this.sixPolyCheck.TabIndex = 4;
            this.sixPolyCheck.Text = "6 x 6 Square";
            this.sixPolyCheck.UseVisualStyleBackColor = true;
            this.sixPolyCheck.CheckedChanged += new System.EventHandler(this.sixPolyCheck_CheckedChanged);
            // 
            // fivePolyCheck
            // 
            this.fivePolyCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivePolyCheck.AutoSize = true;
            this.fivePolyCheck.Checked = true;
            this.fivePolyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fivePolyCheck.Location = new System.Drawing.Point(46, 65);
            this.fivePolyCheck.Name = "fivePolyCheck";
            this.fivePolyCheck.Size = new System.Drawing.Size(88, 19);
            this.fivePolyCheck.TabIndex = 1;
            this.fivePolyCheck.Text = "5 x 5 Square";
            this.fivePolyCheck.UseVisualStyleBackColor = true;
            this.fivePolyCheck.CheckedChanged += new System.EventHandler(this.fivPolyCheck_CheckedChanged);
            // 
            // listContainer
            // 
            this.listContainer.Controls.Add(this.polybiusSquare);
            this.listContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContainer.Location = new System.Drawing.Point(3, 123);
            this.listContainer.Name = "listContainer";
            this.listContainer.Size = new System.Drawing.Size(174, 211);
            this.listContainer.TabIndex = 1;
            // 
            // polybiusSquare
            // 
            this.polybiusSquare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.polybiusSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polybiusSquare.FullRowSelect = true;
            this.polybiusSquare.GridLines = true;
            this.polybiusSquare.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem13.UseItemStyleForSubItems = false;
            listViewItem14.UseItemStyleForSubItems = false;
            listViewItem15.UseItemStyleForSubItems = false;
            listViewItem16.UseItemStyleForSubItems = false;
            listViewItem17.UseItemStyleForSubItems = false;
            listViewItem18.UseItemStyleForSubItems = false;
            this.polybiusSquare.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.polybiusSquare.Location = new System.Drawing.Point(0, 0);
            this.polybiusSquare.MultiSelect = false;
            this.polybiusSquare.Name = "polybiusSquare";
            this.polybiusSquare.Scrollable = false;
            this.polybiusSquare.Size = new System.Drawing.Size(174, 211);
            this.polybiusSquare.TabIndex = 4;
            this.polybiusSquare.UseCompatibleStateImageBehavior = false;
            this.polybiusSquare.View = System.Windows.Forms.View.Details;
            this.polybiusSquare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 25;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "2";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 25;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "3";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 25;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "4";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 25;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "5";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 25;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "6";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 25;
            // 
            // polybiusDecryptRadio
            // 
            this.polybiusDecryptRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.polybiusDecryptRadio.AutoSize = true;
            this.polybiusDecryptRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polybiusDecryptRadio.Location = new System.Drawing.Point(3, 30);
            this.polybiusDecryptRadio.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.polybiusDecryptRadio.Name = "polybiusDecryptRadio";
            this.polybiusDecryptRadio.Size = new System.Drawing.Size(174, 27);
            this.polybiusDecryptRadio.TabIndex = 3;
            this.polybiusDecryptRadio.Text = "Decrypt";
            this.polybiusDecryptRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.polybiusDecryptRadio.UseVisualStyleBackColor = true;
            this.polybiusDecryptRadio.CheckedChanged += new System.EventHandler(this.polybiusRadio_CheckedChanged);
            // 
            // polybiusEncryptRadio
            // 
            this.polybiusEncryptRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.polybiusEncryptRadio.AutoSize = true;
            this.polybiusEncryptRadio.Checked = true;
            this.polybiusEncryptRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polybiusEncryptRadio.Location = new System.Drawing.Point(3, 3);
            this.polybiusEncryptRadio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.polybiusEncryptRadio.Name = "polybiusEncryptRadio";
            this.polybiusEncryptRadio.Size = new System.Drawing.Size(174, 27);
            this.polybiusEncryptRadio.TabIndex = 2;
            this.polybiusEncryptRadio.TabStop = true;
            this.polybiusEncryptRadio.Text = "Encrypt";
            this.polybiusEncryptRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.polybiusEncryptRadio.UseVisualStyleBackColor = true;
            this.polybiusEncryptRadio.CheckedChanged += new System.EventHandler(this.polybiusRadio_CheckedChanged);
            // 
            // transposeButton
            // 
            this.transposeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transposeButton.Location = new System.Drawing.Point(3, 340);
            this.transposeButton.Name = "transposeButton";
            this.transposeButton.Size = new System.Drawing.Size(174, 28);
            this.transposeButton.TabIndex = 5;
            this.transposeButton.Text = "Transpose";
            this.transposeButton.UseVisualStyleBackColor = true;
            this.transposeButton.Click += new System.EventHandler(this.transposeButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RSA Encryption";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caesarDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caesarNumeric)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.listContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar caesarDistance;
        private System.Windows.Forms.TextBox plainCaesar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox plainPolyaplha;
        private System.Windows.Forms.TextBox polyalphaKeyword;
        private System.Windows.Forms.TextBox cipherPolyalpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton polyalphaDecryptRadio;
        private System.Windows.Forms.RadioButton polyalphaEncryptRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton polybiusDecryptRadio;
        private System.Windows.Forms.RadioButton polybiusEncryptRadio;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox plainPolybius;
        private System.Windows.Forms.TextBox cipherPolybius;
        private System.Windows.Forms.ListView polybiusSquare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel listContainer;
        private System.Windows.Forms.CheckBox sixPolyCheck;
        private System.Windows.Forms.CheckBox fivePolyCheck;
        private System.Windows.Forms.Button transposeButton;
        private System.Windows.Forms.NumericUpDown caesarNumeric;
        private System.Windows.Forms.NumericUpDown caesarNumeric2;
    }
}


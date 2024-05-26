namespace PdfSearch
{
    partial class PdfSearch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
     
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
      this.textBoxSearchTerm = new System.Windows.Forms.TextBox();
      this.checkBoxWholeWord = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonRunSearch = new System.Windows.Forms.Button();
      this.buttonChooseFolder = new System.Windows.Forms.Button();
      this.textBoxPath = new System.Windows.Forms.TextBox();
      this.dataGridViewResults = new System.Windows.Forms.DataGridView();
      this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.occurrences = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Preview = new System.Windows.Forms.DataGridViewButtonColumn();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.buttonRunSearch, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.buttonChooseFolder, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.textBoxPath, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
      this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 100);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20);
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1442, 141);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
      this.tableLayoutPanel1.Controls.Add(this.checkBoxMatchCase, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBoxSearchTerm, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.checkBoxWholeWord, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 76);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1236, 47);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // checkBoxMatchCase
      // 
      this.checkBoxMatchCase.AutoSize = true;
      this.checkBoxMatchCase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.checkBoxMatchCase.Location = new System.Drawing.Point(1127, 3);
      this.checkBoxMatchCase.Name = "checkBoxMatchCase";
      this.checkBoxMatchCase.Size = new System.Drawing.Size(106, 41);
      this.checkBoxMatchCase.TabIndex = 4;
      this.checkBoxMatchCase.Text = "Match case";
      this.checkBoxMatchCase.UseVisualStyleBackColor = true;
      // 
      // textBoxSearchTerm
      // 
      this.textBoxSearchTerm.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxSearchTerm.Location = new System.Drawing.Point(110, 10);
      this.textBoxSearchTerm.Margin = new System.Windows.Forms.Padding(10);
      this.textBoxSearchTerm.Name = "textBoxSearchTerm";
      this.textBoxSearchTerm.Size = new System.Drawing.Size(873, 27);
      this.textBoxSearchTerm.TabIndex = 3;
      // 
      // checkBoxWholeWord
      // 
      this.checkBoxWholeWord.AutoSize = true;
      this.checkBoxWholeWord.Dock = System.Windows.Forms.DockStyle.Fill;
      this.checkBoxWholeWord.Location = new System.Drawing.Point(996, 3);
      this.checkBoxWholeWord.Name = "checkBoxWholeWord";
      this.checkBoxWholeWord.Size = new System.Drawing.Size(125, 41);
      this.checkBoxWholeWord.TabIndex = 1;
      this.checkBoxWholeWord.Text = "Whole word";
      this.checkBoxWholeWord.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 47);
      this.label1.TabIndex = 5;
      this.label1.Text = "Search Text:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // buttonRunSearch
      // 
      this.buttonRunSearch.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonRunSearch.Location = new System.Drawing.Point(1272, 83);
      this.buttonRunSearch.Margin = new System.Windows.Forms.Padding(10);
      this.buttonRunSearch.MaximumSize = new System.Drawing.Size(153, 0);
      this.buttonRunSearch.Name = "buttonRunSearch";
      this.buttonRunSearch.Size = new System.Drawing.Size(140, 33);
      this.buttonRunSearch.TabIndex = 3;
      this.buttonRunSearch.Text = "Run Search";
      this.buttonRunSearch.UseVisualStyleBackColor = true;
      this.buttonRunSearch.Click += new System.EventHandler(this.buttonRunSearch_Click);
      // 
      // buttonChooseFolder
      // 
      this.buttonChooseFolder.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonChooseFolder.Location = new System.Drawing.Point(1272, 30);
      this.buttonChooseFolder.Margin = new System.Windows.Forms.Padding(10);
      this.buttonChooseFolder.MaximumSize = new System.Drawing.Size(153, 0);
      this.buttonChooseFolder.Name = "buttonChooseFolder";
      this.buttonChooseFolder.Size = new System.Drawing.Size(140, 33);
      this.buttonChooseFolder.TabIndex = 0;
      this.buttonChooseFolder.Text = "Choose Folder";
      this.buttonChooseFolder.UseVisualStyleBackColor = true;
      this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
      // 
      // textBoxPath
      // 
      this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxPath.Location = new System.Drawing.Point(30, 30);
      this.textBoxPath.Margin = new System.Windows.Forms.Padding(10);
      this.textBoxPath.Multiline = true;
      this.textBoxPath.Name = "textBoxPath";
      this.textBoxPath.ReadOnly = true;
      this.textBoxPath.Size = new System.Drawing.Size(1222, 33);
      this.textBoxPath.TabIndex = 1;
      // 
      // dataGridViewResults
      // 
      this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filename,
            this.occurrences,
            this.Preview});
      this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewResults.Location = new System.Drawing.Point(0, 141);
      this.dataGridViewResults.Name = "dataGridViewResults";
      this.dataGridViewResults.ReadOnly = true;
      this.dataGridViewResults.RowHeadersWidth = 51;
      this.dataGridViewResults.RowTemplate.Height = 29;
      this.dataGridViewResults.Size = new System.Drawing.Size(1442, 540);
      this.dataGridViewResults.TabIndex = 2;
      this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
      // 
      // filename
      // 
      this.filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.filename.HeaderText = "Filename";
      this.filename.MinimumWidth = 6;
      this.filename.Name = "filename";
      this.filename.ReadOnly = true;
      // 
      // occurrences
      // 
      this.occurrences.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.occurrences.HeaderText = "Occurrences";
      this.occurrences.MinimumWidth = 6;
      this.occurrences.Name = "occurrences";
      this.occurrences.ReadOnly = true;
      this.occurrences.Width = 118;
      // 
      // Preview
      // 
      this.Preview.HeaderText = "";
      this.Preview.MinimumWidth = 6;
      this.Preview.Name = "Preview";
      this.Preview.ReadOnly = true;
      this.Preview.Text = "B";
      this.Preview.ToolTipText = "show Pdf";
      this.Preview.Width = 125;
      // 
      // PdfSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1442, 681);
      this.Controls.Add(this.dataGridViewResults);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Name = "PdfSearch";
      this.ShowIcon = false;
      this.Text = "Pdf Searcher";
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonChooseFolder;
        private TextBox textBoxPath;
        private DataGridView dataGridViewResults;
        private Button buttonRunSearch;
        private DataGridViewTextBoxColumn filename;
        private DataGridViewTextBoxColumn occurrences;
        private DataGridViewButtonColumn Preview;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBoxMatchCase;
        private TextBox textBoxSearchTerm;
        private CheckBox checkBoxWholeWord;
        private Label label1;
    }
}
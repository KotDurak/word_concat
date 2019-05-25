namespace word_concatenation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.join = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.addColumn = new System.Windows.Forms.Button();
            this.importInSynonyms = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.col_import = new System.Windows.Forms.TextBox();
            this.import = new System.Windows.Forms.RadioButton();
            this.paste = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // join
            // 
            this.join.Location = new System.Drawing.Point(657, 453);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(75, 23);
            this.join.TabIndex = 1;
            this.join.Text = "Склеить";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Location = new System.Drawing.Point(12, 453);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(163, 23);
            this.deleteRowButton.TabIndex = 2;
            this.deleteRowButton.Text = "Очистить пустые строки";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // addColumn
            // 
            this.addColumn.Location = new System.Drawing.Point(12, 13);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(130, 23);
            this.addColumn.TabIndex = 3;
            this.addColumn.Text = "Добавить колонку";
            this.addColumn.UseVisualStyleBackColor = true;
            this.addColumn.Click += new System.EventHandler(this.addColumn_Click);
            // 
            // importInSynonyms
            // 
            this.importInSynonyms.Location = new System.Drawing.Point(159, 13);
            this.importInSynonyms.Name = "importInSynonyms";
            this.importInSynonyms.Size = new System.Drawing.Size(146, 23);
            this.importInSynonyms.TabIndex = 4;
            this.importInSynonyms.Text = "Импорт в синонимы";
            this.importInSynonyms.UseVisualStyleBackColor = true;
            this.importInSynonyms.Click += new System.EventHandler(this.importInSynonyms_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.col_import);
            this.groupBox1.Controls.Add(this.import);
            this.groupBox1.Controls.Add(this.paste);
            this.groupBox1.Location = new System.Drawing.Point(325, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Импорт в синонимы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вставка из колонки:";
            // 
            // col_import
            // 
            this.col_import.Location = new System.Drawing.Point(144, 45);
            this.col_import.Name = "col_import";
            this.col_import.Size = new System.Drawing.Size(100, 20);
            this.col_import.TabIndex = 2;
            this.col_import.Text = "A";
            // 
            // import
            // 
            this.import.AutoSize = true;
            this.import.Location = new System.Drawing.Point(144, 19);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(113, 17);
            this.import.TabIndex = 1;
            this.import.Text = "Парсинг из excell";
            this.import.UseVisualStyleBackColor = true;
            // 
            // paste
            // 
            this.paste.AutoSize = true;
            this.paste.Checked = true;
            this.paste.Location = new System.Drawing.Point(26, 19);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(112, 17);
            this.paste.TabIndex = 0;
            this.paste.TabStop = true;
            this.paste.Text = "Вставка из excell";
            this.paste.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.importInSynonyms);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.join);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.Button importInSynonyms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton import;
        private System.Windows.Forms.RadioButton paste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox col_import;
    }
}


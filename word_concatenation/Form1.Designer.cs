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
            this.cbx_ping = new System.Windows.Forms.CheckBox();
            this.first_column_import = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.col_import = new System.Windows.Forms.TextBox();
            this.import = new System.Windows.Forms.RadioButton();
            this.paste = new System.Windows.Forms.RadioButton();
            this.export_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pluralToOne = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // join
            // 
            this.join.Location = new System.Drawing.Point(9, 23);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(101, 23);
            this.join.TabIndex = 1;
            this.join.Text = "Склеить";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Location = new System.Drawing.Point(3, 14);
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
            this.groupBox1.Controls.Add(this.pluralToOne);
            this.groupBox1.Controls.Add(this.cbx_ping);
            this.groupBox1.Controls.Add(this.first_column_import);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.col_import);
            this.groupBox1.Controls.Add(this.import);
            this.groupBox1.Controls.Add(this.paste);
            this.groupBox1.Location = new System.Drawing.Point(325, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Импорт в синонимы";
            // 
            // cbx_ping
            // 
            this.cbx_ping.AutoSize = true;
            this.cbx_ping.Checked = true;
            this.cbx_ping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_ping.Location = new System.Drawing.Point(262, 20);
            this.cbx_ping.Name = "cbx_ping";
            this.cbx_ping.Size = new System.Drawing.Size(171, 17);
            this.cbx_ping.TabIndex = 5;
            this.cbx_ping.Text = "Задержка между парсингом";
            this.cbx_ping.UseVisualStyleBackColor = true;
            // 
            // first_column_import
            // 
            this.first_column_import.AutoSize = true;
            this.first_column_import.Checked = true;
            this.first_column_import.CheckState = System.Windows.Forms.CheckState.Checked;
            this.first_column_import.Location = new System.Drawing.Point(262, 48);
            this.first_column_import.Name = "first_column_import";
            this.first_column_import.Size = new System.Drawing.Size(151, 17);
            this.first_column_import.TabIndex = 4;
            this.first_column_import.Text = "Импорт с первой строки";
            this.first_column_import.UseVisualStyleBackColor = true;
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
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(116, 23);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(101, 23);
            this.export_btn.TabIndex = 6;
            this.export_btn.Text = "Экспорт";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.deleteRowButton);
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 84);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(502, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 67);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Конструкция 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Экспорт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Склеить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.export_btn);
            this.panel2.Controls.Add(this.join);
            this.panel2.Location = new System.Drawing.Point(199, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 67);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Конструкция 1";
            // 
            // pluralToOne
            // 
            this.pluralToOne.AutoSize = true;
            this.pluralToOne.Location = new System.Drawing.Point(262, 72);
            this.pluralToOne.Name = "pluralToOne";
            this.pluralToOne.Size = new System.Drawing.Size(96, 17);
            this.pluralToOne.TabIndex = 6;
            this.pluralToOne.Text = "Множ. в ед .ч.";
            this.pluralToOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.importInSynonyms);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox first_column_import;
        private System.Windows.Forms.CheckBox cbx_ping;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox pluralToOne;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ExcellObj = Microsoft.Office.Interop.Excel;
using System.Threading;
using word_concatenation.services;
using System.Collections;

namespace word_concatenation
{
  
    public partial class Form1 : Form
    {

        ConstructService constructService;

        public Form1()
        {
            this.constructService = new ConstructService();
            InitializeComponent();
        }

     

        private void addRowButton_Click(object sender, EventArgs e)
        {
            //Склеивание колонок таблицы в сроку итог; 
            for(int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                string total = "";
                for(int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    //MessageBox.Show(dataGridView1.Columns[j].DisplayIndex.ToString());
                
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (dataGridView1.Columns[k].DisplayIndex == j
                            && dataGridView1.Columns[k].Name != "total"
                            && dataGridView1.Columns[k].Name != "number"
                            )
                        { 
                            string val = dataGridView1[k, i].Value != null ? dataGridView1[k, i].Value.ToString() : "";
                            total += " " + val;
                          //  MessageBox.Show(val);
                        }
                    }
                  /*  if (dataGridView1[i, k].Value != null)
                        MessageBox.Show(dataGridView1[i,k].Value.ToString()); */
                }
                dataGridView1["total", i].Value = total;
            }
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1["synonyms", i].Value == null || dataGridView1["synonyms", i].Value == "")
                {
                    for(int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        dataGridView1[j,i].Value = "";
                    }
                    //dataGridView1.Rows.RemoveAt(i);
                 //   i--;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.EnableHeadersVisualStyles = false;

           


            var column1 = new DataGridViewColumn();
            column1.HeaderText = "№";
            column1.Width = 50;
            column1.ReadOnly = true;
            column1.Name = "number";
            column1.Frozen = false;
            column1.CellTemplate = new DataGridViewTextBoxCell();
            column1.HeaderCell.Style.ForeColor = Color.Red;
           

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Синонимы";
            column2.Name = "synonyms";
            column2.CellTemplate = new DataGridViewTextBoxCell();
            column2.Frozen = false;
            column2.HeaderCell.Style.ForeColor = Color.Red;

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Конструкция 1";
            column3.Name = "total";
            column3.CellTemplate = new DataGridViewTextBoxCell();
            column3.Frozen = false;
            column3.HeaderCell.Style.ForeColor = Color.Red;

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Конструкция 2";
            column4.Name = "total_two";
            column4.CellTemplate = new DataGridViewTextBoxCell();
            column4.Frozen = false;
            column4.HeaderCell.Style.ForeColor = Color.Red;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
            //    dataGridView1.Rows.Add("Example 1, Good " + i, i * 1000, i);
            }

            

          
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
          //  dataGridView1.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void importInSynonyms_Click(object sender, EventArgs e)
        {
            if (paste.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = " Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
                ofd.Title = "Выберите документ для загрузки данных";
                ExcellObj.Application app = new ExcellObj.Application();
                ExcellObj.Workbook workbook;
                ExcellObj.Worksheet NwSheet;
                ExcellObj.Range ShtRange;
                DataTable dt = new DataTable();
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    workbook = app.Workbooks.Open(ofd.FileName, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value
                    );
                    NwSheet = (ExcellObj.Worksheet)workbook.Sheets.get_Item(1);
                    //    ShtRange = NwSheet.UsedRange;
                    string range = col_import.Text + ":" + col_import.Text;
                  
                    ShtRange = NwSheet.get_Range(range);
                     
                    int empty_count = 0;
                    int start = first_column_import.Checked ? 1 : 2;
                    
                    for(int Rnum = start; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        if(empty_count == 10)
                        {
                            break;
                        }
                        if (Rnum - start >= dataGridView1.Rows.Count)
                        {
                            dataGridView1.Rows.Add();
                        }
                        for(int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2 != null)
                            {
                                empty_count = 0;
                                dataGridView1["synonyms", Rnum - start].Value = (ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2.ToString();
                            }
                            else
                            {
                                // MessageBox.Show((ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2.ToString());
                              
                            }
                         //   MessageBox.Show(Rnum.ToString() + " and " + Cnum.ToString());
                        }
                        empty_count++;
                   
                    }
                    app.Quit();
                }
            }
            else
            {
                //Парсинг синонимов
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = " Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
                ofd.Title = "Выберите документ для загрузки данных";
                ExcellObj.Application app = new ExcellObj.Application();
                ExcellObj.Workbook workbook;
                ExcellObj.Worksheet NwSheet;
                ExcellObj.Range ShtRange;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    workbook = app.Workbooks.Open(ofd.FileName, Missing.Value,
                       Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                       Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                       Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                       Missing.Value
                   );
                    NwSheet = (ExcellObj.Worksheet)workbook.Sheets.get_Item(1);
                    string range = col_import.Text + ":" + col_import.Text;
 
                    ShtRange = NwSheet.get_Range(range);
                    int start = first_column_import.Checked ? 1 : 2;
                    int empty_count = 0;
                   
                    for (int Rnum = start; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        if (empty_count == 10)
                        {
                            break;
                        }
                        if (Rnum - start >= dataGridView1.Rows.Count)
                        {
                            dataGridView1.Rows.Add();
                        }
                        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2 != null)
                            {
                                empty_count = 0;
                                string value = (ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2.ToString().Trim();
                                this.Text = "Парсинг: " + value;
                                dataGridView1["synonyms", Rnum - start].Value = SynomymsParse.GetWord(value, pluralToOne.Checked);
                                if(cbx_ping.Checked)
                                {
                                    Random rnd = new Random();
                                    Thread.Sleep(rnd.Next(1000, 3000));
                                }
                                    
                            }
                        }
                        empty_count++;
                    }
                    this.Text = "Парснг завершен";
                    app.Quit();
                }
            }
        }

        private void addColumn_Click(object sender, EventArgs e)
        {
            AddColumnForm form = new AddColumnForm();
            form.Owner = this;
            if(form.ShowDialog() == DialogResult.OK)
            {
                int rows_number =  Convert.ToInt32(form.rows_number.Text);
                var column = new DataGridViewColumn();
                column.HeaderText = form.col_name.Text;
             //   column.Name = "synonyms2";
                column.CellTemplate = new DataGridViewTextBoxCell();
           //     column.DisplayIndex = 2;
                dataGridView1.Columns.Add(column);
      
                for(int i = 0; i < rows_number; i++)
                {
                    if (i >= dataGridView1.Rows.Count)
                    {
                        dataGridView1.Rows.Add();
                    }
                    dataGridView1[column.Index, i].Value = form.col_symbols.Text;
                }
                dataGridView1.Columns["total"].DisplayIndex = dataGridView1.Columns.Count - 1;
                
            }
            form.Dispose();
        }

        

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            this.export("total", "markers"); 
        }

        private void export(string col_index, string file)
        {
            ExcellObj.Application exApp = new ExcellObj.Application();
            exApp.Workbooks.Add();
            ExcellObj.Worksheet workSheet = (ExcellObj.Worksheet)exApp.ActiveSheet;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string val = dataGridView1[col_index, i].Value.ToString();
                workSheet.Cells[i + 1, 1] = val;
            }


            string pathToFile = Environment.CurrentDirectory + "\\" + file + ".xls";
            workSheet.SaveAs(pathToFile);
            exApp.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for(int i = 3; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns.RemoveAt(i);
            }
           // Form1_Load(sender, e);
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удаление столбца", "Удалить данный столбец?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                dataGridView1.Columns.RemoveAt(e.ColumnIndex);
            }
            else if (dr == DialogResult.Cancel)
            {
                //
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
  
            List<string> lines = new List<string>();
            List<string> collections = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string val = dataGridView1["total", i].Value.ToString();
                lines.Add(dataGridView1["total", i].Value.ToString());
            }
 
            foreach(string line in lines)
            {
                List<string> format_lines = this.constructService.getConstruction(line);
                if(format_lines == null)
                {
                    continue;
                } 
                foreach (string format_line in format_lines)
                {
                    collections.Add(format_line);
                }
                
            }
            //   column.Name = "synonyms2";
           
            //     column.DisplayIndex = 2;
         

            for (int i = 0; i < collections.Count; i++)
            {
                if (i >= dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows.Add();
                }
                dataGridView1["total_two", i].Value = collections[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.export("total_two", "markers_contruct_two");
        }
    }

}

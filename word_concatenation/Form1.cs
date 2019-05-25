using System;
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

namespace word_concatenation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void addRowButton_Click(object sender, EventArgs e)
        {
            var column = new DataGridViewColumn();
            column.HeaderText = "Синонимы 2";
            column.Name = "synonyms2";
            column.CellTemplate = new DataGridViewTextBoxCell();
            column.DisplayIndex = 2;
            dataGridView1.Columns.Add(column);
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1["synonyms", i].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

             dataGridView1.AllowUserToOrderColumns = true;
             
             var column1 = new DataGridViewColumn();
             column1.HeaderText = "№ (0)";
             column1.Width = 50;
             column1.ReadOnly = true;
             column1.Name = "number";
             column1.Frozen = false;
             column1.CellTemplate = new DataGridViewTextBoxCell();
          //   column1.DisplayIndex = 0;

             var column2 = new DataGridViewColumn();
             column2.HeaderText = "Синонимы (1)";
             column2.Name = "synonyms";
             column2.CellTemplate = new DataGridViewTextBoxCell();
           //  column2.DisplayIndex = 50;
             column1.Frozen = false;

            var column3 = new DataGridViewColumn();
             column3.HeaderText = "Итог(2)";
             column3.Name = "total";
             column3.CellTemplate = new DataGridViewTextBoxCell();
           //  column3.DisplayIndex = 100;
             column1.Frozen = false;

             dataGridView1.AllowUserToAddRows = false;
             dataGridView1.Columns.Add(column1);
             dataGridView1.Columns.Add(column2);
             dataGridView1.Columns.Add(column3);

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
                e.Value = e.RowIndex;
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
                     
                    for(int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        
                    }
                    int empty_count = 0;
                    for(int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        if(empty_count == 10)
                        {
                            break;
                        }
                        if (Rnum - 2 >= dataGridView1.Rows.Count)
                        {
                            dataGridView1.Rows.Add();
                        }
                        for(int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                          
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2 != null)
                            {
                                empty_count = 0;
                                // MessageBox.Show((ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2.ToString());
                                dataGridView1["synonyms", Rnum - 2].Value = (ShtRange.Cells[Rnum, Cnum] as ExcellObj.Range).Value2.ToString();
                            }
                                    
                        }
                        empty_count++;
                   
                    }
                    app.Quit();
                }
            }
            else
            {
                
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
    }

}

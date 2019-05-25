using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excell =

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
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                MessageBox.Show(col_import.Text + " Hello");
            }
            else
            {
                
            }
        }
    }

}

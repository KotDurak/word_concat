using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView1.Columns["name"].DisplayIndex = 2;
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Test";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "name";
            column1.Frozen = false;
            column1.CellTemplate = new DataGridViewTextBoxCell();
          

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Price";
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();
            
            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Remainder";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();
         
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            dataGridView1.AllowUserToAddRows = false;

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Example 1, Good " + i, i * 1000, i);
            }

            for(int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                dataGridView1.Rows.Add();
                dataGridView1["name", dataGridView1.Rows.Count - 1].Value = "Example 2 Good" + i;
                dataGridView1["price", dataGridView1.Rows.Count - 1].Value = i * 1000;
                dataGridView1["count", dataGridView1.Rows.Count - 1].Value = i;
            }

            //А теперь простой пройдемся циклом по всем ячейкам
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    object o = dataGridView1[j, i].Value;
                }
            }
        }
    }

}

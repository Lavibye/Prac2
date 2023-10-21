using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int m = Convert.ToInt32(textBox2.Text);
                Arrays2D twoDimArray = new Arrays2D(n, m);

                dataGridView1.Columns.Clear();
                for (int i = 0; i < m; i++)
                {
                    DataGridViewTextBoxColumn dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;
                    dataGridView1.Columns.Add(dvage);
                }

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = twoDimArray.X_lenght;
                dataGridView1.ColumnCount = twoDimArray.Y_lenght;

                for (int i = 0; i < twoDimArray.X_lenght; i++)
                    for (int j = 0; j < twoDimArray.Y_lenght; j++)
                        dataGridView1.Rows[i].Cells[j].Value = twoDimArray[i, j].ToString();

                var (rightDiagonalSum, leftDiagonalProduct) = twoDimArray.DiagonalSumProduct;
                label3.Text = rightDiagonalSum.ToString();
                label4.Text = leftDiagonalProduct.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {

        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table; // connescting it to our table


            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 185;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            boxTitle.Clear();
            boxMessage.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(boxTitle.Text, boxMessage.Text);
            boxTitle.Clear();
            boxMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // to know wich row it selected
            int index = dataGridView1.CurrentCell.RowIndex;


            if (index > -1)
            {
                boxTitle.Text = table.Rows[index].ItemArray[0].ToString();
                boxMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}

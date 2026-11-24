using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace голосование
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "голосованиеDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.голосованиеDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "голосованиеDataSet.Голосования". При необходимости она может быть перемещена или удалена.
            this.голосованияTableAdapter.Fill(this.голосованиеDataSet.Голосования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "голосованиеDataSet.Голоса". При необходимости она может быть перемещена или удалена.
            this.голосаTableAdapter.Fill(this.голосованиеDataSet.Голоса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "голосованиеDataSet.ВариантыОтветов". При необходимости она может быть перемещена или удалена.
            this.вариантыОтветовTableAdapter.Fill(this.голосованиеDataSet.ВариантыОтветов);

        }

        private void вариантыОтветовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
        }

        private void голосаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
        }

        private void голосованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
        }
    }
}

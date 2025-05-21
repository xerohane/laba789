using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabaVrode.Data;
using Microsoft.EntityFrameworkCore;

namespace LabaVrode
{
    public partial class Form4 : Form
    {
        DataContext db = new DataContext();
        public Form4()
        {
            InitializeComponent();
            Refresh();
        }

        public override void Refresh()
        {




            db.Groups.Load();

            db.Students.Load();
            dataGridView1.DataSource = db.Students.Local.ToBindingList();
            dataGridView2.DataSource = db.Groups.Local.ToBindingList();
            base.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6(this);
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

            new Form9(id).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }
    }
}

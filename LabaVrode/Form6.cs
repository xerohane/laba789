using LabaVrode.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaVrode
{
    public partial class Form6 : Form
    {
        DataContext db = new DataContext();
        Form parent;
        public Form6(Form parent)
        {
            InitializeComponent();

            this.parent = parent;

            db.Groups.Load();
            comboBox1.DataSource = db.Groups.Local.ToBindingList();
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string middlename = textBox3.Text;
            DateTime birthday = dateTimePicker1.Value;
            Group group = (Group)comboBox1.SelectedItem;

            var student = new Student()
            {
                Name = name,
                Surename = surname,
                MiddleName = middlename,
                BirthDay = birthday,
                Group = group

            };
            db.Add(student);
            db.SaveChanges();

            parent.Refresh();

            Close();
        }

    }
}

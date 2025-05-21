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

namespace LabaVrode
{
    public partial class Form5 : Form
    {
        Form parent;
        public Form5(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext();
            string groupName = textBox1.Text;

            Group group = new Group()
            {
                Name = groupName,
            };
            db.Add(group);
            db.SaveChanges();

            parent.Refresh();

            Close();
        }
    }
}

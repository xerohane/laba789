using LabaVrode.Data;
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
    public partial class Form8 : Form
    {
        string[] Subjects;
        public Form8()
        {
            InitializeComponent();

            using var db = new DataContext();
            Subjects = db.Subjects.Select(s => s.Name).ToArray();

            foreach (var subjectName in Subjects)
            {
                listBox1.Items.Add(subjectName);
            }
            textBox2.Text = Subjects.Length.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var input = textBox1.Text;
            string[] subjects;
            if (!string.IsNullOrEmpty(input))
            {
                subjects = Subjects.Where(s => s.Contains(input)).ToArray();
            }
            else
            {
                subjects = Subjects;
            }
            foreach (var subjectName in subjects)
            {
                listBox1.Items.Add(subjectName);
            }
        }

       
    }
}

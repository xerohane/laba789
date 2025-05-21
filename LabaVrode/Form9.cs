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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabaVrode
{
    public partial class Form9 : Form
    {
        int StudentId;
        public Form9(int studentId= 1)
        {
            InitializeComponent();
            StudentId = studentId;
            UpdateListView();

            using DataContext db = new DataContext();
            var subjects = db.Subjects.ToList();
            foreach (var subject in subjects)
            {
                comboBox1.Items.Add(subject);
            }
        }

        public void UpdateListView()
        {
            listView1.Items.Clear();

            using DataContext db = new DataContext();
            var subjects = db.Subjects
                .Include(x => x.Marks)
                .ThenInclude(x => x.Student)
                .SelectMany((y) => y.Marks
                                    .Where(y=> y.StudentId == StudentId)
                                    .DefaultIfEmpty(),
                                 (x,y) => new {X = x.Name, Y = y})
                .ToList();

            foreach(var subject in subjects)
            {
                var item = new ListViewItem(subject.X);
                item.SubItems.Add(subject.Y?.Value.ToString());
                listView1 .Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using DataContext db = new DataContext();
            Marks MARK = new Marks()
            {
                StudentId = StudentId,
                SubjectId = ((Subject)comboBox1.SelectedItem).Id,
                Value = int.Parse(textBox1.Text)
            };

            db.Add(MARK);
            db.SaveChanges();

            UpdateListView();
        }

    }
}

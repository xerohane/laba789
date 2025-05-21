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
    public partial class Form2 : Form
    {

        DataContext db = new DataContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string repeatPassword = textBox3.Text;


            //Проверка на совпадения

            if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

           bool exists = db.Users.Any(u => u.Login == login);
            if (exists)
            {
                MessageBox.Show("Пользователь с таким именем уже существует");
                return;
            }


            User user = new User()
            { Login = login,
              Password = password,
              isAdmin = false
            };


            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}

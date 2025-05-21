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
    public partial class Form3 : Form
    {

        DataContext db = new DataContext();


        public Form3()
        {
            InitializeComponent();

            //Загрузка пользователей из БД
            db.Users.Load();

            //Выгрузка в Датагрид
            dataGridView1.DataSource= db.Users.Local.ToBindingList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

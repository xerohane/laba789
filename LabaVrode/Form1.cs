using LabaVrode.Data;

namespace LabaVrode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using DataContext db = new DataContext();
            
            string login = textBox1.Text;
            string password = textBox2.Text;

            //����� ������������

            User user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("�������� ����� ��� ������");
                return;
            }


            if (user.isAdmin)
            {
                MessageBox.Show("�������� ����: �����");
                Form3 f3 = new Form3();
                f3.Show();
            }
            else 
            {
                MessageBox.Show("�������� ����: ������������");
                Form4 f = new Form4();
                f.Show();
            
            }

        }
    }
}

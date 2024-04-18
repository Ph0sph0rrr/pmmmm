using Npgsql;
using System.Data;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pm
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        string phome, pass;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnEmp_Click(object sender, EventArgs e)
        {
            phome = tBxPhEn.Text;
            pass = tBxPasEn.Text;
            

            if (phome.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkUs = new NpgsqlCommand($"SELECT fio, id FROM users WHERE phone = '{phome}' AND pass = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkUs.ExecuteReader();

                    if (reader.Read())
                    {
                        

                        this.Hide();
                        Form2 formMenu = new Form2();
                        formMenu.Show();
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form2 ent = new Form2();
            this.Hide();
            ent.Show();
        }
    }
}
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace pm
{
    public partial class Form2 : Form
    {
        Database db = new Database();
        string nameCl, checkRes;
        string fio, passCl, phone, Sp, Np, napravma, stat,
Mail,
Fiorod,
Shara,
yrobroz,
naprav,
atestate,
Diplom,
Ege1,
Ege2,
Ege3,
Ege4,
Eget1,
Eget2,
Eget3,
Eget4,
pass;







        public Form2()
        {
            


            InitializeComponent();
            



            



        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            List<int> reqs = new List<int>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT id FROM users WHERE stat = 'Подано'", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                reqs.Add(reader.GetInt32(0));
            }

            db.closeConnection();










            
        }

        private int countReqs()
        {
            List<int> reqs = new List<int>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT id FROM users WHERE stat = 'Подано'", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                reqs.Add(reader.GetInt32(0));
            }

            db.closeConnection();

            return reqs.Count();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            


        }

        private void regCl_Click(object sender, EventArgs e)
        {

            

            db.openConnection();
            NpgsqlCommand addCllllll = new NpgsqlCommand($"INSERT INTO users (fio, phone, sp,np, mail, fiorod, shara, yrobr, naprav,  ege1, ege2, ege3, ege4, eget1,eget2,eget3,eget4, pass, status) VALUES " +
                $"('{fio}', '{phone}','{Sp}','{Np}','{Mail}','{Fiorod}', '{Shara}','{yrobroz}','{naprav}','{Ege1}','{Ege2}','{Ege3}','{Ege4}','{Eget1}','{Eget2}','{Eget3}','{Eget4}','{pass}','{stat}')", db.getConnection());
            addCllllll.ExecuteNonQuery();
            MessageBox.Show("Заявка подана на специалитет.");
            db.closeConnection();


            stat = "Подано";
            fio = tBxIoRg.Text;
            phone = tBxPhRg.Text;
            Sp = sp.Text;
            Np = np.Text;
            Mail = mail.Text;
            Fiorod = fiorod.Text;
            Shara = shara.Text;
            yrobroz = comboBox1.Text;
            naprav = napravspec.Text;
            atestate = atestat.Text;
            Diplom = diplom.Text;
            Ege1 = ege1.Text;
            Ege2 = ege2.Text;
            Ege3 = ege3.Text;
            Ege4 = ege4.Text;
            Eget1 = eget1.Text;
            Eget2 = eget2.Text;
            Eget3 = eget3.Text;
            Eget4 = eget4.Text;
            pass = tBxPasRg.Text;
        }
    }
}

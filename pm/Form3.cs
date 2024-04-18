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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pm
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            Database db = new Database();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private int countReqs()
        {
            List<int> reqs = new List<int>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT id FROM products WHERE status = 'выполнено'", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                reqs.Add(reader.GetInt32(0));
            }

            db.closeConnection();

            return reqs.Count();
        }







        private void btnBack_Click(object sender, EventArgs e)
        {

        }


        Database db = new Database();
        string roleUs, oftProb;
        string nameCl, phoneCl;
        int doneReqs, idCl;
        

        private string countProb()
        {
            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT problem, COUNT(*) AS frequency FROM products GROUP BY problem ORDER BY frequency DESC LIMIT 1", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                oftProb = reader.GetString(0);
            }

            db.closeConnection();

            return oftProb;
        }

        private int countTime()
        {
            List<int> times = new List<int>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT start_date, finish_date FROM products", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                DateTime dateSt = reader.GetDateTime(0);
                DateOnly dateStOnly = DateOnly.FromDateTime(dateSt);
                DateTime dateFn = reader.GetDateTime(1);
                DateOnly dateFnOnly = DateOnly.FromDateTime(dateFn);
                var findat = dateFnOnly.DayNumber - dateStOnly.DayNumber;
                times.Add(Convert.ToInt32(findat));
            }

            db.closeConnection();
            int countTm = times.Count();
            int sumTm = times.Sum();
            int medTm = (sumTm / countTm);
            return medTm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbDoneReq_Click(object sender, EventArgs e)
        {

        }

        private void lbMedTime_Click(object sender, EventArgs e)
        {

        }

        private void lbOftProb_Click(object sender, EventArgs e)
        {

        }

       
        

        }
}

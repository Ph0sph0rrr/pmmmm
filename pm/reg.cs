using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using System.Drawing.Printing;

namespace pm
{
    public partial class reg : Form
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

        private void eget1_TextChanged(object sender, EventArgs e)
        {

        }

        private void diplom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ege3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ege1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void atestat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ege2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void shara_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void fiorod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void snils_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sp_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBxPasRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBxPhRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string Filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(Filename);
            richTextBox1.Text = fileText;

            MessageBox.Show("Файл открыт");



        }

        public void print(string t)
        {
           
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void eget2_TextChanged(object sender, EventArgs e)
        {

        }

        private void eget3_TextChanged(object sender, EventArgs e)
        {

        }

        private void eget4_TextChanged(object sender, EventArgs e)
        {

        }

        private void np_TextChanged(object sender, EventArgs e)
        {

        }

        private void napravspo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void napravbak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void napravspec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void napravmag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int idd;


        

        public reg()
        {
            

            InitializeComponent();
            comboBox1.Items.Add("СПО");
            comboBox1.Items.Add("Бакалавриат");
            comboBox1.Items.Add("Специалитет");
            comboBox1.Items.Add("Магистратура");
            //СПО, Бакалавриат, Специалитет, Магистратура

            ege1.Items.Add("Русский язык");
            ege1.Items.Add("Английский язык");
            ege1.Items.Add("Математика");
            ege1.Items.Add("Информатика");
            ege1.Items.Add("Биология");
            ege1.Items.Add("Химия");
            ege1.Items.Add("История");
            ege1.Items.Add("Литература");
            ege1.Items.Add("География");


            ege2.Items.Add("Русский язык");
            ege2.Items.Add("Английский язык");
            ege2.Items.Add("Математика");
            ege2.Items.Add("Информатика");
            ege2.Items.Add("Биология");
            ege2.Items.Add("Химия");
            ege2.Items.Add("История");
            ege2.Items.Add("Литература");
            ege2.Items.Add("География");


            ege3.Items.Add("Русский язык");
            ege3.Items.Add("Английский язык");
            ege3.Items.Add("Математика");
            ege3.Items.Add("Информатика");
            ege3.Items.Add("Биология");
            ege3.Items.Add("Химия");
            ege3.Items.Add("История");
            ege3.Items.Add("Литература");
            ege3.Items.Add("География");


            ege4.Items.Add("Русский язык");
            ege4.Items.Add("Английский язык");
            ege4.Items.Add("Математика");
            ege4.Items.Add("Информатика");
            ege4.Items.Add("Биология");
            ege4.Items.Add("Химия");
            ege4.Items.Add("История");
            ege4.Items.Add("Литература");
            ege4.Items.Add("География");


            napravbak.Items.Add("07.03.01 Архитектура Профиль: «Архитектура»");
            napravbak.Items.Add("07.03.02  Реконструкция и реставрация архитектурного наследия Профиль: «Реконструкция и реставрация архитектурного наследия»");
            napravbak.Items.Add("07.03.03 Дизайн архитектурной среды Профиль: «Дизайн архитектурной среды»");
            napravbak.Items.Add("07.03.04 Градостроительство Профиль: «Градостроительное проектирование»");


            napravmag.Items.Add("07.04.01 Архитектура Программа «Актуальные направления теории и практики архитектуры»");
            napravmag.Items.Add("07.04.02 Реконструкция и реставрация архитектурного наследия Программа «Реконструкция и реставрация архитектурного наследия»");
            napravmag.Items.Add("07.04.03 Дизайн архитектурной среды Программа «Дизайн архитектурной среды»");
          
            napravspec.Items.Add("10.05.02 Информационная безопасность телекоммуникационных систем");
            napravspec.Items.Add("11.05.01 Радиоэлектронные системы и комплексы");
            napravspec.Items.Add("24.05.02 Проектирование авиационных и ракетных двигателей");
            napravspec.Items.Add("24.05.07 Самолето- и вертолетостроение");

            napravspo.Items.Add("11.01.01 Монтажник радиоэлектронной аппаратуры и приборов");
            napravspo.Items.Add("08.02.01 Строительство и эксплуатация зданий и сооружений");
            napravspo.Items.Add("08.02.05 Строительство и эксплуатация автомобильных дорог и аэродромов");
            napravspo.Items.Add("08.02.08 Монтаж и эксплуатация оборудования и систем газоснабжения");
            napravspo.Items.Add("08.02.13 Монтаж и эксплуатация внутренних сантехнических устройств, кондиционирования воздуха и вентиляции");
            napravspo.Items.Add("09.02.01 Компьютерные системы и комплексы");



            label11.Visible = false;
            atestat.Visible = false;
            //

            label12.Visible = false;
            ege1.Visible = false;
            ege2.Visible = false;
            ege3.Visible = false;
            ege4.Visible = false;

            eget1.Visible = false;
            eget2.Visible = false;
            eget3.Visible = false;
            eget4.Visible = false;


            //
            diplom.Visible = false;
            label13.Visible = false;

            napravbak.Visible = false;
            napravmag.Visible = false;
            napravspec.Visible = false;
            napravspo.Visible = false;


        }

        private void tBxIoRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)//спо
            {
                label11.Visible = true;
                atestat.Visible = true;
                napravspo.Visible = true;


                ///////////////////
                label12.Visible = false;
                ege1.Visible = false;
                ege2.Visible = false;
                ege3.Visible = false;
                ege4.Visible = false;
                napravbak.Visible = false;
                eget1.Visible = false;
                eget2.Visible = false;
                eget3.Visible = false;
                eget4.Visible = false;
                napravspec.Visible = false;
                //
                diplom.Visible = false;
                label13.Visible = false;
                napravmag.Visible = false;


            }
            if (comboBox1.SelectedIndex == 1)//Бакалавриат
            {
                label12.Visible = true;
                napravbak.Visible= true;
                ege1.Visible = true;
                ege2.Visible = true;
                ege3.Visible = true;
                ege4.Visible = true;

                eget1.Visible = true;
                eget2.Visible = true;
                eget3.Visible = true;
                eget4.Visible = true;

                /////////////////////
                napravspo.Visible = false;
                label11.Visible = false;
                atestat.Visible = false;
                napravspec.Visible = false;

                //
                diplom.Visible = false;
                label13.Visible = false;
                napravmag.Visible= false;

            }
            if (comboBox1.SelectedIndex ==2)//Специалитет
            {
                label12.Visible = true;
                napravspec.Visible = true;
                ege1.Visible = true;
                ege2.Visible = true;
                ege3.Visible = true;
                ege4.Visible = true;
                napravspo.Visible = false;
                eget1.Visible = true;
                eget2.Visible = true;
                eget3.Visible = true;
                eget4.Visible = true;

                //////////////////////

                label11.Visible = false;
                atestat.Visible = false;
                napravspo.Visible = false;
                napravbak.Visible = false;
                napravmag.Visible = false;
                //
                diplom.Visible = false;
                label13.Visible = false;
            }
            if (comboBox1.SelectedIndex ==3 ) //магистратура
            {
                diplom.Visible = true;
                label13.Visible = true;
                napravmag.Visible = true;

                ///////////////////////
                label12.Visible = false;
                ege1.Visible = false;
                ege2.Visible = false;
                ege3.Visible = false;
                ege4.Visible = false;
                napravspec.Visible= false;
                eget1.Visible = false;
                eget2.Visible = false;
                eget3.Visible = false;
                eget4.Visible = false;
                napravbak.Visible = false;

                //

                label11.Visible = false;
                atestat.Visible = false;


            }



        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNumericc(string textt)
        {
            foreach (char c in textt)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        private bool IsNumericcc(string texttt)
        {
            foreach (char c in texttt)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNumericccc(string textttt)
        {
            foreach (char c in textttt)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNumericcccc(string texttttt)
        {
            return int.TryParse(texttttt, out _);
        }



        int x = 5;

        private void regCl_Click(object sender, EventArgs e)
        {
           




            if (tBxPhRg.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (tBxIoRg.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (tBxPasRg.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (sp.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (np.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (snils.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (mail.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (fiorod.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (shara.Text == "")
            {
                MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tBxPasRg.Text, @"^[a-zA-Z0-9._]+(@|#|%|<|>)$")) // проверка yf pyfrb
            {
                MessageBox.Show("Введите дополнительные знаки");
                return;
            }

            if (!Regex.IsMatch(mail.Text, @"^[a-zA-Z0-9._]+(@mail|@yandex|@gm|@bk|>)$")) // проверка на почту
            {
                MessageBox.Show("Введите  почту");
                return;
            }

            







            //88888888888







            string text = tBxPhRg.Text.Trim();
            if (text.Length == 11 && (text.StartsWith("8") || text.StartsWith("7")) && IsNumeric(text))
            {
              //  MessageBox.Show("Текст введен корректно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка: Текст должен состоять из 11 цифр и начинаться с 7 или 8.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textt = sp.Text.Trim();
            if (textt.Length == 4 && (IsNumericc(textt)))
            {
                //  MessageBox.Show("Текст введен корректно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка: серия паспорта должна состоять из 4 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texttt = np.Text.Trim();
            if (texttt.Length == 6 && (IsNumericcc(texttt)))
            {
                //  MessageBox.Show("Текст введен корректно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка: Номер паспорта должен состоять из 6 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textttt = snils.Text.Trim();
            if (textttt.Length == 11 && (IsNumericccc(textttt)))
            {
                //  MessageBox.Show("Текст введен корректно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка: Номер снилса должен состоять из 11 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }










            if (comboBox1.SelectedIndex == 2) // специалетет
            {

                if (ege1.Text == ege2.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege1.Text == ege3.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege1.Text == ege4.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (ege2.Text == ege3.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege2.Text == ege4.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ege3.Text == ege4.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ege1.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege2.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege3.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege4.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget1.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget2.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget3.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget4.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                int value1 = Convert.ToInt32(eget1.Text);
                int value2 = Convert.ToInt32(eget2.Text);
                int value3 = Convert.ToInt32(eget3.Text);
                int value4 = Convert.ToInt32(eget4.Text);
                

                if (value1 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;
                }

                if (value2 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;

                }
                if (value3 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;

                }
                if (value4 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;

                }


                if (napravspec.Text == "")
                { 
                    MessageBox.Show(" Укажите направление");
                    return;
                }



                MessageBox.Show("Успех");

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


            if (comboBox1.SelectedIndex == 1)//бакаловариат
            {

                if (ege1.Text == ege2.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege1.Text == ege3.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege1.Text == ege4.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (ege2.Text == ege3.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege2.Text == ege4.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ege3.Text == ege4.Text)
                {
                    MessageBox.Show("Ошибка: Текст в комбобоксах совпадает!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ege1.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege2.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege3.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ege4.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение комбобокса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget1.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget2.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget3.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (eget4.Text == "")
                {
                    MessageBox.Show("Ошибка: пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                
                int value1 =  Convert.ToInt32(eget1.Text);
                int value2 = Convert.ToInt32(eget2.Text);
                int value3 = Convert.ToInt32(eget3.Text);
                int value4 = Convert.ToInt32(eget4.Text);

                if (value1 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;
                }

                if (value2 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;

                }
                if (value3 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;

                }
                if (value4 > 100)
                {
                    MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                    return;

                }


                if (napravbak.Text == "")
                {
                    MessageBox.Show(" Укажите направление");
                    return;
                }





                MessageBox.Show("Успех");

                db.openConnection();
                NpgsqlCommand addCllll = new NpgsqlCommand($"INSERT INTO users (fio, phone, sp,np, mail, fiorod, shara, yrobr, naprav,  ege1, ege2, ege3, ege4, eget1,eget2,eget3,eget4, pass,status) VALUES " +
                    $"('{fio}', '{phone}','{Sp}','{Np}','{Mail}','{Fiorod}', '{Shara}','{yrobroz}','{naprav}','{Ege1}','{Ege2}','{Ege3}','{Ege4}','{Eget1}','{Eget2}','{Eget3}','{Eget4}','{pass}',{stat}')", db.getConnection());
                addCllll.ExecuteNonQuery();
                MessageBox.Show("Заявка подана на бакаловариат.");
                db.closeConnection();




                //88888888888








                stat = "Подано";
                fio = tBxIoRg.Text;
                phone = tBxPhRg.Text;
                Sp = sp.Text;
                Np = np.Text;
                Mail = mail.Text;
                Fiorod = fiorod.Text;
                Shara = shara.Text;
                yrobroz = comboBox1.Text;
                naprav = napravbak.Text;
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

            if (comboBox1.SelectedIndex== 0) //спо
            {
                if (atestat.Text == "")
                {
                    MessageBox.Show("Укажите средний балл аттестата");
                    return;




                }
                    int value5 = Convert.ToInt32(atestat.Text);

                    if (value5 > 100)
                    {
                        MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                        return;


                    }




                    if (comboBox1.Text == "")
                    {
                        MessageBox.Show("Укажите уровень образования");
                        return;
                    }


                if (napravspo.Text == "")
                {
                    MessageBox.Show(" Укажите направление");
                    return;
                }





                MessageBox.Show("Успех");

                db.openConnection();
                NpgsqlCommand addClll = new NpgsqlCommand($"INSERT INTO users (fio, phone, sp,np, mail, fiorod, shara, yrobr, naprav, atestat,  pass, status) VALUES " +
                    $"('{fio}', '{phone}','{Sp}','{Np}','{Mail}','{Fiorod}', '{Shara}','{yrobroz}','{naprav}','{atestate}','{pass}','{stat}')", db.getConnection());
                addClll.ExecuteNonQuery();
                MessageBox.Show("Заявка подана на СПО.");
                db.closeConnection();




                //88888888888

                stat = "Подано";
                fio = tBxIoRg.Text;
                phone = tBxPhRg.Text;
                Sp = sp.Text;
                Np = np.Text;
                Mail = mail.Text;
                Fiorod = fiorod.Text;
                Shara = shara.Text;
                yrobroz = comboBox1.Text;
                naprav = napravspo.Text;
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

            if (comboBox1.SelectedIndex == 3) //магистратура
            {
                if (diplom.Text == "")
                {
                    MessageBox.Show("Укажите средний бал диплома");
                    return;

                }
                    int value6 = Convert.ToInt32(diplom.Text);



                    
                    if (value6 > 100)
                    {
                        MessageBox.Show("БАЛЛ БОЛЬШЕ 100");
                        return;

                    }

                if (napravmag.Text == "")
                {
                    MessageBox.Show(" Укажите направление");
                    return;
                }








                MessageBox.Show("Успех");

                db.openConnection();
                NpgsqlCommand addCll = new NpgsqlCommand($"INSERT INTO users (fio, phone, sp,np, mail, fiorod, shara, yrobr, naprav, diplom, pass, status) VALUES " +
                    $"('{fio}', '{phone}','{Sp}','{Np}','{Mail}','{Fiorod}', '{Shara}','{yrobroz}','{napravma}','{Diplom}','{pass}','{stat}')", db.getConnection());
                addCll.ExecuteNonQuery();
                MessageBox.Show("Заявление в магистратуру подано.");
                db.closeConnection();




                //88888888888
                stat = "Подано";
                fio = tBxIoRg.Text;
                phone = tBxPhRg.Text;
                Sp = sp.Text;
                Np = np.Text;
                Mail = mail.Text;
                Fiorod = fiorod.Text;
                Shara = shara.Text;
                yrobroz = comboBox1.Text;
                napravma = napravmag.Text;
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




            if (comboBox1.Text == "")
            {
                MessageBox.Show("Укажите уровень образования");
                return;
            }


            ///////////////////////////////////

                MessageBox.Show("Успех");

            db.openConnection();
            NpgsqlCommand addCl = new NpgsqlCommand($"INSERT INTO users (fio, phone, sp,np, mail, fiorod, shara, yrobr, naprav, atestat, diplom, ege1, ege2, ege3, ege4, eget1,eget2,eget3,eget4, pass, status) VALUES " +
                $"('{fio}', '{phone}','{Sp}','{Np}','{Mail}','{Fiorod}', '{Shara}','{yrobroz}','{naprav}','{atestate}','{Diplom}','{Ege1}','{Ege2}','{Ege3}','{Ege4}','{Eget1}','{Eget2}','{Eget3}','{Eget4}','{pass}','{stat}')", db.getConnection());
            addCl.ExecuteNonQuery();
            MessageBox.Show("Вы успешно зарегистрированы.");
            db.closeConnection();




            //88888888888

            


            x =x-1;
            if (x == 0)
            {
                MessageBox.Show("Ошибка: заявлений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            stat = "Подано";
            fio = tBxIoRg.Text;
             phone = tBxPhRg.Text;
             Sp = sp.Text;
             Np = np.Text;
             Mail= mail.Text;
             Fiorod = fiorod.Text;
             Shara = shara   .Text;
             yrobroz = comboBox1.Text;
             naprav = napravmag.Text;
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


            /////////////////////
        }



       



        private void ege4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            Form1 ent = new Form1();
            this.Hide();
            ent.Show();
        }
    }
}

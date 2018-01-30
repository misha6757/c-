using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Sdelka". При необходимости она может быть перемещена или удалена.
            this.sdelkaTableAdapter.Fill(this.bondarevDataSet.Sdelka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Usluga". При необходимости она может быть перемещена или удалена.
            this.uslugaTableAdapter.Fill(this.bondarevDataSet.Usluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Skidka". При необходимости она может быть перемещена или удалена.
            this.skidkaTableAdapter.Fill(this.bondarevDataSet.Skidka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.bondarevDataSet.Klient);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Nkl = "";
            string FIO = "";
            string Viddet = "";
            string Adr = "";
            string Tel = "";
            string sum = "";
            Nkl = Convert.ToString(textBox1.Text);
            FIO = Convert.ToString(textBox2.Text);
            Viddet = Convert.ToString(textBox3.Text);
            Adr = Convert.ToString(textBox4.Text);
            Tel = Convert.ToString(textBox5.Text);
            sum = "('" + Nkl + "', '" + FIO + "', '" + Viddet + "', '" + Adr + "', '" + Tel + "')";
            klientTableAdapter.Connection.Open();
            OleDbCommand command = klientTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Klient (N_klienta, FIO, VId_deaytelnosti, adress, telefon) VALUES " + sum;
            command.ExecuteNonQuery();
            klientTableAdapter.Connection.Close();          
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("TI LOH");
            klientTableAdapter.Update(bondarevDataSet.Klient);
            klientTableAdapter.Fill(bondarevDataSet.Klient);


           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Sk = "";
            string Vid = "";
            string Raz = "";
            string sum = "";
            Sk = Convert.ToString(textBox10.Text);
            Vid = Convert.ToString(textBox9.Text);
            Raz = Convert.ToString(textBox8.Text);
            sum = "('" + Sk + "', '" + Vid + "', '" + Raz + "')";
            skidkaTableAdapter.Connection.Open();
            OleDbCommand command = skidkaTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Skidka (N_skidki, Vid_skidki, Razmer_skidki) VALUES " + sum;
            command.ExecuteNonQuery();
            skidkaTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("TI LOH");
            skidkaTableAdapter.Update(bondarevDataSet.Skidka);
            skidkaTableAdapter.Fill(bondarevDataSet.Skidka);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Nus = "";
            string Op = "";
            string St = "";
            string sum = "";
            Nus = Convert.ToString(textBox15.Text);
            Op = Convert.ToString(textBox14.Text);
            St = Convert.ToString(textBox13.Text);
            sum = "('" + Nus + "', '" + Op + "', '" + St + "')";
            uslugaTableAdapter.Connection.Open();
            OleDbCommand command = uslugaTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Usluga (N_uslugi, Opisanie_uslugi, Stoimost_uslugi) VALUES " + sum;
            command.ExecuteNonQuery();
            uslugaTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("TI LOH");
            uslugaTableAdapter.Update(bondarevDataSet.Usluga);
            uslugaTableAdapter.Fill(bondarevDataSet.Usluga);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Ns = "";
            string Nu = "";
            string Da = "";
            string Su = "";
            string ko = "";
            string Nsk = "";
            string Nk = "";
            string sum = "";
            Ns = Convert.ToString(textBox20.Text);
            Da = Convert.ToString(textBox19.Text);
            Su = Convert.ToString(textBox18.Text);
            ko = Convert.ToString(textBox17.Text);
            Nsk = Convert.ToString(textBox16.Text);
            Nk = Convert.ToString(textBox6.Text);
            Nu = Convert.ToString(textBox7.Text);
            sum = "('" + Ns + "', '" + Da + "', '" + Su + "', '" + ko + "', '" + Nsk + "', '" + Nk + "', '" + Nu + "')";
            sdelkaTableAdapter.Connection.Open();
            OleDbCommand command = sdelkaTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Sdelka (N_sdelki, Data, Summa_sdelki, komissionie, N_skidki, N_klienta, N_uslugi) VALUES " + sum;
            command.ExecuteNonQuery();
            sdelkaTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("TI LOH");
            sdelkaTableAdapter.Update(bondarevDataSet.Sdelka);
            sdelkaTableAdapter.Fill(bondarevDataSet.Sdelka);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Nkl;
            Nkl = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            klientTableAdapter.Connection.Open();
            OleDbCommand command = klientTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Klient WHERE N_klienta = " + Nkl;
            command.ExecuteNonQuery();
            klientTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Klient WHERE N_klienta = " + Nkl;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE OK");
            klientTableAdapter.Update(bondarevDataSet.Klient);
            klientTableAdapter.Fill(bondarevDataSet.Klient);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int Sk;
            Sk = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            skidkaTableAdapter.Connection.Open();
            OleDbCommand command = skidkaTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Skidka WHERE N_skidki = " + Sk;
            command.ExecuteNonQuery();
            skidkaTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Skidka WHERE N_skidki = " + Sk;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE OK");
            skidkaTableAdapter.Update(bondarevDataSet.Skidka);
            skidkaTableAdapter.Fill(bondarevDataSet.Skidka);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int Nus;
            Nus = Convert.ToInt32(comboBox3.SelectedValue.ToString());
            uslugaTableAdapter.Connection.Open();
            OleDbCommand command = uslugaTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Usluga WHERE N_uslugi = " + Nus;
            command.ExecuteNonQuery();
            uslugaTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Usluga WHERE N_uslugi = " + Nus;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE OK");
            uslugaTableAdapter.Update(bondarevDataSet.Usluga);
            uslugaTableAdapter.Fill(bondarevDataSet.Usluga);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int Ns;
            Ns = Convert.ToInt32(comboBox4.SelectedValue.ToString());
            sdelkaTableAdapter.Connection.Open();
            OleDbCommand command = sdelkaTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Sdelka WHERE N_sdelki = " + Ns;
            command.ExecuteNonQuery();
            sdelkaTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Sdelka WHERE N_sdelki = " + Ns;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE OK");
            sdelkaTableAdapter.Update(bondarevDataSet.Sdelka);
            sdelkaTableAdapter.Fill(bondarevDataSet.Sdelka);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
        conn.Open();
            OleDbDataAdapter zapros1 = new
                OleDbDataAdapter("SELECT Klient.FIO, Klient.Telefon FROM Klient", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT Klient.FIO, Klient.Telefon FROM Klient", conn);
            zapros1.SelectCommand = command;
            DataTable DTzap1 = new DataTable();
            zapros1.Fill(DTzap1);
            BindingSource BSzap1 = new BindingSource();
            BSzap1.DataSource = DTzap1;
            dataGridView5.DataSource = BSzap1;
            dataGridView5.Columns[0].HeaderCell.Value = "Ф.И.О";
            dataGridView5.Columns[1].HeaderCell.Value = "Телефон";
            conn.Close();
            MessageBox.Show("TI LOH");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros2 = new
                OleDbDataAdapter("SELECT Usluga.Opisanie_uslugi, Klient.telefon FROM Usluga, Klient", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT Usluga.Opisanie_uslugi, Klient.telefon FROM Usluga, Klient", conn);
            zapros2.SelectCommand = command;
            DataTable DTzap2 = new DataTable();
            zapros2.Fill(DTzap2);
            BindingSource BSzap2 = new BindingSource();
            BSzap2.DataSource = DTzap2;
            dataGridView5.DataSource = BSzap2;
            dataGridView5.Columns[0].HeaderCell.Value = "Описание";
            dataGridView5.Columns[1].HeaderCell.Value = "Номер телефона";
            conn.Close();
            MessageBox.Show("TI LOH");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros3 = new
                OleDbDataAdapter("SELECT Klient.FIO, Sdelka.Data FROM Klient INNER JOIN Sdelka ON Klient.[N_klienta] = Sdelka.[N_klienta]", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT Klient.FIO, Sdelka.Data FROM Klient INNER JOIN Sdelka ON Klient.[N_klienta] = Sdelka.[N_klienta]", conn);
            zapros3.SelectCommand = command;
            DataTable DTzap3 = new DataTable();
            zapros3.Fill(DTzap3);
            BindingSource BSzap3 = new BindingSource();
            BSzap3.DataSource = DTzap3;
            dataGridView5.DataSource = BSzap3;
            dataGridView5.Columns[0].HeaderCell.Value = "Ф.И.О";
            dataGridView5.Columns[1].HeaderCell.Value = "Дата сделки";
            conn.Close();
            MessageBox.Show("TI LOH");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros4 = new
                OleDbDataAdapter("SELECT MAX([Usluga.Stoimost_uslugi]) FROM Usluga;", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT MAX([Usluga.Stoimost_uslugi]) FROM Usluga;", conn);
            zapros4.SelectCommand = command;
            DataTable DTzap4 = new DataTable();
            zapros4.Fill(DTzap4);
            BindingSource BSzap4 = new BindingSource();
            BSzap4.DataSource = DTzap4;
            dataGridView5.DataSource = BSzap4;
            dataGridView5.Columns[0].HeaderCell.Value = "Максимальная стоимость";
            conn.Close();
            MessageBox.Show("TI LOH");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros5 = new
                OleDbDataAdapter("SELECT Sum(Sdelka.[Summa_sdelki]) AS [Sum-Summa_sdelki] FROM Sdelka", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT Sum(Sdelka.[Summa_sdelki]) AS [Sum-Summa_sdelki] FROM Sdelka", conn);
            zapros5.SelectCommand = command;
            DataTable DTzap5 = new DataTable();
            zapros5.Fill(DTzap5);
            BindingSource BSzap5 = new BindingSource();
            BSzap5.DataSource = DTzap5;
            dataGridView5.DataSource = BSzap5;
            dataGridView5.Columns[0].HeaderCell.Value = "Сумма всех сделок";
            conn.Close();
            MessageBox.Show("TI LOH");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\я Миша\Tupamiha\WindowsFormsApplication2\Bondarev.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros6 = new
                OleDbDataAdapter("SELECT Sdelka.Summa_Sdelki, Sdelka.komissionie, (Summa_Sdelki-komissionie) FROM Sdelka;", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT (Summa_Sdelki-komissionie) FROM Sdelka;", conn);
            zapros6.SelectCommand = command;
            DataTable DTzap6 = new DataTable();
            zapros6.Fill(DTzap6);
            BindingSource BSzap6 = new BindingSource();
            BSzap6.DataSource = DTzap6;
            dataGridView5.DataSource = BSzap6;
            dataGridView5.Columns[0].HeaderCell.Value = "Значение сделок без комисионных";
            conn.Close();
            MessageBox.Show("TI LOH");
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    public partial class FormAdmin : Form
    {
        SqlCon connection = new SqlCon();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void Listele()
        {
            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "Execute DiyetisyenListele"
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvAdmin.DataSource = dt;
            connection.SqlConnect().Close();
        }

        void DiyetisyenEkle()
        {

            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "Execute DiyetisyenEkle "+Convert.ToDouble(txtTC.Text)+","+"'"+txtAd.Text+"'"+","+"'"+txtSoyad.Text+"'"+","+"'"+txtSifre.Text+"'"
            };
            commandShow.ExecuteNonQuery();
            connection.SqlConnect().Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DiyetisyenEkle();
            Listele();
        }
    }
}

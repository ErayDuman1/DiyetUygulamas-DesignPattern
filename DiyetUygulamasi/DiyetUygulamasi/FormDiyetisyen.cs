using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DiyetUygulamasi
{
    public partial class FormDiyetisyen : Form
    {
        public FormDiyetisyen(double TC)
        {
            InitializeComponent();
            DiyetisyenTC = TC;
        }
        double DiyetisyenTC;
        SqlCon connection = new SqlCon();
        
        void DGVDoldur()
        {
            SqlCommand dgvDoldur = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "Execute HastaListele " + Convert.ToDouble(DiyetisyenTC)
            };
            SqlDataAdapter adapt = new SqlDataAdapter(dgvDoldur);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvHastalar.DataSource = dt;
            connection.SqlConnect().Close();
        }
        void cmbDoldur(ComboBox cmb,int i)
        {
            SqlCommand cmbDoldur = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "Execute CmbDoldur " + i
            };
            SqlDataReader dr = cmbDoldur.ExecuteReader();
            while(dr.Read())
            {
                cmb.Items.Add(dr["Ad"]).ToString();
            }
            connection.SqlConnect().Close();
        }

        void HastaEkle()
        {
            DiyetBelirtilmedi diyet = new DiyetBelirtilmedi();

            if (cmbHastalik.SelectedIndex == 0)
            {
                Obez hasta = new Obez(diyet);
                HastaEkleKalip(hasta);
            }
            else if (cmbHastalik.SelectedIndex == 1)
            {
                Colyak hasta = new Colyak(diyet);
                HastaEkleKalip(hasta);
            }
            else if (cmbHastalik.SelectedIndex == 2)
            {
                Seker hasta = new Seker(diyet);
                HastaEkleKalip(hasta);
            }
            DGVDoldur();
            
        }
        void HastaEkleKalip(Hasta hasta)
        {
            hasta.Tc = Convert.ToDouble(txtTC.Text);
            hasta.Ad = txtAd.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.HastalikID = cmbHastalik.SelectedIndex + 1;
            hasta.DiyetisyenTc = DiyetisyenTC;
            hasta.hastaOlustur(hasta);
            txtTC.ResetText();
            txtAd.ResetText();
            txtSoyad.ResetText();
            cmbHastalik.ResetText();
        }

        void DiyetAta()
        {
            if(cmbDiyetDegistir.SelectedIndex==0)
            {
                IDiyet diyet = new Akdeniz();
                diyet.DiyetAta(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value.ToString()));
            }
            else if(cmbDiyetDegistir.SelectedIndex == 1)
            {
                IDiyet diyet = new GlutenFree();
                diyet.DiyetAta(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value.ToString()));
            }
            else if (cmbDiyetDegistir.SelectedIndex == 2)
            {
                IDiyet diyet = new DenizUrunleri();
                diyet.DiyetAta(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value.ToString()));
            }
            else
            {
                IDiyet diyet = new YesilliklerDunyasi();
                diyet.DiyetAta(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value.ToString()));
            }
            cmbDiyetDegistir.ResetText();
            DGVDoldur();
        }


        private void FormDiyetisyen_Load(object sender, EventArgs e)
        {
            cmbDoldur(cmbHastalik,0);
            cmbDoldur(cmbDiyetDegistir, 1);
            DGVDoldur();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HastaEkle();
        }

        private void btnDiyet_Click(object sender, EventArgs e)
        {
            DiyetAta();
        }

        private void btnHTML_Click(object sender, EventArgs e)
        {
            if (cmbRapor.SelectedIndex == 0)
            {
                HTML html = new HTML(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value));
                html.BilgiCikti();
            }
            else if(cmbRapor.SelectedIndex == 1)
            {
                HTML html = new HTML(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value));
                html.BilgiCiktiTers();
            }
            else
            {
                MessageBox.Show("Rapor Düzeni Seçiniz.", "Hata!");
                return;
            }
            MessageBox.Show("HTML raporu başarıyla oluşturuldu!","Başarılı!");
            System.Diagnostics.Process.Start("rapor.html");
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            if (cmbRapor.SelectedIndex == 0)
            {
                JSON json = new JSON(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value));
                json.BilgiCikti();
            }
            else if (cmbRapor.SelectedIndex == 1)
            {
                JSON json = new JSON(Convert.ToDouble(dgvHastalar.SelectedCells[0].Value));
                json.BilgiCiktiTers();
            }
            else
            {
                MessageBox.Show("Rapor Düzeni Seçiniz.", "Hata!");
                return;
            }
            MessageBox.Show("JSON raporu başarıyla oluşturuldu!", "Başarılı!");
            System.Diagnostics.Process.Start("rapor.json");
        }
        private void FormDiyetisyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
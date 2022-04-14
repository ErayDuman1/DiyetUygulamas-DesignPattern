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

namespace DiyetUygulamasi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlCon connection = new SqlCon();
        void Kontrol()
        {
            SqlCommand kontrol = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText ="Select * from tblUser where UserTC="+txtTC.Text+" and UserSifre="+"'"+txtSifre.Text+"'"
            };
            
            SqlDataReader dr = kontrol.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                if(Convert.ToInt32(dr["UserTypeID"])==0)//Admin Ekranı Açma
                {
                    FormAdmin frmAdmin = new FormAdmin();
                    this.Hide();
                    frmAdmin.Show();
                }
                else
                {
                    FormDiyetisyen frmDiyetisyen = new FormDiyetisyen(Convert.ToDouble(txtTC.Text));
                    this.Hide();
                    frmDiyetisyen.Show();
                }
            }
            else
            {
                MessageBox.Show("Tc veya şifre yanlış!","Hata");
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kontrol();
        }
    }
}

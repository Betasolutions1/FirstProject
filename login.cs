using MaterialSkin.Controls;
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

namespace IFRPCVC
{
    public partial class login : MaterialForm
    {
        public login()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlConnection cn = new SqlConnection(CDatabase.ConnectionStr);
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //cn.Open();
            // cmd = new SqlCommand("select * from login  where UID='"+UID.Text+"' and PWD='"+PWD.Text+"' and UT='admin'", cn);
            // SqlCommand cmd1 = new SqlCommand("select * from login  where UID='" + UID.Text + "' and PWD='" + PWD.Text + "' and UT='operator'", cn); 
            //dr = cmd.ExecuteReader();
            //SqlDataReader dr1 = cmd1.ExecuteReader();
            //if (dr.Read())
            //{
            //    admin a = new admin();
            //    a.Show();
            //    this.Hide();
            //}
            //else if (dr1.Read())
            //{
            //    Form1 f = new Form1();
            //    f.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password");
            //}

            //cn.Close();
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            cn.Open();
            //cmd = new SqlCommand("select * from login  where U_N='" + UID.Text + "' and PWD='" + PWD.Text + "' and UT='admin'", cn);
            //SqlCommand cmd1 = new SqlCommand("select * from login  where U_N='" + UID.Text + "' and PWD='" + PWD.Text + "' and UT='operator'", cn);
            //dr = cmd.ExecuteReader();
            
            //if (dr.Read())
            //{
            //    admin a = new admin();
            //    a.Show();
            //    this.Hide();
            //}
            //else 
            //{
            //    MessageBox.Show("Invalid Username or Password");
               
            //}
            //dr.Close();
            //SqlDataReader dr1 = cmd1.ExecuteReader();
            //   if (dr1.Read())
            //   {
            //         Form1 f = new Form1();
            //    f.Show();
            //    this.Hide();
            //    }
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password");
            //}
           
           
            //dr1.Close();

            SqlDataAdapter da = new SqlDataAdapter("select * from login  where U_N='" + UID.Text + "' and PWD='" + PWD.Text + "' and UT='admin'", cn);
            SqlDataAdapter da1= new SqlDataAdapter("select * from login  where U_N='" + UID.Text + "' and PWD='" + PWD.Text + "' and UT='operator'",cn);
            DataTable dt = new DataTable();
            DataTable dt1= new DataTable();
            da.Fill(dt);
            da1.Fill(dt1);
            

            if(dt.Rows.Count==1)
            {
                admin a = new admin();
                   a.Show();
                   this.Hide();
            }
            else if (dt1.Rows.Count == 1)
            {
                entry1 f = new entry1();
                string un = UID.Text;
                f.txtprint = un;
                f.Owner = this;
                f.Show();
                this.Hide();
               
            }
            else 
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
            cn.Close();
        }
    }
}

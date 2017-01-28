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
using CrystalDecisions.CrystalReports.Engine;

namespace IFRPCVC
{
    public partial class prnt_vw : Form
    {
        public prnt_vw()
        {
            InitializeComponent();
        }
        CDatabase cd = new CDatabase();
        public string txtprint
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string txtprint1
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string txtprint2
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string txtprint3
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public void PrintReport(string Id,string Id1,string Id2,string Id3)
        {
            //prnt_all un = new prnt_all();
            //SqlConnection cn = new SqlConnection(CDatabase.ConnectionStr);
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("USP_GET_ID", cn);
            //SqlCommand cmd1 = new SqlCommand("USP_GET_ID1", cn);
            //SqlCommand cmd2 = new SqlCommand("USP_GET_ID2", cn);
            //SqlCommand cmd3 = new SqlCommand("USP_GET_ID3", cn);

            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@P_ID", Id);
            //cmd1.CommandType = CommandType.StoredProcedure;
            //cmd1.Parameters.AddWithValue("@P_ID1", Id1);
            //cmd2.CommandType = CommandType.StoredProcedure;
            //cmd2.Parameters.AddWithValue("@P_ID2", Id2);
            //cmd3.CommandType = CommandType.StoredProcedure;
            //cmd3.Parameters.AddWithValue("@P_ID3", Id3);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //un.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = un;
            //crystalReportViewer1.Refresh();
            ////un.PrintOptions.PrinterName = "HP LaserJet 1020 (Copy 2)";
            ////un.PrintOptions.PrinterName = "HP LaserJet 1020";
            ////un.PrintOptions.PrinterName = "Microsoft Print to PDF";
            ////un.PrintToPrinter(1, false, 1, 6);
            //cn.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            textBox1.Text = txtprint;
            textBox2.Text = txtprint1;
            textBox3.Text = txtprint2;
            textBox4.Text = txtprint3;

            prnt_all un = new prnt_all();
            SqlConnection cn = new SqlConnection(CDatabase.ConnectionStr);
            cn.Open();
            SqlCommand cmd = new SqlCommand("USP_GET_ID", cn);
            SqlCommand cmd1 = new SqlCommand("USP_GET_ID1", cn);
            SqlCommand cmd2 = new SqlCommand("USP_GET_ID2", cn);
            SqlCommand cmd3 = new SqlCommand("USP_GET_ID3", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@P_ID", textBox1.Text);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@P_ID1", textBox2.Text);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@P_ID2", textBox3.Text);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@P_ID3", textBox4.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            un.SetDataSource(dt);

            crystalReportViewer1.ReportSource = un;
            crystalReportViewer1.Refresh();
            //un.PrintOptions.PrinterName = "HP LaserJet 1020 (Copy 2)";
            //un.PrintOptions.PrinterName = "HP LaserJet 1020";
            // un.PrintOptions.PrinterName = "Microsoft Print to PDF";
            // un.PrintToPrinter(1, false, 1, 6);
            cn.Close();
        }
        //private void crystalReportViewer1_Load(object sender, EventArgs e)
        //{
        //    Untitled un = new Untitled();
        //    SqlConnection cn = new SqlConnection(CDatabase.ConnectionStr);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand("USP_GET_ID", cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@P_ID", textBox1.Text);
        //    cmd.Parameters.AddWithValue("@P_ID1", textBox2.Text);
        //    cmd.Parameters.AddWithValue("@P_ID2", textBox3.Text);
        //    cmd.Parameters.AddWithValue("@P_ID3", textBox4.Text);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    un.SetDataSource(dt);
        //    crystalReportViewer1.ReportSource = un;
        //    crystalReportViewer1.Refresh();
        //    un.PrintOptions.PrinterName = "HP LaserJet 1020 (Copy 2)";
        //    un.PrintOptions.PrinterName = "HP LaserJet 1020";
        //    un.PrintOptions.PrinterName = "Microsoft Print to PDF";
        //    un.PrintToPrinter(1, false, 1, 6);
        //    cn.Close();
        //}
    }
}

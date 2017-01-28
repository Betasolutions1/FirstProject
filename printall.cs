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
    public partial class printall : Form
    {
        public printall()
        {
            InitializeComponent();
        }

        private void printall_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(CDatabase.ConnectionStr);
        public void FillData()
        {
            listView2.Items.Clear();
            con.Close();
            con.Open();

            SqlCommand cmd = new SqlCommand("select DP_ID from TBL_DUTY_PASS ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                //listView2.CheckBoxes = true;
                // Select the item and subitems when selection is made.
                //listView2.FullRowSelect = true;
                // Display grid lines.
                //listView2.GridLines = true;
                ListViewItem listItem = new ListViewItem();
                listItem.Text = dr[0].ToString();
               // listItem.SubItems.Add(dr[0].ToString());
                listView2.Items.Add(listItem);

            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (listView2.SelectedItems.Count > 0)
            //{
            //    if (listView2.SelectedItems[0].Text != null)
            //    {

            //        label1.Text = listView2.SelectedItems[0].Text.ToString();
            //    }
            //    else if (label1.Text == "")
            //    {
            //        MessageBox.Show("Please select one ID");
            //    }
            //}
            //if (listView2.CheckedItems.Count > 0)
            //{
            //    label1.Text = listView2.CheckedItems.ToString();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listView2.SelectedItems[0].Text != null)
                {

                    label3.Text = listView2.SelectedItems[0].Text.ToString();
                }
                else if (label3.Text == "")
                {
                    MessageBox.Show("Please select one ID");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listView2.SelectedItems[0].Text != null)
                {

                    label1.Text = listView2.SelectedItems[0].Text.ToString();
                }
                else if (label1.Text == "")
                {
                    MessageBox.Show("Please select one ID");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listView2.SelectedItems[0].Text != null)
                {

                    label2.Text = listView2.SelectedItems[0].Text.ToString();
                }
                else if (label2.Text == "")
                {
                    MessageBox.Show("Please select one ID");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listView2.SelectedItems[0].Text != null)
                {

                    label4.Text = listView2.SelectedItems[0].Text.ToString();
                }
                else if (label4.Text == "")
                {
                    MessageBox.Show("Please select one ID");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prnt_vw f = new prnt_vw();
            //string s = txtid.Text;
            //f.txtprint = s;

           // f.PrintReport(label1.Text, label2.Text, label3.Text, label4.Text);
           // f.Load(label1.Text, label2.Text, label3.Text, label4.Text);
            string a = label1.Text;
            string b = label2.Text;
            string c = label3.Text;
            string d = label4.Text;
            f.txtprint = a;
            f.txtprint1 = b;
            f.txtprint2 = c;
            f.txtprint3 = d;
            f.Owner = this;
            f.Show();
            //f.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

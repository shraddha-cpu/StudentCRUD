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
using System.Configuration;
using System.Xml.Linq;


namespace StudentCRUD
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(constr);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Student values(@Rollno,@Name,@Sub1_Mark,@Sub2_Mark,@Sub3_Mark,@Percentage)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Sub1_Mark", Convert.ToDecimal(txtSub1Mark.Text));
                cmd.Parameters.AddWithValue("@Sub2_Mark", Convert.ToDecimal(txtSub2Mark.Text));
                cmd.Parameters.AddWithValue("@Sub3_Mark", Convert.ToDecimal(txtSub3Mark.Text));
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToDecimal(txtPercentage.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Student set name=@name,Sub1_Mark=@Sub1_Mark,Sub2_Mark=@Sub2_Mark,Sub3_Mark=@Sub3_Mark,Percentage=@Percentage where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtStudentRollno.Text));
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Sub1_Mark", Convert.ToDecimal(txtSub1Mark.Text));
                cmd.Parameters.AddWithValue("@Sub2_Mark", Convert.ToDecimal(txtSub2Mark.Text));
                cmd.Parameters.AddWithValue("@Sub2_Mark", Convert.ToDecimal(txtSub3Mark.Text));
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToInt32(txtPercentage.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Student where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtStudentRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Student where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtStudentRollno.Text));
                con.Open();
                dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtStudentName.Text = dr["name"].ToString();
                        txtSub1Mark.Text = dr["Sub1_Mark"].ToString();
                        txtSub2Mark.Text = dr["Sub2_Mark"].ToString();
                        txtSub3Mark.Text = dr["Sub2_Mark"].ToString();
                        txtPercentage.Text = dr["Percentage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}

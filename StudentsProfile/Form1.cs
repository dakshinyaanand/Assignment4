using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProfile
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=StudentProfile;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from STUDPROF";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);

                    }
                    lbselect.Items.Add("*******");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            string roll = txtrollno.Text;
            string name = txtname.Text;
            string address = txtaddress.Text;
            string phone = txtphone.Text;
            string gender = "";

            if (rbfemale.Checked)
            {
                gender = "female";

            }
            if (rbmale.Checked)
            {
                gender = "male";
            }
            string department = cbdepartment.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            try
            {

                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into STUDPROF values(@roll,@name,@date,@gen,@dept,@course,@sem,@add,@phn)";//parameters to sql query
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpdateof.Value.Date;
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dept", department);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@add",address);
                cmd.Parameters.AddWithValue("@phn", phone);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data inserted " + res);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string add = txtaddress.Text;
            string phn = txtphone.Text;
            string department = cbdepartment.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            try
            {
                string id = txtrollno.Text;
                con = new SqlConnection(constr);
                con.Open();
                string query = "update studprof set department=@dept,course=@course,semester=@sem,address=@add,phone=@phn where rollno=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dept", department);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@add", add);
                cmd.Parameters.AddWithValue("@phn", phn);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("updated" + res);
                else
                {
                    MessageBox.Show("Roll no not found");
                }

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtrollno.Text;
                MessageBox.Show("ID is :" + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from studprof where Rollno=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Deleted" + res);
                else
                {
                    MessageBox.Show("Roll no not found");
                }
               
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
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

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtrollno.Text;
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from STUDPROF where rollno=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);


                    }
                    txtname.Text = r["name"].ToString();
                    dtpdateof.Text = ((DateTime)r["Dateof"]).ToString();
                    if (r["gender"].ToString() == "male")
                    {
                        rbmale.Checked = true;
                    }
                    if (r["gender"].ToString() == "female")
                    {
                        rbfemale.Checked = true;
                    }
                    cbdepartment.SelectedItem = r["department"].ToString();
                    cbcourse.SelectedItem = r["course"].ToString();
                    cbsemester.SelectedItem = r["semester"].ToString();
                    txtaddress.Text = r["address"].ToString();
                    txtphone.Text = r["phone"].ToString();
                    //lbselect.Items.Add("*******");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
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

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

namespace chosesubject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitDataGridView();
        }

        string studentid;
        string sqlconnectioncommand = "Data Source=182.92.76.25;Initial Catalog=timetable;Uid=SA;Pwd=ZHJzhj2121";

        int ischosenum = 0;
        int ischosecredit = 0;
        private void button_SelectName_Click(object sender, EventArgs e)
        {
            if (textBox_studentid.Text.Length != 0)
            {
                studentid = textBox_studentid.Text;
                string queryString = "SELECT student_name FROM dbo.student where student_id = " + studentid;
                using (SqlConnection connection = new SqlConnection(sqlconnectioncommand))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label_studentname_show.Text = (string)reader[0];
                            updatedatagrip();
                        }
                        else
                        {
                            label_studentname_show.Text = "查无此人";
                            MessageBox.Show("查无此人");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("学号不能为空");
            }
        }

        private void updatedatagrip()
        {
            ischosenum = 0;
            ischosecredit = 0;

            //查询该用户已经选的课
            List<Int32> subject_has_chose = new List<Int32>();
            string queryString = "SELECT C_ID FROM dbo.subject_chose_" + studentid;
            using (SqlConnection connection = new SqlConnection(sqlconnectioncommand))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subject_has_chose.Add((Int32)reader[0]);
                    }
                }
            }

            DataGridView_down.Rows.Clear();
            DataGridView_top.Rows.Clear();

            //所有课表
            queryString = "SELECT * FROM dbo.curriculum";
            using (SqlConnection connection = new SqlConnection(sqlconnectioncommand))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int subjectid = (Int32)reader[0];
                        Object[] row = new object[6];
                        row[0] = subjectid;
                        row[1] = (string)reader[1];
                        row[2] = (string)reader[2];
                        int credit = (Int32)reader[3];
                        row[3] = credit;
                        row[4] = (string)reader[4];
                        if (subject_has_chose.Exists(x => x == subjectid))
                        {//已经选的课
                            DataGridView_top.Rows.Add(row);
                            ischosenum++;
                            ischosecredit += credit;
                        }
                        else
                        {
                            DataGridView_down.Rows.Add(row);
                        }
                    }
                }
            }
            label_mid.Text = "已选课程数量：" + ischosenum + " ，已选学分：" + ischosecredit;
        }

        private void InitDataGridView()
        {
            //上，已选课程
            DataGridView_top.ColumnCount = 5;
            DataGridView_top.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DataGridView_top.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView_top.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView_top.Font, FontStyle.Bold);
            DataGridView_top.Columns[0].Name = "课程ID";
            DataGridView_top.Columns[1].Name = "课程名称";
            DataGridView_top.Columns[2].Name = "授课老师";
            DataGridView_top.Columns[3].Name = "学分";
            DataGridView_top.Columns[4].Name = "时间";
            DataGridView_top.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_top.MultiSelect = false;
            //下，待选课程
            DataGridView_down.ColumnCount = 5;
            DataGridView_down.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DataGridView_down.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView_down.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView_top.Font, FontStyle.Bold);
            DataGridView_down.Columns[0].Name = "课程ID";
            DataGridView_down.Columns[1].Name = "课程名称";
            DataGridView_down.Columns[2].Name = "授课老师";
            DataGridView_down.Columns[3].Name = "学分";
            DataGridView_down.Columns[4].Name = "时间";
            DataGridView_down.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_down.MultiSelect = true;

            DataGridView_top.Columns[0].DisplayIndex = 0;
            DataGridView_top.Columns[1].DisplayIndex = 1;
            DataGridView_top.Columns[2].DisplayIndex = 2;
            DataGridView_top.Columns[3].DisplayIndex = 3;
            DataGridView_top.Columns[4].DisplayIndex = 4;

            DataGridView_down.Columns[0].DisplayIndex = 0;
            DataGridView_down.Columns[1].DisplayIndex = 1;
            DataGridView_down.Columns[2].DisplayIndex = 2;
            DataGridView_down.Columns[3].DisplayIndex = 3;
            DataGridView_down.Columns[4].DisplayIndex = 4;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (DataGridView_down.SelectedRows.Count + ischosenum >= 3 && DataGridView_down.SelectedRows.Count + ischosenum <= 5)
            {
                int chosecredit = 0;
                Console.WriteLine(DataGridView_down.SelectedRows);
                foreach (DataGridViewRow selectrow in DataGridView_down.SelectedRows)
                {
                    chosecredit += (int)selectrow.Cells[3].Value;
                }

                if (chosecredit +ischosecredit >= 8 && chosecredit + ischosecredit <= 12)
                {
                    using (SqlConnection connection = new SqlConnection(sqlconnectioncommand))
                    {
                        connection.Open();
                        foreach (DataGridViewRow selectrow in DataGridView_down.SelectedRows)
                        {
                            if (selectrow.Cells[0].Value != null)
                            {
                                int choseid = (int)selectrow.Cells[0].Value;
                                string queryString = "INSERT dbo.subject_chose_" + studentid + " values(" + choseid + ")";
                                SqlCommand command = new SqlCommand(queryString, connection);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("请不要选择空行");
                            }
                        }
                    }
                    updatedatagrip();
                }
                else
                {
                    MessageBox.Show("您选择了"+ chosecredit + "个学分，请按规定一共选择8-12学分");
                }
            }
            else
            {
                MessageBox.Show("您选择了" + DataGridView_down.SelectedRows.Count + "门课，按规定一共选择3-5门课");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (DataGridView_top.SelectedRows.Count == 1)
            {
                using (SqlConnection connection = new SqlConnection(sqlconnectioncommand))
                {
                    connection.Open();
                    foreach (DataGridViewRow selectrow in DataGridView_top.SelectedRows)
                    {
                        if(selectrow.Cells[0].Value != null)
                        {
                            int choseid = (int)selectrow.Cells[0].Value;
                            string queryString = "DELETE dbo.subject_chose_" + studentid + " where C_ID = " + choseid;
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("请不要选择空值");
                        }
                    }
                }
                updatedatagrip();
            }
            else
            {
                MessageBox.Show("您未选择课程");
            }
        }
    }
}
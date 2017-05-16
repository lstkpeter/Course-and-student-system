using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// searchStudent.xaml 的交互逻辑
    /// </summary>
    public partial class searchStudent : Window
    {
        public searchStudent()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)//基本信息
        {
            textBlockShow.Text = "";
            if (textBox.Text.Length == 0)
            {
                textBlockShow.Text = "学号不能为空！";
                return;
            }
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select * from student where sid = \'" + textBox.Text + "\'";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                int total = ds.Tables[0].Rows.Count;
                if (total != 0)
                {
                    DataRow r = ds.Tables[0].Rows[0];
                    textBlockShow.Text += "学号：" + r["sid"];
                    textBlockShow.Text += "\n姓名：" + r["name"];
                    textBlockShow.Text += "\n性别：" + r["sex"];
                    textBlockShow.Text += "\n入学年龄：" + r["inage"];
                    textBlockShow.Text += "\n入学年份：" + r["inyear"];
                    textBlockShow.Text += "\n班级：" + r["cls"];
                }
                else
                    textBlockShow.Text = "查询不到此学生！";
            }
            catch (MySqlException ex)
            {
                textBlockShow.Text = ex.Message;
            }
            catch (Exception)
            {
                textBlockShow.Text = "Wrong";
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)//选课情况
        {
            textBlockShow.Text = "";
            if (textBox.Text.Length == 0)
            {
                textBlockShow.Text = "学号不能为空！";
                return;
            }
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select cid, score from info where sid = \'" + textBox.Text + "\' order by score";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                int total = ds.Tables[0].Rows.Count;
                textBlockShow.Text += "已选课程数：" + total.ToString() + "\n";
                if (total > 0)
                {
                    textBlockShow.Text += String.Format("\n{0,-12}{1,-10}{2,7}{3,11}", "课程编号", "课程名称" ,"学分", "得分");
                }
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string cid = r["cid"].ToString();
                    string score = r["score"].ToString();
                    if (score.Length == 0) score = "NA";
                    cmd.CommandText = "select cname,credit from course where cid = \'" + cid + "\'";
                    adap = new MySqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    adap.Fill(ds1);
                    DataRow r1 = ds1.Tables[0].Rows[0];
                    string cname = r1["cname"].ToString();
                    string credit = r1["credit"].ToString();
                    textBlockShow.Text += String.Format("\n{0,-15}{1,-5}{2,12}{3,16}", cid, cname, credit ,score);

                }
            }
            catch (MySqlException ex)
            {
                textBlockShow.Text = ex.Message;
            }
            catch (Exception)
            {
                textBlockShow.Text = "Wrong";
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)//加权平均
        {
            textBlockShow.Text = "";
            if (textBox.Text.Length == 0)
            {
                textBlockShow.Text = "学号不能为空！";
                return;
            }
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select cid, score from info where sid = \'" + textBox.Text + "\'";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                int total = ds.Tables[0].Rows.Count;
                if (total != 0)
                {
                    total = 0;
                    double sum = 0;
                    double div = 0;
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        string cid = r["cid"].ToString();
                        try
                        {
                            double score = double.Parse(r["score"].ToString());
                            cmd.CommandText = "select credit from course where cid = \'" + cid + "\'";
                            adap = new MySqlDataAdapter(cmd);
                            DataSet ds1 = new DataSet();
                            adap.Fill(ds1);
                            DataRow r1 = ds1.Tables[0].Rows[0];
                            double credit = double.Parse(r1["credit"].ToString());
                            sum += score * credit;
                            div += credit;
                            total++;
                        }
                        catch
                        {
                            //什么也不做,跳过该次循环
                        }

                    }
                    double result = sum / div;
                    string str1 = result.ToString("f2");//保留两位小数
                    textBlockShow.Text += "加权平均分：";
                    textBlockShow.Text += str1;
                }
                else
                {
                    textBlockShow.Text = "无记录";
                }
            }
            catch (MySqlException ex)
            {
                textBlockShow.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

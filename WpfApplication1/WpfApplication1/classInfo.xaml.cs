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
    /// classInfo.xaml 的交互逻辑
    /// </summary>
    public partial class classInfo : Window
    {
        public classInfo()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                xt.Text = " 学号不能为空！";
                return;
            }
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select password from student where sid = \'" + textBox.Text + "\'";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                DataRow r = ds.Tables[0].Rows[0];
                string password = r["password"].ToString();
                if (password != passwordBox.Password)
                {
                    MessageBox.Show("密码错误");
                    return;
                }
            }
            catch (Exception)
            {
                xt.Text = "查询不到此学生！";
            }

            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select cid from info where sid = \'" + textBox.Text + "\'";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                int total = ds.Tables[0].Rows.Count;
                
                if (total != 0)
                {
                    xt.Text += "已选课程数：" + total.ToString() + "\n";
                    xt.Text += String.Format("\n{0,-12}{1,-10}{2,7}", "课程编号", "课程名称", "学分");
                    DataRow r = ds.Tables[0].Rows[0];
                    foreach (DataRow k in ds.Tables[0].Rows)
                    {
                        string cid = k["cid"].ToString();
                        cmd.CommandText = "select cname,credit from course where cid = \'" + cid + "\'";
                        adap = new MySqlDataAdapter(cmd);
                        DataSet ds1 = new DataSet();
                        adap.Fill(ds1);
                        DataRow r1 = ds1.Tables[0].Rows[0];
                        string cname = r1["cname"].ToString();
                        string credit = r1["credit"].ToString();
                        xt.Text += String.Format("\n{0,-15}{1,-5}{2,12}", cid, cname, credit);
                    }
                }
                else
                    xt.Text = " 查询不到此学生！";
            }
            catch (Exception)
            {
                xt.Text = " Wrong";
            }
        }
    }
}

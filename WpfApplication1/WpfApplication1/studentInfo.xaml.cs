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
    /// studentInfo.xaml 的交互逻辑
    /// </summary>
    public partial class studentInfo : Window
    {
        public studentInfo()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                textBox1.Text =" 学号不能为空！";
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
                    textBox1.Text = "密码错误";
                    return;
                }
            }
            catch (Exception)
            {
                textBox1.Text = "查询不到此学生！";
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
                    try
                    {
                        textBox1.Text = "学号：" + r["sid"] +
                                        "\n姓名：" + r["name"] +
                                        "\n性别：" + r["sex"] +
                                        "\n入学年龄：" + r["inage"] +
                                        "\n入学年份：" + r["inyear"] +
                                        "\n班级：" + r["cls"];
                    }
                    catch
                    {
                        textBox1.Text = "Wrong";
                    }
                }
                else
                    textBox1.Text = " 查询不到此学生！";
            }
            catch (Exception)
            {
                textBox1.Text = " Wrong";
            }
        }
    }
}

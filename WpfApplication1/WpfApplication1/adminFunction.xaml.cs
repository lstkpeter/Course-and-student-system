using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    /// adminFunction.xaml 的交互逻辑
    /// </summary>
    public partial class adminFunction : Window
    {
        public adminFunction()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)//学生信息管理
        {
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select * from student";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);
                MainWindow.slist.Clear();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Student tmp = new Student();
                    tmp.sid = r["sid"].ToString();
                    tmp.name = r["name"].ToString();
                    tmp.sex = r["sex"].ToString();
                    tmp.inage = r["inage"].ToString();
                    tmp.inyear = r["inyear"].ToString();
                    tmp.cls = r["cls"].ToString();
                    MainWindow.slist.Add(tmp);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            adminWindow adWindow = new adminWindow();
            adWindow.f = 1;
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "学号", Binding = new Binding("sid") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "姓名", Binding = new Binding("name") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "性别", Binding = new Binding("sex") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "入学年龄", Binding = new Binding("inage") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "入学年份", Binding = new Binding("inyear") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "班级", Binding = new Binding("cls") });
            adWindow.dataGrid.ItemsSource = MainWindow.slist;
            adWindow.textBlock1.Text = "姓名搜索";
            adWindow.textBox.Focus();
            adWindow.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)//课程信息管理
        {
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select * from course";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);
                MainWindow.clist.Clear();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Course tmp = new Course();
                    tmp.cid = r["cid"].ToString();
                    tmp.cname = r["cname"].ToString();
                    tmp.teacher = r["teacher"].ToString();
                    tmp.credit = r["credit"].ToString();
                    tmp.minage = r["minage"].ToString();
                    tmp.cancelyear = r["cancelyear"].ToString();
                    MainWindow.clist.Add(tmp);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            adminWindow adWindow = new adminWindow();
            adWindow.f = 2;
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "课程编号", Binding = new Binding("cid") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "课程名称", Binding = new Binding("cname") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "教师姓名", Binding = new Binding("teacher") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "学分", Binding = new Binding("credit") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "适合年级", Binding = new Binding("minage") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "取消年份", Binding = new Binding("cancelyear") });
            adWindow.dataGrid.ItemsSource = MainWindow.clist;
            adWindow.textBlock1.Text = "课程名搜索";
            adWindow.textBox.Focus();
            adWindow.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlCommand cmd = MainWindow.conn.CreateCommand();
                cmd.CommandText = "select * from info";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);
                MainWindow.ilist.Clear();
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Info tmp = new Info();
                    tmp.sid = r["sid"].ToString();
                    tmp.cid = r["cid"].ToString();
                    tmp.year = r["year"].ToString();
                    tmp.score = r["score"].ToString();
                    MainWindow.ilist.Add(tmp);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            adminWindow adWindow = new adminWindow();
            adWindow.f = 3;
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "学号", Binding = new Binding("sid") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "课程编号", Binding = new Binding("cid") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "选课年份", Binding = new Binding("year") });
            adWindow.dataGrid.Columns.Add(new DataGridTextColumn() { Header = "成绩", Binding = new Binding("score") });
            adWindow.dataGrid.ItemsSource = MainWindow.ilist;
            adWindow.textBlock1.Text = "学号搜索";
            adWindow.textBox.Focus();
            adWindow.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)//数据库控制台
        {
            MessageBox.Show("即将进入数据库控制台，若非管理员请勿使用");
            Process p = new Process();
            p.StartInfo.FileName = @"C:\xampp\mysql\bin\mysql.exe";
            try
            { p.Start(); }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

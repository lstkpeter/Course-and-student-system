using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private String myConnectionString = "Server=127.0.0.1;Database=school;Uid=root;";
        public static MySqlConnection conn;
        public static List<Student> slist = new List<Student>();
        public static List<Course> clist = new List<Course>();
        public static List<Info> ilist = new List<Info>();
        public MainWindow()
        {
            InitializeComponent();

            Flag.modeFlag = 1;
            conn = new MySqlConnection(myConnectionString);
            conn.Open();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex != 0)
            {
                passwordBox.Focus();
            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            conn.Close();
            System.Environment.Exit(0);
        }
        private void button_Click(object sender, RoutedEventArgs e)//登录按钮
        {
            if (comboBox.SelectedIndex == 0)
            {
                Flag.modeFlag = 1;
                newStudent();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                if (passwordBox.Password == "1")
                {
                    Flag.modeFlag = 2;
                    newTeacher();
                }
                else
                    MessageBox.Show("口令错误");
            }
            else if (comboBox.SelectedIndex == 2)
            {
                if (passwordBox.Password == "2")
                {
                    Flag.modeFlag = 3;
                    newAdmin();
                }
                else
                    MessageBox.Show("口令错误");
            }
            passwordBox.Password = "";
        }

        public void newStudent()
        {
            studentsFunction sF = new studentsFunction();
            sF.ShowDialog();
        }
        public void newTeacher()
        {
            teacherFunction tF = new teacherFunction();
            tF.ShowDialog();
        }
        public void newAdmin()
        {
            adminFunction aF = new adminFunction();
            aF.ShowDialog();
        }
    }
    public class Student
    {
        public string sid { set; get; }
        public string name { set; get; }
        public string sex { set; get; }
        public string inage { set; get; }
        public string inyear { set; get; }
        public string cls { set; get; }
        public bool isChecked { set; get; }
    }

    public class Course
    {
        public string cid { set; get; }
        public string cname { set; get; }
        public string teacher { set; get; }
        public string credit { set; get; }
        public string minage { set; get; }
        public string cancelyear { set; get; }
        public bool isChecked { set; get; }
    }

    public class Info
    {
        public string sid { set; get; }
        public string cid { set; get; }
        public string year { set; get; }
        public string score { set; get; }
        public bool isChecked { set; get; }
    }

    public class Flag
    {
        public static int modeFlag;//1为学生，2为教师，3为管理员
        public static int flag2;//搜索状态，1为全部列表，2为搜索列表
    }

}

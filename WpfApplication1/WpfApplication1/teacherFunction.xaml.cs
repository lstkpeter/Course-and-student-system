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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// teacherFunction.xaml 的交互逻辑
    /// </summary>
    public partial class teacherFunction : Window
    {
        public teacherFunction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)//成绩查询
        {
            scoreWindow sw = new scoreWindow();
            sw.textBox.Focus();
            sw.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)//学生信息查询
        {
            searchStudent sS = new searchStudent();
            sS.textBox.Focus();
            sS.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)//课程信息查询
        {
            searchCourse sC = new searchCourse();
            sC.textBox.Focus();
            sC.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)//班级成绩
        {
            classScore cS = new classScore();
            cS.textBox.Focus();
            cS.ShowDialog();
        }
    }
}

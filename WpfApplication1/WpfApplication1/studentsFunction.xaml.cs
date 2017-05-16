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
    /// studentsFunction.xaml 的交互逻辑
    /// </summary>
    public partial class studentsFunction : Window
    {
        public studentsFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)//成绩查询
        {
            scoreWindow sw = new scoreWindow();
            sw.textBox.Focus();
            sw.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)//学生信息
        {
            studentInfo sI = new studentInfo();
            sI.textBox.Focus();
            sI.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)//选课信息查询
        {
            classInfo cI = new classInfo();
            cI.textBox.Focus();
            cI.ShowDialog();
        }
    }
}

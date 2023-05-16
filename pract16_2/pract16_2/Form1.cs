using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pract16_2
{
    public partial class Form1 : Form
    {
        private bool CheckPath()
        {
            string message = string.Empty;
            if (pathTextBox.Text.Length == 0)
                message = "Вы не указали путь к фалу";
            else if (!File.Exists(pathTextBox.Text))
                message = "Такого файла не существует";
            if (message.Length == 0)
                return true;
            MessageBox.Show(message);
            return false;
                
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showAndSortButton_Click(object sender, EventArgs e)
        {
            if (CheckPath())
            {
                studentsList.Clear();
                StreamReader sr = File.OpenText(pathTextBox.Text);
                Queue<string[]> students = new Queue<string[]>();
                Queue<string> students_with_bad_marks = new Queue<string>();
                while (!sr.EndOfStream)
                {
                    string[] person = sr.ReadLine().Split(' ');
                    students.Enqueue(person);
                }
                sr.Close();
                while(students.Count!=0)
                {
                    string marks = students.Peek()[3]+ students.Peek()[4]+ students.Peek()[5];
                    string student = string.Join(" ", students.Dequeue());
                    if (marks.Contains("3") || marks.Contains("2"))
                        students_with_bad_marks.Enqueue(student);
                    else
                        studentsList.Items.Add(student);
                }
               while(students_with_bad_marks.Count!=0)
                {
                    studentsList.Items.Add(students_with_bad_marks.Dequeue());
                }
            }
        }
    }
}

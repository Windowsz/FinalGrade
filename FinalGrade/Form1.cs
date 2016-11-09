using System;
using System.IO;
using System.Windows.Forms;

namespace FinalGrade
{
    public partial class Form1 : Form
    {
        private string grade;
        private int point = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Trim() != "")
                {
                    point = Convert.ToInt32(textBox2.Text);
                }
                if (point >= 80 || point < 100)
                {
                    grade = "A";
                }
                else if (point >= 75)
                {
                    grade = "B+";
                }
                else if (point >= 70)
                {
                    grade = "B";
                }
                else if (point >= 65)
                {
                    grade = "C+";
                }
                else if (point >= 60)
                {
                    grade = "C";
                }
                else if (point >= 55)
                {
                    grade = "D+";
                }
                else if (point >= 50)
                {
                    grade = "D";
                }
                else if (point <= 49)
                {
                    grade = "F";
                }
                else
                {
                    grade = "X";
                }
                textBox3.Text = grade;
            }
            catch {
                MessageBox.Show("กรุณาใส่ค่าที่ถูกต้อง");
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream wout = new FileStream("grade.xls", FileMode.Append);
            StreamWriter w = new StreamWriter(wout);
            w.WriteLine(textBox1.Text + "\t" + point + "\t" + grade);
            w.Close();
            wout.Close();
            MessageBox.Show("Export to Excel สำเร็จ");
        }
    }
}

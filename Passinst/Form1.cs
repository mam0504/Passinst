using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Passinst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private bool State;
        private string ver;
        private void Form1_Load(object sender, EventArgs e)
        {
            ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += ver;
            string desc = "Спецсимволы могут быть включены, а могут быть выключены,\n так как некоторыми серверами не поддерживаются...";
            string num_symb = "Количество символов может быть изменено";
            string but_desc = "Кнопка генерации";
            string clr_desc = "Очищает окно";
            string sv_file = "Кнопка сохранения в файл...";
            numericUpDown1.Value = 8;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1, but_desc);
            toolTip1.SetToolTip(this.checkBox1, desc);
            toolTip1.SetToolTip(this.numericUpDown1, num_symb);
            toolTip1.SetToolTip(this.button2, clr_desc);
            toolTip1.SetToolTip(this.button3, sv_file);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteString str = new WriteString();
            int num = Convert.ToInt16(numericUpDown1.Value);
            string Str;
            if(num != 0)
            {
                Str = str.ReadString(num, State);
                textBox1.Text += Str + Environment.NewLine;
            } else
            {
                MessageBox.Show("Количество символов должно быть больше 0");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
                State = checkBox1.Checked;
            } else
            {
                checkBox1.Checked = false;
                State = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Текстовое поле не должно быть пустым !");
            } else
            {
                saveFileDialog1.Filter = "Text files (*.txt) | *.txt";
                saveFileDialog1.FileName = "passwords";
                DialogResult result = saveFileDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true))
                    {
                        sw.Write(textBox1.Text);
                    }

                }
            }
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            string allString = "Генератор паролей версия 1.0.0.1\n";
            string aboutString = "Написано Андреем Межлумовым\n";
            string addrString = "По своим откликам о работе с данной программой просьба писать:\n amezhlumov@mail.ru";
            MessageBox.Show(allString + aboutString + addrString);
        }
    }
}

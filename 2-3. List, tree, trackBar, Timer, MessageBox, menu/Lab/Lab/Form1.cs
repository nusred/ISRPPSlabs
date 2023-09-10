using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();


            timer.Start();
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(this.timer_Tick);


            this.trackBar1.Scroll += trackBar1_Scroll;
            // The Maximum property sets the value of the track bar when
            // the slider is all the way to the right.
            trackBar1.Maximum = 30;

            // The TickFrequency property establishes how many positions
            // are between each tick-mark.
            trackBar1.TickFrequency = 5;

            // The LargeChange property sets how many positions to move
            // if the bar is clicked on either side of the slider.
            trackBar1.LargeChange = 3;

            // The SmallChange property sets how many positions to move
            // if the keyboard arrows are used to move the slider.
            trackBar1.SmallChange = 2;

            ToolStripMenuItem file = new ToolStripMenuItem();
            ToolStripMenuItem open = new ToolStripMenuItem();
            ToolStripMenuItem save = new ToolStripMenuItem();

            file.DropDownItems.Add(open);
            file.DropDownItems.Add(save);


            menuStrip1.Items.Add(file);

            ToolStripButton clearBtn = new ToolStripButton();
            clearBtn.Text = "Clear";
            // устанавливаем обработчик нажатия
            clearBtn.Click += btn_Click;
            toolStrip1.Items.Add(clearBtn);

            void btn_Click(object sender, EventArgs e)
            {
                textBox3.Text = "";
            }

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Copyright";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            // добавляем возможность выбора цвета шрифта
            fontDialog1.ShowColor = true;

            button2.Click += button2_Click;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
                if (listView1.Items[i].Selected)
                    listView1.Items[i].Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode(textBox2.Text);
            treeView1.SelectedNode.Nodes.Add(newNode);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Selected Первый";
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Отмечено все!");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Selected Второй";
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Отмечено все!");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Selected Третий";
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Отмечено все!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!working)
            {
                timer.Enabled = true;
                working = true;
            }
            else
            {
                timer.Enabled = false;
                working = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            label1.Text = "0";
            count = 0;
            working = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 100;
            trackBar1.Maximum = 150;
            ChangeImageSize(trackBar1.Value);
            trackBar1.Text = String.Format("Changed image size to {0}", trackBar1.Value);
        }

        private void ChangeImageSize(int x)
        {
            this.pictureBox1.Height = x;
            this.pictureBox1.Width = x * 2;
        }

        int count = 0;
        bool working = true;

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
            count++;
        }

        private void ListBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ListBox1_DragEnter(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox3.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox3.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton2.Text);
                label2.Text = "Selected " + radioButton2.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton1.Text);
                label2.Text = "Selected " + radioButton1.Text;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
            if (numericUpDown1.Value % 1 == 0)
            {
                label2.Text = "Changed";
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            button1.Font = fontDialog1.Font;
            button2.Font = fontDialog1.Font;
            button3.Font = fontDialog1.Font;
            button4.Font = fontDialog1.Font;
            button5.Font = fontDialog1.Font;
            button6.Font = fontDialog1.Font;
            button7.Font = fontDialog1.Font;
            button8.Font = fontDialog1.Font;
            button9.Font = fontDialog1.Font;
            button10.Font = fontDialog1.Font;
            // установка цвета шрифта
            button1.ForeColor = fontDialog1.Color;
            button1.ForeColor = fontDialog1.Color;
            button2.ForeColor = fontDialog1.Color;
            button3.ForeColor = fontDialog1.Color;
            button4.ForeColor = fontDialog1.Color;
            button5.ForeColor = fontDialog1.Color;
            button6.ForeColor = fontDialog1.Color;
            button7.ForeColor = fontDialog1.Color;
            button8.ForeColor = fontDialog1.Color;
            button9.ForeColor = fontDialog1.Color;
            button10.ForeColor = fontDialog1.Color;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            button1.BackColor = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
            button2.BackColor = colorDialog1.Color;
            button3.BackColor = colorDialog1.Color;
            button4.BackColor = colorDialog1.Color;
            button5.BackColor = colorDialog1.Color;
            button6.BackColor = colorDialog1.Color;
            button7.BackColor = colorDialog1.Color;
            button8.BackColor = colorDialog1.Color;
            button9.BackColor = colorDialog1.Color;
            button10.BackColor = colorDialog1.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Takes the selected text from a text box and puts it on the clipboard.
            if (textBox1.SelectedText != "")
                Clipboard.SetDataObject(textBox3.SelectedText);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Declares an IDataObject to hold the data returned from the clipboard.
            // Retrieves the data from the clipboard.
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
                textBox3.Text = (String)iData.GetData(DataFormats.Text);
            }
        }
    }
}

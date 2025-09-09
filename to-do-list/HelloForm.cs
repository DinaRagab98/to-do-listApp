using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tasktxt.Text) && comboBox1.SelectedItem != null)
            {
                string task = Tasktxt.Text;
                string priority = comboBox1.SelectedItem.ToString();
                if (priority == "High")
                {
                    checkedListBox1.Items.Insert(0, "High: " + task);
                }
                else if (priority == "Meduim")
                {
                    int lastHigh = -1;
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (checkedListBox1.Items[i].ToString().StartsWith("High: "))
                        {
                            lastHigh = i;
                        }
                    }
                    if (lastHigh == -1)
                    {
                        checkedListBox1.Items.Insert(0, "Meduim: " + task);
                    }
                    else
                        checkedListBox1.Items.Insert(lastHigh + 1, "Meduim: " + task);
                }
                else
                {
                    checkedListBox1.Items.Add("Low: " + task);
                }
                Tasktxt.Clear();
            }
            else
            {
                MessageBox.Show("please enter task first and priority");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Items.Clear();

            }
            else
            {
                MessageBox.Show("No tasks to delete");
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Gongratulations!!!!!🎉🎉");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

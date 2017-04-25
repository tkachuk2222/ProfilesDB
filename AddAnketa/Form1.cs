using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddAnketa
{
    public partial class Form1 : Form
    {

        public List<Person> per;
        public ListBox ListBox1 { get { return this.listBox1; }  set { this.listBox1 = value; } }

        public Form1()
        {
            per = new List<Person>();
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            AddForm f = new AddForm();
            f.Owner = this;
            f.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm();
            f.Owner = this;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in this.ListBox1.SelectedItems)
                {
                    for (int i = 0; i < per.Count; i++)
                    {
                        if (per[i].ToString() == item.ToString())
                        {
                            per.RemoveAt(i);
                        }

                    }
                }
                this.listBox1.Items.Clear();
                foreach (var item in per)
                    this.listBox1.Items.Add(item.ToString());
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach(var el in per)
                this.listBox1.Items.Add(el);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportForm exp = new ExportForm();
            exp.ShowDialog();
        }
    }
}

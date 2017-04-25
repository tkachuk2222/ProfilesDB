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
    public partial class AddForm : Form
    {
        Form1 MyOwner;
        public AddForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.textBox1.Text != "" & this.textBox2.Text != "" & this.textBox3.Text != "" & this.textBox4.Text != "")
            {
                // creating tmp of person object
                Person tmp = new Person();
                tmp.FirstName = this.textBox1.Text;
                tmp.Lasname = this.textBox2.Text;
                tmp.Email = this.textBox3.Text;
                tmp.Number = this.textBox4.Text;
                MyOwner.per.Add(tmp);
                this.Close();

                // reset listbox at Owner
                MyOwner.ListBox1.Items.Clear();
                foreach (var el in MyOwner.per)
                {
                    string strData = $"{el.FirstName}, {el.Lasname}, {el.Email}, {el.Number}";
                    MyOwner.ListBox1.Items.Add(strData);
                }
                MyOwner.ListBox1.Show();
            }
            else
                MessageBox.Show("Please return input");
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            MyOwner = Owner as Form1;
        }
    }
}

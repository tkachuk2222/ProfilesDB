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
    public partial class SearchForm : Form
    {
        
        Form1 MyOwner;
        public SearchForm()
        {
            
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
                this.textBox1.Enabled = true;
            else
                this.textBox1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
                this.textBox2.Enabled = true;
            else
                this.textBox2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
                this.textBox3.Enabled = true;
            else
                this.textBox3.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked == true)
                this.textBox4.Enabled = true;
            else
                this.textBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            bool name=false, surname=false, email=false, number=false;
            //if(this.checkBox1.Checked == true)
            //{
            //    name = true;
            //}
            Person tmpSearchPerson = new Person();
            //name
            if (this.checkBox1.Checked == true)
                tmpSearchPerson.FirstName = this.textBox1.Text;
            else
                tmpSearchPerson.FirstName = "";
            //lastname
            if (this.checkBox2.Checked == true)
                tmpSearchPerson.Lasname = this.textBox2.Text;
            else
                tmpSearchPerson.Lasname = "";
            //number
            if (this.checkBox3.Checked == true)
                tmpSearchPerson.Number = this.textBox3.Text;
            else
                tmpSearchPerson.Number = "";
            //email
            if (this.checkBox4.Checked == true)
                tmpSearchPerson.Email = this.textBox4.Text;
            else
                tmpSearchPerson.Email = "";


            //
            // show only selected
            if (this.radioButton2.Checked == true) { 
                MyOwner.ListBox1.Items.Clear();
                //
                // search by bool
                foreach (var person in MyOwner.per)
                {
                    name = false; surname = false; email = false; number = false;
                    if (tmpSearchPerson.Email != "")
                    {
                        if (tmpSearchPerson.Email == person.Email)
                            email = true;
                    }
                    else
                        email = true;
                    if (tmpSearchPerson.FirstName != "")
                    {
                        if (tmpSearchPerson.FirstName == person.FirstName)
                            name = true;
                    }
                    else
                        name = true;
                    if (tmpSearchPerson.Lasname != "")
                    {
                        if (tmpSearchPerson.Lasname == person.Lasname)
                            surname = true;
                    }
                    else
                        surname = true;
                    if (tmpSearchPerson.Number != "")
                    {
                        if (tmpSearchPerson.Number == person.Number)
                            number = true;
                    }
                    else
                        number = true;
                    if (name == true && surname == true && number == true && email == true)
                    {
                        MyOwner.ListBox1.Items.Add(person);
                    }
                }
            }
            else if (this.radioButton1.Checked == true)
            {
                //
                // search by bool
                foreach (var person in MyOwner.per)
                {
                    if (tmpSearchPerson.Email != "")
                    {
                        if (tmpSearchPerson.Email == person.Email)
                            email = true;
                    }
                    else
                        email = true;
                    if (tmpSearchPerson.FirstName != "")
                    {
                        if (tmpSearchPerson.FirstName == person.FirstName)
                            name = true;
                    }
                    else
                        name = true;
                    if (tmpSearchPerson.Lasname != "")
                    {
                        if (tmpSearchPerson.Lasname == person.Lasname)
                            surname = true;
                    }
                    else
                        surname = true;
                    if (tmpSearchPerson.Number != "")
                    {
                        if (tmpSearchPerson.Number == person.Number)
                            number = true;
                    }
                    else
                        number = true;
                    if (name == true && surname == true && number == true && email == true)
                    {
                        for (int i = 0; i < MyOwner.ListBox1.Items.Count; i++)
                        {
                            
                            bool nameToPrint = false, surnameToPrint = false, numberToPrint = false, emailToPrint = false;


                            string[] tmp = MyOwner.ListBox1.Items[i].ToString().Split(',');
                            string[] resultTmp = new string[4];
                            for (int f = 0; f < tmp.Length; f++)
                            {
                                resultTmp[f] = tmp[f].Trim(' ');
                            }

                            if (tmpSearchPerson.FirstName != "")
                            {
                                if (tmpSearchPerson.FirstName == resultTmp[0])
                                    nameToPrint = true;
                            }
                            else
                                nameToPrint = true;


                            if (tmpSearchPerson.Lasname != "")
                            {
                                if (tmpSearchPerson.Lasname == resultTmp[1])
                                    surnameToPrint = true;
                            }
                            else
                                surnameToPrint = true;


                            if (tmpSearchPerson.Email != "")
                            {
                                if (tmpSearchPerson.Email == resultTmp[2])
                                    emailToPrint = true;
                            }
                            else
                               emailToPrint = true;


                            if (tmpSearchPerson.Number != "")
                            {
                                if (tmpSearchPerson.Number == resultTmp[3])
                                    numberToPrint = true;
                            }
                            else
                                numberToPrint = true;


                            if (nameToPrint==true && surnameToPrint==true && numberToPrint == true && emailToPrint==true)
                                MyOwner.ListBox1.SetSelected(i, true);
                        }
                    }
                }
            }
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            MyOwner = Owner as Form1;
        }
    }
}

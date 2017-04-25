using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AddAnketa
{
    public partial class ExportForm : Form
    {
        Form1 MyOwner;
        public ExportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked == true)
            {
                //
                //initializing xml writer
                XmlTextWriter writer = new XmlTextWriter($"{this.textBox1.Text}{this.textBox2.Text}.xml", System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                //
                //writing "xml bla bla bla ver=1.0 blabla"
                writer.WriteStartDocument();

                writer.WriteStartElement("profiles");
                int cnt = 0;
                foreach (var item in MyOwner.per)
                {
                    writer.WriteStartElement($"{++cnt}");
                   // writer.WriteStartElement("Name");
                    writer.WriteElementString("name", item.FirstName);
                   // writer.WriteEndElement();
                   // writer.WriteStartElement("Surname");
                    writer.WriteElementString("surname", item.Lasname);
                    //writer.WriteEndElement();
                    //writer.WriteStartElement("Email");
                    writer.WriteElementString("email", item.Email);
                    //writer.WriteEndElement();
                    //writer.WriteStartElement("Number");
                    writer.WriteElementString("number", item.Number);
                    //writer.WriteEndElement();
                    //
                    // for cnt
                    writer.WriteEndElement();   
                }
                writer.WriteEndElement();
            }
            else if(this.radioButton2.Checked == true)
            {

            }
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            // why there is null??
            MyOwner = Owner as Form1;
        }
    }
}

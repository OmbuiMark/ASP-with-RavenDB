using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raven.Client;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;
namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            comboBox2.Items.Add("Charles Boateng");comboBox2.Items.Add("James Blunt"); comboBox2.Items.Add("Joseph");comboBox2.Items.Add("Paul Scholes");comboBox2.Items.Add("Neli Amstrong");comboBox2.Items.Add("Amy Farowawler");comboBox2.Items.Add("Joseph Davies");comboBox2.Items.Add("Kentucky"); comboBox2.Items.Add("Taylor swift"); comboBox1.Items.Add("IN");comboBox1.Items.Add("OUT");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        public void button1_Click(object sender, EventArgs e)
        {
            var docstore = new DocumentStore
            { Database = "Message", Urls = new[] { "http://localhost:8080" } };
            docstore.Initialize();
            using (var session = docstore.OpenSession())
            {
                string address = "";
                if (comboBox2.SelectedIndex == 0)
                    address = "IDs/1";
                else if (comboBox2.SelectedIndex == 1)
                    address = "IDs/2";
                else if (comboBox2.SelectedIndex == 2)
                    address = "IDs/3";
                else if (comboBox2.SelectedIndex == 3)
                    address = "IDs/4";
                else if (comboBox2.SelectedIndex == 4)
                    address = "IDs/5";
                else if (comboBox2.SelectedIndex == 5)
                    address = "IDs/6";
                else if (comboBox2.SelectedIndex == 6)
                    address = "IDs/7";
                else if (comboBox2.SelectedIndex == 7)
                    address = "IDs/8";
                else if (comboBox2.SelectedIndex == 8)
                    address = "IDs/9";
                if (comboBox1.Text == "IN")
                    
                    session.Store(new ID
                    {
                       Id = address,
                        Name = comboBox2.Text,
                        StudentId = "Edbcn",
                        ParentNo = +25472631115,
                        Status = "IN"
                    });
                else if (comboBox1.Text == "OUT")
                    session.Store(new ID
                    {
                        Id = address,
                        Name = comboBox2.Text,
                        StudentId = "wiqyggc",
                        ParentNo = +25472631115,
                        Status = "OUT"
                    }) ;


                session.SaveChanges();
            }
            if (comboBox1.Text == "IN")

                MessageBox.Show("MESSAGE SENT ", "STUDENT IN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (comboBox1.Text == "OUT")
                MessageBox.Show("MESSAGE SENT", "STUDENT OUT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }


        private class ID
        {
            public long ParentNo { get; set; }
            public string Name { get; set; }
            public string Status { get; set; }
            public string StudentId { get; set; }
            public string Id { get; set; }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class AddTags : Form
    {
        MyConnect connect = new MyConnect();
        public AddTags()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;
            try
            {
                new Success(connect.Command($"insert into tags (name, description) values (\'{name}\', \'{description}\')")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }
}

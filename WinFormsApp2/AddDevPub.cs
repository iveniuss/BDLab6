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

namespace WinFormsApp2
{
    public partial class AddDevPub : Form
    {
        MyConnect connect = new MyConnect();
        string tableName;

        public AddDevPub(string tableName)
        {
            InitializeComponent();
            this.tableName = tableName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string info = textBox2.Text;
            try
            {
                new Success(connect.Command($"insert into {tableName} (name, info) values (\'{name}\', \'{info}\')")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }
}

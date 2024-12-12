using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Add_player : Form
    {
        MyConnect connect = new MyConnect();
        public Add_player()
        {
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string username = textBox3.Text;
            try
            {
                new Success(connect.Command($"insert into players (Login, Username, Password) values ({login}, {username}, {password})")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }

        }

    }
}

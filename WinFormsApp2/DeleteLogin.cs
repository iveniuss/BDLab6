using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class DeleteLogin : Form
    {
        MyConnect connect = new MyConnect();
        public DeleteLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            try
            {
                new Success(connect.Command($"delete from players where Login = \"{login}\"")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }
}

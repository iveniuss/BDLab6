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
    public partial class DeleteId : Form
    {
        MyConnect connect = new MyConnect();
        string tableName;
        public DeleteId(string tableName)
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
            string id = textBox1.Text;
            try
            {
                new Success(connect.Command($"delete from {tableName} where id = \"{id}\"")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }
}

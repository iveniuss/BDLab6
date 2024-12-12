using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class AddGame : Form
    {
        MyConnect connect = new MyConnect();
        public AddGame()
        {
            InitializeComponent();
            var reader = connect.GetReader("select * from developers");
            while (reader.Read())
                comboBox1.Items.Add(new ComboBoxItem
                {
                    Id = reader["id"].ToString(),
                    Name = reader["name"].ToString()
                });
            reader.Close();
            reader = connect.GetReader("select * from publishers");
            while (reader.Read())
                comboBox2.Items.Add(new ComboBoxItem
                {
                    Id = reader["id"].ToString(),
                    Name = reader["name"].ToString()
                });
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;
            string date = textBox3.Text;
            string dev = "0";
            string pub = "0";
            if (comboBox1.SelectedItem is ComboBoxItem cbi1)
                dev = cbi1.Id;
            if (comboBox2.SelectedItem is ComboBoxItem cbi2)
                pub = cbi2.Id;
            string link = textBox4.Text;
            //try
            //{
            new Success(connect.Command($"insert into games (name, description, release_date, dev_id, pub_id, link) values (\'{name}\', \'{description}\', \'{date}\', \'{dev}\', \'{pub}\',\'{link}\')")).Show();
            //}
            //catch
            //{
            //    new Error("Что-то пошло не так").Show();
            //}
        }
    }

    class ComboBoxItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

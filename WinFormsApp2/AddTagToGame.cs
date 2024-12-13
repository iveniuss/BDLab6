using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class AddTagToGame : Form
    {
        MyConnect connect = new MyConnect();
        string key;
        public AddTagToGame(string id)
        {
            InitializeComponent();
            key = id;
            var reader = connect.GetReader("select * from tags");
            while (reader.Read())
                comboBox1.Items.Add(new ComboBoxItem
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
            string id = "0";
            if (comboBox1.SelectedItem is ComboBoxItem cbi1)
                id = cbi1.Id;
            try
            {
                new Success(connect.Command($"insert into games_tags (game_id, tag_id) values (\'{key}\', \'{id}\')")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }

}

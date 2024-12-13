using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace WinFormsApp2
{
    public partial class DeleteTagFromGame : Form
    {
        MyConnect connect = new MyConnect();
        string key;
        public DeleteTagFromGame(string id)
        {
            InitializeComponent();
            key = id;
            var reader = connect.GetReader($"select games_tags.id as id, tags.name as name from games_tags join tags on games_tags.tag_id = tags.id where games_tags.game_id={id}");
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
                new Success(connect.Command($"delete from games_tags where id = \'{id}\'")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }
}

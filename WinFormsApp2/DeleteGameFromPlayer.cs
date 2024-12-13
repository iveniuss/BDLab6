using Microsoft.VisualBasic.Logging;
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
    public partial class DeleteGameFromPlayer : Form
    {
        MyConnect connect = new MyConnect();
        string key;
        public DeleteGameFromPlayer(string login)
        {
            InitializeComponent();
            key = login;
            var reader = connect.GetReader($"select players_games.id as id, games.name as name from players_games join games on players_games.game_id = games.id where players_games.player_login=\'{login}\'");
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
            string id = "";
            if (comboBox1.SelectedItem is ComboBoxItem cbi1)
                id = cbi1.Id;
            try
            {
                new Success(connect.Command($"delete from players_games where id = \'{id}\'")).Show();
            }
            catch
            {
                new Error("Что-то пошло не так").Show();
            }
        }
    }
}

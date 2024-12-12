using MySql.Data.MySqlClient;
using System.Data;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        MyConnect connect = new MyConnect();
        MySqlDataAdapter adapter1;
        DataTable dt1;
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
        {

        }


        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt1 = new DataTable();

            switch (comboBox1.SelectedItem)
            {
                case "������":
                    adapter1 = connect.GetAdapter("select * from players");
                    connect.close();
                    break;
                case "����":
                    adapter1 = connect.GetAdapter("select * from games");
                    break;
                case "������������":
                    adapter1 = connect.GetAdapter("select * from developers");
                    break;
                case "��������":
                    adapter1 = connect.GetAdapter("select * from publishers");
                    break;
                case "����":
                    adapter1 = connect.GetAdapter("select * from developers");
                    break;
                case "��������� ����������":
                    adapter1 = connect.GetAdapter("select * from requirements");
                    break;
            }

            adapter1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new Success(connect.UpdateTable(adapter1, dt1)).Show();

            }
            catch
            {
                new Error("��� �� ����� �� ���").Show();
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (comboBox1.SelectedItem == "����")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    var dt = new DataTable();
                    var adapter = connect.GetAdapter("select " +
                        "games.name as ��������, " +
                        "games.description as ��������, " +
                        "games.release_date as \"���� ������\", " +
                        "developers.name as �����������, " +
                        "publishers.name as �������� " +
                        "from games " +
                        "join developers on games.dev_id  = developers.id " +
                        "join publishers on games.pub_id = publishers.id " +
                        $"where games.id = {id}");
                    adapter.Fill(dt);
                    label1.Text = dt.Rows[0]["��������"].ToString();
                    richTextBox1.Text = $"��������:\n{dt.Rows[0]["��������"]}\n\n" +
                                        $"���� ������: {dt.Rows[0]["���� ������"].ToString().Substring(0, 10)}\n\n" +
                                        $"�����������: {dt.Rows[0]["�����������"]}\n\n" +
                                        $"��������: {dt.Rows[0]["��������"]}";
                    label2.Text = "����";
                    richTextBox2.Clear();
                    dt = new DataTable();
                    adapter = connect.GetAdapter("select " +
                        "tags.name " +
                        "from games_tags " +
                        "join games on games_tags.game_id = games.id " +
                        "join tags on games_tags.tag_id = tags.id " +
                        $"where games.id = {id}");
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        richTextBox2.Text += row[0].ToString() + ", ";
                    }
                    if (richTextBox2.Text != "")
                        richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.Text.Length - 2);
                }
                if (comboBox1.SelectedItem == "������")
                {
                    string login = dataGridView1.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                    var dt = new DataTable();
                    var adapter = connect.GetAdapter("select " +
                        "players.Username as \"��� ������������\", " +
                        "players.Login as �����, " +
                        "players.Password as ������ " +
                        "from players " +
                        $"where players.Login = \"{login}\"");
                    adapter.Fill(dt);
                    label1.Text = dt.Rows[0]["��� ������������"].ToString();
                    richTextBox1.Text = $"�����: {dt.Rows[0]["�����"]}\n\n" +
                                        $"������: {dt.Rows[0]["������"]}";
                    label2.Text = "����";
                    richTextBox2.Clear();
                    dt = new DataTable();
                    adapter = connect.GetAdapter("select " +
                        "games.name " +
                        "from players_games " +
                        "join games on players_games.game_id = games.id " +
                        "join players on players_games.player_login = players.Login " +
                        $"where players.Login = \"{login}\"");
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        richTextBox2.Text += row[0].ToString() + ", ";
                    }
                    if (richTextBox2.Text != "")
                        richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.Text.Length - 2);
                }

            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "������":
                    new Add_player().Show();
                    break;
                case "����":
                    new AddGame().Show();
                    break;
                case "������������":
                    adapter1 = connect.GetAdapter("select * from developers");
                    break;
                case "��������":
                    adapter1 = connect.GetAdapter("select * from publishers");
                    break;
                case "����":
                    adapter1 = connect.GetAdapter("select * from developers");
                    break;
                case "��������� ����������":
                    adapter1 = connect.GetAdapter("select * from requirements");
                    break;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "������":
                    new DeleteLogin().Show();
                    break;
                case "����":
                    new DeleteId("games").Show();
                    break;
                case "������������":
                    adapter1 = connect.GetAdapter("select * from developers");
                    break;
                case "��������":
                    adapter1 = connect.GetAdapter("select * from publishers");
                    break;
                case "����":
                    adapter1 = connect.GetAdapter("select * from developers");
                    break;
                case "��������� ����������":
                    adapter1 = connect.GetAdapter("select * from requirements");
                    break;
            }
        }
    }
}

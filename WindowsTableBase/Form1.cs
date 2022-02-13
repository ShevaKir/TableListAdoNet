using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataSetTeamsPlayers;

namespace WindowsTableBase
{
    public partial class Form1 : Form
    {

        DataAccessor teams = new DataAccessor(StringConnectionToDataBase.GetStringConnect(), "select * from Teams");

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.Rows[e.RowIndex].Cells["IdTeam"].Value.ToString();
            int id = int.Parse(str);
            string select = string.Format("select * from Players where IdTeam = {0}", id);

            DataAccessor player = new DataAccessor(StringConnectionToDataBase.GetStringConnect(), select);
            dataGridView2.DataSource = player.Table;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teams.Table;
        }
    }
}

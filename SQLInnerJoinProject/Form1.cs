using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLInnerJoinProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection conn = new SqlConnection(@"Data Source=msyc;Initial Catalog=InnerJoinSQLTableProject;Integrated Security=True");
		
		void listele()
		{
			conn.Open();

			SqlDataAdapter da = new SqlDataAdapter("Execute InnerJoinSQLTableProject", conn);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridView1.DataSource = dt;

			conn.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
			



		}
	}
}

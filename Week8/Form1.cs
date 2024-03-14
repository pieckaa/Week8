using System.Data;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\user\\Documents\\Database1.mdb");
            ds = new DataSet();
            con.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\user\\Documents\\Database1.mdb");
            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (LastName, FirstName) values(Lastname, Firstname)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("Lastname", tbxLname.Text);
            cmd.Parameters.AddWithValue("Firstname", tbxFname.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = ID";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("ID",
            dgvStudentInfo.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void bntUpdt_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = Lastname WhereStudentID = ID";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("Lastname", tbxLname.Text);
            cmd.Parameters.AddWithValue("Firstname", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxID.Text = row.Cells[0].Value.ToString();
        }
    }
}

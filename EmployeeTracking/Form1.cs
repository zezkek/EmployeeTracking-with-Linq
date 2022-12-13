using System.Data.SqlClient;

namespace EmployeeTracking
{
    public partial class Form1 : Form
    {
        DbConnect db = new DbConnect();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = ("INSERT INTO Workers_Data (Name, EmployeeNumber, JobTitle, SubDivision, Email, PhoneNumber, EmploymentDate) VALUES ('nothing'," + 12345+ ",'nothing','nothing','nothing','nothing'," + "'"+DateTime.Now.ToShortDateString()+"')");
                //+ "(" + "'" + textBox1.Text + "'" + "," + "'" + int.Parse(textBox2.Text) + "'" + "," + "'" + textBox3.Text 
                //+ "'" + "," + "'" + textBox4.Text + "'" + "," + "'" + textBox5.Text
                //+ "'" + "," + "'" + textBox6.Text + "'" + "," + "'" + DateTime.Parse(textBox7.Text) + "'" + ")";
            db.Execute(sqlQuery);
        }
    }
}
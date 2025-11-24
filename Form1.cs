using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace _243506_Labtask10_VP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                Id = Convert.ToInt16(textBoxid.Text),
                name = textBoxname.Text,
                fathername = textBoxfather.Text,
                cnic = textBoxcnic.Text,
                designation = textBoxdesig.Text,
                salary = Convert.ToInt32(textBoxsalary.Text),
                department = comboBoxdept.SelectedItem.ToString(),
                hiredate = Convert.ToString(hiredateTimePicker.Text)
            };

            EmployeeDB db = new EmployeeDB();
            db.employee.Add(emp);
            db.SaveChanges();
            MessageBox.Show("Insert successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeDB db = new EmployeeDB();
            dataGridView1.DataSource = db.employee.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                Id = Convert.ToInt16(textBoxid.Text),
                name = textBoxname.Text,
                fathername = textBoxfather.Text
            };

            EmployeeDB db = new EmployeeDB();
            db.employee.Update(emp);
            db.SaveChanges();
            MessageBox.Show("Updated successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                Id = Convert.ToInt16(textBoxid.Text),
            };

            EmployeeDB db = new EmployeeDB();
            db.employee.Remove(emp);
            db.SaveChanges();
            MessageBox.Show("Deleted successfully");
        }

    }
}


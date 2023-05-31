using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsBook
{
    public partial class Phonebook : Form
    {

        DataTable contacts = new DataTable();
        bool editing = false;

        public Phonebook()
        {
            InitializeComponent();
        }

        private void Phonebook_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone Number");
            contacts.Columns.Add("Email");

            // Set data source

            contactsDataGrid.DataSource = contacts;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["First Name"] = firstNameTextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Last Name"] = lastNameTextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Phone Number"] = phoneNumTextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Email"] = emailTextBox.Text;

            }
            else
            {
                contacts.Rows.Add(firstNameTextBox.Text, lastNameTextBox.Text, phoneNumTextBox.Text, emailTextBox.Text);
            }
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumTextBox.Text = "";
            emailTextBox.Text = "";
            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a vlid row."); }
        }

        private void contactsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firstNameTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }
    }
}

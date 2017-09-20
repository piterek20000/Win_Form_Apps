using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MouseHoverTextBox
        private void FirstNameTextBox_MouseHover(object sender, EventArgs e)
        {
            FirstNameTextBox.BackColor = Color.ForestGreen;
        }

        private void LastNameTextBox_MouseHover(object sender, EventArgs e)
        {
            LastNameTextBox.BackColor = Color.ForestGreen;
        }

        private void AgeTextBox_MouseHover(object sender, EventArgs e)
        {
            AgeTextBox.BackColor = Color.ForestGreen;
        }

        private void BirthdayTextBox_MouseHover(object sender, EventArgs e)
        {
            BirthdayTextBox.BackColor = Color.ForestGreen;
        }

        private void AdressTextBox_MouseHover(object sender, EventArgs e)
        {
            AdressTextBox.BackColor = Color.ForestGreen;
        }

        private void PhoneTextBox_MouseHover(object sender, EventArgs e)
        {
            PhoneTextBox.BackColor = Color.ForestGreen;
        }
        #endregion

        #region MouseLeaveTextBox
        private void FirstNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstNameTextBox.Text))
                FirstNameTextBox.BackColor = Color.LightGreen;
            else
                FirstNameTextBox.BackColor = Color.Purple;
        }

        private void LastNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LastNameTextBox.Text))
                LastNameTextBox.BackColor = Color.LightGreen;
            else
                LastNameTextBox.BackColor = Color.Purple;
        }

        private void AgeTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AgeTextBox.Text))
                AgeTextBox.BackColor = Color.LightGreen;
            else
                AgeTextBox.BackColor = Color.Purple;
        }

        private void BirthdayTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BirthdayTextBox.Text))
                BirthdayTextBox.BackColor = Color.LightGreen;
            else
                BirthdayTextBox.BackColor = Color.Purple;
        }

        private void AdressTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AdressTextBox.Text))
                AdressTextBox.BackColor = Color.LightGreen;
            else
                AdressTextBox.BackColor = Color.Purple;
        }

        private void PhoneTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneTextBox.Text))
                PhoneTextBox.BackColor = Color.LightGreen;
            else
                PhoneTextBox.BackColor = Color.Purple;
        }



        #endregion

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
                FirstNameTextBox.BackColor = Color.Red;
            if (string.IsNullOrEmpty(LastNameTextBox.Text))
                LastNameTextBox.BackColor = Color.Red;
            if (string.IsNullOrEmpty(AgeTextBox.Text))
                AgeTextBox.BackColor = Color.Red;
            if (string.IsNullOrEmpty(BirthdayTextBox.Text))
                BirthdayTextBox.BackColor = Color.Red;
            if (string.IsNullOrEmpty(AdressTextBox.Text))
                AdressTextBox.BackColor = Color.Red;
            if (string.IsNullOrEmpty(PhoneTextBox.Text))
                PhoneTextBox.BackColor = Color.Red;

            else
            {
                ListViewItem A = new ListViewItem();
                A.Text = FirstNameTextBox.Text;
                A.SubItems.Add(LastNameTextBox.Text);
                A.SubItems.Add(AgeTextBox.Text);
                A.SubItems.Add(BirthdayTextBox.Text);
                A.SubItems.Add(AdressTextBox.Text);
                A.SubItems.Add(PhoneTextBox.Text);

                ClientsListView.Items.Add(A);
            }
        }

        private void ClientsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in ClientsListView.SelectedItems)
            {
                ClientsListView.Items.Remove(eachItem);
            }
        }
    }
}

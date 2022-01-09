using PatientReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientService
{
    public partial class PatientRegistrationForm : Form
    {
        public PatientRegistrationForm()
        {
            InitializeComponent();
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {

            // ensures no TextBoxes are empty
            if (textBoxName.Text == "" || textBoxUtente.Text == "" || comboBoxRNCCI.Text == "" || textBoxAddress.Text == "" || textBoxContact.Text == "" )
            {
                // display popup box
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK);
                textBoxName.Focus(); // set focus to textBoxName (the first one)
                return;
            }

            // if name format invalid show message  
            if (!Regex.Match(textBoxName.Text, "^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)").Success)
            {
                //name was incorrect  
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK);
                textBoxName.Focus();
                return;
            }

            // if address format invalid show message  
            if (!Regex.Match(textBoxAddress.Text, @"^[A-Z][a-z]+([.])?(\s?([a-zA-Z]{1,})?(([-])|([.]))?)*(([,] )|( )|([-])|([.]))?[1-9]+$").Success)
            {
                // address was incorrect  
                MessageBox.Show("Invalid address", "Message", MessageBoxButtons.OK);
                textBoxAddress.Focus();
                return;
            }


            // if utente format invalid show message
            if (!Regex.Match(textBoxUtente.Text, @"^[0-9]{9}$").Success)
            {
                // utente was incorrect  
                MessageBox.Show("Invalid utente", "Message", MessageBoxButtons.OK);
                textBoxUtente.Focus();
                return;
            }

            // if phone number format invalid show message  
            if (!Regex.Match(textBoxContact.Text, @"^[0-9]{3}\s?[0-9]{3}\s?[0-9]{4}$").Success)
            {
                //Regex expression for numbers with prefix: ^([+]{1}[(]{0,1}[0-9]{1,4}[)]{0,1})?\s?[0-9]{3}\s?[0-9]{3}\s?[0-9]{4}$
                // phone number was incorrect  
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK);
                textBoxContact.Focus();
                return;
            }
           
            

            // if hospital unit format invalid show message
            if (!Regex.Match(textBoxUnit.Text, @"^[1-9]{1}[0-9]{2}$").Success && textBoxUnit.Visible==true)
            {
                // Unit was incorrect  
                MessageBox.Show("Invalid unit number", "Message", MessageBoxButtons.OK);
                textBoxUnit.Focus();
                return;
            }

      

            if (textBoxUnit.Visible == false)
            {
                textBoxUnit.Text = "0";
            }
        

            //creating a new patient
            PatientRegistrationClient client = new();

          

            //adding the patient if the conditions are met
            string result = await client.AddPatientAsync(new Patient
            {
                Name = textBoxName.Text,
                Utente = Convert.ToInt32(textBoxUtente.Text),
                Age = dateTimePickerAge.Value.Date,
                RNCCITypology = (RNCCI)Enum.Parse(typeof(RNCCI), comboBoxRNCCI.Text),
                Address = textBoxAddress.Text,
                Contact = Convert.ToInt32(textBoxContact.Text),
                HospitalUnit = Convert.ToInt32(textBoxUnit.Text)
            });

            MessageBox.Show(result, "Message", MessageBoxButtons.OK);

            client.Close();
        }

        //if the RNCCI selection is EDCCI (meanning home care), text unit box will disappear
        private void comboBoxRNCCI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRNCCI.Text == "EDCCI")
            {
                textBoxUnit.Visible = false;
            }

            else
            {
                textBoxUnit.Visible = true;
            }
        }

        //reset button that deletes all the information from the form's fields  
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxUtente.Text = "";
            dateTimePickerAge.Value = new DateTime(2022, 01, 06);
            comboBoxRNCCI.Text = "";
            textBoxAddress.Text = "";
            textBoxContact.Text = "";
            textBoxUnit.Text = "";
            textBoxUnit.Visible = true;
        }

       
    }
}

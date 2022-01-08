using PatientReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            PatientRegistrationClient client = new();

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

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxUtente.Text = "";
            dateTimePickerAge.Value = new DateTime(2022, 01, 06);
            comboBoxRNCCI.Text = "";
            textBoxAddress.Text = "";
            textBoxContact.Text = "";
            textBoxUnit.Text = "";
        }
    }
}

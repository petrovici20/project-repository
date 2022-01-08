
namespace PatientService
{
    partial class PatientRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistrationForm));
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dateTimePickerAge = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRNCCI = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelRNCCI = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxUtente = new System.Windows.Forms.TextBox();
            this.labelUtente = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(12, 399);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.PlaceholderText = "e.g. 101";
            this.textBoxUnit.Size = new System.Drawing.Size(414, 23);
            this.textBoxUnit.TabIndex = 26;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnit.Location = new System.Drawing.Point(12, 375);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(150, 21);
            this.labelUnit.TabIndex = 32;
            this.labelUnit.Text = "Enter hospital unit: *";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(91, 446);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 28);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // dateTimePickerAge
            // 
            this.dateTimePickerAge.Location = new System.Drawing.Point(12, 155);
            this.dateTimePickerAge.MaxDate = new System.DateTime(2300, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAge.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAge.Name = "dateTimePickerAge";
            this.dateTimePickerAge.Size = new System.Drawing.Size(414, 23);
            this.dateTimePickerAge.TabIndex = 20;
            this.dateTimePickerAge.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(12, 446);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(70, 28);
            this.buttonSubmit.TabIndex = 28;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Contact: *";
            // 
            // comboBoxRNCCI
            // 
            this.comboBoxRNCCI.FormattingEnabled = true;
            this.comboBoxRNCCI.Items.AddRange(new object[] {
            "UC",
            "UMDR",
            "ULDM",
            "EDCCI"});
            this.comboBoxRNCCI.Location = new System.Drawing.Point(12, 220);
            this.comboBoxRNCCI.Name = "comboBoxRNCCI";
            this.comboBoxRNCCI.Size = new System.Drawing.Size(414, 23);
            this.comboBoxRNCCI.TabIndex = 22;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 282);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(414, 23);
            this.textBoxAddress.TabIndex = 23;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(12, 258);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(118, 21);
            this.labelAddress.TabIndex = 30;
            this.labelAddress.Text = "Enter address: *";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(12, 339);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.PlaceholderText = "## ### ####";
            this.textBoxContact.Size = new System.Drawing.Size(414, 23);
            this.textBoxContact.TabIndex = 25;
            // 
            // labelRNCCI
            // 
            this.labelRNCCI.AutoSize = true;
            this.labelRNCCI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRNCCI.Location = new System.Drawing.Point(12, 196);
            this.labelRNCCI.Name = "labelRNCCI";
            this.labelRNCCI.Size = new System.Drawing.Size(177, 21);
            this.labelRNCCI.TabIndex = 27;
            this.labelRNCCI.Text = "Enter RNCCI Typology: *";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAge.Location = new System.Drawing.Point(12, 131);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(149, 21);
            this.labelAge.TabIndex = 24;
            this.labelAge.Text = "Enter date of birth: *";
            // 
            // textBoxUtente
            // 
            this.textBoxUtente.Location = new System.Drawing.Point(12, 94);
            this.textBoxUtente.Name = "textBoxUtente";
            this.textBoxUtente.Size = new System.Drawing.Size(414, 23);
            this.textBoxUtente.TabIndex = 19;
            // 
            // labelUtente
            // 
            this.labelUtente.AutoSize = true;
            this.labelUtente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUtente.Location = new System.Drawing.Point(12, 70);
            this.labelUtente.Name = "labelUtente";
            this.labelUtente.Size = new System.Drawing.Size(187, 21);
            this.labelUtente.TabIndex = 21;
            this.labelUtente.Text = "Utente/ID of the patient: *";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(414, 23);
            this.textBoxName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter full name: *";
            // 
            // PatientRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 485);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dateTimePickerAge);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxRNCCI);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelRNCCI);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxUtente);
            this.Controls.Add(this.labelUtente);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DateTimePicker dateTimePickerAge;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRNCCI;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelRNCCI;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxUtente;
        private System.Windows.Forms.Label labelUtente;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}
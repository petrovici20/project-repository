
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
            this.textBoxUnit.Location = new System.Drawing.Point(14, 532);
            this.textBoxUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.PlaceholderText = "e.g. 101";
            this.textBoxUnit.Size = new System.Drawing.Size(473, 27);
            this.textBoxUnit.TabIndex = 26;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnit.Location = new System.Drawing.Point(14, 500);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(188, 28);
            this.labelUnit.TabIndex = 32;
            this.labelUnit.Text = "Enter hospital unit: *";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(104, 595);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 37);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // dateTimePickerAge
            // 
            this.dateTimePickerAge.Location = new System.Drawing.Point(14, 207);
            this.dateTimePickerAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerAge.MaxDate = new System.DateTime(2300, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAge.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAge.Name = "dateTimePickerAge";
            this.dateTimePickerAge.Size = new System.Drawing.Size(473, 27);
            this.dateTimePickerAge.TabIndex = 20;
            this.dateTimePickerAge.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(14, 595);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(80, 37);
            this.buttonSubmit.TabIndex = 28;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
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
            this.comboBoxRNCCI.Location = new System.Drawing.Point(14, 293);
            this.comboBoxRNCCI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRNCCI.Name = "comboBoxRNCCI";
            this.comboBoxRNCCI.Size = new System.Drawing.Size(473, 28);
            this.comboBoxRNCCI.TabIndex = 22;
            this.comboBoxRNCCI.SelectedIndexChanged += new System.EventHandler(this.comboBoxRNCCI_SelectedIndexChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(14, 376);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(473, 27);
            this.textBoxAddress.TabIndex = 23;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(14, 344);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(146, 28);
            this.labelAddress.TabIndex = 30;
            this.labelAddress.Text = "Enter address: *";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(14, 452);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.PlaceholderText = "## ### ####";
            this.textBoxContact.Size = new System.Drawing.Size(473, 27);
            this.textBoxContact.TabIndex = 25;
            // 
            // labelRNCCI
            // 
            this.labelRNCCI.AutoSize = true;
            this.labelRNCCI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRNCCI.Location = new System.Drawing.Point(14, 261);
            this.labelRNCCI.Name = "labelRNCCI";
            this.labelRNCCI.Size = new System.Drawing.Size(221, 28);
            this.labelRNCCI.TabIndex = 27;
            this.labelRNCCI.Text = "Enter RNCCI Typology: *";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAge.Location = new System.Drawing.Point(14, 175);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(188, 28);
            this.labelAge.TabIndex = 24;
            this.labelAge.Text = "Enter date of birth: *";
            // 
            // textBoxUtente
            // 
            this.textBoxUtente.Location = new System.Drawing.Point(14, 125);
            this.textBoxUtente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUtente.Name = "textBoxUtente";
            this.textBoxUtente.Size = new System.Drawing.Size(473, 27);
            this.textBoxUtente.TabIndex = 19;
            // 
            // labelUtente
            // 
            this.labelUtente.AutoSize = true;
            this.labelUtente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUtente.Location = new System.Drawing.Point(14, 93);
            this.labelUtente.Name = "labelUtente";
            this.labelUtente.Size = new System.Drawing.Size(238, 28);
            this.labelUtente.TabIndex = 21;
            this.labelUtente.Text = "Utente/ID of the patient: *";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 44);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(473, 27);
            this.textBoxName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter full name: *";
            // 
            // PatientRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 647);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
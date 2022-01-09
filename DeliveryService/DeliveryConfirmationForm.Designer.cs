
namespace DeliveryService
{
    partial class DeliveryConfirmationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryConfirmationForm));
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.labelRequest = new System.Windows.Forms.Label();
            this.textBoxSearchRequest = new System.Windows.Forms.TextBox();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.dataGridViewDelivery = new System.Windows.Forms.DataGridView();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.textBoxSearchDelivery = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.AllowUserToAddRows = false;
            this.dataGridViewRequests.AllowUserToDeleteRows = false;
            this.dataGridViewRequests.AllowUserToResizeColumns = false;
            this.dataGridViewRequests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRequests.GridColor = System.Drawing.Color.Azure;
            this.dataGridViewRequests.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowTemplate.Height = 25;
            this.dataGridViewRequests.Size = new System.Drawing.Size(332, 237);
            this.dataGridViewRequests.TabIndex = 89;
            this.dataGridViewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRequests_CellContentClick);
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.BackColor = System.Drawing.Color.Transparent;
            this.labelRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRequest.Location = new System.Drawing.Point(12, 23);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(124, 21);
            this.labelRequest.TabIndex = 88;
            this.labelRequest.Text = "Search Requests";
            // 
            // textBoxSearchRequest
            // 
            this.textBoxSearchRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchRequest.Location = new System.Drawing.Point(12, 47);
            this.textBoxSearchRequest.Name = "textBoxSearchRequest";
            this.textBoxSearchRequest.Size = new System.Drawing.Size(204, 29);
            this.textBoxSearchRequest.TabIndex = 87;
            this.textBoxSearchRequest.TextChanged += new System.EventHandler(this.TextBoxSearchRequest_TextChanged);
            // 
            // buttonPlace
            // 
            this.buttonPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlace.Location = new System.Drawing.Point(264, 47);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(80, 29);
            this.buttonPlace.TabIndex = 94;
            this.buttonPlace.Text = "Place";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.ButtonPlace_Click);
            // 
            // dataGridViewDelivery
            // 
            this.dataGridViewDelivery.AllowUserToAddRows = false;
            this.dataGridViewDelivery.AllowUserToDeleteRows = false;
            this.dataGridViewDelivery.AllowUserToResizeColumns = false;
            this.dataGridViewDelivery.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDelivery.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDelivery.GridColor = System.Drawing.Color.Azure;
            this.dataGridViewDelivery.Location = new System.Drawing.Point(393, 91);
            this.dataGridViewDelivery.Name = "dataGridViewDelivery";
            this.dataGridViewDelivery.RowTemplate.Height = 25;
            this.dataGridViewDelivery.Size = new System.Drawing.Size(332, 237);
            this.dataGridViewDelivery.TabIndex = 97;
            this.dataGridViewDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDelivery_CellContentClick);
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.BackColor = System.Drawing.Color.Transparent;
            this.labelDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDelivery.Location = new System.Drawing.Point(393, 23);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(129, 21);
            this.labelDelivery.TabIndex = 96;
            this.labelDelivery.Text = "Search Deliveries";
            // 
            // textBoxSearchDelivery
            // 
            this.textBoxSearchDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchDelivery.Location = new System.Drawing.Point(393, 47);
            this.textBoxSearchDelivery.Name = "textBoxSearchDelivery";
            this.textBoxSearchDelivery.Size = new System.Drawing.Size(204, 29);
            this.textBoxSearchDelivery.TabIndex = 95;
            this.textBoxSearchDelivery.TextChanged += new System.EventHandler(this.TextBoxSearchDelivery_TextChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(645, 46);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(79, 29);
            this.buttonConfirm.TabIndex = 98;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // DeliveryConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 340);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dataGridViewDelivery);
            this.Controls.Add(this.labelDelivery);
            this.Controls.Add(this.textBoxSearchDelivery);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.dataGridViewRequests);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.textBoxSearchRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeliveryConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Placement and Confirmation";
            this.Load += new System.EventHandler(this.DeliveryConfirmationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.TextBox textBoxSearchRequest;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.DataGridView dataGridViewDelivery;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.TextBox textBoxSearchDelivery;
        private System.Windows.Forms.Button buttonConfirm;
    }
}
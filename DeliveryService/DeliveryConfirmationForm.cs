using DeliveryService.Models;
using RequestService;
using RequestService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryService
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeliveryConfirmationForm : Form
    {
        // 
        RequestClient request = new();
        DeliveryClient delivery = new();

        public DeliveryConfirmationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchRequest_TextChanged(object sender, EventArgs e) => dataGridViewRequests.DataSource = RequestConnection.Filter(textBoxSearchRequest.Text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchDelivery_TextChanged(object sender, EventArgs e) => dataGridViewDelivery.DataSource = DeliveryConnection.Filter(textBoxSearchDelivery.Text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlace_Click(object sender, EventArgs e)
        {
            if(request.RequestId > 0)
            {
                DeliveryConnection.Place(request);

                DataTable tableRequest = RequestConnection.GetRequests();
                dataGridViewRequests.DataSource = tableRequest;

                DataTable tableDelivery = DeliveryConnection.GetDeliveries();
                dataGridViewRequests.DataSource = tableDelivery;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {

        }

       
        /// <summary>
        /// Selects the request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            request.RequestId = Convert.ToInt32(dataGridViewRequests.Rows[rowIndex].Cells[0].Value.ToString());
            request.HospitalUnitId = Convert.ToInt32(dataGridViewRequests.Rows[rowIndex].Cells[1].Value.ToString());
            request.MaterialName = dataGridViewRequests.Rows[rowIndex].Cells[2].Value.ToString();
            request.MaterialQuantity = Convert.ToInt32(dataGridViewRequests.Rows[rowIndex].Cells[3].Value.ToString());
        }

        /// <summary>
        /// Selects the Delivery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            delivery.RequestId = Convert.ToInt32(dataGridViewRequests.Rows[rowIndex].Cells[0].Value.ToString());
            delivery.HospitalUnitId = Convert.ToInt32(dataGridViewRequests.Rows[rowIndex].Cells[1].Value.ToString());
            delivery.MaterialName = dataGridViewRequests.Rows[rowIndex].Cells[2].Value.ToString();
            delivery.MaterialQuantity = Convert.ToInt32(dataGridViewRequests.Rows[rowIndex].Cells[3].Value.ToString());
            delivery.Delivered = dataGridViewRequests.Rows[rowIndex].Cells[4].Value.ToString();
        }

        /// <summary>
        /// Loads the tables when initialized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryConfirmationForm_Load(object sender, EventArgs e)
        {
            // Request table fill
            DataTable tableRequest = RequestConnection.GetRequests();
            dataGridViewRequests.DataSource = tableRequest;

            // Delivery table fill
            DataTable tableDelivery = DeliveryConnection.GetDeliveries();
            dataGridViewRequests.DataSource = tableDelivery;
        }
    }
}

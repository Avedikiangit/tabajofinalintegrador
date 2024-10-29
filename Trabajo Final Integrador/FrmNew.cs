using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final_Integrador
{
    public partial class FrmNew : Form
    {

        private ErrorProvider _errorProvider = new ErrorProvider();
        public List<ApiProducts> newProducts { get; private set; }

        public FrmNew(List<ApiProducts> existingProducts)
        {
            InitializeComponent();
            this.newProducts = existingProducts;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNew_Load(object sender, EventArgs e)
        {
            txtBoxId.Text = GetNextProductId().ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ConnecectionApi connecectionApi = new ConnecectionApi();
            string title = txtBoxTitle.Text;
            string priceText = txtBoxPrice.Text;
            decimal price = Convert.ToDecimal(priceText);

            if (!ValidateFields())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(txtBoxId.Text);

            ApiProducts product = new ApiProducts
            {
                Id = id,
                Title = title,
                Price = price,
                Description = txtBoxDescription.Text,
                Category = txtBoxCategory.Text
            };



            MessageBox.Show(connecectionApi.PostProducts(newProducts, product));

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtBoxTitle.Text))
            {
                _errorProvider.SetError(txtBoxTitle, "El campo Title es obligatorio.");
                isValid = false;
            }
            else
            {
                _errorProvider.SetError(txtBoxTitle, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtBoxPrice.Text) || !decimal.TryParse(txtBoxPrice.Text, out decimal price) || price <= 0)
            {
                _errorProvider.SetError(txtBoxPrice, "El campo Price debe ser un número válido mayor que cero.");
                isValid = false;
            }
            else
            {
                _errorProvider.SetError(txtBoxPrice, string.Empty);
            }

            return isValid;
        }
        private int GetNextProductId()
        {
            if (newProducts != null && newProducts.Count > 0)
            {
                return newProducts.Max(p => p.Id) + 1;
            }
            return 1;
        }
    }
}

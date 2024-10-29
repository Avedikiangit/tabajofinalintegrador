using Datos;
using Negocio;

namespace Trabajo_Final_Integrador
{
    public partial class FrmEdit : Form
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();
        private readonly ConnecectionApi _connecectionApi;
        private ApiProducts _product;
        public List<ApiProducts> EditedProducts { get; private set; }

        public FrmEdit(ApiProducts product, List<ApiProducts> oldList)
        {
            InitializeComponent();
            _product = product;
            EditedProducts = oldList;
            _connecectionApi = new ConnecectionApi();

            InitializeProductFields(product);
        }

        private void InitializeProductFields(ApiProducts product)
        {
            txtBoxIdEdit.Text = product.Id.ToString();
            txtBoxCategoryEdit.Text = product.Category;
            txtBoxDescriptionEdit.Text = product.Description;
            txtBoxTitleEdit.Text = product.Title;
            txtBoxPriceEdit.Text = product.Price.ToString();
        }

        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatedProduct = GetUpdatedProductFromFields();
            MessageBox.Show(_connecectionApi.PutProducts(EditedProducts, updatedProduct));
            this.Close();
        }

        private ApiProducts GetUpdatedProductFromFields()
        {
            return new ApiProducts
            {
                Id = int.Parse(txtBoxIdEdit.Text),
                Title = txtBoxTitleEdit.Text,
                Price = decimal.Parse(txtBoxPriceEdit.Text),
                Description = txtBoxDescriptionEdit.Text,
                Category = txtBoxCategoryEdit.Text
            };
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtBoxTitleEdit.Text))
            {
                _errorProvider.SetError(txtBoxTitleEdit, "El campo Title es obligatorio.");
                isValid = false;
            }
            else
            {
                _errorProvider.SetError(txtBoxTitleEdit, string.Empty);
            }

            if (!ValidatePrice())
            {
                isValid = false;
            }

            return isValid;
        }

        private bool ValidatePrice()
        {
            if (string.IsNullOrWhiteSpace(txtBoxPriceEdit.Text) || !decimal.TryParse(txtBoxPriceEdit.Text, out decimal price) || price <= 0)
            {
                _errorProvider.SetError(txtBoxPriceEdit, "El campo Price debe ser un número válido mayor que cero.");
                return false;
            }
            else
            {
                _errorProvider.SetError(txtBoxPriceEdit, string.Empty);
                return true;
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}

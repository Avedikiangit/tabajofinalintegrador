using Datos;
using Negocio;
using System.Configuration;


namespace Trabajo_Final_Integrador
{
    public partial class FrmMain : Form
    {
        ConnecectionApi connecectionApi;
        public List<ApiProducts> Products;
        public List<string>? Categories;
        public List<ApiProducts>? FilteredProducts;
        public FrmMain()
        {
            InitializeComponent();
            Products = new List<ApiProducts>();
            Categories = new List<string>();


            connecectionApi = new ConnecectionApi();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show(connecectionApi.GetProducts(Products));
            FilteredProducts = new List<ApiProducts>(Products);
            connecectionApi.GetCategories(Categories);

            dataGridView.DataSource = Products;

            Categories.Insert(0, "All");

            cmbBoxCategory.DataSource = Categories;

            cmbBoxCategory.SelectedIndex = 0;
        }

        private void cmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedCategory = cmbBoxCategory.SelectedItem.ToString();

            FilteredProducts = new List<ApiProducts>(Products);
            if (selectedCategory == "All")
            {
                dataGridView.DataSource = Products;
            }
            else
            {
                connecectionApi.GetInCategory(FilteredProducts, selectedCategory);
                dataGridView.DataSource = null;
                dataGridView.DataSource = FilteredProducts;
            }

        }


        private void btnAscDesc_Click(object sender, EventArgs e)
        {
            string? selectedCategory = cmbBoxCategory.SelectedItem?.ToString();

            if (selectedCategory != "All")
            {
                connecectionApi.SortResults(Products, btnAscDesc.Text);
                dataGridView.DataSource = null;
                dataGridView.DataSource = Products
                    .Where(p => p.Category != null && p.Category.Equals(selectedCategory))
                    .ToList();
            }
            else
            {
                connecectionApi.SortResults(Products, btnAscDesc.Text);
                dataGridView.DataSource = null;
                dataGridView.DataSource = Products;
            }

            if (btnAscDesc.Text == "Descendente")
            {
                btnAscDesc.Text = "Ascendente";
            }
            else
            {
                btnAscDesc.Text = "Descendente";
            }
        }

        private void btnAcctions_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (FrmNew form = new FrmNew(this.Products))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Products = form.newProducts;

                    dataGridView.DataSource = null;
                    dataGridView.DataSource = this.Products;
                }
            }
        }



        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var filteredProducts = (List<ApiProducts>)dataGridView.DataSource;
            var selectedProduct = filteredProducts[e.RowIndex];

            using (FrmEdit form = new FrmEdit(selectedProduct, this.Products))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataGridView.Refresh();
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedIds = new List<int>();
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    int selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                    selectedIds.Add(selectedId);
                }

                dataGridView.BindingContext[Products].SuspendBinding();

                string resultMessage = connecectionApi.DeleteProducts(Products, selectedIds);
                MessageBox.Show(resultMessage);

                dataGridView.DataSource = null;
                dataGridView.DataSource = Products;

                dataGridView.BindingContext[Products].ResumeBinding();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila.");
            }

        }


    }
}
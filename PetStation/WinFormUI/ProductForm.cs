using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace WinFormUI
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private IProductService _productService;

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadProducts();
            ListViewDetail();
            totalCost.Text = "0,00";
        }

        public void LoadProducts()
        {
            dataGridView1.DataSource = _productService.GetList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].Width = 240;
            dataGridView1.Columns[2].HeaderText = "Fiyat";
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].HeaderText = "Stok";
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.AutoSize = true;

        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string totalPrice;
                string ProductName = Convert.ToString(textBoxProductName.Text);

                var priceT = Convert.ToString(textBoxPriceT.Text);
                var priceO = Convert.ToString(textBoxPriceO.Text);
                totalPrice = $"{priceT},{priceO}";

                var Price = Convert.ToDecimal(totalPrice);

                int Quantity = Convert.ToInt32(textBoxQuantity.Text);


                _productService.Add(new Product
                {
                    ProductName = ProductName,
                    Price = Price,
                    Quantity = Quantity,
                    CategoryId = 1

                });

                LoadProducts();
                ClearForAddEvent();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }



        }


        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(textBoxSearchProduct.Text);
        }

        private void SearchProducts(string product)
        {
            var result = _productService.GetList().Where(p => p.ProductName.ToLower().Contains(product.ToLower())).ToList();
            dataGridView1.DataSource = result;
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                textBoxUpdateProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                string Price = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                string[] PriceList = Price.Split(',');

                textBoxUpdatePriceT.Text = PriceList[0].ToString();
                textBoxUpdatePriceO.Text = PriceList[1].ToString();
                textBoxUpdateQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                AddForCombineListView();
            }


        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });

            LoadProducts();
            MessageBox.Show("Ürün Silindi");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string totalPrice;
                var priceT = Convert.ToString(textBoxUpdatePriceT.Text);
                var priceO = Convert.ToString(textBoxUpdatePriceO.Text);
                totalPrice = $"{priceT},{priceO}";

                var PriceTotal = Convert.ToDecimal(totalPrice);

                var a = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                _productService.Update(new Product
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    ProductName = textBoxUpdateProductName.Text,
                    Price = PriceTotal,
                    Quantity = Convert.ToInt32(textBoxUpdateQuantity.Text),
                    CategoryId = 1


                });

                LoadProducts();
                ClearForUpdateEvent();
                MessageBox.Show("Ürün Güncellendi.");

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }

        }


        private void ListViewDetail()
        {
            CombineListView.View = View.Details;
            CombineListView.GridLines = true;
            CombineListView.FullRowSelect = true;

            CombineListView.Columns.Add("Ürün", 162);
            CombineListView.Columns.Add("Alış Fiyatı", 58);

        }

        private void deleteForCombineBox_Click(object sender, EventArgs e)
        {
            DeleteCombineListView();
        }

        private bool DeleteCombineListView()
        {
            bool deleteStatus = true;

            if (CombineListView.Items.Count != 0)
            {
                try
                {
                    while (CombineListView.SelectedItems.Count > 0)
                    {
                        CombineListView.Items.Remove(CombineListView.SelectedItems[0]);
                    }

                    LoadListView();
                }
                catch (Exception exception)
                {
                    if (exception.Source == "System.Windows.Forms" && exception.Message == "InvalidArgument='0' değeri 'index' için geçerli değil.\r\nParametre adı: index")

                    {
                        MessageBox.Show("Lütfen listeden silmek istediğiniz ürünü seçiniz!.");
                    }


                }

            }


            return deleteStatus;
        }

        private void AddForCombineListView()
        {
            string specifier = "G";
            bool status = false;
            var productName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
            var roundTheNumber = price.ToString(specifier, CultureInfo.InvariantCulture);
            string[] items = { productName, roundTheNumber };
            var row = new ListViewItem(items);
            CombineListView.Items.Add(row);

            if (CombineListView.Items.Count != 0)
            {
                status = true;
            }
            else if (CombineListView.Items.Count == 0)
            {
                status = false;
            }


            if (status == true)
            {
                LoadListView();
            }
            else
            {
                totalCost.Text = "0.00";
            }


        }

        private void LoadListView()
        {
            decimal totalCoastforItems = 0;
            decimal[] total = new decimal[CombineListView.Items.Count];


            for (int i = 0; i < CombineListView.Items.Count; i++)
            {
                total[i] = Convert.ToDecimal(CombineListView.Items[i].SubItems[1].Text.ToString());
                totalCoastforItems = totalCoastforItems + total[i];
            }


            totalCost.Text = (decimal.Parse(totalCoastforItems.ToString(), System.Globalization.NumberStyles.Currency) / 100).ToString("N2");



        }

        private void ClearForAddEvent()
        {
            textBoxProductName.Text = "";
            textBoxPriceO.Text = "";
            textBoxPriceT.Text = "";
            textBoxQuantity.Text = "";
        }
        private void ClearForUpdateEvent()
        {
            textBoxUpdateProductName.Text = "";
            textBoxUpdatePriceO.Text = "";
            textBoxUpdatePriceT.Text = "";
            textBoxUpdateQuantity.Text = "";
        }

        private void ClearForComponent_Click(object sender, EventArgs e)
        {
            ClearForAddEvent();
            ClearForUpdateEvent();
        }

        private void CreateCombineForImageBtn_Click(object sender, EventArgs e)
        {
            ImageCombineForm _imageForm = new ImageCombineForm();
            _imageForm.Show();
        }
    }
}


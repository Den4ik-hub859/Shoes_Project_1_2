using Microsoft.EntityFrameworkCore;
using Shoes_Project_1_2.Models;
using System.Resources;

namespace Shoes_Project_1_2
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            this.Text = "Чудо Обувь — Товары";
            this.BackColor = Color.White;
            FLP.BackColor = Color.White;
            this.Load += FormLoad;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            CatalogLoad();
            FLP.Dock = DockStyle.Fill;
            FLP.AutoScroll = true;
        }

        private void CatalogLoad()
        {
            FLP.Controls.Clear();

            try
            {
                using (var db = new MyDbContext())
                {
                    var today = DateOnly.FromDateTime(DateTime.Now);
                    var firstDayOfCurrentMonth = new DateOnly(today.Year, today.Month, 1);
                    var startOfLastMonth = firstDayOfCurrentMonth.AddMonths(-1);
                    var endOfLastMonth = firstDayOfCurrentMonth.AddDays(-1);

                    var products = db.Products
                        .Include(p => p.Category)
                        .Include(p => p.Manufacturer)
                        .Include(p => p.ProductStocks)
                        .Include(p => p.OrderItems)
                        .ThenInclude(oi => oi.Order)
                        .ToList();

                    foreach (var p in products)
                    {
                        ProductControl card = new ProductControl();

                        bool hasOrdersLastMonth = p.OrderItems.Any(oi =>
                            oi.Order != null &&
                            oi.Order.OrderDate >= startOfLastMonth &&
                            oi.Order.OrderDate <= endOfLastMonth);

                        int totalPairsCount = p.ProductStocks?.Sum(s => s.QuantityAvailable) ?? 0;

                        card.InsertProduct(
                            brand: p.Manufacturer?.ManufacturerName ?? "Без бренда",
                            name: p.ProductName,
                            category: p.Category?.CategoryName ?? "Без категории",
                            composition: p.Composition ?? "Не указан",
                            totalPairs: totalPairsCount,
                            basePrice: p.Price,
                            hasOrdersLastMonth: hasOrdersLastMonth,
                            productImages: LoadProductImage(p.ImageFile)
                        );

                        FLP.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Image LoadProductImage(string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName)) return null;

            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            string fullPath = Path.Combine(imagesFolder, imageName);

            if (File.Exists(fullPath))
            {
                return Image.FromFile(fullPath);
            }

            return null;
        }
    }
}

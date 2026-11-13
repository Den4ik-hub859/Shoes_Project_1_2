using Image = System.Drawing.Image;

namespace Shoes_Project_1_2
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        public void InsertProduct(string brand, string name, string category, string composition, int totalPairs, decimal basePrice, bool hasOrdersLastMonth, Image productImages)
        {
            lblHead.Text = $"{brand} | {name}";

            lblCategory.Text = $"Категория: {category}";
            lblComposition.Text = $"Состав: {composition}";

            if (totalPairs > 5)
            {
                lblQuantity.Text = "Количество: много";
                this.BackColor = Color.White;
            }
            else
            {
                lblQuantity.Text = "Количество: мало";
                this.BackColor = ColorTranslator.FromHtml("#70B2AF");
            }

            decimal finalPrice = basePrice;
            if (!hasOrdersLastMonth)
            {
                finalPrice = basePrice * 0.75m;
            }
            lblPrice.Text = $"{finalPrice:N} руб.";

            if (productImages != null)
            {
                pic.Image = productImages;
            }
            else
            {
                pic.Image = Properties.Resources.picture;
            }
        }
    }
}

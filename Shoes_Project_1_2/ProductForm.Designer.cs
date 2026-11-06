namespace Shoes_Project_1_2
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            FLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FLP
            // 
            FLP.Dock = DockStyle.Fill;
            FLP.Location = new Point(0, 0);
            FLP.Margin = new Padding(3, 4, 3, 4);
            FLP.Name = "FLP";
            FLP.Size = new Size(784, 561);
            FLP.TabIndex = 0;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(FLP);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductForm";
            Text = "Товары";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FLP;
    }
}
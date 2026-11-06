namespace Shoes_Project_1_2
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic = new PictureBox();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblComposition = new Label();
            lblPrice = new Label();
            lblHead = new Label();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pic.Location = new Point(21, 21);
            pic.Name = "pic";
            pic.Size = new Size(155, 155);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(200, 54);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(365, 32);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "label1";
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(200, 86);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(365, 33);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "label2";
            // 
            // lblComposition
            // 
            lblComposition.Location = new Point(200, 119);
            lblComposition.Name = "lblComposition";
            lblComposition.Size = new Size(365, 57);
            lblComposition.TabIndex = 4;
            lblComposition.Text = "label3";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(571, 54);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(159, 122);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "label4";
            lblPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHead
            // 
            lblHead.Location = new Point(200, 21);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(530, 33);
            lblHead.TabIndex = 6;
            lblHead.Text = "label1";
            lblHead.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblHead);
            Controls.Add(lblPrice);
            Controls.Add(lblComposition);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(pic);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductControl";
            Size = new Size(750, 200);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic;
        private Label labelHead;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblComposition;
        private Label lblPrice;
        private Label lblHead;
    }
}

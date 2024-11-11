namespace WinFormsApp
{
    partial class ItemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetails));
            itemPicture = new PictureBox();
            brandLabel = new Label();
            nameLabel = new Label();
            priceLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            descLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)itemPicture).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // itemPicture
            // 
            itemPicture.Image = (Image)resources.GetObject("itemPicture.Image");
            itemPicture.Location = new Point(3, 3);
            itemPicture.Name = "itemPicture";
            itemPicture.Size = new Size(186, 180);
            itemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            itemPicture.TabIndex = 0;
            itemPicture.TabStop = false;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            brandLabel.Location = new Point(3, 186);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(105, 25);
            brandLabel.TabIndex = 1;
            brandLabel.Text = "Sennheiser";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(3, 211);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "HD560S";
            // 
            // priceLabel
            // 
            priceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(3, 236);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(186, 19);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "(13990.00 php)";
            priceLabel.Click += priceLabel_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel2.Controls.Add(priceLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(brandLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(itemPicture, 0, 0);
            tableLayoutPanel2.Controls.Add(nameLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(descLabel, 0, 4);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(192, 376);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(3, 261);
            descLabel.Margin = new Padding(3, 6, 3, 0);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(180, 105);
            descLabel.TabIndex = 4;
            descLabel.Text = "Professional Open-back Studio Headphones. 120 Ohm dynamic transducer, 110dB SPL. 6Hz-38,000Hz\r\n\r\nInput Connector(s): \r\n3.5mm Male\r\n";
            // 
            // ItemDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "ItemDetails";
            Size = new Size(192, 376);
            Load += ItemDetails_Load;
            ((System.ComponentModel.ISupportInitialize)itemPicture).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox itemPicture;
        private Label brandLabel;
        private Label nameLabel;
        private Label priceLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label descLabel;
    }
}

﻿namespace WinFormsApp
{
    partial class ItemListing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            flowLayoutPanel1 = new FlowLayoutPanel();
            addItemButton = new Button();
            refreshButton = new Button();
            titleLabel = new Label();
            itemListView = new ListView();
            code = new ColumnHeader();
            item = new ColumnHeader();
            Variant = new ColumnHeader();
            unitPrice = new ColumnHeader();
            itemDetails1 = new ItemDetails();
            id = new ColumnHeader();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(addItemButton);
            flowLayoutPanel1.Controls.Add(refreshButton);
            flowLayoutPanel1.Controls.Add(titleLabel);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 44);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(684, 3);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(89, 41);
            addItemButton.TabIndex = 0;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(589, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(89, 41);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(15, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(568, 37);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "SEV Audio Inventory                                         ";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // itemListView
            // 
            itemListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemListView.Columns.AddRange(new ColumnHeader[] { id, code, item, Variant, unitPrice });
            itemListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            itemListView.Location = new Point(210, 62);
            itemListView.Name = "itemListView";
            itemListView.Size = new Size(578, 376);
            itemListView.TabIndex = 3;
            itemListView.UseCompatibleStateImageBehavior = false;
            itemListView.View = View.Details;
            itemListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // code
            // 
            code.Tag = "";
            code.Text = "Code";
            code.Width = 80;
            // 
            // item
            // 
            item.Tag = "";
            item.Text = "Item";
            item.Width = 200;
            // 
            // Variant
            // 
            Variant.Tag = "";
            Variant.Text = "Variant";
            Variant.Width = 100;
            // 
            // unitPrice
            // 
            unitPrice.Tag = "";
            unitPrice.Text = "Unit Price";
            unitPrice.Width = 120;
            // 
            // itemDetails1
            // 
            itemDetails1.Location = new Point(12, 62);
            itemDetails1.Name = "itemDetails1";
            itemDetails1.Size = new Size(192, 376);
            itemDetails1.TabIndex = 4;
            itemDetails1.Load += itemDetails1_Load;
            // 
            // id
            // 
            id.Text = "id";
            // 
            // ItemListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(itemDetails1);
            Controls.Add(itemListView);
            Controls.Add(flowLayoutPanel1);
            Name = "ItemListing";
            Text = "ITS152L - Vilaga SA";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView itemListView;
        private ColumnHeader Variant;
        private ColumnHeader code;
        private ColumnHeader item;
        private ColumnHeader unitPrice;
        private ItemDetails itemDetails1;
        private Button addItemButton;
        private Button refreshButton;
        private Label titleLabel;
        private ColumnHeader id;
    }
}

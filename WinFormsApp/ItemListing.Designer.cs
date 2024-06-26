namespace WinFormsApp
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
            listView1 = new ListView();
            id = new ColumnHeader();
            code = new ColumnHeader();
            item = new ColumnHeader();
            unitPrice = new ColumnHeader();
            itemDetails1 = new ItemDetails();
            addItemButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(addItemButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 44);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { id, code, item, unitPrice });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(210, 62);
            listView1.Name = "listView1";
            listView1.Size = new Size(578, 376);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // id
            // 
            id.Tag = "";
            id.Text = "ID";
            id.Width = 50;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(itemDetails1);
            Controls.Add(listView1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader code;
        private ColumnHeader item;
        private ColumnHeader unitPrice;
        private ItemDetails itemDetails1;
        private Button addItemButton;
    }
}

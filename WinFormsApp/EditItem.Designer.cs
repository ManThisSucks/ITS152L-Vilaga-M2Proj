namespace AudioProductsUI
{
    partial class EditItem
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
            submitButton = new Button();
            msrpTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            variantTextBox = new TextBox();
            modelTextBox = new TextBox();
            makeTextBox = new TextBox();
            itemCodeTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            submitButton.Location = new Point(352, 270);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 25;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // msrpTextBox
            // 
            msrpTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            msrpTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            msrpTextBox.Location = new Point(120, 225);
            msrpTextBox.Name = "msrpTextBox";
            msrpTextBox.Size = new Size(307, 31);
            msrpTextBox.TabIndex = 24;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(120, 184);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(307, 31);
            descriptionTextBox.TabIndex = 23;
            // 
            // variantTextBox
            // 
            variantTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            variantTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            variantTextBox.Location = new Point(120, 143);
            variantTextBox.Name = "variantTextBox";
            variantTextBox.Size = new Size(307, 31);
            variantTextBox.TabIndex = 22;
            // 
            // modelTextBox
            // 
            modelTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            modelTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            modelTextBox.Location = new Point(120, 102);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(307, 31);
            modelTextBox.TabIndex = 21;
            // 
            // makeTextBox
            // 
            makeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            makeTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            makeTextBox.Location = new Point(120, 61);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(307, 31);
            makeTextBox.TabIndex = 20;
            // 
            // itemCodeTextBox
            // 
            itemCodeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemCodeTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            itemCodeTextBox.Location = new Point(120, 20);
            itemCodeTextBox.Name = "itemCodeTextBox";
            itemCodeTextBox.Size = new Size(307, 31);
            itemCodeTextBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 229);
            label6.Margin = new Padding(3, 10, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 18;
            label6.Text = "Msrp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 188);
            label5.Margin = new Padding(3, 10, 3, 10);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 17;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 147);
            label4.Margin = new Padding(3, 10, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 16;
            label4.Text = "Variant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 65);
            label3.Margin = new Padding(3, 10, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 15;
            label3.Text = "Make/Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 106);
            label2.Margin = new Padding(3, 10, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 14;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Margin = new Padding(3, 10, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 13;
            label1.Text = "Item Code";
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 312);
            Controls.Add(submitButton);
            Controls.Add(msrpTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(variantTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(makeTextBox);
            Controls.Add(itemCodeTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditItem";
            Text = "EditItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private TextBox msrpTextBox;
        private TextBox descriptionTextBox;
        private TextBox variantTextBox;
        private TextBox modelTextBox;
        private TextBox makeTextBox;
        private TextBox itemCodeTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace Inventory
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            label9 = new Label();
            richTxtDescription = new RichTextBox();
            label8 = new Label();
            txtProductId = new TextBox();
            btnAddProduct = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(136, 34);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 107);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 145);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 186);
            label4.Name = "label4";
            label4.Size = new Size(82, 26);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 11.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 230);
            label5.Name = "label5";
            label5.Size = new Size(79, 26);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 11.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 277);
            label6.Name = "label6";
            label6.Size = new Size(40, 26);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 11.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 319);
            label7.Name = "label7";
            label7.Size = new Size(108, 26);
            label7.TabIndex = 6;
            label7.Text = "Sell Price (₱)";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Cursor = Cursors.Hand;
            txtProductName.Font = new Font("Poppins", 9F);
            txtProductName.Location = new Point(135, 110);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(252, 25);
            txtProductName.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Cursor = Cursors.Hand;
            txtQuantity.Font = new Font("Poppins", 9F);
            txtQuantity.Location = new Point(135, 280);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(252, 25);
            txtQuantity.TabIndex = 8;
            // 
            // txtSellPrice
            // 
            txtSellPrice.BorderStyle = BorderStyle.FixedSingle;
            txtSellPrice.Cursor = Cursors.Hand;
            txtSellPrice.Font = new Font("Poppins", 9F);
            txtSellPrice.Location = new Point(135, 322);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(252, 25);
            txtSellPrice.TabIndex = 9;
            // 
            // cbCategory
            // 
            cbCategory.Cursor = Cursors.Hand;
            cbCategory.Font = new Font("Poppins", 9F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(135, 148);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(252, 30);
            cbCategory.TabIndex = 10;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Cursor = Cursors.Hand;
            dtPickerMfgDate.Font = new Font("Poppins", 9F);
            dtPickerMfgDate.Location = new Point(135, 189);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(252, 25);
            dtPickerMfgDate.TabIndex = 11;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Cursor = Cursors.Hand;
            dtPickerExpDate.Font = new Font("Poppins", 9F);
            dtPickerExpDate.Location = new Point(135, 233);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(252, 25);
            dtPickerExpDate.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 11.25F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(404, 72);
            label9.Name = "label9";
            label9.Size = new Size(98, 26);
            label9.TabIndex = 14;
            label9.Text = "Description";
            // 
            // richTxtDescription
            // 
            richTxtDescription.BorderStyle = BorderStyle.FixedSingle;
            richTxtDescription.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTxtDescription.Location = new Point(404, 107);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(273, 194);
            richTxtDescription.TabIndex = 15;
            richTxtDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 11.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 72);
            label8.Name = "label8";
            label8.Size = new Size(90, 26);
            label8.TabIndex = 17;
            label8.Text = "Product ID";
            // 
            // txtProductId
            // 
            txtProductId.BorderStyle = BorderStyle.FixedSingle;
            txtProductId.Cursor = Cursors.Hand;
            txtProductId.Font = new Font("Poppins", 9F);
            txtProductId.Location = new Point(135, 72);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(252, 25);
            txtProductId.TabIndex = 18;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(556, 319);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(121, 46);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(429, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 46);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(689, 395);
            Controls.Add(btnCancel);
            Controls.Add(txtProductId);
            Controls.Add(label8);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(label9);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Product";
            Load += frmAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private Label label9;
        private RichTextBox richTxtDescription;
        private Label label8;
        private TextBox txtProductId;
        private Button btnAddProduct;
        private Button btnCancel;
    }
}
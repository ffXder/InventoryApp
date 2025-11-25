namespace Inventory
{
    partial class FrmInventory
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
            gridViewProductList = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnFind = new Button();
            txtFind = new TextBox();
            txtSearch = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnStockOut = new Button();
            numStock = new NumericUpDown();
            btnStockIn = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridViewProductList
            // 
            gridViewProductList.AllowUserToAddRows = false;
            gridViewProductList.AllowUserToDeleteRows = false;
            gridViewProductList.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridViewProductList.DefaultCellStyle = dataGridViewCellStyle5;
            gridViewProductList.EnableHeadersVisualStyles = false;
            gridViewProductList.Location = new Point(200, 142);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridViewProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridViewProductList.Size = new Size(1084, 595);
            gridViewProductList.TabIndex = 0;
            gridViewProductList.CellContentClick += gridViewProductList_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(844, 100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 27);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 12);
            label1.Name = "label1";
            label1.Size = new Size(462, 48);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(23, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(23, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 39);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(23, 138);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 39);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 104);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 6;
            label2.Text = "Find by ID:";
            // 
            // btnFind
            // 
            btnFind.Cursor = Cursors.Hand;
            btnFind.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(443, 100);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 27);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtFind
            // 
            txtFind.Cursor = Cursors.Hand;
            txtFind.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFind.Location = new Point(292, 100);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(131, 27);
            txtFind.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Cursor = Cursors.Hand;
            txtSearch.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(633, 99);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(192, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(554, 102);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 11;
            label3.Text = "Search:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.SteelBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(btnStockOut);
            panel1.Controls.Add(numStock);
            panel1.Controls.Add(btnStockIn);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(-1, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 687);
            panel1.TabIndex = 12;
            // 
            // btnStockOut
            // 
            btnStockOut.BackColor = Color.White;
            btnStockOut.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockOut.Location = new Point(23, 336);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(131, 39);
            btnStockOut.TabIndex = 14;
            btnStockOut.Text = "Stock Out";
            btnStockOut.UseVisualStyleBackColor = false;
            btnStockOut.Click += btnStockOut_Click;
            // 
            // numStock
            // 
            numStock.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numStock.Location = new Point(23, 250);
            numStock.Name = "numStock";
            numStock.Size = new Size(131, 25);
            numStock.TabIndex = 13;
            // 
            // btnStockIn
            // 
            btnStockIn.BackColor = Color.White;
            btnStockIn.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockIn.Location = new Point(23, 291);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(131, 39);
            btnStockIn.TabIndex = 6;
            btnStockIn.Text = "Stock In";
            btnStockIn.UseVisualStyleBackColor = false;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1307, 65);
            panel2.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1243, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1306, 749);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(txtFind);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(gridViewProductList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += FrmInventory_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridViewProductList;
        private Button btnRefresh;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label2;
        private Button btnFind;
        private TextBox txtFind;
        private TextBox txtSearch;
        private Label label3;
        private Panel panel1;
        private Button btnStockIn;
        private NumericUpDown numStock;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnStockOut;
    }
}
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
            gridViewProductList = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnFind = new Button();
            txtBoxFind = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(22, 187);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(662, 329);
            gridViewProductList.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(702, 243);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Inventory System";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(42, 61);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(172, 61);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.Location = new Point(319, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 39);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 143);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Find by ID:";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(232, 139);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtBoxFind
            // 
            txtBoxFind.Location = new Point(126, 140);
            txtBoxFind.Name = "txtBoxFind";
            txtBoxFind.Size = new Size(100, 23);
            txtBoxFind.TabIndex = 9;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(txtBoxFind);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(gridViewProductList);
            Name = "FrmInventory";
            Text = "FrmInventory";
            Load += FrmInventory_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
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
        private TextBox txtBoxFind;
    }
}
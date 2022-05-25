namespace FinalSE
{
    partial class formExport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdReceipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMethods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colIDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "XUẤT HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdReceipt,
            this.colDateOrder,
            this.colStatus,
            this.colPayMethods,
            this.colSumPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // colIdReceipt
            // 
            this.colIdReceipt.HeaderText = "Mã đơn hàng";
            this.colIdReceipt.Name = "colIdReceipt";
            // 
            // colDateOrder
            // 
            this.colDateOrder.HeaderText = "Ngày đặt hàng";
            this.colDateOrder.Name = "colDateOrder";
            this.colDateOrder.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colPayMethods
            // 
            this.colPayMethods.HeaderText = "Phương thức thanh toán";
            this.colPayMethods.Name = "colPayMethods";
            this.colPayMethods.Width = 150;
            // 
            // colSumPrice
            // 
            this.colSumPrice.HeaderText = "Thành tiền";
            this.colSumPrice.Name = "colSumPrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách đơn đặt hàng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProduct,
            this.colNameProduct,
            this.colQuantity,
            this.colPrice,
            this.colSum});
            this.dataGridView2.Location = new System.Drawing.Point(12, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // colIDProduct
            // 
            this.colIDProduct.HeaderText = "Mã đơn hàng";
            this.colIDProduct.Name = "colIDProduct";
            // 
            // colNameProduct
            // 
            this.colNameProduct.HeaderText = "Tên sản phẩm";
            this.colNameProduct.Name = "colNameProduct";
            this.colNameProduct.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.Name = "colQuantity";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.Name = "colPrice";
            // 
            // colSum
            // 
            this.colSum.HeaderText = "Thành tiền";
            this.colSum.Name = "colSum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi tiết đơn hàng";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(351, 464);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(106, 39);
            this.btnPrintReceipt.TabIndex = 6;
            this.btnPrintReceipt.Text = "Xuất đơn";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "formExport";
            this.Text = "formExport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayMethods;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSumPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnBack;
    }
}
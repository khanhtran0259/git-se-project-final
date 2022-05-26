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
            this.dgrvList = new System.Windows.Forms.DataGridView();
            this.colIdReceipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMethods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaystt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrvDetail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.colIDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDetail)).BeginInit();
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
            // dgrvList
            // 
            this.dgrvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdReceipt,
            this.colDateOrder,
            this.colStatus,
            this.colSumPrice,
            this.colPayMethods,
            this.colPaystt});
            this.dgrvList.Location = new System.Drawing.Point(3, 97);
            this.dgrvList.Name = "dgrvList";
            this.dgrvList.RowHeadersWidth = 51;
            this.dgrvList.Size = new System.Drawing.Size(846, 150);
            this.dgrvList.TabIndex = 2;
            this.dgrvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvList_CellClick);
            this.dgrvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colIdReceipt
            // 
            this.colIdReceipt.DataPropertyName = "Id";
            this.colIdReceipt.HeaderText = "Mã đơn hàng";
            this.colIdReceipt.MinimumWidth = 6;
            this.colIdReceipt.Name = "colIdReceipt";
            this.colIdReceipt.Width = 95;
            // 
            // colDateOrder
            // 
            this.colDateOrder.DataPropertyName = "Date";
            this.colDateOrder.HeaderText = "Ngày đặt hàng";
            this.colDateOrder.MinimumWidth = 6;
            this.colDateOrder.Name = "colDateOrder";
            this.colDateOrder.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colSumPrice
            // 
            this.colSumPrice.HeaderText = "Thành tiền";
            this.colSumPrice.MinimumWidth = 6;
            this.colSumPrice.Name = "colSumPrice";
            this.colSumPrice.Width = 125;
            // 
            // colPayMethods
            // 
            this.colPayMethods.DataPropertyName = "PaymentMethod";
            this.colPayMethods.HeaderText = "Phương thức thanh toán";
            this.colPayMethods.MinimumWidth = 6;
            this.colPayMethods.Name = "colPayMethods";
            this.colPayMethods.Width = 120;
            // 
            // colPaystt
            // 
            this.colPaystt.DataPropertyName = "PaymentStatus";
            this.colPaystt.HeaderText = "Thanh toán";
            this.colPaystt.Name = "colPaystt";
            this.colPaystt.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách đơn đặt hàng";
            // 
            // dgrvDetail
            // 
            this.dgrvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProduct,
            this.colNameProduct,
            this.colQuantity,
            this.colPrice,
            this.colSum});
            this.dgrvDetail.Location = new System.Drawing.Point(12, 300);
            this.dgrvDetail.Name = "dgrvDetail";
            this.dgrvDetail.RowHeadersWidth = 51;
            this.dgrvDetail.Size = new System.Drawing.Size(802, 150);
            this.dgrvDetail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi tiết đơn hàng";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(480, 476);
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
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(152, 476);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(126, 39);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Xác nhận đơn hàng";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(21, 21);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateList.TabIndex = 15;
            this.btnUpdateList.Text = "Cập nhật danh sách";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // colIDProduct
            // 
            this.colIDProduct.DataPropertyName = "Id";
            this.colIDProduct.HeaderText = "Mã đơn hàng";
            this.colIDProduct.MinimumWidth = 6;
            this.colIDProduct.Name = "colIDProduct";
            this.colIDProduct.Width = 125;
            // 
            // colNameProduct
            // 
            this.colNameProduct.DataPropertyName = "Name";
            this.colNameProduct.HeaderText = "Tên sản phẩm";
            this.colNameProduct.MinimumWidth = 6;
            this.colNameProduct.Name = "colNameProduct";
            this.colNameProduct.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colSum
            // 
            this.colSum.DataPropertyName = "total";
            this.colSum.HeaderText = "Thành tiền";
            this.colSum.MinimumWidth = 6;
            this.colSum.Name = "colSum";
            this.colSum.Width = 125;
            // 
            // formExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 527);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgrvDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrvList);
            this.Controls.Add(this.label1);
            this.Name = "formExport";
            this.Text = "formExport";
            this.Load += new System.EventHandler(this.formExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrvList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrvDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayMethods;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaystt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
    }
}
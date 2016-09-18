namespace DXApp
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errID = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCustomSearch = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.chDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MintCream;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrder.Location = new System.Drawing.Point(29, 225);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(340, 151);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(24, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Order Manager";
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // errID
            // 
            this.errID.ContainerControl = this;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MintCream;
            this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderDetail.Location = new System.Drawing.Point(420, 122);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.Size = new System.Drawing.Size(446, 226);
            this.dgvOrderDetail.TabIndex = 5;
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            this.dgvOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellDoubleClick);
            this.dgvOrderDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvOrderDetail_CellValidating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MintCream;
            this.label12.Location = new System.Drawing.Point(414, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "Order Detail";
            // 
            // btnCustomSearch
            // 
            this.btnCustomSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnCustomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomSearch.ForeColor = System.Drawing.Color.MintCream;
            this.btnCustomSearch.Location = new System.Drawing.Point(140, 186);
            this.btnCustomSearch.Name = "btnCustomSearch";
            this.btnCustomSearch.Size = new System.Drawing.Size(88, 33);
            this.btnCustomSearch.TabIndex = 14;
            this.btnCustomSearch.Text = "Search";
            this.btnCustomSearch.UseVisualStyleBackColor = false;
            this.btnCustomSearch.Click += new System.EventHandler(this.btnCustomSearch_Click_1);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.MintCream;
            this.lblCustomerName.Location = new System.Drawing.Point(417, 58);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 15);
            this.lblCustomerName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MintCream;
            this.label8.Location = new System.Drawing.Point(44, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "To Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MintCream;
            this.label9.Location = new System.Drawing.Point(44, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Order ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(44, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "From Date";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(168, 94);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(148, 20);
            this.txtSearchByName.TabIndex = 6;
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.Location = new System.Drawing.Point(168, 68);
            this.txtSearchByID.MaxLength = 250;
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(88, 20);
            this.txtSearchByID.TabIndex = 7;
            // 
            // chDateFrom
            // 
            this.chDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDateFrom.Location = new System.Drawing.Point(168, 122);
            this.chDateFrom.Name = "chDateFrom";
            this.chDateFrom.Size = new System.Drawing.Size(148, 20);
            this.chDateFrom.TabIndex = 8;
            // 
            // chDateTo
            // 
            this.chDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDateTo.Location = new System.Drawing.Point(168, 149);
            this.chDateTo.Name = "chDateTo";
            this.chDateTo.Size = new System.Drawing.Size(148, 20);
            this.chDateTo.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MintCream;
            this.lblDate.Location = new System.Drawing.Point(417, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 15);
            this.lblDate.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MintCream;
            this.lblTotal.Location = new System.Drawing.Point(702, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 12;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 402);
            this.Controls.Add(this.btnCustomSearch);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.chDateFrom);
            this.Controls.Add(this.chDateTo);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOrder);
            this.Name = "frmOrder";
            this.Text = "Order Manager";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errID;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCustomSearch;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.DateTimePicker chDateFrom;
        private System.Windows.Forms.DateTimePicker chDateTo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDate;
    }
}
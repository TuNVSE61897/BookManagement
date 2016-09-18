namespace DXApp
{
    partial class BookOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookOrderForm));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomSearch = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderBook = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.errCustomerName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.errOrder = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeColumns = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MintCream;
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(12, 217);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(539, 220);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.btnCustomSearch);
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCustomSearch
            // 
            this.btnCustomSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnCustomSearch.ForeColor = System.Drawing.Color.MintCream;
            this.btnCustomSearch.Location = new System.Drawing.Point(160, 102);
            this.btnCustomSearch.Name = "btnCustomSearch";
            this.btnCustomSearch.Size = new System.Drawing.Size(75, 29);
            this.btnCustomSearch.TabIndex = 3;
            this.btnCustomSearch.Text = "Search";
            this.btnCustomSearch.UseVisualStyleBackColor = false;
            this.btnCustomSearch.Click += new System.EventHandler(this.btnCustomSearch_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(104, 77);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(232, 21);
            this.txtAuthorName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Author Name";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(104, 50);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(232, 21);
            this.txtBookName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(104, 23);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(131, 21);
            this.txtISBN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvOrderBook
            // 
            this.dgvOrderBook.AllowUserToAddRows = false;
            this.dgvOrderBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MintCream;
            this.dgvOrderBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderBook.Location = new System.Drawing.Point(589, 92);
            this.dgvOrderBook.Name = "dgvOrderBook";
            this.dgvOrderBook.Size = new System.Drawing.Size(476, 233);
            this.dgvOrderBook.TabIndex = 3;
            this.dgvOrderBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderBook_CellContentClick);
            this.dgvOrderBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderBook_CellDoubleClick);
            this.dgvOrderBook.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderBook_CellEndEdit);
            this.dgvOrderBook.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvOrderBook_CellValidating);
            this.dgvOrderBook.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvOrderBook_DragOver);
            this.dgvOrderBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOrderBook_KeyDown);
            this.dgvOrderBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvOrderBook_KeyUp);
            this.dgvOrderBook.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvOrderBook_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(593, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Order List";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.SlateGray;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.MintCream;
            this.btnCheckOut.Location = new System.Drawing.Point(727, 400);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(130, 37);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(586, 364);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(774, 364);
            this.txtCustomerName.MaxLength = 250;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(291, 21);
            this.txtCustomerName.TabIndex = 0;
            // 
            // errCustomerName
            // 
            this.errCustomerName.ContainerControl = this;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SlateGray;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.MintCream;
            this.btnRemove.Location = new System.Drawing.Point(974, 52);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 31);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // errOrder
            // 
            this.errOrder.ContainerControl = this;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(939, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : 0";
            // 
            // BookOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 456);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOrderBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBook);
            this.Name = "BookOrderForm";
            this.Text = "Book Order";
            this.Load += new System.EventHandler(this.BookOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustomSearch;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrderBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ErrorProvider errCustomerName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ErrorProvider errOrder;
        private System.Windows.Forms.Label lblTotal;
    }
}
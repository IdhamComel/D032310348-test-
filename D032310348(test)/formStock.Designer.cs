namespace D032310348_test_
{
    partial class formStock
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
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label authorIDLabel;
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label quantityInStockLabel;
            System.Windows.Forms.Label dateRecordedLabel;
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admiralBookstore = new D032310348_test_.AdmiralBookstore();
            this.stockTableAdapter = new D032310348_test_.AdmiralBookstoreTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new D032310348_test_.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.dateRecordedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAuthorS = new System.Windows.Forms.Button();
            this.btnBookS = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            stockIDLabel = new System.Windows.Forms.Label();
            authorIDLabel = new System.Windows.Forms.Label();
            iSBN_13Label = new System.Windows.Forms.Label();
            quantityInStockLabel = new System.Windows.Forms.Label();
            dateRecordedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            this.SuspendLayout();
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(178, 177);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(60, 16);
            stockIDLabel.TabIndex = 1;
            stockIDLabel.Text = "Stock ID:";
            // 
            // authorIDLabel
            // 
            authorIDLabel.AutoSize = true;
            authorIDLabel.Location = new System.Drawing.Point(178, 205);
            authorIDLabel.Name = "authorIDLabel";
            authorIDLabel.Size = new System.Drawing.Size(64, 16);
            authorIDLabel.TabIndex = 3;
            authorIDLabel.Text = "Author ID:";
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(178, 233);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(59, 16);
            iSBN_13Label.TabIndex = 5;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Location = new System.Drawing.Point(178, 261);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new System.Drawing.Size(108, 16);
            quantityInStockLabel.TabIndex = 7;
            quantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // dateRecordedLabel
            // 
            dateRecordedLabel.AutoSize = true;
            dateRecordedLabel.Location = new System.Drawing.Point(178, 290);
            dateRecordedLabel.Name = "dateRecordedLabel";
            dateRecordedLabel.Size = new System.Drawing.Size(103, 16);
            dateRecordedLabel.TabIndex = 9;
            dateRecordedLabel.Text = "Date Recorded:";
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoGenerateColumns = false;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.iSBN13DataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.dateRecordedDataGridViewTextBoxColumn});
            this.dataGridViewStock.DataSource = this.stockBindingSource;
            this.dataGridViewStock.Location = new System.Drawing.Point(45, 34);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(683, 119);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRecordedDataGridViewTextBoxColumn
            // 
            this.dateRecordedDataGridViewTextBoxColumn.DataPropertyName = "DateRecorded";
            this.dateRecordedDataGridViewTextBoxColumn.HeaderText = "DateRecorded";
            this.dateRecordedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRecordedDataGridViewTextBoxColumn.Name = "dateRecordedDataGridViewTextBoxColumn";
            this.dateRecordedDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.admiralBookstore;
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = D032310348_test_.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBoxStock
            // 
            this.textBoxStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "StockID", true));
            this.textBoxStock.Location = new System.Drawing.Point(310, 174);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(303, 22);
            this.textBoxStock.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "AuthorID", true));
            this.textBoxAuthor.Location = new System.Drawing.Point(310, 202);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(303, 22);
            this.textBoxAuthor.TabIndex = 4;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ISBN-13", true));
            this.textBoxISBN.Location = new System.Drawing.Point(310, 230);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(303, 22);
            this.textBoxISBN.TabIndex = 6;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "QuantityInStock", true));
            this.textBoxQuantity.Location = new System.Drawing.Point(310, 258);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(303, 22);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // dateRecordedDateTimePicker
            // 
            this.dateRecordedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stockBindingSource, "DateRecorded", true));
            this.dateRecordedDateTimePicker.Location = new System.Drawing.Point(310, 286);
            this.dateRecordedDateTimePicker.Name = "dateRecordedDateTimePicker";
            this.dateRecordedDateTimePicker.Size = new System.Drawing.Size(303, 22);
            this.dateRecordedDateTimePicker.TabIndex = 10;
            // 
            // btnAuthorS
            // 
            this.btnAuthorS.Location = new System.Drawing.Point(658, 404);
            this.btnAuthorS.Name = "btnAuthorS";
            this.btnAuthorS.Size = new System.Drawing.Size(116, 24);
            this.btnAuthorS.TabIndex = 16;
            this.btnAuthorS.Text = "Form Author";
            this.btnAuthorS.UseVisualStyleBackColor = true;
            this.btnAuthorS.Click += new System.EventHandler(this.btnAuthorS_Click);
            // 
            // btnBookS
            // 
            this.btnBookS.Location = new System.Drawing.Point(658, 374);
            this.btnBookS.Name = "btnBookS";
            this.btnBookS.Size = new System.Drawing.Size(116, 24);
            this.btnBookS.TabIndex = 15;
            this.btnBookS.Text = "Form Book";
            this.btnBookS.UseVisualStyleBackColor = true;
            this.btnBookS.Click += new System.EventHandler(this.btnBookS_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(479, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(321, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 45);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(171, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAuthorS);
            this.Controls.Add(this.btnBookS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(stockIDLabel);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(authorIDLabel);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(quantityInStockLabel);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(dateRecordedLabel);
            this.Controls.Add(this.dateRecordedDateTimePicker);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "formStock";
            this.Text = "Stock Form";
            this.Load += new System.EventHandler(this.formStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private AdmiralBookstoreTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecordedDataGridViewTextBoxColumn;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.DateTimePicker dateRecordedDateTimePicker;
        private System.Windows.Forms.Button btnAuthorS;
        private System.Windows.Forms.Button btnBookS;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}
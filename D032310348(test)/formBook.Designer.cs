namespace D032310348_test_
{
    partial class formBook
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
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label publishDateLabel;
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admiralBookstore = new D032310348_test_.AdmiralBookstore();
            this.bookTableAdapter = new D032310348_test_.AdmiralBookstoreTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new D032310348_test_.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.publishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnStockB = new System.Windows.Forms.Button();
            this.btnAuthorB = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            iSBN_13Label = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(216, 246);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(59, 16);
            iSBN_13Label.TabIndex = 1;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(216, 274);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(216, 302);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(66, 16);
            publisherLabel.TabIndex = 5;
            publisherLabel.Text = "Publisher:";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new System.Drawing.Point(216, 331);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(86, 16);
            publishDateLabel.TabIndex = 7;
            publishDateLabel.Text = "Publish Date:";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBN13DataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn});
            this.dataGridViewBook.DataSource = this.bookBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(72, 27);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 51;
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.Size = new System.Drawing.Size(731, 196);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.admiralBookstore;
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = D032310348_test_.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN-13", true));
            this.textBoxISBN.Location = new System.Drawing.Point(308, 243);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(298, 22);
            this.textBoxISBN.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.textBoxTitle.Location = new System.Drawing.Point(308, 271);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(298, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publisher", true));
            this.textBoxPublisher.Location = new System.Drawing.Point(308, 299);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(298, 22);
            this.textBoxPublisher.TabIndex = 6;
            // 
            // publishDateDateTimePicker
            // 
            this.publishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PublishDate", true));
            this.publishDateDateTimePicker.Location = new System.Drawing.Point(308, 327);
            this.publishDateDateTimePicker.Name = "publishDateDateTimePicker";
            this.publishDateDateTimePicker.Size = new System.Drawing.Size(298, 22);
            this.publishDateDateTimePicker.TabIndex = 8;
            // 
            // btnStockB
            // 
            this.btnStockB.Location = new System.Drawing.Point(673, 447);
            this.btnStockB.Name = "btnStockB";
            this.btnStockB.Size = new System.Drawing.Size(116, 24);
            this.btnStockB.TabIndex = 16;
            this.btnStockB.Text = "Form Stock";
            this.btnStockB.UseVisualStyleBackColor = true;
            this.btnStockB.Click += new System.EventHandler(this.btnStockB_Click);
            // 
            // btnAuthorB
            // 
            this.btnAuthorB.Location = new System.Drawing.Point(673, 417);
            this.btnAuthorB.Name = "btnAuthorB";
            this.btnAuthorB.Size = new System.Drawing.Size(116, 24);
            this.btnAuthorB.TabIndex = 15;
            this.btnAuthorB.Text = "Form Author";
            this.btnAuthorB.UseVisualStyleBackColor = true;
            this.btnAuthorB.Click += new System.EventHandler(this.btnAuthorB_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(494, 382);
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
            this.btnUpdate.Location = new System.Drawing.Point(336, 382);
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
            this.btnAdd.Location = new System.Drawing.Point(186, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 492);
            this.Controls.Add(this.btnStockB);
            this.Controls.Add(this.btnAuthorB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(this.publishDateDateTimePicker);
            this.Controls.Add(this.dataGridViewBook);
            this.Name = "formBook";
            this.Text = "Book Form";
            this.Load += new System.EventHandler(this.formBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private AdmiralBookstoreTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.DateTimePicker publishDateDateTimePicker;
        private System.Windows.Forms.Button btnStockB;
        private System.Windows.Forms.Button btnAuthorB;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}
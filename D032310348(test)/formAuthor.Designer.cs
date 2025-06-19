namespace D032310348_test_
{
    partial class formAuthor
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
            System.Windows.Forms.Label authorIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthYearLabel;
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBookA = new System.Windows.Forms.Button();
            this.btnStockA = new System.Windows.Forms.Button();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admiralBookstore = new D032310348_test_.AdmiralBookstore();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorTableAdapter = new D032310348_test_.AdmiralBookstoreTableAdapters.AuthorTableAdapter();
            this.tableAdapterManager = new D032310348_test_.AdmiralBookstoreTableAdapters.TableAdapterManager();
            authorIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.AutoGenerateColumns = false;
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn});
            this.dataGridViewAuthor.DataSource = this.authorBindingSource;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(94, 32);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowHeadersWidth = 51;
            this.dataGridViewAuthor.RowTemplate.Height = 24;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(625, 213);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // authorIDLabel
            // 
            authorIDLabel.AutoSize = true;
            authorIDLabel.Location = new System.Drawing.Point(229, 268);
            authorIDLabel.Name = "authorIDLabel";
            authorIDLabel.Size = new System.Drawing.Size(64, 16);
            authorIDLabel.TabIndex = 1;
            authorIDLabel.Text = "Author ID:";
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "AuthorID", true));
            this.textBoxAuthorID.Location = new System.Drawing.Point(303, 265);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(226, 22);
            this.textBoxAuthorID.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(229, 296);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(303, 293);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(226, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Location = new System.Drawing.Point(229, 324);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new System.Drawing.Size(68, 16);
            birthYearLabel.TabIndex = 5;
            birthYearLabel.Text = "Birth Year:";
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "BirthYear", true));
            this.textBoxBirth.Location = new System.Drawing.Point(303, 321);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.Size = new System.Drawing.Size(226, 22);
            this.textBoxBirth.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(174, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(324, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 45);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(482, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBookA
            // 
            this.btnBookA.Location = new System.Drawing.Point(661, 410);
            this.btnBookA.Name = "btnBookA";
            this.btnBookA.Size = new System.Drawing.Size(116, 24);
            this.btnBookA.TabIndex = 10;
            this.btnBookA.Text = "Form Book";
            this.btnBookA.UseVisualStyleBackColor = true;
            this.btnBookA.Click += new System.EventHandler(this.btnBookA_Click);
            // 
            // btnStockA
            // 
            this.btnStockA.Location = new System.Drawing.Point(661, 440);
            this.btnStockA.Name = "btnStockA";
            this.btnStockA.Size = new System.Drawing.Size(116, 24);
            this.btnStockA.TabIndex = 11;
            this.btnStockA.Text = "Form Stock";
            this.btnStockA.UseVisualStyleBackColor = true;
            this.btnStockA.Click += new System.EventHandler(this.btnStockA_Click);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.admiralBookstore;
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = this.authorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = D032310348_test_.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 492);
            this.Controls.Add(this.btnStockA);
            this.Controls.Add(this.btnBookA);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(authorIDLabel);
            this.Controls.Add(this.textBoxAuthorID);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(birthYearLabel);
            this.Controls.Add(this.textBoxBirth);
            this.Controls.Add(this.dataGridViewAuthor);
            this.Name = "formAuthor";
            this.Text = "Author Form";
            this.Load += new System.EventHandler(this.formAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private AdmiralBookstoreTableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBirth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBookA;
        private System.Windows.Forms.Button btnStockA;
    }
}


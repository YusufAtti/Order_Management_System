namespace Order_Management_System
{
    partial class OrderForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOupdate = new System.Windows.Forms.Button();
            this.btnODelete = new System.Windows.Forms.Button();
            this.btnOAdd = new System.Windows.Forms.Button();
            this.btnOlist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPpiece = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCusId = new System.Windows.Forms.ComboBox();
            this.cmbProdctId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Castomer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order ID:";
            // 
            // txtOid
            // 
            this.txtOid.Enabled = false;
            this.txtOid.Location = new System.Drawing.Point(145, 256);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(112, 22);
            this.txtOid.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 194);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnOupdate
            // 
            this.btnOupdate.Location = new System.Drawing.Point(583, 389);
            this.btnOupdate.Name = "btnOupdate";
            this.btnOupdate.Size = new System.Drawing.Size(135, 37);
            this.btnOupdate.TabIndex = 21;
            this.btnOupdate.Text = "UPDATE";
            this.btnOupdate.UseVisualStyleBackColor = true;
            // 
            // btnODelete
            // 
            this.btnODelete.Location = new System.Drawing.Point(583, 340);
            this.btnODelete.Name = "btnODelete";
            this.btnODelete.Size = new System.Drawing.Size(135, 37);
            this.btnODelete.TabIndex = 20;
            this.btnODelete.Text = "DELETE";
            this.btnODelete.UseVisualStyleBackColor = true;
            // 
            // btnOAdd
            // 
            this.btnOAdd.Location = new System.Drawing.Point(583, 291);
            this.btnOAdd.Name = "btnOAdd";
            this.btnOAdd.Size = new System.Drawing.Size(135, 37);
            this.btnOAdd.TabIndex = 19;
            this.btnOAdd.Text = "ADD";
            this.btnOAdd.UseVisualStyleBackColor = true;
            this.btnOAdd.Click += new System.EventHandler(this.btnOAdd_Click);
            // 
            // btnOlist
            // 
            this.btnOlist.Location = new System.Drawing.Point(583, 240);
            this.btnOlist.Name = "btnOlist";
            this.btnOlist.Size = new System.Drawing.Size(135, 37);
            this.btnOlist.TabIndex = 18;
            this.btnOlist.Text = "LIST";
            this.btnOlist.UseVisualStyleBackColor = true;
            this.btnOlist.Click += new System.EventHandler(this.btnOlist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pieces: ";
            // 
            // txtPpiece
            // 
            this.txtPpiece.Location = new System.Drawing.Point(145, 386);
            this.txtPpiece.Name = "txtPpiece";
            this.txtPpiece.Size = new System.Drawing.Size(112, 22);
            this.txtPpiece.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(371, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // cmbCusId
            // 
            this.cmbCusId.FormattingEnabled = true;
            this.cmbCusId.Location = new System.Drawing.Point(145, 320);
            this.cmbCusId.Name = "cmbCusId";
            this.cmbCusId.Size = new System.Drawing.Size(371, 24);
            this.cmbCusId.TabIndex = 25;
            // 
            // cmbProdctId
            // 
            this.cmbProdctId.FormattingEnabled = true;
            this.cmbProdctId.Location = new System.Drawing.Point(145, 353);
            this.cmbProdctId.Name = "cmbProdctId";
            this.cmbProdctId.Size = new System.Drawing.Size(371, 24);
            this.cmbProdctId.TabIndex = 26;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 516);
            this.Controls.Add(this.cmbProdctId);
            this.Controls.Add(this.cmbCusId);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPpiece);
            this.Controls.Add(this.btnOupdate);
            this.Controls.Add(this.btnODelete);
            this.Controls.Add(this.btnOAdd);
            this.Controls.Add(this.btnOlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOid);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOupdate;
        private System.Windows.Forms.Button btnODelete;
        private System.Windows.Forms.Button btnOAdd;
        private System.Windows.Forms.Button btnOlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPpiece;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbCusId;
        private System.Windows.Forms.ComboBox cmbProdctId;
    }
}
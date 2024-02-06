namespace Order_Management_System
{
    partial class CustomerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCsurname = new System.Windows.Forms.TextBox();
            this.txtCcity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClist = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnCupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtCid
            // 
            this.txtCid.Enabled = false;
            this.txtCid.Location = new System.Drawing.Point(161, 274);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 22);
            this.txtCid.TabIndex = 1;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(161, 315);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 22);
            this.txtCname.TabIndex = 2;
            // 
            // txtCsurname
            // 
            this.txtCsurname.Location = new System.Drawing.Point(161, 356);
            this.txtCsurname.Name = "txtCsurname";
            this.txtCsurname.Size = new System.Drawing.Size(100, 22);
            this.txtCsurname.TabIndex = 3;
            // 
            // txtCcity
            // 
            this.txtCcity.Location = new System.Drawing.Point(161, 396);
            this.txtCcity.Name = "txtCcity";
            this.txtCcity.Size = new System.Drawing.Size(100, 22);
            this.txtCcity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "City: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname: ";
            // 
            // btnClist
            // 
            this.btnClist.Location = new System.Drawing.Point(307, 267);
            this.btnClist.Name = "btnClist";
            this.btnClist.Size = new System.Drawing.Size(135, 37);
            this.btnClist.TabIndex = 9;
            this.btnClist.Text = "LIST";
            this.btnClist.UseVisualStyleBackColor = true;
            this.btnClist.Click += new System.EventHandler(this.btnClist_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(307, 318);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(135, 37);
            this.btnCAdd.TabIndex = 10;
            this.btnCAdd.Text = "ADD";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.Location = new System.Drawing.Point(307, 367);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(135, 37);
            this.btnCDelete.TabIndex = 11;
            this.btnCDelete.Text = "DELETE";
            this.btnCDelete.UseVisualStyleBackColor = true;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnCupdate
            // 
            this.btnCupdate.Location = new System.Drawing.Point(307, 416);
            this.btnCupdate.Name = "btnCupdate";
            this.btnCupdate.Size = new System.Drawing.Size(135, 37);
            this.btnCupdate.TabIndex = 12;
            this.btnCupdate.Text = "UPDATE";
            this.btnCupdate.UseVisualStyleBackColor = true;
            this.btnCupdate.Click += new System.EventHandler(this.btnCupdate_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnCupdate);
            this.Controls.Add(this.btnCDelete);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.btnClist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCcity);
            this.Controls.Add(this.txtCsurname);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCsurname;
        private System.Windows.Forms.TextBox txtCcity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClist;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Button btnCupdate;
    }
}
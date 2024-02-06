namespace Order_Management_System
{
    partial class ProductForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.btnPlist = new System.Windows.Forms.Button();
            this.btnPupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product ID:";
            // 
            // txtPprice
            // 
            this.txtPprice.Location = new System.Drawing.Point(159, 354);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(100, 22);
            this.txtPprice.TabIndex = 10;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(159, 313);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(100, 22);
            this.txtPName.TabIndex = 9;
            // 
            // txtPid
            // 
            this.txtPid.Enabled = false;
            this.txtPid.Location = new System.Drawing.Point(159, 272);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(100, 22);
            this.txtPid.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 194);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnPDelete
            // 
            this.btnPDelete.Location = new System.Drawing.Point(313, 343);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(135, 37);
            this.btnPDelete.TabIndex = 17;
            this.btnPDelete.Text = "DELETE";
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.Location = new System.Drawing.Point(313, 294);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(135, 37);
            this.btnPAdd.TabIndex = 16;
            this.btnPAdd.Text = "ADD";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // btnPlist
            // 
            this.btnPlist.Location = new System.Drawing.Point(313, 243);
            this.btnPlist.Name = "btnPlist";
            this.btnPlist.Size = new System.Drawing.Size(135, 37);
            this.btnPlist.TabIndex = 15;
            this.btnPlist.Text = "LIST";
            this.btnPlist.UseVisualStyleBackColor = true;
            this.btnPlist.Click += new System.EventHandler(this.btnPlist_Click);
            // 
            // btnPupdate
            // 
            this.btnPupdate.Location = new System.Drawing.Point(313, 393);
            this.btnPupdate.Name = "btnPupdate";
            this.btnPupdate.Size = new System.Drawing.Size(135, 37);
            this.btnPupdate.TabIndex = 18;
            this.btnPupdate.Text = "UPDATE";
            this.btnPupdate.UseVisualStyleBackColor = true;
            this.btnPupdate.Click += new System.EventHandler(this.btnPupdate_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPupdate);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.btnPAdd);
            this.Controls.Add(this.btnPlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPid);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button btnPlist;
        private System.Windows.Forms.Button btnPupdate;
    }
}
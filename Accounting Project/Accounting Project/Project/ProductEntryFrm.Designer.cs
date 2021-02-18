
namespace Accounting_Project.Project
{
    partial class ProductEntryFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ID_tx = new System.Windows.Forms.TextBox();
            this.ProductName_tx = new System.Windows.Forms.TextBox();
            this.Save_bt = new System.Windows.Forms.Button();
            this.Update_bt = new System.Windows.Forms.Button();
            this.Close_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rate_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MRP_tx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // ID_tx
            // 
            this.ID_tx.Location = new System.Drawing.Point(12, 347);
            this.ID_tx.Name = "ID_tx";
            this.ID_tx.Size = new System.Drawing.Size(122, 20);
            this.ID_tx.TabIndex = 3;
            this.ID_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_tx_KeyPress);
            // 
            // ProductName_tx
            // 
            this.ProductName_tx.Location = new System.Drawing.Point(178, 347);
            this.ProductName_tx.Name = "ProductName_tx";
            this.ProductName_tx.Size = new System.Drawing.Size(122, 20);
            this.ProductName_tx.TabIndex = 4;
            this.ProductName_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductName_tx_KeyPress);
            // 
            // Save_bt
            // 
            this.Save_bt.Location = new System.Drawing.Point(12, 403);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(101, 35);
            this.Save_bt.TabIndex = 5;
            this.Save_bt.Text = "Save";
            this.Save_bt.UseVisualStyleBackColor = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // Update_bt
            // 
            this.Update_bt.Location = new System.Drawing.Point(178, 403);
            this.Update_bt.Name = "Update_bt";
            this.Update_bt.Size = new System.Drawing.Size(101, 35);
            this.Update_bt.TabIndex = 6;
            this.Update_bt.Text = "Update";
            this.Update_bt.UseVisualStyleBackColor = true;
            this.Update_bt.Click += new System.EventHandler(this.Update_bt_Click);
            // 
            // Close_bt
            // 
            this.Close_bt.Location = new System.Drawing.Point(506, 403);
            this.Close_bt.Name = "Close_bt";
            this.Close_bt.Size = new System.Drawing.Size(101, 35);
            this.Close_bt.TabIndex = 7;
            this.Close_bt.Text = "Close";
            this.Close_bt.UseVisualStyleBackColor = true;
            this.Close_bt.Click += new System.EventHandler(this.Close_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(606, 300);
            this.dataGridView1.TabIndex = 8;
            // 
            // Rate_tx
            // 
            this.Rate_tx.Location = new System.Drawing.Point(340, 347);
            this.Rate_tx.Name = "Rate_tx";
            this.Rate_tx.Size = new System.Drawing.Size(122, 20);
            this.Rate_tx.TabIndex = 10;
            this.Rate_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rate_tx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 10);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rate";
            // 
            // MRP_tx
            // 
            this.MRP_tx.Location = new System.Drawing.Point(485, 347);
            this.MRP_tx.Name = "MRP_tx";
            this.MRP_tx.Size = new System.Drawing.Size(122, 20);
            this.MRP_tx.TabIndex = 12;
            this.MRP_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MRP_tx_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MRP";
            // 
            // Delete_bt
            // 
            this.Delete_bt.Location = new System.Drawing.Point(340, 403);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(101, 35);
            this.Delete_bt.TabIndex = 13;
            this.Delete_bt.Text = "Delete";
            this.Delete_bt.UseVisualStyleBackColor = true;
            this.Delete_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // ProductEntryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.Delete_bt);
            this.Controls.Add(this.MRP_tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rate_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Close_bt);
            this.Controls.Add(this.Update_bt);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.ProductName_tx);
            this.Controls.Add(this.ID_tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductEntryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductEntryFrm";
            this.Load += new System.EventHandler(this.ProductEntryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_tx;
        private System.Windows.Forms.TextBox ProductName_tx;
        private System.Windows.Forms.Button Save_bt;
        private System.Windows.Forms.Button Update_bt;
        private System.Windows.Forms.Button Close_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Rate_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MRP_tx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete_bt;
    }
}
namespace WindowsFormsApp1
{
    partial class Products
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbExpDate = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(153, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(153, 81);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 20);
            this.tbDescription.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(27, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(27, 81);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(60, 13);
            this.lbDesc.TabIndex = 4;
            this.lbDesc.Text = "Description";
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(27, 122);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(61, 13);
            this.lbExpDate.TabIndex = 5;
            this.lbExpDate.Text = "Expiry Date";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(132, 177);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(30, 246);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(323, 264);
            this.listBoxItems.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 531);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbExpDate);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Name = "Products";
            this.Text = "Proizvodi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbExpDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


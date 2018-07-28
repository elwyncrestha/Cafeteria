namespace Cafeteria
{
    partial class DynamicForm
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
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstTotal = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Items";
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Items.AddRange(new object[] {
            "Momo",
            "Chowmein",
            "Pizza",
            "Coke"});
            this.cboItem.Location = new System.Drawing.Point(132, 37);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(121, 21);
            this.cboItem.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(16, 203);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(75, 108);
            this.lstItem.TabIndex = 3;
            this.lstItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstItem_Keydown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grand Total";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(282, 335);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(13, 13);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "0";
            // 
            // lstQty
            // 
            this.lstQty.FormattingEnabled = true;
            this.lstQty.Location = new System.Drawing.Point(135, 203);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(47, 108);
            this.lstQty.TabIndex = 6;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(204, 203);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(49, 108);
            this.lstPrice.TabIndex = 7;
            // 
            // lstTotal
            // 
            this.lstTotal.FormattingEnabled = true;
            this.lstTotal.Location = new System.Drawing.Point(285, 203);
            this.lstTotal.Name = "lstTotal";
            this.lstTotal.Size = new System.Drawing.Size(49, 108);
            this.lstTotal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(132, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "QTY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(201, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(282, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(14, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "No. of Items";
            // 
            // txtNoItems
            // 
            this.txtNoItems.Location = new System.Drawing.Point(130, 81);
            this.txtNoItems.Name = "txtNoItems";
            this.txtNoItems.Size = new System.Drawing.Size(123, 20);
            this.txtNoItems.TabIndex = 14;
            // 
            // DynamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 387);
            this.Controls.Add(this.txtNoItems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTotal);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstQty);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.label1);
            this.Name = "DynamicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DynamicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.ListBox lstQty;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoItems;
    }
}
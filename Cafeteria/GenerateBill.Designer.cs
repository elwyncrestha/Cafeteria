namespace Cafeteria
{
    partial class GenerateBill
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblTea = new System.Windows.Forms.Label();
            this.lblMomo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCoffee = new System.Windows.Forms.TextBox();
            this.txtTea = new System.Windows.Forms.TextBox();
            this.txtMomo = new System.Windows.Forms.TextBox();
            this.MyCafe = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscount1 = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.rdoPercentage = new System.Windows.Forms.RadioButton();
            this.rdoFlat = new System.Windows.Forms.RadioButton();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblVatAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.MyCafe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(19, 57);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(38, 13);
            this.lblCoffee.TabIndex = 2;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblTea
            // 
            this.lblTea.AutoSize = true;
            this.lblTea.Location = new System.Drawing.Point(19, 88);
            this.lblTea.Name = "lblTea";
            this.lblTea.Size = new System.Drawing.Size(26, 13);
            this.lblTea.TabIndex = 3;
            this.lblTea.Text = "Tea";
            // 
            // lblMomo
            // 
            this.lblMomo.AutoSize = true;
            this.lblMomo.Location = new System.Drawing.Point(19, 117);
            this.lblMomo.Name = "lblMomo";
            this.lblMomo.Size = new System.Drawing.Size(39, 13);
            this.lblMomo.TabIndex = 4;
            this.lblMomo.Text = "Mo mo";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtCoffee
            // 
            this.txtCoffee.Location = new System.Drawing.Point(115, 50);
            this.txtCoffee.Name = "txtCoffee";
            this.txtCoffee.Size = new System.Drawing.Size(100, 20);
            this.txtCoffee.TabIndex = 6;
            // 
            // txtTea
            // 
            this.txtTea.Location = new System.Drawing.Point(115, 81);
            this.txtTea.Name = "txtTea";
            this.txtTea.Size = new System.Drawing.Size(100, 20);
            this.txtTea.TabIndex = 7;
            // 
            // txtMomo
            // 
            this.txtMomo.Location = new System.Drawing.Point(115, 110);
            this.txtMomo.Name = "txtMomo";
            this.txtMomo.Size = new System.Drawing.Size(100, 20);
            this.txtMomo.TabIndex = 8;
            // 
            // MyCafe
            // 
            this.MyCafe.Controls.Add(this.btnGenerate);
            this.MyCafe.Controls.Add(this.lblName);
            this.MyCafe.Controls.Add(this.txtMomo);
            this.MyCafe.Controls.Add(this.lblCoffee);
            this.MyCafe.Controls.Add(this.txtTea);
            this.MyCafe.Controls.Add(this.lblTea);
            this.MyCafe.Controls.Add(this.txtCoffee);
            this.MyCafe.Controls.Add(this.lblMomo);
            this.MyCafe.Controls.Add(this.txtName);
            this.MyCafe.Location = new System.Drawing.Point(12, 12);
            this.MyCafe.Name = "MyCafe";
            this.MyCafe.Size = new System.Drawing.Size(271, 210);
            this.MyCafe.TabIndex = 9;
            this.MyCafe.TabStop = false;
            this.MyCafe.Text = "MyCafe";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(115, 154);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 31);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiscountAmount);
            this.groupBox1.Controls.Add(this.lblDiscount1);
            this.groupBox1.Controls.Add(this.lblNetAmount);
            this.groupBox1.Controls.Add(this.txtDiscountAmount);
            this.groupBox1.Controls.Add(this.rdoPercentage);
            this.groupBox1.Controls.Add(this.rdoFlat);
            this.groupBox1.Controls.Add(this.lblNetTotal);
            this.groupBox1.Controls.Add(this.lblVatAmount);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.lblVat);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Location = new System.Drawing.Point(336, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(336, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(103, 116);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(13, 13);
            this.lblDiscountAmount.TabIndex = 12;
            this.lblDiscountAmount.Text = "0";
            // 
            // lblDiscount1
            // 
            this.lblDiscount1.AutoSize = true;
            this.lblDiscount1.Location = new System.Drawing.Point(7, 116);
            this.lblDiscount1.Name = "lblDiscount1";
            this.lblDiscount1.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount1.TabIndex = 11;
            this.lblDiscount1.Text = "Discount";
            this.lblDiscount1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Location = new System.Drawing.Point(103, 193);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(13, 13);
            this.lblNetAmount.TabIndex = 10;
            this.lblNetAmount.Text = "0";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(106, 77);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmount.TabIndex = 8;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.txtDiscountAmount_TextChanged);
            // 
            // rdoPercentage
            // 
            this.rdoPercentage.AutoSize = true;
            this.rdoPercentage.Location = new System.Drawing.Point(227, 50);
            this.rdoPercentage.Name = "rdoPercentage";
            this.rdoPercentage.Size = new System.Drawing.Size(33, 17);
            this.rdoPercentage.TabIndex = 7;
            this.rdoPercentage.TabStop = true;
            this.rdoPercentage.Text = "%";
            this.rdoPercentage.UseVisualStyleBackColor = true;
            // 
            // rdoFlat
            // 
            this.rdoFlat.AutoSize = true;
            this.rdoFlat.Location = new System.Drawing.Point(106, 51);
            this.rdoFlat.Name = "rdoFlat";
            this.rdoFlat.Size = new System.Drawing.Size(42, 17);
            this.rdoFlat.TabIndex = 6;
            this.rdoFlat.TabStop = true;
            this.rdoFlat.Text = "Flat";
            this.rdoFlat.UseVisualStyleBackColor = true;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Location = new System.Drawing.Point(6, 193);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(51, 13);
            this.lblNetTotal.TabIndex = 5;
            this.lblNetTotal.Text = "Net Total";
            // 
            // lblVatAmount
            // 
            this.lblVatAmount.AutoSize = true;
            this.lblVatAmount.Location = new System.Drawing.Point(103, 149);
            this.lblVatAmount.Name = "lblVatAmount";
            this.lblVatAmount.Size = new System.Drawing.Size(13, 13);
            this.lblVatAmount.TabIndex = 4;
            this.lblVatAmount.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(103, 26);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(6, 56);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(6, 149);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(54, 13);
            this.lblVat.TabIndex = 1;
            this.lblVat.Text = "VAT(13%)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // GenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MyCafe);
            this.Name = "GenerateBill";
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.GenerateBill_Load);
            this.MyCafe.ResumeLayout(false);
            this.MyCafe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblTea;
        private System.Windows.Forms.Label lblMomo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCoffee;
        private System.Windows.Forms.TextBox txtTea;
        private System.Windows.Forms.TextBox txtMomo;
        private System.Windows.Forms.GroupBox MyCafe;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.RadioButton rdoPercentage;
        private System.Windows.Forms.RadioButton rdoFlat;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblVatAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblDiscount1;
    }
}


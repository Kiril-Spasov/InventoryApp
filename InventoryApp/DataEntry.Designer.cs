namespace InventoryApp
{
    partial class DataEntry
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
            this.CboPartNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RdoBtnSmall = new System.Windows.Forms.RadioButton();
            this.RdoBtnMedium = new System.Windows.Forms.RadioButton();
            this.RdoBtnLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboPartNumber
            // 
            this.CboPartNumber.FormattingEnabled = true;
            this.CboPartNumber.Items.AddRange(new object[] {
            "1001",
            "2002",
            "3003",
            "4004",
            "5005",
            "6006",
            "7007",
            "8008",
            "9009",
            "9876"});
            this.CboPartNumber.Location = new System.Drawing.Point(51, 69);
            this.CboPartNumber.Name = "CboPartNumber";
            this.CboPartNumber.Size = new System.Drawing.Size(202, 24);
            this.CboPartNumber.TabIndex = 0;
            this.CboPartNumber.Validating += new System.ComponentModel.CancelEventHandler(this.CboPartNumber_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Part Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Size";
            // 
            // RdoBtnSmall
            // 
            this.RdoBtnSmall.AutoSize = true;
            this.RdoBtnSmall.Location = new System.Drawing.Point(6, 21);
            this.RdoBtnSmall.Name = "RdoBtnSmall";
            this.RdoBtnSmall.Size = new System.Drawing.Size(62, 20);
            this.RdoBtnSmall.TabIndex = 3;
            this.RdoBtnSmall.TabStop = true;
            this.RdoBtnSmall.Text = "Small";
            this.RdoBtnSmall.UseVisualStyleBackColor = true;
            // 
            // RdoBtnMedium
            // 
            this.RdoBtnMedium.AutoSize = true;
            this.RdoBtnMedium.Location = new System.Drawing.Point(6, 57);
            this.RdoBtnMedium.Name = "RdoBtnMedium";
            this.RdoBtnMedium.Size = new System.Drawing.Size(76, 20);
            this.RdoBtnMedium.TabIndex = 4;
            this.RdoBtnMedium.TabStop = true;
            this.RdoBtnMedium.Text = "Medium";
            this.RdoBtnMedium.UseVisualStyleBackColor = true;
            // 
            // RdoBtnLarge
            // 
            this.RdoBtnLarge.AutoSize = true;
            this.RdoBtnLarge.Location = new System.Drawing.Point(6, 96);
            this.RdoBtnLarge.Name = "RdoBtnLarge";
            this.RdoBtnLarge.Size = new System.Drawing.Size(63, 20);
            this.RdoBtnLarge.TabIndex = 5;
            this.RdoBtnLarge.TabStop = true;
            this.RdoBtnLarge.Text = "Large";
            this.RdoBtnLarge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoBtnLarge);
            this.groupBox1.Controls.Add(this.RdoBtnMedium);
            this.groupBox1.Controls.Add(this.RdoBtnSmall);
            this.groupBox1.Location = new System.Drawing.Point(51, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(51, 370);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(219, 22);
            this.TxtQuantity.TabIndex = 8;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
            this.TxtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.TxtQuantity_Validating);
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(56, 438);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(145, 45);
            this.BtnOK.TabIndex = 9;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(289, 438);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 45);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 525);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboPartNumber);
            this.Name = "DataEntry";
            this.Text = "Data Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboPartNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdoBtnSmall;
        private System.Windows.Forms.RadioButton RdoBtnMedium;
        private System.Windows.Forms.RadioButton RdoBtnLarge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}
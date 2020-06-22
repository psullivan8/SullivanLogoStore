namespace SullivanLogoStore
{
    partial class LogoItemOrderForm
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
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtNumItems = new System.Windows.Forms.TextBox();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.lblEngrave = new System.Windows.Forms.Label();
            this.txtEngrave = new System.Windows.Forms.TextBox();
            this.ckbxLogo = new System.Windows.Forms.CheckBox();
            this.txtNumColors = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.gbxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.lblOrderNum.Location = new System.Drawing.Point(12, 9);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(90, 17);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Number";
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.lblNumItems.Location = new System.Drawing.Point(12, 40);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(103, 17);
            this.lblNumItems.TabIndex = 1;
            this.lblNumItems.Text = "Number of Items";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(150, 7);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(169, 20);
            this.txtOrderNum.TabIndex = 2;
            this.txtOrderNum.TextChanged += new System.EventHandler(this.txtOrderNum_TextChanged);
            // 
            // txtNumItems
            // 
            this.txtNumItems.Location = new System.Drawing.Point(150, 38);
            this.txtNumItems.Name = "txtNumItems";
            this.txtNumItems.Size = new System.Drawing.Size(169, 20);
            this.txtNumItems.TabIndex = 3;
            this.txtNumItems.TextChanged += new System.EventHandler(this.txtNumItems_TextChanged);
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbPen);
            this.gbxType.Controls.Add(this.rbMug);
            this.gbxType.Controls.Add(this.rbUSB);
            this.gbxType.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.gbxType.Location = new System.Drawing.Point(150, 67);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(169, 109);
            this.gbxType.TabIndex = 4;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Item Type";
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(7, 80);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(47, 21);
            this.rbPen.TabIndex = 2;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Location = new System.Drawing.Point(7, 52);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(52, 21);
            this.rbMug.TabIndex = 1;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            this.rbMug.CheckedChanged += new System.EventHandler(this.rbMug_CheckedChanged);
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(7, 24);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(49, 21);
            this.rbUSB.TabIndex = 0;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            this.rbUSB.CheckedChanged += new System.EventHandler(this.rbUSB_CheckedChanged);
            // 
            // lblEngrave
            // 
            this.lblEngrave.AutoSize = true;
            this.lblEngrave.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.lblEngrave.Location = new System.Drawing.Point(25, 171);
            this.lblEngrave.Name = "lblEngrave";
            this.lblEngrave.Size = new System.Drawing.Size(132, 17);
            this.lblEngrave.TabIndex = 5;
            this.lblEngrave.Text = "Text to engrave/print:";
            // 
            // txtEngrave
            // 
            this.txtEngrave.Location = new System.Drawing.Point(15, 191);
            this.txtEngrave.Multiline = true;
            this.txtEngrave.Name = "txtEngrave";
            this.txtEngrave.Size = new System.Drawing.Size(304, 65);
            this.txtEngrave.TabIndex = 6;
            this.txtEngrave.TextChanged += new System.EventHandler(this.txtEngrave_TextChanged);
            // 
            // ckbxLogo
            // 
            this.ckbxLogo.AutoSize = true;
            this.ckbxLogo.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.ckbxLogo.Location = new System.Drawing.Point(157, 258);
            this.ckbxLogo.Name = "ckbxLogo";
            this.ckbxLogo.Size = new System.Drawing.Size(60, 21);
            this.ckbxLogo.TabIndex = 7;
            this.ckbxLogo.Text = "Logo?";
            this.ckbxLogo.UseVisualStyleBackColor = true;
            this.ckbxLogo.CheckedChanged += new System.EventHandler(this.ckbxLogo_CheckedChanged);
            // 
            // txtNumColors
            // 
            this.txtNumColors.Location = new System.Drawing.Point(157, 280);
            this.txtNumColors.Name = "txtNumColors";
            this.txtNumColors.Size = new System.Drawing.Size(162, 20);
            this.txtNumColors.TabIndex = 8;
            this.txtNumColors.Visible = false;
            this.txtNumColors.TextChanged += new System.EventHandler(this.txtNumColors_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.lblColor.Location = new System.Drawing.Point(42, 282);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(109, 17);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Number of Colors:";
            this.lblColor.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.btnSubmit.Location = new System.Drawing.Point(55, 310);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.btnClear.Location = new System.Drawing.Point(203, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(15, 348);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(304, 78);
            this.txtSummary.TabIndex = 12;
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged);
            // 
            // LogoItemOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(331, 438);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtNumColors);
            this.Controls.Add(this.ckbxLogo);
            this.Controls.Add(this.txtEngrave);
            this.Controls.Add(this.lblEngrave);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.txtNumItems);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.lblNumItems);
            this.Controls.Add(this.lblOrderNum);
            this.Name = "LogoItemOrderForm";
            this.Text = "Form1";
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtNumItems;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbMug;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.Label lblEngrave;
        private System.Windows.Forms.TextBox txtEngrave;
        private System.Windows.Forms.CheckBox ckbxLogo;
        private System.Windows.Forms.TextBox txtNumColors;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSummary;
    }
}


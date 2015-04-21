namespace CISK343Assignment5DavePollard
{
    partial class Form1
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
            this.grpShow = new System.Windows.Forms.GroupBox();
            this.radMatinee = new System.Windows.Forms.RadioButton();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkChild = new System.Windows.Forms.CheckBox();
            this.chkVeteran = new System.Windows.Forms.CheckBox();
            this.chkSenior = new System.Windows.Forms.CheckBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpShow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShow
            // 
            this.grpShow.Controls.Add(this.radMatinee);
            this.grpShow.Controls.Add(this.radRegular);
            this.grpShow.Location = new System.Drawing.Point(53, 77);
            this.grpShow.Name = "grpShow";
            this.grpShow.Size = new System.Drawing.Size(106, 76);
            this.grpShow.TabIndex = 0;
            this.grpShow.TabStop = false;
            this.grpShow.Text = "Show";
            // 
            // radMatinee
            // 
            this.radMatinee.AutoSize = true;
            this.radMatinee.Location = new System.Drawing.Point(7, 43);
            this.radMatinee.Name = "radMatinee";
            this.radMatinee.Size = new System.Drawing.Size(77, 17);
            this.radMatinee.TabIndex = 1;
            this.radMatinee.Text = "matinee $8";
            this.radMatinee.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Location = new System.Drawing.Point(6, 19);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(78, 17);
            this.radRegular.TabIndex = 0;
            this.radRegular.Text = "regular $10";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChild);
            this.groupBox1.Controls.Add(this.chkVeteran);
            this.groupBox1.Controls.Add(this.chkSenior);
            this.groupBox1.Location = new System.Drawing.Point(211, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discounts";
            // 
            // chkChild
            // 
            this.chkChild.AutoSize = true;
            this.chkChild.Location = new System.Drawing.Point(7, 65);
            this.chkChild.Name = "chkChild";
            this.chkChild.Size = new System.Drawing.Size(70, 17);
            this.chkChild.TabIndex = 2;
            this.chkChild.Text = "Child - $1";
            this.chkChild.UseVisualStyleBackColor = true;
            // 
            // chkVeteran
            // 
            this.chkVeteran.AutoSize = true;
            this.chkVeteran.Location = new System.Drawing.Point(7, 41);
            this.chkVeteran.Name = "chkVeteran";
            this.chkVeteran.Size = new System.Drawing.Size(84, 17);
            this.chkVeteran.TabIndex = 1;
            this.chkVeteran.Text = "Veteran - $2";
            this.chkVeteran.UseVisualStyleBackColor = true;
            // 
            // chkSenior
            // 
            this.chkSenior.AutoSize = true;
            this.chkSenior.Location = new System.Drawing.Point(6, 17);
            this.chkSenior.Name = "chkSenior";
            this.chkSenior.Size = new System.Drawing.Size(77, 17);
            this.chkSenior.TabIndex = 0;
            this.chkSenior.Text = "Senior - $1";
            this.chkSenior.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(380, 79);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(383, 96);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 3;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add ticket to Total";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(202, 242);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 37);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "ShowTotal";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(361, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Total";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 365);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpShow);
            this.Name = "Form1";
            this.Text = "Purchase Ticket";
            this.grpShow.ResumeLayout(false);
            this.grpShow.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShow;
        private System.Windows.Forms.RadioButton radMatinee;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkChild;
        private System.Windows.Forms.CheckBox chkVeteran;
        private System.Windows.Forms.CheckBox chkSenior;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
    }
}


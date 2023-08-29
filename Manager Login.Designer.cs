
namespace System_for_a_food_city.cs
{
    partial class Manager_Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCashierName = new System.Windows.Forms.TextBox();
            this.txtmanagerpassword = new System.Windows.Forms.TextBox();
            this.btnCashierBack = new System.Windows.Forms.Button();
            this.btnCashierLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::System_for_a_food_city.cs.Properties.Resources.super;
            this.pictureBox1.Location = new System.Drawing.Point(185, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 246);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manager Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // txtCashierName
            // 
            this.txtCashierName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierName.Location = new System.Drawing.Point(472, 328);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.Size = new System.Drawing.Size(509, 45);
            this.txtCashierName.TabIndex = 7;
            // 
            // txtmanagerpassword
            // 
            this.txtmanagerpassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanagerpassword.Location = new System.Drawing.Point(472, 435);
            this.txtmanagerpassword.Name = "txtmanagerpassword";
            this.txtmanagerpassword.PasswordChar = '*';
            this.txtmanagerpassword.Size = new System.Drawing.Size(509, 45);
            this.txtmanagerpassword.TabIndex = 8;
            this.txtmanagerpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCashierBack
            // 
            this.btnCashierBack.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierBack.Location = new System.Drawing.Point(126, 528);
            this.btnCashierBack.Name = "btnCashierBack";
            this.btnCashierBack.Size = new System.Drawing.Size(285, 76);
            this.btnCashierBack.TabIndex = 9;
            this.btnCashierBack.Text = "Back";
            this.btnCashierBack.UseVisualStyleBackColor = true;
            this.btnCashierBack.Click += new System.EventHandler(this.btnCashierBack_Click);
            // 
            // btnCashierLogin
            // 
            this.btnCashierLogin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierLogin.Location = new System.Drawing.Point(797, 519);
            this.btnCashierLogin.Name = "btnCashierLogin";
            this.btnCashierLogin.Size = new System.Drawing.Size(285, 76);
            this.btnCashierLogin.TabIndex = 10;
            this.btnCashierLogin.Text = "Login";
            this.btnCashierLogin.UseVisualStyleBackColor = true;
            this.btnCashierLogin.Click += new System.EventHandler(this.btnCashierLogin_Click);
            // 
            // Manager_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1238, 625);
            this.Controls.Add(this.btnCashierLogin);
            this.Controls.Add(this.btnCashierBack);
            this.Controls.Add(this.txtmanagerpassword);
            this.Controls.Add(this.txtCashierName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Manager_Login";
            this.Text = "Manager_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCashierName;
        private System.Windows.Forms.TextBox txtmanagerpassword;
        private System.Windows.Forms.Button btnCashierBack;
        private System.Windows.Forms.Button btnCashierLogin;
    }
}

namespace System_for_a_food_city.cs
{
    partial class Manager_Password
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
            this.txtmanagerpassword = new System.Windows.Forms.TextBox();
            this.btnItemsBack = new System.Windows.Forms.Button();
            this.btnCashierLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::System_for_a_food_city.cs.Properties.Resources.super;
            this.pictureBox1.Location = new System.Drawing.Point(123, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 246);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manager Password";
            // 
            // txtmanagerpassword
            // 
            this.txtmanagerpassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanagerpassword.Location = new System.Drawing.Point(530, 345);
            this.txtmanagerpassword.Name = "txtmanagerpassword";
            this.txtmanagerpassword.PasswordChar = '*';
            this.txtmanagerpassword.Size = new System.Drawing.Size(400, 45);
            this.txtmanagerpassword.TabIndex = 7;
            // 
            // btnItemsBack
            // 
            this.btnItemsBack.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsBack.Location = new System.Drawing.Point(133, 488);
            this.btnItemsBack.Name = "btnItemsBack";
            this.btnItemsBack.Size = new System.Drawing.Size(285, 76);
            this.btnItemsBack.TabIndex = 20;
            this.btnItemsBack.Text = "Back";
            this.btnItemsBack.UseVisualStyleBackColor = true;
            this.btnItemsBack.Click += new System.EventHandler(this.btnItemsBack_Click);
            // 
            // btnCashierLogin
            // 
            this.btnCashierLogin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierLogin.Location = new System.Drawing.Point(645, 488);
            this.btnCashierLogin.Name = "btnCashierLogin";
            this.btnCashierLogin.Size = new System.Drawing.Size(285, 76);
            this.btnCashierLogin.TabIndex = 21;
            this.btnCashierLogin.Text = "Login";
            this.btnCashierLogin.UseVisualStyleBackColor = true;
            this.btnCashierLogin.Click += new System.EventHandler(this.btnCashierLogin_Click);
            // 
            // Manager_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1139, 615);
            this.Controls.Add(this.btnCashierLogin);
            this.Controls.Add(this.btnItemsBack);
            this.Controls.Add(this.txtmanagerpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Manager_Password";
            this.Text = "Manager_Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanagerpassword;
        private System.Windows.Forms.Button btnItemsBack;
        private System.Windows.Forms.Button btnCashierLogin;
    }
}
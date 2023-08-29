
namespace System_for_a_food_city.cs
{
    partial class Cashier_log_out
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
            this.btnCashierLogin = new System.Windows.Forms.Button();
            this.btnItemsBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::System_for_a_food_city.cs.Properties.Resources.super;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 246);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Have A nice Day";
            // 
            // btnCashierLogin
            // 
            this.btnCashierLogin.BackColor = System.Drawing.Color.LightCoral;
            this.btnCashierLogin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierLogin.Location = new System.Drawing.Point(1102, 540);
            this.btnCashierLogin.Name = "btnCashierLogin";
            this.btnCashierLogin.Size = new System.Drawing.Size(285, 76);
            this.btnCashierLogin.TabIndex = 8;
            this.btnCashierLogin.Text = "Login";
            this.btnCashierLogin.UseVisualStyleBackColor = false;
            this.btnCashierLogin.Click += new System.EventHandler(this.btnCashierLogin_Click);
            // 
            // btnItemsBack
            // 
            this.btnItemsBack.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnItemsBack.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnItemsBack.Location = new System.Drawing.Point(12, 540);
            this.btnItemsBack.Name = "btnItemsBack";
            this.btnItemsBack.Size = new System.Drawing.Size(285, 76);
            this.btnItemsBack.TabIndex = 10;
            this.btnItemsBack.Text = "Back";
            this.btnItemsBack.UseVisualStyleBackColor = false;
            this.btnItemsBack.Click += new System.EventHandler(this.btnItemsellBack_Click);
            // 
            // Cashier_log_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::System_for_a_food_city.cs.Properties.Resources.cashier;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 628);
            this.Controls.Add(this.btnItemsBack);
            this.Controls.Add(this.btnCashierLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cashier_log_out";
            this.Text = "Cashier_log_out";
            this.Load += new System.EventHandler(this.Cashier_log_out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCashierLogin;
        private System.Windows.Forms.Button btnItemsBack;
    }
}
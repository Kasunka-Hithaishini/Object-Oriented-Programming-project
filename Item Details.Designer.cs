
namespace System_for_a_food_city.cs
{
    partial class Item_Details
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
            this.btnItemsBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idetail = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::System_for_a_food_city.cs.Properties.Resources.super;
            this.pictureBox1.Location = new System.Drawing.Point(236, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 246);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnItemsBack
            // 
            this.btnItemsBack.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsBack.Location = new System.Drawing.Point(1104, 131);
            this.btnItemsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItemsBack.Name = "btnItemsBack";
            this.btnItemsBack.Size = new System.Drawing.Size(285, 76);
            this.btnItemsBack.TabIndex = 19;
            this.btnItemsBack.Text = "Item Selling";
            this.btnItemsBack.UseVisualStyleBackColor = true;
            this.btnItemsBack.Click += new System.EventHandler(this.btnItemsBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1104, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 76);
            this.button1.TabIndex = 20;
            this.button1.Text = "MDetails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idetail
            // 
            this.idetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idetail.Location = new System.Drawing.Point(34, 336);
            this.idetail.Name = "idetail";
            this.idetail.RowHeadersWidth = 51;
            this.idetail.RowTemplate.Height = 24;
            this.idetail.Size = new System.Drawing.Size(1013, 182);
            this.idetail.TabIndex = 21;
            this.idetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.idetail_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1091, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 65);
            this.button2.TabIndex = 22;
            this.button2.Text = "Show Item Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Item_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1401, 703);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idetail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnItemsBack);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Item_Details";
            this.Text = "Item_Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnItemsBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView idetail;
        private System.Windows.Forms.Button button2;
    }
}
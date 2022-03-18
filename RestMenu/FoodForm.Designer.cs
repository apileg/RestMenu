namespace RestMenu
{
    partial class FoodForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodItem4 = new RestMenu.FoodItem();
            this.foodItem3 = new RestMenu.FoodItem();
            this.foodItem2 = new RestMenu.FoodItem();
            this.foodItem1 = new RestMenu.FoodItem();
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.ValueText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.bBacket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.foodItem4);
            this.panel1.Controls.Add(this.foodItem3);
            this.panel1.Controls.Add(this.foodItem2);
            this.panel1.Controls.Add(this.foodItem1);
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.bNext);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 327);
            this.panel1.TabIndex = 9;
            // 
            // foodItem4
            // 
            this.foodItem4.Food = null;
            this.foodItem4.Location = new System.Drawing.Point(403, 168);
            this.foodItem4.Name = "foodItem4";
            this.foodItem4.Size = new System.Drawing.Size(291, 149);
            this.foodItem4.TabIndex = 42;
            // 
            // foodItem3
            // 
            this.foodItem3.Food = null;
            this.foodItem3.Location = new System.Drawing.Point(65, 169);
            this.foodItem3.Name = "foodItem3";
            this.foodItem3.Size = new System.Drawing.Size(291, 149);
            this.foodItem3.TabIndex = 41;
            // 
            // foodItem2
            // 
            this.foodItem2.Food = null;
            this.foodItem2.Location = new System.Drawing.Point(403, 14);
            this.foodItem2.Name = "foodItem2";
            this.foodItem2.Size = new System.Drawing.Size(291, 149);
            this.foodItem2.TabIndex = 40;
            // 
            // foodItem1
            // 
            this.foodItem1.Food = null;
            this.foodItem1.Location = new System.Drawing.Point(65, 14);
            this.foodItem1.Name = "foodItem1";
            this.foodItem1.Size = new System.Drawing.Size(291, 149);
            this.foodItem1.TabIndex = 39;
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(14, 11);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(45, 301);
            this.bBack.TabIndex = 38;
            this.bBack.Text = "<";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNext
            // 
            this.bNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNext.Location = new System.Drawing.Point(706, 14);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(45, 301);
            this.bNext.TabIndex = 37;
            this.bNext.Text = ">";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButtonBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 38);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(15, 14);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonBack.BackgroundImage = global::RestMenu.Properties.Resources.icon_back;
            this.toolStripButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButtonBack.Image = global::RestMenu.Properties.Resources.icon_back;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 35);
            this.toolStripButtonBack.Text = "Назад";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // ValueText
            // 
            this.ValueText.AutoSize = true;
            this.ValueText.BackColor = System.Drawing.Color.Transparent;
            this.ValueText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ValueText.Location = new System.Drawing.Point(670, 8);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(19, 20);
            this.ValueText.TabIndex = 12;
            this.ValueText.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // bBacket
            // 
            this.bBacket.BackColor = System.Drawing.Color.Transparent;
            this.bBacket.BackgroundImage = global::RestMenu.Properties.Resources.shopping_basket;
            this.bBacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bBacket.FlatAppearance.BorderSize = 0;
            this.bBacket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bBacket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bBacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBacket.ForeColor = System.Drawing.Color.Black;
            this.bBacket.Location = new System.Drawing.Point(710, 0);
            this.bBacket.Name = "bBacket";
            this.bBacket.Size = new System.Drawing.Size(32, 36);
            this.bBacket.TabIndex = 11;
            this.bBacket.UseVisualStyleBackColor = false;
            this.bBacket.Click += new System.EventHandler(this.bBacket_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::RestMenu.Properties.Resources.bgShop;
            this.ClientSize = new System.Drawing.Size(769, 357);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.bBacket);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FoodForm";
            this.Text = "Food";
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        public System.Windows.Forms.Button bBack;
        public System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bBacket;
        private System.Windows.Forms.Label ValueText;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FoodItem foodItem4;
        private FoodItem foodItem3;
        private FoodItem foodItem2;
        private FoodItem foodItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
namespace RestMenu
{
    partial class FoodItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BuyButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.CountUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(155, 122);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(128, 23);
            this.BuyButton.TabIndex = 29;
            this.BuyButton.Text = "Купить";
            this.toolTip1.SetToolTip(this.BuyButton, "Для завершения покупки нажмите на корзину");
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(6, 125);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(96, 18);
            this.countLabel.TabIndex = 28;
            this.countLabel.Text = "Количество:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceLabel.Location = new System.Drawing.Point(102, 86);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 18);
            this.PriceLabel.TabIndex = 27;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Enabled = false;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(155, 23);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(128, 95);
            this.DescriptionTextBox.TabIndex = 26;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(152, 4);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(132, 16);
            this.headerLabel.TabIndex = 25;
            this.headerLabel.Text = "Описание блюда";
            // 
            // CountUpDown
            // 
            this.CountUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUpDown.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CountUpDown.Location = new System.Drawing.Point(108, 125);
            this.CountUpDown.Name = "CountUpDown";
            this.CountUpDown.Size = new System.Drawing.Size(37, 21);
            this.CountUpDown.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Подсказка.";
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Location = new System.Drawing.Point(8, 6);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(140, 112);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 30;
            this.PictureBox.TabStop = false;
            // 
            // FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.CountUpDown);
            this.Controls.Add(this.PictureBox);
            this.Name = "FoodItem";
            this.Size = new System.Drawing.Size(291, 149);
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.Button BuyButton;
        public System.Windows.Forms.TextBox DescriptionTextBox;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.NumericUpDown CountUpDown;
        public System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

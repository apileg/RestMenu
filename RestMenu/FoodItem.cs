using System;
using System.Windows.Forms;

namespace RestMenu
{
    public partial class FoodItem : UserControl
    {
        private Food food;

        public Food Food
        {
            get
            {
                return food;
            }

            set
            {
                food = value;

                if (food != null)
                {
                    PictureBox.Image = food.Image;

                    DescriptionTextBox.Lines = new string[]
                    {
                        food.Description,
                        $"Вес: {food.Weight} г."
                    };

                    PriceLabel.Text = $"{food.Price}₴";

                    CountUpDown.Value = food.Count;
                }
                else
                {
                    PictureBox.Image = null;
                    DescriptionTextBox.Text = "";
                    PriceLabel.Text = "";

                    CountUpDown.Value = 0;
                }
            }
        }

        public FoodItem()
        {
            InitializeComponent();

            food = null;
            CountUpDown.ValueChanged += CountUpDown_ValueChanged;
        }

        private void CountUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (food != null)
            {
                food.Count = Convert.ToInt32(CountUpDown.Value);
            }        
        }
    }
}

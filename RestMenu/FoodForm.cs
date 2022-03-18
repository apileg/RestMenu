using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestMenu
{
    /* После прочтения убрать все комментарии 
     * со звездочками, как в этом.
     */

    public partial class FoodForm : Form
    {
        private List<FoodItem> foodItems;

        private List<Food> foods;
        private int fistFoodOnPageIndex;
        
        public FoodForm(List<Food> foods)
        {
            InitializeComponent();

            // Все элементы foodItems помещаются в список,
            //чтобы по ним можно было прохожить в цикле.
            foodItems = new List<FoodItem>()
            {
                foodItem1, foodItem2, foodItem3, foodItem4
            };

            //Еда тоже помещается в список.
            //Индекс первого продукта на странице сохраняется.
            this.foods = foods;
            fistFoodOnPageIndex = 0;

            foreach (var item in foodItems)
            {
                //Подписываем действие купить на BuyButton_Click (FoodItem)
                /* P.S. это ясно и без комментария. */
                item.BuyButton.Click += BuyButton_Click;
            }

            FillItems();
        }


        private void FillItems()
        {
            int foodItemIndex = 0;

            // Нужно заполнить foodItems едой, начиная с первой на страничке. 
            // При этом на странице может быть меньше, чем 4 продукта.
            for (int foodIndex = fistFoodOnPageIndex; foodIndex < foods.Count; ++foodIndex)
            {
                foodItems[foodItemIndex].Food = foods[foodIndex];

                // После заполнения нужно перейти к следующему продукту.
                ++foodItemIndex;

                // Если все элементы заполнены, то выйти из цикла.
                if (foodItemIndex >= foodItems.Count) 
                {
                    break;
                }
            }
        }


        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.FormClosed += (s, args) => this.Close();

            this.Hide();
            menu.Show();
        }

        public void bNext_Click(object sender, EventArgs e)
        {
            //Нужно перейти на следующую страницу.
            // При этом нужно не выходить за пределы списка: 
            //на след. страницу перейти не удастся, если больше нет еды.
            if (fistFoodOnPageIndex + foodItems.Count <= foods.Count - 1)                                                   
            {
                fistFoodOnPageIndex += foodItems.Count;

                ClearItems();
                FillItems();
            }
        }

        private void ClearItems()
        {
            foreach (var foodItem in foodItems)
            {
                foodItem.Food = null;
            }
        }

        // Подписываем действие на нажатие клавиши BuyButton_Click (FoodItem)
        /* P.S. это снова ясно и без комментария. */

        /* Нужно выбрать один стиль названия кнопок и их обработчиков.
         * У тебя есть обработчик bNext_Click и кнопка bNext - один стиль названия.
         * Но у тебя также есть обработчик BuyButton_Click и кнопка
         * BuyButton в FoodItem - другой стиль названия 
         * (возможно, это я так назвал кнопку в FoodItem).
         * Нужно либо назвать все кнопки либо форме bNext, bBuy, 
         * либо в форме NextButton, BuyButton, но не смешивать стили. 
         * Выбери стиль, который ты предпочитаешь.
         * Разговор на эту тему здесь: https://stackoverflow.com/a/1349294/12983861
         */

        private void BuyButton_Click(object sender, EventArgs e) 
        {
            ValueText.Text = CountProducts().ToString();
        }


        /* Старое название: CountOfProducts().
         * Обычно методы называют глаголами, ведь они выполняют действия.
         */

        public int CountProducts()
        {
            int count = 0;

            foreach (var item in foods)
            {
                count += item.Count;
            }

            return count;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (fistFoodOnPageIndex - foodItems.Count >= 0)
            {
                fistFoodOnPageIndex -= foodItems.Count;

                ClearItems();
                FillItems();
            }
        }


        private void bBacket_Click(object sender, EventArgs e)
        {
            if (CountProducts() == 0)
            {
                MessageBox.Show("Вы не добавили ни одного товара.", "Ошибка");
            }
            else
            {
                //Создаем форму для чека, но не привязываем обработчик к событию
                //receipt.FormClosed. Вместо этого передаем чеку ссылку на эту
                //форму.
                //Чек либо закроет эту форму (пользователь купил еду) либо
                //покажет ее (пользователь нажал на кнопку "Назад").
                Receipt receipt = new Receipt(this, ChooseFoodForReceipt());

                this.Hide();
                receipt.Show();
            }
        }

        private List<Food> ChooseFoodForReceipt()
        {
            List<Food> choosedFood = new List<Food>();

            foreach (var food in foods)
            {
                if (food.Count > 0)
                {
                    choosedFood.Add(food);
                }
            }

            return choosedFood;
        }
    }
}

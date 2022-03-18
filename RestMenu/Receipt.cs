using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestMenu
{
    /* После прочтения убрать все комментарии 
     * со звездочками, как в этом.
     */

    public partial class Receipt : Form
    {
        private List<Food> choosedFoods;

        //Сохраняем ссылку на предыдущую форму c едой.
        private FoodForm foodForm;

        //true, если при закрытии чека нужно вернутся на foodForm.
        private bool returnToFoodForm;

        public Receipt(FoodForm foodForm, List<Food> choosedFoods)
        {
            InitializeComponent();

            this.foodForm = foodForm;
            returnToFoodForm = false;

            this.FormClosing += Receipt_FormClosing;

            this.choosedFoods = choosedFoods;

            foreach (var food in choosedFoods)
            {
                    var lw = listView.Items.Add($"{food.Name}");
                    lw.SubItems.Add($"{food.Description}");
                    lw.SubItems.Add($"{food.Count} шт.");
                    lw.SubItems.Add($"{food.Price}₴");
            }

            Indent();
            MakePriceRow();

            SetTotalPrice(CountTotalPrice());
        }

        public void Indent()
        {
            var indent = listView.Items.Add("-------------------------------------------");

            indent.SubItems.Add("-----------------------------------------------");
            indent.SubItems.Add("----------------------------------------------");
            indent.SubItems.Add("---------------------------------");
        }

        private void MakePriceRow()
        {
            var priceRow = listView.Items.Add(new ListViewItem()
            {
                Name = "priceRow", Text = ""
            });

            priceRow.SubItems.Add("");
            priceRow.SubItems.Add("");

            priceRow.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "totalPrice"
            });
        }

        private void SetTotalPrice(double count)
        {
            listView.Items["priceRow"].SubItems["totalPrice"].Text = $"Всего: {count}";
        }

        private double CountTotalPrice()
        {
            double count = 0.0;

            foreach (var food in choosedFoods)
            {
                count += food.Price * food.Count;
            }

            return count;
        }

        /* Что за toolStripButton1? */
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Возвращаемся на предыдущую форму с едой.
            returnToFoodForm = true;
            this.Close();
        }

        /* А toolStripLabel1? */
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        /* Почему Click_1, а не Click? */
        private void bReceipt_Click_1(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void CloseApplication()
        {
            MessageBox.Show("Спасибо за заказ!");

            //Закрываем все приложение - не возвращаемся на форму с едой.
            returnToFoodForm = false;
            this.Close();
        }

        private void Receipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Когда чек закрывается, определяем, возвращатся ли на форму с едой,
            //или закрывать приложение.
            if (returnToFoodForm)
            {
                foodForm.Show();
            }
            else
            {
                foodForm.Close();
            }
        }

        /* Еще есть toolStripButton2? */
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in listView.SelectedItems)
            {
                var items = listView.Items;   

                choosedFoods.RemoveAt(items.IndexOf(listViewItem));
                items.Remove(listViewItem);
            }

            SetTotalPrice(CountTotalPrice());
        }

        /* Если одна строка не вмещается в экран, то можно ее перенести.
         * Есть некоторые детали переноса: например, как разбивать большое математическое
         * выражение. Могу рассказать, как я разбиваю строки кода, а можешь почитать
         * об этом сам.
         * Кстати, почему listView1? Что за 1?
         */
        private void listView1_ItemSelectionChanged(object sender, 
                                                   ListViewItemSelectionChangedEventArgs e)
        {
            if (e.ItemIndex >= listView.Items.Count - 2)
                e.Item.Selected = false;
        }
    }
}

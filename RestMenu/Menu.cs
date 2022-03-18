using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestMenu
{
    public partial class Menu : Form
    {
        private List<Food> sushi;
        private List<Food> rolls;
        private List<Food> sets;
        private List<Food> noodles;
        private List<Food> snacks;
        private List<Food> shef;

        public Menu()
        {
            InitializeComponent();

            sushi = new List<Food>();
                                                                                          // Weight, Price
            sushi.Add(new Food(Properties.Resources.Sushi_Ika,"Суши Ика.","Суши с кальмаром.", 35, 17));
            sushi.Add(new Food(Properties.Resources.Sushi_Ebi, "Суши Еби.", "Суши с тигровой криветкой.", 40, 36));
            sushi.Add(new Food(Properties.Resources.Sushi_Unagi, "Суши Унаги.", "Суши с угрем.", 35, 39));
            sushi.Add(new Food(Properties.Resources.Sushi_Maguro, "Суши Магуро.", "Суши с тунцом.", 35, 27));
            sushi.Add(new Food(Properties.Resources.Sushi_SpiceKani, "Суши острые Кани.", "Острые суши гункан с крабом", 40, 26));


            rolls = new List<Food>();

            rolls.Add(new Food(Properties.Resources.Roll_Sonata, "Ролл Соната.", "Ролл с угрем, огурцом, сливочным сыром и кунжутом.", 28, 13));
            rolls.Add(new Food(Properties.Resources.Roll_SouthSea, "Ролл Южное море.", "Ролл с кальмаром, икрой тобико, сливочным сыром, огурцом и салатом чука.", 32.5, 11));
            rolls.Add(new Food(Properties.Resources.Roll_Tofubruk, "Ролл Туфубрук.", "Тофу, водоросли нори, икра тобико, Филе курицы и огурец.", 27.5, 11));
            rolls.Add(new Food(Properties.Resources.Roll_Tokyo, "Ролл Токи.", "Ролл с лососем, авокадо, сливочным сыром, рисом и водорослями нори.", 31, 11));
            rolls.Add(new Food(Properties.Resources.Roll_Combo, "Ролл Комбо.", "Ролл с креветками, лососем, икрой тобико, снежным крабом, мягким сыром, огурцом, рисом и водорослями нори.", 35, 16));
            rolls.Add(new Food(Properties.Resources.Roll_SyakeAvokado, "Ролл Сяке Авокадо.", "Ролл с лососем и авокадо", 29, 9));

            rolls.Add(new Food(Properties.Resources.Roll_NewYork, "Ролл Нью-Йорк.", "Ролл с лососем, икрой тобико и снежным крабом.", 21, 3.5));
            rolls.Add(new Food(Properties.Resources.Roll_Sea, "Ролл Морской.", "Ролл с лососем, огурцом, сливочным сыром и икрой тобико.", 43, 18.5));
            rolls.Add(new Food(Properties.Resources.Roll_Sevilia, "Ролл Севилия.", "Ролл с телапии, жареной в унаги соусе, снежным крабом, сливочным сыром, огурцом, рисом и водорослями нори.", 29, 9));
            rolls.Add(new Food(Properties.Resources.Roll_Summer, "Ролл Летний.", "Ролл с кальмаром, икрой тобико, сливочным сыром, огурцом и салатом чука.", 26, 7));

            sets = new List<Food>();

            sets.Add(new Food(Properties.Resources.Sets_Hot, "Сет Горячий.", "Горячая тропиканка, Дакота ролл, Итальянский ролл, Кантри Хот, Фурай.", 1360, 345));
            sets.Add(new Food(Properties.Resources.Sets_Tempura, "Сет Темпура", "Гранада ролл, Чикен Хот, Джингл, Севилья ролл, Токио ролл.", 1130, 349));
            sets.Add(new Food(Properties.Resources.Sets_Summer, "Сет Летний.", "Алабама ролл, Колорадо ролл, Авокадо ролл, Хияши Унаги ролл, Гринвич.", 1040, 327));
            sets.Add(new Food(Properties.Resources.Sets_Hawaiian, "Сет Гавайский.", "Бразильский ролл, Гейша ролл, Алабама ролл, Колорадо ролл, Хияши Унаги.", 2260, 720));
            sets.Add(new Food(Properties.Resources.Sets_AristokratVIP, "Сет Аристократ VIP.", "Алабама ролл, Дракон ролл, Калифорния, Мексиканский ролл, Хияши Унаги.", 2595, 810));
            sets.Add(new Food(Properties.Resources.Sets_Sushi, "Сет Суши.", "Суши Сяке, Суши Унаги, Суши Магуро, Суши Ика.", 450, 291));
            sets.Add(new Food(Properties.Resources.Sets_LasVegas, "Сет Лас-Вегас.", "Дракон Унаги ролл, Филадельфия, Калифорния, Комбо ролл, Санторини, Маори Ролл.", 1630, 597));
            sets.Add(new Food(Properties.Resources.Sets_Kanarskiy, "Сет Канарский.", "Колорадо ролл, Дракон ролл, Нью-Йорк, Обама ролл, Калифорния с мясом криля.", 1230, 399));
            sets.Add(new Food(Properties.Resources.Sets_Vegetarian, "Сет Вегетерианский.", "Сет Вегетерианский. Гунканы с водорослями хияши, Авокадо ролл, Каппа ролл.", 485, 170));
            sets.Add(new Food(Properties.Resources.Sets_Namuro, "Сет Намуро.", "Намуро со скумбрией, Намуро с беконом, Намуро со свининой, Намуро с грибами.", 840, 225));
            sets.Add(new Food(Properties.Resources.Sets_Madagaskarskiy, "Сет Мадагаскарский.", "Алабама ролл, Соната ролл, Калифорния, Мексиканский ролл, Гринвич, Новозеландский ролл.", 2800, 890));

            noodles = new List<Food>();

            noodles.Add(new Food(Properties.Resources.Noodles_Funchoza, "Лапша Фунчоза с курицей.", "Фунчоза с кусочками нежного куриного филе и овощами.", 350, 75));
            noodles.Add(new Food(Properties.Resources.Noodles_FiredRise, "Рис жареный с курицей.", "Рис с сочной курицей и овощами.", 350, 63));
            noodles.Add(new Food(Properties.Resources.Noodles_Eggs, "Лапша яичная с говядиной.", "Яичная лапша с сочной говядиной и овощами.", 350, 93));
            noodles.Add(new Food(Properties.Resources.Noodles_SeaFood, "Лапша яичная с морепродуктами.", "Лапша яичная с морепродуктами и овощами.", 350, 109));
            noodles.Add(new Food(Properties.Resources.Noodles_Karbonara, "Лапша Карбонара.", "Карбонара с беконом и овощами.", 350, 107));
            noodles.Add(new Food(Properties.Resources.Noodles_RiseMashrooms, "Рис с грибами и лососем.", "Рис с грибами, нежным лососем и овощами.", 350, 117));
            noodles.Add(new Food(Properties.Resources.Noodles_RiseBacon, "Рис с беконом.", "Рис с беконом и нежными овощами.", 350, 63));
            noodles.Add(new Food(Properties.Resources.Noodles_RiseChicken, "Лапша рисовая с курицей.", "Рисовая лапша с сочными кусочками куриного филе и овощами.", 350, 89));

            snacks = new List<Food>();

            snacks.Add(new Food(Properties.Resources.Snacks_NamuroBacon, "Фунчоза с курицей.", "Нежная сыровяленая шея, рис, листья салата, тостерный сыр, сырные чипсы, водоросли нори. 4 кусочка.", 210, 73));
            snacks.Add(new Food(Properties.Resources.Snacks_NamuroMackerel, "Намуро со скумбрией.", "Филе скумбрии, рис, листья салата, сыр Чеддер, сырные чипсы, водоросли нори. 4 кусочка.", 350, 75));
            snacks.Add(new Food(Properties.Resources.Snacks_SpringRoll, "Спринг ролл Тофу.", "Сыр тофу, копченое брюшко лосося, сырные чипсы, морковь, укроп, базилик, зеленый лучок. 4 кусочка.", 145, 79));
            snacks.Add(new Food(Properties.Resources.Snacks_SpringRollSquid, "Спринг ролл Кальмар.", "Кальмар, снежный краб, икра летучей рыбы, имбирь, авокадо, мягкий сыр.", 160, 64));
            snacks.Add(new Food(Properties.Resources.Snacks_SideHiyashi, "Салат Хияши.", "Морские водоросли хияши, кунжут, ореховый соус.", 100, 45));
            snacks.Add(new Food(Properties.Resources.Snacks_SpringRollForel, "Спринг ролл Форель.", "Фунчоза с кусочками нежного куриного филе и овощами.", 350, 75));
            snacks.Add(new Food(Properties.Resources.Snacks_HamuroChicken, "Намуро с куриным филе.", "Куриное филе, рис, листья салата, сыр Чеддер, сырные чипсы, водоросли нори. 4 кусочка.", 235, 63));

            shef = new List<Food>();

            shef.Add(new Food(Properties.Resources.Shef_California, "Калифорния Сякэ.", "Лосось, креветки, икра тобико, авокадо, огурец, рис, водоросли нори. 8 кусочков.", 245, 170));
            shef.Add(new Food(Properties.Resources.Shef_Tokaydo, "Токайдо.", "Креветки, печень трески, икра летучей рыбы, мягкий сыр, кунжут, водоросли нори, рис. 8 кусочков.", 250, 170));
            shef.Add(new Food(Properties.Resources.Shef_NagiroCalifornia, "Нагиро Калифорния.", "Креветки, мясо криля, авокадо, икра тобико, мягкий сыр, огурец, рис, водоросли нори. 8 кусочков.", 255, 190));
            shef.Add(new Food(Properties.Resources.Shef_NagiroFiladelphia, "Нагиро Филадельфия", "Лосось, авокадо, мягкий сыр, огурец, рис, водоросли нори. 8 кусочков.", 255, 190));
            shef.Add(new Food(Properties.Resources.Shef_FiladelphiaUnagi, "Филадельфия Унаги.", "Угорь, лосось, мягкий сыр, авокадо, огурец, соус унаги, кунжут, рис, водоросли нори. 8 кусочков.", 270, 190));

        }

        private void bSushi_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(sushi);
            Hide();

            foodForm.FormClosed += (_, __) => this.Close();

            foodForm.Show();
        }

        private void bRolls_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(rolls);
            Hide();

            foodForm.FormClosed += (_, __) => this.Close();

            foodForm.Show();
        }

        private void bSets_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(sets);
            Hide();

            foodForm.FormClosed += (_, __) => this.Close();

            foodForm.Show();
        }

        private void bNoodles_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(noodles);
            Hide();

            foodForm.FormClosed += (_, __) => this.Close();

            foodForm.Show();
        }

        private void bSnacks_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(shef);
            Hide();

            foodForm.FormClosed += (_, __) => this.Close();

            foodForm.Show();
        }

        private void bPotables_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(shef);
            Hide();

            foodForm.FormClosed += (_, __) => this.Close();

            foodForm.Show();
        }
    }
}

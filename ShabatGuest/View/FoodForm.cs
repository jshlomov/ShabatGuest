using ShabatGuest.DAL.Model;
using ShabatGuest.DAL.Rpository;
using ShabatGuest.Services;

namespace ShabatGuest.View
{
    public partial class FoodForm : Form
    {
        FormHandler navigationService;
        IRepository<CategoryModel> catRep;
        IFoodRepository foodRep;
        CategoryModel category;
        int guestId;


        public FoodForm(FormHandler navigation, IRepository<CategoryModel> catRep, IFoodRepository foodRep, CategoryModel cm, int guestID)
        {
            InitializeComponent();
            this.navigationService = navigation;
            this.catRep = catRep;
            this.foodRep = foodRep;
            this.category = cm;
            this.guestId = guestID;

            label_Category.Text = category.Name;
            LoadAll();
        }

        public void LoadAll()
        {
            LoadFoodsNames();
            LoadOthersFood();
        }

        private void LoadFoodsNames()
        {
            List<FoodModel> foods = foodRep.GetAll().FindAll(x => x.GuestID == guestId && x.CategoryID == category.ID);
            listBox_foodList.Items.Clear();
            foreach (var f in foods)
            {
                listBox_foodList.Items.Add(f.Name);
            }
            //listView_viewCategories.Items.AddRange(categories.Select(category => new ListViewItem(category.CategoryName)).ToArray());
        }

        private void LoadOthersFood()
        {
            dataGridView_orderedFood.DataSource = foodRep.GetAllWithNames(guestId, category.ID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_right_Click(object sender, EventArgs e)
        {
            navigationService.PrevCategoryForm(this);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            navigationService.NextCategoryForm(this);
        }

        private void textBox_newFood_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_insertFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_newFood.Text))
            {
                MessageBox.Show("הכנס שם");
                return;
            }
            FoodModel food = new FoodModel(category.ID, guestId, textBox_newFood.Text);
            int id = foodRep.Insert(food, category.ID, guestId);
            string message;
            if (id == -1) message = "מאכל קיים";
            else message = "במאכל עודכן בהצלחה";
            MessageBox.Show(message);
            LoadAll();
        }

        private void FoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

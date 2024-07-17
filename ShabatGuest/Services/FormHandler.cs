using ShabatGuest.DAL;
using ShabatGuest.DAL.Model;
using ShabatGuest.DAL.Rpository;
using ShabatGuest.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.Services
{
    public class FormHandler
    {
        DBContext dBContext;
        IRepository<GuestModel> GuestRepository;
        IRepository<CategoryModel> CategoryRepository;
        IFoodRepository FoodRepository;
        List<FoodForm> foodForms = new List<FoodForm>();
        int formIndex = 0;

        public FormHandler(DBContext db)
        {
            this.dBContext = db;
            GuestRepository = new GuestRepository(dBContext);
            CategoryRepository = new CategoryRepository(dBContext);
            FoodRepository = new FoodRepository(dBContext);

            new LoginForm(this, GuestRepository).Show();
        }

        public void ShowFirstCategoryForm(int guestID)
        {
            List<CategoryModel> categories = CategoryRepository.GetAll();
            foreach (CategoryModel category in categories)
            {
                foodForms.Add(new FoodForm(this, CategoryRepository, FoodRepository, category, guestID));
            }
            foodForms[formIndex].Show();
        }

        public void NextCategoryForm(FoodForm current)
        {
            current.Hide();
            formIndex = (formIndex + 1) % foodForms.Count;
            foodForms[formIndex].LoadAll();
            foodForms[formIndex].Show();
        }


        public void PrevCategoryForm(FoodForm current)
        {
            current.Hide();
            formIndex = (formIndex - 1 + foodForms.Count) % (foodForms.Count);
            foodForms[formIndex].LoadAll();
            foodForms[formIndex].Show();
        }
    }
}

using ShabatGuest.DAL;
using ShabatGuest.DAL.Model;
using ShabatGuest.DAL.Rpository;
using ShabatGuest.Services;
using System.Data;

namespace ShabatGuest
{
    public partial class LoginForm : Form
    {
        IRepository<GuestModel> guestRepository;
        FormHandler navigation;
        bool isNavigating = false;

        public LoginForm(FormHandler navigation, IRepository<GuestModel> guestRepository)
        {
            InitializeComponent();
            this.guestRepository = guestRepository;
            this.navigation = navigation;
            LoadGuestsList();
        }

        private void LoadGuestsList()
        {
            try
            {
                List<GuestModel> guestsList = guestRepository.GetAll();
                foreach (var item in guestsList)
                {
                    listView_GuestsList.Items.Add(item.Name);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_guestName.Text))
            {
                MessageBox.Show("הכנס שם");
                return;
            }
            GuestModel guest = new GuestModel(textBox_guestName.Text);
            int id = guestRepository.Insert(guest);
            isNavigating = true;
            navigation.ShowFirstCategoryForm(id);
            this.Close();

        }

        private void listView_GuestsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView_GuestsList.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                textBox_guestName.Text = item.Text;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isNavigating)
                Application.Exit();
        }
    }
}

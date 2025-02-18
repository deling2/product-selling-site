using product_selling_site.Entities;

namespace product_selling_site
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "پرهام";
            customer1.LastName = "درویشی";
            customer1.PhoneNumber = "09123217856";
            customer1.Address = "";
            customer1.City = "تهران";

            Customer customer2 = new Customer();
            customer2.FirstName = "محمد";
            customer2.LastName = "محمدی";
            customer2.PhoneNumber = "09128743476";
            customer2.Address = "";
            customer2.City = "شیراز";

            Customer customer3 = new Customer();
            customer3.FirstName = "احمد";
            customer3.LastName = "احمدی";
            customer3.PhoneNumber = "09122938126";
            customer3.Address = "";
            customer3.City = "رشت";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Customer_Button(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                PhoneNumber = PhoneNumberTexxtBox.Text,
                Address = AddressTextBox.Text,
                City = CityTextBox.Text,
            };
        }
    }
}

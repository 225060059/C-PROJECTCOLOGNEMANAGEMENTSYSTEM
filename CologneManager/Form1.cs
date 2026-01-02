using MySql.Data.MySqlClient;
using System.ComponentModel;
namespace CologneManager
{
    public partial class Form1 : Form
    {
        // Database connection string
        string connectionString = "Server=localhost;Database=shopdb;Uid=root;Pwd=6767;";
        // 1. THE STOCK LIST: List to store the bottles
        BindingList<Cologne> inventory = new BindingList<Cologne>();
        // 2. THE CUSTOMERS LIST: List to store our customers
        BindingList<Customer> customers = new BindingList<Customer>();
        // 3. THE ORDER HISTORY: List to store our orders
        BindingList<Order> orderHistory = new BindingList<Order>();
        public Form1()
        {
            InitializeComponent();
            gridColognes.DataSource = inventory;
            gridCustomers.DataSource = customers;
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name"; // Shows the customer's Name
            cmbProduct.DataSource = inventory;
            cmbProduct.DisplayMember = "Name";  // Shows the cologne's Name
            gridOrders.DataSource = orderHistory;
        }

        private void btnAddCologne_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get values from the TextBoxes
                string brand = txtBrand.Text;
                string name = txtName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                int stock = 10;
                string imagePath = "";

                // 2. The MySQL Command
                string query = "INSERT INTO Colognes (Brand, Name, Price, ImagePath, Stock) VALUES (@Brand, @Name, @Price, @Img, @Stock)";

                // 3. Open Connection & Send to Database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", brand);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Img", imagePath);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.ExecuteNonQuery();
                    }
                }

                inventory.Add(new Cologne(-1, brand, name, price, imagePath, stock));

                // 4. Message
                MessageBox.Show("Saved to MySQL Database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get values
                string name = txtCustName.Text;
                string email = txtCustEmail.Text;
                string phone = txtCustPhone.Text;

                // 2. The MySQL Query
                string query = "INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";

                // 3. Connect and Send to Database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Filling the placeholders
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        cmd.ExecuteNonQuery();
                    }
                }

                customers.Add(new Customer(-1, name, email, phone));

                txtCustName.Clear();
                txtCustEmail.Clear();
                txtCustPhone.Clear();

                MessageBox.Show("Customer Saved to MySQL Database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the selected items
                Customer selectedCust = (Customer)cmbCustomer.SelectedItem;
                Cologne selectedCol = (Cologne)cmbProduct.SelectedItem;

                // 2. Get quantity
                int qty = (int)numQuantity.Value;

                // Validation check
                if (selectedCust == null || selectedCol == null)
                {
                    MessageBox.Show("Please select a customer and a product!");
                    return;
                }

                // Validation check
                if (qty <= 0)
                {
                    MessageBox.Show("You must buy at least 1 bottle.");
                    return;
                }

                // Validation check
                if (selectedCol.Stock < qty)
                {
                    MessageBox.Show("Not enough stock! We only have " + selectedCol.Stock);
                    return;
                }

                // 3. Process
                decimal totalCost = selectedCol.Price * qty;

                // MYSQL Process
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // A. Inserts the Order into the Orders table
                    string orderQuery = "INSERT INTO Orders (CustomerName, ProductName, Quantity, TotalPrice, OrderDate) " +
                                        "VALUES (@CName, @PName, @Qty, @Total, @Date)";

                    using (MySqlCommand cmd = new MySqlCommand(orderQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CName", selectedCust.Name);
                        cmd.Parameters.AddWithValue("@PName", selectedCol.Name);
                        cmd.Parameters.AddWithValue("@Qty", qty);
                        cmd.Parameters.AddWithValue("@Total", totalCost);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                    // B. Updates the Stock in the Colognes table (Real-time update)
                    string stockQuery = "UPDATE Colognes SET Stock = Stock - @Qty WHERE Id = @ColId";

                    using (MySqlCommand cmd = new MySqlCommand(stockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qty);
                        cmd.Parameters.AddWithValue("@ColId", selectedCol.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                //MYSQL Process
                selectedCol.Stock -= qty;
                inventory.ResetBindings();

                Order newOrder = new Order(orderHistory.Count + 1, selectedCust.Name, selectedCol.Name, qty, totalCost);
                orderHistory.Add(newOrder);

                MessageBox.Show($"Success! Order saved to MySQL.\nSold {qty} {selectedCol.Name} to {selectedCust.Name} for ${totalCost}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order: " + ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadFromDatabase()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. LOAD COLOGNES
                    string sqlCologne = "SELECT * FROM Colognes";
                    using (MySqlCommand cmd = new MySqlCommand(sqlCologne, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        inventory.Clear();
                        while (reader.Read())
                        {
                            inventory.Add(new Cologne(
                                reader.GetInt32("Id"),
                                reader.GetString("Brand"),
                                reader.GetString("Name"),
                                reader.GetDecimal("Price"),
                                reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? "" : reader.GetString("ImagePath"),
                                reader.GetInt32("Stock")
                            ));
                        }
                    }

                    // 2. LOAD CUSTOMERS
                    string sqlCust = "SELECT * FROM Customers";
                    using (MySqlCommand cmd = new MySqlCommand(sqlCust, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        customers.Clear();
                        while (reader.Read())
                        {
                            customers.Add(new Customer(
                                reader.GetInt32("Id"),
                                reader.GetString("Name"),
                                reader.GetString("Email"),
                                reader.GetString("Phone")
                            ));
                        }
                    }

                    // 3. LOAD ORDERS
                    string sqlOrders = "SELECT * FROM Orders";
                    using (MySqlCommand cmd = new MySqlCommand(sqlOrders, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        orderHistory.Clear();
                        while (reader.Read())
                        {
                            orderHistory.Add(new Order(
                                reader.GetInt32("Id"),
                                reader.GetString("CustomerName"),
                                reader.GetString("ProductName"),
                                reader.GetInt32("Quantity"),
                                reader.GetDecimal("TotalPrice")
                            ));
                        }
                    }
                    if (gridColognes.Columns.Contains("ImagePath"))
                    {
                        gridColognes.Columns["ImagePath"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromDatabase(); // This runs the moment the window opens to vacuum information from database
        }


    }
}
# ***Project: Cologne Boutique Management System***

# ***RAYAN MOHAMMAD 22506005***



# **C# PROJECT**



# **ASKED IF A MANAGEMENT SYSTEM WAS ACCEPTABLE AND GOT APPROVED ✅**



### For my project, I am building a Cologne Shop Management System. It will manage Colognes (Stock), Customers, and Orders. It uses a C# Windows Forms GUI and a MySQL backend database to track sales, stock, customers, orders, and stock levels.

### The application will manage real-life objects (classes).

# **-----------------------------------------------------------------------------------**



# **ASSETS:**

#### **CLASS1:** 

#### COLOGNES: **Cologne.cs** (The Stock)

#### Properties: Brand (e.g., JPG), Name (e.g., Le Male Elixir), Price, and StockLevel.



#### **CLASS2:**

#### CUSTOMERS: **Customer.cs** (The Buyer)

#### Properties: Name, Email, Phone Number.

#### Validation: Email must contain an "@" symbol.



#### **CLASS3:**

#### ORDERS: **Order.cs** (The Orders)

#### The Task: A method called CompleteSale(int quantity).

#### 

#### It doesn't just print "Sold"

#### 

#### It subtracts the quantity from the Cologne stock.

#### 

#### It calculates the total cost.

#### 

#### Users will be able to add, edit, delete, and list properties.



# **-----------------------------------------------------------------------------------**

# **OVERVIEW:**



#### C# Language

#### 

#### WinForms GUI

#### 

#### MySQL Backend Database

#### 

#### .NET 10.00 for LONG TERM SUPPORT

#### 

#### MY MYSQL DATABASE PASSWORD WILL BE **6767.**

#### 

#### YES, IT USES AN EXTERNAL BACKEND; MYSQL DATABASE, FOR PROFESSIONAL GRADE WORK.



# **-----------------------------------------------------------------------------------**



# **1. Project Goal (Full Scale):**



#### At its full scale, this application could be a complete retail management platform for high-end boutique shops. A production-ready version would handle multi-user authentication (Admin vs. Staff), barcode scanning for inventory checkouts, and a reporting engine to generate monthly financial statements. It would also feature a cloud-synced database to allow management to view stock levels across different branch locations from a single dashboard.



# **2. Testing Model (Current Submission):**



#### The version I am submitting is a functional prototype that demonstrates the core architecture of the system. It focuses on "Business" of how stock, customers, and sales, owners, and employees interact with a C# application.

#### 

#### What it does:

#### 

#### Storage: it uses a local MySQL 8.0 server. Data remains stored after the app is closed.

#### 

#### Object Management: The GUI handles three specific model classes: Cologne, Customer, and Order.

#### 

#### Relational Logic: The "Place Order" feature isn't just a text entry; it performs a logic check. It verifies if the selected Cologne has enough stock before allowing the transaction.

#### 

#### Database Triggering: When a sale is made, the app sends an SQL UPDATE command to change the stock count in the database automatically.



# **3. Application Structural Integrity:**

#### 

#### UI Layer: WinForms (C#) providing the user interface for input and data display.

#### 

#### Logic Layer: Methods that handle the calculation of totals and stock verification.

#### 

#### Data Layer: A MySQL connection using the MySql.Data library to execute queries.



# **4. Setup Instructions/Requirements:**



#### To test the application, the following environment is required:

#### 

#### Database: A MySQL schema named shopdb must exist. (I have included the .sql script in the folder to generate the tables).

#### 

#### Connection: The connection string in Form1.cs is currently set to localhost. You will need to enter your local MySQL password in the Pwd= field to enable the handshake.

#### 

#### NuGet: Ensure the MySql.Data package is restored in the Visual Studio Solution.



#### **-----------------------------------------------------------------------------------**



## **MySQL Database Navigation Code Controls:**



#### **CTRL + T TO OPEN TERMINAL TO RUN CODES.**

#### CODES:



#### **To check current Colognes stock:**



#### USE shopdb;

#### SELECT \* FROM Colognes;



#### **To check current registered Customers:**



#### USE shopdb;

#### SELECT \* FROM Customers;



#### **To check requested/ongoing/paid orders:**



#### USE shopdb;

#### SELECT \* FROM Orders;

#### 

#### **ALL INFORMATION WILL BE SAVED AND STORED IN THE DATABASE FOR GOOD.**



#### **-----------------------------------------------------------------------------------**



# **USAGE MANUAL:**



#### Step 1: Set up the Catalog

#### Open the Stock tab.

#### 

#### Enter a **brand** (e.g., "Chanel"), a **name** (e.g., "Bleu"), and a **price** (e.g., "120").

#### 

#### Click Add Cologne. You should see a "Saved to MySQL" message.

#### 

#### Check that the cologne appears in the list with a default stock of 10.

#### 

#### Step 2: Register a Customer

#### Switch to the Customers tab.

#### 

#### Enter a **name, email, and phone number**.

#### 

#### Click Add Customer. This creates a persistent profile in the database.

#### 

#### Step 3: Process a Sale

#### Navigate to the Orders tab.

#### 

#### Select your new customer from the dropdown/list.

#### 

#### Select the cologne you just added from the product dropdown.

#### 

#### Set the quantity (e.g., "2").

#### 

#### Click Place Order.

#### 

#### Step 4: Check Code Logic

#### Check Inventory: Go back to the Inventory tab. You will see the stock has automatically dropped from 10 to 8.

#### 

#### Check Orders: Go to the Order tab to see the recorded transaction and total price ($240).

#### 

#### Restart Test: Close the application and re-open it. All data should still be there, proving the MySQL persistence is working.


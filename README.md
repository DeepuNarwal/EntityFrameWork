This is a simple API built using Entity Framework in an ASP.NET Core application. The API allows users to add, read, and delete product entries in a database using basic CRUD operations with an EntityFrameWork_1.Model data model.

How to Set Up : 
Prerequisites
.NET Core 3.1 or higher
Entity Framework Core
A working database (configured in the ApplicationDbContext class)

API Endpoints : 

1. AddEntry
Route: GET /EntityFrameWork/AddEntry
Description: This endpoint adds three predefined product entries to the database.
Response: It returns a message indicating the result of the operation (e.g., status code 200 OK).

2. ReadEntry
Route: GET /EntityFrameWork/ReadEntry
Description: This endpoint reads all product entries from the database and returns them as a list of Product objects.
Response: A list of products in JSON format, or a 400 Bad Request error if something went wrong.

3. DeleteEntry
Route: DELETE /EntityFrameWork/ReadEntry/productId={productId}
Description: This endpoint allows the deletion of a product by its productId. It checks the database for the product, deletes it, and returns the status of the operation.
Response: It returns a success message if the product is deleted, or a 404 Not Found error if the product with the provided productId is not found.


Database Configuration : 
The API is set up to use Entity Framework with an ApplicationDbContext class to interact with the database. It handles the operations of adding, reading, and deleting products from the Products table.

License
This project is licensed under the MIT License - see the LICENSE file for details.

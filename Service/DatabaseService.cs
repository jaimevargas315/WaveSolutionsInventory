using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Objects;
using SQLite;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.ComponentModel;
using System.Collections;

namespace Capstone.Service
{
    public static class DatabaseService
    {
        private static SQLiteAsyncConnection _db;
        private static SQLiteConnection _dbConnection;
        static async Task Init()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "database.db");

            _db = new SQLiteAsyncConnection(databasePath);
            _dbConnection = new SQLiteConnection(databasePath);

            if(_db !=null)
            {
                return;
            }

            await _db.CreateTableAsync<User>();
            await _db.CreateTableAsync<Order>();
            await _db.CreateTableAsync<Inhouse>();
            await _db.CreateTableAsync<Outsourced>();
            await _db.CreateTableAsync<Product>();
        }

        #region users  
        public static async Task<User> GetUser(int id)
        {
            await Init();
            var user = await _db.Table<User>()
                .Where(i => i.UserID == id)
                .FirstOrDefaultAsync();
            return user;
        }
        public static async Task<IEnumerable<User>> GetUsers()
        {
            await Init();
            var users = await _db.Table<User>().ToListAsync();

            return users;
        }
        public static async Task UpdateUser(int userId, string firstName, string lastName,
                                            string password, DateTime creationDate, bool isManager)
        {
            await Init();
            var userQuery = await _db.Table<User>()
            .Where(i => i.UserID == userId)
            .FirstOrDefaultAsync();
            if (userQuery != null)
            {
                userQuery.FirstName = firstName;
                userQuery.LastName = lastName;
                userQuery.Password = password;
                userQuery.CreationDate = creationDate;
                userQuery.IsManager = isManager;

                await _db.UpdateAsync(userQuery);
            }
        }
        public static async Task UpdateUser(User user)
        {
            await Init();
            var userQuery = await _db.Table<User>()
            .Where(i => i.UserID == user.UserID)
            .FirstOrDefaultAsync();
            if (userQuery != null)
            {
                userQuery = user;

                await _db.UpdateAsync(userQuery);
            }
        }
        public static async Task RemoveUser(int id)
        {
            await Init();

            await _db.DeleteAsync<User>(id);
        }
        public static async Task AddUser(User user)
        {
            await Init();
            await _db.InsertAsync(user);
        }
        #endregion

        #region orders
        public static async Task<Order>GetOrder(int id)
        {
            await Init();
            var order = await _db.Table<Order>()
                .Where(i => i.OrderId == id)
                .FirstOrDefaultAsync();
            return order;
        }
        public static async Task<ICollection<Order>>GetOrders()
        {
            await Init();
            var orders = await _db.Table<Order>().ToListAsync();
            return orders;
        }
        public static async Task<ICollection<Order>>GetOrders(User user)
        {
            await Init();
            var orders  = await _db.Table<Order>()
                .Where(i => i.UserID == user.UserID)
                .ToListAsync();
            return orders;          
        }
        public static async Task<Order> GetCurrentOrder(User user)
        {
            await Init();
            var orders = await _db.Table<Order>()
                .Where(i => i.OrderId == user.CurrentOrder)
                .FirstOrDefaultAsync();
            return orders;
        }

        public static async Task UpdateOrder(int orderId, int userId, DateTime creationTime, bool complete,
                                             DateTime completionTime, string parts, string products,
                                             string missingParts, string missingProducts)
        {
            await Init();
            var orderQuery = await _db.Table<Order>()
                .Where(o => o.OrderId == orderId)
                .FirstOrDefaultAsync();
        if (orderQuery != null)
            {
                orderQuery.UserID = userId;
                orderQuery.CreationTime = creationTime;
                orderQuery.Complete = complete;
                orderQuery.CompletionTime = completionTime;
                orderQuery.Parts = parts;
                orderQuery.Products = products;
                orderQuery.MissingParts = missingParts;
                orderQuery.MissingProducts = missingProducts;

                await _db.UpdateAsync(orderQuery);
            }
        }
        public static async Task UpdateOrder(Order order)
        {
            await Init();
            var orderQuery = await _db.Table<Order>()
                    .Where(i => i.OrderId == order.OrderId)
                    .FirstOrDefaultAsync();
            if (orderQuery != null)
            {
                orderQuery = order;
                await _db.UpdateAsync(orderQuery);
            }
        }
        public static async Task RemoveOrder(int id)
        {
            await Init();

            await _db.DeleteAsync<Order>(id);
        }
        public static async Task AddOrder(Order order)
        {
            await Init();
            await _db.InsertAsync(order);
        }
        #endregion

        #region inhouse
        public static async Task<Inhouse> GetInhouse(int id)
        {
            await Init();
            var inhouse = await _db.Table<Inhouse>()
                .Where(i => i.PartId == id)
                .FirstOrDefaultAsync();
            return inhouse;
        }
        public static async Task<ICollection<Inhouse>> GetInhouses()
        {
            await Init();
            var inhouses = await _db.Table<Inhouse>().ToListAsync();
            return inhouses;
        }
        public static async Task UpdateInhouse(int partId, int productId, string name, decimal price,
                                               int min, int max,int machineId, string companyName, string storageLocation)
        {
            await Init();
            var inhouseQuery = await _db.Table<Inhouse>()
                .Where(i => i.PartId == partId)
                .FirstOrDefaultAsync();
            if (inhouseQuery != null)
            {
                inhouseQuery.ProductID = productId;
                inhouseQuery.Name = name;
                inhouseQuery.Price = price;
                inhouseQuery.Min = min;
                inhouseQuery.Max = max;
                inhouseQuery.MachineID = machineId;
                inhouseQuery.CompanyName = companyName;
                inhouseQuery.StorageLocation = storageLocation;

                await _db.UpdateAsync(inhouseQuery);
            }
        }
        public static async Task UpdateInhouse(Inhouse inhouse)
        {
            await Init();
            var inhouseQuery = await _db.Table<Inhouse>()
                    .Where(i => i.PartId == inhouse.PartId)
                    .FirstOrDefaultAsync();
            if(inhouseQuery!= null)
            {
                inhouseQuery = inhouse;
                await _db.UpdateAsync(inhouseQuery);
            }
        }
        public static async Task RemoveInhouse(int id)
        {
            await Init();

            await _db.DeleteAsync<Inhouse>(id);
        }
        public static async Task AddInhouse(Inhouse inhouse)
        {
            await Init();
            await _db.InsertAsync(inhouse);
        }
        public static async Task InhouseStockAdjust(int id, int stock)
        {
            await Init();
            var inhouseQuery = await _db.Table<Inhouse>()
                .Where(i => i.PartId == id)
                .FirstOrDefaultAsync();
            if (inhouseQuery != null)
            {
                inhouseQuery.InStock += stock;

                await _db.UpdateAsync(inhouseQuery);
            }
        }
        #endregion

        #region outsourced
        public static async Task<Outsourced> GetOutsourced(int id)
        {
            await Init();
            var outsourced = await _db.Table<Outsourced>()
                .Where(i => i.PartId == id)
                .FirstOrDefaultAsync();
            return outsourced;
        }
        public static async Task<ICollection<Outsourced>> GetOutsources()
        {
            await Init();
            var outsources = await _db.Table<Outsourced>().ToListAsync();
            return outsources;
        }
        public static async Task UpdateOutsourced(int partId, int productId, string name, decimal price,
                                               int min, int max, int machineId, string companyName, string storageLocation)
        {
            await Init();
            var outsourcedQuery = await _db.Table<Outsourced>()
                .Where(i => i.PartId == partId)
                .FirstOrDefaultAsync();
            if (outsourcedQuery != null)
            {
                outsourcedQuery.ProductID = productId;
                outsourcedQuery.Name = name;
                outsourcedQuery.Price = price;
                outsourcedQuery.Min = min;
                outsourcedQuery.Max = max;
                outsourcedQuery.MachineID = machineId;
                outsourcedQuery.CompanyName = companyName;
                outsourcedQuery.StorageLocation = storageLocation;

                await _db.UpdateAsync(outsourcedQuery);
            }
        }
        public static async Task UpdateOutsourced(Outsourced outsourced)
        {
            await Init();
            var outsourcedQuery = await _db.Table<Outsourced>()
                    .Where(i => i.PartId == outsourced.PartId)
                    .FirstOrDefaultAsync();
            if (outsourcedQuery != null)
            {
                outsourcedQuery = outsourced;
                await _db.UpdateAsync(outsourcedQuery);
            }
        }
        public static async Task RemoveOutsourced(int id)
        {
            await Init();

            await _db.DeleteAsync<Outsourced>(id);
        }
        public static async Task AddOutsourced(Outsourced outsourced)
        {
            await Init();
            await _db.InsertAsync(outsourced);
        }
        public static async Task OutsourcedStockAdjust(int id, int stock)
        {
            await Init();
            var outsourcedQuery = await _db.Table<Outsourced>()
                .Where(i => i.PartId == id)
                .FirstOrDefaultAsync();
            if (outsourcedQuery != null)
            {
                outsourcedQuery.InStock += stock;

                await _db.UpdateAsync(outsourcedQuery);
            }
        }
        #endregion

        #region product
        public static async Task<Product> GetProduct(int id)
        {
            await Init();
            var product = await _db.Table<Product>()
                .Where(i => i.ProductID == id)
                .FirstOrDefaultAsync();
            return product;
        }
        public static async Task<ICollection<Product>> GetProducts()
        {
            await Init();
            var products = await _db.Table<Product>().ToListAsync();
            return products;
        }
        public static async Task UpdateProduct
            (int productId, string name, decimal price, int min, int max, string companyName, string storageLocation)
        {
            await Init();
            var productQuery = await _db.Table<Product>()
                .Where(i => i.ProductID == productId)
                .FirstOrDefaultAsync();
            if (productQuery != null)
            {
                productQuery.Name = name;
                productQuery.Price = price;
                productQuery.Min = min;
                productQuery.Max = max;
                productQuery.CompanyName = companyName;
                productQuery.StorageLocation = storageLocation;

                await _db.UpdateAsync(productQuery);
            }
        }
        public static async Task UpdateProduct(Product product)
        {
            await Init();
            var productQuery = await _db.Table<Product>()
                    .Where(i => i.ProductID == product.ProductID)
                    .FirstOrDefaultAsync();
            if (productQuery != null)
            {
                productQuery = product;
                await _db.UpdateAsync(productQuery);
            }
        }
        public static async Task RemoveProduct(int id)
        {
            await Init();

            await _db.DeleteAsync<Product>(id);
        }
        public static async Task AddProduct(Product product)
        {
            await Init();
            await _db.InsertAsync(product);
        }
        public static async Task ProductStockAdjust(int id, int stock)
        {
            await Init();
            var productQuery = await _db.Table<Product>()
                .Where(i => i.ProductID == id)
                .FirstOrDefaultAsync();
            if (productQuery != null)
            {
                productQuery.InStock += stock;

                await _db.UpdateAsync(productQuery);
            }
        }


        #endregion

    }
}

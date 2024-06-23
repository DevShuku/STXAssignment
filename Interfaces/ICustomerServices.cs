using Microsoft.EntityFrameworkCore;
using STXAssignment.Controllers;
using STXAssignment.Data;

    //Dependency Object should be Interface-Based

    public interface ICustomerServices
    {
        Task<List<Customer>> LoadCustomerDetails();

        Task<Customer?> LoadCustomerDetailById(int id);
    }
    /*
    public class CustomerDAL : ICustomerServices
    {
        /*List<Customer> CustomerList = new List<Customer>
            {
                //Get the Customers from the Database
             /*  new() { CustomerId = 1, CustomerName = "ABC Wholesalers", Type = "Wholesaler", Contact = new Contact { Name = "John Smith", Email = "john@example.com", Phone = "+971586790303" }, Country = "UAE" },
               new() { CustomerId = 2, CustomerName = "XYZ Retail Chain", Type = "Retailer", Contact = new Contact { Name = "Shreshta", Email = "shreshta@example.com", Phone = "+919737789890" }, Country = "INDIA" },
               new() { CustomerId = 3, CustomerName = "Global Import Ltd", Type = "Importer", Contact = new Contact { Name = "David Lee", Email = "david@example.com", Phone = "+447700123456" }, Country = "UK" }
           */
        /* new() { CustomerId = 1, CustomerName = "ABC Wholesalers", Type = "Wholesaler", Contact ="John Smith", Country = "UAE" },
            new() { CustomerId = 2, CustomerName = "XYZ Retail Chain", Type = "Retailer", Contact = "Shreshta", Country = "INDIA" },
            new() { CustomerId = 3, CustomerName = "Global Import Ltd", Type = "Importer", Contact = "David Lee",Country = "UK" }


         }; */
        //_context.Customer.ToList();

     /*   public Customer? LoadCustomerDetailById(int id)
        {
            var customerById = CustomerList.FirstOrDefault(c => c.CustomerId == id);
            return customerById;
        }

        public List<Customer> LoadCustomerDetails()
        {            
            return CustomerList;
        }
    } */

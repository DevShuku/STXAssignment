using static STXAssignment.Controllers.SupplierController;

namespace STXAssignment.Interfaces
{
    //Service Class or Dependency Object
    //Dependency Object should be Interface-Based
    public interface ISupplierServices
    {
        List<Supplier> LoadSupplierDetails();
        Supplier? LoadSupplierDetailById(int id);
    }

    public class SupplierDAL : ISupplierServices
    {
        List<Supplier> SupplierList = new List<Supplier>
            {
                //Get the Suppliers from the Database
               new() { SupplierId = 1, SupplierName = "ABC Electronics Co.", Category = "Electronics", Contact =new Contact { Name = "Michael Chang", Email = "michael@abcelectronics.com", Phone = "+971586790303" }, Country = "USA" },
               new() { SupplierId = 2, SupplierName = "XYZ Textiles Ltd.", Category = "Textiles", Contact = new Contact { Name = "Haya Emir", Email = "haya@example.com", Phone = "+919737789890" }, Country = "OMAN" },
               new() { SupplierId = 3, SupplierName = "Global Foods Inc.", Category = "Food & Beverage", Contact = new Contact { Name = "Sophia Lee", Email = "sophia@globalfoods.com", Phone = "+447700123498" }, Country = "UK" }
            };

        public Supplier? LoadSupplierDetailById(int id)
        {
            var SupplierById = SupplierList.FirstOrDefault(c => c.SupplierId == id);
            return SupplierById;
        }

        public List<Supplier> LoadSupplierDetails()
        {            
            return SupplierList;
        }
    }
}
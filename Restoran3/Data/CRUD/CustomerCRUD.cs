using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran3.Data.CRUD
{
    public class CustomerCRUD
    {
        public static Customer selectedCust = null;

        public static void getById(String idCust)
        {
            selectedCust = Repo.entities.Customers.Where(r => r.idCustomer.Equals(idCust)).FirstOrDefault();
        }

        public static Customer getByIdReturn(String idCust)
        {
           return Repo.entities.Customers.Where(r => r.idCustomer.Equals(idCust)).FirstOrDefault();
        }

        public static void addCustomer(String email, String idCustomer, String nama, String telp)
        {
            try
            {
                var cust = new Customer()
                {
                    Email = email,
                    idCustomer = idCustomer,
                    Nama = nama,
                    Telepon = telp,
                };
                Repo.entities.Customers.Add(cust);
                Repo.entities.SaveChanges();
            }catch (Exception ex) { throw; }
        }

        public static void updateCustomer(Customer custModel)
        {
            try
            {
                Customer model = Repo.entities.Customers.Find(custModel.idCustomer);
                
                model.idCustomer = custModel.idCustomer;
                model.Telepon = custModel.Telepon;
                model.Email = custModel.Email;
                model.Nama = custModel.Nama;

                Repo.entities.SaveChanges();
            } catch (Exception ex) { throw; }
        }

        public static void removeCustomer()
        {
            Customer entry = Repo.entities.Customers.Find(selectedCust.idCustomer);

            if (entry != null)
            {
                Repo.entities.Customers.Remove(entry);
                Repo.entities.SaveChanges();
            }
        }

        public static void exportCustomer(DataTable dt)
        {
            Export.ekspor("Customer", dt);
        }
    }
}

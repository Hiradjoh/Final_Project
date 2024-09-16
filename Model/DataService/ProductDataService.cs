using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataService
{
    public class ProductDataService
    {
        #region [- SelectAll() -]
        public List<Product> SelectAll()
        {
            try
            {
                using (var context = new Final_ProjectDbContext())
                {
                    var products = context.Product.ToList();
                    return products;
                }
            }
            catch
            {

                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Insert() -]
        public void Insert(Product product)
        {
            try
            {
                using (var context = new Final_ProjectDbContext())
                {
                    context.Product.Add(product);
                    context.SaveChanges();
                }
            }
            catch
            {

                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Update() -]
        public void Update(int id, Product product)
        {
            try
            {
                using (var context = new Final_ProjectDbContext())
                {
                    var productToModify = context.Product.SingleOrDefault(p => p.Id == id);
                    productToModify.Title = product.Title;
                    productToModify.UnitPrice = product.UnitPrice;
                    productToModify.Quantity = product.Quantity;
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete(int id)
        {
            try
            {
                using (var context = new Final_ProjectDbContext())
                {
                    var productToDelete = context.Product.SingleOrDefault(p => p.Id == id);
                    context.Product.Remove(productToDelete);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}


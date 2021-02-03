using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{Id=1, BrandId=1, ColorId=1, DailyPrice=400000, Description="Audi Yeni Model", ModelYear=2021},
            new Product{Id=2, BrandId=2, ColorId=2, DailyPrice=200000, Description="Hundai Model", ModelYear=2021},
            new Product{Id=3, BrandId=3, ColorId=1, DailyPrice=300000, Description="Toyota Model", ModelYear=2020},
            new Product{Id=4, BrandId=4, ColorId=3, DailyPrice=800000, Description="BMW Yeni Model", ModelYear=2021},
            new Product{Id=5, BrandId=5, ColorId=2, DailyPrice=700000, Description="BMW Model", ModelYear=2017}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.Id = product.Id;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
            productToUpdate.ModelYear = product.ModelYear;
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Product product)
        {
            return _products;
        }

        public List<Product> GetById(Product product)
        {
            return _products;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p=>p.Id==categoryId).ToList();

        }

    internal class p
    {
        internal class CategoryId
        {
        }
    }

    public List<Product> GetAllId(int CategoryId)
        {
            throw new NotImplementedException();
        }

        void IProductDal.GetById(Product product)
        {
            throw new NotImplementedException();
        }

        void IProductDal.GetAll(Product product)
        {
            throw new NotImplementedException();
        }
    }



}

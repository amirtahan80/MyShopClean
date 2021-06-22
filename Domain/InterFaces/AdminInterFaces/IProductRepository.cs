using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.InterFaces.AdminInterFaces
{
    public interface IProductRepository : ISaveInterFaces
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(int productId);
        Task<ProductImages> FindImageByIdAsync(int imageId);
        Task<ProductProperty> FindPropertyByIdAsync(int propertyId);



        Task AddProductAsync(Product t);
        Task AddProductImagesAsync(IEnumerable<ProductImages> t);
        Task AddProductProperties(IEnumerable<ProductProperty> t);

        Task AddProductAdjectives(IEnumerable<Adjective> t);
        Task AddProductAdjectives(Adjective t);
        Task AddProductAdjectiveValues(IEnumerable<Value> t);
        Task AddProductAdjectiveValues(Value t);
        Task AddProductAdjectiveValueSubValue(IEnumerable<SubValue> t);
        Task AddProductAdjectiveValueSubValue(SubValue t);

        void DeleteProduct(Product t);
        void DeleteProduct(IEnumerable<Product> t);
        void DeletePhoto(ProductImages t);
        void DeletePhoto(IEnumerable<ProductImages> t);
        void DeleteProductProperties(ProductProperty t);
        void DeleteProductProperties(IEnumerable<ProductProperty> t);
        void EditProduct(Product t);
    }
}

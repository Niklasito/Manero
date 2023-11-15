using Manero.Models.Entities;
using Manero.Models.Entities.Identity;
using Manero.Controllers;
using Manero.Models;

namespace Manero.Models.ViewModels
{
    public class Cart
    {
        public List<ProductEntity> Items { get; set; } = new List<ProductEntity>();

        public void AddItem(ProductEntity product)
        {
            Items.Add(product);
        }

        public void RemoveItem(int productId)
        {
            var product = Items.FirstOrDefault(i => i.Id == productId);
            if (product != null)
            {
                Items.Remove(product);
            }
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(product => product.Price);
        }
    }

}

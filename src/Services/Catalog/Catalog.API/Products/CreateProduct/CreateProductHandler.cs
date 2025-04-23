using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
    public record CreateProductResult(Guid Id);
    public class CreateProductCommandHandler
    {
        
    }
}
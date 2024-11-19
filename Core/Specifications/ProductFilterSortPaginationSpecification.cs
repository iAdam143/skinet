using System;
using Core.Entities;

namespace Core.Specifications;

public class ProductFilterSortPaginationSpecification:BaseSpecification<Product>
{
    public ProductFilterSortPaginationSpecification(string? brand, string? type):base(x=>(x.Brand == brand || string.IsNullOrWhiteSpace(brand)) && (x.Type == type || string.IsNullOrWhiteSpace(type))) 
    {
        
    }
}

using AutoMapper;
using ProductManagement.Products;
using static ProductManagement.Web.Pages.Products.CreateProductModalModel;

namespace ProductManagement.Web;

public class ProductManagementWebAutoMapperProfile : Profile
{
    public ProductManagementWebAutoMapperProfile()
    {
        CreateMap<CreateEditProductViewModel,CreateUpdateProductDto>();
        CreateMap<ProductDto, CreateEditProductViewModel>();
    }
}

using API.Dtos;
using Core.Entities;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _confing;

        public ProductUrlResolver(IConfiguration confing)
        {
            _confing = confing;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _confing["ApiUrl"] + source.PictureUrl;
            }

            return null;
            
        }
    }
}
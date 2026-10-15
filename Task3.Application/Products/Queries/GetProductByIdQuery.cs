using MediatR;
using Task3.Application.Products.DTOs;

namespace Task3.Application.Products.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<ProductDto?>;
}
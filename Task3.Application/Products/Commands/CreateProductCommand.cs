using MediatR;

namespace Task3.Application.Products.Commands
{
    public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;
}
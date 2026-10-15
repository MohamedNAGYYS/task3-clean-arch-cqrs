using MediatR;
using Task3.Application.Common.Interfaces;
using Task3.Domain.Entities;

namespace Task3.Application.Products.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken ct)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            return await _repository.AddAsync(product);
        }
    }
}
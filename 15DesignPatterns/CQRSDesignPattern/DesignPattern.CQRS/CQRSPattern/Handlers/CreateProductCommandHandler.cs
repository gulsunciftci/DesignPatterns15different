﻿using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.CQRS.CQRSPattern.Commands;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;
        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Description=command.Description,
                Name=command.Name,
                Price=command.Price,
                Status=true,
                Stock=command.Stock
            });
            _context.SaveChanges();
        }
    }
}
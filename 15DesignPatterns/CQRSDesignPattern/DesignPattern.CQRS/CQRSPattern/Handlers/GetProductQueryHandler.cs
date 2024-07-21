using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.CQRS.CQRSPattern.Results;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        public readonly Context _context;
        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ID=x.ProductID,
                Price=x.Price,
                ProductName=x.Name,
                Stock=x.Stock

            }).ToList();

            return values;
        }
    }
}

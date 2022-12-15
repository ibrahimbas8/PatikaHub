using System.Linq;
using System;
using MovieStoreWebApi.DbOperations;

namespace MovieStoreWebApi.Applications.OrderOperations.Commands
{
  public class DeleteOrderCommand
  {
    private readonly IMovieStoreDbContext _context;
    public int OrderId { get; set; }
    public DeleteOrderCommand(IMovieStoreDbContext context)
    {
      _context = context;
    }

    public void Handle()
    {
      var order = _context.Orders.SingleOrDefault(x=> x.Id == OrderId);

      if(order is null)
        throw new InvalidOperationException("Sipariş bulunamadı");
      
      _context.Orders.Remove(order);
      _context.SaveChanges();
    }
  }
}
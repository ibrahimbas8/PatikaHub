using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApi.Applications.OrderOperations.Commands;
using MovieStoreWebApi.Applications.OrderOperations.Queries;
using MovieStoreWebApi.DbOperations;
using static MovieStoreWebApi.Applications.OrderOperations.Commands.CreateOrderCommand;
using static MovieStoreWebApi.Applications.OrderOperations.Commands.UpdateOrderCommand;
using static MovieStoreWebApi.Applications.OrderOperations.Queries.GetOrderDetailQuery;

namespace MovieStoreWebApi.Controllers
{
  [Authorize]
  [ApiController]  
  [Route("[Controller]s")]
  public class OrderController : ControllerBase  
  {
    private readonly IMovieStoreDbContext _context;
    private readonly IMapper _mapper;

    public OrderController(IMovieStoreDbContext context , IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
      GetOrdersQuery query = new GetOrdersQuery(_context, _mapper);
      var result = query.Handle();
      return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetOrderDetail(int id)
    { 
      OrderDetailViewModel result; 
      
      GetOrderDetailQuery query = new GetOrderDetailQuery(_context, _mapper);
      query.OrderId = id;
      GetOrderDetailQueryValidator validator = new GetOrderDetailQueryValidator();
      validator.ValidateAndThrow(query);
      result = query.Handle();
      
      return Ok(result);
    }

    [HttpPost]
    public IActionResult AddOrder([FromBody] CreateOrderModel newOrder)
    {
      CreateOrderCommand command = new CreateOrderCommand(_context, _mapper);
      command.Model = newOrder;
      CreateOrderCommandValidator validator = new CreateOrderCommandValidator();
      validator.ValidateAndThrow(command);
      command.Handle(); 
      return Ok();      
    }

    [HttpPut("{id}")]
    public IActionResult UpdateOrder(int id,[FromBody] UpdateOrderModel  updatedOrder)
    {      
      UpdateOrderCommand command = new UpdateOrderCommand(_context);
      command.OrderId = id; 
      command.Model = updatedOrder; 

      UpdateOrderCommandValidator validator = new UpdateOrderCommandValidator();
      validator.ValidateAndThrow(command);
      command.Handle();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteOrder(int id)
    {      
      DeleteOrderCommand command = new DeleteOrderCommand(_context);
      command.OrderId = id;
      DeleteOrderCommandValidator validator = new DeleteOrderCommandValidator();
      validator.ValidateAndThrow(command);
      command.Handle();      
      return Ok();
    }
  }
}
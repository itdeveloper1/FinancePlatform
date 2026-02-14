[ApiController]
[Route("transactions")]
public class TransactionsController : ControllerBase
{
    private readonly ITransactionService _service;

    public TransactionsController(ITransactionService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateTransactionRequest request)
    {
        var tx = _service.CreateTransaction(request.MerchantId);
        return Ok(tx);
    }

    [HttpPost("{id}/items")]
    public IActionResult AddItem(Guid id, [FromBody] AddItemRequest request)
    {
        _service.AddItem(id, request.Description, request.Amount);
        return Ok();
    }

    [HttpPost("{id}/submit")]
    public IActionResult Submit(Guid id)
    {
        _service.SubmitTransaction(id);
        return Ok();
    }

    [HttpPost("{id}/cancel")]
    public IActionResult Cancel(Guid id, [FromQuery] bool isMerchant = false)
    {
        _service.CancelTransaction(id, isMerchant);
        return Ok();
    }
}

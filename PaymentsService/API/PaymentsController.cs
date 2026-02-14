[ApiController]
[Route("payments")]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentService _service;

    public PaymentsController(IPaymentService service)
    {
        _service = service;
    }

    [HttpPost("start")]
    public IActionResult Start([FromBody] StartPaymentRequest request)
    {
        var payment = _service.StartPayment(request.TransactionId);
        return Ok(payment);
    }

    [HttpPost("{id}/confirm")]
    public IActionResult Confirm(Guid id)
    {
        _service.ConfirmPayment(id);
        return Ok();
    }

    [HttpPost("{id}/fail")]
    public IActionResult Fail(Guid id)
    {
        _service.FailPayment(id);
        return Ok();
    }
}

using Microsoft.AspNetCore.Mvc;
 
[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the NewClaim of the CustomerCareController");
    }

    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the ClaimStatus of the CustomerCareController");
    }
}
using MacManesAPI_.Interfaces;
using MacManesAPI_.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MacManesAPI_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        public RequestsController(IRequestRepository requestRepository)
        {
            _requestsRepo = requestRepository;
        }

        private IRequestRepository _requestsRepo;

        // GET: api/<RequestsController>
        [HttpGet]public List<Request> GetAllRequests()
        {
            return _requestsRepo.GetAll();
        }

       
    }
}

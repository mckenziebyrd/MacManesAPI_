using MacManesAPI_.Models;

namespace MacManesAPI_.Interfaces
{
    public interface IRequestRepository
    {
        List<Request> GetAll();
    }
}

using MacManesAPI_.Models;
using MacManesAPI_.Interfaces;

namespace MacManesAPI_.Repostitories
{
    public class RequestRepository : IRequestRepository 
    {
        private static List<Request> _requests = new()
        {
            new Request()
            {
                Id = 1,
                Name = "Bob",
                CurrentClient = true,
                AppointmentType = "Haircut",
                Description = "I want bangs",
                HairHistory = "None",
                Img = "http://fbueifbwiufbeuiwfbewuibf",
                usersId = 1,
            }
        };
        public List<Request> GetAll()
        {
            return _requests;
        }

    }
}



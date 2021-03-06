using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DonateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private IDonationRepository _donationRepository;

        public DonationController(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        [HttpPost("give")]
        public IActionResult Donate([FromRoute]string _name, 
                                    [FromRoute]string _family, 
                                    [FromQuery]int _amount, 
                                    [FromQuery]int _companyId,
                                    [FromBody]DonateDetailsModel donateDetails)
        {
            var donation = new {
                name = _name,
                family = _family,
                amount = _amount,
                companyId = _companyId,
                dateOfDonation = donateDetails.DonateDate,
                totalOfAllDonations = _donationRepository.GetTotalDonationCount()
            };
            return Ok(donation);
        }
    }
}

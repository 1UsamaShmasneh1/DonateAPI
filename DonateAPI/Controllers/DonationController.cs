﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DonateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        [HttpPost("give")]
        public IActionResult Donate([FromRoute]string _name, 
                                    [FromRoute]string _family, 
                                    [FromQuery]int _amount, 
                                    [FromQuery]int _companyId)
        {
            var donation = new {
                name = _name,
                family = _family,
                amount = _amount,
                companyId = _companyId,
                dateOfDonation = "2000-01-05T00:00",
                totalOfAllDonations = 10000
            };
            return Ok(donation);
        }
    }
}
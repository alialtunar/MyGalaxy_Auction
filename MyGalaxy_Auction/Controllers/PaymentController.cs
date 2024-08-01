using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Common;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using Stripe;

namespace MyGalaxy_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private ApiResponse _response;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private StripeSettings _stripeSettings;

        public PaymentController(IConfiguration configuration,ApiResponse response,ApplicationDbContext context,IOptions<StripeSettings> options)
        {
            _configuration = configuration;
            _response = response;
            _context = context;
            _stripeSettings = options.Value;
        }

        [HttpPost("Pay")]
        public async Task<ActionResult<ApiResponse>> MakePayment(string userId,int vehicleId)
        {
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
            var amountToPaid = _context.Vehicles.FirstOrDefault(x=>x.VehicleId == vehicleId);
            var options = new PaymentIntentCreateOptions
            {
                Amount = (int)(amountToPaid.AuctionPrice * 100),
                Currency = "usd",
                PaymentMethodTypes = new List<string> { "card"}
            };

            var service = new PaymentIntentService();
            var response = service.Create(options);

            CreatePaymentHistoryDTO model = new()
            {
                  ClientSecret = response.ClientSecret,
                  StripePaymentIntentId = response.Id,
                  UserId = userId,
                  VehicleId = vehicleId,
            };

            _response.Result = model;
            _response.StatusCode = System.Net.HttpStatusCode.OK;
            return Ok(_response);
        }


      
    }
}

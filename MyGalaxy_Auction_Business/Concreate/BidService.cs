using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Business.Abstract;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concreate
{
    public class BidService : IBidService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ApiResponse _response;

        public BidService(ApplicationDbContext context, IMapper mapper,ApiResponse response)
        {
            _context = context;
            _mapper = mapper;
            _response = response;
        }

        public Task<ApiResponse> AutomaticallyCreateBid(CreateBidDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CancelBid(int bidId)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> CreateBid(CreateBidDTO model)
        {
            var returnValue = await ChechIsActive(model.VehicleId);
            var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);

            if (!isPaid)
            {
                _response.isSuccess = false;
                _response.ErrorMessages.Add("please before pat auction price");
                return _response;
            }
            if(returnValue == null)
            {
                _response.isSuccess =false;
                _response.ErrorMessages.Add("this car is not active");
                return _response;
            }

            if (returnValue.Price >= model.BidAmount)
            {
                _response.isSuccess = false;
                _response.ErrorMessages.Add("you should surpass the highest bid in the placed bids");
                return _response;
            }
            if(model != null)
            {
                var topPrice = await _context.Bids.Where(x => x.VehicleId == model.VehicleId).OrderByDescending(x => x.BidAmount).ToListAsync();
                if(topPrice.Count != 0)
                {
                    if (topPrice[0].BidAmount >= model.BidAmount)
                    {
                        _response.isSuccess = false;
                        _response.ErrorMessages.Add("Entry bid aomunt not lover than higher price to the system; higher price is : " + topPrice[0].BidAmount);
                        return _response;
                    }
                }

                Bid bid = _mapper.Map<Bid>(model);
                bid.BidDate = DateTime.Now;
                await _context.Bids.AddAsync(bid);

                if(await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess =true;
                    _response.Result = model;
                    return _response;
                }
               
            }

            _response.isSuccess = false;
            _response.ErrorMessages.Add("Oopss! something went wrong");
            return _response;

          
        }

        public Task<ApiResponse> GetBidById(int bidId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetBidByVehicleId(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateBid(int bidId, UpdateBidDTO model)
        {
            throw new NotImplementedException();
        }

        private async Task<Vehicle> ChechIsActive(int vehicleId)
        {
            var obj = await _context.Vehicles.Where(x => x.VehicleId == vehicleId && x.IsActive == true && x.EndTime >= DateTime.Now).FirstOrDefaultAsync();
            if(obj == null)
            {
                return obj;
            }
            return null;
        }

        private async Task<bool> CheckIsPaidAuction(string userId, int vehicleId)
        {
            var obj = await _context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
            if (obj != null)
            {
                return true;
            }
            return false;
        }


    }
}

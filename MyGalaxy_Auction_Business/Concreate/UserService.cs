using MyGalaxy_Auction_Business.Abstract;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concreate
{
    public class UserService : IUserService
    {
        public Task<ApiResponse> Login(LoginRequestDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Register(RegisterRequestDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

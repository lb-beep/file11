using System;
using BakeryShoppingCart.Models;

namespace BakeryShoppingCart.Repositories.MainRepository
{
    public interface IUser_Repository : IMainRepository<User>
    {
        
        public void GetAllUsersByName(string name);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.Exceptions;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.Repositories.MainRepository;

namespace BakeryShoppingCart.Repositories.Implementation
{
    public class UserRespository : MainRepository<User>, IUser_Repository
    {
        public UserRespository()
        {
        }

        public void GetAllUsersByName(string name)
        {
            List<User> resultList =
            currentDatabase.Where(User => User.UserName == "").ToList();

            if(resultList.Count > 0)
            {
                foreach(var user in resultList)
                {
                    Console.WriteLine(user.UserId);
                    Console.WriteLine(user.UserName);
                    Console.WriteLine(user.Email);
                }
            }
            else
            {
                throw new UserNotFound("No User Found!");
            }
        }
    }
}

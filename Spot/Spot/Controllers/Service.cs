using System;
using Microsoft.AspNetCore.Mvc;

namespace Spot.Controllers
{
    public class Service
    {
        public string AddToFavorite()
        {
            Console.WriteLine("Called");
            return "SUCCESS";
        }
    }
}
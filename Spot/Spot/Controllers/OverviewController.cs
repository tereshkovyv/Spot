using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spot.Data.Interfaces;
using Spot.Models;
using Spot.Views.Overview;

namespace Spot.Controllers
{
    public class OverviewController : Controller
    {     
        private readonly IAllSocialObjects _allSocialObjects;

        public OverviewController(IAllSocialObjects iAllSocialObjects)
        {
            _allSocialObjects = iAllSocialObjects;
        }

        public ViewResult All()
        {
            ViewBag.Title = "Все объекты";
            var veiwModel = new AllOverviewModel();
            veiwModel.socialObjects = _allSocialObjects.GetAllObjectsObjects;
            return View(veiwModel);
        }
        
        public ViewResult Favorite()
        {
            ViewBag.Title = "Избранные объекты";
            var veiwModel = new FavoriteOverviewModel
            {
                socialObjects = _allSocialObjects.GetFavoriteObjects
            };
            return View(veiwModel);
        }
        
        public ViewResult My()
        {
            ViewBag.Title = "Мои объекты";
            var veiwModel = new MyOverviewModel();
            veiwModel.socialObjects = _allSocialObjects.GetFavoriteObjects;
            return View(veiwModel);
        }
    }
}
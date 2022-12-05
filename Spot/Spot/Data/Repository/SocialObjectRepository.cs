using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Spot.Data.Interfaces;
using Spot.Data.Models;

namespace Spot.Data.Repository
{
    public class SocialObjectRepository : IAllSocialObjects
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SocialObjectRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<SocialObject> GetAllObjectsObjects
        {
            get => _applicationDbContext.SocialObject;
            set{}
        }

        public IEnumerable<SocialObject> GetFavoriteObjects => _applicationDbContext.SocialObject.Take(2);
        public IEnumerable<SocialObject> GetMySocialObjects => _applicationDbContext.SocialObject.Take(2);
    }
}
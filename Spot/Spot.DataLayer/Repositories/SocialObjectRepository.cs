using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Spot.Data;
using Spot.Data.Models;
using Spot.DataLayer.Exceptions;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.DataLayer.Repositories
{
    public class SocialObjectRepository : ISocialObjectRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SocialObjectRepository(ApplicationDbContext applicationDbContext)
            =>
                _applicationDbContext = applicationDbContext;

        public SocialObject? GetByIdOrNull(int id)
        {
            try
            {
                return Try(() => _applicationDbContext.SocialObject.FirstOrDefault(s => s.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<SocialObject> All
            => Try(() => _applicationDbContext.SocialObject);
        
        private static T Try<T>(Func<T> func)
        {
            var attempts = 0;
            while(attempts <= 3)
                try
                {
                    return func();
                }
                catch
                {
                    attempts++;
                }

            throw new DataBaseException();
        }

        public void Add(SocialObject objectToAdd)
        {
            _applicationDbContext.Add(objectToAdd);
            _applicationDbContext.SaveChanges();
        }

        public void Change(int id, SocialObject newSocialObject)
        {
            var socialObject = GetByIdOrNull(id);
            socialObject.Name = newSocialObject.Name;
            socialObject.Place = newSocialObject.Place;
            socialObject.Date = newSocialObject.Date;
            socialObject.Status = newSocialObject.Status;
            socialObject.FullDescription = newSocialObject.FullDescription;
            socialObject.ShirtDescription = newSocialObject.ShirtDescription;
            socialObject.OtherInformation = newSocialObject.OtherInformation;
            socialObject.PresenterId = newSocialObject.PresenterId;
            _applicationDbContext.SaveChanges();
        }
    }
}
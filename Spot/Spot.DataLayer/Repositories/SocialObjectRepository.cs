using System.Collections.Generic;
using System.Data;
using System.Linq;
using Spot.Data;
using Spot.Data.Models;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.DataLayer.Repositories
{
    public class SocialObjectRepository : ISocialObjectRepository
    {
        private int RetryAttempts { get; set; }
        private readonly ApplicationDbContext _applicationDbContext;
        
        public SocialObjectRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public IEnumerable<SocialObject> All
        {
            get
            {
                try
                {
                    return _applicationDbContext.SocialObject;
                }
                catch
                {
                    RetryAttempts += 1;
                    if (RetryAttempts <= 3)
                        return All;
                    throw new DataException();
                }
            }
        }


        public SocialObject? GetByIdOrNull(int id)
        {
            try
            {
                return _applicationDbContext.SocialObject.FirstOrDefault(s => s.Id == id);
            }
            catch
            {
                RetryAttempts += 1;
                if (RetryAttempts <= 3)
                    return GetByIdOrNull(id);
                throw new DataException();
            }
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
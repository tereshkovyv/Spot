using System.Collections.Generic;
using System.Linq;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.DataLayer.Repositories
{
    public class SocialObjectRepository : ISocialObjectRepository
    {
        private readonly List<string> _relevantStatuses = new() {"Active"};
        private readonly ApplicationDbContext _applicationDbContext;
        public SocialObjectRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<SocialObject> All => _applicationDbContext.SocialObject;

        public IEnumerable<SocialObject> Relevant =>
            _applicationDbContext.SocialObject.Where(s => _relevantStatuses.Contains(s.Status));
        
        public IEnumerable<SocialObject> GetFavorite(User user)
        {
            return user.FavoriteObjects;
        }

        public IEnumerable<SocialObject> GetOwn(User user)
        {
            return user.OwnObjects;
        }

        public SocialObject? GetByIdOrNull(int id)
        {
            return _applicationDbContext.SocialObject.FirstOrDefault(s => s.Id == id);
        }

        public void ChangeStatus(int id, string status)
        {
            GetByIdOrNull(id)!.Status = status;
            _applicationDbContext.SaveChanges();
        }

        public void ChangeData(int id, SocialObject newSocialObject)
        {
            var socialObject = GetByIdOrNull(id);
            if (socialObject != null)
            {
                socialObject.Name = newSocialObject.Name;
                socialObject.Place = newSocialObject.Place;
                socialObject.Date = newSocialObject.Date;
                socialObject.Status = newSocialObject.Status;
                socialObject.FullDescription = newSocialObject.FullDescription;
                socialObject.ShirtDescription = newSocialObject.ShirtDescription;
                socialObject.OtherInformation = newSocialObject.OtherInformation;
                socialObject.PresenterId = newSocialObject.PresenterId;
            }

            _applicationDbContext.SaveChanges();
        }

        public void Add(SocialObject objectToAdd)
        {
            _applicationDbContext.Add(objectToAdd);
            _applicationDbContext.SaveChanges();
        }
    }
}
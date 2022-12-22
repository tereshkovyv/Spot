using System.Collections.Generic;
using System.Linq;
using Spot.Data;
using Spot.Data.Models;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.DataLayer.Services
{
    public class SocialObjectManager
    {
        private readonly List<string> _relevantStatuses = new List<string>() {"Active"};
        private readonly ApplicationDbContext _applicationDbContext;
        public SocialObjectManager(ApplicationDbContext applicationDbContext)
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

        public SocialObject GetById(int id)
        {
            return _applicationDbContext.SocialObject.FirstOrDefault(s => s.Id == id);
        }

        public void ChangeStatus(int id, string status)
        {
            GetById(id).Status = status;
            _applicationDbContext.SaveChanges();
        }

        public void ChangeData(int id, SocialObject newSocialObject)
        {
            var socialObject = GetById(id);
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
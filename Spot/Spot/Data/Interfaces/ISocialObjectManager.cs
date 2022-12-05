using System.Collections.Generic;
using Spot.Data.Models;

namespace Spot.Data.Interfaces
{
    public interface ISocialObjectManager
    {
        public IEnumerable<SocialObject> All { get; }
        public IEnumerable<SocialObject> Relevant { get; }
        public IEnumerable<SocialObject> GetFavorite(User user);
        public IEnumerable<SocialObject> GetOwn(User user);
        public SocialObject GetById(int id);
        public void ChangeStatus(int id, string status);
        public void ChangeData(int id, SocialObject newSocialObject);
    }
}
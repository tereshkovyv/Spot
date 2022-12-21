using System.Collections.Generic;
using Spot.DataLayer.Models;

namespace Spot.DataLayer.Interfaces
{
    public interface IGettable<TObject>
    {
        public IEnumerable<TObject> All { get; }
        public IEnumerable<TObject> Relevant { get; }
        public SocialObject? GetByIdOrNull(int id);
    }
}
using System.Collections.Generic;

#nullable enable
namespace Spot.DataLayer.Interfaces
{
    public interface IGettable<TObject>
    {
        public IEnumerable<TObject> All { get; }

        public TObject? GetByIdOrNull(int id);
    }
}
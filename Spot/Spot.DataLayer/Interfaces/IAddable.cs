namespace Spot.DataLayer.Interfaces
{
    public interface IAddable<TObject>
    {
        public void Add(TObject objectToAdd);
    }
}
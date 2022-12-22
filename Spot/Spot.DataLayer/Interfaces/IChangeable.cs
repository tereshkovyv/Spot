namespace Spot.DataLayer.Interfaces
{
    public interface IChangeable<TObject>
    {
        public void Change(int id, TObject newObject);
    }
}
namespace _02_Service_Lifetimes.Repositories
{
    public interface ISingletonRepository
    {
        public string GetGuid();
    }

    public class SingletonRepository : ISingletonRepository
    {
        private Guid _guid;

        public SingletonRepository()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}

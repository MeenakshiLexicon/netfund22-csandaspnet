namespace _02_Service_Lifetimes.Repositories
{
    public interface IScopedRepository
    {
        public string GetGuid();
    }

    public class ScopedRepository : IScopedRepository
    {
        private Guid _guid;

        public ScopedRepository()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}

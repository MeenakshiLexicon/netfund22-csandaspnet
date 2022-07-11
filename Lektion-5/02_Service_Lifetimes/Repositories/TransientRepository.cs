namespace _02_Service_Lifetimes.Repositories
{
    public interface ITransientRepository
    {
        public string GetGuid();
    }
    public class TransientRepository : ITransientRepository
    {
        private Guid _guid;

        public TransientRepository()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}

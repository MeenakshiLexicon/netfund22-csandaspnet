using _02_Service_Lifetimes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _02_Service_Lifetimes.Controllers
{
    public class TestController : Controller
    {
        private readonly ISingletonRepository _singleton;
        private readonly IScopedRepository _scoped;
        private readonly ITransientRepository _transient;

        public TestController(ISingletonRepository singleton, IScopedRepository scoped, ITransientRepository transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }



        // https://localhost:7156/test/singleton
        public IActionResult Singleton()
        {
            return View(_singleton);
        }

        // https://localhost:7156/test/scoped
        public IActionResult Scoped()
        {
            return View(_scoped);
        }

        // https://localhost:7156/test/transient
        public IActionResult Transient()
        {
            return View(_transient);
        }
    }
}

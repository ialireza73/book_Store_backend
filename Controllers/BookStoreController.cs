using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace book_Store_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookStoreController : ControllerBase
    {


        private readonly ILogger<BookStoreController> _logger;

        public BookStoreController(ILogger<BookStoreController> logger)
        {
            _logger = logger;
        }


    }
}

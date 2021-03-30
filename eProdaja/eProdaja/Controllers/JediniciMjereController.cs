using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class JediniciMjereController : BaseReadController<Model.JediniceMjere, object>
    {

        public JediniciMjereController(IJediniceMjereService service)
            :base(service)
        {

        }

    }
}

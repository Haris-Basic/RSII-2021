using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseCRUDController<Model.Proizvodi, Model.ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService service) 
            : base(service)
        {

        }
    }
} 

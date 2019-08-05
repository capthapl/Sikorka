using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drzewo;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Net;
using MongoDB.Bson;

namespace Bocian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueOfLegendsController : ControllerBase
    {
        private const string standardCollectionName = "Standard";
        private const string tftCollectionName = "TFT";

    }
}
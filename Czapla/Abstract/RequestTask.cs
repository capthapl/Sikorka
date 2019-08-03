using Czapla.Controllers;
using Czapla.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Abstract
{
    public abstract class RequestTask
    {
        protected RequestController requestController;
        protected string response;
        public RequestTask()
        {
            requestController = new RequestController();
        }

        public string MakeRequestAndGetResponse(string url)
        {

                return requestController.MakeRequest(url);
        }
    }
}

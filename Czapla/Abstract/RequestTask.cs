using System;
using System.Collections.Generic;
using System.Text;

namespace Czapla.Abstract
{
    public abstract class RequestTask
    {
        protected RequestController requestController;
        public RequestTask()
        {
            requestController = new RequestController();
        }
    }
}

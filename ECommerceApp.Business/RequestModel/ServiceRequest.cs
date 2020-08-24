using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Business.RequestModel
{
    public class ServiceRequest<T> : BaseRequest
    {
        public T Entity { get; set; }
        public ICollection<T> Entities { get; set; }
        public int EntitiesCount { get; set; }

        public ServiceRequest()
        {
            Errors = new List<string>();
            Entities = new List<T>();
        }
    }
}

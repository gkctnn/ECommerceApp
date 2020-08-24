using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Business.ResponseModel
{
    public class ServiceResponse<T> : BaseResponse
    {
        public T Entity { get; set; }
        public ICollection<T> Entities { get; set; }
        public int EntitiesCount { get; set; }

        public ServiceResponse()
        {
            Errors = new List<string>();
            Entities = new List<T>();
        }
    }
}

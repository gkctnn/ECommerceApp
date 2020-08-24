using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Business.ResponseModel
{
    public abstract class BaseResponse
    {
        public List<string> Errors { get; set; }
        public bool HasError { get; set; }
        public bool IsSuccess { get; set; }
    }
}

using models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web.Models;
using web.Models.Return;
using webCore.input;
using webCore.services;

namespace web.Controllers
{
    public class PhoneController : ApiController
    {
        private readonly IphoneServices phoneServices;
        public PhoneController(IphoneServices phoneServices)
        {
            this.phoneServices = phoneServices;
        }
        [HttpPost,Route("api/GetListPhone")]
        public ApiResult GetListPhone(PhoneListParmaeter pagi)
        {
            var page = phoneServices.GetListPhone(pagi);
            return new ApiResult()
            {
                StatusCode = HttpStatusCode.OK,
                Data = new
                {
                    list = page.Items.Select(r => new ReturnPhone
                    {
                        id = r.id,
                        color = r.color,
                        ListedTime = r.ListedTime,
                        name = r.name,
                        Price = r.Price,
                        Type = r.Type,
                        Version = r.Version
                    }),
                    page = page.CurrentPage,
                    pageSize = page.ItemsPerPage,
                    totalPage = page.TotalPages
                }
            };
        }
        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <returns></returns>
        [Route("api/str"),HttpGet]
        public string str()
        {
            return "dad";
        }

    }
}

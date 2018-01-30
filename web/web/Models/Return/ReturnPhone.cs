﻿/********************************************************************************
**
**　　　　　　　　┏┓　　　┏┓+ +
**　　　　　　　┏┛┻━━━┛┻┓ + +
**　　　　　　　┃　　　　　　　┃ 　
**　　　　　　　┃　　　━　　　┃ ++ + + +
**　　　　　　 ████━████ ┃+
**　　　　　　　┃　　　　　　　┃ +
**　　　　　　　┃　　　┻　　　┃
**　　　　　　　┃　　　　　　　┃ + +
**　　　　　　　┗━┓　　　┏━┛
**　　　　　　　　　┃　　　┃　　　　　　　　　　　
**　　　　　　　　　┃　　　┃ + + + +
**　　　　　　　　　┃　　　┃　　　　Code is far away from bug with the animal protecting　　　　　　　
**　　　　　　　　　┃　　　┃ + 　　　　神兽保佑,代码无bug　　
**　　　　　　　　　┃　　　┃
**　　　　　　　　　┃　　　┃　　+　　　　　　　　　
**　　　　　　　　　┃　 　　┗━━━┓ + +
**　　　　　　　　　┃ 　　　　　　　┣┓
**　　　　　　　　　┃ 　　　　　　　┏┛
**　　　　　　　　　┗┓┓┏━┳┓┏┛ + + + +
**　　　　　　　　　　┃┫┫　┃┫┫
**　　　　　　　　　　┗┻┛　┗┻┛+ + + +
**
** ***********************************************************************************
     * CLR版本：       4.0.30319.42000
     * 类 名 称：       Interface1
     * 机器名称：       DESKTOP-DS9CMVK
     * 命名空间：       webCore.common
     * 文 件 名：       Interface1
     * 创建时间：       2018/1/16 13:49:41
     * 作    者：         xxx
     * 说   明：
     * 修改时间：
     * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models.Return
{
    public class ReturnPhone
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string Version { get; set; }
        public DateTime? ListedTime { get; set; }
        public decimal? Price { get; set; }
        public int? Type { get; set; }

    }
}
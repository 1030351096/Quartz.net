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

namespace webCore
{
    /// <summary>
    /// 手机还是平板
    /// </summary>
    public enum PhoneType
    {
        All=0,
        手机 = 1,
        iPad = 2,
    }

    /// <summary>
    /// 排序方式
    /// </summary>
    public enum OrderBy
    {
        价格 = 1,
        价格倒序 = 2,
        上市时间 = 3,
        上市时间倒序 = 4,
        大于价格区间=5,
        小于价格区间=6,
        大于上市时间=7,
        小于上市时间=8
    }
}
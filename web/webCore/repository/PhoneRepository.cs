/********************************************************************************
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
using models;
using PetaPoco;
using webCore.input;

namespace webCore.repository
{
    public class PhoneRepository : IphoneRepository
    {
        private readonly DbcontextDB db = new DbcontextDB();
        public Page<Phone> GetListPhone(PhoneListParmaeter pagi)
        {
            var sql = Sql.Builder.Select("*").From("Phone");
            sql.Where("Type=@0", pagi.Type);
            if (!string.IsNullOrWhiteSpace(pagi.keyword))//构建查询条件
            {
                sql.Where("name like @0", $"%{pagi.keyword}%");
            }
            switch (pagi.OrderBy)//构建排序规则
            {
                case OrderBy.价格:
                    sql.OrderBy("price");
                    break;
                case OrderBy.价格倒序:
                    sql.OrderBy("price Desc");
                    break;
                case OrderBy.上市时间:
                    sql.OrderBy("ListedTime");
                    break;
                case OrderBy.上市时间倒序:
                    sql.OrderBy("ListedTime Desc");
                    break;
                case OrderBy.大于价格区间:
                    if (pagi.Price.HasValue)
                    {
                        sql.Where("Price >@0", pagi.Price.Value);
                    }
                    break;
                case OrderBy.小于价格区间:
                    if (pagi.Price.HasValue)
                    {
                        sql.Where("Price <@0", pagi.Price.Value);
                    }
                    break;
                case OrderBy.大于上市时间:
                    if (pagi.ListedTime.HasValue)
                    {
                        sql.Where("ListedTime >'@0'", pagi.ListedTime.Value);
                    }
                    break;
                case OrderBy.小于上市时间:
                    if (pagi.ListedTime.HasValue)
                    {
                        sql.Where("ListedTime <'@0'", pagi.ListedTime.Value);
                    }
                    break;
            }
            return db.Page<Phone>(pagi.page, pagi.pageSize, sql);
        }
    }
}
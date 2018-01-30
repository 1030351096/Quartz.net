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
     * 接口名称：       IphoneconfigRepository
     * 机器名称：       DESKTOP-DS9CMVK
     * 命名空间：       webCore.repository
     * 文 件 名：       IphoneconfigRepository
     * 创建时间：       2018/1/19 13:19:35
     * 作    者：         xxx
     * 说   明：
     * 修改时间：
     * 修 改 人：
*************************************************************************************/
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webCore.repository
{
    public interface IphoneconfigRepository
    {
        /// <summary>
        /// 通过phoneid返回PhoneConfig
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>PhoneConfig</returns>
        PhoneConfig GetPhoneConfigByid(int id);


    }
}

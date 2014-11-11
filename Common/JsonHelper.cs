using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Common
{
    public class JsonHelper
    {
        /// <summary>
        /// 返回json字符串结果
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string ToJson(this object model)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(model);
        }
    }
}

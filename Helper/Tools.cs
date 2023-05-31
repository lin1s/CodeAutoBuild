using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAutoBuild.Helper
{
    public static class Tools
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">枚举对象</param>
        /// <returns></returns>
        public static List<ComboData> GetEmunList(Type type)
        {
            List<ComboData> emunList = new List<ComboData>();
            foreach (var value in Enum.GetValues(type))
            {
                ComboData comboData = new ComboData()
                {
                    Key= Convert.ToInt32(value).ToString(),
                    Value= value.ToString()

                };
                emunList.Add(comboData);
            }

            return emunList;
        }

    }

    public class ComboData
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }

}

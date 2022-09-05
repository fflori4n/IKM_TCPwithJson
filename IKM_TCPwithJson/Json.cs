using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace IKM_TCPwithJson
{
    public static class JSON
    {
        public static T FromJson<T>(string input)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(input);
        }

        public static string ToJson(object input)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Console.WriteLine(serializer.Serialize(input));
            return serializer.Serialize(input);
        }
    }
}

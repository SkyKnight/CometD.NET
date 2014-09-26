using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Cometd.Common
{
    public class JsonHelper
    {
        public static void FixDeserializing(IDictionary<string, object> obj)
        {
            var keys = obj.Keys.ToArray();

            foreach (var k in keys)
            {
                JContainer jcontainer = obj[k] as JContainer;

                if (jcontainer != null)
                {
                    if(jcontainer.Type == JTokenType.Array)
                        obj[k] = jcontainer.ToObject<List<object>>();
                    else if(jcontainer.Type == JTokenType.Object)
                        obj[k] = jcontainer.ToObject<Dictionary<string, object>>();
                }
            }
        }

        public static void FixDeserializing(IList<IDictionary<string, object>> obj)
        {
            foreach (var item in obj)
            {
                FixDeserializing(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Post02.Console
{
    public static class ReflectionUtils
    {

        public static void ServiceMethods()
        {
            var methods = typeof(IDataService).GetMethods()
                .Select(p => new
                {
                    Name = p.Name,
                    ReturnType = p.ReturnType.FullName ==
                        "System.Void" ? "void" : p.ReturnType.FullName,
                    Parameters = p.GetParameters()
                        .Select(q => new
                        {
                            q.ParameterType,
                            q.Name
                        })
                        .ToArray()
                })
                .ToArray();
            
        }
    }
}

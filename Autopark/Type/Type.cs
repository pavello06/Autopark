using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Autopark.Type
{
    public static class Type
    {
        public static System.Type[] GetTypes()
        {
            Assembly[] allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            System.Type[] allTypes = allAssemblies
                .SelectMany(assembly =>
                {
                    try
                    {
                        return assembly.GetTypes();
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        return ex.Types.Where(t => t != null);
                    }
                })
                .ToArray()!;
            return allTypes;
        }
    }
}

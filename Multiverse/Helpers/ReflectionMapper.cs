using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Multiverse.Helpers;
public static class ReflectionHelper
{
    public static IEnumerable<T> GetStaticFieldsOfType<T>()
    {
        Type type = typeof(T);

        var fields = type.GetFields(
           BindingFlags.Public | BindingFlags.Static)
          .Where(f => f.FieldType == type)
          .Select(f => (T)f.GetValue(default)!);

        return fields;
    }
}

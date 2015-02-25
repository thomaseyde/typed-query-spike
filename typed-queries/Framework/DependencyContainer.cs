using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace typed_queries.Framework
{
    [DebuggerStepThrough]
    internal static class DependencyContainer
    {
        public static T Resolve<T>()
        {
            return (T) Resolve(typeof (T));
        }

        static object Resolve(Type type)
        {
            var implementor = types.Single(type.IsAssignableFrom);
            var parameters = ConstructorParameters(implementor);
            return Activator.CreateInstance(implementor, parameters);
        }

        static object[] ConstructorParameters(Type implementor)
        {
            var constructor = Constructor(implementor);

            return constructor == null 
                ? new object[0] 
                : constructor.GetParameters().Select(info => Resolve(info.ParameterType)).ToArray();
        }

        static ConstructorInfo Constructor(Type implementor)
        {
            var constructors = implementor.GetConstructors();

            ConstructorInfo constructor = null;

            foreach (var current in constructors)
            {
                if (constructor == null || current.GetParameters().Length > constructor.GetParameters().Length)
                {
                    constructor = current;
                }
            }
            return constructor;
        }

        static readonly Type[] types = Assembly.GetExecutingAssembly().GetTypes();
    }
}
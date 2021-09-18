using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            // Alttaki kodu eklersem ve file logger yazarsam her metodda burası çalışır ve süreleri loglarım!
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
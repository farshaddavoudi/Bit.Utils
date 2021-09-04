using System.Reflection;
using Autofac;
using Bit.Core.Contracts;
using Bit.Model.Contracts;

namespace Bit.Utils.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IDependencyManagerExtensions
    {
        public static void RegisterAutoMapperConfigurations(this IDependencyManager dependencyManager, Assembly[] assemblies)
        {
            dependencyManager
                .GetContainerBuilder()
                .RegisterAssemblyTypes(assemblies)
                .AssignableTo<IMapperConfiguration>()
                .Where(type => type.IsClass && !type.IsAbstract)
                .PropertiesAutowired(PropertyWiringOptions.PreserveSetValues)
                .AsImplementedInterfaces()
                .PreserveExistingDefaults();
        }
    }
}

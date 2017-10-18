using eManager.Domain;
using eManager.Infraestructure;
using StructureMap;
namespace eManager {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDepartmentDataSource>().HttpContextScoped().Use<DeparmentDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}
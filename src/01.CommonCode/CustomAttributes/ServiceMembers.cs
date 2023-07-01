using System.Reflection;

namespace Exercise.CommonCode.CustomAttributes
{
    #region ServiceMembers Attributes
    public enum ServiceType
    {
        Singleton,
        Scope,
        Transient
    }

    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
    public class ServiceMembers : Attribute
    {
        public ServiceType ServiceType { get; set; }

        public static ServiceType GetServiceType(Type classType)
        {
            var attributeObject = classType.GetCustomAttributes()
                .Where(t => t is ServiceMembers)
            .FirstOrDefault() as ServiceMembers;

            Console.WriteLine($"\nType: {classType.Name}, {nameof(attributeObject.ServiceType)}: {attributeObject!.ServiceType}\n");

            return attributeObject!.ServiceType;
        }
    }
    #endregion

    #region Sample ServiceType = ServiceType.Scope
    [ServiceMembers(ServiceType = ServiceType.Scope)]
    public interface IMyRestClient
    {
        void GetAccessToken();
    }

    public abstract class BaseMyRestClient
    {
        public virtual void GetAccessToken()
        {
            Console.WriteLine($"Method: {MethodBase.GetCurrentMethod()!.Name} from Class: {GetType().Name}");
        }
    }

    public class MyRestClient01 : BaseMyRestClient, IMyRestClient
    {
        public override void GetAccessToken()
        {
            base.GetAccessToken();
        }
    }

    public class MyRestClient02 : BaseMyRestClient, IMyRestClient
    {
        public override void GetAccessToken()
        {
            base.GetAccessToken();
        }
    }
    #endregion

    #region ServiceType = ServiceType.Singleton
    [ServiceMembers(ServiceType = ServiceType.Singleton)]
    public interface IInformationInMemory
    {
        public string Username { get; set; }
    }

    public class AppUserInfo : IInformationInMemory
    {
        public string Username { get; set; } = $"Hi, This is User from {nameof(AppUserInfo)}";
    }
    #endregion
}

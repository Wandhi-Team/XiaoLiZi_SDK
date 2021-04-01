using SDK.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RobotCore
{
    public static class RegisterCore
    {
        public static void Register(IUnityContainer unityContainer, Assembly[] assemblies)
        {
            foreach (var item in assemblies)
            {
                var enables = item.GetTypes().Where(a => a.GetInterfaces().Contains(typeof(IAppEnableEvent)));
                var recvices = item.GetTypes().Where(a => a.GetInterfaces().Contains(typeof(IRecvicetPrivateMessage)));
                var groupMessages = item.GetTypes().Where(a => a.GetInterfaces().Contains(typeof(IGroupMessage)));
                var appSettings = item.GetTypes().Where(a => a.GetInterfaces().Contains(typeof(IAppSetting)));
                var eventCallBacks = item.GetTypes().Where(a => a.GetInterfaces().Contains(typeof(IEventcallBack)));

                enables.Select(a => unityContainer.RegisterType(typeof(IAppEnableEvent), a));
                recvices.Select(a => unityContainer.RegisterType(typeof(IRecvicetPrivateMessage), a));
                groupMessages.Select(a => unityContainer.RegisterType(typeof(IGroupMessage), a));
                appSettings.Select(a => unityContainer.RegisterType(typeof(IAppSetting), a));
                eventCallBacks.Select(a => unityContainer.RegisterType(typeof(IEventcallBack), a));
            }
        }
    }
}
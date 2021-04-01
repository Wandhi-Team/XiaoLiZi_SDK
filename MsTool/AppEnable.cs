using System.Linq;
using System.Reflection;
using MsTool.Custom.Interface;
using SDK;
using SDK.Events;
using SDK.Interface;
using Unity;

namespace MsTool
{
    public class AppEnable : IAppEnableEvent
    {
        public void AppEnableEvent(AppEnableEvent e)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            
            //注册群消息服务集
            var groupMessageServices = types.Where(a => a.GetInterfaces().Contains(typeof(IGroupMessageEvent)));

            foreach (var item in groupMessageServices)
            {
                Common.unityContainer.RegisterType(typeof(IGroupMessageEvent),item,item.Name);
            }     
            
            
            //注册私聊消息服务集
            var friendMessageServices=types.Where(a => a.GetInterfaces().Contains(typeof(IFriendMessageEvent)));
            foreach (var item in friendMessageServices)
            {
                Common.unityContainer.RegisterType(typeof(IFriendMessageEvent),item,item.Name);
            }
        }
    }
}
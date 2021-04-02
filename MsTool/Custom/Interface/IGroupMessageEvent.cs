using SDK.Events;

namespace MsTool.Custom.Interface
{
    public interface IGroupMessageEvent:IMessageEvent
    {
        void MessageEvent(GroupMessageEvent messageEvent);
    }
}
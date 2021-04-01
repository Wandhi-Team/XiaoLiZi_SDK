using SDK.Events;

namespace MsTool.Custom.Interface
{
    public interface IGroupMessageEvent
    {
        void MessageEvent(PrivateMessageEvent messageEvent);
    }
}
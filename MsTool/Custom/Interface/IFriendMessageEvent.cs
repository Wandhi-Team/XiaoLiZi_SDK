using SDK.Events;

namespace MsTool.Custom.Interface
{
    public interface IFriendMessageEvent:IMessageEvent
    {
        void MessageEvent(PrivateMessageEvent messageEvent);
    }
}
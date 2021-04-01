using SDK.Events;

namespace MsTool.Custom.Interface
{
    public interface IFriendMessageEvent
    {
        void MessageEvent(GroupMessageEvent messageEvent);
    }
}
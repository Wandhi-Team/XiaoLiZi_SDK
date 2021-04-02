namespace MsTool.Custom.Interface
{
    public interface IMessageEvent
    {
        /// <summary>
        /// 是否继续分发消息
        /// </summary>
        /// <returns></returns>
        bool IsBlock();
    }
}
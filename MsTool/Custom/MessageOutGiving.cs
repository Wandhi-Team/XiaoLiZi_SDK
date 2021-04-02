using MsTool.Custom.Interface;
using SDK;
using SDK.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace MsTool.Custom
{
    public class MessageOutGiving
    {
        /// <summary>
        /// 群消息分发
        /// </summary>
        /// <param name="e"></param>
        public void MessageGiving(GroupMessageEvent e)
        {
            var types = Common.unityContainer.ResolveAll<IGroupMessageEvent>();

            foreach (var item in types)
            {
                Task.Factory.StartNew(() =>
                {
                    item.MessageEvent(e);
                });
                if (!item.IsBlock())
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 私聊消息分发
        /// </summary>
        /// <param name="e"></param>
        public void MessageGiving(PrivateMessageEvent e)
        {
            var types = Common.unityContainer.ResolveAll<IFriendMessageEvent>();

            foreach (var item in types)
            {
                Task.Factory.StartNew(() =>
                {
                    item.MessageEvent(e);
                });
                if (!item.IsBlock())
                {
                    break;
                }
            }
        }      

        /// <summary>
        /// 通用事件分发
        /// </summary>
        /// <param name="e"></param>
        
        public void MessageGiving(EventTypeBase e)
        {
            var types = Common.unityContainer.ResolveAll<ICommonEvent>();

            foreach (var item in types)
            {
                Task.Factory.StartNew(() =>
                {
                    item.MessageEvent(e);
                });
                if (!item.IsBlock())
                {
                    break;
                }
            }
        }
    }
}

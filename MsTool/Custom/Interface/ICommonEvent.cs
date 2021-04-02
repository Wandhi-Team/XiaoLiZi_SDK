using SDK.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTool.Custom.Interface
{
    public interface ICommonEvent:IMessageEvent
    {
        void MessageEvent(EventTypeBase e);
    }
}

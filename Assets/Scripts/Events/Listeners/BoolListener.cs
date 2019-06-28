using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;

namespace DapperDino.Events.Listeners
{
    public class BoolListener : BaseGameEventListener<bool, BoolEvent, UnityBoolEvent> { }
}

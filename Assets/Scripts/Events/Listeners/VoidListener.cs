using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;

namespace DapperDino.Events.Listeners
{
    public class VoidListener : BaseGameEventListener<Void, VoidEvent, UnityVoidEvent> { }
}

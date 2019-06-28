using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;

namespace DapperDino.Events.Listeners
{
    public class FloatListener : BaseGameEventListener<float, FloatEvent, UnityFloatEvent> { }
}

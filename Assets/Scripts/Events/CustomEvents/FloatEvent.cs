using UnityEngine;

namespace DapperDino.Events.CustomEvents
{
    [CreateAssetMenu(fileName = "New Float Event", menuName = "Game Events/Float Event")]
    public class FloatEvent : BaseGameEvent<float> { }
}

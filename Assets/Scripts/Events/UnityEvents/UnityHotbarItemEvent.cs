using DapperDino.Items.Hotbars;
using System;
using UnityEngine.Events;

namespace DapperDino.Events.UnityEvents
{
    [Serializable] public class UnityHotbarItemEvent : UnityEvent<HotbarItem> { }
}
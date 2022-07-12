using System;
using Qurre;
using Qurre.API.Events;
using Qurre.Events;

namespace HitMarker
{
    public class HitMarker : Plugin
    {
        public override string Developer => "KoT0XleB#4663";
        public override string Name => "Hitmarker";
        public override Version Version => new Version(1, 0, 0);
        public override int Priority => int.MinValue;
        public override void Enable() => Player.DamageProcess += OnDamageProcess;
        public override void Disable() => Player.DamageProcess -= OnDamageProcess;
        public static void OnDamageProcess(DamageProcessEvent ev)
        {
            string color = "red";
            if (ev.Attacker.Team != Team.SCP)
            {
                if (ev.Target.Ahp > 0) color = "42aaff";
                else color = "ff0000";
                ev.Attacker.ShowHint($"       <size=25><color=#{color}>X</color></size>  <size=25>[<color=#{color}>{(int)ev.Amount}</color>]\n\n\n\n\n\n\n\n\n\n\n", 2f);
            }
        }
    }
}

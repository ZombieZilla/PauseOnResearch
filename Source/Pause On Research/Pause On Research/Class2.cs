using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using Verse.Sound;
using RimWorld;

namespace Pause_On_Research
{
    [StaticConstructorOnStartup]
    public class ImStuff : GameComponent
    {

        public ImStuff(Game game)
        {}

        private readonly KeyBindingDef ResearchStart = KeyBindingDef.Named("Dostuff");

        public override void GameComponentUpdate()
        {
            if (ResearchStart.IsDown)
            {
                SoundDefOf.HissJet.PlayOneShotOnCamera();
            }
        }
    }
}

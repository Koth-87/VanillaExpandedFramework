﻿using System;
using Verse;
using System.Collections.Generic;

namespace VEF.AnimalBehaviours
{
    public class HediffCompProperties_Regeneration : HediffCompProperties
    {
        //This is equivalent to the CompRegeneration class, but just adds things through a hediff

        public int rateInTicks = 1000;
        public float healAmount = 0.1f;
        public bool healAll = true;
        public bool needsSun = false;
        public bool needsWater = false;
        public bool onlyBleeding = false;
        public bool onlyTendButNotHeal = false;
        public float tendMin = 0.7f;
        public float tendMax = 1f;

        //If not null, regeneration will only affect this BodyPartDef
        public BodyPartDef bodypart = null;

        public HediffCompProperties_Regeneration()
        {
            this.compClass = typeof(HediffComp_Regeneration);
        }
    }
}

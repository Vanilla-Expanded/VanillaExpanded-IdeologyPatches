using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;

namespace VEIP
{
    public class PlaceWorker_LinkToStoneCampfire : PlaceWorker
    {
        public float range = 11.9f;

        public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
        {
            GenDraw.DrawRadiusRing(center, this.range);
            ThingDef campfire = DefDatabase<ThingDef>.GetNamedSilentFail("Stone_Campfire");
            if (campfire != null)
            {
                List<Thing> forCell = Find.CurrentMap.listerBuldingOfDefInProximity.GetForCell(center, this.range, campfire);
                for (int index = 0; index < forCell.Count; ++index)
                    GenDraw.DrawLineBetween(GenThing.TrueCenter(center, Rot4.North, def.size, def.Altitude), forCell[index].TrueCenter(), SimpleColor.Green);
            }
        }
    }

    public class PlaceWorker_LinkToDarkStoneCampfire : PlaceWorker
    {
        public float range = 11.9f;

        public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
        {
            GenDraw.DrawRadiusRing(center, this.range);
            ThingDef campfire = DefDatabase<ThingDef>.GetNamedSilentFail("Stone_DarklightCampfire");
            if (campfire != null)
            {
                List<Thing> forCell = Find.CurrentMap.listerBuldingOfDefInProximity.GetForCell(center, this.range, campfire);
                for (int index = 0; index < forCell.Count; ++index)
                    GenDraw.DrawLineBetween(GenThing.TrueCenter(center, Rot4.North, def.size, def.Altitude), forCell[index].TrueCenter(), SimpleColor.Green);
            }
        }
    }
}
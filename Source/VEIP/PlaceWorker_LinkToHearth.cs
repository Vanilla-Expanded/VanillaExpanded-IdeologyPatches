using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace VEIP
{
    class PlaceWorker_LinkToHearth : PlaceWorker
    {
        public float range = 11.9f;

        public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
        {
            GenDraw.DrawRadiusRing(center, this.range);
            ThingDef campfire = DefDatabase<ThingDef>.GetNamedSilentFail("VFEV_Hearth");
            if (campfire != null)
            {
                List<Thing> forCell = Find.CurrentMap.listerBuldingOfDefInProximity.GetForCell(center, this.range, campfire);
                for (int index = 0; index < forCell.Count; ++index)
                    GenDraw.DrawLineBetween(GenThing.TrueCenter(center, Rot4.North, def.size, def.Altitude), forCell[index].TrueCenter(), SimpleColor.Green);
            }
        }
    }

    class PlaceWorker_LinkToDarkHearth : PlaceWorker
    {
        public float range = 11.9f;

        public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
        {
            GenDraw.DrawRadiusRing(center, this.range);
            ThingDef campfire = DefDatabase<ThingDef>.GetNamedSilentFail("VFEV_DarkHearth");
            if (campfire != null)
            {
                List<Thing> forCell = Find.CurrentMap.listerBuldingOfDefInProximity.GetForCell(center, this.range, campfire);
                for (int index = 0; index < forCell.Count; ++index)
                    GenDraw.DrawLineBetween(GenThing.TrueCenter(center, Rot4.North, def.size, def.Altitude), forCell[index].TrueCenter(), SimpleColor.Green);
            }
        }
    }
}

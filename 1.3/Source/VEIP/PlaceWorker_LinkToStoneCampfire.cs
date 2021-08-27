using RimWorld;
using System.Collections.Generic;
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
            List<Thing> forCell = Find.CurrentMap.listerBuldingOfDefInProximity.GetForCell(center, this.range, VEIP_DefOf.Stone_Campfire);
            for (int index = 0; index < forCell.Count; ++index)
                GenDraw.DrawLineBetween(GenThing.TrueCenter(center, Rot4.North, def.size, def.Altitude), forCell[index].TrueCenter(), SimpleColor.Green);
        }
    }
}
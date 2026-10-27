using Rimatomics;
using Verse;

namespace _1001_FastPlutonium
{
    public class FastBreederReactor:Rimatomics.reactorCore
    {
        public override int SlotCount => 16; //May need to be 21 to avoid problems
        public override bool IsBreeder => true;

        public override ThingDef PoppedCoreDef => ThingDef.Named("PoppedReactorCoreA");

        public override bool IsBuilt => DubDef.AdvReactor3.IsFinished;

        //No need to override Graphic unless I build this out into a project

        //Relevant: public Dictionary<int, RodStatus> SlotStatus = new Dictionary<int, RodStatus>();
    }
}

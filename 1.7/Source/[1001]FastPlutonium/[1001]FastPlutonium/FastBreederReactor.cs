using Rimatomics;
using Verse;

namespace _1001_FastPlutonium
{
    public class FastBreederReactor:Rimatomics.reactorCore
    {
        public override int SlotCount => 21; //May need to be 21 to avoid problems
        public override bool IsBreeder => true;

        public override ThingDef PoppedCoreDef => ThingDef.Named("PoppedReactorCoreA");

        public override bool IsBuilt => DubDef.AdvReactor3.IsFinished;

        public new float ConversionRatio
        {
            get
            {
                return 0.8f;
            }
        }

        public override void Tick()
        {
            base.Tick();
            for (int i = 0; i < FuelCount; i++)
            {
                Item_NuclearFuel item_NuclearFuel = FuelGrid[i];
                for(int j = 0; j < 9; ++j)
                {
                    item_NuclearFuel.FissionEvent(this);
                }
                
            }
        }

        //No need to override Graphic unless I build this out into a project

        //Relevant: public Dictionary<int, RodStatus> SlotStatus = new Dictionary<int, RodStatus>();
    }
}

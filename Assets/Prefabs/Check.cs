using System;
using StarterAssets.Proposals;
using UnityEngine;

namespace Prefabs
{
    public class Check : MonoBehaviour
    {
        private void Start()
        {
            CampainTown someTown = new CampainTown();
            
            ProposalHelper.GetBuildingRelatedProposalOptions(someTown.GetBuildingSlotManager());    
        }

        public void method()
        {
            
        }
    }
    
    public abstract class Base
    {
        protected abstract void Do();
        void Call() { Do(); }
    }

    public class A : Base
    {
        protected override void Do()
        {
            throw new NotImplementedException();
        }
    }

    public class B : Base
    {
        protected override void Do()
        {
            throw new NotImplementedException();
        }

        void Other() { Do(); }
    }
}
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.Rendering;

namespace StarterAssets.Proposals
{
    public class ProposalHelper
    {
        public static List<ProposalOption> GenerateNewConstructionProposalsOnly(CampainTown _town)
        {
            var buildingSlotManager = _town.GetBuildingSlotManager();
            return GetBuildingRelatedProposalOptions(buildingSlotManager);
        }

        public static List<ProposalOption> GetBuildingProposalOptions(CampainOfficer _officer)
        {
            var buildingSlotManager = _officer.GetBuildingSlotManager();
            return GetBuildingRelatedProposalOptions(buildingSlotManager, true, false);
        }

        public static List<ProposalOption> GetBuildingRelatedProposalOptions(BuildingSlotManager manager,
            bool addNewConstruction = false, bool addBuildingTASK = false)
        {
            List<ProposalOption> rezult = new List<ProposalOption>();
            return rezult;
        }
    }

    public class CampainOfficer
    {
        private static BuildingSlotManager _buildingSlotManagerInstance;

        public BuildingSlotManager GetBuildingSlotManager()
        {
            if (_buildingSlotManagerInstance == null)
                _buildingSlotManagerInstance = new BuildingSlotManager();
            return _buildingSlotManagerInstance;
        }
    }

    public class CampainTown
    {
        private static BuildingSlotManager _buildingSlotManagerInstance;

        public BuildingSlotManager GetBuildingSlotManager()
        {
            if (_buildingSlotManagerInstance == null)
                _buildingSlotManagerInstance = new BuildingSlotManager();
            return _buildingSlotManagerInstance;
        }
    }

    public class BuildingSlotManager
    {}
}
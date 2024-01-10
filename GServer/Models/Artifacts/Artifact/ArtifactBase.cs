using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{

    public enum ArtifactType
    {
        CityPortalArtifact,
        DragonBaitArtifact,
        DragonScalesArtifact,
        ElixirArtifact,
        InvisibilityRingArtifact,
        SwordArtifact,
        TalismanArtifact,
        ThieveToolsArtifact,
        WandArtifact,
        ScrollArtidact
    }
    public abstract class ArtifactBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ArtifactType ArtifactType { get; set; }
        public bool IsCanByUsed { get; set; }
    }
}

using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public abstract class ArtifactBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public bool IsCanByUsed { get; set; }

       
    }
}

using GServer.Models.Artifacts.Interfaces;


namespace GServer.Models.Artifacts
{
    // Чешуйки дракона
    public class DragonScalesArtifact : ArtifactBase, IArtifactItem
    {

        public DragonScalesArtifact()
        {
            Name = "Приманка для дракона";
            ArtifactType = ArtifactType.DragonScalesArtifact;
            Description = "";
            IsCanByUsed = true;
        }


    }
}

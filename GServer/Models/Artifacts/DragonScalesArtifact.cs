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

        public string UseArtifact()
        {
            ArtifactStorage.ArtifactStorage.AddUsedArtifact(this);
            string str = "";

            if (this.IsCanByUsed)
                str = $"Артефакт {this.Name}: использован";
            else
                str = $"Артефакт {this.Name}: невозможно использовать";
            return str;
        }
    }
}

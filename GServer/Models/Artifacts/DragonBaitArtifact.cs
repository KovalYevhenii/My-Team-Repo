using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public class DragonBaitArtifact : ArtifactBase, IArtifactItem
    {

        public DragonBaitArtifact()
        {
            Name = "Драконьи чешуйки";
            ArtifactType = ArtifactType.DragonBaitArtifact;
            Description = "";
            IsCanByUsed = false;
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

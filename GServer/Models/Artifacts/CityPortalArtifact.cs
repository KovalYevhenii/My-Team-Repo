using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public class CityPortalArtifact : ArtifactBase, IArtifactItem
    {
        public CityPortalArtifact()
        {
            Name = "Городской портал";
            ArtifactType = ArtifactType.CityPortalArtifact;
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

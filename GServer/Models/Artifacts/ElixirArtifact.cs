using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public class ElixirArtifact : ArtifactBase, IArtifactItem
    {
        public ElixirArtifact()
        {
            Name = "Эликсир";
            ArtifactType = ArtifactType.ElixirArtifact;
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

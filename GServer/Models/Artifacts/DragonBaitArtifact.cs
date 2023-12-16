using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public class DragonBaitArtifact : ArtifactBase, IArtifactItem
    {
        public string UseArtifact()
        {
            string str = "";

            if (this.IsCanByUsed)
                str = $"Артефакт {this.Name}: использован";
            else
                str = $"Артефакт {this.Name}: невозможно использовать";
            return str;

        }
    }
}

using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public class SwordArtifact : ArtifactBase// IMag, IPaladin, AThieve ...
    {

        public override string UseArtifact()
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

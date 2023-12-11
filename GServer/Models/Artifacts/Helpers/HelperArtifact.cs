
namespace GServer.Models.Artifacts.Helpers
{
    public static class HelperArtifact
    {


        public static ArtifactBase GetArtifact(string artifact)
        {


            // Link to Db
            ArtifactBase _artifact = null!;

            switch (artifact)
            {
                case "Разящий меч":
                    _artifact = new SwordArtifact();
                    break;
                case "Кольцо невидимости":
                    _artifact = new RingArtifact() { Id = 2, Name = "Кольцо невидимости", Description = "Очень классное колечко", IsCanByUsed = true };
                    break;
                case "Талисман":
                    _artifact = new TalismanArtifact() { Id = 1, Name = "Талисман", Description = "Очень важный талисман", IsCanByUsed = true };
                    break;
                case "Воровские инструменты":
                    _artifact = new ThieveToolsArtifact();
                    break;
                case "Жезл силы":
                    _artifact = new WandArtifact();
                    break;
                case "Драконьи чешуйки":
                    _artifact = new WandArtifact();
                    break;


            } // switch

            return _artifact;
        }
        public static ArtifactBase GetArtifact()
        {


            // Link to Db
            string _artifactName = "Талисман";
            ArtifactBase _artifact = null!;

            switch (_artifactName)
            {
                case "Разящий меч":
                    _artifact = new SwordArtifact();
                    break;
                case "Кольцо невидимости":
                    _artifact = new RingArtifact();
                    break;
                case "Талисман":
                    _artifact = new TalismanArtifact() { Id = 1, Name = "Талисман", Description = "Очень важный талисман", IsCanByUsed = true  };
                    break;
                case "Воровские инструменты":
                    _artifact = new ThieveToolsArtifact();
                    break;
                case "Жезл силы":
                    _artifact = new WandArtifact();
                    break;
                case "Драконьи чешуйки":
                    _artifact = new WandArtifact();
                    break;


            } // switch

            return _artifact;
        }



    }
}

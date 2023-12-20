namespace GServer.Models.Artifacts.ArtifactStorage
{
    public static class ArtifactStorage
    {
        static ICollection<ArtifactBase> _artifacts;

        static ArtifactStorage()
        {
            _artifacts = new List<ArtifactBase>() {
                 new SwordArtifact(){Id = 1},
                 new SwordArtifact(){Id = 2},
                 new SwordArtifact(){Id = 3},
                 
                 new TalismanArtifact(){Id = 4},
                 new TalismanArtifact(){Id = 5},
                 new TalismanArtifact(){Id = 6},
                 
                 new WandArtifact(){Id = 7},
                 new WandArtifact(){Id = 8},
                 new WandArtifact(){Id = 9},
                 
                
                 new ScrollArtifact(){Id = 10},
                 new ScrollArtifact(){Id = 11},
                 new ScrollArtifact(){Id = 12},
                 
                 new ThieveToolsArtifact(){Id = 13},
                 new ThieveToolsArtifact(){Id = 14},
                 new ThieveToolsArtifact(){Id = 15},
                 
                 new InvisibilityRingArtifact(){Id = 16},
                 new InvisibilityRingArtifact(){Id = 17},
                 new InvisibilityRingArtifact(){Id = 18},
                 new InvisibilityRingArtifact(){Id = 19},
                 
                
                 new DragonBaitArtifact(){Id = 20},
                 new DragonBaitArtifact(){Id = 21},
                 new DragonBaitArtifact(){Id = 22},
                 new DragonBaitArtifact(){Id = 23},
                 new DragonBaitArtifact(){Id = 24},
                 new DragonBaitArtifact(){Id = 25},
                 
                 new ElixirArtifact(){Id = 26},
                 new ElixirArtifact(){Id = 27},
                 new ElixirArtifact(){Id = 28},
                 
                 new DragonScalesArtifact(){Id = 29},
                 new DragonScalesArtifact(){Id = 30},
                 new DragonScalesArtifact(){Id = 31},
                 new DragonScalesArtifact(){Id = 32},

                 new CityPortalArtifact(){Id = 33},
                 new CityPortalArtifact(){Id = 34},
                 new CityPortalArtifact(){Id = 35},
                 new CityPortalArtifact(){Id = 36},
                

            
            
            };
        }

        public static ArtifactBase GetArtifact() {

            // P.S. Нид протестить

            // Получить случайный артефакт через рандом и удалить его из статического массива.
            ArtifactBase artifact = _artifacts.First(art => (art.Id - 1) == new Random().Next(_artifacts.Count));
            _artifacts.Remove(artifact);
            return artifact;
        }


        // Вернуть использованный артифакт в Хранилище
        public static void AddUsedArtifact(ArtifactBase artifact) {
           _artifacts.Add(artifact);
        }
    }
}

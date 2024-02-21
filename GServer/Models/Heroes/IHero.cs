namespace GServer.Models.Heroes
{
    public interface IHero
    {
        public HeroType GetType();
        void ChangeLavel();
    }
}

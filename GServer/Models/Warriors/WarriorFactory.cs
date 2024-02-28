using GServer.Models.Heroes;

namespace GServer.Models.Warriors
{
    public class WarriorFactory
    {
        private Warrior warrior;

        public WarriorFactory(WarriorType warriorType) {

            switch (warriorType)
            {
                case WarriorType.Scroll:
                    Warrior = new Scroll();
                    break;
                case WarriorType.Cleric:
                    Warrior = new Cleric();
                    break;
                case WarriorType.Mage:
                    Warrior = new Mage();
                    break;
                case WarriorType.Guard:
                    Warrior = new Guard();
                    break;
                case WarriorType.Thief:
                    Warrior = new Thief();
                    break;
                default:
                    Warrior = new Cleric();
                    break;
            }
        }

        protected Warrior Warrior { get => warrior; set => warrior = value; }
    }
}

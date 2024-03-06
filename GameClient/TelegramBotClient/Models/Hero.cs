using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotClient.Models
{
    public class Hero
    {
        public string hash { get; set; }
        public HeroType type { get; set; }
    }

    public enum HeroType
    {
        ENCHANTRESS,
        SOLDEROFFORTUNE,
        KNIGHT,
        BARD,
        MAGE,
        NECROMANCER,
        CRUSADER,
        GOBLIN
    }
}

using System;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;
using YGOSharp.OCGWrapper.Enums;

namespace WindBot.Game.AI.Decks
{
    [Deck("Toon", "AI_Toon", "Easy")]
    public class ToonExecutor : DefaultExecutor
    {
        public class CardId
        {
            public const int AbyssDweller = 21044178;
            public const int BahamutShark = 440556;
            public const int BorreloadDragon = 31833038;
            public const int BorrelswordDragon = 85289965;
            public const int ChimeratechMegafleetDragon = 87116928;
            public const int ComicHand = 33453260;
            public const int DivineArsenalAAZEUSSkyThunder = 90448279;
            public const int IPMasquerena = 65741786;
            public const int KnightmareCerberus = 75452921;
            public const int KnightmarePhoenix = 2857636;
            public const int KnightmareUnicorn = 38342335;
            public const int Metaverse = 89208725;
            public const int Mimicat = 88032456;
            public const int Number38HopeHarbingerDragonTitanicGalaxy = 63767246;
            public const int Number70MalevolentSin = 80796456;
            public const int OneforOne = 2295440;
            public const int RedEyesToonDragon = 31733941;
            public const int Terraforming = 73628505;
            public const int TheBlackStoneofLegend = 66574418;
            public const int ToadallyAwesome = 90809975;
            public const int ToonBookmark = 91500017;
            public const int ToonBriefcase = 5832914;
            public const int ToonCyberDragon = 83629030;
            public const int ToonDarkMagician = 21296502;
            public const int ToonHarpieLady = 64116319;
            public const int ToonKingdom = 43175858;
            public const int ToonMermaid = 65458948;
            public const int ToonPageFlip = 27699122;
            public const int ToonTableofContents = 89997728;
            public const int ToonTerror = 53094821;
            public const int ToonWorld = 15259704;
            public const int TornadoDragon = 6983839;
            public const int UnderworldGoddessoftheClosedWorld = 98127546;
        }

        public ToonExecutor(GameAI ai, Duel duel) : base(ai, duel)
        {
            /* hand:
                     1  73628505 - Terraforming
                     2  28711704 - Toon Black Luster Soldier
                     3  43175858 - Toon Kingdom
                     4  66574418 - The Black Stone of Legend
                     5  28711704 - Toon Black Luster Soldier
             */
            AddExecutor(ExecutorType.Activate, CardId.Terraforming, TerraformingEffect);
            AddExecutor(ExecutorType.Activate, CardId.ToonKingdom, FieldSpellActivate); // TODO check deck > 3?
            AddExecutor(ExecutorType.Activate, CardId.ToonWorld, ToonWorldEffect);
        }

        private bool TerraformingEffect()
        {
            AI.SelectCard(CardId.ToonKingdom);
            return true;
        }

        private bool FieldSpellActivate()
        {
            //Do not replace own field spell!
            if (Bot.SpellZone[5] != null) {
                return false;
            }
            return true;
        }

        private bool ToonWorldEffect()
        {
            if (Bot.LifePoints <= 1000) return false;
            return true;
        }


    }
}

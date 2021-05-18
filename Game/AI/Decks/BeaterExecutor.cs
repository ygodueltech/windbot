using System;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;
using YGOSharp.OCGWrapper.Enums;

namespace WindBot.Game.AI.Decks
{
    [Deck("Beater", "AI_Beater", "Easy")]
    public class BeaterExecutor : DefaultExecutor
    {
        public class CardId
        {
            public const int AlexandriteDragon = 43096270;
            public const int ShinyblackSquadder=4148264;
            public const int LuterDragon=11091375;
            public const int Zombino=14575467;
            public const int VorseRaider=14898066;
            public const int MyteryShellDragon=18108166;
            public const int InsectKnight=35052053;
            public const int Sabersaurus=37265642;
            public const int Leotron=47226949;
            public const int GeneWarpedWarwolf=69247929;
            public const int PhantomGryphon=74852097;
            public const int EvilswarmHeliotrope=77542832;
            public const int MegalosmasherX=81823360;
            public const int MekkKnightAvram=84754430;
        }

        public BeaterExecutor(GameAI ai, Duel duel) : base(ai, duel)
        {
            Console.WriteLine("foo");
            AddExecutor(ExecutorType.Greedy, -1);
            //AddExecutor(ExecutorType.Summon, CardId.AlexandriteDragon);
            //AddExecutor(ExecutorType.Summon, CardId.ShinyblackSquadder);
            //AddExecutor(ExecutorType.Summon, CardId.LuterDragon);
            //AddExecutor(ExecutorType.Summon, CardId.Zombino);
            //AddExecutor(ExecutorType.Summon, CardId.VorseRaider);
            //AddExecutor(ExecutorType.Summon, CardId.MyteryShellDragon);
            //AddExecutor(ExecutorType.Summon, CardId.InsectKnight);
            //AddExecutor(ExecutorType.Summon, CardId.Sabersaurus);
            //AddExecutor(ExecutorType.Summon, CardId.Leotron);
            //AddExecutor(ExecutorType.Summon, CardId.GeneWarpedWarwolf);
            //AddExecutor(ExecutorType.Summon, CardId.PhantomGryphon);
            //AddExecutor(ExecutorType.Summon, CardId.EvilswarmHeliotrope);
            //AddExecutor(ExecutorType.Summon, CardId.MegalosmasherX);
            //AddExecutor(ExecutorType.Summon, CardId.MekkKnightAvram);
        }

    }
}

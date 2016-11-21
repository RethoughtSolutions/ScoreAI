//     File:  ScoreAI/ScoreAITest/Program.cs
//     Copyright (C) 2016 Rethought and SupportExTraGoZ
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//     Created: 20.11.2016 11:37 PM
//     Last Edited: 20.11.2016 11:40 PM

namespace ScoreAITest
{
    #region Using Directives

    using System;

    using ScoreAI;
    using ScoreAI.Action;
    using ScoreAI.Context;
    using ScoreAI.Qualifier;
    using ScoreAI.Scorer;
    using ScoreAI.Selector;

    #endregion

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            var writingAI = new AIClient<WritingContext>(new WritingContextProvider());
            {
                var selector = new HighestScoreWinsSelector<WritingContext>();
                writingAI.RootSelector = selector;
                {
                    var qualifier = new SumOfChildrenQualifier<WritingContext>();
                    selector.AddQualifier(qualifier);
                    {
                        qualifier.AddScorer(new EloBuddyLetterScorer());
                        qualifier.AddScorer(new EloBuddyPageScorer());

                        qualifier.SetAction(new ReadBook("EloBuddy"));
                    }
                }
                {
                    var qualifier = new SumOfChildrenQualifier<WritingContext>();
                    selector.AddQualifier(qualifier);
                    {
                        qualifier.AddScorer(new LeagueSharpLetterScorer());
                        qualifier.AddScorer(new LeagueSharpPageScorer());

                        qualifier.SetAction(new ReadBook("LeagueSharp"));
                    }
                }
            }

            writingAI.Tick();
            Console.ReadKey();
        }

        public class ReadBook : ActionBase<WritingContext>
        {
            private readonly string bookname;

            public ReadBook(string bookname)
            {
                this.bookname = bookname;
            }
            public override void Execute(WritingContext context)
            {
                Console.WriteLine("Reading " + this.bookname);
            }
        }

        public class EloBuddyLetterScorer : ContextualScorerBase<WritingContext>
        {
            public override float Score(WritingContext context)
            {
                var score = (1f / context.EloBuddy.AmountOfLetters) * 100000;

                Console.WriteLine(nameof(EloBuddyLetterScorer) + " scored: " + score);

                return score;
            }
        }

        public class EloBuddyPageScorer : ContextualScorerBase<WritingContext>
        {
            public override float Score(WritingContext context)
            {
                var score = 1f / context.EloBuddy.AmountOfSites * 100000;

                Console.WriteLine(nameof(EloBuddyPageScorer) + " scored: " + score);

                return score;
            }
        }
        public class LeagueSharpPageScorer : ContextualScorerBase<WritingContext>
        {
            public override float Score(WritingContext context)
            {
                var score = 1f / context.LeagueSharp.AmountOfSites * 100000;

                Console.WriteLine(nameof(LeagueSharpPageScorer) + " scored: " + score);

                return score;
            }
        }

        public class LeagueSharpLetterScorer : ContextualScorerBase<WritingContext>
        {
            public override float Score(WritingContext context)
            {
                var score = 1f / context.LeagueSharp.AmountOfLetters * 100000;

                Console.WriteLine(nameof(LeagueSharpLetterScorer) + " scored: " + score);

                return score;
            }
        }


        #endregion

        public class WritingContext : IContext
        {
            public class Book
            {
                public int AmountOfLetters { get; set; }

                public int AmountOfSites { get; set; }

                public Book(int amountOfLetters = 0, int amountOfSites = 0)
                {
                    this.AmountOfLetters = amountOfLetters;
                    this.AmountOfSites = amountOfSites;
                }
            }

            public Book EloBuddy { get; set; } = new Book(1565, 21);

            public Book LeagueSharp { get; set; } = new Book(6252, 10);
        }

        private class WritingContextProvider : IContextProvider<WritingContext>
        {
            #region Constructors and Destructors

            public WritingContextProvider()
            {
                this.Context = new WritingContext();
            }

            #endregion

            #region Public Properties

            public WritingContext Context { get; }

            #endregion
        }
    }
}
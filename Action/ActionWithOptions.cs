//     File:  ScoreAI/ScoreAI/ActionWithOptions.cs
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
//     Created: 20.11.2016 7:30 PM
//     Last Edited: 20.11.2016 8:29 PM

namespace ScoreAI.Action
{
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Context;
    using ScoreAI.OptionScorer;

    #endregion

    /// <summary>
    ///     ActionBase with options.
    /// </summary>
    /// <typeparam name="TOption">
    ///     TODO
    /// </typeparam>
    public abstract class ActionWithOptions<TOption, TContext> : IAction<TContext> where TContext : IContext
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the (option) scorers.
        /// </summary>
        public List<IOptionScorer<TOption, TContext>> Scorers { get; set; } = new List<IOptionScorer<TOption, TContext>>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The executing method
        /// </summary>
        /// <param name="context">The context.</param>
        public abstract void Execute(TContext context);

        #endregion

        #region Methods

        /// <summary>
        ///     Gets the best
        ///     <typeparam name="TOption"></typeparam>
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="options">The options.</param>
        /// <returns>
        ///     The best
        ///     <typeparam name="TOption"></typeparam>
        /// </returns>
        protected TOption GetBest(TContext context, IList<TOption> options)
        {
            var highest = default(TOption);
            var highestScore = 0f;

            foreach (var scorer in this.Scorers)
            {
                foreach (var option in options)
                {
                    var score = scorer.Score(context, option);

                    if (score <= highestScore) continue;

                    highest = option;
                    highestScore = score;
                }
            }

            return highest;
        }

        #endregion
    }
}
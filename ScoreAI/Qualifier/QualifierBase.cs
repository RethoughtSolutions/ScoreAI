//     File:  ScoreAI/ScoreAI/QualifierBase.cs
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

namespace ScoreAI.Qualifier
{
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Action;
    using ScoreAI.Context;
    using ScoreAI.Scorer;

    #endregion

    /// <summary>
    ///     The qualifier base.
    /// </summary>
    public abstract class QualifierBase<T> : IQualifier<T> where T : IContext
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the action.
        /// </summary>
        public IAction<T> Action { get; set; }

        /// <summary>
        ///     Gets or sets the scorers.
        /// </summary>
        public IList<IContextualScorer<T>> Scorers { get; set; } = new List<IContextualScorer<T>>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Adds a scorer.
        /// </summary>
        /// <param name="scorer">The scorer.</param>
        public void AddScorer(IContextualScorer<T> scorer)
        {
            this.Scorers.Add(scorer);
        }

        /// <summary>
        ///     The score.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public abstract float Score(T context);

        /// <summary>
        ///     Sets the action.
        /// </summary>
        /// <param name="action">The action.</param>
        public void SetAction(IAction<T> action)
        {
            this.Action = action;
        }

        #endregion
    }
}
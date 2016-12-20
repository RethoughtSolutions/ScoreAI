﻿//     File:  ScoreAI/ScoreAI/IQualifier.cs
//     Copyright (C) 2016 Rethought
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
//     Last Edited: 20.12.2016 6:04 PM

namespace ScoreAI.Qualifier
{
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Action;
    using ScoreAI.Scorer;

    #endregion

    /// <summary>
    ///     The Qualifier interface.
    /// </summary>
    public interface IQualifier
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the action.
        /// </summary>
        IAction Action { get; set; }

        /// <summary>
        ///     Gets or sets the scorers.
        /// </summary>
        IList<IScorer> Scorers { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Adds a scorer.
        /// </summary>
        /// <param name="scorer">The scorer.</param>
        void AddScorer(IScorer scorer);

        /// <summary>
        ///     The score.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        float Score();

        /// <summary>
        ///     Sets the action.
        /// </summary>
        /// <param name="action">The action.</param>
        void SetAction(IAction action);

        #endregion
    }
}
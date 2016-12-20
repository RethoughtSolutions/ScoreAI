//     File:  ScoreAI/ScoreAI/LinkedScorer.cs
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
//     Created: 22.11.2016 5:58 PM
//     Last Edited: 20.12.2016 6:04 PM

namespace ScoreAI.Scorer
{
    #region Using Directives

    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    ///     The linked scorer. Used to nest scorers.
    /// </summary>
    public class LinkedScorer : IScorer
    {
        #region Fields

        /// <summary>
        ///     The qualifier
        /// </summary>
        private readonly IQualifier qualifier;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LinkedScorer" /> class.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        public LinkedScorer(IQualifier qualifier)
        {
            this.qualifier = qualifier;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The score.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public float Score()
        {
            return this.qualifier.Score();
        }

        #endregion
    }
}
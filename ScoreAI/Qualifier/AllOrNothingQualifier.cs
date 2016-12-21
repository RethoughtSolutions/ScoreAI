//     File:  ScoreAI/ScoreAI/AllOrNothingQualifier.cs
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
    using System.Linq;

    #region Using Directives

    #endregion

    /// <summary>
    ///     The all or nothing qualifier.
    /// </summary>
    public class AllOrNothingQualifier : QualifierBase
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AllOrNothingQualifier" /> class.
        /// </summary>
        /// <param name="threshold">
        ///     The threshold.
        /// </param>
        public AllOrNothingQualifier(float threshold = 0f)
        {
            this.Threshold = threshold;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the threshold.
        /// </summary>
        public float Threshold { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The score.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public override float Score() => 
            this.Scorers.Any(s => s.Score() < this.Threshold) // if theres any under threshold
            ? 0f // return null
            : this.Scorers.Sum(s => s.Score()); // otherwise return sum

            #endregion
        }
}
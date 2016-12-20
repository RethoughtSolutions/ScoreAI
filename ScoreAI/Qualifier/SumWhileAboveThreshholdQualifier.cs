//     File:  ScoreAI/ScoreAI/SumWhileAboveThreshholdQualifier.cs
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

    #endregion

    /// <summary>
    ///     The sum while above threshhold qualifier.
    /// </summary>
    public class SumWhileAboveThreshholdQualifier : QualifierBase
    {
        #region Fields

        /// <summary>
        ///     The threshold.
        /// </summary>
        private readonly float threshold;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SumWhileAboveThreshholdQualifier" /> class.
        /// </summary>
        /// <param name="threshold">
        ///     The threshold.
        /// </param>
        public SumWhileAboveThreshholdQualifier(float threshold)
        {
            this.threshold = threshold;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The score.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public override float Score()
        {
            var sum = 0f;

            foreach (var scorer in this.Scorers)
            {
                var score = scorer.Score();

                if (score > this.threshold)
                    sum += score;
                else
                    break;
            }

            return sum;
        }

        #endregion
    }
}
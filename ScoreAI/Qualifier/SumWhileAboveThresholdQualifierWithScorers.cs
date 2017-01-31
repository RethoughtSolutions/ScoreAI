//     File:  ScoreAI/ScoreAI/SumWhileAboveThresholdQualifierWithScorers.cs
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
//     Last Edited: 31.01.2017 6:13 AM

using System.Collections.Generic;
using ScoreAI.Scorer;

namespace ScoreAI.Qualifier
{
    /// <summary>
    ///     The sum while above threshold qualifier.
    /// </summary>
    public class SumWhileAboveThresholdQualifierWithScorers<T> : QualifierWithScorersBase<T>
    {
        public float Threshold { get; set; }



        /// <summary>
        /// Initializes a new instance of the <see cref="SumWhileAboveThresholdQualifierWithScorers{T}"/> class.
        /// </summary>
        /// <param name="threshold">The threshold.</param>
        public SumWhileAboveThresholdQualifierWithScorers(float threshold = 0f)
        {
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SumWhileAboveThresholdQualifierWithScorers{T}"/> class.
        /// </summary>
        /// <param name="qualifiedItem">The qualified item.</param>
        /// <param name="scorerList">The scorer list.</param>
        /// <param name="threshold">The threshold.</param>
        protected SumWhileAboveThresholdQualifierWithScorers(T qualifiedItem, IList<IScorer> scorerList, float threshold = 0f) : base(qualifiedItem, scorerList)
        {
            this.Threshold = threshold;
        }

        /// <summary>
        ///     The score.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public override float Score()
        {
            var sum = 0f;

            foreach (var scorer in this.ScorerList)
            {
                var score = scorer.Score();

                if (score > this.Threshold)
                    sum += score;
                else
                    break;
            }

            return sum;
        }
    }
}
//     File:  ScoreAI/ScoreAI/AllOrNothingQualifierWithScorers.cs
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

namespace ScoreAI.Qualifier
{
    using System.Collections.Generic;
    #region Using Directives

    using ScoreAI.Action;
    using Scorer;
    using ScoreAI.Selector;

    #endregion

    /// <summary>
    ///     The all or nothing qualifier.
    /// </summary>
    public class AllOrNothingQualifierWithScorers<T> : QualifierWithScorersBase<T>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AllOrNothingQualifierWithScorers" /> class.
        /// </summary>
        /// <param name="threshold">
        ///     The threshold.
        /// </param>
        public AllOrNothingQualifierWithScorers(T qualifiedItem, float threshold = 0f)
        {
            this.QualifiedItem = qualifiedItem;
            this.Threshold = threshold;
        }

        protected AllOrNothingQualifierWithScorers()
        {
        }

        protected AllOrNothingQualifierWithScorers(T qualifiedItem, float threshold, IList<IScorer> scorerList) : base(qualifiedItem, scorerList)
        {
            this.Threshold = threshold;
        }

        /// <summary>
        ///     Gets or sets the threshold.
        /// </summary>
        public float Threshold { get; set; }

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
                    return 0f;
            }

            return sum;
        }
    }
}
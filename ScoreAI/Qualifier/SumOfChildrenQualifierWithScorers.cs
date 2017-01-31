//     File:  ScoreAI/ScoreAI/SumOfChildrenQualifierWithScorers.cs
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

    using System.Linq;
    using Scorer;

    #endregion

    /// <summary>
    ///     The sum of children qualifier.
    /// </summary>
    public class SumOfChildrenQualifierWithScorers<T> : QualifierWithScorersBase<T>
    {
        public SumOfChildrenQualifierWithScorers(T qualifiedItem, IList<IScorer> scorerList) : base(qualifiedItem, scorerList)
        {
        }

        public SumOfChildrenQualifierWithScorers()
        {
            
        }

        /// <summary>
        ///     The score.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public override float Score()
        {
            return this.ScorerList.Sum(x => x.Score());
        }
    }
}
//     File:  ScoreAI/ScoreAI/HighestScoreWinsSelector.cs
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

namespace ScoreAI.Selector
{
    using System.Collections.Generic;
    #region Using Directives

    using ScoreAI.Extensions;
    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    ///     The highest score wins selector.
    /// </summary>
    public class HighestScoreWinsSelector<T> : SelectorBase<T>
    {
        public HighestScoreWinsSelector(IList<IQualifier<T>> qualifierList) : base(qualifierList)
        {
        }

        public HighestScoreWinsSelector()
        {
            
        }

        /// <summary>
        ///     Selects the Qualifier based on its score. The highest scoring qualifier wins.
        /// </summary>
        /// <returns>
        ///     The <see cref="QualifierWithScorersBase" />.
        /// </returns>
        public override IQualifier<T> Select()
        {
            return this.QualifiersList.MaxOrDefault(x => x.Score());
        }
    }
}
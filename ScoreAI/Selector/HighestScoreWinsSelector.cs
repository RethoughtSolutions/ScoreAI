//     File:  Rethought Series/RethoughtAILib/HighestScoreWinsSelector.cs
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
//     Created: 19.11.2016 12:22 AM
//     Last Edited: 20.11.2016 7:26 PM

namespace ScoreAI.Selector
{
    #region Using Directives

    using ScoreAI.Extensions;
    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    /// The highest score wins selector.
    /// </summary>
    public class HighestScoreWinsSelector : SelectorBase
    {
        #region Public Methods and Operators

        /// <summary>
        /// Selects the Qualifier based on its score. The highest scoring qualifier wins.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// The <see cref="QualifierBase" />.
        /// </returns>
        public override IQualifier Select()
        {
            return this.Qualifiers.MaxOrDefault(x => x.Score());
        }

        #endregion
    }
}
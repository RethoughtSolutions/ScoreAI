//     File:  ScoreAI/ScoreAI/FirstScoreWinsSelector.cs
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

namespace ScoreAI.Selector
{
    #region Using Directives

    using ScoreAI.Context;
    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    ///     The first score wins selector.
    /// </summary>
    public class FirstScoreWinsSelector<T> : SelectorBase<T> where T : IContext
    {
        #region Fields

        /// <summary>
        ///     The threshold.
        /// </summary>
        private readonly float threshold;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FirstScoreWinsSelector" /> class.
        /// </summary>
        /// <param name="threshold">
        ///     The threshold.
        /// </param>
        public FirstScoreWinsSelector(float threshold = 0f)
        {
            this.threshold = threshold;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Selects the Qualifier based on its score. The first Qualifier that scores above a threshold wins.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        ///     The <see cref="QualifierBase" />.
        /// </returns>
        public override IQualifier<T> Select(T context)
        {
            foreach (var qualifier in this.Qualifiers)
            {
                if (!(qualifier.Score(context) > this.threshold)) continue;

                return qualifier;
            }

            return this.DefaultQualifier;
        }

        #endregion
    }
}
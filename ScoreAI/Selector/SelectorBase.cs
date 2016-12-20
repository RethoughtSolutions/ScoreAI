//     File:  ScoreAI/ScoreAI/SelectorBase.cs
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
//     Last Edited: 20.11.2016 8:35 PM

namespace ScoreAI.Selector
{
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    ///     The selector.
    /// </summary>
    public abstract class SelectorBase : ISelector
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the default qualifier. Which gets used when no qualifier scored above a threshold.
        /// </summary>
        public IQualifier DefaultQualifier { get; set; } = new FixedScoreQualifier();

        /// <summary>
        ///     Gets or sets the qualifiers.
        /// </summary>
        public List<IQualifier> Qualifiers { get; set; } = new List<IQualifier>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Adds a qualifier.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        public void AddQualifier(IQualifier qualifier)
        {
            this.Qualifiers.Add(qualifier);
        }

        /// <summary>
        ///     Selects the Qualifier based on its score. Selection depends on the implementation.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <returns>
        ///     The <see cref="QualifierBase" />.
        /// </returns>
        public abstract IQualifier Select();

        /// <summary>
        ///     Sets the default qualifier.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        public void SetDefaultQualifier(IQualifier qualifier)
        {
            this.DefaultQualifier = qualifier;
        }

        #endregion
    }
}
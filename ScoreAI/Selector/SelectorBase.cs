//     File:  ScoreAI/ScoreAI/SelectorBase.cs
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
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    ///     The selector.
    /// </summary>
    public abstract class SelectorBase<T> : ISelector<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectorBase{T}"/> class.
        /// </summary>
        /// <param name="qualifierList">The qualifier.</param>
        protected SelectorBase(IList<IQualifier<T>> qualifierList)
        {
            this.QualifiersList = qualifierList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectorBase{T}"/> class.
        /// </summary>
        protected SelectorBase()
        {
        }

        /// <summary>
        ///     Gets or sets the qualifiers.
        /// </summary>
        public IList<IQualifier<T>> QualifiersList { get; set; } = new List<IQualifier<T>>();

        /// <summary>
        ///     Adds a qualifier.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        public void AddQualifier(IQualifier<T> qualifier)
        {
            this.QualifiersList.Add(qualifier);
        }

        /// <summary>
        ///     Selects the Qualifier based on its score. Selection depends on the implementation.
        /// </summary>
        /// <returns>
        ///     The <see cref="ISelector{T}" />.
        /// </returns>
        public abstract IQualifier<T> Select();
    }
}
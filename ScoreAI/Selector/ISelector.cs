//     File:  ScoreAI/ScoreAI/ISelector.cs
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
//     Last Edited: 20.11.2016 8:49 PM

namespace ScoreAI.Selector
{
    #region Using Directives

    using ScoreAI.Context;
    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    /// The RootSelector interface.
    /// </summary>
    /// <typeparam name="T">
    ///     The context type
    /// </typeparam>
    public interface ISelector<T>
        where T : IContext
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Adds a qualifier.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        void AddQualifier(IQualifier<T> qualifier);

        /// <summary>
        ///     Selects a Qualifier based on its score.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <returns>
        ///     The <see cref="IQualifier" />.
        /// </returns>
        IQualifier<T> Select(T context);

        /// <summary>
        ///     Sets the default qualifier.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        void SetDefaultQualifier(IQualifier<T> qualifier);

        #endregion
    }
}
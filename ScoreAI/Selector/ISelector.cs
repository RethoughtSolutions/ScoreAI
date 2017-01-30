//     File:  ScoreAI/ScoreAI/ISelector.cs
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
//     Last Edited: 29.01.2017 5:40 PM

namespace ScoreAI.Selector
{
    #region Using Directives

    using ScoreAI.Qualifier;

    #endregion

    /// <summary>
    /// The RootSelector interface.
    /// </summary>
    /// <typeparam name="T">
    ///     Defines the type that gets qualified
    /// </typeparam>
    public interface ISelector<T>
    {
        /// <summary>
        ///     Adds a qualifier.
        /// </summary>
        /// <param name="qualifier">The qualifier.</param>
        void AddQualifier(IQualifier<T> qualifier);

        /// <summary>
        ///     Selects a Qualifier based on its score.
        /// </summary>
        /// <returns>
        ///     <see cref="IQualifier{T}" />
        /// </returns>
        IQualifier<T> Select();
    }
}
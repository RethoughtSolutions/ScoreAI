//     File:  ScoreAI/ScoreAI/EnumerableExtensions.cs
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
//     Last Edited: 20.12.2016 6:04 PM

namespace ScoreAI.Extensions
{
    #region Using Directives

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The enumerable extensions.
    /// </summary>
    public static class EnumerableExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Returns the max or default element
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TR">The type of the r.</typeparam>
        /// <param name="container">The container.</param>
        /// <param name="valuingFoo">The valuing foo.</param>
        /// <returns>the max or default element</returns>
        public static T MaxOrDefault<T, TR>(this IEnumerable<T> container, Func<T, TR> valuingFoo)
            where TR : IComparable
        {
            T maxElem;

            using (var enumerator = container.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return default(T);

                maxElem = enumerator.Current;
                var maxVal = valuingFoo(maxElem);

                while (enumerator.MoveNext())
                {
                    var currVal = valuingFoo(enumerator.Current);

                    if (currVal.CompareTo(maxVal) <= 0) continue;
                    maxVal = currVal;
                    maxElem = enumerator.Current;
                }
            }

            return maxElem;
        }

        /// <summary>
        ///     Searches for the min or default element.
        /// </summary>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <typeparam name="TR">
        ///     The comparing type.
        /// </typeparam>
        /// <param name="container">
        ///     The container.
        /// </param>
        /// <param name="valuingFoo">
        ///     The comparing function.
        /// </param>
        /// <returns></returns>
        public static T MinOrDefault<T, TR>(this IEnumerable<T> container, Func<T, TR> valuingFoo)
            where TR : IComparable
        {
            T minElem;

            using (var enumerator = container.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return default(T);

                minElem = enumerator.Current;
                var minVal = valuingFoo(minElem);

                while (enumerator.MoveNext())
                {
                    var currVal = valuingFoo(enumerator.Current);

                    if (currVal.CompareTo(minVal) >= 0) continue;
                    minVal = currVal;
                    minElem = enumerator.Current;
                }
            }

            return minElem;
        }

        #endregion
    }
}
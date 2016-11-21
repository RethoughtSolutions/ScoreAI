//     File:  ScoreAI/ScoreAI/IOptionScorer.cs
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

namespace ScoreAI.OptionScorer
{
    #region Using Directives

    using ScoreAI.Context;

    #endregion

    /// <summary>
    ///     The OptionScorer interface.
    /// </summary>
    /// <typeparam name="TOption">
    ///     TODO
    /// </typeparam>
    public interface IOptionScorer<in TOption, TContext> where TContext : IContext
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Determines the score
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="option">The option.</param>
        /// <returns>The score</returns>
        float Score(TContext context, TOption option);

        #endregion
    }
}
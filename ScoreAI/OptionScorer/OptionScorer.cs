//     File:  ScoreAI/ScoreAI/OptionScorer.cs
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
//     Last Edited: 24.11.2016 12:22 AM

namespace ScoreAI.OptionScorer
{
    #region Using Directives

    

    #endregion

    /// <summary>
    ///     The option scorer base.
    /// </summary>
    /// <typeparam name="T">
    ///     The type
    /// </typeparam>
    public abstract class OptionScorerBase : IOptionScorer
    {
        #region Constructors and Destructors

        protected OptionScorerBase(string name)
        {
            this.Name = name;
        }

        protected OptionScorerBase()
        {
        }

        #endregion

        #region Public Properties

        public string Name { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Determines the score
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="option">The option.</param>
        /// <returns>
        ///     The score
        /// </returns>
        public abstract float Score();

        #endregion
    }
}
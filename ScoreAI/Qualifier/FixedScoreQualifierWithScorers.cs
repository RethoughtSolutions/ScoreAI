//     File:  ScoreAI/ScoreAI/FixedScoreQualifierWithScorers.cs
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
//     Last Edited: 28.12.2016 5:24 PM

namespace ScoreAI.Qualifier
{
    /// <summary>
    ///     The fixed fixedScore qualifier.
    /// </summary>
    public class FixedScoreQualifierWithScorers<T> : IQualifier<T>
    {
        /// <summary>
        ///     The fixed fixedScore.
        /// </summary>
        private readonly float fixedScore;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FixedScoreQualifierWithScorers" /> class.
        /// </summary>
        /// <param name="fixedScore">
        ///     The fixedScore.
        /// </param>
        public FixedScoreQualifierWithScorers(float fixedScore = 0f)
        {
            this.fixedScore = fixedScore;
        }

        public T QualifiedItem { get; set; }

        /// <summary>
        ///     The fixedScore.
        /// </summary>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public float Score()
        {
            return this.fixedScore;
        }
    }
}
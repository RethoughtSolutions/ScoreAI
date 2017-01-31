//     File:  ScoreAI/ScoreAI/AIActionClientBase.cs
//     Copyright (C) 2017 Rethought
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
//     Created: 31.01.2017 6:05 AM
//     Last Edited: 31.01.2017 6:13 AM

namespace ScoreAI.Client
{
    #region Using Directives

    using ScoreAI.Action;
    using ScoreAI.Selector;

    #endregion

    public abstract class AISingleSelectorClientBase<T> : IAIClient
    {
        protected AISingleSelectorClientBase()
        {
        }

        protected AISingleSelectorClientBase(ISelector<T> selector)
        {
            this.Selector = selector;
        }

        public ISelector<T> Selector { get; set; }

        public abstract void Tick();
    }
}
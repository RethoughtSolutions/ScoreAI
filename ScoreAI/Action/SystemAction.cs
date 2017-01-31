//     File:  ScoreAI/ScoreAI/SystemAction.cs
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
//     Created: 28.12.2016 5:25 PM
//     Last Edited: 31.01.2017 6:13 AM

namespace ScoreAI.Action
{
    #region Using Directives

    using System;

    #endregion

    /// <summary>
    ///     The system action. Covers System.Action.
    /// </summary>
    public class SystemAction : IAction
    {
        /// <summary>
        ///     The action
        /// </summary>
        private readonly Action action;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SystemAction" /> class.
        /// </summary>
        /// <param name="action">The action.</param>
        public SystemAction(Action action)
        {
            this.action = action;
        }

        /// <summary>
        ///     Executes this instance.
        /// </summary>
        public void Execute()
        {
            this.action.Invoke();
        }
    }
}
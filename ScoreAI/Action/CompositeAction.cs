//     File:  ScoreAI/ScoreAI/CompositeAction.cs
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

namespace ScoreAI.Action
{
    #region Using Directives

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The composite action.
    /// </summary>
    public class CompositeAction : ActionBase
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the actions.
        /// </summary>
        /// <value>
        ///     The actions.
        /// </value>
        public List<IAction> Actions { get; set; } = new List<IAction>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Executes the action
        /// </summary>
        public override void Execute()
        {
            foreach (var action in this.Actions)
            {
                action.Execute();
            }
        }

        #endregion
    }
}
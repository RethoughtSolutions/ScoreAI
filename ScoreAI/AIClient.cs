//     File:  ScoreAI/ScoreAI/AIClient.cs
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

namespace ScoreAI
{
    #region Using Directives

    using ScoreAI.Context;
    using ScoreAI.Selector;

    #endregion

    /// <summary>
    ///     The AI client.
    /// </summary>
    public class AIClient<T> : IAIClient<T> where T : IContext
    {
        #region Fields

        /// <summary>
        ///     The context provider
        /// </summary>
        private readonly IContextProvider<T> contextProvider;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AIClient" /> class.
        /// </summary>
        /// <param name="contextProvider">The context provider.</param>
        public AIClient(IContextProvider<T> contextProvider)
        {
            this.contextProvider = contextProvider;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the selector.
        /// </summary>
        public ISelector<T> RootSelector { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Ticks this instance.
        /// </summary>
        public void Tick()
        {
            var context = this.contextProvider.Context;

            var qualifier = this.RootSelector.Select(context);

            qualifier?.Action?.Execute(context);
        }

        #endregion
    }
}
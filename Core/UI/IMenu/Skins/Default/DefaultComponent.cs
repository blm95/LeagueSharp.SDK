﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultComponent.cs" company="LeagueSharp">
//   Copyright (C) 2015 LeagueSharp
//   
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//   
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//   Provides of series of methods used in the Default theme.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LeagueSharp.SDK.Core.UI.IMenu.Skins.Default
{
    using LeagueSharp.SDK.Core.UI.IMenu.Abstracts;

    using SharpDX;

    /// <summary>
    ///     Provides of series of methods used in the Default theme.
    /// </summary>
    public class DefaultComponent
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Calculates the width of text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The <see cref="int" /></returns>
        public int CalcWidthText(string text)
        {
            return MenuSettings.Font.MeasureText(MenuManager.Instance.Sprite, text, 0).Width;
        }

        /// <summary>
        ///     Calculate the item's width.
        /// </summary>
        /// <param name="menuItem">The <see cref="MenuItem" /></param>
        /// <returns>The width</returns>
        public int CalcWidthItem(MenuItem menuItem)
        {
            return (int)(MeasureString(menuItem.DisplayName).Width + (MenuSettings.ContainerTextOffset * 2));
        }

        /// <summary>
        ///     Calculates the string measurements.
        /// </summary>
        /// <param name="text">
        ///     The text.
        /// </param>
        /// <returns>
        ///     The measured rectangle.
        /// </returns>
        public Rectangle MeasureString(string text)
        {
            return MenuSettings.Font.MeasureText(MenuManager.Instance.Sprite, text, 0);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Gets the container rectangle.
        /// </summary>
        /// <param name="component">
        ///     The component.
        /// </param>
        /// <returns>
        ///     <see cref="Rectangle" /> with information.
        /// </returns>
        protected static Rectangle GetContainerRectangle(AMenuComponent component)
        {
            return new Rectangle(
                (int)component.Position.X, 
                (int)component.Position.Y, 
                component.MenuWidth, 
                MenuSettings.ContainerHeight);
        }

        #endregion
    }
}
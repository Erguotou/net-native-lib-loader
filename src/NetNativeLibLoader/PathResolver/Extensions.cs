//
//  Extensions.cs
//
//  Copyright (c) 2018 Firwood Software
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.IO;
using System.Linq;

namespace NetNativeLibLoader.PathResolver
{
    internal static class Extensions
    {
        public static bool IsValidPath(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return false;
            }

            if (@this.Any(c => Path.GetInvalidPathChars().Contains(c)))
            {
                return false;
            }

            var parentDirectory = Path.GetDirectoryName(@this);
            if (string.IsNullOrEmpty(parentDirectory))
            {
                return false;
            }

            return true;
        }
    }
}
#region Copyright (C) 2003-2026 Stimulsoft
/*
    This file is part of Stimulsoft.MathFX.
    Copyright (C) 2003-2026 Stimulsoft

    Stimulsoft.MathFX is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Stimulsoft.MathFX is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Stimulsoft.MathFX.  If not, see <https://www.gnu.org/licenses/>.
*/
#endregion Copyright (C) 2003-2026 Stimulsoft

using System.Text;

namespace LatexMath2MathML
{
    /// <summary>
    /// The converter for array blocks.
    /// </summary>
    internal sealed class StiBMatrixConverter : StiMatrixConverter
    {
        #region Properties
        public override string MatrixStartSymbol => "[";

        public override string MatrixEndSymbol => "]";
        #endregion        
    }
}

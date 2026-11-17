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
    internal class StiMatrixConverter : BlockConverter
    {
        #region Properties
        public virtual string MatrixStartSymbol => "";

        public virtual string MatrixEndSymbol => "";
        #endregion

        #region Methods
        /// <summary>
        /// Performs the conversion procedure (comments the expression).
        /// </summary>
        /// <param name="expr">The expression to convert.</param>
        /// <returns>The conversion result.</returns>
        public override string Convert(LatexExpression expr)
        {
            var bld = new StringBuilder();
            var rows = expr.Expressions[0];

            bld.Append("<mrow>\n");
            
            if (!string.IsNullOrEmpty(this.MatrixStartSymbol))
                bld.Append($"<mo>{this.MatrixStartSymbol}</mo>\n");

            bld.Append("<mtable>\n");
            for (int i = 0; i < rows.Count; i++)
            {
                bld.Append("<mtr>\n");
                for (int j = 0; j < rows[i].Expressions[0].Count; j++)
                {
                    bld.Append("<mtd columnalign=\"left\">\n<mrow>\n");
                    bld.Append(SequenceConverter.ConvertOutline(rows[i].Expressions[0][j].Expressions[0], expr.Customization));
                    bld.Append("</mrow>\n</mtd>\n");
                }
                bld.Append("</mtr>\n");
            }
            bld.Append("</mtable>\n");

            if (!string.IsNullOrEmpty(this.MatrixEndSymbol))
                bld.Append($"<mo>{this.MatrixEndSymbol}</mo>\n");

            bld.Append("</mrow>\n");
            return bld.ToString();
        } 
        #endregion
    }
}

﻿/*  
    This file is part of LatexMath2MathML.

    LatexMath2MathML is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LatexMath2MathML is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LatexMath2MathML.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;

namespace LatexMath2MathML
{
    /// <summary>
    /// The converter class for equations.
    /// </summary>
    internal sealed class EquationConverter : BlockConverter
    {
        /// <summary>
        /// Performs the conversion procedure.
        /// </summary>
        /// <param name="expr">The expression to convert.</param>
        /// <returns>The conversion result.</returns>
        public override string Convert(LatexExpression expr)
        {
            expr.ExprType = ExpressionType.BlockMath;
            expr.Expressions.Add(new List<LatexExpression> { new LatexExpression("equation", expr, 1, 0, expr.Customization) });
            return expr.Convert();
        }

        /// <summary>
        /// Returns true if the block defines a math environment; otherwise, false.
        /// </summary>
        /// <returns></returns>
        public override bool ImpliesMathMode()
        {
            return true;
        }
    }
}


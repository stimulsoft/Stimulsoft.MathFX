/*  
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

using System.Text;

namespace LatexMath2MathML
{
    /// <summary>
    /// The converter class for fractions.
    /// </summary>
    internal class FracCommandConverter : CommandConverter
    {
        /// <summary>
        /// Gets the command name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "frac";
            }
        }

        /// <summary>
        /// Gets the expected count of child subtrees.
        /// </summary>
        public override int ExpectedBranchesCount
        {
            get { return 2; }
        }

        /// <summary>
        /// Performs the conversion procedure.
        /// </summary>
        /// <param name="expr">The expression to convert.</param>
        /// <returns>The conversion result.</returns>
        public override string Convert(LatexExpression expr)
        {
            var bld = new StringBuilder();
            bld.Append("<mfrac>\n<mrow>\n");
            bld.Append(SequenceConverter.ConvertOutline(expr.Expressions[0], expr.Customization));
            bld.Append("</mrow>\n<mrow>\n");
            bld.Append(SequenceConverter.ConvertOutline(expr.Expressions[1], expr.Customization));
            bld.Append("</mrow>\n</mfrac>\n");
            return bld.ToString();
        }
    }

    /// <summary>
    /// The converter class for dfrac.
    /// </summary>
    internal sealed class DfracCommandConverter : FracCommandConverter
    {
        /// <summary>
        /// Gets the command name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "dfrac";
            }
        }
    }

    /// <summary>
    /// The converter class for tfrac.
    /// </summary>
    internal sealed class TfracCommandConverter : FracCommandConverter
    {
        /// <summary>
        /// Gets the command name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "tfrac";
            }
        }
    }
}

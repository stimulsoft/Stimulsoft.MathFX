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
    [Accent("underline", "&#x0332;<!-- &UnderBar; -->", true, true)]
    internal class StiUnderlineAccentConverter : AccentConverter
    {/// <summary>
     /// Performs the conversion procedure.
     /// </summary>
     /// <param name="expr">The expression to convert.</param>
     /// <returns>The conversion result.</returns>
        public override string Convert(LatexExpression expr)
        {
            if (expr.Expressions == null) return "";
            var bld = new StringBuilder();

            bld.Append("<munder accentunder=\"true\">\n");
            bld.Append(SequenceConverter.ConvertOutline(expr.Expressions[0], expr.Customization));
            bld.Append("<mo stretchy=\"true\">&#x0332;<!-- &UnderBar; --></mo>\n</munder>\n");

            return bld.ToString();
        }
    }
}

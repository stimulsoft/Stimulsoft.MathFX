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

using LatexMath2MathML;
using SvgMath;

namespace Stimulsoft.MathFX
{
    public class StiLatexService
    {
        #region Fields
        private string latex;
        private string mathML;
        #endregion

        #region Methods
        public string GetMathML()
        {
            if (!string.IsNullOrEmpty(mathML))
                return mathML;

            var lmm = new LatexMathToMathMLConverter();
            this.mathML = lmm.ConvertToMathML(latex);

            return mathML;
        }

        public string GetSVG(float fontSize, string colorHex)
        {
            var mathMLText = this.GetMathML();

            var m = new Mml(mathMLText);
            var xElement = m.MakeSvg(fontSize, colorHex);
            return xElement.ToString();
        }
        #endregion

        public StiLatexService(string latex)
        {
            this.latex = latex;
        }
    }
}

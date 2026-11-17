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

using Stimulsoft.MathFX;
using System;
using System.Reflection;
using System.Security;

[assembly: AssemblyTitle("Stimulsoft.MathFX.dll")]
[assembly: AssemblyDescription("Math functionality")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(StiPublicName.Company)]
[assembly: AssemblyProduct(StiPublicName.ProductReports)]
[assembly: AssemblyCopyright(StiVersion.Copyright)]
[assembly: AssemblyTrademark(StiPublicName.Trademark)]
[assembly: AssemblyCulture("")]
[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(false)]
[assembly: AssemblyVersion(StiVersion.Version)]
[assembly: AssemblyDelaySign(false)]
[assembly: SecurityRules(SecurityRuleSet.Level1)]

namespace Stimulsoft.MathFX
{
    public class StiVersion
    {
        // When changing the MathFX version, also update project dependencies and NuGet metadata.
        public const string Version = "2026.4.1.0";
        public const string CreationDate = "9 Sep 2026";
        public static DateTime Created = new DateTime(2026, 9, 9);
        public const string VersionInfo = "Version=" + Version + ", Culture=neutral, " + StiPublicKeyToken.Key;
        public const string Copyright = "Copyright (C) 2003-2026 Stimulsoft";
    }
}
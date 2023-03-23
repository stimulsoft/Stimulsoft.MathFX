#region Copyright (C) 2003-2023 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports												}
{	                         										}
{																	}
{	Copyright (C) 2003-2023 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2023 Stimulsoft

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
        public const string Version = "2023.2.1.0";
        public const string CreationDate = "8 March 2023";
        public static DateTime Created = new DateTime(2023, 3, 8);
        public const string VersionInfo = "Version=" + Version + ", Culture=neutral, " + StiPublicKeyToken.Key;
        public const string Copyright = "Copyright (C) 2003-2023 Stimulsoft";
    }
}
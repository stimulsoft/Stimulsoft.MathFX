# Library for working with mathematical formulas

This repository contains the source code of the library for working with mathematical formulas in Stimulsoft products. This library is compatible with products [Reports.WEB](https://www.stimulsoft.com/en/products/reports-web), [Reports.NET](https://www.stimulsoft.com/en/products/reports-net) and [Reports.WPF](https://www.stimulsoft.com/en/products/reports-wpf), as well as with [Ultimate](https://www.stimulsoft.com/en/products/ultimate), which includes these products. The following frameworks are supported: .NET Framework 4.6.2, .NET Framework 4.7.2, .NET 6.0, .NET 8.0 and .NET 10.0, as well as all newer frameworks compatible with these.

# How to use

To use the library functions, it is enough to install the NuGet package listed below in your project. To use the source codes, you can clone this repository and connect the source codes to your project.

[NuGet](https://www.nuget.org/packages/Stimulsoft.MathFX)

[GPL-3.0 License](LICENSE.md)

[Third-party notices](THIRD-PARTY.md)

# Bundled fonts

The library embeds the font metrics it needs to lay out formulas. Two fonts are bundled,
both under the SIL Open Font License 1.1:

* [Tinos](https://fonts.google.com/specimen/Tinos) - letters, digits and punctuation.
* [Noto Sans Math](https://fonts.google.com/noto/specimen/Noto+Sans+Math) - operators, arrows, delimiters and other mathematical symbols.

The font files and the full licence text are in [Stimulsoft.MathFX/Fonts](Stimulsoft.MathFX/Fonts).
The generated SVG refers to these families by name, so the renderer displaying the formula
needs them available; Tinos is metric-compatible with Times New Roman, which most systems
substitute for it.

﻿// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using PdfSharp.Drawing;

namespace PdfSharp.Fonts
{
    /// <summary>
    /// An internal marker interface used to identify different manifestations of font resolvers.
    /// </summary>
    public interface IFontResolverMarker
    { }

    /// <summary>
    /// Provides functionality that converts a requested typeface into a physical font.
    /// </summary>
    public interface IFontResolver : IFontResolverMarker
    {
        /// <summary>
        /// Converts specified information about a required typeface into a specific font.
        /// </summary>
        /// <param name="familyName">Name of the font family.</param>
        /// <param name="isBold">Set to <c>true</c> when a bold fontface is required.</param>
        /// <param name="isItalic">Set to <c>true</c> when an italic fontface is required.</param>
        /// <returns>Information about the physical font, or null if the request cannot be satisfied.</returns>
        FontResolverInfo? ResolveTypeface(string familyName, bool isBold, bool isItalic);

        //FontResolverInfo ResolveTypeface(Typeface); TODO in future PDFsharp

        /// <summary>
        /// Gets the bytes of a physical font with specified face name.
        /// </summary>
        /// <param name="faceName">A face name previously retrieved by ResolveTypeface.</param>
        byte[]? GetFont(string faceName);
    }

    /// <summary>
    /// Provides functionality that converts a requested typeface into a physical font.
    /// </summary>
    /*public*/
    public interface IFontResolver2 : IFontResolverMarker
    {
        /// <summary>
        /// Converts specified information about a required typeface into a specific font.
        /// </summary>
        /// <param name="familyName">The font family of the typeface.</param>
        /// <param name="style">The style of the typeface.</param>
        /// <param name="weight">The relative weight of the typeface.</param>
        /// <param name="stretch">The degree to which the typeface is stretched.</param>
        /// <returns>Information about the physical font, or null if the request cannot be satisfied.</returns>
        FontResolverInfo? ResolveTypeface(string familyName, XFontStyle style, XFontWeight weight, XFontStretch stretch);

        /// <summary>
        /// Gets the bytes of a physical font with specified face name.
        /// </summary>
        /// <param name="faceName">A face name previously retrieved by ResolveTypeface.</param>
        ReadOnlyMemory<byte> GetFont(string faceName);
    }
}

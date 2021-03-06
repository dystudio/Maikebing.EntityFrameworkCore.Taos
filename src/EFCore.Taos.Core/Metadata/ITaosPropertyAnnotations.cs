﻿// Copyright (c)  maikebing All rights reserved.
//// Licensed under the MIT License, See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     API for Taos-specific annotations accessed through
    ///     <see cref="TaosMetadataExtensions.Taos(IProperty)" />.
    /// </summary>
    public interface ITaosPropertyAnnotations : IRelationalPropertyAnnotations
    {
        /// <summary>
        ///     Gets the SRID to use when creating a column for this property.
        /// </summary>
        int? Srid { get; }

        /// <summary>
        ///     Gets the dimension to use when creating a column for this property.
        /// </summary>
        string Dimension { get; }
    }
}

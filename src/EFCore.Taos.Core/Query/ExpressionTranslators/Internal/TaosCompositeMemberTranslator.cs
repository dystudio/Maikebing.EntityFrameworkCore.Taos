// Copyright (c)  maikebing All rights reserved.
//// Licensed under the MIT License, See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators;

namespace Microsoft.EntityFrameworkCore.Taos.Query.ExpressionTranslators.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public class TaosCompositeMemberTranslator : RelationalCompositeMemberTranslator
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public TaosCompositeMemberTranslator([NotNull] RelationalCompositeMemberTranslatorDependencies dependencies)
            : base(dependencies)
        {
            var TaosTranslators = new List<IMemberTranslator>
            {
                new TaosDateTimeMemberTranslator(),
                new TaosStringLengthTranslator()
            };

            AddTranslators(TaosTranslators);
        }
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprUnaryOp : ExprOperator
    {
        public ExprUnaryOp(ExpressionKind kind, CType type)
            : base(kind, type)
        {
            Debug.Assert(kind.IsUnaryOperator());
        }

        public Expr Child { get; set; }
    }
}

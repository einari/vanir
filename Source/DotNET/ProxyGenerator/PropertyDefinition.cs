// Copyright (c) Dolittle. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Dolittle.Vanir.ProxyGenerator
{
    public class PropertyDefinition
    {
        public string Name { get; init; }
        public Type Type { get; init; }
        public bool IsEnumerable { get; init; }
        public bool IsComplex { get; init; }
        public ReadModelDefinition ReadModel { get; init; }
    }
}

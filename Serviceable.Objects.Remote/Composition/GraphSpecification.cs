﻿namespace Serviceable.Objects.Remote.Composition
{
    using System.Collections.Generic;
    using Serviceable.Objects.Remote.Serialization;

    public sealed class GraphSpecification : SerializableSpecification
    {
        public override int DataStructureVersionNumber => 1;

        public IEnumerable<GraphNodeWithVertex> GraphVertices { get; set; }
    }
}

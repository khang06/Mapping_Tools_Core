﻿using Mapping_Tools_Core.MathUtil;
using Mapping_Tools_Core.Tools.SnappingTools.DataStructure.RelevantObject.RelevantObjects;
using Mapping_Tools_Core.Tools.SnappingTools.DataStructure.RelevantObjectGenerators.Allocation;
using Mapping_Tools_Core.Tools.SnappingTools.DataStructure.RelevantObjectGenerators.GeneratorInputSelection;
using Mapping_Tools_Core.Tools.SnappingTools.DataStructure.RelevantObjectGenerators.GeneratorTypes;

namespace Mapping_Tools_Core.Tools.SnappingTools.DataStructure.RelevantObjectGenerators.Generators {
    public class ParallelismGenerator : RelevantObjectsGenerator {
        public override string Name => "Parallel Lines";
        public override string Tooltip => "Takes a pair of line and point and generates a virtual line across the point that is parallel to the line.";
        public override GeneratorType GeneratorType => GeneratorType.Intermediate;

        public ParallelismGenerator() {
            Settings.IsActive = true;
            Settings.IsDeep = true;
            Settings.InputPredicate.Predicates.Add(new SelectionPredicate {NeedSelected = true});
        }

        [RelevantObjectsGeneratorMethod]
        public RelevantLine GetRelevantObjects(RelevantLine line, RelevantPoint point) {
            return new RelevantLine(new Line2(point.Child, line.Child.DirectionVector));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace treeDiM.StackBuilder.Basics
{
    public class AnalysisCaseTruck : AnalysisPackableTruck
    {
        public AnalysisCaseTruck(Document doc, Packable packable, TruckProperties truckProperties, ConstraintSetPackableTruck constraintSet)
            : base(doc, packable, truckProperties, constraintSet)
        { 
        }
    }
}

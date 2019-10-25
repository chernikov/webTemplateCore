﻿using System.Collections.Generic;
using System.Diagnostics;

namespace webTemplate.Swagger.Output
{
    [DebuggerDisplay("Enum: {FullName}")]
    public class OutputEnum : BaseOutputClass
    {
        public OutputEnum()
        {

        }

        public List<object> Types { get; set; }

        public override string FullName => Name;

    }
}

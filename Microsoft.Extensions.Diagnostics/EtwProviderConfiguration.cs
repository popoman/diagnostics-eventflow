﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Diagnostics
{
    public class EtwProviderConfiguration
    {
        public string ProviderName { get; set; }
        public EventLevel Level { get; set; }
        public EventKeywords Keywords { get; set; }

        public EtwProviderConfiguration()
        {
            Level = EventLevel.LogAlways;
            Keywords = (EventKeywords) ~0;
        }
    }
}

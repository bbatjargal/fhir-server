﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using Microsoft.Health.Fhir.ValueSets;

namespace Microsoft.Health.Fhir.Core.Configs
{
    public class VersioningConfiguration
    {
        public string Default { get; set; } = ResourceVersionPolicy.Versioned;
    }
}

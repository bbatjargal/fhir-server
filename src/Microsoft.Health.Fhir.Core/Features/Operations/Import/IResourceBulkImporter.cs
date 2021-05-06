﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Microsoft.Health.Fhir.Core.Features.Operations.Import
{
    public interface IResourceBulkImporter
    {
        public (Channel<ImportProcessingProgress> progressChannel, Task importTask) Import(Channel<ImportResource> inputChannel, IImportErrorStore importErrorStore, CancellationToken cancellationToken);
    }
}

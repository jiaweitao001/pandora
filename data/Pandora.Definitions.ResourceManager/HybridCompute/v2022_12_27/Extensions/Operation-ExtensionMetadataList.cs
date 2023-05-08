using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HybridCompute.v2022_12_27.Extensions;

internal class ExtensionMetadataListOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new ExtensionTypeId();

    public override Type? ResponseObject() => typeof(ExtensionValueListResultModel);

    public override string? UriSuffix() => "/versions";


}
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSqlHSC.v2020_10_05_privatepreview.Servers;

internal class ListByServerGroupOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new ServerGroupsv2Id();

    public override Type? ResponseObject() => typeof(ServerGroupServerListResultModel);

    public override string? UriSuffix() => "/servers";


}
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Advisor.v2023_01_01.AdvisorScore;

internal class ListOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new SubscriptionId();

    public override Type? ResponseObject() => typeof(AdvisorScoreResponseModel);

    public override string? UriSuffix() => "/providers/Microsoft.Advisor/advisorScore";


}
using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.AdaptiveNetworkHardenings;

internal class ScopedAdaptiveNetworkHardeningId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/{scope}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Scope("scope"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftSecurity", "Microsoft.Security"),
        ResourceIDSegment.Static("staticAdaptiveNetworkHardenings", "adaptiveNetworkHardenings"),
        ResourceIDSegment.UserSpecified("adaptiveNetworkHardeningName"),
    };
}

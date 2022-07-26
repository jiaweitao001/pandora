using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceBus.v2022_01_01_preview.TopicsAuthorizationRule;

internal class Definition : ResourceDefinition
{
    public string Name => "TopicsAuthorizationRule";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new TopicsCreateOrUpdateAuthorizationRuleOperation(),
        new TopicsDeleteAuthorizationRuleOperation(),
        new TopicsGetAuthorizationRuleOperation(),
        new TopicsListAuthorizationRulesOperation(),
        new TopicsListKeysOperation(),
        new TopicsRegenerateKeysOperation(),
    };
}

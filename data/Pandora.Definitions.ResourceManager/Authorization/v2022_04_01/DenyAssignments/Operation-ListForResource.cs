using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization.v2022_04_01.DenyAssignments;

internal class ListForResourceOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ScopedResourceId();

    public override Type NestedItemType() => typeof(DenyAssignmentModel);

    public override Type? OptionsObject() => typeof(ListForResourceOperation.ListForResourceOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Authorization/denyAssignments";

    internal class ListForResourceOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}

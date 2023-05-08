using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_09_01.VMSSPublicIPAddresses;

internal class PublicIPAddressesListVirtualMachineScaleSetVMPublicIPAddressesOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new VirtualMachineScaleSetIPConfigurationId();

    public override Type NestedItemType() => typeof(PublicIPAddressModel);

    public override string? UriSuffix() => "/publicIPAddresses";


}
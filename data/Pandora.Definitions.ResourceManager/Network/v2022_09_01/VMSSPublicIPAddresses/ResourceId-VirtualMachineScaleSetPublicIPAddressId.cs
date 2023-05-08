using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_09_01.VMSSPublicIPAddresses;

internal class VirtualMachineScaleSetPublicIPAddressId : ResourceID
{
    public string? CommonAlias => "VirtualMachineScaleSetPublicIPAddress";

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{virtualMachineScaleSetName}/virtualMachines/{virtualMachineName}/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}/publicIPAddresses/{publicIPAddressName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("subscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("resourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("providers", "providers"),
        ResourceIDSegment.ResourceProvider("resourceProvider", "Microsoft.Compute"),
        ResourceIDSegment.Static("virtualMachineScaleSets", "virtualMachineScaleSets"),
        ResourceIDSegment.UserSpecified("virtualMachineScaleSetName"),
        ResourceIDSegment.Static("virtualMachines", "virtualMachines"),
        ResourceIDSegment.UserSpecified("virtualMachineName"),
        ResourceIDSegment.Static("networkInterfaces", "networkInterfaces"),
        ResourceIDSegment.UserSpecified("networkInterfaceName"),
        ResourceIDSegment.Static("ipConfigurations", "ipConfigurations"),
        ResourceIDSegment.UserSpecified("ipConfigurationName"),
        ResourceIDSegment.Static("publicIPAddresses", "publicIPAddresses"),
        ResourceIDSegment.UserSpecified("publicIPAddressName"),
    };
}
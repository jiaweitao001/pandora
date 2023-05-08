using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_09_01.TrafficAnalytics;

internal class Definition : ResourceDefinition
{
    public string Name => "TrafficAnalytics";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new NetworkWatchersGetFlowLogStatusOperation(),
        new NetworkWatchersSetFlowLogConfigurationOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(FlowLogFormatTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(FlowLogFormatParametersModel),
        typeof(FlowLogInformationModel),
        typeof(FlowLogPropertiesModel),
        typeof(FlowLogStatusParametersModel),
        typeof(RetentionPolicyParametersModel),
        typeof(TrafficAnalyticsConfigurationPropertiesModel),
        typeof(TrafficAnalyticsPropertiesModel),
    };
}
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2023_04_03.AzureMonitorWorkspaces;


internal class MetricsModel
{
    [JsonPropertyName("internalId")]
    public string? InternalId { get; set; }

    [JsonPropertyName("prometheusQueryEndpoint")]
    public string? PrometheusQueryEndpoint { get; set; }
}
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Media.v2022_08_01.StreamingPoliciesAndStreamingLocators;


internal class StreamingLocatorPropertiesModel
{
    [JsonPropertyName("alternativeMediaId")]
    public string? AlternativeMediaId { get; set; }

    [JsonPropertyName("assetName")]
    [Required]
    public string AssetName { get; set; }

    [JsonPropertyName("contentKeys")]
    public List<StreamingLocatorContentKeyModel>? ContentKeys { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("defaultContentKeyPolicyName")]
    public string? DefaultContentKeyPolicyName { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }

    [JsonPropertyName("filters")]
    public List<string>? Filters { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("streamingLocatorId")]
    public string? StreamingLocatorId { get; set; }

    [JsonPropertyName("streamingPolicyName")]
    [Required]
    public string StreamingPolicyName { get; set; }
}
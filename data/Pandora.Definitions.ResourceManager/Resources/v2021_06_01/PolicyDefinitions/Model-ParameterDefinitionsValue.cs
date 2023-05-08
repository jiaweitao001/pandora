using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2021_06_01.PolicyDefinitions;


internal class ParameterDefinitionsValueModel
{
    [JsonPropertyName("allowedValues")]
    public List<object>? AllowedValues { get; set; }

    [JsonPropertyName("defaultValue")]
    public object? DefaultValue { get; set; }

    [JsonPropertyName("metadata")]
    public ParameterDefinitionsValueMetadataModel? Metadata { get; set; }

    [JsonPropertyName("type")]
    public ParameterTypeConstant? Type { get; set; }
}
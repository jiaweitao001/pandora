using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerInstance.v2023_05_01.ContainerInstance;


internal class DeploymentExtensionSpecPropertiesModel
{
    [JsonPropertyName("extensionType")]
    [Required]
    public string ExtensionType { get; set; }

    [JsonPropertyName("protectedSettings")]
    public object? ProtectedSettings { get; set; }

    [JsonPropertyName("settings")]
    public object? Settings { get; set; }

    [JsonPropertyName("version")]
    [Required]
    public string Version { get; set; }
}
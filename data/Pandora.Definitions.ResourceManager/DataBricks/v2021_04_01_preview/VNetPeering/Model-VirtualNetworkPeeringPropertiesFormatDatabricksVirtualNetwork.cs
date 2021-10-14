using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.DataBricks.v2021_04_01_preview.VNetPeering
{

    internal class VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetworkModel
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}

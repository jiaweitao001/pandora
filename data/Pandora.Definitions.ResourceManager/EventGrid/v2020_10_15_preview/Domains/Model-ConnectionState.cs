using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventGrid.v2020_10_15_preview.Domains
{

    internal class ConnectionStateModel
    {
        [JsonPropertyName("actionsRequired")]
        public string? ActionsRequired { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("status")]
        public PersistedConnectionStatusConstant? Status { get; set; }
    }
}

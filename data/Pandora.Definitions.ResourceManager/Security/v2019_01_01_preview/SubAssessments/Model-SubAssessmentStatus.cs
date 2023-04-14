using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2019_01_01_preview.SubAssessments;


internal class SubAssessmentStatusModel
{
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    [JsonPropertyName("code")]
    public SubAssessmentStatusCodeConstant? Code { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("severity")]
    public SeverityConstant? Severity { get; set; }
}
using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.HealthcareApis.v2021_11_01.FhirServices;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ServiceEventStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,

    [Description("Updating")]
    Updating,
}
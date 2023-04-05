using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPDiskConfigurations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SAPProductTypeConstant
{
    [Description("ECC")]
    ECC,

    [Description("Other")]
    Other,

    [Description("S4HANA")]
    SFourHANA,
}
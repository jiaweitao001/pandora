using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2022_09_01.VirtualNetworkPeerings;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualNetworkEncryptionEnforcementConstant
{
    [Description("AllowUnencrypted")]
    AllowUnencrypted,

    [Description("DropUnencrypted")]
    DropUnencrypted,
}
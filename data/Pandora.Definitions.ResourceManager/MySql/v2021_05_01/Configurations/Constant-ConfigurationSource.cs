using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MySql.v2021_05_01.Configurations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConfigurationSourceConstant
{
    [Description("system-default")]
    SystemNegativedefault,

    [Description("user-override")]
    UserNegativeoverride,
}
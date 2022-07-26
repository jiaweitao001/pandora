using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ServiceBus.v2022_01_01_preview.Namespaces;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TlsVersionConstant
{
    [Description("1.1")]
    OnePointOne,

    [Description("1.2")]
    OnePointTwo,

    [Description("1.0")]
    OnePointZero,
}

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2022_09_10.ReplicationProtectedItems;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum MobilityAgentUpgradeStateConstant
{
    [Description("Commit")]
    Commit,

    [Description("Completed")]
    Completed,

    [Description("None")]
    None,

    [Description("Started")]
    Started,
}
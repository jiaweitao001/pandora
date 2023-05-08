using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.GuestConfiguration.v2020_06_25.GuestConfigurationConnectedVMwarevSphereAssignmentsReports;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ComplianceStatusConstant
{
    [Description("Compliant")]
    Compliant,

    [Description("NonCompliant")]
    NonCompliant,

    [Description("Pending")]
    Pending,
}
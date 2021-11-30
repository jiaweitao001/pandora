using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.EventGrid.v2020_10_15_preview.EventSubscriptions
{
    [ConstantType(ConstantTypeAttribute.ConstantType.String)]
    internal enum EventDeliverySchemaConstant
    {
        [Description("CloudEventSchemaV1_0")]
        CloudEventSchemaVOneZero,

        [Description("CustomInputSchema")]
        CustomInputSchema,

        [Description("EventGridSchema")]
        EventGridSchema,
    }
}

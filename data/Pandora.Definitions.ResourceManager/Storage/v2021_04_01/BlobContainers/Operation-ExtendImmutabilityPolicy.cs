using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.BlobContainers;

internal class ExtendImmutabilityPolicyOperation : Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(ImmutabilityPolicyModel);

    public override ResourceID? ResourceId() => new ContainerId();

    public override Type? ResponseObject() => typeof(ImmutabilityPolicyModel);

    public override Type? OptionsObject() => typeof(ExtendImmutabilityPolicyOperation.ExtendImmutabilityPolicyOptions);

    public override string? UriSuffix() => "/immutabilityPolicies/default/extend";

    internal class ExtendImmutabilityPolicyOptions
    {
        [HeaderName("If-Match")]
        public string IfMatch { get; set; }
    }
}

using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_09_01.NetworkProfiles;

internal class CreateOrUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => typeof(NetworkProfileModel);

    public override ResourceID? ResourceId() => new NetworkProfileId();

    public override Type? ResponseObject() => typeof(NetworkProfileModel);


}
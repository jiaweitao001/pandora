using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Redis.v2023_04_01.PatchSchedules;

internal class Definition : ResourceDefinition
{
    public string Name => "PatchSchedules";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByRedisResourceOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(DayOfWeekConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(RedisPatchScheduleModel),
        typeof(ScheduleEntriesModel),
        typeof(ScheduleEntryModel),
    };
}
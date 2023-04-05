using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2019_06_01_preview.TaskRuns;

internal class Definition : ResourceDefinition
{
    public string Name => "TaskRuns";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetDetailsOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ArchitectureConstant),
        typeof(OSConstant),
        typeof(ProvisioningStateConstant),
        typeof(RunStatusConstant),
        typeof(RunTypeConstant),
        typeof(SecretObjectTypeConstant),
        typeof(SourceRegistryLoginModeConstant),
        typeof(VariantConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AgentPropertiesModel),
        typeof(ArgumentModel),
        typeof(CredentialsModel),
        typeof(CustomRegistryCredentialsModel),
        typeof(DockerBuildRequestModel),
        typeof(EncodedTaskRunRequestModel),
        typeof(FileTaskRunRequestModel),
        typeof(ImageDescriptorModel),
        typeof(ImageUpdateTriggerModel),
        typeof(OverrideTaskStepPropertiesModel),
        typeof(PlatformPropertiesModel),
        typeof(RunModel),
        typeof(RunPropertiesModel),
        typeof(RunRequestModel),
        typeof(SecretObjectModel),
        typeof(SetValueModel),
        typeof(SourceRegistryCredentialsModel),
        typeof(SourceTriggerDescriptorModel),
        typeof(TaskRunModel),
        typeof(TaskRunPropertiesModel),
        typeof(TaskRunPropertiesUpdateParametersModel),
        typeof(TaskRunRequestModel),
        typeof(TaskRunUpdateParametersModel),
        typeof(TimerTriggerDescriptorModel),
    };
}
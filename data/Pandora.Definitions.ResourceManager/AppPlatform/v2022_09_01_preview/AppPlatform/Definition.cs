using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2022_09_01_preview.AppPlatform;

internal class Definition : ResourceDefinition
{
    public string Name => "AppPlatform";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ApiPortalCustomDomainsCreateOrUpdateOperation(),
        new ApiPortalCustomDomainsDeleteOperation(),
        new ApiPortalCustomDomainsGetOperation(),
        new ApiPortalCustomDomainsListOperation(),
        new ApiPortalsCreateOrUpdateOperation(),
        new ApiPortalsDeleteOperation(),
        new ApiPortalsGetOperation(),
        new ApiPortalsListOperation(),
        new ApiPortalsValidateDomainOperation(),
        new AppsCreateOrUpdateOperation(),
        new AppsDeleteOperation(),
        new AppsGetOperation(),
        new AppsGetResourceUploadUrlOperation(),
        new AppsListOperation(),
        new AppsSetActiveDeploymentsOperation(),
        new AppsUpdateOperation(),
        new AppsValidateDomainOperation(),
        new BindingsCreateOrUpdateOperation(),
        new BindingsDeleteOperation(),
        new BindingsGetOperation(),
        new BindingsListOperation(),
        new BindingsUpdateOperation(),
        new BuildServiceAgentPoolGetOperation(),
        new BuildServiceAgentPoolListOperation(),
        new BuildServiceAgentPoolUpdatePutOperation(),
        new BuildServiceBuilderCreateOrUpdateOperation(),
        new BuildServiceBuilderDeleteOperation(),
        new BuildServiceBuilderGetOperation(),
        new BuildServiceBuilderListOperation(),
        new BuildServiceBuilderListDeploymentsOperation(),
        new BuildServiceCreateOrUpdateBuildOperation(),
        new BuildServiceGetBuildOperation(),
        new BuildServiceGetBuildResultOperation(),
        new BuildServiceGetBuildResultLogOperation(),
        new BuildServiceGetBuildServiceOperation(),
        new BuildServiceGetResourceUploadUrlOperation(),
        new BuildServiceGetSupportedBuildpackOperation(),
        new BuildServiceGetSupportedStackOperation(),
        new BuildServiceListBuildResultsOperation(),
        new BuildServiceListBuildServicesOperation(),
        new BuildServiceListBuildsOperation(),
        new BuildServiceListSupportedBuildpacksOperation(),
        new BuildServiceListSupportedStacksOperation(),
        new BuildpackBindingCreateOrUpdateOperation(),
        new BuildpackBindingDeleteOperation(),
        new BuildpackBindingGetOperation(),
        new BuildpackBindingListOperation(),
        new CertificatesCreateOrUpdateOperation(),
        new CertificatesDeleteOperation(),
        new CertificatesGetOperation(),
        new CertificatesListOperation(),
        new ConfigServersGetOperation(),
        new ConfigServersUpdatePatchOperation(),
        new ConfigServersUpdatePutOperation(),
        new ConfigServersValidateOperation(),
        new ConfigurationServicesCreateOrUpdateOperation(),
        new ConfigurationServicesDeleteOperation(),
        new ConfigurationServicesGetOperation(),
        new ConfigurationServicesListOperation(),
        new ConfigurationServicesValidateOperation(),
        new CustomDomainsCreateOrUpdateOperation(),
        new CustomDomainsDeleteOperation(),
        new CustomDomainsGetOperation(),
        new CustomDomainsListOperation(),
        new CustomDomainsUpdateOperation(),
        new DeploymentsCreateOrUpdateOperation(),
        new DeploymentsDeleteOperation(),
        new DeploymentsDisableRemoteDebuggingOperation(),
        new DeploymentsEnableRemoteDebuggingOperation(),
        new DeploymentsGenerateHeapDumpOperation(),
        new DeploymentsGenerateThreadDumpOperation(),
        new DeploymentsGetOperation(),
        new DeploymentsGetLogFileUrlOperation(),
        new DeploymentsGetRemoteDebuggingConfigOperation(),
        new DeploymentsListOperation(),
        new DeploymentsListForClusterOperation(),
        new DeploymentsRestartOperation(),
        new DeploymentsStartOperation(),
        new DeploymentsStartJFROperation(),
        new DeploymentsStopOperation(),
        new DeploymentsUpdateOperation(),
        new GatewayCustomDomainsCreateOrUpdateOperation(),
        new GatewayCustomDomainsDeleteOperation(),
        new GatewayCustomDomainsGetOperation(),
        new GatewayCustomDomainsListOperation(),
        new GatewayRouteConfigsCreateOrUpdateOperation(),
        new GatewayRouteConfigsDeleteOperation(),
        new GatewayRouteConfigsGetOperation(),
        new GatewayRouteConfigsListOperation(),
        new GatewaysCreateOrUpdateOperation(),
        new GatewaysDeleteOperation(),
        new GatewaysGetOperation(),
        new GatewaysListOperation(),
        new GatewaysValidateDomainOperation(),
        new MonitoringSettingsGetOperation(),
        new MonitoringSettingsUpdatePatchOperation(),
        new MonitoringSettingsUpdatePutOperation(),
        new RuntimeVersionsListRuntimeVersionsOperation(),
        new ServiceRegistriesCreateOrUpdateOperation(),
        new ServiceRegistriesDeleteOperation(),
        new ServiceRegistriesGetOperation(),
        new ServiceRegistriesListOperation(),
        new ServicesCheckNameAvailabilityOperation(),
        new ServicesCreateOrUpdateOperation(),
        new ServicesDeleteOperation(),
        new ServicesDisableTestEndpointOperation(),
        new ServicesEnableTestEndpointOperation(),
        new ServicesGetOperation(),
        new ServicesListOperation(),
        new ServicesListBySubscriptionOperation(),
        new ServicesListTestKeysOperation(),
        new ServicesRegenerateTestKeyOperation(),
        new ServicesStartOperation(),
        new ServicesStopOperation(),
        new ServicesUpdateOperation(),
        new SkusListOperation(),
        new StoragesCreateOrUpdateOperation(),
        new StoragesDeleteOperation(),
        new StoragesGetOperation(),
        new StoragesListOperation(),
    };
}

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Insights.v2023_04_03;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2023-04-03";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new AzureMonitorWorkspaces.Definition(),
    };
}
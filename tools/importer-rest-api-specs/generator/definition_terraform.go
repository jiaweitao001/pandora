package generator

import (
	"fmt"
	"strings"

	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
)

func (g PandoraDefinitionGenerator) GenerateTerraformResourceDefinition(fileName, terraformNamespace, apiVersion, apiResource, resourceLabel string, details resourcemanager.TerraformResourceDetails) error {
	code := codeForTerraformDefinition(terraformNamespace, apiVersion, apiResource, resourceLabel, details)
	return writeToFile(fileName, code)
}

func codeForTerraformDefinition(terraformNamespace, apiVersion, apiResource, resourceLabel string, details resourcemanager.TerraformResourceDetails) string {
	components := []string{
		templateForTerraformMethodDefinition("Create", details.CreateMethod, false, apiVersion, apiResource),
		templateForTerraformMethodDefinition("Delete", details.DeleteMethod, false, apiVersion, apiResource),
		templateForTerraformMethodDefinition("Read", details.ReadMethod, false, apiVersion, apiResource),
	}

	updateCode := "public MethodDefinition? UpdateMethod => null"
	if details.UpdateMethod != nil {
		updateCode = templateForTerraformMethodDefinition("Update", *details.UpdateMethod, true, apiVersion, apiResource)
	}
	components = append(components, updateCode)

	return fmt.Sprintf(`using Pandora.Definitions.Interfaces;

namespace %[1]s;

public class %[2]sResource : TerraformResourceDefinition
{
    public string DisplayName => "%[3]s";
    public ResourceID ResourceId => new %[4]s.%[5]s.%[6]s();
    public string ResourceLabel => "%[7]s";

    public bool GenerateIDValidationFunction => true;
    public bool GenerateSchema => true;

    %[8]s
}
`, terraformNamespace, details.ResourceName, details.DisplayName, apiVersion, apiResource, details.ResourceIdName, resourceLabel, strings.Join(components, "\n"))
}

func templateForTerraformMethodDefinition(methodName string, method resourcemanager.MethodDefinition, nullable bool, apiVersion, apiResource string) string {
	returnType := "MethodDefinition"
	if nullable {
		returnType = "MethodDefinition?"
	}
	return strings.TrimSpace(fmt.Sprintf(`
    public %[1]s %[2]sMethod => new MethodDefinition
    {
        Generate = %[3]t,
        Method = typeof(%[4]s.%[5]s.%[6]sOperation),
        TimeoutInMinutes = %[7]d,
    };
`, returnType, methodName, method.Generate, apiVersion, apiResource, method.MethodName, method.TimeoutInMinutes))
}
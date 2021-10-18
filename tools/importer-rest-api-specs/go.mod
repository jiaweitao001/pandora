module github.com/hashicorp/pandora/tools/importer-rest-api-specs

go 1.16

require (
	github.com/go-git/go-git/v5 v5.4.2
	github.com/go-openapi/analysis v0.20.1
	github.com/go-openapi/loads v0.20.2
	github.com/go-openapi/spec v0.20.3
	github.com/hashicorp/pandora/tools/sdk v0.0.0-00010101000000-000000000000
)

replace github.com/go-openapi/analysis v0.20.1 => github.com/jackofallops/analysis v0.20.2-0.20210705135157-888aa8dbc8e5

replace github.com/hashicorp/pandora/tools/sdk => ../sdk

Login-AzAccount

New-AzResourceGroup -Name "KPMGTest-RG" -location 'eastus'

New-AzResourceGroupDeployment -ResourceGroupName "KPMGTest-RG" -TemplateFile '.\Challenge 1\3-tier-app-deploy.template.json' `
                              -TemplateParameterFile '.\Challenge 1\3-tier-app-deploy.parameter.json' -Verbose
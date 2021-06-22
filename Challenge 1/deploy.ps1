$RGName = "KPMGTest-RG"

Login-AzAccount

$RG = Get-AzResourceGroup -Name $RGName -ErrorAction SilentlyContinue

if(!$RG)
{
    Write-Host "Resource Group $RGName does not exist, Creating it..."
    New-AzResourceGroup -Name $RGName -location 'eastus'
    Write-Host "Resource Group $RGName Created."

}
else {
    Write-Host "$RGName exist, continuing deployment"
}
Write-Host "Starting Deployment..."
New-AzResourceGroupDeployment -ResourceGroupName "KPMGTest-RG" -TemplateFile '.\3-tier-app-deploy.template.json' `
                              -TemplateParameterFile '.\3-tier-app-deploy.parameter.json' -Verbose
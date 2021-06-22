function Get-EC2Data {
    [CmdletBinding()]
    param (
        [Parameter()]
        [string]
        $CategoryName
    )
    if(!$CategoryName){
        Get-EC2InstanceMetadata -ListCategory
        $CategoryName = Read-Host "Please Select the Category"
    }
    return Get-EC2InstanceMetadata -Category $CategoryName
}
if(($null -eq $TestName) -or ($TestName -contains 'Get-AzPineconeOrganization'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzPineconeOrganization.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzPineconeOrganization' {
    It 'List' {
        { 
            $result =  Get-AzPineconeOrganization -SubscriptionId  $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName
            $result.Count | Should -BeGreaterThan 0 
        } | Should -Not -Throw
    }

    It 'Get' {
        { 
            $result =  Get-AzPineconeOrganization -SubscriptionId  $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -Name $env.ResourceName
            $result.Count | Should -BeGreaterThan 0 
        } | Should -Not -Throw
    }
}

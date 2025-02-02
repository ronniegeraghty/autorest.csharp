# MgmtRenameRules

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
azure-arm: true
require: $(this-folder)/../../../readme.md
input-file: $(this-folder)/MgmtRenameRules.json
namespace: MgmtRenameRules
model-namespace: false
public-clients: false
head-as-boolean: false
modelerfour:
  lenient-model-deduplication: true

keep-orphaned-models:
- VmDiskType

rename-rules:
  Os: OS
  Ip: IP
  Ips: IPs
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  VMScaleSet: VmScaleSet

format-by-name-rules:
  'tenantId': 'uuid'
  'resourceType': 'resource-type'
  'etag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'
  
directive:
  - rename-model:
      from: SshPublicKey
      to: SshPublicKeyInfo
  - rename-model:
      from: LogAnalyticsOperationResult
      to: LogAnalytics
  - rename-model:
      from: SshPublicKeyResource
      to: SshPublicKey
  - rename-model:
      from: RollingUpgradeStatusInfo
      to: VirtualMachineScaleSetRollingUpgrade
  - from: MgmtRenameRules.json
    where: $.definitions.UpgradeOperationHistoricalStatusInfo.properties.type
    transform: > 
      $["x-ms-client-name"] = "ResourceType";
  - from: MgmtRenameRules.json
    where: $.definitions
    transform: >
      $.HyperVGenerationType['x-ms-enum'].name = 'HyperVGenerationType';
```

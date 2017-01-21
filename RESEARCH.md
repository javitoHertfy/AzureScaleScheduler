# AzureScaleScheduler - Research

## Options / Alternatives

### Azure Auto Scale
*(Main source: [Auto scale a cloud service in Azure Portal](https://docs.microsoft.com/en-us/azure/cloud-services/cloud-services-how-to-scale-portal))*

The *Azure Instance Auto Scale* is provided by Azure and can be found in the Azure Portal, going to: *(Any Cloud Service)* -> Instances -> *(Any Instance Group)* -> Scale. Here we found the Scale panel for a specific instance group.

[Scale Panel Image](ResearchImages/ScalePanel_Default.png "Scale Panel")

Changing the *Scale by* parameter to **Schedule and performance rules**, we enter into the *Auto Scale* mode.

[Scale Panel With Auto Scale Image](ResearchImages/ScalePanel_AutoScale.png "Scale Panel With Auto Scale")

Here, we can configure the Scale scheduler with some **Profiles** and **Rules**.

* **Profile**: Here you can define a instance count profile, that will maintain it in-range. It can be *Always*, meaning that it will be checked always; *Recurrence*, meaning that it will be checked in a  pre-defined period of time recursive (for example, every Monday); or *Fixed Date*, which will only check the conditions in a fixed period of time (For example, from March the 3rd of 2017 at 12:00 to March the 5th of 2017)
* **Rule**: Here you can define a instance count change, depending on some rules that are matched. For example, if the CPU percentatge goes below 70%, increase the instance count by 1.

#### Pros
* Already functional and active functionality.
* Azure support
* Instance count control

#### Cons
* Only allows to modify the scale, not to *reboot* or *reimage* any instance
* The metrics of the rules aren't enough to a full control

### Azure Scheduler

### Azure WebJob

### Azure Automation


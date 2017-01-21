# AzureScaleScheduler

Scope
---------

- Create a "worker" that given a json configuration it goes through every service/database and scale it accordingly.

How it works
-----------------

- The configuration will have a way to describe each service and database separately and scale it accordingly
- The configuration will take into account load peaks in each service to scale it accordingly
- The worker will take into account that if a service is manually scaled up or down and it is not in the configuration will not re-scale it
- The worker will scale both cloud services and databases
- To be run must only depend in a json it will not depend on any external configuration

Questions to resolve
---------------------------
- Does a similar tool already exists
- Decide if we can do it with serverless code or automation
- Which language do we choose
- Json structure
- Where do we store the json

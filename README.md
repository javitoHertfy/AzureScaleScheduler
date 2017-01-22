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
- How much money are we going to save up? Calculate the average amount with the autoscale tool
- Does a similar tool already exists?
  Apparently there are a couple of alternatives:
  1.- The new portal has a more advanced scaling scheduler, but still I think that is not the solution for 30 services.. we need to configure one by one each service and DB
  2.- cloudmonix.com it has a free version
- Decide if we can do it with serverless code or automation
- Which language do we choose
- Json structure
- Where do we store the json

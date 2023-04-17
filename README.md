# DKHS-deployments
Docker Kubernetes Helm Skaffold Dapr deployment stack testing

* Using `docker` containerise a .Net core 6.0 web api serving a simple "hi"/"hello"/etc (other greetings) on a GET endpoint `/word`

* Using Kubernetes orchestrate instances of the docker container

* Using Helm package the relevant kubernetes files and make template value substitutions 

* Using Skaffold expedite the execution of the previous 3 steps 

* Using Dapr launch a sidecar (daprd container) attached to the webapi to abstract interaction with cloud infrastrucutre

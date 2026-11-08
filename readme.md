# ASP.NET Loadbalancer experiment
This project is a small experiment focus on loadbalancer and asp.net deployed on local docker in order to find out how load balancer really help in bottleneck.

# Prepare Environment
### Without Build
1. $ docker compose up -d --build
### Or With Build
1. $ docker compose up -d --build
2. $ docker compose restart nginx
#### Switch replica without editing the file
Run $ docker compose up -d --scale flcapp=1         #Stops 2 replicas, leaves 1 running, It lets you switch between 1 and 3 replicas without editing the file

## Test
1. Install K6
2. Run test without load balancer use: $ k6 run test.js
3. Run test with load balancer use: $ k6 run test_js.js

## Check docker performance
Run $ docker stats

## Confirm the limit of CPU is applied, 1 CPU = 1000000000
Run $ docker inspect -f "{{.Name}}  {{.HostConfig.NanoCpus}}" $(docker compose ps -q flcapp)

## Dispose
Run $ docker compose down
### Clean build
Run docker builder prune -a


## RESULT
It shows that we pay a little cost to load balance as a trade off to resolve server bottleneck.
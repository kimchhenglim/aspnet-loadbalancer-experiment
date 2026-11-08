# Prepare Environment
## Without Build
1. $ docker compose up -d --build
## Or With Build
1. $ docker compose up -d --build
2. $ docker compose restart nginx
### Switch replica without editing the file
1. $ docker compose up -d --scale flcapp=1         #Stops 2 replicas, leaves 1 running, It lets you switch between 1 and 3 replicas without editing the file

# Test
1. Install K6
2. Run test without load balancer use: $ k6 run test.js
3. Run test with load balancer use: $ k6 run test_js.js

# Check docker performance
1. > docker stats

# Confirm the limit of CPU is applied, 1 CPU = 1000000000
$ docker inspect -f "{{.Name}}  {{.HostConfig.NanoCpus}}" $(docker compose ps -q flcapp)

# Dispose
1. $ docker compose down
## Clean build
1. docker builder prune -a


# RESULT
It shows that we pay a little cost to load balance as a trade off to resolve server bottleneck.
# LK
- OS: Linux
- Docker hub: https://hub.docker.com/r/lamkhai/lamkhai.com
- Docker client:
  - Build:
	```
	docker build -t lamkhai/lamkhai.com .
	```
  - Run:
	- Development (Without using compose):
	  - Run via Container (Dockerfile) or via the following command:
	    ```
	    docker run --name=LK-Cli -p 8080 -e ASPNETCORE_ENVIRONMENT=Development lamkhai/lamkhai.com
	    ``` 
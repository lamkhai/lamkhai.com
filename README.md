# LK

## Environments:
- Development:
  - http
  - https
  - IIS Express
  - Container (Dockerfile)
- Staging:
  - Refer to [Publish to Docker](#publish-to-docker)
  - Refer to [Publish to IIS](#publish-to-iis)
- Production:
  - https://lamkhai.azurewebsites.net/

## Publish to Docker:
- OS: Linux
- Docker hub: https://hub.docker.com/r/lamkhai/lamkhai.com
- Docker client:
  - Build:
	```
	docker build -t lamkhai/lamkhai.com .
	```
  - Run:
	```
	docker run --name=LK-Cli -p 8080 -e ASPNETCORE_ENVIRONMENT=Staging lamkhai/lamkhai.com
	```

## Publish to IIS:
Use:
- FolderProfile
- IISProfile

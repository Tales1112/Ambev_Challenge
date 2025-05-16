# Getting Started

This guide provides step-by-step instructions to set up and run the `Ambev.DeveloperEvaluation` project locally. The project is a sales management API built with .NET 8, PostgreSQL, RabbitMQ, and Docker.

## Prerequisites

Ensure you have the following tools installed on your system:
- **Docker**: For containerization (Docker Desktop recommended on Windows/Mac).
- **Docker Compose**: Included with Docker Desktop or install separately.
- **.NET 8 SDK**: For local development or manual builds (optional if using Docker).
- **Git**: To clone the repository.
- **Visual Studio Code** or **Visual Studio 2022**: Ide for code, build, tests, debugging.

Verify installations:
```sh
docker --version
docker-compose --version
dotnet --version
git --version
```

### Step 1: Clone the Repository
Clone the project from GitHub:
```bash
git clone https://github.com/gBritz/abi-gth-omnia-developer-evaluation.git
cd abi-gth-omnia-developer-evaluation
```

### Step 2: Configure the Environment
The project uses Docker Compose to manage services (API, PostgreSQL, RabbitMQ). No additional .env file is required as configurations are embedded in docker-compose.yml. However, ensure the following ports are free:

8080, 8081 (API)
5432 (PostgreSQL)
5672, 15672 (RabbitMQ)
Check for port availability:
```
netstat -an | findstr "8080 8081 5432 5672 15672"  # Windows
lsof -i :8080,8081,5432,5672,15672                  # Linux/Mac
```

If any port is in use, stop the conflicting service or adjust the ports in docker-compose.yml.

### Step 3: Set Up the Docker Network
Create a custom Docker network for communication between containers:
```bash
docker network create ambev_network
```

### Step 4: Start the Services
Run the project using Docker Compose:
```bash
docker-compose up -d
```

`-d` runs containers in detached mode (background).
This starts the API, PostgreSQL, and RabbitMQ services.
Verify that all containers are running:
```bash
docker ps
```

You should see three containers:
* ambev_developer_evaluation_webapi (API)
* ambev_developer_evaluation_database (PostgreSQL)
* rabbitmq (RabbitMQ)
If a container fails to start, check logs:
```bash
docker logs <container_name>
```

#### Manual Network Connection (if needed)
If containers are not automatically connected to ambev_network, link them manually:
```bash
docker network connect ambev_network ambev_developer_evaluation_webapi
docker network connect ambev_network ambev_developer_evaluation_database
docker network connect ambev_network rabbitmq
```
Confirm the network setup:
```bash
docker network inspect ambev_network
```

### Step 5: Create database in PostgreSQL
Enter the directory `src` and execute command below:
```bash
dotnet ef database update --project Ambev.DeveloperEvaluation.ORM --startup-project Ambev.DeveloperEvaluation.WebApi
```
[To more information about database versioning](./database-versioning.md)


### Step 6: Access the API
Once the services are running, access the Swagger UI to interact with the API:

URL: http://localhost:8081/swagger
The API runs on HTTPS (8081) by default, but HTTP (8080) is also available.


## Stopping the Project
To stop and remove the containers:
```bash
docker-compose down
```
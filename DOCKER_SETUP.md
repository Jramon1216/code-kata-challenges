# Docker Setup Guide

This project includes Docker configuration to run a complete development environment with support for multiple programming languages.

## Supported Languages

- **JavaScript/TypeScript**: Node.js 20.x
- **Python**: Python 3.x with Jupyter Notebook
- **C#**: .NET 8.0 SDK

## Prerequisites

- Docker (version 20.10 or later)
- Docker Compose (version 1.29 or later)

## Quick Start

### 1. Build the Docker Image

```bash
docker-compose build
```

### 2. Start the Development Container

#### Interactive Development (with bash access):

```bash
docker-compose run code-kata-dev
```

This will give you an interactive bash shell where you can run:

- Node.js: `node`, `npm`
- Python: `python3`, `pip`
- .NET: `dotnet`
- TypeScript: `tsc` (after `npm install`)

#### Run Jupyter Notebook:

```bash
docker-compose up jupyter
```

Then access Jupyter at `http://localhost:8888`

### 3. Running Code

#### JavaScript/TypeScript

```bash
# Inside the container
npm run build:ts
node typescript-kata/dist/file.js
node javascript-kata/file.js
```

#### Python

```bash
# Inside the container
python3 python-kata/good-evil.py
```

#### C#

```bash
# Inside the container
dotnet run --project c-sharp-kata/c-sharp-kata.csproj
```

## Container Services

### code-kata-dev

- **Purpose**: Main development environment with all language support
- **Ports**: 3000, 5000, 8888
- **Access**: `docker-compose run code-kata-dev`
- **Volume**: Entire project mounted at `/workspace`

### jupyter

- **Purpose**: Jupyter Notebook server for interactive Python/notebook development
- **Port**: 8888
- **Access**: `http://localhost:8888`
- **Command**: `docker-compose up jupyter`

## Common Commands

### Interactive Shell

```bash
docker-compose run code-kata-dev bash
```

### Running a Single Command

```bash
docker-compose run code-kata-dev python3 python-kata/validate-card.py
docker-compose run code-kata-dev npm run build:ts
docker-compose run code-kata-dev dotnet build c-sharp-kata/c-sharp-kata.csproj
```

### View Container Logs

```bash
docker-compose logs -f code-kata-dev
```

### Stop All Containers

```bash
docker-compose down
```

### Remove All Containers and Images

```bash
docker-compose down --rmi all
```

## Development Workflow

1. **Start the main container**:

   ```bash
   docker-compose run code-kata-dev
   ```

2. **Inside the container, develop normally**:

   - Edit files in your IDE (they're mounted as volumes)
   - Run/test your code using the container

3. **For notebook work**:
   - Run `docker-compose up jupyter` in another terminal
   - Open `http://localhost:8888` in your browser

## Troubleshooting

### Port Already in Use

If ports 8888, 3000, or 5000 are already in use:

1. Change the port mapping in `docker-compose.yml`:

   ```yaml
   ports:
     - "8889:8888" # Use 8889 instead of 8888
   ```

2. Or stop the service using the port:
   ```bash
   lsof -i :8888  # Find what's using the port
   kill -9 <PID>
   ```

### Permission Denied Errors

If you encounter permission errors on Linux:

```bash
sudo usermod -aG docker $USER
newgrp docker
```

### Rebuild After Changes

If you modify `Dockerfile` or dependencies:

```bash
docker-compose build --no-cache
```

## Environment Variables

You can add custom environment variables in `docker-compose.yml`:

```yaml
environment:
  - NODE_ENV=development
  - PYTHONUNBUFFERED=1
  - MY_CUSTOM_VAR=value
```

## IDE Integration

### VS Code

1. Install the "Docker" and "Remote - Containers" extensions
2. Open the project folder
3. Click "Reopen in Container" or use the Command Palette (`Cmd+Shift+P`)
4. Select the Dockerfile

This will give you full IDE support inside the container.

## Next Steps

- Start coding with your preferred language!
- Check individual language directories for specific kata files
- Use Jupyter for interactive Python notebook development
- Access the container's shell for testing and debugging

# Multi-language development environment
# Supports: Node.js (JavaScript/TypeScript), Python, and .NET (C#)

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base

# Install Node.js and npm
RUN apt-get update && apt-get install -y \
    curl \
    && curl -fsSL https://deb.nodesource.com/setup_20.x | bash - \
    && apt-get install -y nodejs \
    && rm -rf /var/lib/apt/lists/*

# Install Python and pip
RUN apt-get update && apt-get install -y \
    python3 \
    python3-pip \
    python3-venv \
    && rm -rf /var/lib/apt/lists/*

# Create and activate virtual environment for Python packages
RUN python3 -m venv /opt/venv
ENV PATH="/opt/venv/bin:$PATH"

# Install Jupyter for Python notebooks
RUN pip install --no-cache-dir \
    jupyter \
    notebook \
    ipython \
    numpy \
    pandas

# Set working directory
WORKDIR /workspace

# Copy project files
COPY . .

# Install Node.js dependencies
RUN npm install

# Restore .NET dependencies
RUN dotnet restore c-sharp-kata/c-sharp-kata.csproj

# Expose ports for different services
EXPOSE 8888 3000 5000

# Default command
CMD ["/bin/bash"]

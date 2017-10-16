FROM microsoft/aspnetcore-build:2

WORKDIR /app

COPY . .

RUN npm install
RUN node node_modules/webpack/bin/webpack.js --config webpack.config.vendor.js --env.prod
RUN node node_modules/webpack/bin/webpack.js --env.prod

# postgresql-client - is for db health check script in docker-compose.yml
RUN apt-get update
RUN apt-get install -y postgresql-client

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 8080/tcp

CMD ["dotnet", "run", "--launch-profile", "Docker"]
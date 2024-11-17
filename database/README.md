# Database

Create .env file:
```
MSSQL_SA_PASSWORD=<sa password>
```

Run:
```
docker compose up -d

export SA_PASSWORD=<sa password>

./init.sql
```
#!/bin/bash

docker-compose exec db /opt/mssql-tools/bin/sqlcmd -H localhost -U sa -P "${SA_PASSWORD}" -i /init.sql
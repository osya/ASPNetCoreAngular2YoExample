#!/bin/bash
# wait-for-postgres.sh

set -e

host="$1"
port="$2"
shift
shift
cmd="$@"

until psql -h "$host" -p "$port" -w -c '\l'; do
  >&2 echo "Postgres is unavailable - sleeping"
  sleep 1
done

>&2 echo "Postgres is up - executing command"
exec $cmd
# Feliz.ReactLeaflet

Fable + Giraffe server with Entity Framework Core and JWT-authentication.

## Run

* Update the Postgres connection string in `src/Server/Settings.fs`
* If no changes are made, a demo user will be created upon server startup. See `src/Seed.fs`

`fake build -t Run`

# Web API Migrations in ASP.NET Core 2.0

Now I developed an web api implementing migrations concept.

I am using Entity Framework Core Code First with Migrations to avoid open Sql Server and improve the development.

You have just to download and run the web api with `dotnet run` command. Before the web api is available, migrations will try to create the data base on the basis of migrations that I created.

In less words, we can create the business model with their relationships that corresponds to each other. When we have finished the relationships, we created migrations to step by step goes building the data base.

﻿1. Install cli tool:
	dotnet tool install --global dotnet-ef

2. Create Migration
	dotnet ef migrations add initial --startup-project ../Tastelio.Api

3. Run Update
	dotnet ef database update --startup-project ../Tastelio.Api
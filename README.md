# IDMissionPOC

This repository contains a demo ASP.NET Core Web API project that shows how IDMission KYC verification can be integrated.

The sample project lives under `src/IDMissionDemo`. It was created manually in this environment without using the `dotnet` CLI. To run it you must have the .NET 6 SDK installed locally.

```
cd src/IDMissionDemo
 dotnet run
```

You can then send a POST request to `https://localhost:5001/api/kyc` with JSON data:

```json
{
  "imageBase64": "<base64-encoded-image>"
}
```

Configuration for the IDMission endpoint and credentials is located in `appsettings.json`.

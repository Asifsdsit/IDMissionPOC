# IDMissionPOC

This repository contains a demo ASP.NET Core Web API project that shows how IDMission KYC verification can be integrated.

All production code now lives under the `src` directory and corresponding test projects live under `tests`.  Each project has its own test project following the `<ProjectName>.Tests` convention.  This layout makes it easier to add more applications and their tests as the repository grows.

The current sample project lives under `src/IDMissionDemo`. It was created manually in this environment without using the `dotnet` CLI. To run it you must have the .NET 6 SDK installed locally.

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

## Running Tests

All test projects are located under the `tests` folder. Run all tests with the .NET CLI:

```bash
dotnet test
```

Note that the .NET SDK must be installed locally for the above command to work.

# IDMission Demo

This directory contains a sample ASP.NET Core Web API project demonstrating how to integrate with the IDMission KYC verification service. The `KycController` exposes an endpoint at `/api/kyc` that accepts a base64 encoded image and forwards it to the configured IDMission endpoint.

Configuration for the IDMission API endpoint, API key and secret can be set in `appsettings.json` or through environment variables.

Due to limitations of this environment, the project was created manually without running `dotnet new` or restoring NuGet packages. To run the project locally you must have the .NET SDK installed.

```bash
# build and run
cd src/IDMissionDemo
 dotnet run
```

Then POST to `https://localhost:5001/api/kyc` with JSON body:

```json
{
  "imageBase64": "<base64-encoded-image>"
}
```

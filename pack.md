TOKEN=[TOKEN]

dotnet build Ripple.Address --configuration Release
dotnet pack Ripple.Address --configuration Release
dotnet nuget push Ripple.Address/bin/Release/Ripple.Address.0.1.0.nupkg --api-key $TOKEN --source "btctrader"

dotnet build Ripple.Signing --configuration Release
dotnet pack Ripple.Signing --configuration Release
dotnet nuget push Ripple.Signing/bin/Release/Ripple.Signing.0.1.0.nupkg --api-key $TOKEN --source "btctrader"
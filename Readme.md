[![NuGet](https://img.shields.io/nuget/v/Digi21.DigiNG.IO.Shp?style=flat)](https://www.nuget.org/packages/Digi21.DigiNG.IO.Shp/)

# Digi21.DigiNG.IO.Shp

This repository contains the source code of the reference assembly: Digi21.DigiNG.IO.Shp that is distributed through NuGet package for reading/creating Shapefile files (*.SHP) on computers with Digi3D.AI installed.

## Publishing

Push a tag `v<version>` whose version matches `<version>` in the `.nuspec` of the `NuGet` folder. The *Release* workflow builds the reference assembly, packs it and publishes it to nuget.org with trusted publishing (repository secret `NUGET_USER`, the nuget.org profile name). The packages are not author-signed; the reference assembly is public-signed with `Digi21.PublicKey.snk`, which contains only the public key.

@echo off
nuget.exe pack Digi21.DigiNG.IO.Shp.nuspec
nuget.exe sign Digi21.DigiNG.IO.Shp.17.2.0.nupkg -CertificatePath dwo.pfx -TimeStamper http://tsa.starfieldtech.com

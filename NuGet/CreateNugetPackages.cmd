@echo off
nuget.exe pack Digi21.DigiNG.IO.Shp.nuspec
nuget.exe sign Digi21.DigiNG.IO.Shp.22.1.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://timestamp.comodoca.com?td=sha256.

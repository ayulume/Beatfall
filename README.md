# Beatfall
Beatfall is a rhythm game made using osu!framework.

# Build from source
## For Linux
`dotnet publish -r linux-x64 -p:DefineConstants=LINUX`
## For Windows
`dotnet publish -r win-x64 --self-contained true -p:PublishSingleFile=true`

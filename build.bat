dotnet restore src/firstGiraffe
dotnet build src/firstGiraffe

dotnet restore tests/firstGiraffe.Tests
dotnet build tests/firstGiraffe.Tests
dotnet test tests/firstGiraffe.Tests

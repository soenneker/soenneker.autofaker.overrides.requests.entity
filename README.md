[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.requests.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.requests.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.requests.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.requests.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.requests.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.requests.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.requests.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.requests.entity/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Requests.Entity

An AutoFaker override that assigns valid identifiers to `EntityRequest` fixtures.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Requests.Entity
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Requests.Entity;
using Soenneker.Requests.Entity;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new EntityRequestOverride()];

EntityRequest request = autoFaker.Generate<EntityRequest>();
```

The override applies to `EntityRequest` and derived request types and sets `Id` to a GUID string. Because the contract treats `Id` as optional for create operations, explicitly set it to `null` after generation when testing creation semantics.

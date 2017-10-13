This repository contains a repro to issues with the latest `xunit (2.3.0)` in relation to https://github.com/xunit/xunit/issues/1060. It also includes a repro of an inability to load native dependencies. This issue is resolved by downgrading to an earlier beta.

To repro:
* Change Xunit1060Repro.csproj to use XunitVersion=2.3.0
* `rm bin -Recurse; rm obj -Recurse`
* `dotnet restore`
* `dotnet xunit`

To fix:
* Change Xunit1060Repro.csproj to use XunitVersion=2.3.0-beta5-build3769
* `rm bin -Recurse; rm obj -Recurse`
* `dotnet restore`
* `dotnet xunit`
# Agent Notes

## Packaging

- `winget-tui` version is pinned in `winget-tui.version` at the repo root; update it there when refreshing the upstream payload.
- Only Windows x64 (`win-x64`) and Windows ARM64 (`win-arm64`) are supported.
- The `PrepareTui` MSBuild target in `src/winget/winget.csproj` downloads the binaries automatically during `Build` or `Pack`. No manual restore step is needed.
- Binaries are cached at `src/winget/obj/winget-tui/<version>/<rid>/winget-tui.exe`. Embedding the version in the path means a version bump automatically triggers a fresh download.
- Batching over `TuiRid` items downloads both RIDs incrementally; MSBuild skips a RID if its versioned output already exists.

## Runtime

- The main app resolves `winget-tui.exe` from the bundled payload next to the app output; there is no PATH fallback.

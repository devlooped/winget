## winget-tui v0.3.0

A terminal UI for Windows Package Manager (winget).

### 📦 Downloads

| File | Platform |
|------|----------|
| `winget-tui-x64.exe` | Windows x64 |
| `winget-tui-arm64.exe` | Windows ARM64 |

### Usage

Download the executable for your platform and run it. No installation required.


## What's Changed
* perf: pre-compute column indices once per table; avoid Vec<char> in detect_columns by @Copilot in https://github.com/shanselman/winget-tui/pull/61
* [Repo Assist] chore: bump compatible dependencies (cargo update) by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/70
* [Repo Assist] refactor: add PackageDetail::merge_over to eliminate verbose field-by-field merge by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/71
* [Repo Assist] fix: guard install/uninstall/upgrade against truncated package IDs by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/72
* [Repo Assist] improve: guard load_detail against truncated package IDs by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/73
* [Repo Assist] perf: extract clean_output, reduce winget output cleaning from 3 allocations to 1 by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/75
* [Repo Assist] test: add 18 unit tests for parse_sources, show edge cases, and models by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/76
* [Repo Assist] fix: use Unicode display widths in truncate() for correct CJK rendering by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/77
* [Repo Assist] feat: show available version in detail panel for upgradeable packages by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/69
* [Repo Assist] fix: reset detail_loading flag when switching tabs by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/74
* [Repo Assist] refactor: add SourceFilter::as_arg() to eliminate inline string matching by @github-actions[bot] in https://github.com/shanselman/winget-tui/pull/78

## New Contributors
* @github-actions[bot] made their first contribution in https://github.com/shanselman/winget-tui/pull/70

**Full Changelog**: https://github.com/shanselman/winget-tui/compare/v0.2.3...v0.3.0

https://github.com/shanselman/winget-tui/releases/tag/v0.3.0

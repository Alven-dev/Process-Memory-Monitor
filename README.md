# Process Memory Monitor

A lightweight Windows tool that tracks a process's memory usage and warns you before it hits the ceiling.

<img width="456" height="501" alt="Process Memory Monitor" src="https://github.com/user-attachments/assets/1c265701-75bb-4fb9-80f0-013d9c2302e4" />

## Why?

This started as a tool for the ArcheAge Classic community. The game runs on a 32-bit client, which can address at most 4GB of memory. During long sessions the process creeps toward that ceiling and the client crashes with no warning at all.

You can't prevent it — but you can see it coming. This tool tells you when a restart is due, so the crash happens on your terms instead of mid-raid.

It works with any process, not just games.

## Features

- Tracks memory usage of any running process with a visible window
- Configurable alert threshold
- Sound alarm and system tray notification when the threshold is crossed
- Usage bar changes color as memory climbs - blue, orange, red
- Alert fires once per crossing, not once per second
- Optional automatic shader cache cleanup when the monitored process exits
  
## How to use?

1. Press **Refresh List** to load running processes
2. Pick the process you want to watch
3. Set your alert threshold in MB
4. Press **Start Monitoring**

## Shader cache cleanup

Games that compile shaders on the fly build up a cache that can grow stale and cause crashes or stutter. ArcheAge recommends clearing it manually - this tool can do it for you.
Tick **Clear shader cache on exit**, point the path field at your shaders folder, and the tool wipes it the moment the monitored process closes. The game rebuilds the folder on next launch.
The default path assumes a standard ArcheAge Classic install. Use **Browse** if yours sits elsewhere, or if you play a different game.
The cleanup only runs on folders whose path contains `shaders`, so a mistyped path **can't wipe something important**.
The threshold field and the refresh button lock while monitoring is active. Press Stop Monitoring to change them.

**Choosing a threshold**

There is no universal value. Watch the process during a normal session, note where it sits, and set the threshold somewhat below the point where things start going wrong.

**Two things worth knowing:**

The 4096 MB scale assumes the process is built with LARGEADDRESSAWARE. Without that flag a 32-bit process is capped at 2GB instead, and the bar will never fill past halfway.
The tool reads WorkingSet64, which is physical memory in use. That is close to, but not identical with, the address space that actually triggers a crash.

## Built with

C# / .NET 10 / Windows Forms

### Verification
[VirusTotal report](https://www.virustotal.com/gui/file/a7073dfbbd47006117758ff0ebc6c2dcf80e8fd608feb95ee1b230843ad3ef74) — clean, 0/69

SHA-256: `a7073dfbbd47006117758ff0ebc6c2dcf80e8fd608feb95ee1b230843ad3ef74`

## Download

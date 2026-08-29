# Process Memory Monitor

A lightweight Windows tool that tracks a process's memory usage and warns you before it hits the ceiling.

<img width="462" height="409" alt="image" src="https://github.com/user-attachments/assets/3c4fe76f-cad1-4c81-9214-66602b052d06" />

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
  
## How to use?

1. Press **Refresh List** to load running processes
2. Pick the process you want to watch
3. Set your alert threshold in MB
4. Press **Start Monitoring**

The threshold field and the refresh button lock while monitoring is active. Press Stop Monitoring to change them.

**Choosing a threshold**

There is no universal value. Watch the process during a normal session, note where it sits, and set the threshold somewhat below the point where things start going wrong.

**Two things worth knowing:**

The 4096 MB scale assumes the process is built with LARGEADDRESSAWARE. Without that flag a 32-bit process is capped at 2GB instead, and the bar will never fill past halfway.
The tool reads WorkingSet64, which is physical memory in use. That is close to, but not identical with, the address space that actually triggers a crash.

## Built with

C# / .NET 10 / Windows Forms

## Download


# Project Tetr
Work in progress. Here is a [showcase](https://www.youtube.com/watch?v=TqWu-4EPfW0).

Currently allows you to 1v1 a Tetris bot, or have two Tetris bots 1v1-ing eachoter. Bots need to implement [Tetris Bot Protocol](https://github.com/tetris-bot-protocol/tbp-spec/).

Keybinds (currently my own):

 - CW: D
 - CCW: A
 - 180: S
 - Hold: LShift
 - Harddrop: Space
 - Softdrop: DownArrow
 - Left: LeftArrow
 - Right: RightArrow
 - Settings: Tab
 - Reset: Ctrl+R / F5
 - Change mode: Ctrl+T / F6

DAS and Bot Speed are configurable for PvB.
Softdrop speed is infinite.

Bot Speed is configurable individually for BvB.

Bot speed under 50ms is experimental and not guaranteed to work. The faster the speed, the higher the odds something will go wrong.

For ideal visuals, use a 16:9 resolution.

The game has absolutely no authority. It will accept move 0 every time, will not question whether that move is obstructed, unreachable or if it is or not a spin.

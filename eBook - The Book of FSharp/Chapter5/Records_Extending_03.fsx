﻿open System

type rgbColor = { R : byte; G : byte; B : byte }
                member x.ToHexString() = sprintf "#%02X%02X%02X" x.R x.G x.B
                static member Red = { R = 255uy; G = 0uy; B = 0uy }
                static member Green = { R = 0uy; G = 255uy; B = 0uy }
                static member Blue = { R = 0uy; G = 0uy; B = 255uy }
                static member (+) (l : rgbColor, r : rgbColor) =
                  { R = Math.Min(255uy, l.R + r.R)
                    G = Math.Min(255uy, l.G + r.G)
                    B = Math.Min(255uy, l.B + r.B) }

let yellow = { R = 255uy; G = 0uy; B = 0uy } +
             { R = 0uy; G = 255uy; B = 0uy }

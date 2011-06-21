﻿///////////////////////////////////////////////////////////////////////////////
/// Sharplike, The Open Roguelike Library (C) 2010 Ed Ropple.               ///
///                                                                         ///
/// This code is part of the Sharplike Roguelike library, and is licensed   ///
/// under the Common Public Attribution License (CPAL), version 1.0. Use of ///
/// this code is purusant to this license. The CPAL grants you certain      ///
/// permissions and requirements and should be read carefully before using  ///
/// this library.                                                           ///
///                                                                         ///
/// A copy of this license can be found in the Sharplike root directory,    ///
/// and must be included with all projects released using this library.     ///
///////////////////////////////////////////////////////////////////////////////


using System;
using System.Drawing;
using Sharplike.Core.Rendering;
using Sharplike.Mapping;

namespace Sharplike.Tests.Sandbox
{


	[Serializable]
    public class FloorSquare : AbstractSquare
    {
        public override Color BackgroundColor { get { return Color.Black; } }

        private static Glyph[] glyphs = { new Glyph((int)'.', Color.Gray) };
        public override Glyph[] Glyphs
        {
            get
            {
                return FloorSquare.glyphs;
            }
        }

        public FloorSquare(Int32 x, Int32 y, Int32 z)
            : base(x, y, z)
        {
        }
    }
}
﻿///////////////////////////////////////////////////////////////////////////////
/// Sharplike, The Open Roguelike Library (C) 2010 2010 Ed Ropple.          ///
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
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Sharplike.Core.Rendering;

namespace Sharplike.Frontend.Rendering
{
    public class TKRenderSystem : AbstractRenderSystem
    {
        public override AbstractWindow CreateWindow(Size displayDimensions, GlyphPalette palette, Object context)
        {
            if (win == null)
                win = new TKWindow(displayDimensions, palette, context as Control);
            return win;
        }

        public override AbstractWindow Window
        {
            get { return win; }
        }
        private TKWindow win = null;

        public override void Dispose()
        {
            if (win != null)
                win.Dispose();
        }

        public override void Process()
        {
            win.Update();
        }
    }
}

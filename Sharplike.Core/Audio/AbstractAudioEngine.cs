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
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sharplike.Core;
using Mono.Addins;

namespace Sharplike.Core.Audio
{
	public abstract class AbstractAudioEngine : IDisposable
	{
		/// <summary>
		/// Build an audio cue (encapsulation of an audio file).
		/// </summary>
		/// <param name="audioFilename">The audio file to cue up.</param>
		/// <returns>An engine-specific AudioCue subclass.</returns>
        public AbstractAudioCue BuildAudioCue(String audioFilename)
        {
            using (FileStream s = new FileStream(audioFilename, FileMode.Open))
            {
                return BuildAudioCue(s);
            }
        }

        /// <summary>
        /// Process audio events. This should be called frequently.
        /// </summary>
        public abstract void Process();

        /// <summary>
        /// Build an audio cue from an arbitrary stream.
        /// </summary>
        /// <param name="audioFilename">The audio file to cue up.</param>
        /// <returns>An engine-specific AudioCue subclass.</returns>
        public abstract AbstractAudioCue BuildAudioCue(Stream audioData);

        public abstract void Dispose();
    }
}
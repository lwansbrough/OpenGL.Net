
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Binding for wglDelayBeforeSwapNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="seconds">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_delay_before_swap")]
		public static bool DelayBeforeSwapNV(IntPtr hDC, float seconds)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDelayBeforeSwapNV != null, "pwglDelayBeforeSwapNV not implemented");
			retValue = Delegates.pwglDelayBeforeSwapNV(hDC, seconds);
			LogFunction("wglDelayBeforeSwapNV(0x{0}, {1}) = {2}", hDC.ToString("X8"), seconds, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

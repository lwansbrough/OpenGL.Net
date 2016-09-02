
// Copyright (C) 2013-2015 Luca Piccioni
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
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Device context factory.
	/// </summary>
	public class DeviceContextFactory
	{
		/// <summary>
		/// Create the specified window.
		/// </summary>
		/// <param name='handle'>
		/// A <see cref="IntPtr"/> which is used to create the device context.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the handle of <see cref="handle"/> is not created.
		/// </exception>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static IDeviceContext Create(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
				throw new ArgumentException("handle");

			return (new NativeDeviceContext(handle));
		}
	}
}
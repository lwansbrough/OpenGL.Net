
// Copyright (C) 2016 Luca Piccioni
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
using System.Text;

namespace OpenCL
{
	public partial class Cl
	{
		/// <summary>
		/// Get specific information about the OpenCL platform.
		/// </summary>
		/// <param name="platform">
		/// The platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the platform information being queried. It can be one of the values specified in 
		/// the table below.
		/// </param>
		/// <param name="param_value">
		/// 
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, out string param_value)
		{
			const uint ParamMaxLength = 256;

			int err;
			byte[] paramBuffer = new byte[ParamMaxLength];
			uint paramLength;

			GCHandle paramBufferHandle = GCHandle.Alloc(paramBuffer, GCHandleType.Pinned);
			try {
				err = GetPlatformInfo(platform, param_name, ParamMaxLength, paramBufferHandle.AddrOfPinnedObject(), out paramLength);
			} finally {
				paramBufferHandle.Free();
			}
			
			param_value = Encoding.ASCII.GetString(paramBuffer).Trim();

			return (err);
		}

		/// <summary>
		/// Get specific information about the OpenCL platform.
		/// </summary>
		/// <param name="platform">
		/// The platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the platform information being queried. It can be one of the values specified in 
		/// the table below.
		/// </param>
		/// <param name="param_value">
		/// 
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, out ulong param_value)
		{
			const uint ParamMaxLength = 256;

			int err;
			uint paramLength;

			param_value = 0;

			GCHandle paramBufferHandle = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				err = GetPlatformInfo(platform, param_name, ParamMaxLength, paramBufferHandle.AddrOfPinnedObject(), out paramLength);
			} finally {
				paramBufferHandle.Free();
			}

			return (err);
		}
	}
}

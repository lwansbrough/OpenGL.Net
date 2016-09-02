
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_YUV_PLANE0_TEXTURE_UNIT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_PLANE0_TEXTURE_UNIT_NV = 0x332C;

		/// <summary>
		/// Value of EGL_YUV_PLANE1_TEXTURE_UNIT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_PLANE1_TEXTURE_UNIT_NV = 0x332D;

		/// <summary>
		/// Value of EGL_YUV_PLANE2_TEXTURE_UNIT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_PLANE2_TEXTURE_UNIT_NV = 0x332E;

		/// <summary>
		/// Value of EGL_YUV_NUMBER_OF_PLANES_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_NUMBER_OF_PLANES_EXT = 0x3311;

		/// <summary>
		/// Value of EGL_YUV_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_BUFFER_EXT = 0x3300;

		/// <summary>
		/// Binding for eglStreamConsumerGLTextureExternalAttribsNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public static bool StreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglStreamConsumerGLTextureExternalAttribsNV != null, "peglStreamConsumerGLTextureExternalAttribsNV not implemented");
					retValue = Delegates.peglStreamConsumerGLTextureExternalAttribsNV(dpy, stream, p_attrib_list);
					LogFunction("eglStreamConsumerGLTextureExternalAttribsNV(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), stream.ToString("X8"), LogValue(attrib_list), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

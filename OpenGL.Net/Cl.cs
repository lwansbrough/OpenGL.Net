
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenCL
{
	/// <summary>
	/// OpenCL bindings.
	/// </summary>
	public partial class Cl : OpenGL.KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Cl()
		{
			// Cache imports & delegates
			_Delegates = GetDelegateList(typeof(Cl));
			_ImportMap = GetImportMap(typeof(Cl));
			// Load procedures
			SyncDelegates();
		}

		#endregion

		#region Imports/Delegates Management

		/// <summary>
		/// Synchronize OpenGL delegates.
		/// </summary>
		public static void SyncDelegates()
		{
			LoadProcDelegates(Library, _ImportMap, _Delegates);
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "OpenCL.dll";

		/// <summary>
		/// Imported functions delegates.
		/// </summary>
		private static List<FieldInfo> _Delegates;

		/// <summary>
		/// Build a string->MethodInfo map to speed up extension loading.
		/// </summary>
		internal static SortedList<string, MethodInfo> _ImportMap;

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			
		}

		#endregion

		#region Types

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct ImageFormat
		{
			public uint ChannelOrder;

			public uint ChannelDataType;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct ImageDescr
		{
			public uint Type;

			public uint Width;

			public uint Height;

			public uint Depth;

			public uint ArraySize;

			public uint RowPitch;

			public uint SlicePitcth;

			public uint MipLevels;

			public uint Samples;

			public IntPtr Buffer;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct BufferRegion
		{
			public uint Origin;

			public uint Size;
		}

		public delegate void NotifyCallback(string @event, IntPtr data, uint size, IntPtr ptr);

		#endregion
	}
}

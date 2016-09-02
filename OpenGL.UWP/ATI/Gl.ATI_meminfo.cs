
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
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_VBO_FREE_MEMORY_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_meminfo")]
		public const int VBO_FREE_MEMORY_ATI = 0x87FB;

		/// <summary>
		/// Value of GL_TEXTURE_FREE_MEMORY_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_meminfo")]
		public const int TEXTURE_FREE_MEMORY_ATI = 0x87FC;

		/// <summary>
		/// Value of GL_RENDERBUFFER_FREE_MEMORY_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_meminfo")]
		public const int RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;

	}

}

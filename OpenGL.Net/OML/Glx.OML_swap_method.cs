
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_SWAP_METHOD_OML symbol.
		/// </summary>
		[RequiredByFeature("GLX_OML_swap_method")]
		public const int SWAP_METHOD_OML = 0x8060;

		/// <summary>
		/// Value of GLX_SWAP_EXCHANGE_OML symbol.
		/// </summary>
		[RequiredByFeature("GLX_OML_swap_method")]
		public const int SWAP_EXCHANGE_OML = 0x8061;

		/// <summary>
		/// Value of GLX_SWAP_COPY_OML symbol.
		/// </summary>
		[RequiredByFeature("GLX_OML_swap_method")]
		public const int SWAP_COPY_OML = 0x8062;

		/// <summary>
		/// Value of GLX_SWAP_UNDEFINED_OML symbol.
		/// </summary>
		[RequiredByFeature("GLX_OML_swap_method")]
		public const int SWAP_UNDEFINED_OML = 0x8063;

	}

}

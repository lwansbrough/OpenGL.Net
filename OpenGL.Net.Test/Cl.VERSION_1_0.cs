
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

using NUnit.Framework;

using OpenCL;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenCL 1.0 API.
	/// </summary>
	[TestFixture]
	class Cl_VERSION_1_0 : ClTestBase
	{
		/// <summary>
		/// Test Cl.GetPlatformIDs.
		/// </summary>
		[Test]
		public void TestGetPlatformIDs()
		{
			uint platformsCount;

			Cl.GetPlatformIDs(0, null, out platformsCount);
			Console.WriteLine("Platforms count: {0}", platformsCount);

			if (platformsCount == 0)
				return;

			IntPtr[] platformIds = new IntPtr[platformsCount];

			Cl.GetPlatformIDs((uint)platformIds.Length, platformIds, out platformsCount);
			foreach (IntPtr platformId in platformIds)
				Assert.AreNotEqual(IntPtr.Zero, platformIds);
		}

		/// <summary>
		/// Test Cl.GetPlatformInfo.
		/// </summary>
		[Test]
		public void TestGetPlatformInfo()
		{
			uint platformsCount;

			Cl.GetPlatformIDs(0, null, out platformsCount);

			IntPtr[] platformIds = new IntPtr[platformsCount];

			Cl.GetPlatformIDs((uint)platformIds.Length, platformIds, out platformsCount);

			foreach (IntPtr platformId in platformIds)
				TestGetPlatformInfo(platformId);
		}

		private void TestGetPlatformInfo(IntPtr platformId)
		{
			string platformInfo;

			Cl.GetPlatformInfo(platformId, PlatformInfo.PlatformName, out platformInfo);
			Console.WriteLine("Platform 0x{0:X8} name: {1}", platformId.ToInt32(), platformInfo);

			Cl.GetPlatformInfo(platformId, PlatformInfo.PlatformVendor, out platformInfo);
			Console.WriteLine("Platform 0x{0:X8} vendor: {1}", platformId.ToInt32(), platformInfo);

			Cl.GetPlatformInfo(platformId, PlatformInfo.PlatformProfile, out platformInfo);
			Console.WriteLine("Platform 0x{0:X8} profile: {1}", platformId.ToInt32(), platformInfo);

			Cl.GetPlatformInfo(platformId, PlatformInfo.PlatformVersion, out platformInfo);
			Console.WriteLine("Platform 0x{0:X8} version: {1}", platformId.ToInt32(), platformInfo);

			Cl.GetPlatformInfo(platformId, PlatformInfo.PlatformExtensions, out platformInfo);
			Console.WriteLine("Platform 0x{0:X8} extensions: {1}", platformId.ToInt32(), platformInfo);

			//Cl.GetPlatformInfo(platformId, PlatformInfo.PlatformHostTimerResolution, out platformInfo);
			//Console.WriteLine("Platform 0x{0:X8} timer resolution: {1}", platformId.ToInt32(), platformInfo);
		}
	}
}

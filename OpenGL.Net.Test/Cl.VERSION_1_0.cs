
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

		private IntPtr[] PlatformIds
		{
			get
			{
				uint platformsCount;

				Cl.GetPlatformIDs(0, null, out platformsCount);

				IntPtr[] platformIds = new IntPtr[platformsCount];

				Cl.GetPlatformIDs((uint)platformIds.Length, platformIds, out platformsCount);

				return (platformIds);
			}
		}

		/// <summary>
		/// Test Cl.GetPlatformInfo.
		/// </summary>
		[Test]
		public void TestGetPlatformInfo()
		{
			foreach (IntPtr platformId in PlatformIds)
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

		/// <summary>
		/// Test Cl.GetPlatformIDs.
		/// </summary>
		[Test]
		public void TestGetDeviceIDs()
		{
			foreach (IntPtr platformId in PlatformIds)
				TestGetDeviceIDs(platformId);
		}

		private void TestGetDeviceIDs(IntPtr platformId)
		{
			uint devicesCount;

			Cl.GetDeviceIDs(platformId, DeviceType.DeviceTypeAll, 0, null, out devicesCount);

			if (devicesCount == 0)
				return;

			IntPtr[] deviceIds = new IntPtr[devicesCount];

			Cl.GetPlatformIDs((uint)deviceIds.Length, deviceIds, out devicesCount);
			foreach (IntPtr deviceId in deviceIds)
				Assert.AreNotEqual(IntPtr.Zero, deviceId);
		}

		private IntPtr[] DeviceIds
		{
			get
			{
				List<IntPtr> platformDeviceIds = new List<IntPtr>();

				foreach (IntPtr platformId in PlatformIds) {
					uint devicesCount;

					Cl.GetDeviceIDs(platformId, DeviceType.DeviceTypeAll, 0, null, out devicesCount);

					if (devicesCount == 0)
						continue;

					IntPtr[] deviceIds = new IntPtr[devicesCount];

					Cl.GetPlatformIDs((uint)deviceIds.Length, deviceIds, out devicesCount);

					foreach (IntPtr deviceId in deviceIds)
						platformDeviceIds.Add(deviceId);
				}

				return (platformDeviceIds.ToArray());
			}
		}

		/// <summary>
		/// Test Cl.GetPlatformInfo.
		/// </summary>
		[Test]
		public void TestGetDeviceInfo()
		{
			foreach (IntPtr deviceId in DeviceIds)
				TestGetDeviceInfo(deviceId);
		}

		private void TestGetDeviceInfo(IntPtr deviceId)
		{
			string deviceString;

			// Exception
			//Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceName, out deviceString);
			//Console.WriteLine("Device 0x{0:X8} name: {1}", deviceId.ToInt32(), deviceString);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceVendor, out deviceString);
			Console.WriteLine("Device 0x{0:X8} vendor: {1}", deviceId.ToInt32(), deviceString);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceVersion, out deviceString);
			Console.WriteLine("Device 0x{0:X8} version: {1}", deviceId.ToInt32(), deviceString);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DriverVersion, out deviceString);
			Console.WriteLine("Device 0x{0:X8} driver version: {1}", deviceId.ToInt32(), deviceString);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceProfile, out deviceString);
			Console.WriteLine("Device 0x{0:X8} profile: {1}", deviceId.ToInt32(), deviceString);

			// Exception
			//Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceExtensions, out deviceString);
			//Console.WriteLine("Device 0x{0:X8} extensions: {1}", deviceId.ToInt32(), deviceString);

			bool deviceBool;

			// Exception
			//Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceAvailable, out deviceBool);
			//Console.WriteLine("Device 0x{0:X8} available: {1}", deviceId.ToInt32(), deviceBool);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceCompilerAvailable, out deviceBool);
			Console.WriteLine("Device 0x{0:X8} compiler available: {1}", deviceId.ToInt32(), deviceBool);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceEndianLittle, out deviceBool);
			Console.WriteLine("Device 0x{0:X8} Little Endian: {1}", deviceId.ToInt32(), deviceBool);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceErrorCorrectionSupport, out deviceBool);
			Console.WriteLine("Device 0x{0:X8} ECC support: {1}", deviceId.ToInt32(), deviceBool);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceImageSupport, out deviceBool);
			Console.WriteLine("Device 0x{0:X8} image support: {1}", deviceId.ToInt32(), deviceBool);

			uint deviceUint;

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceAddressBits, out deviceUint);
			Console.WriteLine("Device 0x{0:X8} address bits: {1}", deviceId.ToInt32(), deviceUint);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceGlobalMemCachelineSize, out deviceUint);
			Console.WriteLine("Device 0x{0:X8} GlobalMem Cache Line size: {1}", deviceId.ToInt32(), deviceUint);

			//Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceGlobalMemSize, out deviceUint);
			//Console.WriteLine("Device 0x{0:X8} GlobalMem size: {1}", deviceId.ToInt32(), deviceUint);

			//Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceMaxClockFrequency, out deviceUint);
			//Console.WriteLine("Device 0x{0:X8} max clock freq.: {1}", deviceId.ToInt32(), deviceUint);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceMaxComputeUnits, out deviceUint);
			Console.WriteLine("Device 0x{0:X8} max compute units: {1}", deviceId.ToInt32(), deviceUint);

			Cl.GetDeviceInfo(deviceId, DeviceInfo.DeviceMaxConstantArgs, out deviceUint);
			Console.WriteLine("Device 0x{0:X8} max constant args: {1}", deviceId.ToInt32(), deviceUint);
		}
	}
}

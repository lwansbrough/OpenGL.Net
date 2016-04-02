
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

namespace OpenCL
{
	public partial class Cl
	{
		/// <summary>
		/// Value of CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_1")]
		public const int KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE = 0x2033;

		/// <summary>
		/// Value of CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_1")]
		public const int KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE = 0x2034;

		/// <summary>
		/// Value of CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_1")]
		public const int KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT = 0x11B8;

		/// <summary>
		/// Value of CL_KERNEL_EXEC_INFO_SVM_PTRS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_1")]
		public const int KERNEL_EXEC_INFO_SVM_PTRS = 0x11B6;

		/// <summary>
		/// Value of CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_1")]
		public const int KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM = 0x11B7;

		/// <summary>
		/// Replaces the default command queue on the device.
		/// </summary>
		/// <param name="context">
		/// </param>
		/// <param name="device">
		/// </param>
		/// <param name="command_queue">
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int SetDefaultDeviceCommandQueue(IntPtr context, IntPtr device, IntPtr command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetDefaultDeviceCommandQueue != null, "pclSetDefaultDeviceCommandQueue not implemented");
			retValue = Delegates.pclSetDefaultDeviceCommandQueue(context, device, command_queue);
			LogFunction("clSetDefaultDeviceCommandQueue(0x{0}, 0x{1}, 0x{2}) = {3}", context.ToString("X8"), device.ToString("X8"), command_queue.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns a reasonably synchronized pair of timestamps from the device timer and the host timer as seen by device.
		/// </summary>
		/// <param name="device">
		/// A device returned by Gl.GetDeviceIDs.
		/// </param>
		/// <param name="device_timestamp">
		/// Will be updated with the value of the current timer in nanoseconds. The resolution of the timer is the same as the 
		/// device profiling timer returned by Gl.GetDeviceInfo and the CL_DEVICE_PROFILING_TIMER_RESOLUTION query.
		/// </param>
		/// <param name="host_timestamp">
		/// Will be updated with the value of the current timer in nanoseconds at the closest possible point in time to that at 
		/// which device_timer was returned. The resolution of the timer may be queried via Gl.GetPlatformInfo and the flag 
		/// CL_PLATFORM_HOST_TIMER_RESOLUTION.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetDeviceAndHostTimer(IntPtr device, [Out] ulong[] device_timestamp, [Out] ulong[] host_timestamp)
		{
			int retValue;

			unsafe {
				fixed (ulong* p_device_timestamp = device_timestamp)
				fixed (ulong* p_host_timestamp = host_timestamp)
				{
					Debug.Assert(Delegates.pclGetDeviceAndHostTimer != null, "pclGetDeviceAndHostTimer not implemented");
					retValue = Delegates.pclGetDeviceAndHostTimer(device, p_device_timestamp, p_host_timestamp);
					LogFunction("clGetDeviceAndHostTimer(0x{0}, {1}, {2}) = {3}", device.ToString("X8"), LogValue(device_timestamp), LogValue(host_timestamp), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns a reasonably synchronized pair of timestamps from the device timer and the host timer as seen by device.
		/// </summary>
		/// <param name="device">
		/// A device returned by Gl.GetDeviceIDs.
		/// </param>
		/// <param name="device_timestamp">
		/// Will be updated with the value of the current timer in nanoseconds. The resolution of the timer is the same as the 
		/// device profiling timer returned by Gl.GetDeviceInfo and the CL_DEVICE_PROFILING_TIMER_RESOLUTION query.
		/// </param>
		/// <param name="host_timestamp">
		/// Will be updated with the value of the current timer in nanoseconds at the closest possible point in time to that at 
		/// which device_timer was returned. The resolution of the timer may be queried via Gl.GetPlatformInfo and the flag 
		/// CL_PLATFORM_HOST_TIMER_RESOLUTION.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetDeviceAndHostTimer(Object device, [Out] ulong[] device_timestamp, [Out] ulong[] host_timestamp)
		{
			GCHandle pin_device = GCHandle.Alloc(device, GCHandleType.Pinned);
			try {
				return (GetDeviceAndHostTimer(pin_device.AddrOfPinnedObject(), device_timestamp, host_timestamp));
			} finally {
				pin_device.Free();
			}
		}

		/// <summary>
		/// Return the current value of the host clock as seen by device.
		/// </summary>
		/// <param name="device">
		/// A device returned by Gl.GetDeviceIDs.
		/// </param>
		/// <param name="host_timestamp">
		/// Will be updated with the value of the current timer in nanoseconds. The resolution of the timer may be queried via 
		/// Gl.GetPlatformInfo and the flag CL_PLATFORM_HOST_TIMER_RESOLUTION.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetHostTimer(IntPtr device, [Out] ulong[] host_timestamp)
		{
			int retValue;

			unsafe {
				fixed (ulong* p_host_timestamp = host_timestamp)
				{
					Debug.Assert(Delegates.pclGetHostTimer != null, "pclGetHostTimer not implemented");
					retValue = Delegates.pclGetHostTimer(device, p_host_timestamp);
					LogFunction("clGetHostTimer(0x{0}, {1}) = {2}", device.ToString("X8"), LogValue(host_timestamp), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Return the current value of the host clock as seen by device.
		/// </summary>
		/// <param name="device">
		/// A device returned by Gl.GetDeviceIDs.
		/// </param>
		/// <param name="host_timestamp">
		/// Will be updated with the value of the current timer in nanoseconds. The resolution of the timer may be queried via 
		/// Gl.GetPlatformInfo and the flag CL_PLATFORM_HOST_TIMER_RESOLUTION.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetHostTimer(Object device, [Out] ulong[] host_timestamp)
		{
			GCHandle pin_device = GCHandle.Alloc(device, GCHandleType.Pinned);
			try {
				return (GetHostTimer(pin_device.AddrOfPinnedObject(), host_timestamp));
			} finally {
				pin_device.Free();
			}
		}

		/// <summary>
		/// Creates a program object for a context, and loads the IL into the program object.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="il">
		/// A pointer to a length-byte block of memory containing SPIR-V or an implementation-defined intermediate language.
		/// </param>
		/// <param name="length">
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static IntPtr CreateProgramWithIL(IntPtr context, IntPtr il, uint length, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateProgramWithIL != null, "pclCreateProgramWithIL not implemented");
					retValue = Delegates.pclCreateProgramWithIL(context, il.ToPointer(), length, p_errcode_ret);
					LogFunction("clCreateProgramWithIL(0x{0}, 0x{1}, {2}, {3}) = {4}", context.ToString("X8"), il.ToString("X8"), length, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Make a shallow copy of the kernel object.
		/// </summary>
		/// <param name="source_kernel">
		/// A valid cl_kernel object that will be copied. source_kernel will not be modified in any way by this function.
		/// </param>
		/// <param name="errcode_ret">
		/// Assigned an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static IntPtr CloneKernel(IntPtr source_kernel, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCloneKernel != null, "pclCloneKernel not implemented");
					retValue = Delegates.pclCloneKernel(source_kernel, p_errcode_ret);
					LogFunction("clCloneKernel(0x{0}, {1}) = {2}", source_kernel.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the kernel object.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="device">
		/// Identifies a specific device in the list of devices associated with kernel. The list of devices is the list of devices 
		/// in the OpenCL context that is associated with kernel. If the list of devices associated with kernel is a single device, 
		/// device can be a NULL value.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetKernelSubGroupInfo is described in the table below.
		/// </param>
		/// <param name="input_value_size">
		/// Specifies the size in bytes of memory pointed to by input_value. This size must be == size of input type as described in 
		/// table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, KernelSubGroupInfo param_name, uint input_value_size, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelSubGroupInfo != null, "pclGetKernelSubGroupInfo not implemented");
					retValue = Delegates.pclGetKernelSubGroupInfo(kernel, device, (KernelSubGroupInfo)param_name, input_value_size, param_value_size, param_value.ToPointer(), p_param_value_size_ret);
					LogFunction("clGetKernelSubGroupInfo(0x{0}, 0x{1}, {2}, {3}, {4}, 0x{5}, {6}) = {7}", kernel.ToString("X8"), device.ToString("X8"), param_name, input_value_size, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the kernel object.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="device">
		/// Identifies a specific device in the list of devices associated with kernel. The list of devices is the list of devices 
		/// in the OpenCL context that is associated with kernel. If the list of devices associated with kernel is a single device, 
		/// device can be a NULL value.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetKernelSubGroupInfo is described in the table below.
		/// </param>
		/// <param name="input_value_size">
		/// Specifies the size in bytes of memory pointed to by input_value. This size must be == size of input type as described in 
		/// table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetKernelSubGroupInfo(Object kernel, Object device, KernelSubGroupInfo param_name, uint input_value_size, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_kernel = GCHandle.Alloc(kernel, GCHandleType.Pinned);
			GCHandle pin_device = GCHandle.Alloc(device, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetKernelSubGroupInfo(pin_kernel.AddrOfPinnedObject(), pin_device.AddrOfPinnedObject(), param_name, input_value_size, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_kernel.Free();
				pin_device.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Enqueues a command to indicate which device a set of ranges of SVM allocations should be associated with.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command queue. The specified set of allocation ranges will be migrated to the OpenCL device associated with 
		/// command_queue.
		/// </param>
		/// <param name="num_svm_pointers">
		/// The number of pointers in the specified svm_pointers array, and the number of sizes in the sizes array, if sizes is not 
		/// NULL.
		/// </param>
		/// <param name="svm_pointers">
		/// A pointer to an array of pointers. Each pointer in this array must be within an allocation produced by a call to 
		/// Gl.SVMAlloc.
		/// </param>
		/// <param name="sizes">
		/// An array of sizes. The pair svm_pointers[i] and sizes[i] together define the starting address and number of bytes in a 
		/// range to be migrated. sizes may be NULL indicating that every allocation containing any svm_pointer[i] is to be 
		/// migrated. Also, if sizes[i] is zero, then the entire allocation containing svm_pointer[i] is migrated.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify migration options. Table 5.12 describes the possible values for flags.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_1")]
		public static int EnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, IntPtr[] svm_pointers, uint[] sizes, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_svm_pointers = svm_pointers)
				fixed (uint* p_sizes = sizes)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMigrateMem != null, "pclEnqueueSVMMigrateMem not implemented");
					retValue = Delegates.pclEnqueueSVMMigrateMem(command_queue, num_svm_pointers, p_svm_pointers, p_sizes, (MemMigrationFlags)flags, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMigrateMem(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", command_queue.ToString("X8"), num_svm_pointers, LogValue(svm_pointers), LogValue(sizes), flags, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

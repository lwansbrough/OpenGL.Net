
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

		[RequiredByFeature("CL_VERSION_2_1")]
		public static int SetDefaultDeviceCommandQueue(Int32 context, Int32 device, Int32 command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetDefaultDeviceCommandQueue != null, "pclSetDefaultDeviceCommandQueue not implemented");
			retValue = Delegates.pclSetDefaultDeviceCommandQueue(context, device, command_queue);
			LogFunction("clSetDefaultDeviceCommandQueue({0}, {1}, {2}) = {3}", context, device, command_queue, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetDevice(Int32 device, [Out] ulong[] device_timestamp, [Out] ulong[] host_timestamp)
		{
			int retValue;

			unsafe {
				fixed (ulong* p_device_timestamp = device_timestamp)
				fixed (ulong* p_host_timestamp = host_timestamp)
				{
					Debug.Assert(Delegates.pclGetDeviceAndHostTimer != null, "pclGetDeviceAndHostTimer not implemented");
					retValue = Delegates.pclGetDeviceAndHostTimer(device, p_device_timestamp, p_host_timestamp);
					LogFunction("clGetDeviceAndHostTimer({0}, {1}, {2}) = {3}", device, LogValue(device_timestamp), LogValue(host_timestamp), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static int Get(Int32 device, [Out] ulong[] host_timestamp)
		{
			int retValue;

			unsafe {
				fixed (ulong* p_host_timestamp = host_timestamp)
				{
					Debug.Assert(Delegates.pclGetHostTimer != null, "pclGetHostTimer not implemented");
					retValue = Delegates.pclGetHostTimer(device, p_host_timestamp);
					LogFunction("clGetHostTimer({0}, {1}) = {2}", device, LogValue(host_timestamp), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static IntPtr CreateProgramWith(Int32 context, IntPtr il, uint length, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateProgramWithIL != null, "pclCreateProgramWithIL not implemented");
					retValue = Delegates.pclCreateProgramWithIL(context, il.ToPointer(), length, p_errcode_ret);
					LogFunction("clCreateProgramWithIL({0}, 0x{1}, {2}, {3}) = {4}", context, il.ToString("X8"), length, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static IntPtr CloneKernel(Int32 source_kernel, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCloneKernel != null, "pclCloneKernel not implemented");
					retValue = Delegates.pclCloneKernel(source_kernel, p_errcode_ret);
					LogFunction("clCloneKernel({0}, {1}) = {2}", source_kernel, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetKernelSubGroupInfo(Int32 kernel, Int32 device, uint param_name, uint input_value_size, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelSubGroupInfo != null, "pclGetKernelSubGroupInfo not implemented");
					retValue = Delegates.pclGetKernelSubGroupInfo(kernel, device, (uint)param_name, input_value_size, param_value_size, param_value.ToPointer(), p_param_value_size_ret);
					LogFunction("clGetKernelSubGroupInfo({0}, {1}, {2}, {3}, {4}, 0x{5}, {6}) = {7}", kernel, device, param_name, input_value_size, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static int GetKernelSubGroupInfo(Int32 kernel, Int32 device, uint param_name, uint input_value_size, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_param_value.Free();
			}
		}

		[RequiredByFeature("CL_VERSION_2_1")]
		public static int EnqueueSVMMigrateMem(Int32 command_queue, uint num_svm_pointers, IntPtr[] svm_pointers, uint[] sizes, ulong flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_svm_pointers = svm_pointers)
				fixed (uint* p_sizes = sizes)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMigrateMem != null, "pclEnqueueSVMMigrateMem not implemented");
					retValue = Delegates.pclEnqueueSVMMigrateMem(command_queue, num_svm_pointers, p_svm_pointers, p_sizes, flags, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMigrateMem({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", command_queue, num_svm_pointers, LogValue(svm_pointers), LogValue(sizes), flags, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}


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
		[RequiredByFeature("CL_VERSION_2_0")]
		public static IntPtr CreateCommandQueueWith(Int32 context, Int32 device, ulong[] properties, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (ulong* p_properties = properties)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateCommandQueueWithProperties != null, "pclCreateCommandQueueWithProperties not implemented");
					retValue = Delegates.pclCreateCommandQueueWithProperties(context, device, p_properties, p_errcode_ret);
					LogFunction("clCreateCommandQueueWithProperties({0}, {1}, {2}, {3}) = {4}", context, device, LogValue(properties), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static IntPtr CreatePipe(Int32 context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr[] properties, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_properties = properties)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreatePipe != null, "pclCreatePipe not implemented");
					retValue = Delegates.pclCreatePipe(context, flags, pipe_packet_size, pipe_max_packets, p_properties, p_errcode_ret);
					LogFunction("clCreatePipe({0}, {1}, {2}, {3}, {4}, {5}) = {6}", context, flags, pipe_packet_size, pipe_max_packets, LogValue(properties), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int GetPipeInfo(Int32 pipe, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetPipeInfo != null, "pclGetPipeInfo not implemented");
					retValue = Delegates.pclGetPipeInfo(pipe, param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetPipeInfo({0}, {1}, {2}, {3}, {4}) = {5}", pipe, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static void SVMFree(Int32 context, Int32 svm_pointer)
		{
			Debug.Assert(Delegates.pclSVMFree != null, "pclSVMFree not implemented");
			Delegates.pclSVMFree(context, svm_pointer);
			LogFunction("clSVMFree({0}, {1})", context, svm_pointer);
			DebugCheckErrors(null);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static IntPtr CreateSamplerWith(Int32 context, ulong[] normalized_coords, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (ulong* p_normalized_coords = normalized_coords)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateSamplerWithProperties != null, "pclCreateSamplerWithProperties not implemented");
					retValue = Delegates.pclCreateSamplerWithProperties(context, p_normalized_coords, p_errcode_ret);
					LogFunction("clCreateSamplerWithProperties({0}, {1}, {2}) = {3}", context, LogValue(normalized_coords), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int SetKernelArgSVM(Int32 kernel, uint arg_index, Int32 arg_value)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetKernelArgSVMPointer != null, "pclSetKernelArgSVMPointer not implemented");
			retValue = Delegates.pclSetKernelArgSVMPointer(kernel, arg_index, arg_value);
			LogFunction("clSetKernelArgSVMPointer({0}, {1}, {2}) = {3}", kernel, arg_index, arg_value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int SetKernelExecInfo(Int32 kernel, uint param_name, uint param_value_size, Int32 param_value)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetKernelExecInfo != null, "pclSetKernelExecInfo not implemented");
			retValue = Delegates.pclSetKernelExecInfo(kernel, param_name, param_value_size, param_value);
			LogFunction("clSetKernelExecInfo({0}, {1}, {2}, {3}) = {4}", kernel, param_name, param_value_size, param_value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMFree(Int32 command_queue, uint num_svm_pointers, Int32 queue, Int32 user_data, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMFree != null, "pclEnqueueSVMFree not implemented");
					retValue = Delegates.pclEnqueueSVMFree(command_queue, num_svm_pointers, queue, user_data, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMFree({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", command_queue, num_svm_pointers, queue, user_data, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMMem(Int32 command_queue, bool blocking_copy, Int32 dst_ptr, Int32 src_ptr, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMemcpy != null, "pclEnqueueSVMMemcpy not implemented");
					retValue = Delegates.pclEnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMemcpy({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMMem(Int32 command_queue, Int32 svm_ptr, Int32 pattern, uint pattern_size, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMemFill != null, "pclEnqueueSVMMemFill not implemented");
					retValue = Delegates.pclEnqueueSVMMemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMemFill({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVM(Int32 command_queue, bool blocking_map, ulong flags, Int32 svm_ptr, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMap != null, "pclEnqueueSVMMap not implemented");
					retValue = Delegates.pclEnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMap({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMUnmap(Int32 command_queue, Int32 svm_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMUnmap != null, "pclEnqueueSVMUnmap not implemented");
					retValue = Delegates.pclEnqueueSVMUnmap(command_queue, svm_ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMUnmap({0}, {1}, {2}, {3}, {4}) = {5}", command_queue, svm_ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

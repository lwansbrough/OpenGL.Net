
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
		public static IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, ulong[] properties, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (ulong* p_properties = properties)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateCommandQueueWithProperties != null, "pclCreateCommandQueueWithProperties not implemented");
					retValue = Delegates.pclCreateCommandQueueWithProperties(context, device, p_properties, p_errcode_ret);
					LogFunction("clCreateCommandQueueWithProperties(0x{0}, 0x{1}, {2}, {3}) = {4}", context.ToString("X8"), device.ToString("X8"), LogValue(properties), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static IntPtr CreatePipe(IntPtr context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr[] properties, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_properties = properties)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreatePipe != null, "pclCreatePipe not implemented");
					retValue = Delegates.pclCreatePipe(context, flags, pipe_packet_size, pipe_max_packets, p_properties, p_errcode_ret);
					LogFunction("clCreatePipe(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", context.ToString("X8"), flags, pipe_packet_size, pipe_max_packets, LogValue(properties), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int GetPipeInfo(IntPtr pipe, uint param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetPipeInfo != null, "pclGetPipeInfo not implemented");
					retValue = Delegates.pclGetPipeInfo(pipe, param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetPipeInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", pipe.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int GetPipeInfo(Object pipe, uint param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_pipe = GCHandle.Alloc(pipe, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetPipeInfo(pin_pipe.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_pipe.Free();
				pin_param_value.Free();
			}
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static void SVMFree(IntPtr context, IntPtr svm_pointer)
		{
			Debug.Assert(Delegates.pclSVMFree != null, "pclSVMFree not implemented");
			Delegates.pclSVMFree(context, svm_pointer);
			LogFunction("clSVMFree(0x{0}, 0x{1})", context.ToString("X8"), svm_pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static IntPtr CreateSamplerWithProperties(IntPtr context, ulong[] normalized_coords, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (ulong* p_normalized_coords = normalized_coords)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateSamplerWithProperties != null, "pclCreateSamplerWithProperties not implemented");
					retValue = Delegates.pclCreateSamplerWithProperties(context, p_normalized_coords, p_errcode_ret);
					LogFunction("clCreateSamplerWithProperties(0x{0}, {1}, {2}) = {3}", context.ToString("X8"), LogValue(normalized_coords), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int SetKernelArgSVMPointer(IntPtr kernel, uint arg_index, IntPtr arg_value)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetKernelArgSVMPointer != null, "pclSetKernelArgSVMPointer not implemented");
			retValue = Delegates.pclSetKernelArgSVMPointer(kernel, arg_index, arg_value);
			LogFunction("clSetKernelArgSVMPointer(0x{0}, {1}, 0x{2}) = {3}", kernel.ToString("X8"), arg_index, arg_value.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int SetKernelExecInfo(IntPtr kernel, uint param_name, uint param_value_size, IntPtr param_value)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetKernelExecInfo != null, "pclSetKernelExecInfo not implemented");
			retValue = Delegates.pclSetKernelExecInfo(kernel, param_name, param_value_size, param_value);
			LogFunction("clSetKernelExecInfo(0x{0}, {1}, {2}, 0x{3}) = {4}", kernel.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, IntPtr queue, IntPtr user_data, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMFree != null, "pclEnqueueSVMFree not implemented");
					retValue = Delegates.pclEnqueueSVMFree(command_queue, num_svm_pointers, queue, user_data, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMFree(0x{0}, {1}, 0x{2}, 0x{3}, {4}, {5}, {6}) = {7}", command_queue.ToString("X8"), num_svm_pointers, queue.ToString("X8"), user_data.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMMemcpy(IntPtr command_queue, bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMemcpy != null, "pclEnqueueSVMMemcpy not implemented");
					retValue = Delegates.pclEnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMemcpy(0x{0}, {1}, 0x{2}, 0x{3}, {4}, {5}, {6}, {7}) = {8}", command_queue.ToString("X8"), blocking_copy, dst_ptr.ToString("X8"), src_ptr.ToString("X8"), size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMMemFill(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, uint pattern_size, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMemFill != null, "pclEnqueueSVMMemFill not implemented");
					retValue = Delegates.pclEnqueueSVMMemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMemFill(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}, {6}, {7}) = {8}", command_queue.ToString("X8"), svm_ptr.ToString("X8"), pattern.ToString("X8"), pattern_size, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMMap(IntPtr command_queue, bool blocking_map, ulong flags, IntPtr svm_ptr, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMap != null, "pclEnqueueSVMMap not implemented");
					retValue = Delegates.pclEnqueueSVMMap(command_queue, blocking_map, (ulong)flags, svm_ptr, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMap(0x{0}, {1}, {2}, 0x{3}, {4}, {5}, {6}, {7}) = {8}", command_queue.ToString("X8"), blocking_map, flags, svm_ptr.ToString("X8"), size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMUnmap(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMUnmap != null, "pclEnqueueSVMUnmap not implemented");
					retValue = Delegates.pclEnqueueSVMUnmap(command_queue, svm_ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMUnmap(0x{0}, 0x{1}, {2}, {3}, {4}) = {5}", command_queue.ToString("X8"), svm_ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

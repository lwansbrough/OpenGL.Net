
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
		/// <para>
		/// Cl.EnqueueSVMMap: this flag specifies that the region being mapped in the memory object is being mapped for reading. The 
		/// pointer returned by clEnqueueMap{Buffer|Image} is guaranteed to contain the latest bits in the region being mapped when 
		/// the clEnqueueMap{Buffer|Image} command has completed.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_0")]
		[Log(BitmaskName = "cl")]
		public const int MAP_READ = (1 << 0);

		/// <summary>
		/// <para>
		/// Cl.EnqueueSVMMap: this flag specifies that the region being mapped in the memory object is being mapped for writing. The 
		/// pointer returned by clEnqueueMap{Buffer|Image} is guaranteed to contain the latest bits in the region being mapped when 
		/// the clEnqueueMap{Buffer|Image} command has completed.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_0")]
		[Log(BitmaskName = "cl")]
		public const int MAP_WRITE = (1 << 1);

		/// <summary>
		/// <para>
		/// Cl.EnqueueSVMMap: this flag specifies that the region being mapped in the memory object is being mapped for writing. The 
		/// contents of the region being mapped are to be discarded. This is typically the case when the region being mapped is 
		/// overwritten by the host. This flag allows the implementation to no longer guarantee that the pointer returned by 
		/// clEnqueueMap{Buffer|Image} contains the latest bits in the region being mapped which can be a significant performance 
		/// enhancement. Cl.MAP_READ or Cl.MAP_WRITE and Cl._MAP_WRITE_INVALIDATE_REGION are mutually exclusive.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_2_0")]
		[Log(BitmaskName = "cl")]
		public const int MAP_WRITE_INVALIDATE_REGION = (1 << 2);

		/// <summary>
		/// Create a host or device command-queue on a specific device.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="device">
		/// Must be a device or sub-device associated with context. It can either be in the list of devices and sub-devices 
		/// specified when context is created using Gl.CreateContext or be a root device with the same device type as specified when 
		/// the context is created using Gl.CreateContextFromType.
		/// </param>
		/// <param name="properties">
		/// Specifies a list of properties for the command-queue and their corresponding values. Each property name is immediately 
		/// followed by the corresponding desired value. The list is terminated with 0. The list of supported properties is 
		/// described in the table below. If a supported property and its value is not specified in properties, its default value 
		/// will be used. properties can be NULL in which case the default values for supported command-queue properties will be 
		/// used.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
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

		/// <summary>
		/// Creates a pipe object.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context used to create the pipe object.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify allocation and usage information such as the memory arena that should be used to 
		/// allocate the pipe object and how it will be used. The table below describes the possible values for flags. Only 
		/// CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY, CL_MEM_READ_WRITE, and CL_MEM_HOST_NO_ACCESS can be specified when creating a pipe 
		/// object. If value specified for flags is 0, the default is used which is CL_MEM_READ_WRITE | CL_MEM_HOST_NO_ACCESS.
		/// </param>
		/// <param name="pipe_packet_size">
		/// Size in bytes of a pipe packet.
		/// </param>
		/// <param name="pipe_max_packets">
		/// Specifies the pipe capacity by specifying the maximum number of packets the pipe can hold.
		/// </param>
		/// <param name="properties">
		/// A list of properties for the pipe and their corresponding values. Each property name is immediately followed by the 
		/// corresponding desired value. The list is terminated with 0. In OpenCL 2.0, properties must be NULL.
		/// </param>
		/// <param name="errcode_ret">
		/// Will return an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
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

		/// <summary>
		/// Get information specific to a pipe object created with clCreatePipe.
		/// </summary>
		/// <param name="pipe">
		/// Specifies the pipe object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetPipeInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
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

		/// <summary>
		/// Get information specific to a pipe object created with clCreatePipe.
		/// </summary>
		/// <param name="pipe">
		/// Specifies the pipe object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetPipeInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
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

		/// <summary>
		/// Frees a shared virtual memory buffer allocated using clSVMAlloc.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context used to create the SVM buffer.
		/// </param>
		/// <param name="svm_pointer">
		/// Must be the value returned by a call to Gl.SVMAlloc. If a NULL pointer is passed in svm_pointer, no action occurs.
		/// </param>
		[RequiredByFeature("CL_VERSION_2_0")]
		public static void SVMFree(IntPtr context, IntPtr svm_pointer)
		{
			Debug.Assert(Delegates.pclSVMFree != null, "pclSVMFree not implemented");
			Delegates.pclSVMFree(context, svm_pointer);
			LogFunction("clSVMFree(0x{0}, 0x{1})", context.ToString("X8"), svm_pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Creates a sampler object.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="normalized_coords">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
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

		/// <summary>
		/// Set a SVM pointer as the argument value for a specific argument of a kernel.
		/// </summary>
		/// <param name="kernel">
		/// A valid kernel object.
		/// </param>
		/// <param name="arg_index">
		/// The argument index. Arguments to the kernel are referred by indices that go from 0 for the leftmost argument to n - 1, 
		/// where n is the total number of arguments declared by a kernel.
		/// </param>
		/// <param name="arg_value">
		/// The SVM pointer that should be used as the argument value for argument specified by arg_index. The SVM pointer specified 
		/// is the value used by all API calls that enqueue kernel (Gl.EnqueueNDRangeKernel) until the argument value is changed by 
		/// a call to clSetKernelArgSVMPointer for kernel. The SVM pointer can only be used for arguments that are declared to be a 
		/// pointer to global or constant memory. The SVM pointer value must be aligned according to the argument type. For example, 
		/// if the argument is declared to be global float4 *p, the SVM pointer value passed for p must be at a minimum aligned to a 
		/// float4. The SVM pointer value specified as the argument value can be the pointer returned by Gl.SVMAlloc or can be a 
		/// pointer + offset into the SVM region.
		/// </param>
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

		/// <summary>
		/// Pass additional information other than argument values to a kernel.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to be passed to kernel. The list of supported param_name types and the corresponding values 
		/// passed in param_value is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of the memory pointed to by param_value.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate values determined by param_name are specified.
		/// </param>
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

		/// <summary>
		/// Enqueues a command to free the shared virtual memory allocated using clSVMAlloc or a shared system memory pointer.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command-queue.
		/// </param>
		/// <param name="num_svm_pointers">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="queue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="user_data">
		/// Will be passed as the user_data argument when pfn_free_func is called. user_data can be NULL.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// Specify events that need to complete before clEnqueueSVMFree can be executed. If event_wait_list is NULL, then 
		/// clEnqueueSVMFree does not wait on any event to complete. If event_wait_list is NULL, num_events_in_wait_list must be 0. 
		/// If event_wait_list is not NULL, the list of events pointed to by event_wait_list must be valid and 
		/// num_events_in_wait_list must be greater than 0. The events specified in event_wait_list act as synchronization points. 
		/// The context associated with events in event_wait_list and command_queue must be the same. The memory associated with 
		/// event_wait_list can be reused or freed after the function returns.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
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

		/// <summary>
		/// Enqueues a command to do a memcpy operation.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the read / write command will be queued. queued. If either dst_ptr or src_ptr 
		/// is allocated using clSVMAlloc then the OpenCL context allocated against must match that of command_queue.
		/// </param>
		/// <param name="blocking_copy">
		/// Indicates if the copy operation is blocking or non-blocking.
		/// </param>
		/// <param name="dst_ptr">
		/// The pointer to a host or SVM memory allocation where data is copied to.
		/// </param>
		/// <param name="src_ptr">
		/// The pointer to a memory region where data is copied from.
		/// </param>
		/// <param name="size">
		/// The size in bytes of data being copied.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// Specify events that need to complete before clEnqueueSVMMemcpy can be executed. If event_wait_list is NULL, then 
		/// clEnqueueSVMMemcpy does not wait on any event to complete. If event_wait_list is NULL, num_events_in_wait_list must be 
		/// 0. If event_wait_list is not NULL, the list of events pointed to by event_wait_list must be valid and 
		/// num_events_in_wait_list must be greater than 0. The events specified in event_wait_list act as synchronization points. 
		/// The context associated with events in event_wait_list and command_queue must be the same. The memory associated with 
		/// event_wait_list can be reused or freed after the function returns.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
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

		/// <summary>
		/// Enqueues a command to fill a region in memory with a pattern of a given pattern size.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the fill command will be queued. The OpenCL context associated with 
		/// command_queue and SVM pointer referred to by svm_ptr must be the same.
		/// </param>
		/// <param name="svm_ptr">
		/// A pointer to a memory region that will be filled with pattern. It must be aligned to pattern_size bytes. If svm_ptr is 
		/// allocated using Gl.SVMAlloc then it must be allocated from the same context from which command_queue was created. 
		/// Otherwise the behavior is undefined.
		/// </param>
		/// <param name="pattern">
		/// A pointer to the data pattern of size pattern_size in bytes. pattern will be used to fill a region in buffer starting at 
		/// svm_ptr and is size bytes in size. The data pattern must be a scalar or vector integer or floating-point data type. For 
		/// example, if region pointed to by svm_ptr is to be filled with a pattern of float4 values, then pattern will be a pointer 
		/// to a cl_float4 value and pattern_size will be sizeof(cl_float4). The maximum value of pattern_size is the size of the 
		/// largest integer or floating-point vector data type supported by the OpenCL device. The memory associated with pattern 
		/// can be reused or freed after the function returns.
		/// </param>
		/// <param name="pattern_size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="size">
		/// The size in bytes of region being filled starting with svm_ptr and must be a multiple of pattern_size.
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

		/// <summary>
		/// Enqueues a command that will allow the host to update a region of a SVM buffer
		/// </summary>
		/// <param name="command_queue">
		/// Must be a valid host command-queue.
		/// </param>
		/// <param name="blocking_map">
		/// Indicates if the map operation is blocking or non-blocking.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:MapFlags"/>.
		/// </param>
		/// <param name="svm_ptr">
		/// A pointer to a memory region and size in bytes that will be updated by the host. If svm_ptr is allocated using 
		/// Gl.SVMAlloc then it must be allocated from the same context from which command_queue was created. Otherwise the behavior 
		/// is undefined.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
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
		[RequiredByFeature("CL_VERSION_2_0")]
		public static int EnqueueSVMMap(IntPtr command_queue, bool blocking_map, MapFlags flags, IntPtr svm_ptr, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueSVMMap != null, "pclEnqueueSVMMap not implemented");
					retValue = Delegates.pclEnqueueSVMMap(command_queue, blocking_map, (MapFlags)flags, svm_ptr, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueSVMMap(0x{0}, {1}, {2}, 0x{3}, {4}, {5}, {6}, {7}) = {8}", command_queue.ToString("X8"), blocking_map, flags, svm_ptr.ToString("X8"), size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to indicate that the host has completed updating the region given by svm_ptr and which was specified in a previous call to clEnqueueSVMMap.
		/// </summary>
		/// <param name="command_queue">
		/// Must be a valid host command-queue.
		/// </param>
		/// <param name="svm_ptr">
		/// A pointer that was specified in a previous call to Gl.EnqueueSVMMap. If svm_ptr is allocated using Gl.SVMAlloc then it 
		/// must be allocated from the same context from which command_queue was created. Otherwise the behavior is undefined.
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

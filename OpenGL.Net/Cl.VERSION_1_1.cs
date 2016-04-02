
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
		/// Value of CL_BUFFER_CREATE_TYPE_REGION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_1")]
		public const int BUFFER_CREATE_TYPE_REGION = 0x1220;

		/// <summary>
		/// Creates a new buffer object (referred to as a sub-buffer object) from an existing buffer object.
		/// </summary>
		/// <param name="buffer">
		/// A valid buffer object and cannot be a sub-buffer object.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify allocation and usage information about the sub-buffer memory object being created 
		/// and is described in the table below. If the CL_MEM_READ_WRITE, CL_MEM_READ_ONLY or CL_MEM_WRITE_ONLY values are not 
		/// specified in flags, they are inherited from the corresponding memory access qualifers associated with buffer. The 
		/// CL_MEM_USE_HOST_PTR, CL_MEM_ALLOC_HOST_PTR and CL_MEM_COPY_HOST_PTR values cannot be specified in flags but are 
		/// inherited from the corresponding memory access qualifiers associated with buffer. If CL_MEM_COPY_HOST_PTR is specified 
		/// in the memory access qualifier values associated with buffer it does not imply any additional copies when the sub-buffer 
		/// is created from buffer. If the CL_MEM_HOST_WRITE_ONLY, CL_MEM_HOST_READ_ONLY or CL_MEM_HOST_NO_ACCESS values are not 
		/// specified in flags, they are inherited from the corresponding memory access qualifiers associated with buffer.
		/// </param>
		/// <param name="buffer_create_type">
		/// Describes the type of buffer object to be created. The list of supported values for buffer_create_type and corresponding 
		/// descriptor that buffer_create_info points to is described below.
		/// </param>
		/// <param name="buffer_create_info">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="errcode_ret">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static IntPtr CreateSubBuffer(IntPtr buffer, ulong flags, BufferCreateType buffer_create_type, IntPtr buffer_create_info, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateSubBuffer != null, "pclCreateSubBuffer not implemented");
					retValue = Delegates.pclCreateSubBuffer(buffer, flags, (BufferCreateType)buffer_create_type, buffer_create_info, p_errcode_ret);
					LogFunction("clCreateSubBuffer(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", buffer.ToString("X8"), flags, buffer_create_type, buffer_create_info.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Registers a user callback function with a memory object.
		/// </summary>
		/// <param name="memobj1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="memobj2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static int SetMemObjectDestructorCallback(IntPtr memobj1, IntPtr memobj2)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetMemObjectDestructorCallback != null, "pclSetMemObjectDestructorCallback not implemented");
			retValue = Delegates.pclSetMemObjectDestructorCallback(memobj1, memobj2);
			LogFunction("clSetMemObjectDestructorCallback(0x{0}, 0x{1}) = {2}", memobj1.ToString("X8"), memobj2.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Sets the execution status of a user event object.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="execution_status">
		/// Specifies the new execution status to be set and can be CL_COMPLETE or a negative integer value to indicate an error. A 
		/// negative integer value causes all enqueued commands that wait on this user event to be terminated. clSetUserEventStatus 
		/// can only be called once to change the execution status of event.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static int SetUserEventStatus(IntPtr @event, int execution_status)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetUserEventStatus != null, "pclSetUserEventStatus not implemented");
			retValue = Delegates.pclSetUserEventStatus(@event, execution_status);
			LogFunction("clSetUserEventStatus(0x{0}, {1}) = {2}", @event.ToString("X8"), execution_status, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Registers a user callback function for a specific command execution status.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="command_exec_callback_type">
		/// Specifies the command execution status for which the callback is registered. The command execution callback values for 
		/// which a callback can be registered are CL_SUBMITTED, CL_RUNNING, or CL_COMPLETE. There is no guarantee that the callback 
		/// functions registered for various execution status values for an event will be called in the exact order that the 
		/// execution status of a command changes. Furthermore, it should be noted that receiving a call back for an event with a 
		/// status other than CL_COMPLETE, in no way implies that the memory model or execution model as defined by the OpenCL 
		/// specification has changed. For example, it is not valid to assume that a corresponding memory transfer has completed 
		/// unless the event is in a state CL_COMPLETE.
		/// </param>
		/// <param name="pfn_notify">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="user_data">
		/// Will be passed as the user_data argument when pfn_notify is called. user_data can be NULL.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static int SetEventCallback(IntPtr @event, int command_exec_callback_type, IntPtr pfn_notify, IntPtr user_data)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetEventCallback != null, "pclSetEventCallback not implemented");
			retValue = Delegates.pclSetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data);
			LogFunction("clSetEventCallback(0x{0}, {1}, 0x{2}, 0x{3}) = {4}", @event.ToString("X8"), command_exec_callback_type, pfn_notify.ToString("X8"), user_data.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueue command to read from a 2D or 3D rectangular region from a buffer object to host memory.
		/// </summary>
		/// <param name="command_queue">
		/// Is is a valid host command-queue in which the read command will be queued. command_queue and buffer must be created with 
		/// the same OpenCL context.
		/// </param>
		/// <param name="buffer">
		/// Refers to a valid buffer object.
		/// </param>
		/// <param name="blocking_read">
		/// Indicates if the read operations are blocking or non-blocking.
		/// </param>
		/// <param name="buffer_offset">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="host_offset">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="region">
		/// The (width in bytes, height in rows, depth in slices) of the 2D or 3D rectangle being read or written. For a 2D 
		/// rectangle copy, the depth value given by region[2] should be 1. The values in region cannot be 0.
		/// </param>
		/// <param name="buffer_row_pitch">
		/// The length of each row in bytes to be used for the memory region associated with buffer. If buffer_row_pitch is 0, 
		/// buffer_row_pitch is computed as region[0].
		/// </param>
		/// <param name="buffer_slice_pitch">
		/// The length of each 2D slice in bytes to be used for the memory region associated with buffer. If buffer_slice_pitch is 
		/// 0, buffer_slice_pitch is computed as region[1] * buffer_row_pitch.
		/// </param>
		/// <param name="host_row_pitch">
		/// The length of each row in bytes to be used for the memory region pointed to by ptr. If host_row_pitch is 0, 
		/// host_row_pitch is computed as region[0].
		/// </param>
		/// <param name="host_slice_pitch">
		/// The length of each 2D slice in bytes to be used for the memory region pointed to by ptr. If host_slice_pitch is 0, 
		/// host_slice_pitch is computed as region[1] * host_row_pitch.
		/// </param>
		/// <param name="ptr">
		/// The pointer to buffer in host memory where data is to be read into.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// event_wait_list and num_events_in_wait_list specify events that need to complete before this particular command can be 
		/// executed. If event_wait_list is NULL, then this particular command does not wait on any event to complete. If 
		/// event_wait_list is NULL, num_events_in_wait_list must be 0. If event_wait_list is not NULL, the list of events pointed 
		/// to by event_wait_list must be valid and num_events_in_wait_list must be greater than 0. The events specified in 
		/// event_wait_list act as synchronization points. The context associated with events in event_wait_list and command_queue 
		/// must be the same. The memory associated with event_wait_list can be reused or freed after the function returns.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static int EnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, bool blocking_read, uint[] buffer_offset, uint[] host_offset, uint[] region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (uint* p_buffer_offset = buffer_offset)
				fixed (uint* p_host_offset = host_offset)
				fixed (uint* p_region = region)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueReadBufferRect != null, "pclEnqueueReadBufferRect not implemented");
					retValue = Delegates.pclEnqueueReadBufferRect(command_queue, buffer, blocking_read, p_buffer_offset, p_host_offset, p_region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueReadBufferRect(0x{0}, 0x{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10}, {11}, {12}, {13}) = {14}", command_queue.ToString("X8"), buffer.ToString("X8"), blocking_read, LogValue(buffer_offset), LogValue(host_offset), LogValue(region), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueue command to write a 2D or 3D rectangular region to a buffer object from host memory.
		/// </summary>
		/// <param name="command_queue">
		/// Is is a valid host command-queue in which the write command will be queued. command_queue and buffer must be created 
		/// with the same OpenCL context.
		/// </param>
		/// <param name="buffer">
		/// Refers to a valid buffer object.
		/// </param>
		/// <param name="blocking_write">
		/// Indicates if the write operations are blocking or non-blocking. If blocking_write is CL_TRUE, the OpenCL implementation 
		/// copies the data referred to by ptr and enqueues the write operation in the command-queue. The memory pointed to by ptr 
		/// can be reused by the application after the clEnqueueWriteBufferRect call returns.
		/// </param>
		/// <param name="buffer_offset">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="host_offset">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="region">
		/// The (width in bytes, height in rows, depth in slices) of the 2D or 3D rectangle being read or written. For a 2D 
		/// rectangle copy, the depth value given by region[2] should be 1. The values in region cannot be 0.
		/// </param>
		/// <param name="buffer_row_pitch">
		/// The length of each row in bytes to be used for the memory region associated with buffer. If buffer_row_pitch is 0, 
		/// buffer_row_pitch is computed as region[0].
		/// </param>
		/// <param name="buffer_slice_pitch">
		/// The length of each 2D slice in bytes to be used for the memory region associated with buffer. If buffer_slice_pitch is 
		/// 0, buffer_slice_pitch is computed as region[1] * buffer_row_pitch.
		/// </param>
		/// <param name="host_row_pitch">
		/// The length of each row in bytes to be used for the memory region pointed to by ptr. If host_row_pitch is 0, 
		/// host_row_pitch is computed as region[0].
		/// </param>
		/// <param name="host_slice_pitch">
		/// The length of each 2D slice in bytes to be used for the memory region pointed to by ptr. If host_slice_pitch is 0, 
		/// host_slice_pitch is computed as region[1] * host_row_pitch.
		/// </param>
		/// <param name="ptr">
		/// The pointer to buffer in host memory where data is to be written from.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// event_wait_list and num_events_in_wait_list specify events that need to complete before this particular command can be 
		/// executed. If event_wait_list is NULL, then this particular command does not wait on any event to complete. If 
		/// event_wait_list is NULL, num_events_in_wait_list must be 0. If event_wait_list is not NULL, the list of events pointed 
		/// to by event_wait_list must be valid and num_events_in_wait_list must be greater than 0. The events specified in 
		/// event_wait_list act as synchronization points. The context associated with events in event_wait_list and command_queue 
		/// must be the same. The memory associated with event_wait_list can be reused or freed after the function returns.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static int EnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, bool blocking_write, uint[] buffer_offset, uint[] host_offset, uint[] region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (uint* p_buffer_offset = buffer_offset)
				fixed (uint* p_host_offset = host_offset)
				fixed (uint* p_region = region)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueWriteBufferRect != null, "pclEnqueueWriteBufferRect not implemented");
					retValue = Delegates.pclEnqueueWriteBufferRect(command_queue, buffer, blocking_write, p_buffer_offset, p_host_offset, p_region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueWriteBufferRect(0x{0}, 0x{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10}, {11}, {12}, {13}) = {14}", command_queue.ToString("X8"), buffer.ToString("X8"), blocking_write, LogValue(buffer_offset), LogValue(host_offset), LogValue(region), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to copy a 2D or 3D rectangular region from a buffer object to another buffer object.
		/// </summary>
		/// <param name="command_queue">
		/// The host command-queue in which the copy command will be queued. The OpenCL context associated with command_queue, 
		/// src_buffer, and dst_buffer must be the same.
		/// </param>
		/// <param name="src_buffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dst_buffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="src_origin">
		/// The (x, y, z) offset in the memory region associated with src_buffer. For a 2D rectangle region, the z value given by 
		/// src_origin[2] should be 0. The offset in bytes is computed as src_origin[2] * src_slice_pitch + src_origin[1] * 
		/// src_row_pitch + src_origin[0].
		/// </param>
		/// <param name="dst_origin">
		/// The (x, y, z) offset in the memory region associated with dst_buffer. For a 2D rectangle region, the z value given by 
		/// dst_origin[2] should be 0. The offset in bytes is computed as dst_origin[2] * dst_slice_pitch + dst_origin[1] * 
		/// dst_row_pitch + dst_origin[0].
		/// </param>
		/// <param name="region">
		/// The (width in bytes, height in rows, depth in slices) in bytes of the 2D or 3D rectangle being copied. For a 2D 
		/// rectangle, the depth value given by region[2] should be 1. The values in region cannot be 0.
		/// </param>
		/// <param name="src_row_pitch">
		/// The length of each row in bytes to be used for the memory region associated with src_buffer. If src_row_pitch is 0, 
		/// src_row_pitch is computed as region[0].
		/// </param>
		/// <param name="src_slice_pitch">
		/// The length of each 2D slice in bytes to be used for the memory region associated with src_buffer. If src_slice_pitch is 
		/// 0, src_slice_pitch is computed as region[1] * src_row_pitch.
		/// </param>
		/// <param name="dst_row_pitch">
		/// The length of each row in bytes to be used for the memory region associated with dst_buffer. If dst_row_pitch is 0, 
		/// dst_row_pitch is computed as region[0].
		/// </param>
		/// <param name="dst_slice_pitch">
		/// The length of each 2D slice in bytes to be used for the memory region associated with dst_buffer. If dst_slice_pitch is 
		/// 0, dst_slice_pitch is computed as region[1] * dst_row_pitch.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// Specify events that need to complete before this particular command can be executed. If event_wait_list is NULL, then 
		/// this particular command does not wait on any event to complete. If event_wait_list is NULL, num_events_in_wait_list must 
		/// be 0. If event_wait_list is not NULL, the list of events pointed to by event_wait_list must be valid and 
		/// num_events_in_wait_list must be greater than 0. The events specified in event_wait_list act as synchronization points. 
		/// The context associated with events in event_wait_list and command_queue must be the same. The memory associated with 
		/// event_wait_list can be reused or freed after the function returns.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_1")]
		public static int EnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, uint[] src_origin, uint[] dst_origin, uint[] region, uint src_row_pitch, uint src_slice_pitch, uint dst_row_pitch, uint dst_slice_pitch, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (uint* p_src_origin = src_origin)
				fixed (uint* p_dst_origin = dst_origin)
				fixed (uint* p_region = region)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyBufferRect != null, "pclEnqueueCopyBufferRect not implemented");
					retValue = Delegates.pclEnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, p_src_origin, p_dst_origin, p_region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyBufferRect(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}) = {13}", command_queue.ToString("X8"), src_buffer.ToString("X8"), dst_buffer.ToString("X8"), LogValue(src_origin), LogValue(dst_origin), LogValue(region), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

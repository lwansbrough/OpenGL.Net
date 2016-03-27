
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

		[RequiredByFeature("CL_VERSION_1_1")]
		public static IntPtr CreateSubBuffer(Int32 buffer, ulong flags, uint buffer_create_type, Int32 buffer_create_info, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateSubBuffer != null, "pclCreateSubBuffer not implemented");
					retValue = Delegates.pclCreateSubBuffer(buffer, flags, (uint)buffer_create_type, buffer_create_info, p_errcode_ret);
					LogFunction("clCreateSubBuffer({0}, {1}, {2}, {3}, {4}) = {5}", buffer, flags, buffer_create_type, buffer_create_info, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_1")]
		public static int SetMemObjectDestructorCallback(Int32 memobj1, Int32 memobj2)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetMemObjectDestructorCallback != null, "pclSetMemObjectDestructorCallback not implemented");
			retValue = Delegates.pclSetMemObjectDestructorCallback(memobj1, memobj2);
			LogFunction("clSetMemObjectDestructorCallback({0}, {1}) = {2}", memobj1, memobj2, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_1")]
		public static int SetUserEventStatus(Int32 @event, int execution_status)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetUserEventStatus != null, "pclSetUserEventStatus not implemented");
			retValue = Delegates.pclSetUserEventStatus(@event, execution_status);
			LogFunction("clSetUserEventStatus({0}, {1}) = {2}", @event, execution_status, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_1")]
		public static int SetEventCallback(Int32 @event, int command_exec_callback_type, Int32 pfn_notify, Int32 user_data)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetEventCallback != null, "pclSetEventCallback not implemented");
			retValue = Delegates.pclSetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data);
			LogFunction("clSetEventCallback({0}, {1}, {2}, {3}) = {4}", @event, command_exec_callback_type, pfn_notify, user_data, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_1")]
		public static int EnqueueReadBufferRect(Int32 command_queue, Int32 buffer, bool blocking_read, uint[] buffer_offset, uint[] host_offset, uint[] region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
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
					LogFunction("clEnqueueReadBufferRect({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}) = {14}", command_queue, buffer, blocking_read, LogValue(buffer_offset), LogValue(host_offset), LogValue(region), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_1")]
		public static int EnqueueWriteBufferRect(Int32 command_queue, Int32 buffer, bool blocking_write, uint[] buffer_offset, uint[] host_offset, uint[] region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
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
					LogFunction("clEnqueueWriteBufferRect({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}) = {14}", command_queue, buffer, blocking_write, LogValue(buffer_offset), LogValue(host_offset), LogValue(region), buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_1")]
		public static int EnqueueCopyBufferRect(Int32 command_queue, Int32 src_buffer, Int32 dst_buffer, uint[] src_origin, uint[] dst_origin, uint[] region, uint src_row_pitch, uint src_slice_pitch, uint dst_row_pitch, uint dst_slice_pitch, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
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
					LogFunction("clEnqueueCopyBufferRect({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}) = {13}", command_queue, src_buffer, dst_buffer, LogValue(src_origin), LogValue(dst_origin), LogValue(region), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

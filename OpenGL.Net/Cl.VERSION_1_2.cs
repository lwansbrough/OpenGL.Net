
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
		/// Value of CL_KERNEL_ARG_ADDRESS_QUALIFIER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		public const int KERNEL_ARG_ADDRESS_QUALIFIER = 0x1196;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ACCESS_QUALIFIER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		public const int KERNEL_ARG_ACCESS_QUALIFIER = 0x1197;

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_NAME symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		public const int KERNEL_ARG_TYPE_NAME = 0x1198;

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_QUALIFIER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		public const int KERNEL_ARG_TYPE_QUALIFIER = 0x1199;

		/// <summary>
		/// Value of CL_KERNEL_ARG_NAME symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		public const int KERNEL_ARG_NAME = 0x119A;

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int CreateSubDevice(IntPtr in_device, IntPtr[] properties, uint num_devices, IntPtr[] out_devices, uint[] num_devices_ret)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_properties = properties)
				fixed (IntPtr* p_out_devices = out_devices)
				fixed (uint* p_num_devices_ret = num_devices_ret)
				{
					Debug.Assert(Delegates.pclCreateSubDevices != null, "pclCreateSubDevices not implemented");
					retValue = Delegates.pclCreateSubDevices(in_device, p_properties, num_devices, p_out_devices, p_num_devices_ret);
					LogFunction("clCreateSubDevices(0x{0}, {1}, {2}, {3}, {4}) = {5}", in_device.ToString("X8"), LogValue(properties), num_devices, LogValue(out_devices), LogValue(num_devices_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int RetainDevice(IntPtr device)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainDevice != null, "pclRetainDevice not implemented");
			retValue = Delegates.pclRetainDevice(device);
			LogFunction("clRetainDevice(0x{0}) = {1}", device.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int ReleaseDevice(IntPtr device)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseDevice != null, "pclReleaseDevice not implemented");
			retValue = Delegates.pclReleaseDevice(device);
			LogFunction("clReleaseDevice(0x{0}) = {1}", device.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static IntPtr CreateImage(IntPtr context, ulong flags, Cl.ImageFormat[] image_format, Cl.ImageDescr[] image_desc, IntPtr host_ptr, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (Cl.ImageFormat* p_image_format = image_format)
				fixed (Cl.ImageDescr* p_image_desc = image_desc)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateImage != null, "pclCreateImage not implemented");
					retValue = Delegates.pclCreateImage(context, flags, p_image_format, p_image_desc, host_ptr, p_errcode_ret);
					LogFunction("clCreateImage(0x{0}, {1}, {2}, {3}, 0x{4}, {5}) = {6}", context.ToString("X8"), flags, LogValue(image_format), LogValue(image_desc), host_ptr.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static IntPtr CreateProgramWithBuiltInKernels(IntPtr context, uint num_devices, IntPtr[] device_list, char [] kernel_names, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_device_list = device_list)
				fixed (char * p_kernel_names = kernel_names)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateProgramWithBuiltInKernels != null, "pclCreateProgramWithBuiltInKernels not implemented");
					retValue = Delegates.pclCreateProgramWithBuiltInKernels(context, num_devices, p_device_list, p_kernel_names, p_errcode_ret);
					LogFunction("clCreateProgramWithBuiltInKernels(0x{0}, {1}, {2}, {3}, {4}) = {5}", context.ToString("X8"), num_devices, LogValue(device_list), LogValue(kernel_names), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int CompileProgram(IntPtr program, uint num_devices, IntPtr[] device_list, char [] options, uint num_input_headers, IntPtr[] input_headers, String[] header_include_names, IntPtr pfn_notify, IntPtr user_data)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_device_list = device_list)
				fixed (char * p_options = options)
				fixed (IntPtr* p_input_headers = input_headers)
				{
					Debug.Assert(Delegates.pclCompileProgram != null, "pclCompileProgram not implemented");
					retValue = Delegates.pclCompileProgram(program, num_devices, p_device_list, p_options, num_input_headers, p_input_headers, header_include_names, pfn_notify, user_data);
					LogFunction("clCompileProgram(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7}, 0x{8}) = {9}", program.ToString("X8"), num_devices, LogValue(device_list), LogValue(options), num_input_headers, LogValue(input_headers), LogValue(header_include_names), pfn_notify.ToString("X8"), user_data.ToString("X8"), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static IntPtr LinkProgram(IntPtr context, uint num_devices, IntPtr[] device_list, char [] options, uint num_input_programs, IntPtr[] input_programs, IntPtr pfn_notify, IntPtr user_data, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_device_list = device_list)
				fixed (char * p_options = options)
				fixed (IntPtr* p_input_programs = input_programs)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclLinkProgram != null, "pclLinkProgram not implemented");
					retValue = Delegates.pclLinkProgram(context, num_devices, p_device_list, p_options, num_input_programs, p_input_programs, pfn_notify, user_data, p_errcode_ret);
					LogFunction("clLinkProgram(0x{0}, {1}, {2}, {3}, {4}, {5}, 0x{6}, 0x{7}, {8}) = {9}", context.ToString("X8"), num_devices, LogValue(device_list), LogValue(options), num_input_programs, LogValue(input_programs), pfn_notify.ToString("X8"), user_data.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int UnloadPlatformCompiler(IntPtr platform)
		{
			int retValue;

			Debug.Assert(Delegates.pclUnloadPlatformCompiler != null, "pclUnloadPlatformCompiler not implemented");
			retValue = Delegates.pclUnloadPlatformCompiler(platform);
			LogFunction("clUnloadPlatformCompiler(0x{0}) = {1}", platform.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int GetKernelArgInfo(IntPtr kernel, uint arg_indx, uint param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelArgInfo != null, "pclGetKernelArgInfo not implemented");
					retValue = Delegates.pclGetKernelArgInfo(kernel, arg_indx, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetKernelArgInfo(0x{0}, {1}, {2}, {3}, 0x{4}, {5}) = {6}", kernel.ToString("X8"), arg_indx, param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int GetKernelArgInfo(Object kernel, uint arg_indx, uint param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_kernel = GCHandle.Alloc(kernel, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetKernelArgInfo(pin_kernel.AddrOfPinnedObject(), arg_indx, param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_kernel.Free();
				pin_param_value.Free();
			}
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int EnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, IntPtr pattern, uint pattern_size, uint offset, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueFillBuffer != null, "pclEnqueueFillBuffer not implemented");
					retValue = Delegates.pclEnqueueFillBuffer(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueFillBuffer(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), buffer.ToString("X8"), pattern.ToString("X8"), pattern_size, offset, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int EnqueueFillImage(IntPtr command_queue, IntPtr image, IntPtr fill_color, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueFillImage != null, "pclEnqueueFillImage not implemented");
					retValue = Delegates.pclEnqueueFillImage(command_queue, image, fill_color, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueFillImage(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}) = {6}", command_queue.ToString("X8"), image.ToString("X8"), fill_color.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr[] mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_mem_objects = mem_objects)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueMigrateMemObjects != null, "pclEnqueueMigrateMemObjects not implemented");
					retValue = Delegates.pclEnqueueMigrateMemObjects(command_queue, num_mem_objects, p_mem_objects, flags, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueMigrateMemObjects(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", command_queue.ToString("X8"), num_mem_objects, LogValue(mem_objects), flags, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int EnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueMarkerWithWaitList != null, "pclEnqueueMarkerWithWaitList not implemented");
					retValue = Delegates.pclEnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueMarkerWithWaitList(0x{0}, {1}, {2}, {3}) = {4}", command_queue.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_2")]
		public static int EnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueBarrierWithWaitList != null, "pclEnqueueBarrierWithWaitList not implemented");
					retValue = Delegates.pclEnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueBarrierWithWaitList(0x{0}, {1}, {2}, {3}) = {4}", command_queue.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}


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

		/// <summary>
		/// Value of CL_MIGRATE_MEM_OBJECT_HOST symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		[RequiredByFeature("CL_VERSION_2_1")]
		[Log(BitmaskName = "cl")]
		public const int MIGRATE_MEM_OBJECT_HOST = (1 << 0);

		/// <summary>
		/// Value of CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_2")]
		[RequiredByFeature("CL_VERSION_2_1")]
		[Log(BitmaskName = "cl")]
		public const int MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED = (1 << 1);

		/// <summary>
		/// Creates an array of sub-devices that each reference a non-intersecting set of compute units within in_device.
		/// </summary>
		/// <param name="in_device">
		/// The device to be partitioned.
		/// </param>
		/// <param name="properties">
		/// Specifies how in_device is to be partition described by a partition name and its corresponding value. Each partition 
		/// name is immediately followed by the corresponding desired value. The list is terminated with 0. The list of supported 
		/// partitioning schemes is described in the table below. Only one of the listed partitioning schemes can be specified in 
		/// properties.
		/// </param>
		/// <param name="num_devices">
		/// Size of memory pointed to by out_devices specified as the number of cl_device_id entries.
		/// </param>
		/// <param name="out_devices">
		/// The buffer where the OpenCL sub-devices will be returned. If out_devices is NULL, this argument is ignored. If 
		/// out_devices is not NULL, num_devices must be greater than or equal to the number of sub-devices that device may be 
		/// partitioned into according to the partitioning scheme specified in properties.
		/// </param>
		/// <param name="num_devices_ret">
		/// Returns the number of sub-devices that device may be partitioned into according to the partitioning scheme specified in 
		/// properties. If num_devices_ret is NULL, it is ignored.
		/// </param>
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

		/// <summary>
		/// Increments the device reference count.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
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

		/// <summary>
		/// Decrements the device reference count.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
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

		/// <summary>
		/// Creates a 1D image, 1D image buffer, 1D image array, 2D image, 2D image array or 3D image object.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context on which the image object is to be created.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify allocation and usage information about the image memory object being created and is 
		/// described in the table below.
		/// </param>
		/// <param name="image_format">
		/// A pointer to a structure that describes format properties of the image to be allocated. See Gl._image_format for a 
		/// detailed description of the image format descriptor.
		/// </param>
		/// <param name="image_desc">
		/// A pointer to a structure that describes type and dimensions of the image to be allocated. See Gl.ageDescriptor for more 
		/// information.
		/// </param>
		/// <param name="host_ptr">
		/// A pointer to the image data that may already be allocated by the application. Refer to table below for a description of 
		/// how large the buffer that host_ptr points to must be.
		/// </param>
		/// <param name="errcode_ret">
		/// Will return an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
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

		/// <summary>
		/// Creates a program object for a context, and loads the information related to the built-in kernels into a program object.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="num_devices">
		/// The number of devices listed in device_list.
		/// </param>
		/// <param name="device_list">
		/// A pointer to a list of devices that are in context. device_list must be a non-NULL value. The built-in kernels are 
		/// loaded for devices specified in this list.
		/// </param>
		/// <param name="kernel_names">
		/// A semi-colon separated list of built-in kernel names.
		/// </param>
		/// <param name="errcode_ret">
		/// A <see cref="T:int[]"/>.
		/// </param>
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

		/// <summary>
		/// Compiles a program’s source for all the devices or a specific device(s) in the OpenCL context associated with program.
		/// </summary>
		/// <param name="program">
		/// The program object that is the compilation target.
		/// </param>
		/// <param name="num_devices">
		/// The number of devices listed in device_list.
		/// </param>
		/// <param name="device_list">
		/// A pointer to a list of devices associated with program. If device_list is a NULL value, the compile is performed for all 
		/// devices associated with program. If device_list is a non-NULL value, the compile is performed for devices specified in 
		/// this list.
		/// </param>
		/// <param name="options">
		/// A pointer to a null-terminated string of characters that describes the compilation options to be used for building the 
		/// program executable. Certain options are ignored when program is created with IL. The list of supported options is as 
		/// described below.
		/// </param>
		/// <param name="num_input_headers">
		/// Specifies the number of programs that describe headers in the array referenced by input_headers.
		/// </param>
		/// <param name="input_headers">
		/// An array of program embedded headers created with Gl.CreateProgramWithSource.
		/// </param>
		/// <param name="header_include_names">
		/// An array that has a one to one correspondence with input_headers. Each entry in header_include_names specifies the 
		/// include name used by source in program that comes from an embedded header. The corresponding entry in input_headers 
		/// identifies the program object which contains the header source to be used. The embedded headers are first searched 
		/// before the headers in the list of directories specified by the –I compile option (as described in section 5.8.4.1). If 
		/// multiple entries in header_include_names refer to the same header name, the first one encountered will be used.
		/// </param>
		/// <param name="pfn_notify">
		/// A function pointer to a notification routine. The notification routine is a callback function that an application can 
		/// register and which will be called when the program executable has been built (successfully or unsuccessfully). If 
		/// pfn_notify is not NULL, clCompileProgram does not need to wait for the compiler to complete and can return immediately 
		/// once the compilation can begin. The compilation can begin if the context, program whose sources are being compiled, list 
		/// of devices, input headers, programs that describe input headers and compiler options specified are all valid and 
		/// appropriate host and device resources needed to perform the compile are available. If pfn_notify is NULL, 
		/// clCompileProgram does not return until the compiler has completed. This callback function may be called asynchronously 
		/// by the OpenCL implementation. It is the application’s responsibility to ensure that the callback function is 
		/// thread-safe.
		/// </param>
		/// <param name="user_data">
		/// Passed as an argument when pfn_notify is called. user_data can be NULL.
		/// </param>
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

		/// <summary>
		/// Links a set of compiled program objects and libraries for all the devices or a specific device(s) in the OpenCL context and creates a library or executable.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="num_devices">
		/// The number of devices listed in device_list.
		/// </param>
		/// <param name="device_list">
		/// A pointer to a list of devices that are in context. If device_list is a NULL value, the link is performed for all 
		/// devices associated with context for which a compiled object is available. If device_list is a non-NULL value, the 
		/// compile is performed for devices specified in this list for which a compiled object is available.
		/// </param>
		/// <param name="options">
		/// A pointer to a null-terminated string of characters that describes the link options to be used for building the program 
		/// executable. See Gl.BuildProgram for a list of supported compiler and linker options.
		/// </param>
		/// <param name="num_input_programs">
		/// Specifies the number of programs in array referenced by input_programs.
		/// </param>
		/// <param name="input_programs">
		/// An array of program objects that are compiled binaries or libraries that are to be linked to create the program 
		/// executable. For each device in device_list or if device_list is NULL the list of devices associated with context, the 
		/// following cases occur:
		/// </param>
		/// <param name="pfn_notify">
		/// A function pointer to a notification routine. The notification routine is a callback function that an application can 
		/// register and which will be called when the program executable has been built (successfully or unsuccessfully).
		/// </param>
		/// <param name="user_data">
		/// Will be passed as an argument when pfn_notify is called. user_data can be NULL.
		/// </param>
		/// <param name="errcode_ret">
		/// A <see cref="T:int[]"/>.
		/// </param>
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

		/// <summary>
		/// Allows the implementation to release the resources allocated by the OpenCL compiler for platform.
		/// </summary>
		/// <param name="platform">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
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

		/// <summary>
		/// Returns information about the arguments of a kernel.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="arg_indx">
		/// The argument index. Arguments to the kernel are referred by indices that go from 0 for the leftmost argument to n - 1, 
		/// where n is the total number of arguments declared by a kernel.
		/// </param>
		/// <param name="param_name">
		/// Specifies the argument information to query. The list of supported param_name types and the information returned in 
		/// param_value by clGetKernelArgInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be &gt; size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_2")]
		public static int GetKernelArgInfo(IntPtr kernel, uint arg_indx, KernelArgInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelArgInfo != null, "pclGetKernelArgInfo not implemented");
					retValue = Delegates.pclGetKernelArgInfo(kernel, arg_indx, (KernelArgInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetKernelArgInfo(0x{0}, {1}, {2}, {3}, 0x{4}, {5}) = {6}", kernel.ToString("X8"), arg_indx, param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the arguments of a kernel.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="arg_indx">
		/// The argument index. Arguments to the kernel are referred by indices that go from 0 for the leftmost argument to n - 1, 
		/// where n is the total number of arguments declared by a kernel.
		/// </param>
		/// <param name="param_name">
		/// Specifies the argument information to query. The list of supported param_name types and the information returned in 
		/// param_value by clGetKernelArgInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be &gt; size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_2")]
		public static int GetKernelArgInfo(Object kernel, uint arg_indx, KernelArgInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
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

		/// <summary>
		/// Enqueues a command to fill a buffer object with a pattern of a given pattern size.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the fill command will be queued. The OpenCL context associated with 
		/// command_queue and buffer must be the same.
		/// </param>
		/// <param name="buffer">
		/// A valid buffer object.
		/// </param>
		/// <param name="pattern">
		/// A pointer to the data pattern of size pattern_size in bytes. pattern will be used to fill a region in buffer starting at 
		/// offset and is size bytes in size. The data pattern must be a scalar or vector integer or floating-point data type. For 
		/// example, if buffer is to be filled with a pattern of float4 values, then pattern will be a pointer to a cl_float4 value 
		/// and pattern_size will be sizeof(cl_float4). The maximum value of pattern_size is the size of the largest integer or 
		/// floating-point vector data type supported by the OpenCL device. The memory associated with pattern can be reused or 
		/// freed after the function returns.
		/// </param>
		/// <param name="pattern_size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="offset">
		/// The location in bytes of the region being filled in buffer and must be a multiple of pattern_size.
		/// </param>
		/// <param name="size">
		/// The size in bytes of region being filled in buffer and must be a multiple of pattern_size.
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

		/// <summary>
		/// Enqueues a command to fill an image object with a specified color.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the fill command will be queued. The OpenCL context associated with 
		/// command_queue and image must be the same.
		/// </param>
		/// <param name="image">
		/// A valid image object.
		/// </param>
		/// <param name="fill_color">
		/// The color used to fill the image. The fill color is a single floating point value if the channel order is CL_DEPTH. 
		/// Otherwise, the fill color is a four component RGBA floating-point color value if the image channel data type is not an 
		/// unnormalized signed or unsigned integer type, is a four component signed integer value if the image channel data type is 
		/// an unnormalized signed integer type and is a four component unsigned integer value if the image channel data type is an 
		/// unnormalized unsigned integer type. The fill color will be converted to the appropriate image channel format and order 
		/// associated with image as described in sections 6.12.14 and 8.3.
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

		/// <summary>
		/// Enqueues a command to indicate which device a set of memory objects should be associated with.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command-queue. The specified set of memory objects in mem_objects will be migrated to the OpenCL device 
		/// associated with command_queue or to the host if the CL_MIGRATE_MEM_OBJECT_HOST has been specified.
		/// </param>
		/// <param name="num_mem_objects">
		/// The number of memory objects specified in mem_objects.
		/// </param>
		/// <param name="mem_objects">
		/// A pointer to a list of memory objects.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify migration options. The table below describes the possible values for flags.
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
		[RequiredByFeature("CL_VERSION_1_2")]
		public static int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr[] mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_mem_objects = mem_objects)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueMigrateMemObjects != null, "pclEnqueueMigrateMemObjects not implemented");
					retValue = Delegates.pclEnqueueMigrateMemObjects(command_queue, num_mem_objects, p_mem_objects, (MemMigrationFlags)flags, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueMigrateMemObjects(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", command_queue.ToString("X8"), num_mem_objects, LogValue(mem_objects), flags, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a marker command which waits for either a list of events to complete, or all previously enqueued commands to complete.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command-queue.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// These functions specify events that need to complete before this particular command can be executed.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
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

		/// <summary>
		/// A synchronization point that enqueues a barrier operation.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command queue.
		/// </param>
		/// <param name="num_events_in_wait_list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_wait_list">
		/// Specify events that need to complete before this particular command can be executed.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
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

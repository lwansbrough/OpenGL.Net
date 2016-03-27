
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
using System.Security;
using System.Runtime.InteropServices;

namespace OpenCL
{
	public unsafe partial class Cl
	{
		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetPlatformIDs", ExactSpelling = true)]
			internal extern static unsafe int clGetPlatformIDs(uint num_entries, IntPtr* platforms, uint* num_platforms);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetPlatformInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetPlatformInfo(Int32 platform, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetDeviceIDs", ExactSpelling = true)]
			internal extern static unsafe int clGetDeviceIDs(Int32 platform, ulong device_type, uint num_entries, IntPtr* devices, uint* num_devices);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetDeviceInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetDeviceInfo(Int32 device, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateSubDevices", ExactSpelling = true)]
			internal extern static unsafe int clCreateSubDevices(Int32 in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainDevice", ExactSpelling = true)]
			internal extern static int clRetainDevice(Int32 device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseDevice", ExactSpelling = true)]
			internal extern static int clReleaseDevice(Int32 device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetDefaultDeviceCommandQueue", ExactSpelling = true)]
			internal extern static int clSetDefaultDeviceCommandQueue(Int32 context, Int32 device, Int32 command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetDeviceAndHostTimer", ExactSpelling = true)]
			internal extern static unsafe int clGetDeviceAndHostTimer(Int32 device, ulong* device_timestamp, ulong* host_timestamp);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetHostTimer", ExactSpelling = true)]
			internal extern static unsafe int clGetHostTimer(Int32 device, ulong* host_timestamp);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateContext", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateContext(cl_context_properties * properties, uint num_devices, IntPtr* devices, Int32 pfn_notify, Int32 user_data, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateContextFromType", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateContextFromType(cl_context_properties * properties, ulong device_type, Int32 user_data, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainContext", ExactSpelling = true)]
			internal extern static int clRetainContext(Int32 context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseContext", ExactSpelling = true)]
			internal extern static int clReleaseContext(Int32 context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetContextInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetContextInfo(Int32 context, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateCommandQueueWithProperties", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateCommandQueueWithProperties(Int32 context, Int32 device, ulong* properties, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainCommandQueue", ExactSpelling = true)]
			internal extern static int clRetainCommandQueue(Int32 command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseCommandQueue", ExactSpelling = true)]
			internal extern static int clReleaseCommandQueue(Int32 command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetCommandQueueInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetCommandQueueInfo(Int32 command_queue, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateBuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateBuffer(Int32 context, ulong flags, uint size, Int32 host_ptr, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateSubBuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateSubBuffer(Int32 buffer, ulong flags, uint buffer_create_type, Int32 buffer_create_info, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateImage", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateImage(Int32 context, ulong flags, Cl.ImageFormat* image_format, Cl.ImageDescr* image_desc, Int32 host_ptr, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreatePipe", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreatePipe(Int32 context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainMemObject", ExactSpelling = true)]
			internal extern static int clRetainMemObject(Int32 memobj);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseMemObject", ExactSpelling = true)]
			internal extern static int clReleaseMemObject(Int32 memobj);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetSupportedImageFormats", ExactSpelling = true)]
			internal extern static unsafe int clGetSupportedImageFormats(Int32 context, ulong flags, uint image_type, uint num_entries, Cl.ImageFormat* image_formats, uint* num_image_formats);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetMemObjectInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetMemObjectInfo(Int32 memobj, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetImageInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetImageInfo(Int32 image, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetPipeInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetPipeInfo(Int32 pipe, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetMemObjectDestructorCallback", ExactSpelling = true)]
			internal extern static int clSetMemObjectDestructorCallback(Int32 memobj1, Int32 memobj2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSVMFree", ExactSpelling = true)]
			internal extern static void clSVMFree(Int32 context, Int32 svm_pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateSamplerWithProperties", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateSamplerWithProperties(Int32 context, ulong* normalized_coords, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainSampler", ExactSpelling = true)]
			internal extern static int clRetainSampler(Int32 sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseSampler", ExactSpelling = true)]
			internal extern static int clReleaseSampler(Int32 sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetSamplerInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetSamplerInfo(Int32 sampler, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithSource", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithSource(Int32 context, uint count, String[] strings, uint* lengths, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithBinary", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithBinary(Int32 context, uint num_devices, IntPtr* device_list, uint* lengths, IntPtr* binaries, int* binary_status, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithBuiltInKernels", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithBuiltInKernels(Int32 context, uint num_devices, IntPtr* device_list, char * kernel_names, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithIL", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithIL(Int32 context, void* il, uint length, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainProgram", ExactSpelling = true)]
			internal extern static int clRetainProgram(Int32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseProgram", ExactSpelling = true)]
			internal extern static int clReleaseProgram(Int32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clBuildProgram", ExactSpelling = true)]
			internal extern static unsafe int clBuildProgram(Int32 program, uint num_devices, IntPtr* device_list, char * options, Int32 pfn_notify, Int32 user_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCompileProgram", ExactSpelling = true)]
			internal extern static unsafe int clCompileProgram(Int32 program, uint num_devices, IntPtr* device_list, char * options, uint num_input_headers, IntPtr* input_headers, String[] header_include_names, Int32 pfn_notify, Int32 user_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clLinkProgram", ExactSpelling = true)]
			internal extern static unsafe IntPtr clLinkProgram(Int32 context, uint num_devices, IntPtr* device_list, char * options, uint num_input_programs, IntPtr* input_programs, Int32 pfn_notify, Int32 user_data, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clUnloadPlatformCompiler", ExactSpelling = true)]
			internal extern static int clUnloadPlatformCompiler(Int32 platform);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetProgramInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetProgramInfo(Int32 program, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetProgramBuildInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetProgramBuildInfo(Int32 program, Int32 device, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateKernel", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateKernel(Int32 program, char * kernel_name, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateKernelsInProgram", ExactSpelling = true)]
			internal extern static unsafe int clCreateKernelsInProgram(Int32 program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCloneKernel", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCloneKernel(Int32 source_kernel, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainKernel", ExactSpelling = true)]
			internal extern static int clRetainKernel(Int32 kernel);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseKernel", ExactSpelling = true)]
			internal extern static int clReleaseKernel(Int32 kernel);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetKernelArg", ExactSpelling = true)]
			internal extern static int clSetKernelArg(Int32 kernel, uint arg_index, uint arg_size, Int32 arg_value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetKernelArgSVMPointer", ExactSpelling = true)]
			internal extern static int clSetKernelArgSVMPointer(Int32 kernel, uint arg_index, Int32 arg_value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetKernelExecInfo", ExactSpelling = true)]
			internal extern static int clSetKernelExecInfo(Int32 kernel, uint param_name, uint param_value_size, Int32 param_value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelInfo(Int32 kernel, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelArgInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelArgInfo(Int32 kernel, uint arg_indx, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelWorkGroupInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelWorkGroupInfo(Int32 kernel, Int32 device, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelSubGroupInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelSubGroupInfo(Int32 kernel, Int32 device, uint param_name, uint input_value_size, uint param_value_size, void* param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clWaitForEvents", ExactSpelling = true)]
			internal extern static unsafe int clWaitForEvents(uint num_events, IntPtr* event_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetEventInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetEventInfo(Int32 @event, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateUserEvent", ExactSpelling = true)]
			internal extern static IntPtr clCreateUserEvent(Int32 context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseEvent", ExactSpelling = true)]
			internal extern static int clReleaseEvent(Int32 @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetUserEventStatus", ExactSpelling = true)]
			internal extern static int clSetUserEventStatus(Int32 @event, int execution_status);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetEventCallback", ExactSpelling = true)]
			internal extern static int clSetEventCallback(Int32 @event, int command_exec_callback_type, Int32 pfn_notify, Int32 user_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetEventProfilingInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetEventProfilingInfo(Int32 @event, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clFlush", ExactSpelling = true)]
			internal extern static int clFlush(Int32 command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clFinish", ExactSpelling = true)]
			internal extern static int clFinish(Int32 command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueReadBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueReadBuffer(Int32 command_queue, Int32 buffer, bool blocking_read, uint offset, uint size, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueReadBufferRect", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueReadBufferRect(Int32 command_queue, Int32 buffer, bool blocking_read, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueWriteBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueWriteBuffer(Int32 command_queue, Int32 buffer, bool blocking_write, uint offset, uint size, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueWriteBufferRect", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueWriteBufferRect(Int32 command_queue, Int32 buffer, bool blocking_write, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueFillBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueFillBuffer(Int32 command_queue, Int32 buffer, Int32 pattern, uint pattern_size, uint offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyBuffer(Int32 command_queue, Int32 src_buffer, Int32 dst_buffer, uint src_offset, uint dst_offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyBufferRect", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyBufferRect(Int32 command_queue, Int32 src_buffer, Int32 dst_buffer, uint* src_origin, uint* dst_origin, uint* region, uint src_row_pitch, uint src_slice_pitch, uint dst_row_pitch, uint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueReadImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueReadImage(Int32 command_queue, Int32 image, bool blocking_read, uint row_pitch, uint slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueWriteImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueWriteImage(Int32 command_queue, Int32 image, bool blocking_write, uint input_row_pitch, uint input_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueFillImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueFillImage(Int32 command_queue, Int32 image, Int32 fill_color, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyImage(Int32 command_queue, Int32 src_image, Int32 dst_image, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyImageToBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyImageToBuffer(Int32 command_queue, Int32 src_image, Int32 dst_buffer, uint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyBufferToImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyBufferToImage(Int32 command_queue, Int32 src_buffer, Int32 dst_image, uint src_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueUnmapMemObject", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueUnmapMemObject(Int32 command_queue, Int32 memobj, Int32 mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueMigrateMemObjects", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueMigrateMemObjects(Int32 command_queue, uint num_mem_objects, IntPtr* mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueNDRangeKernel", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueNDRangeKernel(Int32 command_queue, Int32 kernel, uint work_dim, uint* global_work_offset, uint* global_work_size, uint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueNativeKernel", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueNativeKernel(Int32 command_queue, Int32 args, uint cb_args, uint num_mem_objects, IntPtr* mem_list, IntPtr* args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueMarkerWithWaitList", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueMarkerWithWaitList(Int32 command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueBarrierWithWaitList", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueBarrierWithWaitList(Int32 command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMFree", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMFree(Int32 command_queue, uint num_svm_pointers, Int32 queue, Int32 user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMemcpy", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMemcpy(Int32 command_queue, bool blocking_copy, Int32 dst_ptr, Int32 src_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMemFill", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMemFill(Int32 command_queue, Int32 svm_ptr, Int32 pattern, uint pattern_size, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMap", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMap(Int32 command_queue, bool blocking_map, ulong flags, Int32 svm_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMUnmap", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMUnmap(Int32 command_queue, Int32 svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMigrateMem", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMigrateMem(Int32 command_queue, uint num_svm_pointers, IntPtr* svm_pointers, uint* sizes, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

		}
	}

}

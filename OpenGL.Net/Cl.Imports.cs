
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
			internal extern static unsafe int clGetPlatformInfo(IntPtr platform, PlatformInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetDeviceIDs", ExactSpelling = true)]
			internal extern static unsafe int clGetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, IntPtr* devices, uint* num_devices);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetDeviceInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetDeviceInfo(IntPtr device, DeviceInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateSubDevices", ExactSpelling = true)]
			internal extern static unsafe int clCreateSubDevices(IntPtr in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainDevice", ExactSpelling = true)]
			internal extern static unsafe int clRetainDevice(IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseDevice", ExactSpelling = true)]
			internal extern static unsafe int clReleaseDevice(IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetDefaultDeviceCommandQueue", ExactSpelling = true)]
			internal extern static unsafe int clSetDefaultDeviceCommandQueue(IntPtr context, IntPtr device, IntPtr command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetDeviceAndHostTimer", ExactSpelling = true)]
			internal extern static unsafe int clGetDeviceAndHostTimer(IntPtr device, ulong* device_timestamp, ulong* host_timestamp);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetHostTimer", ExactSpelling = true)]
			internal extern static unsafe int clGetHostTimer(IntPtr device, ulong* host_timestamp);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateContext", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateContext(ContextProperties * properties, uint num_devices, IntPtr* devices, IntPtr pfn_notify, IntPtr user_data, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateContextFromType", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateContextFromType(ContextProperties * properties, DeviceType device_type, IntPtr user_data, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainContext", ExactSpelling = true)]
			internal extern static unsafe int clRetainContext(IntPtr context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseContext", ExactSpelling = true)]
			internal extern static unsafe int clReleaseContext(IntPtr context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetContextInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetContextInfo(IntPtr context, ContextInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateCommandQueueWithProperties", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateCommandQueueWithProperties(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainCommandQueue", ExactSpelling = true)]
			internal extern static unsafe int clRetainCommandQueue(IntPtr command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseCommandQueue", ExactSpelling = true)]
			internal extern static unsafe int clReleaseCommandQueue(IntPtr command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetCommandQueueInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetCommandQueueInfo(IntPtr command_queue, CommandQueueInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateBuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateBuffer(IntPtr context, ulong flags, uint size, IntPtr host_ptr, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateSubBuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateSubBuffer(IntPtr buffer, ulong flags, BufferCreateType buffer_create_type, IntPtr buffer_create_info, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateImage", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateImage(IntPtr context, ulong flags, Cl.ImageFormat* image_format, Cl.ImageDescr* image_desc, IntPtr host_ptr, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreatePipe", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreatePipe(IntPtr context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainMemObject", ExactSpelling = true)]
			internal extern static unsafe int clRetainMemObject(IntPtr memobj);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseMemObject", ExactSpelling = true)]
			internal extern static unsafe int clReleaseMemObject(IntPtr memobj);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetSupportedImageFormats", ExactSpelling = true)]
			internal extern static unsafe int clGetSupportedImageFormats(IntPtr context, ulong flags, MemObjectType image_type, uint num_entries, Cl.ImageFormat* image_formats, uint* num_image_formats);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetMemObjectInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetMemObjectInfo(IntPtr memobj, MemInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetImageInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetImageInfo(IntPtr image, ImageInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetPipeInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetPipeInfo(IntPtr pipe, uint param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetMemObjectDestructorCallback", ExactSpelling = true)]
			internal extern static unsafe int clSetMemObjectDestructorCallback(IntPtr memobj1, IntPtr memobj2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSVMFree", ExactSpelling = true)]
			internal extern static unsafe void clSVMFree(IntPtr context, IntPtr svm_pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateSamplerWithProperties", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateSamplerWithProperties(IntPtr context, ulong* normalized_coords, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainSampler", ExactSpelling = true)]
			internal extern static unsafe int clRetainSampler(IntPtr sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseSampler", ExactSpelling = true)]
			internal extern static unsafe int clReleaseSampler(IntPtr sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetSamplerInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetSamplerInfo(IntPtr sampler, SamplerInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithSource", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithSource(IntPtr context, uint count, String[] strings, uint* lengths, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithBinary", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr* device_list, uint* lengths, IntPtr* binaries, int* binary_status, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithBuiltInKernels", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithBuiltInKernels(IntPtr context, uint num_devices, IntPtr* device_list, char * kernel_names, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateProgramWithIL", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateProgramWithIL(IntPtr context, void* il, uint length, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainProgram", ExactSpelling = true)]
			internal extern static unsafe int clRetainProgram(IntPtr program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseProgram", ExactSpelling = true)]
			internal extern static unsafe int clReleaseProgram(IntPtr program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clBuildProgram", ExactSpelling = true)]
			internal extern static unsafe int clBuildProgram(IntPtr program, uint num_devices, IntPtr* device_list, char * options, IntPtr pfn_notify, IntPtr user_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCompileProgram", ExactSpelling = true)]
			internal extern static unsafe int clCompileProgram(IntPtr program, uint num_devices, IntPtr* device_list, char * options, uint num_input_headers, IntPtr* input_headers, String[] header_include_names, IntPtr pfn_notify, IntPtr user_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clLinkProgram", ExactSpelling = true)]
			internal extern static unsafe IntPtr clLinkProgram(IntPtr context, uint num_devices, IntPtr* device_list, char * options, uint num_input_programs, IntPtr* input_programs, IntPtr pfn_notify, IntPtr user_data, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clUnloadPlatformCompiler", ExactSpelling = true)]
			internal extern static unsafe int clUnloadPlatformCompiler(IntPtr platform);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetProgramInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetProgramInfo(IntPtr program, ProgramInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetProgramBuildInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateKernel", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateKernel(IntPtr program, char * kernel_name, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateKernelsInProgram", ExactSpelling = true)]
			internal extern static unsafe int clCreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCloneKernel", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCloneKernel(IntPtr source_kernel, int* errcode_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clRetainKernel", ExactSpelling = true)]
			internal extern static unsafe int clRetainKernel(IntPtr kernel);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseKernel", ExactSpelling = true)]
			internal extern static unsafe int clReleaseKernel(IntPtr kernel);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetKernelArg", ExactSpelling = true)]
			internal extern static unsafe int clSetKernelArg(IntPtr kernel, uint arg_index, uint arg_size, IntPtr arg_value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetKernelArgSVMPointer", ExactSpelling = true)]
			internal extern static unsafe int clSetKernelArgSVMPointer(IntPtr kernel, uint arg_index, IntPtr arg_value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetKernelExecInfo", ExactSpelling = true)]
			internal extern static unsafe int clSetKernelExecInfo(IntPtr kernel, uint param_name, uint param_value_size, IntPtr param_value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelInfo(IntPtr kernel, KernelInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelArgInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelArgInfo(IntPtr kernel, uint arg_indx, KernelArgInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelWorkGroupInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetKernelSubGroupInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetKernelSubGroupInfo(IntPtr kernel, IntPtr device, KernelSubGroupInfo param_name, uint input_value_size, uint param_value_size, void* param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clWaitForEvents", ExactSpelling = true)]
			internal extern static unsafe int clWaitForEvents(uint num_events, IntPtr* event_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetEventInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetEventInfo(IntPtr @event, EventInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clCreateUserEvent", ExactSpelling = true)]
			internal extern static unsafe IntPtr clCreateUserEvent(IntPtr context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clReleaseEvent", ExactSpelling = true)]
			internal extern static unsafe int clReleaseEvent(IntPtr @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetUserEventStatus", ExactSpelling = true)]
			internal extern static unsafe int clSetUserEventStatus(IntPtr @event, int execution_status);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clSetEventCallback", ExactSpelling = true)]
			internal extern static unsafe int clSetEventCallback(IntPtr @event, int command_exec_callback_type, IntPtr pfn_notify, IntPtr user_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clGetEventProfilingInfo", ExactSpelling = true)]
			internal extern static unsafe int clGetEventProfilingInfo(IntPtr @event, ProfilingInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clFlush", ExactSpelling = true)]
			internal extern static unsafe int clFlush(IntPtr command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clFinish", ExactSpelling = true)]
			internal extern static unsafe int clFinish(IntPtr command_queue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueReadBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, uint offset, uint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueReadBufferRect", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, bool blocking_read, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueWriteBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, uint offset, uint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueWriteBufferRect", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, bool blocking_write, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueFillBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, IntPtr pattern, uint pattern_size, uint offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, uint src_offset, uint dst_offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyBufferRect", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, uint* src_origin, uint* dst_origin, uint* region, uint src_row_pitch, uint src_slice_pitch, uint dst_row_pitch, uint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueReadImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueReadImage(IntPtr command_queue, IntPtr image, bool blocking_read, uint row_pitch, uint slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueWriteImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueWriteImage(IntPtr command_queue, IntPtr image, bool blocking_write, uint input_row_pitch, uint input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueFillImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueFillImage(IntPtr command_queue, IntPtr image, IntPtr fill_color, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyImageToBuffer", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, uint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueCopyBufferToImage", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, uint src_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueUnmapMemObject", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueMigrateMemObjects", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueNDRangeKernel", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, uint* global_work_offset, uint* global_work_size, uint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueNativeKernel", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueNativeKernel(IntPtr command_queue, IntPtr args, uint cb_args, uint num_mem_objects, IntPtr* mem_list, IntPtr* args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueMarkerWithWaitList", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueBarrierWithWaitList", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMFree", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, IntPtr queue, IntPtr user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMemcpy", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMemcpy(IntPtr command_queue, bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMemFill", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMemFill(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, uint pattern_size, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMap", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMap(IntPtr command_queue, bool blocking_map, MapFlags flags, IntPtr svm_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMUnmap", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMUnmap(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "clEnqueueSVMMigrateMem", ExactSpelling = true)]
			internal extern static unsafe int clEnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, IntPtr* svm_pointers, uint* sizes, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

		}
	}

}

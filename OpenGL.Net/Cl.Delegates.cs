
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	public unsafe partial class Cl
	{
		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetPlatformIDs(uint num_entries, IntPtr* platforms, uint* num_platforms);

			internal static clGetPlatformIDs pclGetPlatformIDs;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetPlatformInfo(IntPtr platform, PlatformInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetPlatformInfo pclGetPlatformInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, IntPtr* devices, uint* num_devices);

			internal static clGetDeviceIDs pclGetDeviceIDs;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetDeviceInfo(IntPtr device, DeviceInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetDeviceInfo pclGetDeviceInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clCreateSubDevices(IntPtr in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret);

			internal static clCreateSubDevices pclCreateSubDevices;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainDevice(IntPtr device);

			internal static clRetainDevice pclRetainDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseDevice(IntPtr device);

			internal static clReleaseDevice pclReleaseDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetDefaultDeviceCommandQueue(IntPtr context, IntPtr device, IntPtr command_queue);

			internal static clSetDefaultDeviceCommandQueue pclSetDefaultDeviceCommandQueue;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetDeviceAndHostTimer(IntPtr device, ulong* device_timestamp, ulong* host_timestamp);

			internal static clGetDeviceAndHostTimer pclGetDeviceAndHostTimer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetHostTimer(IntPtr device, ulong* host_timestamp);

			internal static clGetHostTimer pclGetHostTimer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateContext(ContextProperties * properties, uint num_devices, IntPtr* devices, IntPtr pfn_notify, IntPtr user_data, int* errcode_ret);

			internal static clCreateContext pclCreateContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateContextFromType(ContextProperties * properties, DeviceType device_type, IntPtr user_data, int* errcode_ret);

			internal static clCreateContextFromType pclCreateContextFromType;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainContext(IntPtr context);

			internal static clRetainContext pclRetainContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseContext(IntPtr context);

			internal static clReleaseContext pclReleaseContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetContextInfo(IntPtr context, ContextInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetContextInfo pclGetContextInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateCommandQueueWithProperties(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret);

			internal static clCreateCommandQueueWithProperties pclCreateCommandQueueWithProperties;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainCommandQueue(IntPtr command_queue);

			internal static clRetainCommandQueue pclRetainCommandQueue;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseCommandQueue(IntPtr command_queue);

			internal static clReleaseCommandQueue pclReleaseCommandQueue;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetCommandQueueInfo(IntPtr command_queue, CommandQueueInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetCommandQueueInfo pclGetCommandQueueInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateBuffer(IntPtr context, ulong flags, uint size, IntPtr host_ptr, int* errcode_ret);

			internal static clCreateBuffer pclCreateBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateSubBuffer(IntPtr buffer, ulong flags, BufferCreateType buffer_create_type, IntPtr buffer_create_info, int* errcode_ret);

			internal static clCreateSubBuffer pclCreateSubBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateImage(IntPtr context, ulong flags, Cl.ImageFormat* image_format, Cl.ImageDescr* image_desc, IntPtr host_ptr, int* errcode_ret);

			internal static clCreateImage pclCreateImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreatePipe(IntPtr context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret);

			internal static clCreatePipe pclCreatePipe;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainMemObject(IntPtr memobj);

			internal static clRetainMemObject pclRetainMemObject;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseMemObject(IntPtr memobj);

			internal static clReleaseMemObject pclReleaseMemObject;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetSupportedImageFormats(IntPtr context, ulong flags, MemObjectType image_type, uint num_entries, Cl.ImageFormat* image_formats, uint* num_image_formats);

			internal static clGetSupportedImageFormats pclGetSupportedImageFormats;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetMemObjectInfo(IntPtr memobj, MemInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetMemObjectInfo pclGetMemObjectInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetImageInfo(IntPtr image, ImageInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetImageInfo pclGetImageInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetPipeInfo(IntPtr pipe, uint param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetPipeInfo pclGetPipeInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetMemObjectDestructorCallback(IntPtr memobj1, IntPtr memobj2);

			internal static clSetMemObjectDestructorCallback pclSetMemObjectDestructorCallback;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void clSVMFree(IntPtr context, IntPtr svm_pointer);

			internal static clSVMFree pclSVMFree;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateSamplerWithProperties(IntPtr context, ulong* normalized_coords, int* errcode_ret);

			internal static clCreateSamplerWithProperties pclCreateSamplerWithProperties;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainSampler(IntPtr sampler);

			internal static clRetainSampler pclRetainSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseSampler(IntPtr sampler);

			internal static clReleaseSampler pclReleaseSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetSamplerInfo(IntPtr sampler, SamplerInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetSamplerInfo pclGetSamplerInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithSource(IntPtr context, uint count, String[] strings, uint* lengths, int* errcode_ret);

			internal static clCreateProgramWithSource pclCreateProgramWithSource;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr* device_list, uint* lengths, IntPtr* binaries, int* binary_status, int* errcode_ret);

			internal static clCreateProgramWithBinary pclCreateProgramWithBinary;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithBuiltInKernels(IntPtr context, uint num_devices, IntPtr* device_list, char * kernel_names, int* errcode_ret);

			internal static clCreateProgramWithBuiltInKernels pclCreateProgramWithBuiltInKernels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithIL(IntPtr context, void* il, uint length, int* errcode_ret);

			internal static clCreateProgramWithIL pclCreateProgramWithIL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainProgram(IntPtr program);

			internal static clRetainProgram pclRetainProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseProgram(IntPtr program);

			internal static clReleaseProgram pclReleaseProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clBuildProgram(IntPtr program, uint num_devices, IntPtr* device_list, char * options, IntPtr pfn_notify, IntPtr user_data);

			internal static clBuildProgram pclBuildProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clCompileProgram(IntPtr program, uint num_devices, IntPtr* device_list, char * options, uint num_input_headers, IntPtr* input_headers, String[] header_include_names, IntPtr pfn_notify, IntPtr user_data);

			internal static clCompileProgram pclCompileProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clLinkProgram(IntPtr context, uint num_devices, IntPtr* device_list, char * options, uint num_input_programs, IntPtr* input_programs, IntPtr pfn_notify, IntPtr user_data, int* errcode_ret);

			internal static clLinkProgram pclLinkProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clUnloadPlatformCompiler(IntPtr platform);

			internal static clUnloadPlatformCompiler pclUnloadPlatformCompiler;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetProgramInfo(IntPtr program, ProgramInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetProgramInfo pclGetProgramInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetProgramBuildInfo pclGetProgramBuildInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateKernel(IntPtr program, char * kernel_name, int* errcode_ret);

			internal static clCreateKernel pclCreateKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clCreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret);

			internal static clCreateKernelsInProgram pclCreateKernelsInProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCloneKernel(IntPtr source_kernel, int* errcode_ret);

			internal static clCloneKernel pclCloneKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clRetainKernel(IntPtr kernel);

			internal static clRetainKernel pclRetainKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseKernel(IntPtr kernel);

			internal static clReleaseKernel pclReleaseKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetKernelArg(IntPtr kernel, uint arg_index, uint arg_size, IntPtr arg_value);

			internal static clSetKernelArg pclSetKernelArg;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetKernelArgSVMPointer(IntPtr kernel, uint arg_index, IntPtr arg_value);

			internal static clSetKernelArgSVMPointer pclSetKernelArgSVMPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetKernelExecInfo(IntPtr kernel, uint param_name, uint param_value_size, IntPtr param_value);

			internal static clSetKernelExecInfo pclSetKernelExecInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelInfo(IntPtr kernel, KernelInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetKernelInfo pclGetKernelInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelArgInfo(IntPtr kernel, uint arg_indx, KernelArgInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetKernelArgInfo pclGetKernelArgInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetKernelWorkGroupInfo pclGetKernelWorkGroupInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelSubGroupInfo(IntPtr kernel, IntPtr device, KernelSubGroupInfo param_name, uint input_value_size, uint param_value_size, void* param_value, uint* param_value_size_ret);

			internal static clGetKernelSubGroupInfo pclGetKernelSubGroupInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clWaitForEvents(uint num_events, IntPtr* event_list);

			internal static clWaitForEvents pclWaitForEvents;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetEventInfo(IntPtr @event, EventInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetEventInfo pclGetEventInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateUserEvent(IntPtr context);

			internal static clCreateUserEvent pclCreateUserEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clReleaseEvent(IntPtr @event);

			internal static clReleaseEvent pclReleaseEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetUserEventStatus(IntPtr @event, int execution_status);

			internal static clSetUserEventStatus pclSetUserEventStatus;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clSetEventCallback(IntPtr @event, int command_exec_callback_type, IntPtr pfn_notify, IntPtr user_data);

			internal static clSetEventCallback pclSetEventCallback;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetEventProfilingInfo(IntPtr @event, ProfilingInfo param_name, uint param_value_size, IntPtr param_value, uint* param_value_size_ret);

			internal static clGetEventProfilingInfo pclGetEventProfilingInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clFlush(IntPtr command_queue);

			internal static clFlush pclFlush;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clFinish(IntPtr command_queue);

			internal static clFinish pclFinish;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, uint offset, uint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueReadBuffer pclEnqueueReadBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, bool blocking_read, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueReadBufferRect pclEnqueueReadBufferRect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, uint offset, uint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueWriteBuffer pclEnqueueWriteBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, bool blocking_write, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueWriteBufferRect pclEnqueueWriteBufferRect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, IntPtr pattern, uint pattern_size, uint offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueFillBuffer pclEnqueueFillBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, uint src_offset, uint dst_offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyBuffer pclEnqueueCopyBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, uint* src_origin, uint* dst_origin, uint* region, uint src_row_pitch, uint src_slice_pitch, uint dst_row_pitch, uint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyBufferRect pclEnqueueCopyBufferRect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueReadImage(IntPtr command_queue, IntPtr image, bool blocking_read, uint row_pitch, uint slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueReadImage pclEnqueueReadImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueWriteImage(IntPtr command_queue, IntPtr image, bool blocking_write, uint input_row_pitch, uint input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueWriteImage pclEnqueueWriteImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueFillImage(IntPtr command_queue, IntPtr image, IntPtr fill_color, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueFillImage pclEnqueueFillImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyImage pclEnqueueCopyImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, uint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyImageToBuffer pclEnqueueCopyImageToBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, uint src_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyBufferToImage pclEnqueueCopyBufferToImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueUnmapMemObject pclEnqueueUnmapMemObject;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueMigrateMemObjects pclEnqueueMigrateMemObjects;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, uint* global_work_offset, uint* global_work_size, uint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueNDRangeKernel pclEnqueueNDRangeKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueNativeKernel(IntPtr command_queue, IntPtr args, uint cb_args, uint num_mem_objects, IntPtr* mem_list, IntPtr* args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueNativeKernel pclEnqueueNativeKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueMarkerWithWaitList pclEnqueueMarkerWithWaitList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueBarrierWithWaitList pclEnqueueBarrierWithWaitList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, IntPtr queue, IntPtr user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMFree pclEnqueueSVMFree;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMemcpy(IntPtr command_queue, bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMemcpy pclEnqueueSVMMemcpy;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMemFill(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, uint pattern_size, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMemFill pclEnqueueSVMMemFill;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMap(IntPtr command_queue, bool blocking_map, MapFlags flags, IntPtr svm_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMap pclEnqueueSVMMap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMUnmap(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMUnmap pclEnqueueSVMUnmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, IntPtr* svm_pointers, uint* sizes, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMigrateMem pclEnqueueSVMMigrateMem;

		}
	}

}

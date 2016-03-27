
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
			internal unsafe delegate int clGetPlatformInfo(Int32 platform, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetPlatformInfo pclGetPlatformInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetDeviceIDs(Int32 platform, ulong device_type, uint num_entries, IntPtr* devices, uint* num_devices);

			internal static clGetDeviceIDs pclGetDeviceIDs;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetDeviceInfo(Int32 device, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetDeviceInfo pclGetDeviceInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clCreateSubDevices(Int32 in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret);

			internal static clCreateSubDevices pclCreateSubDevices;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainDevice(Int32 device);

			internal static clRetainDevice pclRetainDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseDevice(Int32 device);

			internal static clReleaseDevice pclReleaseDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetDefaultDeviceCommandQueue(Int32 context, Int32 device, Int32 command_queue);

			internal static clSetDefaultDeviceCommandQueue pclSetDefaultDeviceCommandQueue;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetDeviceAndHostTimer(Int32 device, ulong* device_timestamp, ulong* host_timestamp);

			internal static clGetDeviceAndHostTimer pclGetDeviceAndHostTimer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetHostTimer(Int32 device, ulong* host_timestamp);

			internal static clGetHostTimer pclGetHostTimer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateContext(cl_context_properties * properties, uint num_devices, IntPtr* devices, Int32 pfn_notify, Int32 user_data, int* errcode_ret);

			internal static clCreateContext pclCreateContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateContextFromType(cl_context_properties * properties, ulong device_type, Int32 user_data, int* errcode_ret);

			internal static clCreateContextFromType pclCreateContextFromType;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainContext(Int32 context);

			internal static clRetainContext pclRetainContext;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseContext(Int32 context);

			internal static clReleaseContext pclReleaseContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetContextInfo(Int32 context, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetContextInfo pclGetContextInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateCommandQueueWithProperties(Int32 context, Int32 device, ulong* properties, int* errcode_ret);

			internal static clCreateCommandQueueWithProperties pclCreateCommandQueueWithProperties;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainCommandQueue(Int32 command_queue);

			internal static clRetainCommandQueue pclRetainCommandQueue;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseCommandQueue(Int32 command_queue);

			internal static clReleaseCommandQueue pclReleaseCommandQueue;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetCommandQueueInfo(Int32 command_queue, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetCommandQueueInfo pclGetCommandQueueInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateBuffer(Int32 context, ulong flags, uint size, Int32 host_ptr, int* errcode_ret);

			internal static clCreateBuffer pclCreateBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateSubBuffer(Int32 buffer, ulong flags, uint buffer_create_type, Int32 buffer_create_info, int* errcode_ret);

			internal static clCreateSubBuffer pclCreateSubBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateImage(Int32 context, ulong flags, Cl.ImageFormat* image_format, Cl.ImageDescr* image_desc, Int32 host_ptr, int* errcode_ret);

			internal static clCreateImage pclCreateImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreatePipe(Int32 context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret);

			internal static clCreatePipe pclCreatePipe;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainMemObject(Int32 memobj);

			internal static clRetainMemObject pclRetainMemObject;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseMemObject(Int32 memobj);

			internal static clReleaseMemObject pclReleaseMemObject;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetSupportedImageFormats(Int32 context, ulong flags, uint image_type, uint num_entries, Cl.ImageFormat* image_formats, uint* num_image_formats);

			internal static clGetSupportedImageFormats pclGetSupportedImageFormats;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetMemObjectInfo(Int32 memobj, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetMemObjectInfo pclGetMemObjectInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetImageInfo(Int32 image, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetImageInfo pclGetImageInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetPipeInfo(Int32 pipe, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetPipeInfo pclGetPipeInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetMemObjectDestructorCallback(Int32 memobj1, Int32 memobj2);

			internal static clSetMemObjectDestructorCallback pclSetMemObjectDestructorCallback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void clSVMFree(Int32 context, Int32 svm_pointer);

			internal static clSVMFree pclSVMFree;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateSamplerWithProperties(Int32 context, ulong* normalized_coords, int* errcode_ret);

			internal static clCreateSamplerWithProperties pclCreateSamplerWithProperties;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainSampler(Int32 sampler);

			internal static clRetainSampler pclRetainSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseSampler(Int32 sampler);

			internal static clReleaseSampler pclReleaseSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetSamplerInfo(Int32 sampler, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetSamplerInfo pclGetSamplerInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithSource(Int32 context, uint count, String[] strings, uint* lengths, int* errcode_ret);

			internal static clCreateProgramWithSource pclCreateProgramWithSource;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithBinary(Int32 context, uint num_devices, IntPtr* device_list, uint* lengths, IntPtr* binaries, int* binary_status, int* errcode_ret);

			internal static clCreateProgramWithBinary pclCreateProgramWithBinary;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithBuiltInKernels(Int32 context, uint num_devices, IntPtr* device_list, char * kernel_names, int* errcode_ret);

			internal static clCreateProgramWithBuiltInKernels pclCreateProgramWithBuiltInKernels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateProgramWithIL(Int32 context, void* il, uint length, int* errcode_ret);

			internal static clCreateProgramWithIL pclCreateProgramWithIL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainProgram(Int32 program);

			internal static clRetainProgram pclRetainProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseProgram(Int32 program);

			internal static clReleaseProgram pclReleaseProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clBuildProgram(Int32 program, uint num_devices, IntPtr* device_list, char * options, Int32 pfn_notify, Int32 user_data);

			internal static clBuildProgram pclBuildProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clCompileProgram(Int32 program, uint num_devices, IntPtr* device_list, char * options, uint num_input_headers, IntPtr* input_headers, String[] header_include_names, Int32 pfn_notify, Int32 user_data);

			internal static clCompileProgram pclCompileProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clLinkProgram(Int32 context, uint num_devices, IntPtr* device_list, char * options, uint num_input_programs, IntPtr* input_programs, Int32 pfn_notify, Int32 user_data, int* errcode_ret);

			internal static clLinkProgram pclLinkProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clUnloadPlatformCompiler(Int32 platform);

			internal static clUnloadPlatformCompiler pclUnloadPlatformCompiler;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetProgramInfo(Int32 program, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetProgramInfo pclGetProgramInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetProgramBuildInfo(Int32 program, Int32 device, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetProgramBuildInfo pclGetProgramBuildInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCreateKernel(Int32 program, char * kernel_name, int* errcode_ret);

			internal static clCreateKernel pclCreateKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clCreateKernelsInProgram(Int32 program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret);

			internal static clCreateKernelsInProgram pclCreateKernelsInProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr clCloneKernel(Int32 source_kernel, int* errcode_ret);

			internal static clCloneKernel pclCloneKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clRetainKernel(Int32 kernel);

			internal static clRetainKernel pclRetainKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseKernel(Int32 kernel);

			internal static clReleaseKernel pclReleaseKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetKernelArg(Int32 kernel, uint arg_index, uint arg_size, Int32 arg_value);

			internal static clSetKernelArg pclSetKernelArg;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetKernelArgSVMPointer(Int32 kernel, uint arg_index, Int32 arg_value);

			internal static clSetKernelArgSVMPointer pclSetKernelArgSVMPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetKernelExecInfo(Int32 kernel, uint param_name, uint param_value_size, Int32 param_value);

			internal static clSetKernelExecInfo pclSetKernelExecInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelInfo(Int32 kernel, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetKernelInfo pclGetKernelInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelArgInfo(Int32 kernel, uint arg_indx, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetKernelArgInfo pclGetKernelArgInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelWorkGroupInfo(Int32 kernel, Int32 device, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetKernelWorkGroupInfo pclGetKernelWorkGroupInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetKernelSubGroupInfo(Int32 kernel, Int32 device, uint param_name, uint input_value_size, uint param_value_size, void* param_value, uint* param_value_size_ret);

			internal static clGetKernelSubGroupInfo pclGetKernelSubGroupInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clWaitForEvents(uint num_events, IntPtr* event_list);

			internal static clWaitForEvents pclWaitForEvents;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetEventInfo(Int32 @event, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetEventInfo pclGetEventInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr clCreateUserEvent(Int32 context);

			internal static clCreateUserEvent pclCreateUserEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clReleaseEvent(Int32 @event);

			internal static clReleaseEvent pclReleaseEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetUserEventStatus(Int32 @event, int execution_status);

			internal static clSetUserEventStatus pclSetUserEventStatus;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clSetEventCallback(Int32 @event, int command_exec_callback_type, Int32 pfn_notify, Int32 user_data);

			internal static clSetEventCallback pclSetEventCallback;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clGetEventProfilingInfo(Int32 @event, uint param_name, uint param_value_size, Int32 param_value, uint* param_value_size_ret);

			internal static clGetEventProfilingInfo pclGetEventProfilingInfo;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clFlush(Int32 command_queue);

			internal static clFlush pclFlush;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int clFinish(Int32 command_queue);

			internal static clFinish pclFinish;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueReadBuffer(Int32 command_queue, Int32 buffer, bool blocking_read, uint offset, uint size, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueReadBuffer pclEnqueueReadBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueReadBufferRect(Int32 command_queue, Int32 buffer, bool blocking_read, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueReadBufferRect pclEnqueueReadBufferRect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueWriteBuffer(Int32 command_queue, Int32 buffer, bool blocking_write, uint offset, uint size, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueWriteBuffer pclEnqueueWriteBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueWriteBufferRect(Int32 command_queue, Int32 buffer, bool blocking_write, uint* buffer_offset, uint* host_offset, uint* region, uint buffer_row_pitch, uint buffer_slice_pitch, uint host_row_pitch, uint host_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueWriteBufferRect pclEnqueueWriteBufferRect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueFillBuffer(Int32 command_queue, Int32 buffer, Int32 pattern, uint pattern_size, uint offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueFillBuffer pclEnqueueFillBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyBuffer(Int32 command_queue, Int32 src_buffer, Int32 dst_buffer, uint src_offset, uint dst_offset, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyBuffer pclEnqueueCopyBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyBufferRect(Int32 command_queue, Int32 src_buffer, Int32 dst_buffer, uint* src_origin, uint* dst_origin, uint* region, uint src_row_pitch, uint src_slice_pitch, uint dst_row_pitch, uint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyBufferRect pclEnqueueCopyBufferRect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueReadImage(Int32 command_queue, Int32 image, bool blocking_read, uint row_pitch, uint slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueReadImage pclEnqueueReadImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueWriteImage(Int32 command_queue, Int32 image, bool blocking_write, uint input_row_pitch, uint input_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueWriteImage pclEnqueueWriteImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueFillImage(Int32 command_queue, Int32 image, Int32 fill_color, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueFillImage pclEnqueueFillImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyImage(Int32 command_queue, Int32 src_image, Int32 dst_image, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyImage pclEnqueueCopyImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyImageToBuffer(Int32 command_queue, Int32 src_image, Int32 dst_buffer, uint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyImageToBuffer pclEnqueueCopyImageToBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueCopyBufferToImage(Int32 command_queue, Int32 src_buffer, Int32 dst_image, uint src_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueCopyBufferToImage pclEnqueueCopyBufferToImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueUnmapMemObject(Int32 command_queue, Int32 memobj, Int32 mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueUnmapMemObject pclEnqueueUnmapMemObject;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueMigrateMemObjects(Int32 command_queue, uint num_mem_objects, IntPtr* mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueMigrateMemObjects pclEnqueueMigrateMemObjects;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueNDRangeKernel(Int32 command_queue, Int32 kernel, uint work_dim, uint* global_work_offset, uint* global_work_size, uint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueNDRangeKernel pclEnqueueNDRangeKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueNativeKernel(Int32 command_queue, Int32 args, uint cb_args, uint num_mem_objects, IntPtr* mem_list, IntPtr* args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueNativeKernel pclEnqueueNativeKernel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueMarkerWithWaitList(Int32 command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueMarkerWithWaitList pclEnqueueMarkerWithWaitList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueBarrierWithWaitList(Int32 command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueBarrierWithWaitList pclEnqueueBarrierWithWaitList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMFree(Int32 command_queue, uint num_svm_pointers, Int32 queue, Int32 user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMFree pclEnqueueSVMFree;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMemcpy(Int32 command_queue, bool blocking_copy, Int32 dst_ptr, Int32 src_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMemcpy pclEnqueueSVMMemcpy;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMemFill(Int32 command_queue, Int32 svm_ptr, Int32 pattern, uint pattern_size, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMemFill pclEnqueueSVMMemFill;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMap(Int32 command_queue, bool blocking_map, ulong flags, Int32 svm_ptr, uint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMap pclEnqueueSVMMap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMUnmap(Int32 command_queue, Int32 svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMUnmap pclEnqueueSVMUnmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int clEnqueueSVMMigrateMem(Int32 command_queue, uint num_svm_pointers, IntPtr* svm_pointers, uint* sizes, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);

			internal static clEnqueueSVMMigrateMem pclEnqueueSVMMigrateMem;

		}
	}

}

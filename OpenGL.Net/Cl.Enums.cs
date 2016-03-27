
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

// Disable "'token' is obsolete" warnings
#pragma warning disable 618
using System;

namespace OpenCL
{
	/// <summary>
	/// Strongly typed enumeration ErrorCode.
	/// </summary>
	[Flags()]
	public enum ErrorCode : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_bool.
	/// </summary>
	public enum cl_bool
	{
		/// <summary>
		/// Strongly typed for value CL_FALSE.
		/// </summary>
		False = Cl.FALSE,

		/// <summary>
		/// Strongly typed for value CL_TRUE.
		/// </summary>
		True = Cl.TRUE,

		/// <summary>
		/// Strongly typed for value CL_BLOCKING.
		/// </summary>
		Blocking = Cl.BLOCKING,

		/// <summary>
		/// Strongly typed for value CL_NON_BLOCKING.
		/// </summary>
		NonBlocking = Cl.NON_BLOCKING,

	}

	/// <summary>
	/// Strongly typed enumeration cl_platform_info.
	/// </summary>
	public enum cl_platform_info
	{
		/// <summary>
		/// Strongly typed for value CL_PLATFORM_PROFILE.
		/// </summary>
		PlatformProfile = Cl.PLATFORM_PROFILE,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_VERSION.
		/// </summary>
		PlatformVersion = Cl.PLATFORM_VERSION,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_NAME.
		/// </summary>
		PlatformName = Cl.PLATFORM_NAME,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_VENDOR.
		/// </summary>
		PlatformVendor = Cl.PLATFORM_VENDOR,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_EXTENSIONS.
		/// </summary>
		PlatformExtensions = Cl.PLATFORM_EXTENSIONS,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_HOST_TIMER_RESOLUTION.
		/// </summary>
		PlatformHostTimerResolution = Cl.PLATFORM_HOST_TIMER_RESOLUTION,

	}

	/// <summary>
	/// Strongly typed enumeration cl_device_info.
	/// </summary>
	public enum cl_device_info
	{
		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE.
		/// </summary>
		DeviceType = Cl.DEVICE_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_VENDOR_ID.
		/// </summary>
		DeviceVendorId = Cl.DEVICE_VENDOR_ID,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_COMPUTE_UNITS.
		/// </summary>
		DeviceMaxComputeUnits = Cl.DEVICE_MAX_COMPUTE_UNITS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS.
		/// </summary>
		DeviceMaxWorkItemDimensions = Cl.DEVICE_MAX_WORK_ITEM_DIMENSIONS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WORK_GROUP_SIZE.
		/// </summary>
		DeviceMaxWorkGroupSize = Cl.DEVICE_MAX_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WORK_ITEM_SIZES.
		/// </summary>
		DeviceMaxWorkItemSizes = Cl.DEVICE_MAX_WORK_ITEM_SIZES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR.
		/// </summary>
		DevicePreferredVectorWidthChar = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_CHAR,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT.
		/// </summary>
		DevicePreferredVectorWidthShort = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_SHORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT.
		/// </summary>
		DevicePreferredVectorWidthInt = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_INT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG.
		/// </summary>
		DevicePreferredVectorWidthLong = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_LONG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT.
		/// </summary>
		DevicePreferredVectorWidthFloat = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE.
		/// </summary>
		DevicePreferredVectorWidthDouble = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_CLOCK_FREQUENCY.
		/// </summary>
		DeviceMaxClockFrequency = Cl.DEVICE_MAX_CLOCK_FREQUENCY,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_ADDRESS_BITS.
		/// </summary>
		DeviceAddressBits = Cl.DEVICE_ADDRESS_BITS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_READ_IMAGE_ARGS.
		/// </summary>
		DeviceMaxReadImageArgs = Cl.DEVICE_MAX_READ_IMAGE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WRITE_IMAGE_ARGS.
		/// </summary>
		DeviceMaxWriteImageArgs = Cl.DEVICE_MAX_WRITE_IMAGE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_MEM_ALLOC_SIZE.
		/// </summary>
		DeviceMaxMemAllocSize = Cl.DEVICE_MAX_MEM_ALLOC_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE2D_MAX_WIDTH.
		/// </summary>
		DeviceImage2dMaxWidth = Cl.DEVICE_IMAGE2D_MAX_WIDTH,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE2D_MAX_HEIGHT.
		/// </summary>
		DeviceImage2dMaxHeight = Cl.DEVICE_IMAGE2D_MAX_HEIGHT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE3D_MAX_WIDTH.
		/// </summary>
		DeviceImage3dMaxWidth = Cl.DEVICE_IMAGE3D_MAX_WIDTH,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE3D_MAX_HEIGHT.
		/// </summary>
		DeviceImage3dMaxHeight = Cl.DEVICE_IMAGE3D_MAX_HEIGHT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE3D_MAX_DEPTH.
		/// </summary>
		DeviceImage3dMaxDepth = Cl.DEVICE_IMAGE3D_MAX_DEPTH,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_SUPPORT.
		/// </summary>
		DeviceImageSupport = Cl.DEVICE_IMAGE_SUPPORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_PARAMETER_SIZE.
		/// </summary>
		DeviceMaxParameterSize = Cl.DEVICE_MAX_PARAMETER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_SAMPLERS.
		/// </summary>
		DeviceMaxSamplers = Cl.DEVICE_MAX_SAMPLERS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MEM_BASE_ADDR_ALIGN.
		/// </summary>
		DeviceMemBaseAddrAlign = Cl.DEVICE_MEM_BASE_ADDR_ALIGN,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE.
		/// </summary>
		DeviceMinDataTypeAlignSize = Cl.DEVICE_MIN_DATA_TYPE_ALIGN_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_SINGLE_FP_CONFIG.
		/// </summary>
		DeviceSingleFpConfig = Cl.DEVICE_SINGLE_FP_CONFIG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_CACHE_TYPE.
		/// </summary>
		DeviceGlobalMemCacheType = Cl.DEVICE_GLOBAL_MEM_CACHE_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE.
		/// </summary>
		DeviceGlobalMemCachelineSize = Cl.DEVICE_GLOBAL_MEM_CACHELINE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_CACHE_SIZE.
		/// </summary>
		DeviceGlobalMemCacheSize = Cl.DEVICE_GLOBAL_MEM_CACHE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_SIZE.
		/// </summary>
		DeviceGlobalMemSize = Cl.DEVICE_GLOBAL_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE.
		/// </summary>
		DeviceMaxConstantBufferSize = Cl.DEVICE_MAX_CONSTANT_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_CONSTANT_ARGS.
		/// </summary>
		DeviceMaxConstantArgs = Cl.DEVICE_MAX_CONSTANT_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_LOCAL_MEM_TYPE.
		/// </summary>
		DeviceLocalMemType = Cl.DEVICE_LOCAL_MEM_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_LOCAL_MEM_SIZE.
		/// </summary>
		DeviceLocalMemSize = Cl.DEVICE_LOCAL_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_ERROR_CORRECTION_SUPPORT.
		/// </summary>
		DeviceErrorCorrectionSupport = Cl.DEVICE_ERROR_CORRECTION_SUPPORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PROFILING_TIMER_RESOLUTION.
		/// </summary>
		DeviceProfilingTimerResolution = Cl.DEVICE_PROFILING_TIMER_RESOLUTION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_ENDIAN_LITTLE.
		/// </summary>
		DeviceEndianLittle = Cl.DEVICE_ENDIAN_LITTLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AVAILABLE.
		/// </summary>
		DeviceAvailable = Cl.DEVICE_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_COMPILER_AVAILABLE.
		/// </summary>
		DeviceCompilerAvailable = Cl.DEVICE_COMPILER_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_EXECUTION_CAPABILITIES.
		/// </summary>
		DeviceExecutionCapabilities = Cl.DEVICE_EXECUTION_CAPABILITIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_PROPERTIES, CL_DEVICE_QUEUE_ON_HOST_PROPERTIES.
		/// </summary>
		DeviceQueueProperties = Cl.DEVICE_QUEUE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NAME.
		/// </summary>
		DeviceName = Cl.DEVICE_NAME,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_VENDOR.
		/// </summary>
		DeviceVendor = Cl.DEVICE_VENDOR,

		/// <summary>
		/// Strongly typed for value CL_DRIVER_VERSION.
		/// </summary>
		DriverVersion = Cl.DRIVER_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PROFILE.
		/// </summary>
		DeviceProfile = Cl.DEVICE_PROFILE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_VERSION.
		/// </summary>
		DeviceVersion = Cl.DEVICE_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_EXTENSIONS.
		/// </summary>
		DeviceExtensions = Cl.DEVICE_EXTENSIONS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PLATFORM.
		/// </summary>
		DevicePlatform = Cl.DEVICE_PLATFORM,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_DOUBLE_FP_CONFIG.
		/// </summary>
		DeviceDoubleFpConfig = Cl.DEVICE_DOUBLE_FP_CONFIG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF.
		/// </summary>
		DevicePreferredVectorWidthHalf = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_HALF,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_HOST_UNIFIED_MEMORY.
		/// </summary>
		DeviceHostUnifiedMemory = Cl.DEVICE_HOST_UNIFIED_MEMORY,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR.
		/// </summary>
		DeviceNativeVectorWidthChar = Cl.DEVICE_NATIVE_VECTOR_WIDTH_CHAR,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT.
		/// </summary>
		DeviceNativeVectorWidthShort = Cl.DEVICE_NATIVE_VECTOR_WIDTH_SHORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_INT.
		/// </summary>
		DeviceNativeVectorWidthInt = Cl.DEVICE_NATIVE_VECTOR_WIDTH_INT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG.
		/// </summary>
		DeviceNativeVectorWidthLong = Cl.DEVICE_NATIVE_VECTOR_WIDTH_LONG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT.
		/// </summary>
		DeviceNativeVectorWidthFloat = Cl.DEVICE_NATIVE_VECTOR_WIDTH_FLOAT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE.
		/// </summary>
		DeviceNativeVectorWidthDouble = Cl.DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF.
		/// </summary>
		DeviceNativeVectorWidthHalf = Cl.DEVICE_NATIVE_VECTOR_WIDTH_HALF,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_OPENCL_C_VERSION.
		/// </summary>
		DeviceOpenclCVersion = Cl.DEVICE_OPENCL_C_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_LINKER_AVAILABLE.
		/// </summary>
		DeviceLinkerAvailable = Cl.DEVICE_LINKER_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_BUILT_IN_KERNELS.
		/// </summary>
		DeviceBuiltInKernels = Cl.DEVICE_BUILT_IN_KERNELS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_MAX_BUFFER_SIZE.
		/// </summary>
		DeviceImageMaxBufferSize = Cl.DEVICE_IMAGE_MAX_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_MAX_ARRAY_SIZE.
		/// </summary>
		DeviceImageMaxArraySize = Cl.DEVICE_IMAGE_MAX_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARENT_DEVICE.
		/// </summary>
		DeviceParentDevice = Cl.DEVICE_PARENT_DEVICE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_MAX_SUB_DEVICES.
		/// </summary>
		DevicePartitionMaxSubDevices = Cl.DEVICE_PARTITION_MAX_SUB_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_PROPERTIES.
		/// </summary>
		DevicePartitionProperties = Cl.DEVICE_PARTITION_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_AFFINITY_DOMAIN.
		/// </summary>
		DevicePartitionAffinityDomain = Cl.DEVICE_PARTITION_AFFINITY_DOMAIN,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_TYPE.
		/// </summary>
		DevicePartitionType = Cl.DEVICE_PARTITION_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_REFERENCE_COUNT.
		/// </summary>
		DeviceReferenceCount = Cl.DEVICE_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_INTEROP_USER_SYNC.
		/// </summary>
		DevicePreferredInteropUserSync = Cl.DEVICE_PREFERRED_INTEROP_USER_SYNC,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PRINTF_BUFFER_SIZE.
		/// </summary>
		DevicePrintfBufferSize = Cl.DEVICE_PRINTF_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_PITCH_ALIGNMENT.
		/// </summary>
		DeviceImagePitchAlignment = Cl.DEVICE_IMAGE_PITCH_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT.
		/// </summary>
		DeviceImageBaseAddressAlignment = Cl.DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS.
		/// </summary>
		DeviceMaxReadWriteImageArgs = Cl.DEVICE_MAX_READ_WRITE_IMAGE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE.
		/// </summary>
		DeviceMaxGlobalVariableSize = Cl.DEVICE_MAX_GLOBAL_VARIABLE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES.
		/// </summary>
		DeviceQueueOnDeviceProperties = Cl.DEVICE_QUEUE_ON_DEVICE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE.
		/// </summary>
		DeviceQueueOnDevicePreferredSize = Cl.DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE.
		/// </summary>
		DeviceQueueOnDeviceMaxSize = Cl.DEVICE_QUEUE_ON_DEVICE_MAX_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_ON_DEVICE_QUEUES.
		/// </summary>
		DeviceMaxOnDeviceQueues = Cl.DEVICE_MAX_ON_DEVICE_QUEUES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_ON_DEVICE_EVENTS.
		/// </summary>
		DeviceMaxOnDeviceEvents = Cl.DEVICE_MAX_ON_DEVICE_EVENTS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_SVM_CAPABILITIES.
		/// </summary>
		DeviceSvmCapabilities = Cl.DEVICE_SVM_CAPABILITIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE.
		/// </summary>
		DeviceGlobalVariablePreferredTotalSize = Cl.DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_PIPE_ARGS.
		/// </summary>
		DeviceMaxPipeArgs = Cl.DEVICE_MAX_PIPE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS.
		/// </summary>
		DevicePipeMaxActiveReservations = Cl.DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PIPE_MAX_PACKET_SIZE.
		/// </summary>
		DevicePipeMaxPacketSize = Cl.DEVICE_PIPE_MAX_PACKET_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT.
		/// </summary>
		DevicePreferredPlatformAtomicAlignment = Cl.DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT.
		/// </summary>
		DevicePreferredGlobalAtomicAlignment = Cl.DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT.
		/// </summary>
		DevicePreferredLocalAtomicAlignment = Cl.DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IL_VERSION.
		/// </summary>
		DeviceIlVersion = Cl.DEVICE_IL_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_NUM_SUB_GROUPS.
		/// </summary>
		DeviceMaxNumSubGroups = Cl.DEVICE_MAX_NUM_SUB_GROUPS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS.
		/// </summary>
		DeviceSubGroupIndependentForwardProgress = Cl.DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS,

	}

	/// <summary>
	/// Strongly typed enumeration cl_device_mem_cache_type.
	/// </summary>
	[Flags()]
	public enum cl_device_mem_cache_type : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_device_local_mem_type.
	/// </summary>
	[Flags()]
	public enum cl_device_local_mem_type : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_context_info.
	/// </summary>
	public enum cl_context_info
	{
		/// <summary>
		/// Strongly typed for value CL_CONTEXT_REFERENCE_COUNT.
		/// </summary>
		ContextReferenceCount = Cl.CONTEXT_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_DEVICES.
		/// </summary>
		ContextDevices = Cl.CONTEXT_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_PROPERTIES.
		/// </summary>
		ContextProperties = Cl.CONTEXT_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_NUM_DEVICES.
		/// </summary>
		ContextNumDevices = Cl.CONTEXT_NUM_DEVICES,

	}

	/// <summary>
	/// Strongly typed enumeration cl_context_properties.
	/// </summary>
	[Flags()]
	public enum cl_context_properties : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_command_queue_info.
	/// </summary>
	public enum cl_command_queue_info
	{
		/// <summary>
		/// Strongly typed for value CL_QUEUE_CONTEXT.
		/// </summary>
		QueueContext = Cl.QUEUE_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_DEVICE.
		/// </summary>
		QueueDevice = Cl.QUEUE_DEVICE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_REFERENCE_COUNT.
		/// </summary>
		QueueReferenceCount = Cl.QUEUE_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_PROPERTIES.
		/// </summary>
		QueueProperties = Cl.QUEUE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_SIZE.
		/// </summary>
		QueueSize = Cl.QUEUE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_DEVICE_DEFAULT.
		/// </summary>
		QueueDeviceDefault = Cl.QUEUE_DEVICE_DEFAULT,

	}

	/// <summary>
	/// Strongly typed enumeration cl_channel_order.
	/// </summary>
	[Flags()]
	public enum cl_channel_order : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_channel_type.
	/// </summary>
	[Flags()]
	public enum cl_channel_type : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_mem_object_type.
	/// </summary>
	public enum cl_mem_object_type
	{
		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_BUFFER.
		/// </summary>
		MemObjectBuffer = Cl.MEM_OBJECT_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE2D.
		/// </summary>
		MemObjectImage2d = Cl.MEM_OBJECT_IMAGE2D,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE3D.
		/// </summary>
		MemObjectImage3d = Cl.MEM_OBJECT_IMAGE3D,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE2D_ARRAY.
		/// </summary>
		MemObjectImage2dArray = Cl.MEM_OBJECT_IMAGE2D_ARRAY,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE1D.
		/// </summary>
		MemObjectImage1d = Cl.MEM_OBJECT_IMAGE1D,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE1D_ARRAY.
		/// </summary>
		MemObjectImage1dArray = Cl.MEM_OBJECT_IMAGE1D_ARRAY,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE1D_BUFFER.
		/// </summary>
		MemObjectImage1dBuffer = Cl.MEM_OBJECT_IMAGE1D_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_PIPE.
		/// </summary>
		MemObjectPipe = Cl.MEM_OBJECT_PIPE,

	}

	/// <summary>
	/// Strongly typed enumeration cl_mem_info.
	/// </summary>
	public enum cl_mem_info
	{
		/// <summary>
		/// Strongly typed for value CL_MEM_TYPE.
		/// </summary>
		MemType = Cl.MEM_TYPE,

		/// <summary>
		/// Strongly typed for value CL_MEM_FLAGS.
		/// </summary>
		MemFlags = Cl.MEM_FLAGS,

		/// <summary>
		/// Strongly typed for value CL_MEM_SIZE.
		/// </summary>
		MemSize = Cl.MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_MEM_HOST_PTR.
		/// </summary>
		MemHostPtr = Cl.MEM_HOST_PTR,

		/// <summary>
		/// Strongly typed for value CL_MEM_MAP_COUNT.
		/// </summary>
		MemMapCount = Cl.MEM_MAP_COUNT,

		/// <summary>
		/// Strongly typed for value CL_MEM_REFERENCE_COUNT.
		/// </summary>
		MemReferenceCount = Cl.MEM_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_MEM_CONTEXT.
		/// </summary>
		MemContext = Cl.MEM_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_MEM_ASSOCIATED_MEMOBJECT.
		/// </summary>
		MemAssociatedMemobject = Cl.MEM_ASSOCIATED_MEMOBJECT,

		/// <summary>
		/// Strongly typed for value CL_MEM_OFFSET.
		/// </summary>
		MemOffset = Cl.MEM_OFFSET,

		/// <summary>
		/// Strongly typed for value CL_MEM_USES_SVM_POINTER.
		/// </summary>
		MemUsesSvmPointer = Cl.MEM_USES_SVM_POINTER,

	}

	/// <summary>
	/// Strongly typed enumeration cl_image_info.
	/// </summary>
	public enum cl_image_info
	{
		/// <summary>
		/// Strongly typed for value CL_IMAGE_FORMAT.
		/// </summary>
		ImageFormat = Cl.IMAGE_FORMAT,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_ELEMENT_SIZE.
		/// </summary>
		ImageElementSize = Cl.IMAGE_ELEMENT_SIZE,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_ROW_PITCH.
		/// </summary>
		ImageRowPitch = Cl.IMAGE_ROW_PITCH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_SLICE_PITCH.
		/// </summary>
		ImageSlicePitch = Cl.IMAGE_SLICE_PITCH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_WIDTH.
		/// </summary>
		ImageWidth = Cl.IMAGE_WIDTH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_HEIGHT.
		/// </summary>
		ImageHeight = Cl.IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_DEPTH.
		/// </summary>
		ImageDepth = Cl.IMAGE_DEPTH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_ARRAY_SIZE.
		/// </summary>
		ImageArraySize = Cl.IMAGE_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_BUFFER.
		/// </summary>
		ImageBuffer = Cl.IMAGE_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_NUM_MIP_LEVELS.
		/// </summary>
		ImageNumMipLevels = Cl.IMAGE_NUM_MIP_LEVELS,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_NUM_SAMPLES.
		/// </summary>
		ImageNumSamples = Cl.IMAGE_NUM_SAMPLES,

		/// <summary>
		/// Strongly typed for value CL_PIPE_PACKET_SIZE.
		/// </summary>
		PipePacketSize = Cl.PIPE_PACKET_SIZE,

		/// <summary>
		/// Strongly typed for value CL_PIPE_MAX_PACKETS.
		/// </summary>
		PipeMaxPackets = Cl.PIPE_MAX_PACKETS,

	}

	/// <summary>
	/// Strongly typed enumeration cl_addressing_mode.
	/// </summary>
	[Flags()]
	public enum cl_addressing_mode : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_filter_mode.
	/// </summary>
	[Flags()]
	public enum cl_filter_mode : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_sampler_info.
	/// </summary>
	public enum cl_sampler_info
	{
		/// <summary>
		/// Strongly typed for value CL_SAMPLER_REFERENCE_COUNT.
		/// </summary>
		SamplerReferenceCount = Cl.SAMPLER_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_CONTEXT.
		/// </summary>
		SamplerContext = Cl.SAMPLER_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_NORMALIZED_COORDS.
		/// </summary>
		SamplerNormalizedCoords = Cl.SAMPLER_NORMALIZED_COORDS,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_ADDRESSING_MODE.
		/// </summary>
		SamplerAddressingMode = Cl.SAMPLER_ADDRESSING_MODE,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_FILTER_MODE.
		/// </summary>
		SamplerFilterMode = Cl.SAMPLER_FILTER_MODE,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_MIP_FILTER_MODE.
		/// </summary>
		SamplerMipFilterMode = Cl.SAMPLER_MIP_FILTER_MODE,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_LOD_MIN.
		/// </summary>
		SamplerLodMin = Cl.SAMPLER_LOD_MIN,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_LOD_MAX.
		/// </summary>
		SamplerLodMax = Cl.SAMPLER_LOD_MAX,

	}

	/// <summary>
	/// Strongly typed enumeration cl_program_info.
	/// </summary>
	public enum cl_program_info
	{
		/// <summary>
		/// Strongly typed for value CL_PROGRAM_REFERENCE_COUNT.
		/// </summary>
		ProgramReferenceCount = Cl.PROGRAM_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_CONTEXT.
		/// </summary>
		ProgramContext = Cl.PROGRAM_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_NUM_DEVICES.
		/// </summary>
		ProgramNumDevices = Cl.PROGRAM_NUM_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_DEVICES.
		/// </summary>
		ProgramDevices = Cl.PROGRAM_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_SOURCE.
		/// </summary>
		ProgramSource = Cl.PROGRAM_SOURCE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_SIZES.
		/// </summary>
		ProgramBinarySizes = Cl.PROGRAM_BINARY_SIZES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARIES.
		/// </summary>
		ProgramBinaries = Cl.PROGRAM_BINARIES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_NUM_KERNELS.
		/// </summary>
		ProgramNumKernels = Cl.PROGRAM_NUM_KERNELS,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_KERNEL_NAMES.
		/// </summary>
		ProgramKernelNames = Cl.PROGRAM_KERNEL_NAMES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_IL.
		/// </summary>
		ProgramIl = Cl.PROGRAM_IL,

	}

	/// <summary>
	/// Strongly typed enumeration cl_program_build_info.
	/// </summary>
	public enum cl_program_build_info
	{
		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_STATUS.
		/// </summary>
		ProgramBuildStatus = Cl.PROGRAM_BUILD_STATUS,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_OPTIONS.
		/// </summary>
		ProgramBuildOptions = Cl.PROGRAM_BUILD_OPTIONS,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_LOG.
		/// </summary>
		ProgramBuildLog = Cl.PROGRAM_BUILD_LOG,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE.
		/// </summary>
		ProgramBinaryType = Cl.PROGRAM_BINARY_TYPE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE.
		/// </summary>
		ProgramBuildGlobalVariableTotalSize = Cl.PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_NONE.
		/// </summary>
		ProgramBinaryTypeNone = Cl.PROGRAM_BINARY_TYPE_NONE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT.
		/// </summary>
		ProgramBinaryTypeCompiledObject = Cl.PROGRAM_BINARY_TYPE_COMPILED_OBJECT,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_LIBRARY.
		/// </summary>
		ProgramBinaryTypeLibrary = Cl.PROGRAM_BINARY_TYPE_LIBRARY,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_EXECUTABLE.
		/// </summary>
		ProgramBinaryTypeExecutable = Cl.PROGRAM_BINARY_TYPE_EXECUTABLE,

	}

	/// <summary>
	/// Strongly typed enumeration cl_build_status.
	/// </summary>
	[Flags()]
	public enum cl_build_status : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_kernel_info.
	/// </summary>
	public enum cl_kernel_info
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_FUNCTION_NAME.
		/// </summary>
		KernelFunctionName = Cl.KERNEL_FUNCTION_NAME,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_NUM_ARGS.
		/// </summary>
		KernelNumArgs = Cl.KERNEL_NUM_ARGS,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_REFERENCE_COUNT.
		/// </summary>
		KernelReferenceCount = Cl.KERNEL_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_CONTEXT.
		/// </summary>
		KernelContext = Cl.KERNEL_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_PROGRAM.
		/// </summary>
		KernelProgram = Cl.KERNEL_PROGRAM,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ATTRIBUTES.
		/// </summary>
		KernelAttributes = Cl.KERNEL_ATTRIBUTES,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_MAX_NUM_SUB_GROUPS.
		/// </summary>
		KernelMaxNumSubGroups = Cl.KERNEL_MAX_NUM_SUB_GROUPS,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_COMPILE_NUM_SUB_GROUPS.
		/// </summary>
		KernelCompileNumSubGroups = Cl.KERNEL_COMPILE_NUM_SUB_GROUPS,

	}

	/// <summary>
	/// Strongly typed enumeration cl_kernel_arg_info.
	/// </summary>
	public enum cl_kernel_arg_info
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ADDRESS_QUALIFIER.
		/// </summary>
		KernelArgAddressQualifier = Cl.KERNEL_ARG_ADDRESS_QUALIFIER,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ACCESS_QUALIFIER.
		/// </summary>
		KernelArgAccessQualifier = Cl.KERNEL_ARG_ACCESS_QUALIFIER,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_NAME.
		/// </summary>
		KernelArgTypeName = Cl.KERNEL_ARG_TYPE_NAME,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_QUALIFIER.
		/// </summary>
		KernelArgTypeQualifier = Cl.KERNEL_ARG_TYPE_QUALIFIER,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_NAME.
		/// </summary>
		KernelArgName = Cl.KERNEL_ARG_NAME,

	}

	/// <summary>
	/// Strongly typed enumeration cl_kernel_arg_address_qualifier.
	/// </summary>
	[Flags()]
	public enum cl_kernel_arg_address_qualifier : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_kernel_arg_access_qualifier.
	/// </summary>
	[Flags()]
	public enum cl_kernel_arg_access_qualifier : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_kernel_work_group_info.
	/// </summary>
	public enum cl_kernel_work_group_info
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_WORK_GROUP_SIZE.
		/// </summary>
		KernelWorkGroupSize = Cl.KERNEL_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_COMPILE_WORK_GROUP_SIZE.
		/// </summary>
		KernelCompileWorkGroupSize = Cl.KERNEL_COMPILE_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_LOCAL_MEM_SIZE.
		/// </summary>
		KernelLocalMemSize = Cl.KERNEL_LOCAL_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE.
		/// </summary>
		KernelPreferredWorkGroupSizeMultiple = Cl.KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_PRIVATE_MEM_SIZE.
		/// </summary>
		KernelPrivateMemSize = Cl.KERNEL_PRIVATE_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_GLOBAL_WORK_SIZE.
		/// </summary>
		KernelGlobalWorkSize = Cl.KERNEL_GLOBAL_WORK_SIZE,

	}

	/// <summary>
	/// Strongly typed enumeration cl_kernel_sub_group_info.
	/// </summary>
	public enum cl_kernel_sub_group_info
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE.
		/// </summary>
		KernelMaxSubGroupSizeForNdrange = Cl.KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE.
		/// </summary>
		KernelSubGroupCountForNdrange = Cl.KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT.
		/// </summary>
		KernelLocalSizeForSubGroupCount = Cl.KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_EXEC_INFO_SVM_PTRS.
		/// </summary>
		KernelExecInfoSvmPtrs = Cl.KERNEL_EXEC_INFO_SVM_PTRS,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM.
		/// </summary>
		KernelExecInfoSvmFineGrainSystem = Cl.KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM,

	}

	/// <summary>
	/// Strongly typed enumeration cl_event_info.
	/// </summary>
	public enum cl_event_info
	{
		/// <summary>
		/// Strongly typed for value CL_EVENT_COMMAND_QUEUE.
		/// </summary>
		EventCommandQueue = Cl.EVENT_COMMAND_QUEUE,

		/// <summary>
		/// Strongly typed for value CL_EVENT_COMMAND_TYPE.
		/// </summary>
		EventCommandType = Cl.EVENT_COMMAND_TYPE,

		/// <summary>
		/// Strongly typed for value CL_EVENT_REFERENCE_COUNT.
		/// </summary>
		EventReferenceCount = Cl.EVENT_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_EVENT_COMMAND_EXECUTION_STATUS.
		/// </summary>
		EventCommandExecutionStatus = Cl.EVENT_COMMAND_EXECUTION_STATUS,

		/// <summary>
		/// Strongly typed for value CL_EVENT_CONTEXT.
		/// </summary>
		EventContext = Cl.EVENT_CONTEXT,

	}

	/// <summary>
	/// Strongly typed enumeration cl_command_type.
	/// </summary>
	[Flags()]
	public enum cl_command_type : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration cl_buffer_create_type.
	/// </summary>
	public enum cl_buffer_create_type
	{
		/// <summary>
		/// Strongly typed for value CL_BUFFER_CREATE_TYPE_REGION.
		/// </summary>
		BufferCreateTypeRegion = Cl.BUFFER_CREATE_TYPE_REGION,

	}

	/// <summary>
	/// Strongly typed enumeration cl_profiling_info.
	/// </summary>
	public enum cl_profiling_info
	{
		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_QUEUED.
		/// </summary>
		ProfilingCommandQueued = Cl.PROFILING_COMMAND_QUEUED,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_SUBMIT.
		/// </summary>
		ProfilingCommandSubmit = Cl.PROFILING_COMMAND_SUBMIT,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_START.
		/// </summary>
		ProfilingCommandStart = Cl.PROFILING_COMMAND_START,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_END.
		/// </summary>
		ProfilingCommandEnd = Cl.PROFILING_COMMAND_END,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_COMPLETE.
		/// </summary>
		ProfilingCommandComplete = Cl.PROFILING_COMMAND_COMPLETE,

	}


	}


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
		/// Value of CL_PLATFORM_PROFILE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PLATFORM_PROFILE = 0x0900;

		/// <summary>
		/// Value of CL_PLATFORM_VERSION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PLATFORM_VERSION = 0x0901;

		/// <summary>
		/// Value of CL_PLATFORM_NAME symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PLATFORM_NAME = 0x0902;

		/// <summary>
		/// Value of CL_PLATFORM_VENDOR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PLATFORM_VENDOR = 0x0903;

		/// <summary>
		/// Value of CL_PLATFORM_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PLATFORM_EXTENSIONS = 0x0904;

		/// <summary>
		/// Value of CL_PLATFORM_HOST_TIMER_RESOLUTION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PLATFORM_HOST_TIMER_RESOLUTION = 0x0905;

		/// <summary>
		/// Value of CL_DEVICE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_TYPE = 0x1000;

		/// <summary>
		/// Value of CL_DEVICE_VENDOR_ID symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_VENDOR_ID = 0x1001;

		/// <summary>
		/// Value of CL_DEVICE_MAX_COMPUTE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_COMPUTE_UNITS = 0x1002;

		/// <summary>
		/// Value of CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003;

		/// <summary>
		/// Value of CL_DEVICE_MAX_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WORK_GROUP_SIZE = 0x1004;

		/// <summary>
		/// Value of CL_DEVICE_MAX_WORK_ITEM_SIZES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WORK_ITEM_SIZES = 0x1005;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_CHAR = 0x1006;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_SHORT = 0x1007;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_INT = 0x1008;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_LONG = 0x1009;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT = 0x100A;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE = 0x100B;

		/// <summary>
		/// Value of CL_DEVICE_MAX_CLOCK_FREQUENCY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_CLOCK_FREQUENCY = 0x100C;

		/// <summary>
		/// Value of CL_DEVICE_ADDRESS_BITS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_ADDRESS_BITS = 0x100D;

		/// <summary>
		/// Value of CL_DEVICE_MAX_READ_IMAGE_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_READ_IMAGE_ARGS = 0x100E;

		/// <summary>
		/// Value of CL_DEVICE_MAX_WRITE_IMAGE_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F;

		/// <summary>
		/// Value of CL_DEVICE_MAX_MEM_ALLOC_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE2D_MAX_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE2D_MAX_WIDTH = 0x1011;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE2D_MAX_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE3D_MAX_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE3D_MAX_WIDTH = 0x1013;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE3D_MAX_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE3D_MAX_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE3D_MAX_DEPTH = 0x1015;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE_SUPPORT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_SUPPORT = 0x1016;

		/// <summary>
		/// Value of CL_DEVICE_MAX_PARAMETER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_PARAMETER_SIZE = 0x1017;

		/// <summary>
		/// Value of CL_DEVICE_MAX_SAMPLERS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_SAMPLERS = 0x1018;

		/// <summary>
		/// Value of CL_DEVICE_MEM_BASE_ADDR_ALIGN symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019;

		/// <summary>
		/// Value of CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A;

		/// <summary>
		/// Value of CL_DEVICE_SINGLE_FP_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SINGLE_FP_CONFIG = 0x101B;

		/// <summary>
		/// Value of CL_DEVICE_GLOBAL_MEM_CACHE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C;

		/// <summary>
		/// Value of CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D;

		/// <summary>
		/// Value of CL_DEVICE_GLOBAL_MEM_CACHE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E;

		/// <summary>
		/// Value of CL_DEVICE_GLOBAL_MEM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_SIZE = 0x101F;

		/// <summary>
		/// Value of CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020;

		/// <summary>
		/// Value of CL_DEVICE_MAX_CONSTANT_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_CONSTANT_ARGS = 0x1021;

		/// <summary>
		/// Value of CL_DEVICE_LOCAL_MEM_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_LOCAL_MEM_TYPE = 0x1022;

		/// <summary>
		/// Value of CL_DEVICE_LOCAL_MEM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_LOCAL_MEM_SIZE = 0x1023;

		/// <summary>
		/// Value of CL_DEVICE_ERROR_CORRECTION_SUPPORT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024;

		/// <summary>
		/// Value of CL_DEVICE_PROFILING_TIMER_RESOLUTION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025;

		/// <summary>
		/// Value of CL_DEVICE_ENDIAN_LITTLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_ENDIAN_LITTLE = 0x1026;

		/// <summary>
		/// Value of CL_DEVICE_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AVAILABLE = 0x1027;

		/// <summary>
		/// Value of CL_DEVICE_COMPILER_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_COMPILER_AVAILABLE = 0x1028;

		/// <summary>
		/// Value of CL_DEVICE_EXECUTION_CAPABILITIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_EXECUTION_CAPABILITIES = 0x1029;

		/// <summary>
		/// Value of CL_DEVICE_QUEUE_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_PROPERTIES = 0x102A;

		/// <summary>
		/// Value of CL_DEVICE_QUEUE_ON_HOST_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_HOST_PROPERTIES = 0x102A;

		/// <summary>
		/// Value of CL_DEVICE_NAME symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NAME = 0x102B;

		/// <summary>
		/// Value of CL_DEVICE_VENDOR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_VENDOR = 0x102C;

		/// <summary>
		/// Value of CL_DRIVER_VERSION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DRIVER_VERSION = 0x102D;

		/// <summary>
		/// Value of CL_DEVICE_PROFILE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PROFILE = 0x102E;

		/// <summary>
		/// Value of CL_DEVICE_VERSION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_VERSION = 0x102F;

		/// <summary>
		/// Value of CL_DEVICE_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_EXTENSIONS = 0x1030;

		/// <summary>
		/// Value of CL_DEVICE_PLATFORM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PLATFORM = 0x1031;

		/// <summary>
		/// Value of CL_DEVICE_DOUBLE_FP_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_DOUBLE_FP_CONFIG = 0x1032;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_VECTOR_WIDTH_HALF = 0x1034;

		/// <summary>
		/// Value of CL_DEVICE_HOST_UNIFIED_MEMORY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_HOST_UNIFIED_MEMORY = 0x1035;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_CHAR = 0x1036;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_SHORT = 0x1037;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_INT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_INT = 0x1038;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_LONG = 0x1039;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_FLOAT = 0x103A;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE = 0x103B;

		/// <summary>
		/// Value of CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NATIVE_VECTOR_WIDTH_HALF = 0x103C;

		/// <summary>
		/// Value of CL_DEVICE_OPENCL_C_VERSION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_OPENCL_C_VERSION = 0x103D;

		/// <summary>
		/// Value of CL_DEVICE_LINKER_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_LINKER_AVAILABLE = 0x103E;

		/// <summary>
		/// Value of CL_DEVICE_BUILT_IN_KERNELS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_BUILT_IN_KERNELS = 0x103F;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE_MAX_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_MAX_BUFFER_SIZE = 0x1040;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE_MAX_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_MAX_ARRAY_SIZE = 0x1041;

		/// <summary>
		/// Value of CL_DEVICE_PARENT_DEVICE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARENT_DEVICE = 0x1042;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_MAX_SUB_DEVICES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_MAX_SUB_DEVICES = 0x1043;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_PROPERTIES = 0x1044;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_AFFINITY_DOMAIN symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_AFFINITY_DOMAIN = 0x1045;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_TYPE = 0x1046;

		/// <summary>
		/// Value of CL_DEVICE_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_REFERENCE_COUNT = 0x1047;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_INTEROP_USER_SYNC symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_INTEROP_USER_SYNC = 0x1048;

		/// <summary>
		/// Value of CL_DEVICE_PRINTF_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PRINTF_BUFFER_SIZE = 0x1049;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE_PITCH_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_PITCH_ALIGNMENT = 0x104A;

		/// <summary>
		/// Value of CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT = 0x104B;

		/// <summary>
		/// Value of CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_READ_WRITE_IMAGE_ARGS = 0x104C;

		/// <summary>
		/// Value of CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_GLOBAL_VARIABLE_SIZE = 0x104D;

		/// <summary>
		/// Value of CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_DEVICE_PROPERTIES = 0x104E;

		/// <summary>
		/// Value of CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE = 0x104F;

		/// <summary>
		/// Value of CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_DEVICE_MAX_SIZE = 0x1050;

		/// <summary>
		/// Value of CL_DEVICE_MAX_ON_DEVICE_QUEUES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_ON_DEVICE_QUEUES = 0x1051;

		/// <summary>
		/// Value of CL_DEVICE_MAX_ON_DEVICE_EVENTS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_ON_DEVICE_EVENTS = 0x1052;

		/// <summary>
		/// Value of CL_DEVICE_SVM_CAPABILITIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SVM_CAPABILITIES = 0x1053;

		/// <summary>
		/// Value of CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE = 0x1054;

		/// <summary>
		/// Value of CL_DEVICE_MAX_PIPE_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_PIPE_ARGS = 0x1055;

		/// <summary>
		/// Value of CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS = 0x1056;

		/// <summary>
		/// Value of CL_DEVICE_PIPE_MAX_PACKET_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PIPE_MAX_PACKET_SIZE = 0x1057;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT = 0x1058;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT = 0x1059;

		/// <summary>
		/// Value of CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT = 0x105A;

		/// <summary>
		/// Value of CL_DEVICE_IL_VERSION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IL_VERSION = 0x105B;

		/// <summary>
		/// Value of CL_DEVICE_MAX_NUM_SUB_GROUPS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_NUM_SUB_GROUPS = 0x105C;

		/// <summary>
		/// Value of CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS = 0x105D;

		/// <summary>
		/// Value of CL_CONTEXT_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_REFERENCE_COUNT = 0x1080;

		/// <summary>
		/// Value of CL_CONTEXT_DEVICES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_DEVICES = 0x1081;

		/// <summary>
		/// Value of CL_CONTEXT_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_PROPERTIES = 0x1082;

		/// <summary>
		/// Value of CL_CONTEXT_NUM_DEVICES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_NUM_DEVICES = 0x1083;

		/// <summary>
		/// Value of CL_QUEUE_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_CONTEXT = 0x1090;

		/// <summary>
		/// Value of CL_QUEUE_DEVICE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_DEVICE = 0x1091;

		/// <summary>
		/// Value of CL_QUEUE_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_REFERENCE_COUNT = 0x1092;

		/// <summary>
		/// Value of CL_QUEUE_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_PROPERTIES = 0x1093;

		/// <summary>
		/// Value of CL_QUEUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_SIZE = 0x1094;

		/// <summary>
		/// Value of CL_QUEUE_DEVICE_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_DEVICE_DEFAULT = 0x1095;

		/// <summary>
		/// Value of CL_MEM_OBJECT_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_BUFFER = 0x10F0;

		/// <summary>
		/// Value of CL_MEM_OBJECT_IMAGE2D symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE2D = 0x10F1;

		/// <summary>
		/// Value of CL_MEM_OBJECT_IMAGE3D symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE3D = 0x10F2;

		/// <summary>
		/// Value of CL_MEM_OBJECT_IMAGE2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE2D_ARRAY = 0x10F3;

		/// <summary>
		/// Value of CL_MEM_OBJECT_IMAGE1D symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE1D = 0x10F4;

		/// <summary>
		/// Value of CL_MEM_OBJECT_IMAGE1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE1D_ARRAY = 0x10F5;

		/// <summary>
		/// Value of CL_MEM_OBJECT_IMAGE1D_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE1D_BUFFER = 0x10F6;

		/// <summary>
		/// Value of CL_MEM_OBJECT_PIPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_PIPE = 0x10F7;

		/// <summary>
		/// Value of CL_MEM_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_TYPE = 0x1100;

		/// <summary>
		/// Value of CL_MEM_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_FLAGS = 0x1101;

		/// <summary>
		/// Value of CL_MEM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_SIZE = 0x1102;

		/// <summary>
		/// Value of CL_MEM_HOST_PTR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_HOST_PTR = 0x1103;

		/// <summary>
		/// Value of CL_MEM_MAP_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_MAP_COUNT = 0x1104;

		/// <summary>
		/// Value of CL_MEM_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_REFERENCE_COUNT = 0x1105;

		/// <summary>
		/// Value of CL_MEM_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_CONTEXT = 0x1106;

		/// <summary>
		/// Value of CL_MEM_ASSOCIATED_MEMOBJECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_ASSOCIATED_MEMOBJECT = 0x1107;

		/// <summary>
		/// Value of CL_MEM_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OFFSET = 0x1108;

		/// <summary>
		/// Value of CL_MEM_USES_SVM_POINTER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_USES_SVM_POINTER = 0x1109;

		/// <summary>
		/// Value of CL_IMAGE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_FORMAT = 0x1110;

		/// <summary>
		/// Value of CL_IMAGE_ELEMENT_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_ELEMENT_SIZE = 0x1111;

		/// <summary>
		/// Value of CL_IMAGE_ROW_PITCH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_ROW_PITCH = 0x1112;

		/// <summary>
		/// Value of CL_IMAGE_SLICE_PITCH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_SLICE_PITCH = 0x1113;

		/// <summary>
		/// Value of CL_IMAGE_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_WIDTH = 0x1114;

		/// <summary>
		/// Value of CL_IMAGE_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_HEIGHT = 0x1115;

		/// <summary>
		/// Value of CL_IMAGE_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_DEPTH = 0x1116;

		/// <summary>
		/// Value of CL_IMAGE_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_ARRAY_SIZE = 0x1117;

		/// <summary>
		/// Value of CL_IMAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_BUFFER = 0x1118;

		/// <summary>
		/// Value of CL_IMAGE_NUM_MIP_LEVELS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_NUM_MIP_LEVELS = 0x1119;

		/// <summary>
		/// Value of CL_IMAGE_NUM_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_NUM_SAMPLES = 0x111A;

		/// <summary>
		/// Value of CL_PIPE_PACKET_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PIPE_PACKET_SIZE = 0x1120;

		/// <summary>
		/// Value of CL_PIPE_MAX_PACKETS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PIPE_MAX_PACKETS = 0x1121;

		/// <summary>
		/// Value of CL_SAMPLER_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_REFERENCE_COUNT = 0x1150;

		/// <summary>
		/// Value of CL_SAMPLER_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_CONTEXT = 0x1151;

		/// <summary>
		/// Value of CL_SAMPLER_NORMALIZED_COORDS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_NORMALIZED_COORDS = 0x1152;

		/// <summary>
		/// Value of CL_SAMPLER_ADDRESSING_MODE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_ADDRESSING_MODE = 0x1153;

		/// <summary>
		/// Value of CL_SAMPLER_FILTER_MODE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_FILTER_MODE = 0x1154;

		/// <summary>
		/// Value of CL_SAMPLER_MIP_FILTER_MODE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_MIP_FILTER_MODE = 0x1155;

		/// <summary>
		/// Value of CL_SAMPLER_LOD_MIN symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_LOD_MIN = 0x1156;

		/// <summary>
		/// Value of CL_SAMPLER_LOD_MAX symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_LOD_MAX = 0x1157;

		/// <summary>
		/// Value of CL_PROGRAM_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_REFERENCE_COUNT = 0x1160;

		/// <summary>
		/// Value of CL_PROGRAM_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_CONTEXT = 0x1161;

		/// <summary>
		/// Value of CL_PROGRAM_NUM_DEVICES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_NUM_DEVICES = 0x1162;

		/// <summary>
		/// Value of CL_PROGRAM_DEVICES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_DEVICES = 0x1163;

		/// <summary>
		/// Value of CL_PROGRAM_SOURCE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_SOURCE = 0x1164;

		/// <summary>
		/// Value of CL_PROGRAM_BINARY_SIZES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_SIZES = 0x1165;

		/// <summary>
		/// Value of CL_PROGRAM_BINARIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARIES = 0x1166;

		/// <summary>
		/// Value of CL_PROGRAM_NUM_KERNELS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_NUM_KERNELS = 0x1167;

		/// <summary>
		/// Value of CL_PROGRAM_KERNEL_NAMES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_KERNEL_NAMES = 0x1168;

		/// <summary>
		/// Value of CL_PROGRAM_IL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_IL = 0x1169;

		/// <summary>
		/// Value of CL_PROGRAM_BUILD_STATUS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BUILD_STATUS = 0x1181;

		/// <summary>
		/// Value of CL_PROGRAM_BUILD_OPTIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BUILD_OPTIONS = 0x1182;

		/// <summary>
		/// Value of CL_PROGRAM_BUILD_LOG symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BUILD_LOG = 0x1183;

		/// <summary>
		/// Value of CL_PROGRAM_BINARY_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_TYPE = 0x1184;

		/// <summary>
		/// Value of CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE = 0x1185;

		/// <summary>
		/// Value of CL_PROGRAM_BINARY_TYPE_NONE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_TYPE_NONE = 0x0;

		/// <summary>
		/// Value of CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_TYPE_COMPILED_OBJECT = 0x1;

		/// <summary>
		/// Value of CL_PROGRAM_BINARY_TYPE_LIBRARY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_TYPE_LIBRARY = 0x2;

		/// <summary>
		/// Value of CL_PROGRAM_BINARY_TYPE_EXECUTABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_TYPE_EXECUTABLE = 0x4;

		/// <summary>
		/// Value of CL_KERNEL_FUNCTION_NAME symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_FUNCTION_NAME = 0x1190;

		/// <summary>
		/// Value of CL_KERNEL_NUM_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_NUM_ARGS = 0x1191;

		/// <summary>
		/// Value of CL_KERNEL_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_REFERENCE_COUNT = 0x1192;

		/// <summary>
		/// Value of CL_KERNEL_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_CONTEXT = 0x1193;

		/// <summary>
		/// Value of CL_KERNEL_PROGRAM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_PROGRAM = 0x1194;

		/// <summary>
		/// Value of CL_KERNEL_ATTRIBUTES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ATTRIBUTES = 0x1195;

		/// <summary>
		/// Value of CL_KERNEL_MAX_NUM_SUB_GROUPS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_MAX_NUM_SUB_GROUPS = 0x11B9;

		/// <summary>
		/// Value of CL_KERNEL_COMPILE_NUM_SUB_GROUPS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_COMPILE_NUM_SUB_GROUPS = 0x11BA;

		/// <summary>
		/// Value of CL_KERNEL_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_WORK_GROUP_SIZE = 0x11B0;

		/// <summary>
		/// Value of CL_KERNEL_COMPILE_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_COMPILE_WORK_GROUP_SIZE = 0x11B1;

		/// <summary>
		/// Value of CL_KERNEL_LOCAL_MEM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_LOCAL_MEM_SIZE = 0x11B2;

		/// <summary>
		/// Value of CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x11B3;

		/// <summary>
		/// Value of CL_KERNEL_PRIVATE_MEM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_PRIVATE_MEM_SIZE = 0x11B4;

		/// <summary>
		/// Value of CL_KERNEL_GLOBAL_WORK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_GLOBAL_WORK_SIZE = 0x11B5;

		/// <summary>
		/// Value of CL_EVENT_COMMAND_QUEUE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_COMMAND_QUEUE = 0x11D0;

		/// <summary>
		/// Value of CL_EVENT_COMMAND_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_COMMAND_TYPE = 0x11D1;

		/// <summary>
		/// Value of CL_EVENT_REFERENCE_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_REFERENCE_COUNT = 0x11D2;

		/// <summary>
		/// Value of CL_EVENT_COMMAND_EXECUTION_STATUS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_COMMAND_EXECUTION_STATUS = 0x11D3;

		/// <summary>
		/// Value of CL_EVENT_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_CONTEXT = 0x11D4;

		/// <summary>
		/// Value of CL_PROFILING_COMMAND_QUEUED symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_QUEUED = 0x1280;

		/// <summary>
		/// Value of CL_PROFILING_COMMAND_SUBMIT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_SUBMIT = 0x1281;

		/// <summary>
		/// Value of CL_PROFILING_COMMAND_START symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_START = 0x1282;

		/// <summary>
		/// Value of CL_PROFILING_COMMAND_END symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_END = 0x1283;

		/// <summary>
		/// Value of CL_PROFILING_COMMAND_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_COMPLETE = 0x1284;

		/// <summary>
		/// Value of CL_FALSE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[RequiredByFeature("CL_VERSION_1_1")]
		[RequiredByFeature("CL_VERSION_2_0")]
		public const int FALSE = 0;

		/// <summary>
		/// Value of CL_TRUE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[RequiredByFeature("CL_VERSION_1_1")]
		[RequiredByFeature("CL_VERSION_2_0")]
		public const int TRUE = 1;

		/// <summary>
		/// Value of CL_BLOCKING symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[RequiredByFeature("CL_VERSION_1_1")]
		[RequiredByFeature("CL_VERSION_2_0")]
		public const int BLOCKING = Cl.TRUE;

		/// <summary>
		/// Value of CL_NON_BLOCKING symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[RequiredByFeature("CL_VERSION_1_1")]
		[RequiredByFeature("CL_VERSION_2_0")]
		public const int NON_BLOCKING = Cl.FALSE;

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformIDs(uint num_entries, [Out] IntPtr[] platforms, [Out] uint[] num_platforms)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_platforms = platforms)
				fixed (uint* p_num_platforms = num_platforms)
				{
					Debug.Assert(Delegates.pclGetPlatformIDs != null, "pclGetPlatformIDs not implemented");
					retValue = Delegates.pclGetPlatformIDs(num_entries, p_platforms, p_num_platforms);
					LogFunction("clGetPlatformIDs({0}, {1}, {2}) = {3}", num_entries, LogValue(platforms), LogValue(num_platforms), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformInfo(Int32 platform, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetPlatformInfo != null, "pclGetPlatformInfo not implemented");
					retValue = Delegates.pclGetPlatformInfo(platform, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetPlatformInfo({0}, {1}, {2}, {3}, {4}) = {5}", platform, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetDeviceIDs(Int32 platform, ulong device_type, uint num_entries, [Out] IntPtr[] devices, [Out] uint[] num_devices)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_devices = devices)
				fixed (uint* p_num_devices = num_devices)
				{
					Debug.Assert(Delegates.pclGetDeviceIDs != null, "pclGetDeviceIDs not implemented");
					retValue = Delegates.pclGetDeviceIDs(platform, device_type, num_entries, p_devices, p_num_devices);
					LogFunction("clGetDeviceIDs({0}, {1}, {2}, {3}, {4}) = {5}", platform, device_type, num_entries, LogValue(devices), LogValue(num_devices), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetDeviceInfo(Int32 device, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetDeviceInfo != null, "pclGetDeviceInfo not implemented");
					retValue = Delegates.pclGetDeviceInfo(device, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetDeviceInfo({0}, {1}, {2}, {3}, {4}) = {5}", device, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateContext(cl_context_properties [] properties, uint num_devices, IntPtr[] devices, Int32 pfn_notify, Int32 user_data, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (cl_context_properties * p_properties = properties)
				fixed (IntPtr* p_devices = devices)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateContext != null, "pclCreateContext not implemented");
					retValue = Delegates.pclCreateContext(p_properties, num_devices, p_devices, pfn_notify, user_data, p_errcode_ret);
					LogFunction("clCreateContext({0}, {1}, {2}, {3}, {4}, {5}) = {6}", LogValue(properties), num_devices, LogValue(devices), pfn_notify, user_data, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateContextFromType(cl_context_properties [] properties, ulong device_type, Int32 user_data, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (cl_context_properties * p_properties = properties)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateContextFromType != null, "pclCreateContextFromType not implemented");
					retValue = Delegates.pclCreateContextFromType(p_properties, device_type, user_data, p_errcode_ret);
					LogFunction("clCreateContextFromType({0}, {1}, {2}, {3}) = {4}", LogValue(properties), device_type, user_data, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainContext(Int32 context)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainContext != null, "pclRetainContext not implemented");
			retValue = Delegates.pclRetainContext(context);
			LogFunction("clRetainContext({0}) = {1}", context, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseContext(Int32 context)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseContext != null, "pclReleaseContext not implemented");
			retValue = Delegates.pclReleaseContext(context);
			LogFunction("clReleaseContext({0}) = {1}", context, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetContextInfo(Int32 context, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetContextInfo != null, "pclGetContextInfo not implemented");
					retValue = Delegates.pclGetContextInfo(context, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetContextInfo({0}, {1}, {2}, {3}, {4}) = {5}", context, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainCommandQueue(Int32 command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainCommandQueue != null, "pclRetainCommandQueue not implemented");
			retValue = Delegates.pclRetainCommandQueue(command_queue);
			LogFunction("clRetainCommandQueue({0}) = {1}", command_queue, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseCommandQueue(Int32 command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseCommandQueue != null, "pclReleaseCommandQueue not implemented");
			retValue = Delegates.pclReleaseCommandQueue(command_queue);
			LogFunction("clReleaseCommandQueue({0}) = {1}", command_queue, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetCommandQueueInfo(Int32 command_queue, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetCommandQueueInfo != null, "pclGetCommandQueueInfo not implemented");
					retValue = Delegates.pclGetCommandQueueInfo(command_queue, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetCommandQueueInfo({0}, {1}, {2}, {3}, {4}) = {5}", command_queue, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateBuffer(Int32 context, ulong flags, uint size, Int32 host_ptr, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateBuffer != null, "pclCreateBuffer not implemented");
					retValue = Delegates.pclCreateBuffer(context, flags, size, host_ptr, p_errcode_ret);
					LogFunction("clCreateBuffer({0}, {1}, {2}, {3}, {4}) = {5}", context, flags, size, host_ptr, LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainMemObject(Int32 memobj)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainMemObject != null, "pclRetainMemObject not implemented");
			retValue = Delegates.pclRetainMemObject(memobj);
			LogFunction("clRetainMemObject({0}) = {1}", memobj, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseMemObject(Int32 memobj)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseMemObject != null, "pclReleaseMemObject not implemented");
			retValue = Delegates.pclReleaseMemObject(memobj);
			LogFunction("clReleaseMemObject({0}) = {1}", memobj, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetSupportedImageFormats(Int32 context, ulong flags, uint image_type, uint num_entries, [Out] Cl.ImageFormat[] image_formats, [Out] uint[] num_image_formats)
		{
			int retValue;

			unsafe {
				fixed (Cl.ImageFormat* p_image_formats = image_formats)
				fixed (uint* p_num_image_formats = num_image_formats)
				{
					Debug.Assert(Delegates.pclGetSupportedImageFormats != null, "pclGetSupportedImageFormats not implemented");
					retValue = Delegates.pclGetSupportedImageFormats(context, flags, (uint)image_type, num_entries, p_image_formats, p_num_image_formats);
					LogFunction("clGetSupportedImageFormats({0}, {1}, {2}, {3}, {4}, {5}) = {6}", context, flags, image_type, num_entries, LogValue(image_formats), LogValue(num_image_formats), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetMemObjectInfo(Int32 memobj, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetMemObjectInfo != null, "pclGetMemObjectInfo not implemented");
					retValue = Delegates.pclGetMemObjectInfo(memobj, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetMemObjectInfo({0}, {1}, {2}, {3}, {4}) = {5}", memobj, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetImageInfo(Int32 image, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetImageInfo != null, "pclGetImageInfo not implemented");
					retValue = Delegates.pclGetImageInfo(image, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetImageInfo({0}, {1}, {2}, {3}, {4}) = {5}", image, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainSampler(Int32 sampler)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainSampler != null, "pclRetainSampler not implemented");
			retValue = Delegates.pclRetainSampler(sampler);
			LogFunction("clRetainSampler({0}) = {1}", sampler, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseSampler(Int32 sampler)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseSampler != null, "pclReleaseSampler not implemented");
			retValue = Delegates.pclReleaseSampler(sampler);
			LogFunction("clReleaseSampler({0}) = {1}", sampler, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetSamplerInfo(Int32 sampler, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetSamplerInfo != null, "pclGetSamplerInfo not implemented");
					retValue = Delegates.pclGetSamplerInfo(sampler, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetSamplerInfo({0}, {1}, {2}, {3}, {4}) = {5}", sampler, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateProgramWithSource(Int32 context, uint count, String[] strings, uint[] lengths, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (uint* p_lengths = lengths)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateProgramWithSource != null, "pclCreateProgramWithSource not implemented");
					retValue = Delegates.pclCreateProgramWithSource(context, count, strings, p_lengths, p_errcode_ret);
					LogFunction("clCreateProgramWithSource({0}, {1}, {2}, {3}, {4}) = {5}", context, count, LogValue(strings), LogValue(lengths), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateProgramWithBinary(Int32 context, uint num_devices, IntPtr[] device_list, uint[] lengths, IntPtr[] binaries, int[] binary_status, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_device_list = device_list)
				fixed (uint* p_lengths = lengths)
				fixed (IntPtr* p_binaries = binaries)
				fixed (int* p_binary_status = binary_status)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateProgramWithBinary != null, "pclCreateProgramWithBinary not implemented");
					retValue = Delegates.pclCreateProgramWithBinary(context, num_devices, p_device_list, p_lengths, p_binaries, p_binary_status, p_errcode_ret);
					LogFunction("clCreateProgramWithBinary({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", context, num_devices, LogValue(device_list), LogValue(lengths), LogValue(binaries), LogValue(binary_status), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainProgram(Int32 program)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainProgram != null, "pclRetainProgram not implemented");
			retValue = Delegates.pclRetainProgram(program);
			LogFunction("clRetainProgram({0}) = {1}", program, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseProgram(Int32 program)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseProgram != null, "pclReleaseProgram not implemented");
			retValue = Delegates.pclReleaseProgram(program);
			LogFunction("clReleaseProgram({0}) = {1}", program, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int BuildProgram(Int32 program, uint num_devices, IntPtr[] device_list, char [] options, Int32 pfn_notify, Int32 user_data)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_device_list = device_list)
				fixed (char * p_options = options)
				{
					Debug.Assert(Delegates.pclBuildProgram != null, "pclBuildProgram not implemented");
					retValue = Delegates.pclBuildProgram(program, num_devices, p_device_list, p_options, pfn_notify, user_data);
					LogFunction("clBuildProgram({0}, {1}, {2}, {3}, {4}, {5}) = {6}", program, num_devices, LogValue(device_list), LogValue(options), pfn_notify, user_data, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetProgramInfo(Int32 program, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetProgramInfo != null, "pclGetProgramInfo not implemented");
					retValue = Delegates.pclGetProgramInfo(program, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetProgramInfo({0}, {1}, {2}, {3}, {4}) = {5}", program, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetProgramBuildInfo(Int32 program, Int32 device, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetProgramBuildInfo != null, "pclGetProgramBuildInfo not implemented");
					retValue = Delegates.pclGetProgramBuildInfo(program, device, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetProgramBuildInfo({0}, {1}, {2}, {3}, {4}, {5}) = {6}", program, device, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateKernel(Int32 program, char [] kernel_name, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (char * p_kernel_name = kernel_name)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateKernel != null, "pclCreateKernel not implemented");
					retValue = Delegates.pclCreateKernel(program, p_kernel_name, p_errcode_ret);
					LogFunction("clCreateKernel({0}, {1}, {2}) = {3}", program, LogValue(kernel_name), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int CreateKernelsInProgram(Int32 program, uint num_kernels, IntPtr[] kernels, uint[] num_kernels_ret)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_kernels = kernels)
				fixed (uint* p_num_kernels_ret = num_kernels_ret)
				{
					Debug.Assert(Delegates.pclCreateKernelsInProgram != null, "pclCreateKernelsInProgram not implemented");
					retValue = Delegates.pclCreateKernelsInProgram(program, num_kernels, p_kernels, p_num_kernels_ret);
					LogFunction("clCreateKernelsInProgram({0}, {1}, {2}, {3}) = {4}", program, num_kernels, LogValue(kernels), LogValue(num_kernels_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainKernel(Int32 kernel)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainKernel != null, "pclRetainKernel not implemented");
			retValue = Delegates.pclRetainKernel(kernel);
			LogFunction("clRetainKernel({0}) = {1}", kernel, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseKernel(Int32 kernel)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseKernel != null, "pclReleaseKernel not implemented");
			retValue = Delegates.pclReleaseKernel(kernel);
			LogFunction("clReleaseKernel({0}) = {1}", kernel, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int SetKernelArg(Int32 kernel, uint arg_index, uint arg_size, Int32 arg_value)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetKernelArg != null, "pclSetKernelArg not implemented");
			retValue = Delegates.pclSetKernelArg(kernel, arg_index, arg_size, arg_value);
			LogFunction("clSetKernelArg({0}, {1}, {2}, {3}) = {4}", kernel, arg_index, arg_size, arg_value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetKernelInfo(Int32 kernel, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelInfo != null, "pclGetKernelInfo not implemented");
					retValue = Delegates.pclGetKernelInfo(kernel, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetKernelInfo({0}, {1}, {2}, {3}, {4}) = {5}", kernel, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetKernelWorkGroupInfo(Int32 kernel, Int32 device, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelWorkGroupInfo != null, "pclGetKernelWorkGroupInfo not implemented");
					retValue = Delegates.pclGetKernelWorkGroupInfo(kernel, device, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetKernelWorkGroupInfo({0}, {1}, {2}, {3}, {4}, {5}) = {6}", kernel, device, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int WaitForEvents(uint num_events, IntPtr[] event_list)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_list = event_list)
				{
					Debug.Assert(Delegates.pclWaitForEvents != null, "pclWaitForEvents not implemented");
					retValue = Delegates.pclWaitForEvents(num_events, p_event_list);
					LogFunction("clWaitForEvents({0}, {1}) = {2}", num_events, LogValue(event_list), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetEventInfo(Int32 @event, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetEventInfo != null, "pclGetEventInfo not implemented");
					retValue = Delegates.pclGetEventInfo(@event, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetEventInfo({0}, {1}, {2}, {3}, {4}) = {5}", @event, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateUserEvent(Int32 context)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pclCreateUserEvent != null, "pclCreateUserEvent not implemented");
			retValue = Delegates.pclCreateUserEvent(context);
			LogFunction("clCreateUserEvent({0}) = {1}", context, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseEvent(Int32 @event)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseEvent != null, "pclReleaseEvent not implemented");
			retValue = Delegates.pclReleaseEvent(@event);
			LogFunction("clReleaseEvent({0}) = {1}", @event, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetEventProfilingInfo(Int32 @event, uint param_name, uint param_value_size, Int32 param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetEventProfilingInfo != null, "pclGetEventProfilingInfo not implemented");
					retValue = Delegates.pclGetEventProfilingInfo(@event, (uint)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetEventProfilingInfo({0}, {1}, {2}, {3}, {4}) = {5}", @event, param_name, param_value_size, param_value, LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int Flush(Int32 command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclFlush != null, "pclFlush not implemented");
			retValue = Delegates.pclFlush(command_queue);
			LogFunction("clFlush({0}) = {1}", command_queue, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int Finish(Int32 command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclFinish != null, "pclFinish not implemented");
			retValue = Delegates.pclFinish(command_queue);
			LogFunction("clFinish({0}) = {1}", command_queue, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueReadBuffer(Int32 command_queue, Int32 buffer, bool blocking_read, uint offset, uint size, Int32 ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueReadBuffer != null, "pclEnqueueReadBuffer not implemented");
					retValue = Delegates.pclEnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueReadBuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueWriteBuffer(Int32 command_queue, Int32 buffer, bool blocking_write, uint offset, uint size, Int32 ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueWriteBuffer != null, "pclEnqueueWriteBuffer not implemented");
					retValue = Delegates.pclEnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueWriteBuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyBuffer(Int32 command_queue, Int32 src_buffer, Int32 dst_buffer, uint src_offset, uint dst_offset, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyBuffer != null, "pclEnqueueCopyBuffer not implemented");
					retValue = Delegates.pclEnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyBuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueReadImage(Int32 command_queue, Int32 image, bool blocking_read, uint row_pitch, uint slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueReadImage != null, "pclEnqueueReadImage not implemented");
					retValue = Delegates.pclEnqueueReadImage(command_queue, image, blocking_read, row_pitch, slice_pitch, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueReadImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, image, blocking_read, row_pitch, slice_pitch, ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueWriteImage(Int32 command_queue, Int32 image, bool blocking_write, uint input_row_pitch, uint input_slice_pitch, Int32 ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueWriteImage != null, "pclEnqueueWriteImage not implemented");
					retValue = Delegates.pclEnqueueWriteImage(command_queue, image, blocking_write, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueWriteImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, image, blocking_write, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyImage(Int32 command_queue, Int32 src_image, Int32 dst_image, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyImage != null, "pclEnqueueCopyImage not implemented");
					retValue = Delegates.pclEnqueueCopyImage(command_queue, src_image, dst_image, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyImage({0}, {1}, {2}, {3}, {4}, {5}) = {6}", command_queue, src_image, dst_image, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyImageToBuffer(Int32 command_queue, Int32 src_image, Int32 dst_buffer, uint dst_offset, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyImageToBuffer != null, "pclEnqueueCopyImageToBuffer not implemented");
					retValue = Delegates.pclEnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, dst_offset, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyImageToBuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", command_queue, src_image, dst_buffer, dst_offset, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyBufferToImage(Int32 command_queue, Int32 src_buffer, Int32 dst_image, uint src_offset, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyBufferToImage != null, "pclEnqueueCopyBufferToImage not implemented");
					retValue = Delegates.pclEnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyBufferToImage({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", command_queue, src_buffer, dst_image, src_offset, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueUnmapMemObject(Int32 command_queue, Int32 memobj, Int32 mapped_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueUnmapMemObject != null, "pclEnqueueUnmapMemObject not implemented");
					retValue = Delegates.pclEnqueueUnmapMemObject(command_queue, memobj, mapped_ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueUnmapMemObject({0}, {1}, {2}, {3}, {4}, {5}) = {6}", command_queue, memobj, mapped_ptr, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueNDRangeKernel(Int32 command_queue, Int32 kernel, uint work_dim, uint[] global_work_offset, uint[] global_work_size, uint[] local_work_size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (uint* p_global_work_offset = global_work_offset)
				fixed (uint* p_global_work_size = global_work_size)
				fixed (uint* p_local_work_size = local_work_size)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueNDRangeKernel != null, "pclEnqueueNDRangeKernel not implemented");
					retValue = Delegates.pclEnqueueNDRangeKernel(command_queue, kernel, work_dim, p_global_work_offset, p_global_work_size, p_local_work_size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueNDRangeKernel({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, kernel, work_dim, LogValue(global_work_offset), LogValue(global_work_size), LogValue(local_work_size), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueNativeKernel(Int32 command_queue, Int32 args, uint cb_args, uint num_mem_objects, IntPtr[] mem_list, IntPtr[] args_mem_loc, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_mem_list = mem_list)
				fixed (IntPtr* p_args_mem_loc = args_mem_loc)
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueNativeKernel != null, "pclEnqueueNativeKernel not implemented");
					retValue = Delegates.pclEnqueueNativeKernel(command_queue, args, cb_args, num_mem_objects, p_mem_list, p_args_mem_loc, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueNativeKernel({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue, args, cb_args, num_mem_objects, LogValue(mem_list), LogValue(args_mem_loc), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

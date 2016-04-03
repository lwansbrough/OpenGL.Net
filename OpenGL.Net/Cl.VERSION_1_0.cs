
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
		/// <para>
		/// Cl.CreateContextFromType: the default OpenCL device in the system. The default device cannot be a Cl.DEVICE_TYPE_CUSTOM 
		/// device.
		/// </para>
		/// <para>
		/// Cl.GetDeviceIDs: the default OpenCL device in the system. The default device cannot be a Cl.DEVICE_TYPE_CUSTOM device.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int DEVICE_TYPE_DEFAULT = (1 << 0);

		/// <summary>
		/// <para>
		/// Cl.CreateContextFromType: an OpenCL device that is the host processor. The host processor runs the OpenCL 
		/// implementations and is a single or multi-core CPU.
		/// </para>
		/// <para>
		/// Cl.GetDeviceIDs: an OpenCL device that is the host processor. The host processor runs the OpenCL implementations and is 
		/// a single or multi-core CPU.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int DEVICE_TYPE_CPU = (1 << 1);

		/// <summary>
		/// <para>
		/// Cl.CreateContextFromType: an OpenCL device that is a GPU. By this we mean that the device can also be used to accelerate 
		/// a 3D API such as OpenGL or DirectX.
		/// </para>
		/// <para>
		/// Cl.GetDeviceIDs: an OpenCL device that is a GPU. By this we mean that the device can also be used to accelerate a 3D API 
		/// such as OpenGL or DirectX.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int DEVICE_TYPE_GPU = (1 << 2);

		/// <summary>
		/// <para>
		/// Cl.CreateContextFromType: dedicated OpenCL accelerators (for example the IBM CELL Blade). These devices communicate with 
		/// the host processor using a peripheral interconnect such as PCIe.
		/// </para>
		/// <para>
		/// Cl.GetDeviceIDs: dedicated OpenCL accelerators (for example the IBM CELL Blade). These devices communicate with the host 
		/// processor using a peripheral interconnect such as PCIe.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int DEVICE_TYPE_ACCELERATOR = (1 << 3);

		/// <summary>
		/// <para>
		/// Cl.CreateContextFromType: dedicated accelerators that do not support programs written in OpenCL C.
		/// </para>
		/// <para>
		/// Cl.GetDeviceIDs: dedicated accelerators that do not support programs written in OpenCL C.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int DEVICE_TYPE_CUSTOM = (1 << 4);

		/// <summary>
		/// <para>
		/// Cl.CreateContextFromType: all OpenCL devices available in the system except Cl.DEVICE_TYPE_CUSTOM devices.
		/// </para>
		/// <para>
		/// Cl.GetDeviceIDs: all OpenCL devices available in the system except Cl.DEVICE_TYPE_CUSTOM devices.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const uint DEVICE_TYPE_ALL = 0xFFFFFFFF;

		/// <summary>
		/// Cl.GetDeviceInfo: the OpenCL device type. Currently supported values are: Cl.DEVICE_TYPE_CPU, Cl.DEVICE_TYPE_GPU, 
		/// Cl.DEVICE_TYPE_ACCELERATOR, Cl.DEVICE_TYPE_DEFAULT, a combination of the above types, or Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_TYPE = 0x1000;

		/// <summary>
		/// Cl.GetDeviceInfo: a unique device vendor identifier. An example of a unique device identifier could be the PCIe ID.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_VENDOR_ID = 0x1001;

		/// <summary>
		/// Cl.GetDeviceInfo: the number of parallel compute units on the OpenCL device. A work-group executes on a single compute 
		/// unit. The minimum value is 1.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_COMPUTE_UNITS = 0x1002;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum dimensions that specify the global and local work-item IDs used by the data parallel execution 
		/// model. (Refer to Cl.EnqueueNDRangeKernel). The minimum value is 3 for devices that are not of type 
		/// Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum number of work-items in a work-group that a device is capable of executing on a single compute 
		/// unit, for any given kernel-instance running on the device. (Refer also to Cl.EnqueueNDRangeKernel) and 
		/// Cl.KERNEL_WORK_GROUP_SIZE). The minimum value is 1.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WORK_GROUP_SIZE = 0x1004;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum number of work-items that can be specified in each dimension of the work-group to 
		/// Cl.EnqueueNDRangeKernel. Returns nsize_t entries, where n is the value returned by the query for 
		/// Cl.DEVICE_MAX_WORK_ITEM_DIMENSIONS. The minimum value is (1, 1, 1) for devices that are not of type 
		/// Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WORK_ITEM_SIZES = 0x1005;

		/// <summary>
		/// Cl.GetDeviceInfo: preferred native vector width size for built-in scalar types that can be put into vectors. The vector 
		/// width is defined as the number of scalar elements that can be stored in the vector. If double precision is not 
		/// supported, Cl.DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0. If the Cl._khr_fp16 extension is not supported, 
		/// Cl.DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
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
		/// Cl.GetDeviceInfo: maximum configured clock frequency of the device in MHz.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_CLOCK_FREQUENCY = 0x100C;

		/// <summary>
		/// Cl.GetDeviceInfo: the default compute device address space size of the global address space specified as an unsigned 
		/// integer value in bits. Currently supported values are 32 or 64 bits.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_ADDRESS_BITS = 0x100D;

		/// <summary>
		/// Cl.GetDeviceInfo: max number of image objects arguments of a kernel declared with the read_only qualifier. The minimum 
		/// value is 128 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_READ_IMAGE_ARGS = 0x100E;

		/// <summary>
		/// Cl.GetDeviceInfo: max number of image objects arguments of a kernel declared with the write_only qualifier. The minimum 
		/// value is 64 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE. NOTE: Cl.DEVICE_MAX_WRITE_IMAGE_ARGS is only there for backward 
		/// compatibility. Cl.DEVICE_MAX_READ_WRITE_IMAGE_ARGS should be used instead.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F;

		/// <summary>
		/// Cl.GetDeviceInfo: max size of memory object allocation in bytes. The minimum value is max(min(1024*1024*1024, 1/4th of 
		/// Cl.DEVICE_GLOBAL_MEM_SIZE), 32*1024*1024) for devices that are not of type Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010;

		/// <summary>
		/// Cl.GetDeviceInfo: max width of 2D image or 1D image not created from a buffer object in pixels. The minimum value is 
		/// 16384 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE2D_MAX_WIDTH = 0x1011;

		/// <summary>
		/// Cl.GetDeviceInfo: max height of 2D image in pixels. The minimum value is 16384 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012;

		/// <summary>
		/// Cl.GetDeviceInfo: max width of 3D image in pixels. The minimum value is 2048 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE3D_MAX_WIDTH = 0x1013;

		/// <summary>
		/// Cl.GetDeviceInfo: max height of 3D image in pixels. The minimum value is 2048 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014;

		/// <summary>
		/// Cl.GetDeviceInfo: max depth of 3D image in pixels. The minimum value is 2048 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE3D_MAX_DEPTH = 0x1015;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.TRUE if images are supported by the OpenCL device and Cl.FALSE otherwise.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_SUPPORT = 0x1016;

		/// <summary>
		/// Cl.GetDeviceInfo: max size in bytes of all arguments that can be passed to a kernel. The minimum value is 1024 for 
		/// devices that are not of type Cl.DEVICE_TYPE_CUSTOM. For this minimum value, only a maximum of 128 arguments can be 
		/// passed to a kernel.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_PARAMETER_SIZE = 0x1017;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum number of samplers that can be used in a kernel. The minimum value is 16 if 
		/// Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE. (Also see Cl.mpler_t.)
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_SAMPLERS = 0x1018;

		/// <summary>
		/// Cl.GetDeviceInfo: alignment requirement (in bits) for sub-buffer offsets. The minimum value is the size (in bits) of the 
		/// largest OpenCL built-in data type supported by the device (long16 in FULL profile, long16 or int16 in EMBEDDED profile) 
		/// for devices that are not of type Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019;

		/// <summary>
		/// Value of CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A;

		/// <summary>
		/// Cl.GetDeviceInfo: describes single precision floating-point capability of the device. This is a bit-field that describes 
		/// one or more of the following values: Cl.FP_DENORM - denorms are supportedCl.FP_INF_NAN - INF and quiet NaNs are 
		/// supportedCl.FP_ROUND_TO_NEAREST - round to nearest even rounding mode supportedCl.FP_ROUND_TO_ZERO - round to zero 
		/// rounding mode supportedCl.FP_ROUND_TO_INF - round to +ve and -ve infinity rounding modes supportedCl.FP_FMA - 
		/// IEEE754-2008 fused multiply-add is supportedCl.FP_CORRECTLY_ROUNDED_DIVIDE_SQRT - divide and sqrt are correctly rounded 
		/// as defined by the IEEE754 specification. Cl.FP_SOFT_FLOAT - Basic floating-point operations (such as addition, 
		/// subtraction, multiplication) are implemented in software. For the full profile, the mandated minimum floating-point 
		/// capability for devices that are not of type Cl.DEVICE_TYPE_CUSTOM is Cl.FP_ROUND_TO_NEAREST | Cl.FP_INF_NAN. For the 
		/// embedded profile, see section 10.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SINGLE_FP_CONFIG = 0x101B;

		/// <summary>
		/// Cl.GetDeviceInfo: type of global memory cache supported. Valid values are: Cl.NONE, Cl.READ_ONLY_CACHE, and 
		/// Cl.READ_WRITE_CACHE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C;

		/// <summary>
		/// Cl.GetDeviceInfo: size of global memory cache line in bytes.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D;

		/// <summary>
		/// Cl.GetDeviceInfo: size of global memory cache in bytes.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E;

		/// <summary>
		/// Cl.GetDeviceInfo: size of global device memory in bytes.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_MEM_SIZE = 0x101F;

		/// <summary>
		/// Cl.GetDeviceInfo: max size in bytes of a constant buffer allocation. The minimum value is 64 KB for devices that are not 
		/// of type Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020;

		/// <summary>
		/// Cl.GetDeviceInfo: max number of arguments declared with the Cl.constant qualifier in a kernel. The minimum value is 8 
		/// for devices that are not of type Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_CONSTANT_ARGS = 0x1021;

		/// <summary>
		/// Cl.GetDeviceInfo: type of local memory supported. This can be set to Cl.LOCAL implying dedicated local memory storage 
		/// such as SRAM, or Cl.GLOBAL. For custom devices, Cl.NONE can also be returned indicating no local memory support.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_LOCAL_MEM_TYPE = 0x1022;

		/// <summary>
		/// Cl.GetDeviceInfo: size of local memory region in bytes. The minimum value is 32 KB for devices that are not of type 
		/// Cl.DEVICE_TYPE_CUSTOM.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_LOCAL_MEM_SIZE = 0x1023;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.TRUE if the device implements error correction for all accesses to compute device memory (global 
		/// and constant). Is Cl.FALSE if the device does not implement such error correction.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024;

		/// <summary>
		/// Cl.GetDeviceInfo: describes the resolution of device timer. This is measured in nanoseconds.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.TRUE if the OpenCL device is a little endian device and Cl.FALSE otherwise.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_ENDIAN_LITTLE = 0x1026;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.TRUE if the device is available and Cl.FALSE otherwise. A device is considered to be available 
		/// if the device can be expected to successfully execute commands enqueued to the device
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AVAILABLE = 0x1027;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.FALSE if the implementation does not have a compiler available to compile the program source. Is 
		/// Cl.TRUE if the compiler is available. This can be Cl.FALSE for the embedded platform profile only.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_COMPILER_AVAILABLE = 0x1028;

		/// <summary>
		/// Cl.GetDeviceInfo: describes the execution capabilities of the device. This is a bit-field that describes one or more of 
		/// the following values: Cl.EXEC_KERNEL - The OpenCL device can execute OpenCL kernels.Cl.EXEC_NATIVE_KERNEL - The OpenCL 
		/// device can execute native kernels.The mandated minimum capability is Cl.EXEC_KERNEL.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_EXECUTION_CAPABILITIES = 0x1029;

		/// <summary>
		/// Value of CL_DEVICE_QUEUE_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_PROPERTIES = 0x102A;

		/// <summary>
		/// Cl.GetDeviceInfo: describes the on host command-queue properties supported by the device. This is a bit-field that 
		/// describes one or more of the following values: Cl.QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLECl.QUEUE_PROFILING_ENABLE These 
		/// properties are described in the table for Cl.CreateCommandQueueWithProperties. The mandated minimum capability is 
		/// Cl.QUEUE_PROFILING_ENABLE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_HOST_PROPERTIES = 0x102A;

		/// <summary>
		/// Cl.GetDeviceInfo: device name string.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NAME = 0x102B;

		/// <summary>
		/// Cl.GetDeviceInfo: vendor name string.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_VENDOR = 0x102C;

		/// <summary>
		/// Cl.GetDeviceInfo: openCL software driver version string in the form major_number.minor_number.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DRIVER_VERSION = 0x102D;

		/// <summary>
		/// Cl.GetDeviceInfo: openCL profile string. Returns the profile name supported by the device (see note). The profile name 
		/// returned can be one of the following strings: FULL_PROFILE - if the device supports the OpenCL specification 
		/// (functionality defined as part of the core specification and does not require any extensions to be supported). 
		/// EMBEDDED_PROFILE - if the device supports the OpenCL embedded profile. The platform profile returns the profile that is 
		/// implemented by the OpenCL framework. If the platform profile returned is Cl.L_PROFILE, the OpenCL framework will support 
		/// devices that are Cl.L_PROFILE and may also support devices that are Cl.EDDED_PROFILE. The compiler must be available for 
		/// all devices i.e. Cl.DEVICE_COMPILER_AVAILABLE is Cl.TRUE. If the platform profile returned is Cl.EDDED_PROFILE, then 
		/// devices that are only Cl.EDDED_PROFILE are supported.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PROFILE = 0x102E;

		/// <summary>
		/// Cl.GetDeviceInfo: openCL version string. Returns the OpenCL version supported by the device. This version string has the 
		/// following format: OpenCL&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt; 
		/// The major_version.minor_version value returned will be 2.1.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_VERSION = 0x102F;

		/// <summary>
		/// Cl.GetDeviceInfo: returns a space separated list of extension names (the extension names themselves do not contain any 
		/// spaces) supported by the device. The list of extension names returned can be vendor supported extension names and one or 
		/// more of the following Khronos approved extension names: 
		/// Cl._khr_int64_base_atomicsCl._khr_int64_extended_atomicsCl._khr_fp16Cl._khr_gl_sharingCl._khr_gl_eventCl._khr_d3d10_sharingCl._khr_dx9_media_sharingCl._khr_d3d11_sharingCl._khr_gl_depth_imagesCl._khr_gl_msaa_sharingCl._khr_initialize_memorycl_khr_context_abortCl._khr_spirCl._khr_srgb_image_writes 
		/// The following approved Khronos extension names must be returned by all device that support OpenCL C 
		/// 2.0:cl_khr_byte_addressable_storeCl._khr_fp64 (for backward compatibility if double precision is 
		/// supported)Cl._khr_3d_image_writescl_khr_image2d_from_buffercl_khr_depth_images Please refer to the OpenCL 2.0 Extension 
		/// Specification for a detailed description of these extensions.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_EXTENSIONS = 0x1030;

		/// <summary>
		/// Cl.GetDeviceInfo: the platform associated with this device.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PLATFORM = 0x1031;

		/// <summary>
		/// Cl.GetDeviceInfo: describes double precision floating-point capability of the OpenCL device. This is a bit-field that 
		/// describes one or more of the following values: Cl.FP_DENORM - denorms are supported.Cl.FP_INF_NAN - INF and NaNs are 
		/// supported.Cl.FP_ROUND_TO_NEAREST - round to nearest even rounding mode supported.Cl.FP_ROUND_TO_ZERO - round to zero 
		/// rounding mode supported.Cl.FP_ROUND_TO_INF - round to positive and negative infinity rounding modes supported.Cl.FP_FMA 
		/// - IEEE754-2008 fused multiply-add is supported. Cl.FP_SOFT_FLOAT - Basic floating-point operations (such as addition, 
		/// subtraction, multiplication) are implemented in software. Double precision is an optional feature so the mandated 
		/// minimum double precision floating-point capability is 0. If double precision is supported by the device, then the 
		/// minimum double precision floating-point capability must be: Cl.FP_FMA | Cl.FP_ROUND_TO_NEAREST | Cl.FP_INF_NAN | 
		/// Cl.FP_DENORM.
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
		/// Cl.GetDeviceInfo: returns the native ISA vector width. The vector width is defined as the number of scalar elements that 
		/// can be stored in the vector. If double precision is not supported, Cl.DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0. 
		/// If the Cl._khr_fp16 extension is not supported, Cl.DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
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
		/// Cl.GetDeviceInfo: openCL C version string. Returns the highest OpenCL C version supported by the compiler for this 
		/// device that is not of type Cl.DEVICE_TYPE_CUSTOM. This version string has the following format: 
		/// OpenCL&lt;space&gt;C&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt; The 
		/// major_version.minor_version value returned must be 2.0 if Cl.DEVICE_VERSION is OpenCL 2.0. The 
		/// major_version.minor_version value returned must be 1.2 if Cl.DEVICE_VERSION is OpenCL 1.2. The 
		/// major_version.minor_version value returned must be 1.1 if Cl.DEVICE_VERSION is OpenCL 1.1. The 
		/// major_version.minor_version value returned can be 1.0 or 1.1 if Cl.DEVICE_VERSION is OpenCL 1.0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_OPENCL_C_VERSION = 0x103D;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.FALSE if the implementation does not have a linker available. Is Cl.TRUE if the linker is 
		/// available. This can be Cl.FALSE for the embedded platform profile only. This must be Cl.TRUE if 
		/// Cl.DEVICE_COMPILER_AVAILABLE is Cl.TRUE
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_LINKER_AVAILABLE = 0x103E;

		/// <summary>
		/// Cl.GetDeviceInfo: a semi-colon separated list of built-in kernels supported by the device. An empty string is returned 
		/// if no built-in kernels are supported by the device.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_BUILT_IN_KERNELS = 0x103F;

		/// <summary>
		/// Cl.GetDeviceInfo: max number of pixels for a 1D image created from a buffer object. The minimum value is 65536 if 
		/// Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_MAX_BUFFER_SIZE = 0x1040;

		/// <summary>
		/// Cl.GetDeviceInfo: max number of images in a 1D or 2D image array. The minimum value is 2048 if Cl.DEVICE_IMAGE_SUPPORT 
		/// is Cl.TRUE
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_MAX_ARRAY_SIZE = 0x1041;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the cl_device_id of the parent device to which this sub-device belongs. If device is a 
		/// root-level device, a NULL value is returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARENT_DEVICE = 0x1042;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the maximum number of sub-devices that can be created when a device is partitioned. The value 
		/// returned cannot exceed Cl.DEVICE_MAX_COMPUTE_UNITS.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_MAX_SUB_DEVICES = 0x1043;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the list of partition types supported by device. This is an array of 
		/// cl_device_partition_property values drawn from the following list: 
		/// Cl.DEVICE_PARTITION_EQUALLYCl.DEVICE_PARTITION_BY_COUNTSCl.DEVICE_PARTITION_BY_AFFINITY_DOMAIN If the device cannot be 
		/// partitioned (i.e. there is no partitioning scheme supported by the device that will return at least two subdevices), a 
		/// value of 0 will be returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_PROPERTIES = 0x1044;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the list of supported affinity domains for partitioning the device using 
		/// Cl.DEVICE_PARTITION_BY_AFFINITY_DOMAIN. This is a bit-field that describes one or more of the following values: 
		/// Cl.DEVICE_AFFINITY_DOMAIN_NUMACl.DEVICE_AFFINITY_DOMAIN_L4_CACHECl.DEVICE_AFFINITY_DOMAIN_L3_CACHECl.DEVICE_AFFINITY_DOMAIN_L2_CACHECl.DEVICE_AFFINITY_DOMAIN_L1_CACHECl.DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE 
		/// If the device does not support any affinity domains, a value of 0 will be returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_AFFINITY_DOMAIN = 0x1045;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the properties argument specified in Cl.CreateSubDevices if device is a subdevice. In the case 
		/// where the properties argument to Cl.CreateSubDevices is Cl.DEVICE_PARTITION_BY_AFFINITY_DOMAIN, 
		/// Cl.DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE, the affinity domain used to perform the partition will be returned. This 
		/// can be one of the following values: 
		/// Cl.DEVICE_AFFINITY_DOMAIN_NUMACl.DEVICE_AFFINITY_DOMAIN_L4_CACHECl.DEVICE_AFFINITY_DOMAIN_L3_CACHECl.DEVICE_AFFINITY_DOMAIN_L2_CACHECl.DEVICE_AFFINITY_DOMAIN_L1_CACHE 
		/// Otherwise the implementation may either return a param_value_size_ret of 0 i.e. there is no partition type associated 
		/// with device or can return a property value of 0 (where 0 is used to terminate the partition property list) in the memory 
		/// that param_value points to.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_TYPE = 0x1046;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the device reference count. If the device is a root-level device, a reference count of one is 
		/// returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_REFERENCE_COUNT = 0x1047;

		/// <summary>
		/// Cl.GetDeviceInfo: is Cl.TRUE if the device's preference is for the user to be responsible for synchronization, when 
		/// sharing memory objects between OpenCL and other APIs such as DirectX, Cl.FALSE if the device / implementation has a 
		/// performant path for performing synchronization of memory object shared between OpenCL and other APIs such as DirectX
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_INTEROP_USER_SYNC = 0x1048;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum size in bytes of the internal buffer that holds the output of Cl.intf calls from a kernel. The 
		/// minimum value for the FULL profile is 1 MB.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PRINTF_BUFFER_SIZE = 0x1049;

		/// <summary>
		/// Cl.GetDeviceInfo: the row pitch alignment size in pixels for 2D images created from a buffer. The value returned must be 
		/// a power of 2. If the device does not support images, this value must be 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_PITCH_ALIGNMENT = 0x104A;

		/// <summary>
		/// Cl.GetDeviceInfo: this query should be used when a 2D image is created from a buffer which was created using 
		/// Cl.MEM_USE_HOST_PTR. The value returned must be a power of 2. This query specifies the minimum alignment in pixels of 
		/// the host_ptr specified to Cl.CreateBuffer. If the device does not support images, this value must be 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT = 0x104B;

		/// <summary>
		/// Cl.GetDeviceInfo: max number of image objects arguments of a kernel declared with the write_only or read_write 
		/// qualifier. The minimum value is 64 if Cl.DEVICE_IMAGE_SUPPORT is Cl.TRUE. NOTE: Cl.DEVICE_MAX_WRITE_IMAGE_ARGS is only 
		/// there for backward compatibility. Cl.DEVICE_MAX_READ_WRITE_IMAGE_ARGS should be used instead.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_READ_WRITE_IMAGE_ARGS = 0x104C;

		/// <summary>
		/// Cl.GetDeviceInfo: the maximum number of bytes of storage that may be allocated for any single variable in program scope 
		/// or inside a function in OpenCL C declared in the global address space. The minimum value is 64 KB.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_GLOBAL_VARIABLE_SIZE = 0x104D;

		/// <summary>
		/// Cl.GetDeviceInfo: describes the on device command-queue properties supported by the device. This is a bit-field that 
		/// describes one or more of the following values: Cl.QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLECl.QUEUE_PROFILING_ENABLE These 
		/// properties are described in the table for Cl.CreateCommandQueueWithProperties. The mandated minimum capability is 
		/// Cl.QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE | Cl.QUEUE_PROFILING_ENABLE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_DEVICE_PROPERTIES = 0x104E;

		/// <summary>
		/// Cl.GetDeviceInfo: the size of the device queue in bytes preferred by the implementation. Applications should use this 
		/// size for the device queue to ensure good performance. The minimum value is 16 KB.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE = 0x104F;

		/// <summary>
		/// Cl.GetDeviceInfo: the max. size of the device queue in bytes. The minimum value is 256 KB for the full profile and 64 KB 
		/// for the embedded profile
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_QUEUE_ON_DEVICE_MAX_SIZE = 0x1050;

		/// <summary>
		/// Cl.GetDeviceInfo: the maximum number of device queues that can be created per context. The minimum value is 1.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_ON_DEVICE_QUEUES = 0x1051;

		/// <summary>
		/// Cl.GetDeviceInfo: the maximum number of events in use by a device queue. These refer to events returned by the enqueue_ 
		/// built-in functions to a device queue or user events returned by the Cl.eate_user_event built-in function that have not 
		/// been released. The minimum value is 1024.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_ON_DEVICE_EVENTS = 0x1052;

		/// <summary>
		/// Cl.GetDeviceInfo: describes the various shared virtual memory (a.k.a. SVM) memory allocation types the device supports. 
		/// Coarse-grain SVM allocations are required to be supported by all OpenCL 2.0 devices. This is a bit-field that describes 
		/// a combination of the following values:Cl.DEVICE_SVM_COARSE_GRAIN_BUFFER – Support for coarse-grain buffer sharing using 
		/// Cl.SVMAlloc. Memory consistency is guaranteed at synchronization points and the host must use calls to 
		/// Cl.EnqueueMapBuffer and Cl.EnqueueUnmapMemObject.Cl.DEVICE_SVM_FINE_GRAIN_BUFFER – Support for fine-grain buffer sharing 
		/// using Cl.SVMAlloc. Memory consistency is guaranteed atsynchronization points without need for Cl.EnqueueMapBuffer and 
		/// Cl.EnqueueUnmapMemObject.Cl.DEVICE_SVM_FINE_GRAIN_SYSTEM – Support for sharing the host’s entire virtual memory 
		/// including memory allocated using malloc. Memory consistency is guaranteed at synchronization 
		/// points.Cl.DEVICE_SVM_ATOMICS – Support for the OpenCL 2.0 atomic operations that provide memory consistency across the 
		/// host and all OpenCL devices supporting fine-grain SVM allocations. The mandated minimum capability is 
		/// Cl.DEVICE_SVM_COARSE_GRAIN_BUFFER.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SVM_CAPABILITIES = 0x1053;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum preferred total size, in bytes, of all program variables in the global address space. This is 
		/// a performance hint. An implementation may place such variables in storage with optimized device access. This query 
		/// returns the capacity of such storage. The minimum value is 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE = 0x1054;

		/// <summary>
		/// Cl.GetDeviceInfo: the maximum number of pipe objects that can be passed as arguments to a kernel. The minimum value is 
		/// 16.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_PIPE_ARGS = 0x1055;

		/// <summary>
		/// Cl.GetDeviceInfo: the maximum number of reservations that can be active for a pipe per work-item in a kernel. A 
		/// work-group reservation is counted as one reservation per work-item. The minimum value is 1.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS = 0x1056;

		/// <summary>
		/// Cl.GetDeviceInfo: the maximum size of pipe packet in bytes. The minimum value is 1024 bytes.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PIPE_MAX_PACKET_SIZE = 0x1057;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the value representing the preferred alignment in bytes for OpenCL 2.0 fine-grained SVM atomic 
		/// types. This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT = 0x1058;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the value representing the preferred alignment in bytes for OpenCL 2.0 atomic types to global 
		/// memory. This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT = 0x1059;

		/// <summary>
		/// Cl.GetDeviceInfo: returns the value representing the preferred alignment in bytes for OpenCL 2.0 atomic types to local 
		/// memory. This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT = 0x105A;

		/// <summary>
		/// Cl.GetDeviceInfo: the intermediate languages that can be supported by Cl.CreateProgramWithIL for this device. Returns a 
		/// space-separated list of IL version strings of the form &lt;IL_Prefix&gt;_&lt;Major_Version&gt;.&lt;Minor_Version&gt;. 
		/// For OpenCL 2.1, "SPIR-V" is a required IL prefix.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_IL_VERSION = 0x105B;

		/// <summary>
		/// Cl.GetDeviceInfo: maximum number of sub-groups in a work-group that a device is capable of executing on a single compute 
		/// unit, for any given kernel-instance running on the device. The minimum value is 1. (Refer also to 
		/// Cl.GetKernelSubGroupInfo.)
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_MAX_NUM_SUB_GROUPS = 0x105C;

		/// <summary>
		/// Value of CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS = 0x105D;

		/// <summary>
		/// <para>
		/// Cl.CreateContext: specifies the platform to use.
		/// </para>
		/// <para>
		/// Cl.CreateContextFromType: specifies the platform to use.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_PLATFORM = 0x1084;

		/// <summary>
		/// <para>
		/// Cl.CreateContext: specifies whether the user is responsible for synchronization between OpenCL and other APIs. Please 
		/// refer to the specific sections in the OpenCL 2.0 extension specification that describe sharing with other APIs for 
		/// restrictions on using this flag. If Cl.CONTEXT_INTEROP_USER_SYNC is not specified, a default of Cl.FALSE is assumed. 
		/// OpenCL / OpenGL sharing does not support the Cl.CONTEXT_INTEROP_USER_SYNC property defined in table 4.5. Specifying this 
		/// property when creating a context with OpenCL / OpenGL sharing will return an appropriate error.
		/// </para>
		/// <para>
		/// Cl.CreateContextFromType: specifies whether the user is responsible for synchronization between OpenCL and other APIs. 
		/// Please refer to the specific sections in the OpenCL 2.0 extension specification that describe sharing with other APIs 
		/// for restrictions on using this flag. If Cl.CONTEXT_INTEROP_USER_SYNC is not specified, a default of Cl.FALSE is assumed. 
		/// OpenCL / OpenGL sharing does not support the Cl.CONTEXT_INTEROP_USER_SYNC property defined in table 4.5. Specifying this 
		/// property when creating a context with OpenCL / OpenGL sharing will return an appropriate error.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_INTEROP_USER_SYNC = 0x1085;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_EQUALLY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_EQUALLY = 0x1086;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_BY_COUNTS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_BY_COUNTS = 0x1087;

		/// <summary>
		/// Cl.CreateSubDevice: this property is followed by a Cl.DEVICE_PARTITION_BY_COUNTS_LIST_END terminated list of compute 
		/// unit counts. For each nonzero count m in the list, a sub-device is created with m compute units in it. 
		/// Cl.DEVICE_PARTITION_BY_COUNTS_LIST_END is defined to be 0. The number of non-zero count entries in the list may not 
		/// exceed Cl.DEVICE_PARTITION_MAX_SUB_DEVICES. The total number of compute units specified may not exceed 
		/// Cl.DEVICE_PARTITION_MAX_COMPUTE_UNITS.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_BY_COUNTS_LIST_END = 0x0;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_BY_AFFINITY_DOMAIN = 0x1088;

		/// <summary>
		/// Value of CL_DEVICE_AFFINITY_DOMAIN_NUMA symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AFFINITY_DOMAIN_NUMA = (1 << 0);

		/// <summary>
		/// Value of CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AFFINITY_DOMAIN_L4_CACHE = (1 << 1);

		/// <summary>
		/// Value of CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AFFINITY_DOMAIN_L3_CACHE = (1 << 2);

		/// <summary>
		/// Value of CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AFFINITY_DOMAIN_L2_CACHE = (1 << 3);

		/// <summary>
		/// Value of CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AFFINITY_DOMAIN_L1_CACHE = (1 << 4);

		/// <summary>
		/// Value of CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE = (1 << 5);

		/// <summary>
		/// Value of CL_DEVICE_SVM_COARSE_GRAIN_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SVM_COARSE_GRAIN_BUFFER = (1 << 0);

		/// <summary>
		/// Value of CL_DEVICE_SVM_FINE_GRAIN_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SVM_FINE_GRAIN_BUFFER = (1 << 1);

		/// <summary>
		/// Value of CL_DEVICE_SVM_FINE_GRAIN_SYSTEM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SVM_FINE_GRAIN_SYSTEM = (1 << 2);

		/// <summary>
		/// Value of CL_DEVICE_SVM_ATOMICS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_SVM_ATOMICS = (1 << 3);

		/// <summary>
		/// Cl.GetContextInfo: return the context reference count. The reference count returned should be considered immediately 
		/// stale. It is unsuitable for general use in applications. This feature is provided for identifying memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_REFERENCE_COUNT = 0x1080;

		/// <summary>
		/// Cl.GetContextInfo: return the list of devices in context.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_DEVICES = 0x1081;

		/// <summary>
		/// Cl.GetContextInfo: return the properties argument specified in Cl.CreateContext or Cl.CreateContextFromType. If the 
		/// properties argument specified in Cl.CreateContext or Cl.CreateContextFromType used to create context is not NULL, the 
		/// implementation must return the values specified in the properties argument. If the properties argument specified in 
		/// Cl.CreateContext or Cl.CreateContextFromType used to create context is NULL, the implementation may return either a 
		/// param_value_size_ret of 0, i.e. there is no context property value to be returned or can return a context property value 
		/// of 0 (where 0 is used to terminate the context properties list) in the memory that param_value points to.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_PROPERTIES = 0x1082;

		/// <summary>
		/// Cl.GetContextInfo: return the number of devices in context.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int CONTEXT_NUM_DEVICES = 0x1083;

		/// <summary>
		/// Cl.GetCommandQueueInfo: return type: cl_contextReturn the context specified when the command-queue is created.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_CONTEXT = 0x1090;

		/// <summary>
		/// Cl.GetCommandQueueInfo: return type: cl_device_idReturn the device specified when the command-queue is created.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_DEVICE = 0x1091;

		/// <summary>
		/// Cl.GetCommandQueueInfo: return type: cl_uintReturn the command-queue reference count. The reference count returned with 
		/// Cl.QUEUE_REFERENCE_COUNT should be considered immediately stale. It is unsuitable for general use in applications. This 
		/// feature is provided for identifying memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_REFERENCE_COUNT = 0x1092;

		/// <summary>
		/// <para>
		/// Cl.CreateCommandQueueWithProperties: this is a bitfield and can be set to a combination of the following 
		/// values:Cl.QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE - Determines whether the commands queued in the command-queue are executed 
		/// in-order or out-of-order. If set, the commands in the command-queue are executed out-of-order. Otherwise, commands are 
		/// executed in-order.Cl.QUEUE_PROFILING_ENABLE - Enable or disable profiling of commands in the command-queue. If set, the 
		/// profiling of commands is enabled. Otherwise profiling of commands is disabled.Cl.QUEUE_ON_DEVICE - Indicates that this 
		/// is a device queue. If Cl.QUEUE_ON_DEVICE is set, Cl.QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE must also be set. Only 
		/// out-of-order device queues are supported.Cl.QUEUE_ON_DEVICE_DEFAULT - indicates that this is the default device queue. 
		/// This can only be used with Cl.QUEUE_ON_DEVICE. The application must create the default device queue if any kernels 
		/// containing calls to get_default_queue are enqueued. There can only be one default device queue for each device within a 
		/// context. clCreateCommandQueueWithProperties with Cl.QUEUE_PROPERTIES set to Cl.QUEUE_ON_DEVICE | 
		/// Cl.QUEUE_ON_DEVICE_DEFAULT will return the default device queue that has already been created and increment its retain 
		/// count by 1. If Cl.QUEUE_PROPERTIES is not specified an in-order host command queue is created for the specified device.
		/// </para>
		/// <para>
		/// Cl.GetCommandQueueInfo: return type: cl_command_queue_properties Return the currently specified properties for the 
		/// command-queue. These properties are specified by the value associated with the Cl.COMMAND_QUEUE_PROPERTIES passed in 
		/// properties argument in Cl.CreateCommandQueueWithProperties.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_PROPERTIES = 0x1093;

		/// <summary>
		/// <para>
		/// Cl.CreateCommandQueueWithProperties: specifies the size of the device queue in bytes.This can only be specified if 
		/// Cl.QUEUE_ON_DEVICE is set in Cl.QUEUE_PROPERTIES. This must be a value ≤ Cl.DEVICE_QUEUE_ON_DEVICE_MAX_SIZE.For best 
		/// performance, this should be ≤ Cl.DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE.If Cl.QUEUE_SIZE is not specified, the device 
		/// queue is created with Cl.DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE as the size of the queue.
		/// </para>
		/// <para>
		/// Cl.GetCommandQueueInfo: return type: cl_uint Return the currently specified size for the device command-queue. This 
		/// query is only supported for device command queues.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_SIZE = 0x1094;

		/// <summary>
		/// Cl.GetCommandQueueInfo: return type: cl_command_queue Return the current default command queue for the underlying 
		/// device.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int QUEUE_DEVICE_DEFAULT = 0x1095;

		/// <summary>
		/// Value of CL_MEM_OBJECT_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_BUFFER = 0x10F0;

		/// <summary>
		/// Cl.CreateImage: cl.mage_row_pitch * image_height
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE2D = 0x10F1;

		/// <summary>
		/// Cl.CreateImage: cl.mage_slice_pitch * image_depth
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE3D = 0x10F2;

		/// <summary>
		/// Cl.CreateImage: cl.mage_slice_pitch * image_array_size
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE2D_ARRAY = 0x10F3;

		/// <summary>
		/// Cl.CreateImage: cl.mage_row_pitch
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE1D = 0x10F4;

		/// <summary>
		/// Cl.CreateImage: cl.mage_slice_pitch * image_array_size
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE1D_ARRAY = 0x10F5;

		/// <summary>
		/// Cl.CreateImage: cl.mage_row_pitch
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_IMAGE1D_BUFFER = 0x10F6;

		/// <summary>
		/// Value of CL_MEM_OBJECT_PIPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_PIPE = 0x10F7;

		/// <summary>
		/// Cl.GetMemObjectInfo: returns one of the following values: Cl.MEM_OBJECT_BUFFER if memobj is created with Cl.CreateBuffer 
		/// or Cl.CreateSubBuffer. cl_image_desc.image_type argument value if memobj is created with Cl.CreateImage. 
		/// Cl.MEM_OBJECT_PIPE if memobj is created with Cl.CreatePipe.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_TYPE = 0x1100;

		/// <summary>
		/// Cl.GetMemObjectInfo: returns the flags argument value specified when memobj is created with Cl.CreateBuffer, 
		/// Cl.CreateSubBuffer, Cl.CreateImage. or Cl.CreatePipe. If memobj is a sub-buffer the memory access qualifiers inherited 
		/// from parent buffer is also returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_FLAGS = 0x1101;

		/// <summary>
		/// Cl.GetMemObjectInfo: return actual size of the data store associated with memobj in bytes.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_SIZE = 0x1102;

		/// <summary>
		/// Cl.GetMemObjectInfo: if memobj is created with Cl.CreateBuffer or Cl.CreateImage and Cl.MEM_USE_HOST_PTR is specified in 
		/// mem_flags, return the host_ptr argument value specified when memobj is created. Otherwise a NULL value is returned. If 
		/// memobj is created with Cl.CreateSubBuffer, return the host_ptr + origin value specified when memobj is created. host_ptr 
		/// is the argument value specified to Cl.CreateBuffer and Cl.MEM_USE_HOST_PTR is specified in mem_flags for memory object 
		/// from which memobj is created. Otherwise a NULL value is returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_HOST_PTR = 0x1103;

		/// <summary>
		/// Cl.GetMemObjectInfo: map count. The map count returned should be considered immediately stale. It is unsuitable for 
		/// general use in applications. This feature is provided for debugging.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_MAP_COUNT = 0x1104;

		/// <summary>
		/// Cl.GetMemObjectInfo: return memobj reference count. The reference count returned should be considered immediately stale. 
		/// It is unsuitable for general use in applications. This feature is provided for identifying memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_REFERENCE_COUNT = 0x1105;

		/// <summary>
		/// Cl.GetMemObjectInfo: return context specified when memory object is created. If memobj is created using 
		/// Cl.CreateSubBuffer, the context associated with the memory object specified as the buffer argument to Cl.CreateSubBuffer 
		/// is returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_CONTEXT = 0x1106;

		/// <summary>
		/// Value of CL_MEM_ASSOCIATED_MEMOBJECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_ASSOCIATED_MEMOBJECT = 0x1107;

		/// <summary>
		/// Cl.GetMemObjectInfo: return offset if memobj is a sub-buffer object created using Cl.CreateSubBuffer. This returns 0 if 
		/// memobj is not a subbuffer object.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OFFSET = 0x1108;

		/// <summary>
		/// Cl.GetMemObjectInfo: return Cl.TRUE if memobj is a buffer object that was created with Cl.MEM_USE_HOST_PTR or is a 
		/// subbuffer object of a buffer object that was created with Cl.MEM_USE_HOST_PTR and the host_ptr specified when the buffer 
		/// object was created is a SVM pointer; otherwise returns Cl.FALSE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_USES_SVM_POINTER = 0x1109;

		/// <summary>
		/// Cl.GetImageInfo: return image format descriptor specified when image is created with Cl.CreateImage.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_FORMAT = 0x1110;

		/// <summary>
		/// Cl.GetImageInfo: return size of each element of the image memory object given by image in bytes. An element is made up 
		/// of n channels. The value of n is given in Cl._image_format descriptor.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_ELEMENT_SIZE = 0x1111;

		/// <summary>
		/// Cl.GetImageInfo: return calculated row pitch in bytes of a row of elements of the image object given by image.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_ROW_PITCH = 0x1112;

		/// <summary>
		/// Cl.GetImageInfo: return calculated slice pitch in bytes of a 2D slice for the 3D image object or size of each image in a 
		/// 1D or 2D image array given by image. For a 1D image, 1D image buffer and 2D image object return 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_SLICE_PITCH = 0x1113;

		/// <summary>
		/// Cl.GetImageInfo: return width of image in pixels.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_WIDTH = 0x1114;

		/// <summary>
		/// Cl.GetImageInfo: return height of image in pixels. For a 1D image, 1D image buffer and 1D image array object, height = 
		/// 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_HEIGHT = 0x1115;

		/// <summary>
		/// Cl.GetImageInfo: return depth of the image in pixels. For a 1D image, 1D image buffer, 2D image or 1D and 2D image array 
		/// object, depth = 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_DEPTH = 0x1116;

		/// <summary>
		/// Cl.GetImageInfo: return number of images in the image array. If image is not an image array, 0 is returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_ARRAY_SIZE = 0x1117;

		/// <summary>
		/// Value of CL_IMAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_BUFFER = 0x1118;

		/// <summary>
		/// Cl.GetImageInfo: return num_mip_levels associated with image.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_NUM_MIP_LEVELS = 0x1119;

		/// <summary>
		/// Cl.GetImageInfo: return num_samples associated with image.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_NUM_SAMPLES = 0x111A;

		/// <summary>
		/// Cl.GetPipeInfo: return pipe packet size specified when pipe is created with Cl.CreatePipe.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PIPE_PACKET_SIZE = 0x1120;

		/// <summary>
		/// Cl.GetPipeInfo: return max. number of packets specified when pipe is created with Cl.CreatePipe.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PIPE_MAX_PACKETS = 0x1121;

		/// <summary>
		/// Cl.GetSamplerInfo: return type: cl_uint Return the sampler reference count. The reference count returned should be 
		/// considered immediately stale. It is unsuitable for general use in applications. This feature is provided for identifying 
		/// memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_REFERENCE_COUNT = 0x1150;

		/// <summary>
		/// Cl.GetSamplerInfo: return type: cl_context Return the context specified when the sampler is created.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_CONTEXT = 0x1151;

		/// <summary>
		/// <para>
		/// Cl.CreateSamplerWithProperties: a boolean value that specifies whether the image coordinates specified are normalized or 
		/// not. The default value (i.e. the value used if this property is not specified in sampler_properties) is Cl.TRUE.
		/// </para>
		/// <para>
		/// Cl.GetSamplerInfo: return type: cl_bool Return the normalized coords value associated with sampler.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_NORMALIZED_COORDS = 0x1152;

		/// <summary>
		/// <para>
		/// Cl.CreateSamplerWithProperties: specifies how out-of-range image coordinates are handled when reading from an image. 
		/// Valid values are: Cl.ADDRESS_MIRRORED_REPEATCl.ADDRESS_REPEATCl.ADDRESS_CLAMP_TO_EDGECl.ADDRESS_CLAMPCl.ADDRESS_NONE The 
		/// default is Cl.ADDRESS_CLAMP.
		/// </para>
		/// <para>
		/// Cl.GetSamplerInfo: return type: cl_addressing_mode Return the addressing mode value associated with sampler.
		/// </para>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SAMPLER_ADDRESSING_MODE = 0x1153;

		/// <summary>
		/// <para>
		/// Cl.CreateSamplerWithProperties: specifies the type of filter that must be applied when reading an image. Valid values 
		/// are: Cl.FILTER_NEARESTCl.FILTER_LINEAR The default is Cl.FILTER_NEAREST.
		/// </para>
		/// <para>
		/// Cl.GetSamplerInfo: return type: cl_filter_mode Return the filter mode value associated with sampler.
		/// </para>
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
		/// Cl.GetProgramInfo: return type: cl_uint Return the program reference count.The reference count returned should be 
		/// considered immediately stale. It is unsuitable for general use in applications. This feature is provided for identifying 
		/// memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_REFERENCE_COUNT = 0x1160;

		/// <summary>
		/// Cl.GetProgramInfo: return type: cl_context Return the context specified when the program object is created
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_CONTEXT = 0x1161;

		/// <summary>
		/// Cl.GetProgramInfo: return type: cl_uint Return the number of devices associated with program.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_NUM_DEVICES = 0x1162;

		/// <summary>
		/// Cl.GetProgramInfo: return type: cl_device_id[] Return the list of devices associated with the program object. This can 
		/// be the devices associated with context on which the program object has been created or can be a subset of devices that 
		/// are specified when a progam object is created using Cl.CreateProgramWithBinary.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_DEVICES = 0x1163;

		/// <summary>
		/// Cl.GetProgramInfo: return type: char[] Return the program source code specified by Cl.CreateProgramWithSource. The 
		/// source string returned is a concatenation of all source strings specified to Cl.CreateProgramWithSource with a null 
		/// terminator. The concatenation strips any nulls in the original source strings. If program is created using 
		/// Cl.CreateProgramWithBinary, Cl.CreateProgramWithIL, or Cl.CreateProgramWithBuiltInKernels, a null string or the 
		/// appropriate program source code is returned depending on whether or not the program source code is stored in the binary. 
		/// The actual number of characters that represents the program source code including the null terminator is returned in 
		/// param_value_size_ret.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_SOURCE = 0x1164;

		/// <summary>
		/// Cl.GetProgramInfo: return type: size_t[] Returns an array that contains the size in bytes of the program binary (could 
		/// be an executable binary, compiled binary or library binary) for each device associated with program. The size of the 
		/// array is the number of devices associated with program. If a binary is not available for a device(s), a size of zero is 
		/// returned. If program is created using Cl.CreateProgramWithBuiltInKernels, the implementation may return zero in any 
		/// entries of the returned array.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARY_SIZES = 0x1165;

		/// <summary>
		/// Cl.GetProgramInfo: return type: unsigned char *[] Return the program binaries (could be an executable binary, compiled 
		/// binary or library binary) for all devices associated with program. For each device in program, the binary returned can 
		/// be the binary specified for the device when program is created with Cl.CreateProgramWithBinary or it can be the 
		/// executable binary generated by Cl.BuildProgram or Cl.LinkProgram. If program is created with Cl.CreateProgramWithSource 
		/// or Cl.CreateProgramWithIL, the binary returned is the binary generated by Cl.BuildProgram, Cl.CompileProgram, or 
		/// Cl.LinkProgram. The bits returned can be an implementation-specific intermediate representation (a.k.a. IR) or device 
		/// specific executable bits or both. The decision on which information is returned in the binary is up to the OpenCL 
		/// implementation. param_value points to an array of n pointers allocated by the caller, where n is the number of devices 
		/// associated with program. The buffer sizes needed to allocate the memory that these n pointers refer to can be queried 
		/// using the Cl.PROGRAM_BINARY_SIZES query as described in this table. Each entry in this array is used by the 
		/// implementation as the location in memory where to copy the program binary for a specific device, if there is a binary 
		/// available. To find out which device the program binary in the array refers to, use the Cl.PROGRAM_DEVICES query to get 
		/// the list of devices. There is a one-to-one correspondence between the array of n pointers returned by 
		/// Cl.PROGRAM_BINARIES and array of devices returned by Cl.PROGRAM_DEVICES. If an entry value in the array is NULL, the 
		/// implementation skips copying the program binary for the specific device identified by the array index.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_BINARIES = 0x1166;

		/// <summary>
		/// Cl.GetProgramInfo: return type: size_t Returns the number of kernels declared in program that can be created with 
		/// Cl.CreateKernel. This information is only available after a successful program executable has been built for at least 
		/// one device in the list of devices associated with program.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_NUM_KERNELS = 0x1167;

		/// <summary>
		/// Cl.GetProgramInfo: return type: char[] Returns a semi-colon separated list of kernel names in program that can be 
		/// created with Cl.CreateKernel. This information is only available after a successful program executable has been built 
		/// for at least one device in the list of devices associated with program.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_KERNEL_NAMES = 0x1168;

		/// <summary>
		/// Cl.GetProgramInfo: return type: void * Returns the program IL for programs created with Cl.CreateProgramWithIL. If 
		/// program is created with Cl.CreateProgramWithSource, Cl.CreateProgramWithBinary or Cl.CreateProgramWithBuiltInKernels the 
		/// memory pointed to by param_value will be unchanged and param_value_size_ret will be set to 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROGRAM_IL = 0x1169;

		/// <summary>
		/// Cl.GetProgramBuildInfo: return type: cl_build_status Returns the build, compile or link status, whichever was performed 
		/// last on program for device. This can be one of the following: Cl.BUILD_NONE. The build status returned if no 
		/// Cl.BuildProgram, Cl.CompileProgram or Cl.LinkProgram has been performed on the specified program object for device. 
		/// Cl.BUILD_ERROR. The build status returned if Cl.BuildProgram, Cl.CompileProgram or Cl.LinkProgram whichever was 
		/// performed last on the specified program object for device generated an error. Cl.BUILD_SUCCESS. The build status 
		/// returned if Cl.BuildProgram, Cl.CompileProgram or Cl.LinkProgram whichever was performed last on the specified program 
		/// object for device was successful. Cl.BUILD_IN_PROGRESS. The build status returned if Cl.BuildProgram, Cl.CompileProgram 
		/// or Cl.LinkProgram whichever was performed last on the specified program object for device has not finished.
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
		/// Cl.GetKernelInfo: return the kernel function name.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_FUNCTION_NAME = 0x1190;

		/// <summary>
		/// Cl.GetKernelInfo: return the number of arguments to kernel.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_NUM_ARGS = 0x1191;

		/// <summary>
		/// Cl.GetKernelInfo: return the kernel reference count. The reference count returned should be considered immediately 
		/// stale. It is unsuitable for general use in applications. This feature is provided for identifying memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_REFERENCE_COUNT = 0x1192;

		/// <summary>
		/// Cl.GetKernelInfo: return the context associated with kernel.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_CONTEXT = 0x1193;

		/// <summary>
		/// Cl.GetKernelInfo: return the program object associated with kernel.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_PROGRAM = 0x1194;

		/// <summary>
		/// Cl.GetKernelInfo: returns any attributes specified using the __Cl.tribute__ qualifier with the kernel function 
		/// declaration in the program source. These attributes include those on the __Cl.tribute__ page and other attributes 
		/// supported by an implementation. Attributes are returned as they were declared inside __Cl.tribute__((...)), with any 
		/// surrounding whitespace and embedded newlines removed. When multiple attributes are present, they are returned as a 
		/// single, space delimited string. For kernels not created from OpenCL C source and the Cl.CreateProgramWithSource API call 
		/// the string returned from this query will be empty.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ATTRIBUTES = 0x1195;

		/// <summary>
		/// Cl.GetKernelSubGroupInfo: this provides a mechanism for the application to query the maximum number of sub-groups that 
		/// may make up each work-group to execute a kernel on a specific device given by device. The OpenCL implementation uses the 
		/// resource requirements of the kernel (register usage etc.) to determine what this work-group size should be. The returned 
		/// value may be used to compute a work-group size to enqueue the kernel with to give a round number of sub-groups for an 
		/// enqueue.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_MAX_NUM_SUB_GROUPS = 0x11B9;

		/// <summary>
		/// Cl.GetKernelSubGroupInfo: returns the number of sub-groups specified in the kernel source or IL. If the sub-group count 
		/// is not specified using the above attribute then 0 is returned.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_COMPILE_NUM_SUB_GROUPS = 0x11BA;

		/// <summary>
		/// Cl.GetKernelWorkGroupInfo: this provides a mechanism for the application to query the maximum work-group size that can 
		/// be used to execute the kernel on a specific device given by device. The OpenCL implementation uses the resource 
		/// requirements of the kernel (register usage etc.) to determine what this work-group size should be. As a result and 
		/// unlike Cl.DEVICE_MAX_WORK_GROUP_SIZE this value may vary from one kernel to another as well as one device to another. 
		/// Cl.KERNEL_WORK_GROUP_SIZE will be less than or equal to Cl.DEVICE_MAX_WORK_GROUP_SIZE for a given kernel object.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_WORK_GROUP_SIZE = 0x11B0;

		/// <summary>
		/// Value of CL_KERNEL_COMPILE_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_COMPILE_WORK_GROUP_SIZE = 0x11B1;

		/// <summary>
		/// Cl.GetKernelWorkGroupInfo: returns the amount of local memory in bytes being used by a kernel. This includes local 
		/// memory that may be needed by an implementation to execute the kernel, variables declared inside the kernel with the 
		/// Cl.local address qualifier and local memory to be allocated for arguments to the kernel declared as pointers with the 
		/// Cl.local address qualifier and whose size is specified with Cl.SetKernelArg. If the local memory size, for any pointer 
		/// argument to the kernel declared with the Cl.local address qualifier, is not specified, its size is assumed to be 0.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_LOCAL_MEM_SIZE = 0x11B2;

		/// <summary>
		/// Value of CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x11B3;

		/// <summary>
		/// Cl.GetKernelWorkGroupInfo: returns the minimum amount of private memory, in bytes, used by each work-item in the kernel. 
		/// This value may include any private memory needed by an implementation to execute the kernel, including that used by the 
		/// language built-ins and variable declared inside the kernel with the Cl.private qualifier.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_PRIVATE_MEM_SIZE = 0x11B4;

		/// <summary>
		/// Cl.GetKernelWorkGroupInfo: this provides a mechanism for the application to query the maximum global size that can be 
		/// used to execute a kernel (i.e. global_work_size argument to Cl.EnqueueNDRangeKernel) on a custom device given by device 
		/// or a built-in kernel on an OpenCL device given by device. If device is not a custom device or kernel is not a built-in 
		/// kernel, clGetKernelWorkGroupInfo returns the error Cl.INVALID_VALUE.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_GLOBAL_WORK_SIZE = 0x11B5;

		/// <summary>
		/// Cl.GetEventInfo: return the command-queue associated with event. For user event objects, a NULL value is returned. If 
		/// the Cl._khr_gl_sharing extension is enabled, the command queue of a linked event NULL, because the event is not 
		/// associated with any OpenCL command queue. If the Cl._khr_egl_event extension is enabled, the Cl.EVENT_COMMAND_QUEUE of a 
		/// linked event is NULL, because the event is not associated with any OpenCL command queue.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_COMMAND_QUEUE = 0x11D0;

		/// <summary>
		/// Cl.GetEventInfo: return the command associated with event. Can be one of the following 
		/// values:Cl.COMMAND_NDRANGE_KERNELCL_COMMAND_NATIVE_KERNELCL_COMMAND_READ_BUFFERCL_COMMAND_WRITE_BUFFERCL_COMMAND_COPY_BUFFERCL_COMMAND_READ_IMAGECL_COMMAND_WRITE_IMAGECL_COMMAND_COPY_IMAGECL_COMMAND_COPY_BUFFER_TO_IMAGECL_COMMAND_COPY_IMAGE_TO_BUFFERCL_COMMAND_MAP_BUFFERCL_COMMAND_MAP_IMAGECL_COMMAND_UNMAP_MEM_OBJECTCL_COMMAND_MARKERCL_COMMAND_ACQUIRE_GL_OBJECTSCL_COMMAND_RELEASE_GL_OBJECTSCL_COMMAND_READ_BUFFER_RECTCL_COMMAND_WRITE_BUFFER_RECTCL_COMMAND_COPY_BUFFER_RECTCL_COMMAND_USERCL_COMMAND_BARRIERCL_COMMAND_MIGRATE_MEM_OBJECTSCL_COMMAND_FILL_BUFFERCL_COMMAND_FILL_IMAGECL_COMMAND_SVM_FREECL_COMMAND_SVM_MEMCPYCL_COMMAND_SVM_MEMFILLCL_COMMAND_SVM_MAPCL_COMMAND_SVM_UNMAPCL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR 
		/// (if Cl._khr_gl_event is enabled, indicating that the event is associated with a GL sync object, rather than an OpenCL 
		/// command)Cl.COMMAND_ACQUIRE_D3D10_OBJECTS_KHR (if Cl._khr_d3d10_sharing is enabled)Cl.COMMAND_RELEASE_D3D10_OBJECTS_KHR 
		/// (if Cl._khr_d3d10_sharing is enabled)Cl.COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR (if Cl._khr_dx9_media_sharing is 
		/// enabled)Cl.COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR (if Cl._khr_dx9_media_sharing is 
		/// enabled)Cl.COMMAND_ACQUIRE_D3D11_OBJECTS_KHR (if Cl._khr_d3d11_sharing is enabled)Cl.COMMAND_RELEASE_D3D11_OBJECTS_KHR 
		/// (if Cl._khr_d3d11_sharing is enabled)Cl.COMMAND_EGL_FENCE_SYNC_OBJECT_KHR (if Cl._khr_egl_event is enabled)
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_COMMAND_TYPE = 0x11D1;

		/// <summary>
		/// Cl.GetEventInfo: return the event reference count. The reference count returned should be considered immediately stale. 
		/// It is unsuitable for general use in applications. This feature is provided for identifying memory leaks.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_REFERENCE_COUNT = 0x11D2;

		/// <summary>
		/// Value of CL_EVENT_COMMAND_EXECUTION_STATUS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_COMMAND_EXECUTION_STATUS = 0x11D3;

		/// <summary>
		/// Cl.GetEventInfo: return the context associated with event.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EVENT_CONTEXT = 0x11D4;

		/// <summary>
		/// Cl.GetEventProfilingInfo: a 64-bit value that describes the current device time counter in nanoseconds when the command 
		/// identified by event is enqueued in a command-queue by the host.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_QUEUED = 0x1280;

		/// <summary>
		/// Cl.GetEventProfilingInfo: a 64-bit value that describes the current device time counter in nanoseconds when the command 
		/// identified by event that has been enqueued is submitted by the host to the device associated with the command-queue.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_SUBMIT = 0x1281;

		/// <summary>
		/// Cl.GetEventProfilingInfo: a 64-bit value that describes the current device time counter in nanoseconds when the command 
		/// identified by event starts execution on the device.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_START = 0x1282;

		/// <summary>
		/// Cl.GetEventProfilingInfo: a 64-bit value that describes the current device time counter in nanoseconds when the command 
		/// identified by event has finished execution on the device.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_COMMAND_END = 0x1283;

		/// <summary>
		/// Cl.GetEventProfilingInfo: a 64-bit value that describes the current device time counter in nanoseconds when the command 
		/// identified by event and any child commands enqueued by this command on the device have finished execution.
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

		/// <summary>
		/// Value of CL_SUCCESS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SUCCESS = 0;

		/// <summary>
		/// Value of CL_DEVICE_NOT_FOUND symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NOT_FOUND = -1;

		/// <summary>
		/// Value of CL_DEVICE_NOT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_NOT_AVAILABLE = -2;

		/// <summary>
		/// Value of CL_COMPILER_NOT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMPILER_NOT_AVAILABLE = -3;

		/// <summary>
		/// Value of CL_MEM_OBJECT_ALLOCATION_FAILURE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_OBJECT_ALLOCATION_FAILURE = -4;

		/// <summary>
		/// Value of CL_OUT_OF_RESOURCES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int OUT_OF_RESOURCES = -5;

		/// <summary>
		/// Value of CL_OUT_OF_HOST_MEMORY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int OUT_OF_HOST_MEMORY = -6;

		/// <summary>
		/// Value of CL_PROFILING_INFO_NOT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int PROFILING_INFO_NOT_AVAILABLE = -7;

		/// <summary>
		/// Value of CL_MEM_COPY_OVERLAP symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MEM_COPY_OVERLAP = -8;

		/// <summary>
		/// Value of CL_IMAGE_FORMAT_MISMATCH symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_FORMAT_MISMATCH = -9;

		/// <summary>
		/// Value of CL_IMAGE_FORMAT_NOT_SUPPORTED symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int IMAGE_FORMAT_NOT_SUPPORTED = -10;

		/// <summary>
		/// Value of CL_BUILD_PROGRAM_FAILURE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int BUILD_PROGRAM_FAILURE = -11;

		/// <summary>
		/// Value of CL_MAP_FAILURE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MAP_FAILURE = -12;

		/// <summary>
		/// Value of CL_MISALIGNED_SUB_BUFFER_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int MISALIGNED_SUB_BUFFER_OFFSET = -13;

		/// <summary>
		/// Value of CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST = -14;

		/// <summary>
		/// Value of CL_COMPILE_PROGRAM_FAILURE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMPILE_PROGRAM_FAILURE = -15;

		/// <summary>
		/// Value of CL_LINKER_NOT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int LINKER_NOT_AVAILABLE = -16;

		/// <summary>
		/// Value of CL_LINK_PROGRAM_FAILURE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int LINK_PROGRAM_FAILURE = -17;

		/// <summary>
		/// Value of CL_DEVICE_PARTITION_FAILED symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEVICE_PARTITION_FAILED = -18;

		/// <summary>
		/// Value of CL_KERNEL_ARG_INFO_NOT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_INFO_NOT_AVAILABLE = -19;

		/// <summary>
		/// Value of CL_INVALID_VALUE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_VALUE = -30;

		/// <summary>
		/// Value of CL_INVALID_DEVICE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_DEVICE_TYPE = -31;

		/// <summary>
		/// Value of CL_INVALID_PLATFORM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_PLATFORM = -32;

		/// <summary>
		/// Value of CL_INVALID_DEVICE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_DEVICE = -33;

		/// <summary>
		/// Value of CL_INVALID_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_CONTEXT = -34;

		/// <summary>
		/// Value of CL_INVALID_QUEUE_PROPERTIES symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_QUEUE_PROPERTIES = -35;

		/// <summary>
		/// Value of CL_INVALID_COMMAND_QUEUE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_COMMAND_QUEUE = -36;

		/// <summary>
		/// Value of CL_INVALID_HOST_PTR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_HOST_PTR = -37;

		/// <summary>
		/// Value of CL_INVALID_MEM_OBJECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_MEM_OBJECT = -38;

		/// <summary>
		/// Value of CL_INVALID_IMAGE_FORMAT_DESCRIPTOR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_IMAGE_FORMAT_DESCRIPTOR = -39;

		/// <summary>
		/// Value of CL_INVALID_IMAGE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_IMAGE_SIZE = -40;

		/// <summary>
		/// Value of CL_INVALID_SAMPLER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_SAMPLER = -41;

		/// <summary>
		/// Value of CL_INVALID_BINARY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_BINARY = -42;

		/// <summary>
		/// Value of CL_INVALID_BUILD_OPTIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_BUILD_OPTIONS = -43;

		/// <summary>
		/// Value of CL_INVALID_PROGRAM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_PROGRAM = -44;

		/// <summary>
		/// Value of CL_INVALID_PROGRAM_EXECUTABLE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_PROGRAM_EXECUTABLE = -45;

		/// <summary>
		/// Value of CL_INVALID_KERNEL_NAME symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_KERNEL_NAME = -46;

		/// <summary>
		/// Value of CL_INVALID_KERNEL_DEFINITION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_KERNEL_DEFINITION = -47;

		/// <summary>
		/// Value of CL_INVALID_KERNEL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_KERNEL = -48;

		/// <summary>
		/// Value of CL_INVALID_ARG_INDEX symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_ARG_INDEX = -49;

		/// <summary>
		/// Value of CL_INVALID_ARG_VALUE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_ARG_VALUE = -50;

		/// <summary>
		/// Value of CL_INVALID_ARG_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_ARG_SIZE = -51;

		/// <summary>
		/// Value of CL_INVALID_KERNEL_ARGS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_KERNEL_ARGS = -52;

		/// <summary>
		/// Value of CL_INVALID_WORK_DIMENSION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_WORK_DIMENSION = -53;

		/// <summary>
		/// Value of CL_INVALID_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_WORK_GROUP_SIZE = -54;

		/// <summary>
		/// Value of CL_INVALID_WORK_ITEM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_WORK_ITEM_SIZE = -55;

		/// <summary>
		/// Value of CL_INVALID_GLOBAL_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_GLOBAL_OFFSET = -56;

		/// <summary>
		/// Value of CL_INVALID_EVENT_WAIT_LIST symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_EVENT_WAIT_LIST = -57;

		/// <summary>
		/// Value of CL_INVALID_EVENT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_EVENT = -58;

		/// <summary>
		/// Value of CL_INVALID_OPERATION symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_OPERATION = -59;

		/// <summary>
		/// Value of CL_INVALID_GL_OBJECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_GL_OBJECT = -60;

		/// <summary>
		/// Value of CL_INVALID_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_BUFFER_SIZE = -61;

		/// <summary>
		/// Value of CL_INVALID_MIP_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_MIP_LEVEL = -62;

		/// <summary>
		/// Value of CL_INVALID_GLOBAL_WORK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_GLOBAL_WORK_SIZE = -63;

		/// <summary>
		/// Value of CL_INVALID_PROPERTY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_PROPERTY = -64;

		/// <summary>
		/// Value of CL_INVALID_IMAGE_DESCRIPTOR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_IMAGE_DESCRIPTOR = -65;

		/// <summary>
		/// Value of CL_INVALID_COMPILER_OPTIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_COMPILER_OPTIONS = -66;

		/// <summary>
		/// Value of CL_INVALID_LINKER_OPTIONS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_LINKER_OPTIONS = -67;

		/// <summary>
		/// Value of CL_INVALID_DEVICE_PARTITION_COUNT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_DEVICE_PARTITION_COUNT = -68;

		/// <summary>
		/// Value of CL_INVALID_PIPE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_PIPE_SIZE = -69;

		/// <summary>
		/// Value of CL_INVALID_DEVICE_QUEUE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INVALID_DEVICE_QUEUE = -70;

		/// <summary>
		/// Value of CL_FP_DENORM symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_DENORM = (1 << 0);

		/// <summary>
		/// Value of CL_FP_INF_NAN symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_INF_NAN = (1 << 1);

		/// <summary>
		/// Value of CL_FP_ROUND_TO_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_ROUND_TO_NEAREST = (1 << 2);

		/// <summary>
		/// Value of CL_FP_ROUND_TO_ZERO symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_ROUND_TO_ZERO = (1 << 3);

		/// <summary>
		/// Value of CL_FP_ROUND_TO_INF symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_ROUND_TO_INF = (1 << 4);

		/// <summary>
		/// Value of CL_FP_FMA symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_FMA = (1 << 5);

		/// <summary>
		/// Value of CL_FP_SOFT_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_SOFT_FLOAT = (1 << 6);

		/// <summary>
		/// Value of CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int FP_CORRECTLY_ROUNDED_DIVIDE_SQRT = (1 << 7);

		/// <summary>
		/// Value of CL_NONE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int NONE = 0x0;

		/// <summary>
		/// Value of CL_READ_ONLY_CACHE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int READ_ONLY_CACHE = 0x1;

		/// <summary>
		/// Value of CL_READ_WRITE_CACHE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int READ_WRITE_CACHE = 0x2;

		/// <summary>
		/// Value of CL_LOCAL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int LOCAL = 0x1;

		/// <summary>
		/// Value of CL_GLOBAL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int GLOBAL = 0x2;

		/// <summary>
		/// Value of CL_EXEC_KERNEL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int EXEC_KERNEL = (1 << 0);

		/// <summary>
		/// Value of CL_EXEC_NATIVE_KERNEL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int EXEC_NATIVE_KERNEL = (1 << 1);

		/// <summary>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE = (1 << 0);

		/// <summary>
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int QUEUE_PROFILING_ENABLE = (1 << 1);

		/// <summary>
		/// Value of CL_QUEUE_ON_DEVICE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int QUEUE_ON_DEVICE = (1 << 2);

		/// <summary>
		/// Value of CL_QUEUE_ON_DEVICE_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		[Log(BitmaskName = "cl")]
		public const int QUEUE_ON_DEVICE_DEFAULT = (1 << 3);

		/// <summary>
		/// Value of CL_R symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int R = 0x10B0;

		/// <summary>
		/// Value of CL_A symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int A = 0x10B1;

		/// <summary>
		/// Value of CL_RG symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int RG = 0x10B2;

		/// <summary>
		/// Value of CL_RA symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int RA = 0x10B3;

		/// <summary>
		/// Cl.CreateImage: cl.sRGB
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int RGB = 0x10B4;

		/// <summary>
		/// Cl.CreateImage: cl.sRGBA
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int RGBA = 0x10B5;

		/// <summary>
		/// Cl.CreateImage: cl.sBGRA
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int BGRA = 0x10B6;

		/// <summary>
		/// Value of CL_ARGB symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ARGB = 0x10B7;

		/// <summary>
		/// Value of CL_INTENSITY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int INTENSITY = 0x10B8;

		/// <summary>
		/// Value of CL_LUMINANCE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int LUMINANCE = 0x10B9;

		/// <summary>
		/// Value of CL_Rx symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int Rx = 0x10BA;

		/// <summary>
		/// Value of CL_RGx symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int RGx = 0x10BB;

		/// <summary>
		/// Cl.CreateImage: cl.sRGBx
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int RGBx = 0x10BC;

		/// <summary>
		/// Cl.CreateImage: cl.R
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEPTH = 0x10BD;

		/// <summary>
		/// Value of CL_DEPTH_STENCIL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int DEPTH_STENCIL = 0x10BE;

		/// <summary>
		/// Cl.CreateImage: cl.RGB
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int sRGB = 0x10BF;

		/// <summary>
		/// Cl.CreateImage: cl.RGBx
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int sRGBx = 0x10C0;

		/// <summary>
		/// Cl.CreateImage: cl.RGBA
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int sRGBA = 0x10C1;

		/// <summary>
		/// Cl.CreateImage: cl.BGRA
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int sBGRA = 0x10C2;

		/// <summary>
		/// Value of CL_ABGR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ABGR = 0x10C3;

		/// <summary>
		/// Value of CL_SNORM_INT8 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SNORM_INT8 = 0x10D0;

		/// <summary>
		/// Value of CL_SNORM_INT16 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SNORM_INT16 = 0x10D1;

		/// <summary>
		/// Value of CL_UNORM_INT8 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_INT8 = 0x10D2;

		/// <summary>
		/// Value of CL_UNORM_INT16 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_INT16 = 0x10D3;

		/// <summary>
		/// Value of CL_UNORM_SHORT_565 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_SHORT_565 = 0x10D4;

		/// <summary>
		/// Value of CL_UNORM_SHORT_555 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_SHORT_555 = 0x10D5;

		/// <summary>
		/// Value of CL_UNORM_INT_101010 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_INT_101010 = 0x10D6;

		/// <summary>
		/// Value of CL_SIGNED_INT8 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SIGNED_INT8 = 0x10D7;

		/// <summary>
		/// Value of CL_SIGNED_INT16 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SIGNED_INT16 = 0x10D8;

		/// <summary>
		/// Value of CL_SIGNED_INT32 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int SIGNED_INT32 = 0x10D9;

		/// <summary>
		/// Value of CL_UNSIGNED_INT8 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNSIGNED_INT8 = 0x10DA;

		/// <summary>
		/// Value of CL_UNSIGNED_INT16 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNSIGNED_INT16 = 0x10DB;

		/// <summary>
		/// Value of CL_UNSIGNED_INT32 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNSIGNED_INT32 = 0x10DC;

		/// <summary>
		/// Value of CL_HALF_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int HALF_FLOAT = 0x10DD;

		/// <summary>
		/// Value of CL_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int FLOAT = 0x10DE;

		/// <summary>
		/// Value of CL_UNORM_INT24 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_INT24 = 0x10DF;

		/// <summary>
		/// Value of CL_UNORM_INT_101010_2 symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int UNORM_INT_101010_2 = 0x10E0;

		/// <summary>
		/// Value of CL_ADDRESS_NONE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ADDRESS_NONE = 0x1130;

		/// <summary>
		/// Value of CL_ADDRESS_CLAMP_TO_EDGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ADDRESS_CLAMP_TO_EDGE = 0x1131;

		/// <summary>
		/// Value of CL_ADDRESS_CLAMP symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ADDRESS_CLAMP = 0x1132;

		/// <summary>
		/// Value of CL_ADDRESS_REPEAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ADDRESS_REPEAT = 0x1133;

		/// <summary>
		/// Value of CL_ADDRESS_MIRRORED_REPEAT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int ADDRESS_MIRRORED_REPEAT = 0x1134;

		/// <summary>
		/// Value of CL_FILTER_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int FILTER_NEAREST = 0x1140;

		/// <summary>
		/// Value of CL_FILTER_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int FILTER_LINEAR = 0x1141;

		/// <summary>
		/// Value of CL_BUILD_SUCCESS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int BUILD_SUCCESS = 0;

		/// <summary>
		/// Value of CL_BUILD_NONE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int BUILD_NONE = -1;

		/// <summary>
		/// Value of CL_BUILD_ERROR symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int BUILD_ERROR = -2;

		/// <summary>
		/// Value of CL_BUILD_IN_PROGRESS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int BUILD_IN_PROGRESS = -3;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ADDRESS_GLOBAL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ADDRESS_GLOBAL = 0x119B;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ADDRESS_LOCAL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ADDRESS_LOCAL = 0x119C;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ADDRESS_CONSTANT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ADDRESS_CONSTANT = 0x119D;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ADDRESS_PRIVATE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ADDRESS_PRIVATE = 0x119E;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ACCESS_READ_ONLY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ACCESS_READ_ONLY = 0x11A0;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ACCESS_WRITE_ONLY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ACCESS_WRITE_ONLY = 0x11A1;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ACCESS_READ_WRITE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ACCESS_READ_WRITE = 0x11A2;

		/// <summary>
		/// Value of CL_KERNEL_ARG_ACCESS_NONE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_ACCESS_NONE = 0x11A3;

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_NONE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_TYPE_NONE = 0;

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_CONST symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_TYPE_CONST = (1 << 0);

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_RESTRICT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_TYPE_RESTRICT = (1 << 1);

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_VOLATILE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_TYPE_VOLATILE = (1 << 2);

		/// <summary>
		/// Value of CL_KERNEL_ARG_TYPE_PIPE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int KERNEL_ARG_TYPE_PIPE = (1 << 3);

		/// <summary>
		/// Value of CL_COMMAND_NDRANGE_KERNEL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_NDRANGE_KERNEL = 0x11F0;

		/// <summary>
		/// Value of CL_COMMAND_TASK symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_TASK = 0x11F1;

		/// <summary>
		/// Value of CL_COMMAND_NATIVE_KERNEL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_NATIVE_KERNEL = 0x11F2;

		/// <summary>
		/// Value of CL_COMMAND_READ_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_READ_BUFFER = 0x11F3;

		/// <summary>
		/// Value of CL_COMMAND_WRITE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_WRITE_BUFFER = 0x11F4;

		/// <summary>
		/// Value of CL_COMMAND_COPY_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_COPY_BUFFER = 0x11F5;

		/// <summary>
		/// Value of CL_COMMAND_READ_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_READ_IMAGE = 0x11F6;

		/// <summary>
		/// Value of CL_COMMAND_WRITE_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_WRITE_IMAGE = 0x11F7;

		/// <summary>
		/// Value of CL_COMMAND_COPY_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_COPY_IMAGE = 0x11F8;

		/// <summary>
		/// Value of CL_COMMAND_COPY_IMAGE_TO_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_COPY_IMAGE_TO_BUFFER = 0x11F9;

		/// <summary>
		/// Value of CL_COMMAND_COPY_BUFFER_TO_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_COPY_BUFFER_TO_IMAGE = 0x11FA;

		/// <summary>
		/// Value of CL_COMMAND_MAP_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_MAP_BUFFER = 0x11FB;

		/// <summary>
		/// Value of CL_COMMAND_MAP_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_MAP_IMAGE = 0x11FC;

		/// <summary>
		/// Value of CL_COMMAND_UNMAP_MEM_OBJECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_UNMAP_MEM_OBJECT = 0x11FD;

		/// <summary>
		/// Value of CL_COMMAND_MARKER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_MARKER = 0x11FE;

		/// <summary>
		/// Value of CL_COMMAND_ACQUIRE_GL_OBJECTS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_ACQUIRE_GL_OBJECTS = 0x11FF;

		/// <summary>
		/// Value of CL_COMMAND_RELEASE_GL_OBJECTS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_RELEASE_GL_OBJECTS = 0x1200;

		/// <summary>
		/// Value of CL_COMMAND_READ_BUFFER_RECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_READ_BUFFER_RECT = 0x1201;

		/// <summary>
		/// Value of CL_COMMAND_WRITE_BUFFER_RECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_WRITE_BUFFER_RECT = 0x1202;

		/// <summary>
		/// Value of CL_COMMAND_COPY_BUFFER_RECT symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_COPY_BUFFER_RECT = 0x1203;

		/// <summary>
		/// Value of CL_COMMAND_USER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_USER = 0x1204;

		/// <summary>
		/// Value of CL_COMMAND_BARRIER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_BARRIER = 0x1205;

		/// <summary>
		/// Value of CL_COMMAND_MIGRATE_MEM_OBJECTS symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_MIGRATE_MEM_OBJECTS = 0x1206;

		/// <summary>
		/// Value of CL_COMMAND_FILL_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_FILL_BUFFER = 0x1207;

		/// <summary>
		/// Value of CL_COMMAND_FILL_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_FILL_IMAGE = 0x1208;

		/// <summary>
		/// Value of CL_COMMAND_SVM_FREE symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_SVM_FREE = 0x1209;

		/// <summary>
		/// Value of CL_COMMAND_SVM_MEMCPY symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_SVM_MEMCPY = 0x120A;

		/// <summary>
		/// Value of CL_COMMAND_SVM_MEMFILL symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_SVM_MEMFILL = 0x120B;

		/// <summary>
		/// Value of CL_COMMAND_SVM_MAP symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_SVM_MAP = 0x120C;

		/// <summary>
		/// Value of CL_COMMAND_SVM_UNMAP symbol.
		/// </summary>
		[RequiredByFeature("CL_VERSION_1_0")]
		public const int COMMAND_SVM_UNMAP = 0x120D;

		/// <summary>
		/// Obtain the list of platforms available.
		/// </summary>
		/// <param name="num_entries">
		/// The number of cl_platform_id entries that can be added to platforms. If platforms is not NULL, the num_entries must be 
		/// greater than zero.
		/// </param>
		/// <param name="platforms">
		/// Returns a list of OpenCL platforms found. The cl_platform_id values returned in platforms can be used to identify a 
		/// specific OpenCL platform. If platforms argument is NULL, this argument is ignored. The number of OpenCL platforms 
		/// returned is the mininum of the value specified by num_entries or the number of OpenCL platforms available.
		/// </param>
		/// <param name="num_platforms">
		/// Returns the number of OpenCL platforms available. If num_platforms is NULL, this argument is ignored.
		/// </param>
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

		/// <summary>
		/// Obtain the list of platforms available.
		/// </summary>
		/// <param name="num_entries">
		/// The number of cl_platform_id entries that can be added to platforms. If platforms is not NULL, the num_entries must be 
		/// greater than zero.
		/// </param>
		/// <param name="platforms">
		/// Returns a list of OpenCL platforms found. The cl_platform_id values returned in platforms can be used to identify a 
		/// specific OpenCL platform. If platforms argument is NULL, this argument is ignored. The number of OpenCL platforms 
		/// returned is the mininum of the value specified by num_entries or the number of OpenCL platforms available.
		/// </param>
		/// <param name="num_platforms">
		/// Returns the number of OpenCL platforms available. If num_platforms is NULL, this argument is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformIDs(uint num_entries, [Out] IntPtr[] platforms, out uint num_platforms)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_platforms = platforms)
				fixed (uint* p_num_platforms = &num_platforms)
				{
					Debug.Assert(Delegates.pclGetPlatformIDs != null, "pclGetPlatformIDs not implemented");
					retValue = Delegates.pclGetPlatformIDs(num_entries, p_platforms, p_num_platforms);
					LogFunction("clGetPlatformIDs({0}, {1}, {2}) = {3}", num_entries, LogValue(platforms), num_platforms, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get specific information about the OpenCL platform.
		/// </summary>
		/// <param name="platform">
		/// The platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the platform information being queried. It can be one of the values specified in 
		/// the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size in bytes must be ≥ size of return type 
		/// specified in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory location where appropriate values for a given param_name will be returned. Possible param_value 
		/// values returned are listed in the table below. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetPlatformInfo != null, "pclGetPlatformInfo not implemented");
					retValue = Delegates.pclGetPlatformInfo(platform, (PlatformInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetPlatformInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", platform.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get specific information about the OpenCL platform.
		/// </summary>
		/// <param name="platform">
		/// The platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the platform information being queried. It can be one of the values specified in 
		/// the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size in bytes must be ≥ size of return type 
		/// specified in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory location where appropriate values for a given param_name will be returned. Possible param_value 
		/// values returned are listed in the table below. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformInfo(Object platform, PlatformInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_platform = GCHandle.Alloc(platform, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetPlatformInfo(pin_platform.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_platform.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Get specific information about the OpenCL platform.
		/// </summary>
		/// <param name="platform">
		/// The platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the platform information being queried. It can be one of the values specified in 
		/// the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size in bytes must be ≥ size of return type 
		/// specified in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory location where appropriate values for a given param_name will be returned. Possible param_value 
		/// values returned are listed in the table below. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, uint param_value_size, IntPtr param_value, out uint param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = &param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetPlatformInfo != null, "pclGetPlatformInfo not implemented");
					retValue = Delegates.pclGetPlatformInfo(platform, param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetPlatformInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", platform.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), param_value_size_ret, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Obtain the list of devices available on a platform.
		/// </summary>
		/// <param name="platform">
		/// Refers to the platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="device_type">
		/// A bitfield that identifies the type of OpenCL device. The device_type can be used to query specific OpenCL devices or 
		/// all OpenCL devices available. The valid values for device_type are specified in the following table.
		/// </param>
		/// <param name="num_entries">
		/// The number of cl_device_id entries that can be added to devices. If devices is not NULL, the num_entries must be greater 
		/// than zero.
		/// </param>
		/// <param name="devices">
		/// A list of OpenCL devices found. The cl_device_id values returned in devices can be used to identify a specific OpenCL 
		/// device. If devices argument is NULL, this argument is ignored. The number of OpenCL devices returned is the mininum of 
		/// the value specified by num_entries or the number of OpenCL devices whose type matches device_type.
		/// </param>
		/// <param name="num_devices">
		/// The number of OpenCL devices available that match device_type. If num_devices is NULL, this argument is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, [Out] IntPtr[] devices, [Out] uint[] num_devices)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_devices = devices)
				fixed (uint* p_num_devices = num_devices)
				{
					Debug.Assert(Delegates.pclGetDeviceIDs != null, "pclGetDeviceIDs not implemented");
					retValue = Delegates.pclGetDeviceIDs(platform, (DeviceType)device_type, num_entries, p_devices, p_num_devices);
					LogFunction("clGetDeviceIDs(0x{0}, {1}, {2}, {3}, {4}) = {5}", platform.ToString("X8"), device_type, num_entries, LogValue(devices), LogValue(num_devices), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Obtain the list of devices available on a platform.
		/// </summary>
		/// <param name="platform">
		/// Refers to the platform ID returned by Gl.GetPlatformIDs or can be NULL. If platform is NULL, the behavior is 
		/// implementation-defined.
		/// </param>
		/// <param name="device_type">
		/// A bitfield that identifies the type of OpenCL device. The device_type can be used to query specific OpenCL devices or 
		/// all OpenCL devices available. The valid values for device_type are specified in the following table.
		/// </param>
		/// <param name="num_entries">
		/// The number of cl_device_id entries that can be added to devices. If devices is not NULL, the num_entries must be greater 
		/// than zero.
		/// </param>
		/// <param name="devices">
		/// A list of OpenCL devices found. The cl_device_id values returned in devices can be used to identify a specific OpenCL 
		/// device. If devices argument is NULL, this argument is ignored. The number of OpenCL devices returned is the mininum of 
		/// the value specified by num_entries or the number of OpenCL devices whose type matches device_type.
		/// </param>
		/// <param name="num_devices">
		/// The number of OpenCL devices available that match device_type. If num_devices is NULL, this argument is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetDeviceIDs(Object platform, DeviceType device_type, uint num_entries, [Out] IntPtr[] devices, [Out] uint[] num_devices)
		{
			GCHandle pin_platform = GCHandle.Alloc(platform, GCHandleType.Pinned);
			try {
				return (GetDeviceIDs(pin_platform.AddrOfPinnedObject(), device_type, num_entries, devices, num_devices));
			} finally {
				pin_platform.Free();
			}
		}

		/// <summary>
		/// Get information about an OpenCL device.
		/// </summary>
		/// <param name="device">
		/// A device returned by Gl.GetDeviceIDs.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the device information being queried. It can be one of the values as specified 
		/// in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size in bytes must be ≥ size of return type 
		/// specified in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory location where appropriate values for a given param_name as specified in the table below will be 
		/// returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetDeviceInfo(IntPtr device, DeviceInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetDeviceInfo != null, "pclGetDeviceInfo not implemented");
					retValue = Delegates.pclGetDeviceInfo(device, (DeviceInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetDeviceInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", device.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get information about an OpenCL device.
		/// </summary>
		/// <param name="device">
		/// A device returned by Gl.GetDeviceIDs.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that identifies the device information being queried. It can be one of the values as specified 
		/// in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size in bytes must be ≥ size of return type 
		/// specified in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory location where appropriate values for a given param_name as specified in the table below will be 
		/// returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetDeviceInfo(Object device, DeviceInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_device = GCHandle.Alloc(device, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetDeviceInfo(pin_device.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_device.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Creates an OpenCL context.
		/// </summary>
		/// <param name="properties">
		/// Specifies a list of context property names and their corresponding values. Each property name is immediately followed by 
		/// the corresponding desired value. The list is terminated with 0. properties can be NULL in which case the platform that 
		/// is selected is implementation-defined. The list of supported properties is described in the table below.
		/// </param>
		/// <param name="num_devices">
		/// The number of devices specified in the devices argument.
		/// </param>
		/// <param name="devices">
		/// A pointer to a list of unique devices returned by Gl.GetDeviceIDs or sub-devices created by Gl.CreateSubDevices for a 
		/// platform. Duplicate devices specified in devices are ignored.
		/// </param>
		/// <param name="pfn_notify">
		/// A callback function that can be registered by the application. This callback function will be used by the OpenCL 
		/// implementation to report information on errors during context creation as well as errors that occur at runtime in this 
		/// context. This callback function may be called asynchronously by the OpenCL implementation. It is the application's 
		/// responsibility to ensure that the callback function is thread-safe. If pfn_notify is NULL, no callback function is 
		/// registered. The parameters to this callback function are:
		/// </param>
		/// <param name="user_data">
		/// Passed as the user_data argument when pfn_notify is called. user_data can be NULL.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateContext(ContextProperties [] properties, uint num_devices, IntPtr[] devices, IntPtr pfn_notify, IntPtr user_data, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (ContextProperties * p_properties = properties)
				fixed (IntPtr* p_devices = devices)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateContext != null, "pclCreateContext not implemented");
					retValue = Delegates.pclCreateContext(p_properties, num_devices, p_devices, pfn_notify, user_data, p_errcode_ret);
					LogFunction("clCreateContext({0}, {1}, {2}, 0x{3}, 0x{4}, {5}) = {6}", LogValue(properties), num_devices, LogValue(devices), pfn_notify.ToString("X8"), user_data.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Create an OpenCL context from a device type that identifies the specific device(s) to use.
		/// </summary>
		/// <param name="properties">
		/// Specifies a list of context property names and their corresponding values. Each property name is immediately followed by 
		/// the corresponding desired value. The list of supported properties is described in the table below. properties can also 
		/// be NULL in which case the platform that is selected is implementation-defined.
		/// </param>
		/// <param name="device_type">
		/// A bit-field that identifies the type of device and is described in the table below.
		/// </param>
		/// <param name="user_data">
		/// Passed as the user_data argument when pfn_notify is called. user_data can be NULL.
		/// </param>
		/// <param name="errcode_ret">
		/// Return an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateContextFromType(ContextProperties [] properties, DeviceType device_type, IntPtr user_data, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (ContextProperties * p_properties = properties)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateContextFromType != null, "pclCreateContextFromType not implemented");
					retValue = Delegates.pclCreateContextFromType(p_properties, (DeviceType)device_type, user_data, p_errcode_ret);
					LogFunction("clCreateContextFromType({0}, {1}, 0x{2}, {3}) = {4}", LogValue(properties), device_type, user_data.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Increment the context reference count.
		/// </summary>
		/// <param name="context">
		/// The context to retain.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainContext(IntPtr context)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainContext != null, "pclRetainContext not implemented");
			retValue = Delegates.pclRetainContext(context);
			LogFunction("clRetainContext(0x{0}) = {1}", context.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrement the context reference count.
		/// </summary>
		/// <param name="context">
		/// The context to release.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseContext(IntPtr context)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseContext != null, "pclReleaseContext not implemented");
			retValue = Delegates.pclReleaseContext(context);
			LogFunction("clReleaseContext(0x{0}) = {1}", context.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Query information about a context.
		/// </summary>
		/// <param name="context">
		/// Specifies the OpenCL context being queried.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that specifies the information to query. The valid values for param_name are:
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be greater than or equal to the size of 
		/// return type as described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetContextInfo(IntPtr context, ContextInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetContextInfo != null, "pclGetContextInfo not implemented");
					retValue = Delegates.pclGetContextInfo(context, (ContextInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetContextInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", context.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Query information about a context.
		/// </summary>
		/// <param name="context">
		/// Specifies the OpenCL context being queried.
		/// </param>
		/// <param name="param_name">
		/// An enumeration constant that specifies the information to query. The valid values for param_name are:
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be greater than or equal to the size of 
		/// return type as described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetContextInfo(Object context, ContextInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_context = GCHandle.Alloc(context, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetContextInfo(pin_context.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_context.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Increments the command_queue reference count.
		/// </summary>
		/// <param name="command_queue">
		/// Specifies the command-queue to retain.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainCommandQueue(IntPtr command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainCommandQueue != null, "pclRetainCommandQueue not implemented");
			retValue = Delegates.pclRetainCommandQueue(command_queue);
			LogFunction("clRetainCommandQueue(0x{0}) = {1}", command_queue.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrements the command_queue reference count.
		/// </summary>
		/// <param name="command_queue">
		/// Specifies the command-queue to release.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseCommandQueue(IntPtr command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseCommandQueue != null, "pclReleaseCommandQueue not implemented");
			retValue = Delegates.pclReleaseCommandQueue(command_queue);
			LogFunction("clReleaseCommandQueue(0x{0}) = {1}", command_queue.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Query information about a command-queue.
		/// </summary>
		/// <param name="command_queue">
		/// Specifies the command-queue being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table below. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetCommandQueueInfo(IntPtr command_queue, CommandQueueInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetCommandQueueInfo != null, "pclGetCommandQueueInfo not implemented");
					retValue = Delegates.pclGetCommandQueueInfo(command_queue, (CommandQueueInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetCommandQueueInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", command_queue.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Query information about a command-queue.
		/// </summary>
		/// <param name="command_queue">
		/// Specifies the command-queue being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table below. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetCommandQueueInfo(Object command_queue, CommandQueueInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_command_queue = GCHandle.Alloc(command_queue, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetCommandQueueInfo(pin_command_queue.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_command_queue.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Creates a buffer object.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context used to create the buffer object.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify allocation and usage information such as the memory arena that should be used to 
		/// allocate the buffer object and how it will be used. The following table describes the possible values for flags. If 
		/// value specified for flags is 0, the default is used which is CL_MEM_READ_WRITE.
		/// </param>
		/// <param name="size">
		/// The size in bytes of the buffer memory object to be allocated.
		/// </param>
		/// <param name="host_ptr">
		/// A pointer to the buffer data that may already be allocated by the application. The size of the buffer that host_ptr 
		/// points to must be ≥ size bytes.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateBuffer(IntPtr context, ulong flags, uint size, IntPtr host_ptr, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateBuffer != null, "pclCreateBuffer not implemented");
					retValue = Delegates.pclCreateBuffer(context, flags, size, host_ptr, p_errcode_ret);
					LogFunction("clCreateBuffer(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", context.ToString("X8"), flags, size, host_ptr.ToString("X8"), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Increments the memory object reference count.
		/// </summary>
		/// <param name="memobj">
		/// A valid memory object.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainMemObject(IntPtr memobj)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainMemObject != null, "pclRetainMemObject not implemented");
			retValue = Delegates.pclRetainMemObject(memobj);
			LogFunction("clRetainMemObject(0x{0}) = {1}", memobj.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrements the memory object reference count.
		/// </summary>
		/// <param name="memobj">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseMemObject(IntPtr memobj)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseMemObject != null, "pclReleaseMemObject not implemented");
			retValue = Delegates.pclReleaseMemObject(memobj);
			LogFunction("clReleaseMemObject(0x{0}) = {1}", memobj.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get the list of image formats supported by an OpenCL implementation.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context on which the image object(s) will be created.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify allocation and usage information about the image memory object being queried and is 
		/// described in the table below. To get a list of supported image formats that can be read from or written to by a kernel, 
		/// flags must be set to CL_MEM_READ_WRITE (get a list of images that can be read from and written to by different kernel 
		/// instances when correctly ordered by event dependencies), CL_MEM_READ_ONLY (list of images that can be read from by a 
		/// kernel) or CL_MEM_WRITE_ONLY (list of images that can be written to by a kernel). To get a list of supported image 
		/// formats that can be both read from and written to by a kernel, flags must be set to CL_MEM_KERNEL_READ_AND_WRITE. Please 
		/// see section 5.3.2.2 for clarification.
		/// </param>
		/// <param name="image_type">
		/// Describes the image type and must be either CL_MEM_OBJECT_IMAGE1D, CL_MEM_OBJECT_IMAGE1D_BUFFER, CL_MEM_OBJECT_IMAGE2D, 
		/// CL_MEM_OBJECT_IMAGE3D, CL_MEM_OBJECT_IMAGE1D_ARRAY or CL_MEM_OBJECT_IMAGE2D_ARRAY.
		/// </param>
		/// <param name="num_entries">
		/// Specifies the number of entries that can be returned in the memory location given by image_formats.
		/// </param>
		/// <param name="image_formats">
		/// A pointer to a memory location where the list of supported image formats are returned. Each entry describes a 
		/// Gl._image_format structure supported by the OpenCL implementation. If image_formats is NULL, it is ignored.
		/// </param>
		/// <param name="num_image_formats">
		/// The actual number of supported image formats for a specific context and values specified by flags. If num_image_formats 
		/// is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetSupportedImageFormats(IntPtr context, ulong flags, MemObjectType image_type, uint num_entries, [Out] Cl.ImageFormat[] image_formats, [Out] uint[] num_image_formats)
		{
			int retValue;

			unsafe {
				fixed (Cl.ImageFormat* p_image_formats = image_formats)
				fixed (uint* p_num_image_formats = num_image_formats)
				{
					Debug.Assert(Delegates.pclGetSupportedImageFormats != null, "pclGetSupportedImageFormats not implemented");
					retValue = Delegates.pclGetSupportedImageFormats(context, flags, (MemObjectType)image_type, num_entries, p_image_formats, p_num_image_formats);
					LogFunction("clGetSupportedImageFormats(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", context.ToString("X8"), flags, image_type, num_entries, LogValue(image_formats), LogValue(num_image_formats), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get the list of image formats supported by an OpenCL implementation.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context on which the image object(s) will be created.
		/// </param>
		/// <param name="flags">
		/// A bit-field that is used to specify allocation and usage information about the image memory object being queried and is 
		/// described in the table below. To get a list of supported image formats that can be read from or written to by a kernel, 
		/// flags must be set to CL_MEM_READ_WRITE (get a list of images that can be read from and written to by different kernel 
		/// instances when correctly ordered by event dependencies), CL_MEM_READ_ONLY (list of images that can be read from by a 
		/// kernel) or CL_MEM_WRITE_ONLY (list of images that can be written to by a kernel). To get a list of supported image 
		/// formats that can be both read from and written to by a kernel, flags must be set to CL_MEM_KERNEL_READ_AND_WRITE. Please 
		/// see section 5.3.2.2 for clarification.
		/// </param>
		/// <param name="image_type">
		/// Describes the image type and must be either CL_MEM_OBJECT_IMAGE1D, CL_MEM_OBJECT_IMAGE1D_BUFFER, CL_MEM_OBJECT_IMAGE2D, 
		/// CL_MEM_OBJECT_IMAGE3D, CL_MEM_OBJECT_IMAGE1D_ARRAY or CL_MEM_OBJECT_IMAGE2D_ARRAY.
		/// </param>
		/// <param name="num_entries">
		/// Specifies the number of entries that can be returned in the memory location given by image_formats.
		/// </param>
		/// <param name="image_formats">
		/// A pointer to a memory location where the list of supported image formats are returned. Each entry describes a 
		/// Gl._image_format structure supported by the OpenCL implementation. If image_formats is NULL, it is ignored.
		/// </param>
		/// <param name="num_image_formats">
		/// The actual number of supported image formats for a specific context and values specified by flags. If num_image_formats 
		/// is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetSupportedImageFormats(Object context, ulong flags, MemObjectType image_type, uint num_entries, [Out] Cl.ImageFormat[] image_formats, [Out] uint[] num_image_formats)
		{
			GCHandle pin_context = GCHandle.Alloc(context, GCHandleType.Pinned);
			try {
				return (GetSupportedImageFormats(pin_context.AddrOfPinnedObject(), flags, image_type, num_entries, image_formats, num_image_formats));
			} finally {
				pin_context.Free();
			}
		}

		/// <summary>
		/// Get information that is common to all memory objects (buffer and image objects).
		/// </summary>
		/// <param name="memobj">
		/// Specifies the memory object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetMemObjectInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetMemObjectInfo(IntPtr memobj, MemInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetMemObjectInfo != null, "pclGetMemObjectInfo not implemented");
					retValue = Delegates.pclGetMemObjectInfo(memobj, (MemInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetMemObjectInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", memobj.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get information that is common to all memory objects (buffer and image objects).
		/// </summary>
		/// <param name="memobj">
		/// Specifies the memory object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetMemObjectInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetMemObjectInfo(Object memobj, MemInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_memobj = GCHandle.Alloc(memobj, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetMemObjectInfo(pin_memobj.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_memobj.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Get information specific to an image object created with clCreateImage.
		/// </summary>
		/// <param name="image">
		/// Specifies the image object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetImageInfo is described in the table below (Table 5.9).
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below (Table 5.9).
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetImageInfo(IntPtr image, ImageInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetImageInfo != null, "pclGetImageInfo not implemented");
					retValue = Delegates.pclGetImageInfo(image, (ImageInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetImageInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", image.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Get information specific to an image object created with clCreateImage.
		/// </summary>
		/// <param name="image">
		/// Specifies the image object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetImageInfo is described in the table below (Table 5.9).
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below (Table 5.9).
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data being queried by param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetImageInfo(Object image, ImageInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetImageInfo(pin_image.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_image.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Increments the sampler reference count.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainSampler(IntPtr sampler)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainSampler != null, "pclRetainSampler not implemented");
			retValue = Delegates.pclRetainSampler(sampler);
			LogFunction("clRetainSampler(0x{0}) = {1}", sampler.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrements the sampler reference count.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseSampler(IntPtr sampler)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseSampler != null, "pclReleaseSampler not implemented");
			retValue = Delegates.pclReleaseSampler(sampler);
			LogFunction("clReleaseSampler(0x{0}) = {1}", sampler.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the sampler object.
		/// </summary>
		/// <param name="sampler">
		/// Specifies the sampler being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetSamplerInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetSamplerInfo(IntPtr sampler, SamplerInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetSamplerInfo != null, "pclGetSamplerInfo not implemented");
					retValue = Delegates.pclGetSamplerInfo(sampler, (SamplerInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetSamplerInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", sampler.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the sampler object.
		/// </summary>
		/// <param name="sampler">
		/// Specifies the sampler being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetSamplerInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetSamplerInfo(Object sampler, SamplerInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_sampler = GCHandle.Alloc(sampler, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetSamplerInfo(pin_sampler.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_sampler.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Creates a program object for a context, and loads the source code specified by the text strings in the strings array into the program object.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="strings">
		/// An array of count pointers to optionally null-terminated character strings that make up the source code.
		/// </param>
		/// <param name="lengths">
		/// An array with the number of chars in each string (the string length). If an element in lengths is zero, its accompanying 
		/// string is null-terminated. If lengths is NULL, all strings in the strings argument are considered null-terminated. Any 
		/// length value passed in that is greater than zero excludes the null terminator in its count.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateProgramWithSource(IntPtr context, uint count, String[] strings, uint[] lengths, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (uint* p_lengths = lengths)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateProgramWithSource != null, "pclCreateProgramWithSource not implemented");
					retValue = Delegates.pclCreateProgramWithSource(context, count, strings, p_lengths, p_errcode_ret);
					LogFunction("clCreateProgramWithSource(0x{0}, {1}, {2}, {3}, {4}) = {5}", context.ToString("X8"), count, LogValue(strings), LogValue(lengths), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Creates a program object for a context, and loads the binary bits specified by binary into the program object.
		/// </summary>
		/// <param name="context">
		/// Must be a valid OpenCL context.
		/// </param>
		/// <param name="num_devices">
		/// The number of devices listed in device_list.
		/// </param>
		/// <param name="device_list">
		/// A pointer to a list of devices that are in context. device_list must be a non-NULL value. The binaries are loaded for 
		/// devices specified in this list.
		/// </param>
		/// <param name="lengths">
		/// An array of the size in bytes of the program binaries to be loaded for devices specified by device_list.
		/// </param>
		/// <param name="binaries">
		/// An array of pointers to program binaries to be loaded for devices specified by device_list. For each device given by 
		/// device_list[i], the pointer to the program binary for that device is given by binaries[i] and the length of this 
		/// corresponding binary is given by lengths[i]. lengths[i] cannot be zero and binaries[i] cannot be a NULL pointer.
		/// </param>
		/// <param name="binary_status">
		/// Returns whether the program binary for each device specified in device_list was loaded successfully or not. It is an 
		/// array of num_devices entries and returns CL_SUCCESS in binary_status[i] if binary was successfully loaded for device 
		/// specified by device_list[i]; otherwise returns CL_INVALID_VALUE if lengths[i] is zero or if binaries[i] is a NULL value 
		/// or CL_INVALID_BINARY in binary_status[i] if program binary is not a valid binary for the specified device. If 
		/// binary_status is NULL, it is ignored.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr[] device_list, uint[] lengths, IntPtr[] binaries, int[] binary_status, int[] errcode_ret)
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
					LogFunction("clCreateProgramWithBinary(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", context.ToString("X8"), num_devices, LogValue(device_list), LogValue(lengths), LogValue(binaries), LogValue(binary_status), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Increments the program reference count.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainProgram(IntPtr program)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainProgram != null, "pclRetainProgram not implemented");
			retValue = Delegates.pclRetainProgram(program);
			LogFunction("clRetainProgram(0x{0}) = {1}", program.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrements the program reference count.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseProgram(IntPtr program)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseProgram != null, "pclReleaseProgram not implemented");
			retValue = Delegates.pclReleaseProgram(program);
			LogFunction("clReleaseProgram(0x{0}) = {1}", program.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Builds (compiles and links) a program executable from the program source or binary.
		/// </summary>
		/// <param name="program">
		/// The program object.
		/// </param>
		/// <param name="num_devices">
		/// The number of devices listed in device_list.
		/// </param>
		/// <param name="device_list">
		/// A pointer to a list of devices associated with program. If device_list is a NULL value, the program executable is built 
		/// for all devices associated with program for which a source or binary has been loaded. If device_list is a non-NULL 
		/// value, the program executable is built for devices specified in this list for which a source or binary has been loaded.
		/// </param>
		/// <param name="options">
		/// A pointer to a null-terminated string of characters that describes the build options to be used for building the program 
		/// executable. Certain options are ignored when program is created with IL. The list of supported options is described 
		/// below.
		/// </param>
		/// <param name="pfn_notify">
		/// A function pointer to a notification routine. The notification routine is a callback function that an application can 
		/// register and which will be called when the program executable has been built (successfully or unsuccessfully). If 
		/// pfn_notify is not NULL, clBuildProgram does not need to wait for the build to complete and can return immediately once 
		/// the build operation can begin. The build operation can begin if the context, program whose sources are being compiled 
		/// and linked, list of devices and build options specified are all valid and appropriate host and device resources needed 
		/// to perform the build are available. If pfn_notify is NULL, clBuildProgram does not return until the build has completed. 
		/// This callback function may be called asynchronously by the OpenCL implementation. It is the application’s responsibility 
		/// to ensure that the callback function is thread-safe.
		/// </param>
		/// <param name="user_data">
		/// Passed as an argument when pfn_notify is called. user_data can be NULL.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int BuildProgram(IntPtr program, uint num_devices, IntPtr[] device_list, char [] options, IntPtr pfn_notify, IntPtr user_data)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_device_list = device_list)
				fixed (char * p_options = options)
				{
					Debug.Assert(Delegates.pclBuildProgram != null, "pclBuildProgram not implemented");
					retValue = Delegates.pclBuildProgram(program, num_devices, p_device_list, p_options, pfn_notify, user_data);
					LogFunction("clBuildProgram(0x{0}, {1}, {2}, {3}, 0x{4}, 0x{5}) = {6}", program.ToString("X8"), num_devices, LogValue(device_list), LogValue(options), pfn_notify.ToString("X8"), user_data.ToString("X8"), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the program object.
		/// </summary>
		/// <param name="program">
		/// Specifies the program object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetProgramInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetProgramInfo(IntPtr program, ProgramInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetProgramInfo != null, "pclGetProgramInfo not implemented");
					retValue = Delegates.pclGetProgramInfo(program, (ProgramInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetProgramInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", program.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the program object.
		/// </summary>
		/// <param name="program">
		/// Specifies the program object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetProgramInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetProgramInfo(Object program, ProgramInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_program = GCHandle.Alloc(program, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetProgramInfo(pin_program.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_program.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Returns build information for each device in the program object.
		/// </summary>
		/// <param name="program">
		/// Specifies the program object being queried.
		/// </param>
		/// <param name="device">
		/// Specifies the device for which build information is being queried. device must be a valid device associated with 
		/// program.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetProgramBuildInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetProgramBuildInfo != null, "pclGetProgramBuildInfo not implemented");
					retValue = Delegates.pclGetProgramBuildInfo(program, device, (ProgramBuildInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetProgramBuildInfo(0x{0}, 0x{1}, {2}, {3}, 0x{4}, {5}) = {6}", program.ToString("X8"), device.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns build information for each device in the program object.
		/// </summary>
		/// <param name="program">
		/// Specifies the program object being queried.
		/// </param>
		/// <param name="device">
		/// Specifies the device for which build information is being queried. device must be a valid device associated with 
		/// program.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetProgramBuildInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table above.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetProgramBuildInfo(Object program, Object device, ProgramBuildInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_program = GCHandle.Alloc(program, GCHandleType.Pinned);
			GCHandle pin_device = GCHandle.Alloc(device, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetProgramBuildInfo(pin_program.AddrOfPinnedObject(), pin_device.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_program.Free();
				pin_device.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Creates a kernel object.
		/// </summary>
		/// <param name="program">
		/// A program object with a successfully built executable.
		/// </param>
		/// <param name="kernel_name">
		/// A function name in the program declared with the Gl.kernel qualifier.
		/// </param>
		/// <param name="errcode_ret">
		/// Returns an appropriate error code. If errcode_ret is NULL, no error code is returned.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateKernel(IntPtr program, char [] kernel_name, int[] errcode_ret)
		{
			IntPtr retValue;

			unsafe {
				fixed (char * p_kernel_name = kernel_name)
				fixed (int* p_errcode_ret = errcode_ret)
				{
					Debug.Assert(Delegates.pclCreateKernel != null, "pclCreateKernel not implemented");
					retValue = Delegates.pclCreateKernel(program, p_kernel_name, p_errcode_ret);
					LogFunction("clCreateKernel(0x{0}, {1}, {2}) = {3}", program.ToString("X8"), LogValue(kernel_name), LogValue(errcode_ret), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Creates kernel objects for all kernel functions in a program object.
		/// </summary>
		/// <param name="program">
		/// A program object with a successfully built executable.
		/// </param>
		/// <param name="num_kernels">
		/// The size of memory pointed to by kernels specified as the number of cl_kernel entries.
		/// </param>
		/// <param name="kernels">
		/// The buffer where the kernel objects for kernels in program will be returned. If kernels is NULL, it is ignored. If 
		/// kernels is not NULL, num_kernels must be greater than or equal to the number of kernels in program.
		/// </param>
		/// <param name="num_kernels_ret">
		/// The number of kernels in program. If num_kernels_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int CreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr[] kernels, uint[] num_kernels_ret)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_kernels = kernels)
				fixed (uint* p_num_kernels_ret = num_kernels_ret)
				{
					Debug.Assert(Delegates.pclCreateKernelsInProgram != null, "pclCreateKernelsInProgram not implemented");
					retValue = Delegates.pclCreateKernelsInProgram(program, num_kernels, p_kernels, p_num_kernels_ret);
					LogFunction("clCreateKernelsInProgram(0x{0}, {1}, {2}, {3}) = {4}", program.ToString("X8"), num_kernels, LogValue(kernels), LogValue(num_kernels_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Increments the kernel object reference count.
		/// </summary>
		/// <param name="kernel">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int RetainKernel(IntPtr kernel)
		{
			int retValue;

			Debug.Assert(Delegates.pclRetainKernel != null, "pclRetainKernel not implemented");
			retValue = Delegates.pclRetainKernel(kernel);
			LogFunction("clRetainKernel(0x{0}) = {1}", kernel.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrements the kernel reference count.
		/// </summary>
		/// <param name="kernel">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseKernel(IntPtr kernel)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseKernel != null, "pclReleaseKernel not implemented");
			retValue = Delegates.pclReleaseKernel(kernel);
			LogFunction("clReleaseKernel(0x{0}) = {1}", kernel.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Set the argument value for a specific argument of a kernel.
		/// </summary>
		/// <param name="kernel">
		/// A valid kernel object.
		/// </param>
		/// <param name="arg_index">
		/// The argument index. Arguments to the kernel are referred by indices that go from 0 for the leftmost argument to n - 1, 
		/// where n is the total number of arguments declared by a kernel.
		/// </param>
		/// <param name="arg_size">
		/// Specifies the size of the argument value. If the argument is a memory object, the size is the size of the memory object. 
		/// For arguments declared with the Gl.cal qualifier, the size specified will be the size in bytes of the buffer that must 
		/// be allocated for the Gl.cal argument. If the argument is of type sampler_t, the arg_size value must be equal to 
		/// sizeof(cl_sampler). If the argument is of type queue_t, the arg_size value must be equal to sizeof(cl_command_queue). 
		/// For all other arguments, the size will be the size of argument type.
		/// </param>
		/// <param name="arg_value">
		/// A pointer to data that should be used as the argument value for argument specified by arg_index. The argument data 
		/// pointed to by arg_value is copied and the arg_value pointer can therefore be reused by the application after 
		/// clSetKernelArg returns. The argument value specified is the value used by all API calls that enqueue kernel 
		/// (Gl.EnqueueNDRangeKernel) until the argument value is changed by a call to clSetKernelArg for kernel.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int SetKernelArg(IntPtr kernel, uint arg_index, uint arg_size, IntPtr arg_value)
		{
			int retValue;

			Debug.Assert(Delegates.pclSetKernelArg != null, "pclSetKernelArg not implemented");
			retValue = Delegates.pclSetKernelArg(kernel, arg_index, arg_size, arg_value);
			LogFunction("clSetKernelArg(0x{0}, {1}, {2}, 0x{3}) = {4}", kernel.ToString("X8"), arg_index, arg_size, arg_value.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the kernel object.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetKernelInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetKernelInfo(IntPtr kernel, KernelInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelInfo != null, "pclGetKernelInfo not implemented");
					retValue = Delegates.pclGetKernelInfo(kernel, (KernelInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetKernelInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", kernel.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the kernel object.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetKernelInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetKernelInfo(Object kernel, KernelInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_kernel = GCHandle.Alloc(kernel, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetKernelInfo(pin_kernel.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_kernel.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Returns information about the kernel object that may be specific to a device.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="device">
		/// Identifies a specific device in the list of devices associated with kernel. The list of devices is the list of devices 
		/// in the OpenCL context that is associated with kernel. If the list of devices associated with kernel is a single device, 
		/// device can be a NULL value.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetKernelWorkGroupInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetKernelWorkGroupInfo != null, "pclGetKernelWorkGroupInfo not implemented");
					retValue = Delegates.pclGetKernelWorkGroupInfo(kernel, device, (KernelWorkGroupInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetKernelWorkGroupInfo(0x{0}, 0x{1}, {2}, {3}, 0x{4}, {5}) = {6}", kernel.ToString("X8"), device.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the kernel object that may be specific to a device.
		/// </summary>
		/// <param name="kernel">
		/// Specifies the kernel object being queried.
		/// </param>
		/// <param name="device">
		/// Identifies a specific device in the list of devices associated with kernel. The list of devices is the list of devices 
		/// in the OpenCL context that is associated with kernel. If the list of devices associated with kernel is a single device, 
		/// device can be a NULL value.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetKernelWorkGroupInfo is described in the table below.
		/// </param>
		/// <param name="param_value_size">
		/// Used to specify the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetKernelWorkGroupInfo(Object kernel, Object device, KernelWorkGroupInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_kernel = GCHandle.Alloc(kernel, GCHandleType.Pinned);
			GCHandle pin_device = GCHandle.Alloc(device, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetKernelWorkGroupInfo(pin_kernel.AddrOfPinnedObject(), pin_device.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_kernel.Free();
				pin_device.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Waits on the host thread for commands identified by event objects to complete.
		/// </summary>
		/// <param name="num_events">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="event_list">
		/// </param>
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

		/// <summary>
		/// Returns information about the event object.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetEventInfo is described in the table below (Table 5.22):
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of the return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetEventInfo(IntPtr @event, EventInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetEventInfo != null, "pclGetEventInfo not implemented");
					retValue = Delegates.pclGetEventInfo(@event, (EventInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetEventInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", @event.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns information about the event object.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="param_name">
		/// Specifies the information to query. The list of supported param_name types and the information returned in param_value 
		/// by clGetEventInfo is described in the table below (Table 5.22):
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of the return type as 
		/// described in the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. If param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetEventInfo(Object @event, EventInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_event = GCHandle.Alloc(@event, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetEventInfo(pin_event.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_event.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Creates a user event object.
		/// </summary>
		/// <param name="context">
		/// A valid OpenCL context.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static IntPtr CreateUserEvent(IntPtr context)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pclCreateUserEvent != null, "pclCreateUserEvent not implemented");
			retValue = Delegates.pclCreateUserEvent(context);
			LogFunction("clCreateUserEvent(0x{0}) = {1}", context.ToString("X8"), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Decrements the event reference count.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int ReleaseEvent(IntPtr @event)
		{
			int retValue;

			Debug.Assert(Delegates.pclReleaseEvent != null, "pclReleaseEvent not implemented");
			retValue = Delegates.pclReleaseEvent(@event);
			LogFunction("clReleaseEvent(0x{0}) = {1}", @event.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns profiling information for the command associated with event if profiling is enabled.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="param_name">
		/// Specifies the profiling data to query. The list of supported param_name types and the information returned in 
		/// param_value by clGetEventProfilingInfo is described in the table of parameter queries below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. if param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetEventProfilingInfo(IntPtr @event, ProfilingInfo param_name, uint param_value_size, IntPtr param_value, [Out] uint[] param_value_size_ret)
		{
			int retValue;

			unsafe {
				fixed (uint* p_param_value_size_ret = param_value_size_ret)
				{
					Debug.Assert(Delegates.pclGetEventProfilingInfo != null, "pclGetEventProfilingInfo not implemented");
					retValue = Delegates.pclGetEventProfilingInfo(@event, (ProfilingInfo)param_name, param_value_size, param_value, p_param_value_size_ret);
					LogFunction("clGetEventProfilingInfo(0x{0}, {1}, {2}, 0x{3}, {4}) = {5}", @event.ToString("X8"), param_name, param_value_size, param_value.ToString("X8"), LogValue(param_value_size_ret), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns profiling information for the command associated with event if profiling is enabled.
		/// </summary>
		/// <param name="event">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="param_name">
		/// Specifies the profiling data to query. The list of supported param_name types and the information returned in 
		/// param_value by clGetEventProfilingInfo is described in the table of parameter queries below.
		/// </param>
		/// <param name="param_value_size">
		/// Specifies the size in bytes of memory pointed to by param_value. This size must be ≥ size of return type as described in 
		/// the table below.
		/// </param>
		/// <param name="param_value">
		/// A pointer to memory where the appropriate result being queried is returned. if param_value is NULL, it is ignored.
		/// </param>
		/// <param name="param_value_size_ret">
		/// Returns the actual size in bytes of data copied to param_value. If param_value_size_ret is NULL, it is ignored.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int GetEventProfilingInfo(Object @event, ProfilingInfo param_name, uint param_value_size, Object param_value, [Out] uint[] param_value_size_ret)
		{
			GCHandle pin_event = GCHandle.Alloc(@event, GCHandleType.Pinned);
			GCHandle pin_param_value = GCHandle.Alloc(param_value, GCHandleType.Pinned);
			try {
				return (GetEventProfilingInfo(pin_event.AddrOfPinnedObject(), param_name, param_value_size, pin_param_value.AddrOfPinnedObject(), param_value_size_ret));
			} finally {
				pin_event.Free();
				pin_param_value.Free();
			}
		}

		/// <summary>
		/// Issues all previously queued OpenCL commands in a command-queue to the device associated with the command-queue.
		/// </summary>
		/// <param name="command_queue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int Flush(IntPtr command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclFlush != null, "pclFlush not implemented");
			retValue = Delegates.pclFlush(command_queue);
			LogFunction("clFlush(0x{0}) = {1}", command_queue.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Blocks until all previously queued OpenCL commands in a command-queue are issued to the associated device and have completed.
		/// </summary>
		/// <param name="command_queue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int Finish(IntPtr command_queue)
		{
			int retValue;

			Debug.Assert(Delegates.pclFinish != null, "pclFinish not implemented");
			retValue = Delegates.pclFinish(command_queue);
			LogFunction("clFinish(0x{0}) = {1}", command_queue.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueue commands to read from a buffer object to host memory.
		/// </summary>
		/// <param name="command_queue">
		/// Is a valid host command-queue in which the read command will be queued. command_queue and buffer must be created with 
		/// the same OpenCL context.
		/// </param>
		/// <param name="buffer">
		/// Refers to a valid buffer object.
		/// </param>
		/// <param name="blocking_read">
		/// Indicates if the read operations are blocking or non-blocking.
		/// </param>
		/// <param name="offset">
		/// The offset in bytes in the buffer object to read from.
		/// </param>
		/// <param name="size">
		/// The size in bytes of data being read.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, uint offset, uint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueReadBuffer != null, "pclEnqueueReadBuffer not implemented");
					retValue = Delegates.pclEnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueReadBuffer(0x{0}, 0x{1}, {2}, {3}, {4}, 0x{5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), buffer.ToString("X8"), blocking_read, offset, size, ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueue commands to write to a buffer object from host memory.
		/// </summary>
		/// <param name="command_queue">
		/// Is a valid host command-queue in which the write command will be queued. command_queue and buffer must be created with 
		/// the same OpenCL context.
		/// </param>
		/// <param name="buffer">
		/// Refers to a valid buffer object.
		/// </param>
		/// <param name="blocking_write">
		/// Indicates if the write operations are blocking or nonblocking.
		/// </param>
		/// <param name="offset">
		/// The offset in bytes in the buffer object to write to.
		/// </param>
		/// <param name="size">
		/// The size in bytes of data being written.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, uint offset, uint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueWriteBuffer != null, "pclEnqueueWriteBuffer not implemented");
					retValue = Delegates.pclEnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueWriteBuffer(0x{0}, 0x{1}, {2}, {3}, {4}, 0x{5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), buffer.ToString("X8"), blocking_write, offset, size, ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to copy from one buffer object to another.
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
		/// <param name="src_offset">
		/// The offset where to begin copying data from src_buffer.
		/// </param>
		/// <param name="dst_offset">
		/// The offset where to begin copying data into dst_buffer.
		/// </param>
		/// <param name="size">
		/// Refers to the size in bytes to copy.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, uint src_offset, uint dst_offset, uint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyBuffer != null, "pclEnqueueCopyBuffer not implemented");
					retValue = Delegates.pclEnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyBuffer(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), src_buffer.ToString("X8"), dst_buffer.ToString("X8"), src_offset, dst_offset, size, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueue commands to read from an image or image array object to host memory.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the read command will be queued. command_queue and image must be created with 
		/// the same OpenCL context.
		/// </param>
		/// <param name="image">
		/// Refers to a valid image or image array object.
		/// </param>
		/// <param name="blocking_read">
		/// Indicates if the read operations are blocking or non-blocking.
		/// </param>
		/// <param name="row_pitch">
		/// The length of each row in bytes. This value must be greater than or equal to the element size in bytes * width. If 
		/// row_pitch is set to 0, the appropriate row pitch is calculated based on the size of each element in bytes multiplied by 
		/// width.
		/// </param>
		/// <param name="slice_pitch">
		/// Size in bytes of the 2D slice of the 3D region of a 3D image or each image of a 1D or 2D image array being read. This 
		/// must be 0 if image is a 1D or 2D image. Otherwise this value must be greater than or equal to row_pitch * height. If 
		/// slice_pitch is set to 0, the appropriate slice pitch is calculated based on the row_pitch * height.
		/// </param>
		/// <param name="ptr">
		/// The pointer to a buffer in host memory where image data is to be read from.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueReadImage(IntPtr command_queue, IntPtr image, bool blocking_read, uint row_pitch, uint slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueReadImage != null, "pclEnqueueReadImage not implemented");
					retValue = Delegates.pclEnqueueReadImage(command_queue, image, blocking_read, row_pitch, slice_pitch, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueReadImage(0x{0}, 0x{1}, {2}, {3}, {4}, 0x{5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), image.ToString("X8"), blocking_read, row_pitch, slice_pitch, ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to write to an image or image array object from host memory.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the write command will be queued. command_queue and image must be created with 
		/// the same OpenCL context.
		/// </param>
		/// <param name="image">
		/// Refers to a valid image or image array object.
		/// </param>
		/// <param name="blocking_write">
		/// Indicates if the write operation is blocking or non-blocking.
		/// </param>
		/// <param name="input_row_pitch">
		/// The length of each row in bytes. This value must be greater than or equal to the element size in bytes * width. If 
		/// input_row_pitch is set to 0, the appropriate row pitch is calculated based on the size of each element in bytes 
		/// multiplied by width.
		/// </param>
		/// <param name="input_slice_pitch">
		/// Size in bytes of the 2D slice of the 3D region of a 3D image or each image of a 1D or 2D image array being written. This 
		/// must be 0 if image is a 1D or 2D image. Otherwise this value must be greater than or equal to row_pitch * height. If 
		/// input_slice_pitch is set to 0, the appropriate slice pitch is calculated based on the row_pitch * height.
		/// </param>
		/// <param name="ptr">
		/// The pointer to a buffer in host memory where image data is to be written to.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueWriteImage(IntPtr command_queue, IntPtr image, bool blocking_write, uint input_row_pitch, uint input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueWriteImage != null, "pclEnqueueWriteImage not implemented");
					retValue = Delegates.pclEnqueueWriteImage(command_queue, image, blocking_write, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueWriteImage(0x{0}, 0x{1}, {2}, {3}, {4}, 0x{5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), image.ToString("X8"), blocking_write, input_row_pitch, input_slice_pitch, ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to copy image objects.
		/// </summary>
		/// <param name="command_queue">
		/// Refers to the host command-queue in which the copy command will be queued. The OpenCL context associated with 
		/// command_queue, src_image and dst_image must be the same.
		/// </param>
		/// <param name="src_image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dst_image">
		/// A <see cref="T:IntPtr"/>.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyImage != null, "pclEnqueueCopyImage not implemented");
					retValue = Delegates.pclEnqueueCopyImage(command_queue, src_image, dst_image, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyImage(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}) = {6}", command_queue.ToString("X8"), src_image.ToString("X8"), dst_image.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to copy an image object to a buffer object.
		/// </summary>
		/// <param name="command_queue">
		/// Must be a valid host command-queue. The OpenCL context associated with command_queue, src_image, and dst_buffer must be 
		/// the same.
		/// </param>
		/// <param name="src_image">
		/// A valid image object.
		/// </param>
		/// <param name="dst_buffer">
		/// A valid buffer object.
		/// </param>
		/// <param name="dst_offset">
		/// Refers to the offset where to begin copying data into dst_buffer. The size in bytes of the region to be copied referred 
		/// to as dst_cb is computed as width * height * depth * bytes/image element if src_image is a 3D image object, is computed 
		/// as width * height * bytes/image element if src_image is a 2D image, is computed as width * height * arraysize * 
		/// bytes/image element if src_image is a 2D image array object, is computed as width * bytes/image element if src_image is 
		/// a 1D image or 1D image buffer object and is computed as width * arraysize * bytes/image element if src_image is a 1D 
		/// image array object.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, uint dst_offset, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyImageToBuffer != null, "pclEnqueueCopyImageToBuffer not implemented");
					retValue = Delegates.pclEnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, dst_offset, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyImageToBuffer(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}, {6}) = {7}", command_queue.ToString("X8"), src_image.ToString("X8"), dst_buffer.ToString("X8"), dst_offset, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to copy a buffer object to an image object.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command-queue. The OpenCL context associated with command_queue, src_buffer, and dst_image must be the 
		/// same.
		/// </param>
		/// <param name="src_buffer">
		/// A valid buffer object.
		/// </param>
		/// <param name="dst_image">
		/// A valid image object.
		/// </param>
		/// <param name="src_offset">
		/// The offset where to begin copying data from src_buffer.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, uint src_offset, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueCopyBufferToImage != null, "pclEnqueueCopyBufferToImage not implemented");
					retValue = Delegates.pclEnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueCopyBufferToImage(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}, {6}) = {7}", command_queue.ToString("X8"), src_buffer.ToString("X8"), dst_image.ToString("X8"), src_offset, num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to unmap a previously mapped region of a memory object.
		/// </summary>
		/// <param name="command_queue">
		/// Must be a valid host command-queue.
		/// </param>
		/// <param name="memobj">
		/// A valid memory (buffer or image) object. The OpenCL context associated with command_queue and memobj must be the same.
		/// </param>
		/// <param name="mapped_ptr">
		/// The host address returned by a previous call to Gl.EnqueueMapBuffer or Gl.EnqueueMapImage for memobj.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_event_wait_list = event_wait_list)
				fixed (IntPtr* p_event = @event)
				{
					Debug.Assert(Delegates.pclEnqueueUnmapMemObject != null, "pclEnqueueUnmapMemObject not implemented");
					retValue = Delegates.pclEnqueueUnmapMemObject(command_queue, memobj, mapped_ptr, num_events_in_wait_list, p_event_wait_list, p_event);
					LogFunction("clEnqueueUnmapMemObject(0x{0}, 0x{1}, 0x{2}, {3}, {4}, {5}) = {6}", command_queue.ToString("X8"), memobj.ToString("X8"), mapped_ptr.ToString("X8"), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to execute a kernel on a device.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command-queue. The kernel will be queued for execution on the device associated with command_queue.
		/// </param>
		/// <param name="kernel">
		/// A valid kernel object. The OpenCL context associated with kernel and command_queue must be the same.
		/// </param>
		/// <param name="work_dim">
		/// The number of dimensions used to specify the global work-items and work-items in the work-group. work_dim must be 
		/// greater than zero and less than or equal to CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS. If global_work_size is NULL, or the 
		/// value in any passed dimension is 0 then the kernel command will trivially succeed after its event dependencies are 
		/// satisfied and subsequently update its completion event. The behavior in this situation is similar to that of an enqueued 
		/// marker, except that unlike a marker, an enqueued kernel with no events passed to event_wait_list may run at any time.
		/// </param>
		/// <param name="global_work_offset">
		/// global_work_offset can be used to specify an array of work_dim unsigned values that describe the offset used to 
		/// calculate the global ID of a work-item. If global_work_offset is NULL, the global IDs start at offset (0, 0, ... 0).
		/// </param>
		/// <param name="global_work_size">
		/// Points to an array of work_dim unsigned values that describe the number of global work-items in work_dim dimensions that 
		/// will execute the kernel function. The total number of global work-items is computed as global_work_size[0] *...* 
		/// global_work_size[work_dim - 1].
		/// </param>
		/// <param name="local_work_size">
		/// Points to an array of work_dim unsigned values that describe the number of work-items that make up a work-group (also 
		/// referred to as the size of the work-group) that will execute the kernel specified by kernel. The total number of 
		/// work-items in a work-group is computed as local_work_size[0] *... * local_work_size[work_dim - 1]. The total number of 
		/// work-items in the work-group must be less than or equal to the CL_KERNEL_WORK_GROUP_SIZE value specified in table of 
		/// OpenCL Device Queries for Gl.GetDeviceInfo and the number of work-items specified in local_work_size[0],... 
		/// local_work_size[work_dim - 1] must be less than or equal to the corresponding values specified by 
		/// CL_DEVICE_MAX_WORK_ITEM_SIZES[0],.... CL_DEVICE_MAX_WORK_ITEM_SIZES[work_dim - 1]. The explicitly specified 
		/// local_work_size will be used to determine how to break the global work-items specified by global_work_size into 
		/// appropriate work-group instances.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, uint[] global_work_offset, uint[] global_work_size, uint[] local_work_size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
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
					LogFunction("clEnqueueNDRangeKernel(0x{0}, 0x{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), kernel.ToString("X8"), work_dim, LogValue(global_work_offset), LogValue(global_work_size), LogValue(local_work_size), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Enqueues a command to execute a native C/C++ function not compiled using the OpenCL compiler.
		/// </summary>
		/// <param name="command_queue">
		/// A valid host command-queue. A native user function can only be executed on a command-queue created on a device that has 
		/// CL_EXEC_NATIVE_KERNEL capability set in CL_DEVICE_EXECUTION_CAPABILITIES as specified in the table of OpenCL Device 
		/// Queries for Gl.GetDeviceInfo.
		/// </param>
		/// <param name="args">
		/// A pointer to the args list that user_func should be called with.
		/// </param>
		/// <param name="cb_args">
		/// The size in bytes of the args list that args points to.
		/// </param>
		/// <param name="num_mem_objects">
		/// The number of buffer objects that are passed in args.
		/// </param>
		/// <param name="mem_list">
		/// A list of valid buffer objects, if num_mem_objects &gt; 0. The buffer object values specified in mem_list are memory 
		/// object handles (cl_mem values) returned by Gl.CreateBuffer or NULL.
		/// </param>
		/// <param name="args_mem_loc">
		/// A pointer to appropriate locations that args points to where memory object handles (cl_mem values) are stored. Before 
		/// the user function is executed, the memory object handles are replaced by pointers to global memory.
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
		[RequiredByFeature("CL_VERSION_1_0")]
		public static int EnqueueNativeKernel(IntPtr command_queue, IntPtr args, uint cb_args, uint num_mem_objects, IntPtr[] mem_list, IntPtr[] args_mem_loc, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
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
					LogFunction("clEnqueueNativeKernel(0x{0}, 0x{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", command_queue.ToString("X8"), args.ToString("X8"), cb_args, num_mem_objects, LogValue(mem_list), LogValue(args_mem_loc), num_events_in_wait_list, LogValue(event_wait_list), LogValue(@event), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}

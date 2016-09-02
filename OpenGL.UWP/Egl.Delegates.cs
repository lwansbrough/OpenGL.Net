
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

namespace OpenGL
{
	public unsafe partial class Egl
	{
		internal unsafe static partial class Delegates
		{
			internal delegate bool eglBindAPI(uint api);

			internal static eglBindAPI peglBindAPI;

			internal unsafe delegate bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			internal static eglBindTexImage peglBindTexImage;

			internal unsafe delegate bool eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config);

			internal static eglChooseConfig peglChooseConfig;

			internal unsafe delegate int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			[AliasOf("eglClientWaitSync")]
			[AliasOf("eglClientWaitSyncKHR")]
			internal static eglClientWaitSync peglClientWaitSync;

			internal unsafe delegate int eglClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout);

			internal static eglClientWaitSyncNV peglClientWaitSyncNV;

			internal unsafe delegate bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

			internal static eglCopyBuffers peglCopyBuffers;

			internal unsafe delegate IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list);

			internal static eglCreateContext peglCreateContext;

			internal unsafe delegate IntPtr eglCreateDRMImageMESA(IntPtr dpy, int* attrib_list);

			internal static eglCreateDRMImageMESA peglCreateDRMImageMESA;

			internal unsafe delegate IntPtr eglCreateFenceSyncNV(IntPtr dpy, uint condition, int* attrib_list);

			internal static eglCreateFenceSyncNV peglCreateFenceSyncNV;

			internal unsafe delegate IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

			internal static eglCreateImage peglCreateImage;

			internal unsafe delegate IntPtr eglCreateImageKHR(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, int* attrib_list);

			internal static eglCreateImageKHR peglCreateImageKHR;

			internal unsafe delegate IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			internal static eglCreatePbufferFromClientBuffer peglCreatePbufferFromClientBuffer;

			internal unsafe delegate IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list);

			internal static eglCreatePbufferSurface peglCreatePbufferSurface;

			internal unsafe delegate IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

			internal static eglCreatePixmapSurface peglCreatePixmapSurface;

			internal unsafe delegate IntPtr eglCreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap* pixmap);

			internal static eglCreatePixmapSurfaceHI peglCreatePixmapSurfaceHI;

			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list);

			internal static eglCreatePlatformPixmapSurface peglCreatePlatformPixmapSurface;

			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

			internal static eglCreatePlatformPixmapSurfaceEXT peglCreatePlatformPixmapSurfaceEXT;

			internal unsafe delegate IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list);

			internal static eglCreatePlatformWindowSurface peglCreatePlatformWindowSurface;

			internal unsafe delegate IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			internal static eglCreatePlatformWindowSurfaceEXT peglCreatePlatformWindowSurfaceEXT;

			internal unsafe delegate IntPtr eglCreateStreamFromFileDescriptorKHR(IntPtr dpy, int file_descriptor);

			internal static eglCreateStreamFromFileDescriptorKHR peglCreateStreamFromFileDescriptorKHR;

			internal unsafe delegate IntPtr eglCreateStreamKHR(IntPtr dpy, int* attrib_list);

			internal static eglCreateStreamKHR peglCreateStreamKHR;

			internal unsafe delegate IntPtr eglCreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list);

			internal static eglCreateStreamProducerSurfaceKHR peglCreateStreamProducerSurfaceKHR;

			internal unsafe delegate IntPtr eglCreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int* attrib_list);

			internal static eglCreateStreamSyncNV peglCreateStreamSyncNV;

			internal unsafe delegate IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

			[AliasOf("eglCreateSync")]
			[AliasOf("eglCreateSync64KHR")]
			internal static eglCreateSync peglCreateSync;

			internal unsafe delegate IntPtr eglCreateSyncKHR(IntPtr dpy, uint type, int* attrib_list);

			internal static eglCreateSyncKHR peglCreateSyncKHR;

			internal unsafe delegate IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

			internal static eglCreateWindowSurface peglCreateWindowSurface;

			internal unsafe delegate int eglDebugMessageControlKHR(DebugProcKHR callback, IntPtr* attrib_list);

			internal static eglDebugMessageControlKHR peglDebugMessageControlKHR;

			internal unsafe delegate bool eglDestroyContext(IntPtr dpy, IntPtr ctx);

			internal static eglDestroyContext peglDestroyContext;

			internal unsafe delegate bool eglDestroyImage(IntPtr dpy, IntPtr image);

			[AliasOf("eglDestroyImage")]
			[AliasOf("eglDestroyImageKHR")]
			internal static eglDestroyImage peglDestroyImage;

			internal unsafe delegate bool eglDestroyStreamKHR(IntPtr dpy, IntPtr stream);

			internal static eglDestroyStreamKHR peglDestroyStreamKHR;

			internal unsafe delegate bool eglDestroySurface(IntPtr dpy, IntPtr surface);

			internal static eglDestroySurface peglDestroySurface;

			internal unsafe delegate bool eglDestroySync(IntPtr dpy, IntPtr sync);

			[AliasOf("eglDestroySync")]
			[AliasOf("eglDestroySyncKHR")]
			internal static eglDestroySync peglDestroySync;

			internal unsafe delegate bool eglDestroySyncNV(IntPtr sync);

			internal static eglDestroySyncNV peglDestroySyncNV;

			internal unsafe delegate int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

			internal static eglDupNativeFenceFDANDROID peglDupNativeFenceFDANDROID;

			internal unsafe delegate bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

			internal static eglExportDMABUFImageMESA peglExportDMABUFImageMESA;

			internal unsafe delegate bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			internal static eglExportDMABUFImageQueryMESA peglExportDMABUFImageQueryMESA;

			internal unsafe delegate bool eglExportDRMImageMESA(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride);

			internal static eglExportDRMImageMESA peglExportDRMImageMESA;

			internal unsafe delegate bool eglFenceNV(IntPtr sync);

			internal static eglFenceNV peglFenceNV;

			internal unsafe delegate bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

			internal static eglGetConfigAttrib peglGetConfigAttrib;

			internal unsafe delegate bool eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config);

			internal static eglGetConfigs peglGetConfigs;

			internal delegate IntPtr eglGetCurrentContext();

			internal static eglGetCurrentContext peglGetCurrentContext;

			internal delegate IntPtr eglGetCurrentDisplay();

			internal static eglGetCurrentDisplay peglGetCurrentDisplay;

			internal delegate IntPtr eglGetCurrentSurface(int readdraw);

			internal static eglGetCurrentSurface peglGetCurrentSurface;

			internal unsafe delegate IntPtr eglGetDisplay(IntPtr display_id);

			internal static eglGetDisplay peglGetDisplay;

			internal delegate int eglGetError();

			internal static eglGetError peglGetError;

			internal unsafe delegate bool eglGetOutputLayersEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers);

			internal static eglGetOutputLayersEXT peglGetOutputLayersEXT;

			internal unsafe delegate bool eglGetOutputPortsEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports);

			internal static eglGetOutputPortsEXT peglGetOutputPortsEXT;

			internal unsafe delegate IntPtr eglGetPlatformDisplay(uint platform, IntPtr native_display, IntPtr* attrib_list);

			internal static eglGetPlatformDisplay peglGetPlatformDisplay;

			internal unsafe delegate IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			internal static eglGetPlatformDisplayEXT peglGetPlatformDisplayEXT;

			internal delegate IntPtr eglGetProcAddress(string procname);

			internal static eglGetProcAddress peglGetProcAddress;

			internal unsafe delegate int eglGetStreamFileDescriptorKHR(IntPtr dpy, IntPtr stream);

			internal static eglGetStreamFileDescriptorKHR peglGetStreamFileDescriptorKHR;

			internal unsafe delegate bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			internal static eglGetSyncAttrib peglGetSyncAttrib;

			internal unsafe delegate bool eglGetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int* value);

			internal static eglGetSyncAttribKHR peglGetSyncAttribKHR;

			internal unsafe delegate bool eglGetSyncAttribNV(IntPtr sync, int attribute, int* value);

			internal static eglGetSyncAttribNV peglGetSyncAttribNV;

			internal delegate UInt64 eglGetSystemTimeFrequencyNV();

			internal static eglGetSystemTimeFrequencyNV peglGetSystemTimeFrequencyNV;

			internal delegate UInt64 eglGetSystemTimeNV();

			internal static eglGetSystemTimeNV peglGetSystemTimeNV;

			internal unsafe delegate bool eglInitialize(IntPtr dpy, int* major, int* minor);

			internal static eglInitialize peglInitialize;

			internal unsafe delegate int eglLabelObjectKHR(IntPtr display, uint objectType, IntPtr @object, IntPtr label);

			internal static eglLabelObjectKHR peglLabelObjectKHR;

			internal unsafe delegate bool eglLockSurfaceKHR(IntPtr dpy, IntPtr surface, int* attrib_list);

			internal static eglLockSurfaceKHR peglLockSurfaceKHR;

			internal unsafe delegate bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			internal static eglMakeCurrent peglMakeCurrent;

			internal unsafe delegate bool eglOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value);

			internal static eglOutputLayerAttribEXT peglOutputLayerAttribEXT;

			internal unsafe delegate bool eglOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value);

			internal static eglOutputPortAttribEXT peglOutputPortAttribEXT;

			internal unsafe delegate bool eglPostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height);

			internal static eglPostSubBufferNV peglPostSubBufferNV;

			internal delegate uint eglQueryAPI();

			internal static eglQueryAPI peglQueryAPI;

			internal unsafe delegate bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

			internal static eglQueryContext peglQueryContext;

			internal unsafe delegate bool eglQueryDebugKHR(int attribute, IntPtr* value);

			internal static eglQueryDebugKHR peglQueryDebugKHR;

			internal unsafe delegate bool eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			internal static eglQueryDeviceAttribEXT peglQueryDeviceAttribEXT;

			internal unsafe delegate IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			internal static eglQueryDeviceStringEXT peglQueryDeviceStringEXT;

			internal unsafe delegate bool eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

			internal static eglQueryDevicesEXT peglQueryDevicesEXT;

			internal unsafe delegate bool eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

			[AliasOf("eglQueryDisplayAttribEXT")]
			[AliasOf("eglQueryDisplayAttribNV")]
			internal static eglQueryDisplayAttribEXT peglQueryDisplayAttribEXT;

			internal unsafe delegate bool eglQueryNativeDisplayNV(IntPtr dpy, IntPtr* display_id);

			internal static eglQueryNativeDisplayNV peglQueryNativeDisplayNV;

			internal unsafe delegate bool eglQueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr* pixmap);

			internal static eglQueryNativePixmapNV peglQueryNativePixmapNV;

			internal unsafe delegate bool eglQueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr* window);

			internal static eglQueryNativeWindowNV peglQueryNativeWindowNV;

			internal unsafe delegate bool eglQueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value);

			internal static eglQueryOutputLayerAttribEXT peglQueryOutputLayerAttribEXT;

			internal unsafe delegate IntPtr eglQueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name);

			internal static eglQueryOutputLayerStringEXT peglQueryOutputLayerStringEXT;

			internal unsafe delegate bool eglQueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr* value);

			internal static eglQueryOutputPortAttribEXT peglQueryOutputPortAttribEXT;

			internal unsafe delegate IntPtr eglQueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name);

			internal static eglQueryOutputPortStringEXT peglQueryOutputPortStringEXT;

			internal unsafe delegate bool eglQueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int* value);

			internal static eglQueryStreamKHR peglQueryStreamKHR;

			internal unsafe delegate bool eglQueryStreamMetadataNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data);

			internal static eglQueryStreamMetadataNV peglQueryStreamMetadataNV;

			internal unsafe delegate bool eglQueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			internal static eglQueryStreamTimeKHR peglQueryStreamTimeKHR;

			internal unsafe delegate bool eglQueryStreamu64KHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			internal static eglQueryStreamu64KHR peglQueryStreamu64KHR;

			internal unsafe delegate IntPtr eglQueryString(IntPtr dpy, int name);

			internal static eglQueryString peglQueryString;

			internal unsafe delegate bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value);

			internal static eglQuerySurface peglQuerySurface;

			internal unsafe delegate bool eglQuerySurface64KHR(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			internal static eglQuerySurface64KHR peglQuerySurface64KHR;

			internal unsafe delegate bool eglQuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			internal static eglQuerySurfacePointerANGLE peglQuerySurfacePointerANGLE;

			internal unsafe delegate bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			internal static eglReleaseTexImage peglReleaseTexImage;

			internal delegate bool eglReleaseThread();

			internal static eglReleaseThread peglReleaseThread;

			internal unsafe delegate void eglSetBlobCacheFuncsANDROID(IntPtr dpy, SetBlobFuncDelegate set, GetBlobFuncDelegate get);

			internal static eglSetBlobCacheFuncsANDROID peglSetBlobCacheFuncsANDROID;

			internal unsafe delegate bool eglSetDamageRegionKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			internal static eglSetDamageRegionKHR peglSetDamageRegionKHR;

			internal unsafe delegate bool eglSetStreamMetadataNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data);

			internal static eglSetStreamMetadataNV peglSetStreamMetadataNV;

			internal unsafe delegate bool eglSignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode);

			internal static eglSignalSyncKHR peglSignalSyncKHR;

			internal unsafe delegate bool eglSignalSyncNV(IntPtr sync, uint mode);

			internal static eglSignalSyncNV peglSignalSyncNV;

			internal unsafe delegate bool eglStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value);

			internal static eglStreamAttribKHR peglStreamAttribKHR;

			internal unsafe delegate bool eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			internal static eglStreamConsumerAcquireKHR peglStreamConsumerAcquireKHR;

			internal unsafe delegate bool eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			internal static eglStreamConsumerGLTextureExternalKHR peglStreamConsumerGLTextureExternalKHR;

			internal unsafe delegate bool eglStreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			internal static eglStreamConsumerGLTextureExternalAttribsNV peglStreamConsumerGLTextureExternalAttribsNV;

			internal unsafe delegate bool eglStreamConsumerOutputEXT(IntPtr dpy, IntPtr stream, IntPtr layer);

			internal static eglStreamConsumerOutputEXT peglStreamConsumerOutputEXT;

			internal unsafe delegate bool eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

			internal static eglStreamConsumerReleaseKHR peglStreamConsumerReleaseKHR;

			internal unsafe delegate bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			internal static eglSurfaceAttrib peglSurfaceAttrib;

			internal unsafe delegate bool eglSwapBuffers(IntPtr dpy, IntPtr surface);

			internal static eglSwapBuffers peglSwapBuffers;

			internal unsafe delegate bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			internal static eglSwapBuffersWithDamageEXT peglSwapBuffersWithDamageEXT;

			internal unsafe delegate bool eglSwapBuffersWithDamageKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			internal static eglSwapBuffersWithDamageKHR peglSwapBuffersWithDamageKHR;

			internal unsafe delegate bool eglSwapBuffersRegionNOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			internal static eglSwapBuffersRegionNOK peglSwapBuffersRegionNOK;

			internal unsafe delegate bool eglSwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			internal static eglSwapBuffersRegion2NOK peglSwapBuffersRegion2NOK;

			internal unsafe delegate bool eglSwapInterval(IntPtr dpy, int interval);

			internal static eglSwapInterval peglSwapInterval;

			internal unsafe delegate bool eglTerminate(IntPtr dpy);

			internal static eglTerminate peglTerminate;

			internal unsafe delegate bool eglUnlockSurfaceKHR(IntPtr dpy, IntPtr surface);

			internal static eglUnlockSurfaceKHR peglUnlockSurfaceKHR;

			internal delegate bool eglWaitClient();

			internal static eglWaitClient peglWaitClient;

			internal delegate bool eglWaitGL();

			internal static eglWaitGL peglWaitGL;

			internal delegate bool eglWaitNative(int engine);

			internal static eglWaitNative peglWaitNative;

			internal unsafe delegate bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

			internal static eglWaitSync peglWaitSync;

			internal unsafe delegate int eglWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags);

			internal static eglWaitSyncKHR peglWaitSyncKHR;

		}
	}

}

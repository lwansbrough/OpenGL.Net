
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

namespace OpenGL
{
	public unsafe partial class Egl
	{
		internal unsafe static partial class UnsafeNativeMethods
		{
			[DllImport(Library, EntryPoint = "eglBindAPI", ExactSpelling = true)]
			internal extern static bool eglBindAPI(uint api);

			[DllImport(Library, EntryPoint = "eglBindTexImage", ExactSpelling = true)]
			internal extern static unsafe bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[DllImport(Library, EntryPoint = "eglChooseConfig", ExactSpelling = true)]
			internal extern static unsafe bool eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config);

			[DllImport(Library, EntryPoint = "eglClientWaitSync", ExactSpelling = true)]
			internal extern static unsafe int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "eglClientWaitSyncKHR", ExactSpelling = true)]
			internal extern static unsafe int eglClientWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "eglClientWaitSyncNV", ExactSpelling = true)]
			internal extern static unsafe int eglClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "eglCopyBuffers", ExactSpelling = true)]
			internal extern static unsafe bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

			[DllImport(Library, EntryPoint = "eglCreateContext", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateDRMImageMESA", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateDRMImageMESA(IntPtr dpy, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateFenceSyncNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateFenceSyncNV(IntPtr dpy, uint condition, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateImage", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateImageKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateImageKHR(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePbufferFromClientBuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePbufferSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePixmapSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePixmapSurfaceHI", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap* pixmap);

			[DllImport(Library, EntryPoint = "eglCreatePlatformPixmapSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePlatformPixmapSurfaceEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePlatformWindowSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreatePlatformWindowSurfaceEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateStreamFromFileDescriptorKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamFromFileDescriptorKHR(IntPtr dpy, int file_descriptor);

			[DllImport(Library, EntryPoint = "eglCreateStreamKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamKHR(IntPtr dpy, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateStreamProducerSurfaceKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateStreamSyncNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateSync", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateSyncKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateSyncKHR(IntPtr dpy, uint type, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateSync64KHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateSync64KHR(IntPtr dpy, uint type, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglCreateWindowSurface", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglDebugMessageControlKHR", ExactSpelling = true)]
			internal extern static unsafe int eglDebugMessageControlKHR(DebugProcKHR callback, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglDestroyContext", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroyContext(IntPtr dpy, IntPtr ctx);

			[DllImport(Library, EntryPoint = "eglDestroyImage", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroyImage(IntPtr dpy, IntPtr image);

			[DllImport(Library, EntryPoint = "eglDestroyImageKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroyImageKHR(IntPtr dpy, IntPtr image);

			[DllImport(Library, EntryPoint = "eglDestroyStreamKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroyStreamKHR(IntPtr dpy, IntPtr stream);

			[DllImport(Library, EntryPoint = "eglDestroySurface", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroySurface(IntPtr dpy, IntPtr surface);

			[DllImport(Library, EntryPoint = "eglDestroySync", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroySync(IntPtr dpy, IntPtr sync);

			[DllImport(Library, EntryPoint = "eglDestroySyncKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroySyncKHR(IntPtr dpy, IntPtr sync);

			[DllImport(Library, EntryPoint = "eglDestroySyncNV", ExactSpelling = true)]
			internal extern static unsafe bool eglDestroySyncNV(IntPtr sync);

			[DllImport(Library, EntryPoint = "eglDupNativeFenceFDANDROID", ExactSpelling = true)]
			internal extern static unsafe int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

			[DllImport(Library, EntryPoint = "eglExportDMABUFImageMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

			[DllImport(Library, EntryPoint = "eglExportDMABUFImageQueryMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			[DllImport(Library, EntryPoint = "eglExportDRMImageMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDRMImageMESA(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride);

			[DllImport(Library, EntryPoint = "eglFenceNV", ExactSpelling = true)]
			internal extern static unsafe bool eglFenceNV(IntPtr sync);

			[DllImport(Library, EntryPoint = "eglGetConfigAttrib", ExactSpelling = true)]
			internal extern static unsafe bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

			[DllImport(Library, EntryPoint = "eglGetConfigs", ExactSpelling = true)]
			internal extern static unsafe bool eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config);

			[DllImport(Library, EntryPoint = "eglGetCurrentContext", ExactSpelling = true)]
			internal extern static IntPtr eglGetCurrentContext();

			[DllImport(Library, EntryPoint = "eglGetCurrentDisplay", ExactSpelling = true)]
			internal extern static IntPtr eglGetCurrentDisplay();

			[DllImport(Library, EntryPoint = "eglGetCurrentSurface", ExactSpelling = true)]
			internal extern static IntPtr eglGetCurrentSurface(int readdraw);

			[DllImport(Library, EntryPoint = "eglGetDisplay", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglGetDisplay(IntPtr display_id);

			[DllImport(Library, EntryPoint = "eglGetError", ExactSpelling = true)]
			internal extern static int eglGetError();

			[DllImport(Library, EntryPoint = "eglGetOutputLayersEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglGetOutputLayersEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers);

			[DllImport(Library, EntryPoint = "eglGetOutputPortsEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglGetOutputPortsEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports);

			[DllImport(Library, EntryPoint = "eglGetPlatformDisplay", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglGetPlatformDisplay(uint platform, IntPtr native_display, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglGetPlatformDisplayEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglGetProcAddress", ExactSpelling = true)]
			internal extern static IntPtr eglGetProcAddress(string procname);

			[DllImport(Library, EntryPoint = "eglGetStreamFileDescriptorKHR", ExactSpelling = true)]
			internal extern static unsafe int eglGetStreamFileDescriptorKHR(IntPtr dpy, IntPtr stream);

			[DllImport(Library, EntryPoint = "eglGetSyncAttrib", ExactSpelling = true)]
			internal extern static unsafe bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglGetSyncAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglGetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int* value);

			[DllImport(Library, EntryPoint = "eglGetSyncAttribNV", ExactSpelling = true)]
			internal extern static unsafe bool eglGetSyncAttribNV(IntPtr sync, int attribute, int* value);

			[DllImport(Library, EntryPoint = "eglGetSystemTimeFrequencyNV", ExactSpelling = true)]
			internal extern static UInt64 eglGetSystemTimeFrequencyNV();

			[DllImport(Library, EntryPoint = "eglGetSystemTimeNV", ExactSpelling = true)]
			internal extern static UInt64 eglGetSystemTimeNV();

			[DllImport(Library, EntryPoint = "eglInitialize", ExactSpelling = true)]
			internal extern static unsafe bool eglInitialize(IntPtr dpy, int* major, int* minor);

			[DllImport(Library, EntryPoint = "eglLabelObjectKHR", ExactSpelling = true)]
			internal extern static unsafe int eglLabelObjectKHR(IntPtr display, uint objectType, IntPtr @object, IntPtr label);

			[DllImport(Library, EntryPoint = "eglLockSurfaceKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglLockSurfaceKHR(IntPtr dpy, IntPtr surface, int* attrib_list);

			[DllImport(Library, EntryPoint = "eglMakeCurrent", ExactSpelling = true)]
			internal extern static unsafe bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			[DllImport(Library, EntryPoint = "eglOutputLayerAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value);

			[DllImport(Library, EntryPoint = "eglOutputPortAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value);

			[DllImport(Library, EntryPoint = "eglPostSubBufferNV", ExactSpelling = true)]
			internal extern static unsafe bool eglPostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height);

			[DllImport(Library, EntryPoint = "eglQueryAPI", ExactSpelling = true)]
			internal extern static uint eglQueryAPI();

			[DllImport(Library, EntryPoint = "eglQueryContext", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

			[DllImport(Library, EntryPoint = "eglQueryDebugKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDebugKHR(int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQueryDeviceAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQueryDeviceStringEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			[DllImport(Library, EntryPoint = "eglQueryDevicesEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

			[DllImport(Library, EntryPoint = "eglQueryDisplayAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQueryDisplayAttribNV", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDisplayAttribNV(IntPtr dpy, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQueryNativeDisplayNV", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryNativeDisplayNV(IntPtr dpy, IntPtr* display_id);

			[DllImport(Library, EntryPoint = "eglQueryNativePixmapNV", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr* pixmap);

			[DllImport(Library, EntryPoint = "eglQueryNativeWindowNV", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr* window);

			[DllImport(Library, EntryPoint = "eglQueryOutputLayerAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQueryOutputLayerStringEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name);

			[DllImport(Library, EntryPoint = "eglQueryOutputPortAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQueryOutputPortStringEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name);

			[DllImport(Library, EntryPoint = "eglQueryStreamKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int* value);

			[DllImport(Library, EntryPoint = "eglQueryStreamMetadataNV", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryStreamMetadataNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data);

			[DllImport(Library, EntryPoint = "eglQueryStreamTimeKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			[DllImport(Library, EntryPoint = "eglQueryStreamu64KHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryStreamu64KHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			[DllImport(Library, EntryPoint = "eglQueryString", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryString(IntPtr dpy, int name);

			[DllImport(Library, EntryPoint = "eglQuerySurface", ExactSpelling = true)]
			internal extern static unsafe bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value);

			[DllImport(Library, EntryPoint = "eglQuerySurface64KHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQuerySurface64KHR(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglQuerySurfacePointerANGLE", ExactSpelling = true)]
			internal extern static unsafe bool eglQuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			[DllImport(Library, EntryPoint = "eglReleaseTexImage", ExactSpelling = true)]
			internal extern static unsafe bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[DllImport(Library, EntryPoint = "eglReleaseThread", ExactSpelling = true)]
			internal extern static bool eglReleaseThread();

			[DllImport(Library, EntryPoint = "eglSetBlobCacheFuncsANDROID", ExactSpelling = true)]
			internal extern static unsafe void eglSetBlobCacheFuncsANDROID(IntPtr dpy, SetBlobFuncDelegate set, GetBlobFuncDelegate get);

			[DllImport(Library, EntryPoint = "eglSetDamageRegionKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglSetDamageRegionKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[DllImport(Library, EntryPoint = "eglSetStreamMetadataNV", ExactSpelling = true)]
			internal extern static unsafe bool eglSetStreamMetadataNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data);

			[DllImport(Library, EntryPoint = "eglSignalSyncKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglSignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode);

			[DllImport(Library, EntryPoint = "eglSignalSyncNV", ExactSpelling = true)]
			internal extern static unsafe bool eglSignalSyncNV(IntPtr sync, uint mode);

			[DllImport(Library, EntryPoint = "eglStreamAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value);

			[DllImport(Library, EntryPoint = "eglStreamConsumerAcquireKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			[DllImport(Library, EntryPoint = "eglStreamConsumerGLTextureExternalKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			[DllImport(Library, EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			[DllImport(Library, EntryPoint = "eglStreamConsumerOutputEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerOutputEXT(IntPtr dpy, IntPtr stream, IntPtr layer);

			[DllImport(Library, EntryPoint = "eglStreamConsumerReleaseKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

			[DllImport(Library, EntryPoint = "eglSurfaceAttrib", ExactSpelling = true)]
			internal extern static unsafe bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			[DllImport(Library, EntryPoint = "eglSwapBuffers", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffers(IntPtr dpy, IntPtr surface);

			[DllImport(Library, EntryPoint = "eglSwapBuffersWithDamageEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[DllImport(Library, EntryPoint = "eglSwapBuffersWithDamageKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersWithDamageKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[DllImport(Library, EntryPoint = "eglSwapBuffersRegionNOK", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersRegionNOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			[DllImport(Library, EntryPoint = "eglSwapBuffersRegion2NOK", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			[DllImport(Library, EntryPoint = "eglSwapInterval", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapInterval(IntPtr dpy, int interval);

			[DllImport(Library, EntryPoint = "eglTerminate", ExactSpelling = true)]
			internal extern static unsafe bool eglTerminate(IntPtr dpy);

			[DllImport(Library, EntryPoint = "eglUnlockSurfaceKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglUnlockSurfaceKHR(IntPtr dpy, IntPtr surface);

			[DllImport(Library, EntryPoint = "eglWaitClient", ExactSpelling = true)]
			internal extern static bool eglWaitClient();

			[DllImport(Library, EntryPoint = "eglWaitGL", ExactSpelling = true)]
			internal extern static bool eglWaitGL();

			[DllImport(Library, EntryPoint = "eglWaitNative", ExactSpelling = true)]
			internal extern static bool eglWaitNative(int engine);

			[DllImport(Library, EntryPoint = "eglWaitSync", ExactSpelling = true)]
			internal extern static unsafe bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

			[DllImport(Library, EntryPoint = "eglWaitSyncKHR", ExactSpelling = true)]
			internal extern static unsafe int eglWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags);

		}
	}

}

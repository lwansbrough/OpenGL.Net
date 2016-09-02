
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
	public unsafe partial class Gl
	{
		internal unsafe static partial class UnsafeNativeMethods
		{
			[DllImport(Library, EntryPoint = "glAccum", ExactSpelling = true)]
			internal extern static void glAccum(Int32 op, float value);

			[DllImport(Library, EntryPoint = "glAccumxOES", ExactSpelling = true)]
			internal extern static unsafe void glAccumxOES(Int32 op, IntPtr value);

			[DllImport(Library, EntryPoint = "glActiveProgramEXT", ExactSpelling = true)]
			internal extern static void glActiveProgramEXT(UInt32 program);

			[DllImport(Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
			internal extern static void glActiveShaderProgram(UInt32 pipeline, UInt32 program);

			[DllImport(Library, EntryPoint = "glActiveShaderProgramEXT", ExactSpelling = true)]
			internal extern static void glActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);

			[DllImport(Library, EntryPoint = "glActiveStencilFaceEXT", ExactSpelling = true)]
			internal extern static void glActiveStencilFaceEXT(Int32 face);

			[DllImport(Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
			internal extern static void glActiveTexture(Int32 texture);

			[DllImport(Library, EntryPoint = "glActiveTextureARB", ExactSpelling = true)]
			internal extern static void glActiveTextureARB(Int32 texture);

			[DllImport(Library, EntryPoint = "glActiveVaryingNV", ExactSpelling = true)]
			internal extern static void glActiveVaryingNV(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glAlphaFragmentOp1ATI", ExactSpelling = true)]
			internal extern static void glAlphaFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[DllImport(Library, EntryPoint = "glAlphaFragmentOp2ATI", ExactSpelling = true)]
			internal extern static void glAlphaFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[DllImport(Library, EntryPoint = "glAlphaFragmentOp3ATI", ExactSpelling = true)]
			internal extern static void glAlphaFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[DllImport(Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
			internal extern static void glAlphaFunc(Int32 func, float @ref);

			[DllImport(Library, EntryPoint = "glAlphaFuncQCOM", ExactSpelling = true)]
			internal extern static void glAlphaFuncQCOM(Int32 func, float @ref);

			[DllImport(Library, EntryPoint = "glAlphaFuncx", ExactSpelling = true)]
			internal extern static unsafe void glAlphaFuncx(Int32 func, IntPtr @ref);

			[DllImport(Library, EntryPoint = "glAlphaFuncxOES", ExactSpelling = true)]
			internal extern static unsafe void glAlphaFuncxOES(Int32 func, IntPtr @ref);

			[DllImport(Library, EntryPoint = "glApplyFramebufferAttachmentCMAAINTEL", ExactSpelling = true)]
			internal extern static void glApplyFramebufferAttachmentCMAAINTEL();

			[DllImport(Library, EntryPoint = "glApplyTextureEXT", ExactSpelling = true)]
			internal extern static void glApplyTextureEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glAreProgramsResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glAreProgramsResidentNV(Int32 n, UInt32* programs, bool* residences);

			[DllImport(Library, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glAreTexturesResident(Int32 n, UInt32* textures, bool* residences);

			[DllImport(Library, EntryPoint = "glAreTexturesResidentEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glAreTexturesResidentEXT(Int32 n, UInt32* textures, bool* residences);

			[DllImport(Library, EntryPoint = "glArrayElement", ExactSpelling = true)]
			internal extern static void glArrayElement(Int32 i);

			[DllImport(Library, EntryPoint = "glArrayElementEXT", ExactSpelling = true)]
			internal extern static void glArrayElementEXT(Int32 i);

			[DllImport(Library, EntryPoint = "glArrayObjectATI", ExactSpelling = true)]
			internal extern static void glArrayObjectATI(Int32 array, Int32 size, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset);

			[DllImport(Library, EntryPoint = "glAsyncMarkerSGIX", ExactSpelling = true)]
			internal extern static void glAsyncMarkerSGIX(UInt32 marker);

			[DllImport(Library, EntryPoint = "glAttachObjectARB", ExactSpelling = true)]
			internal extern static void glAttachObjectARB(UInt32 containerObj, UInt32 obj);

			[DllImport(Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
			internal extern static void glAttachShader(UInt32 program, UInt32 shader);

			[DllImport(Library, EntryPoint = "glBegin", ExactSpelling = true)]
			internal extern static void glBegin(Int32 mode);

			[DllImport(Library, EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
			internal extern static void glBeginConditionalRender(UInt32 id, Int32 mode);

			[DllImport(Library, EntryPoint = "glBeginConditionalRenderNV", ExactSpelling = true)]
			internal extern static void glBeginConditionalRenderNV(UInt32 id, Int32 mode);

			[DllImport(Library, EntryPoint = "glBeginConditionalRenderNVX", ExactSpelling = true)]
			internal extern static void glBeginConditionalRenderNVX(UInt32 id);

			[DllImport(Library, EntryPoint = "glBeginFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glBeginFragmentShaderATI();

			[DllImport(Library, EntryPoint = "glBeginOcclusionQueryNV", ExactSpelling = true)]
			internal extern static void glBeginOcclusionQueryNV(UInt32 id);

			[DllImport(Library, EntryPoint = "glBeginPerfMonitorAMD", ExactSpelling = true)]
			internal extern static void glBeginPerfMonitorAMD(UInt32 monitor);

			[DllImport(Library, EntryPoint = "glBeginPerfQueryINTEL", ExactSpelling = true)]
			internal extern static void glBeginPerfQueryINTEL(UInt32 queryHandle);

			[DllImport(Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
			internal extern static void glBeginQuery(Int32 target, UInt32 id);

			[DllImport(Library, EntryPoint = "glBeginQueryARB", ExactSpelling = true)]
			internal extern static void glBeginQueryARB(Int32 target, UInt32 id);

			[DllImport(Library, EntryPoint = "glBeginQueryEXT", ExactSpelling = true)]
			internal extern static void glBeginQueryEXT(Int32 target, UInt32 id);

			[DllImport(Library, EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
			internal extern static void glBeginQueryIndexed(Int32 target, UInt32 index, UInt32 id);

			[DllImport(Library, EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
			internal extern static void glBeginTransformFeedback(Int32 primitiveMode);

			[DllImport(Library, EntryPoint = "glBeginTransformFeedbackEXT", ExactSpelling = true)]
			internal extern static void glBeginTransformFeedbackEXT(Int32 primitiveMode);

			[DllImport(Library, EntryPoint = "glBeginTransformFeedbackNV", ExactSpelling = true)]
			internal extern static void glBeginTransformFeedbackNV(Int32 primitiveMode);

			[DllImport(Library, EntryPoint = "glBeginVertexShaderEXT", ExactSpelling = true)]
			internal extern static void glBeginVertexShaderEXT();

			[DllImport(Library, EntryPoint = "glBeginVideoCaptureNV", ExactSpelling = true)]
			internal extern static void glBeginVideoCaptureNV(UInt32 video_capture_slot);

			[DllImport(Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
			internal extern static void glBindAttribLocation(UInt32 program, UInt32 index, String name);

			[DllImport(Library, EntryPoint = "glBindAttribLocationARB", ExactSpelling = true)]
			internal extern static void glBindAttribLocationARB(UInt32 programObj, UInt32 index, String name);

			[DllImport(Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
			internal extern static void glBindBuffer(Int32 target, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glBindBufferARB", ExactSpelling = true)]
			internal extern static void glBindBufferARB(Int32 target, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glBindBufferBase", ExactSpelling = true)]
			internal extern static void glBindBufferBase(Int32 target, UInt32 index, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glBindBufferBaseEXT", ExactSpelling = true)]
			internal extern static void glBindBufferBaseEXT(Int32 target, UInt32 index, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glBindBufferBaseNV", ExactSpelling = true)]
			internal extern static void glBindBufferBaseNV(Int32 target, UInt32 index, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glBindBufferOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glBindBufferOffsetEXT(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset);

			[DllImport(Library, EntryPoint = "glBindBufferOffsetNV", ExactSpelling = true)]
			internal extern static unsafe void glBindBufferOffsetNV(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset);

			[DllImport(Library, EntryPoint = "glBindBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glBindBufferRange(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glBindBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glBindBufferRangeEXT(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glBindBufferRangeNV", ExactSpelling = true)]
			internal extern static unsafe void glBindBufferRangeNV(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glBindBuffersBase", ExactSpelling = true)]
			internal extern static unsafe void glBindBuffersBase(Int32 target, UInt32 first, Int32 count, UInt32* buffers);

			[DllImport(Library, EntryPoint = "glBindBuffersRange", ExactSpelling = true)]
			internal extern static unsafe void glBindBuffersRange(Int32 target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, UInt32* sizes);

			[DllImport(Library, EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
			internal extern static void glBindFragDataLocation(UInt32 program, UInt32 color, String name);

			[DllImport(Library, EntryPoint = "glBindFragDataLocationEXT", ExactSpelling = true)]
			internal extern static void glBindFragDataLocationEXT(UInt32 program, UInt32 color, String name);

			[DllImport(Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
			internal extern static void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

			[DllImport(Library, EntryPoint = "glBindFragDataLocationIndexedEXT", ExactSpelling = true)]
			internal extern static void glBindFragDataLocationIndexedEXT(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

			[DllImport(Library, EntryPoint = "glBindFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glBindFragmentShaderATI(UInt32 id);

			[DllImport(Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
			internal extern static void glBindFramebuffer(Int32 target, UInt32 framebuffer);

			[DllImport(Library, EntryPoint = "glBindFramebufferEXT", ExactSpelling = true)]
			internal extern static void glBindFramebufferEXT(Int32 target, UInt32 framebuffer);

			[DllImport(Library, EntryPoint = "glBindFramebufferOES", ExactSpelling = true)]
			internal extern static void glBindFramebufferOES(Int32 target, UInt32 framebuffer);

			[DllImport(Library, EntryPoint = "glBindImageTexture", ExactSpelling = true)]
			internal extern static void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[DllImport(Library, EntryPoint = "glBindImageTextureEXT", ExactSpelling = true)]
			internal extern static void glBindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[DllImport(Library, EntryPoint = "glBindImageTextures", ExactSpelling = true)]
			internal extern static unsafe void glBindImageTextures(UInt32 first, Int32 count, UInt32* textures);

			[DllImport(Library, EntryPoint = "glBindLightParameterEXT", ExactSpelling = true)]
			internal extern static UInt32 glBindLightParameterEXT(Int32 light, Int32 value);

			[DllImport(Library, EntryPoint = "glBindMaterialParameterEXT", ExactSpelling = true)]
			internal extern static UInt32 glBindMaterialParameterEXT(Int32 face, Int32 value);

			[DllImport(Library, EntryPoint = "glBindMultiTextureEXT", ExactSpelling = true)]
			internal extern static void glBindMultiTextureEXT(Int32 texunit, Int32 target, UInt32 texture);

			[DllImport(Library, EntryPoint = "glBindParameterEXT", ExactSpelling = true)]
			internal extern static UInt32 glBindParameterEXT(Int32 value);

			[DllImport(Library, EntryPoint = "glBindProgramARB", ExactSpelling = true)]
			internal extern static void glBindProgramARB(Int32 target, UInt32 program);

			[DllImport(Library, EntryPoint = "glBindProgramNV", ExactSpelling = true)]
			internal extern static void glBindProgramNV(Int32 target, UInt32 id);

			[DllImport(Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
			internal extern static void glBindProgramPipeline(UInt32 pipeline);

			[DllImport(Library, EntryPoint = "glBindProgramPipelineEXT", ExactSpelling = true)]
			internal extern static void glBindProgramPipelineEXT(UInt32 pipeline);

			[DllImport(Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
			internal extern static void glBindRenderbuffer(Int32 target, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glBindRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glBindRenderbufferEXT(Int32 target, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glBindRenderbufferOES", ExactSpelling = true)]
			internal extern static void glBindRenderbufferOES(Int32 target, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
			internal extern static void glBindSampler(UInt32 unit, UInt32 sampler);

			[DllImport(Library, EntryPoint = "glBindSamplers", ExactSpelling = true)]
			internal extern static unsafe void glBindSamplers(UInt32 first, Int32 count, UInt32* samplers);

			[DllImport(Library, EntryPoint = "glBindTexGenParameterEXT", ExactSpelling = true)]
			internal extern static UInt32 glBindTexGenParameterEXT(Int32 unit, Int32 coord, Int32 value);

			[DllImport(Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
			internal extern static void glBindTexture(Int32 target, UInt32 texture);

			[DllImport(Library, EntryPoint = "glBindTextureEXT", ExactSpelling = true)]
			internal extern static void glBindTextureEXT(Int32 target, UInt32 texture);

			[DllImport(Library, EntryPoint = "glBindTextureUnit", ExactSpelling = true)]
			internal extern static void glBindTextureUnit(UInt32 unit, UInt32 texture);

			[DllImport(Library, EntryPoint = "glBindTextureUnitParameterEXT", ExactSpelling = true)]
			internal extern static UInt32 glBindTextureUnitParameterEXT(Int32 unit, Int32 value);

			[DllImport(Library, EntryPoint = "glBindTextures", ExactSpelling = true)]
			internal extern static unsafe void glBindTextures(UInt32 first, Int32 count, UInt32* textures);

			[DllImport(Library, EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
			internal extern static void glBindTransformFeedback(Int32 target, UInt32 id);

			[DllImport(Library, EntryPoint = "glBindTransformFeedbackNV", ExactSpelling = true)]
			internal extern static void glBindTransformFeedbackNV(Int32 target, UInt32 id);

			[DllImport(Library, EntryPoint = "glBindVertexArray", ExactSpelling = true)]
			internal extern static void glBindVertexArray(UInt32 array);

			[DllImport(Library, EntryPoint = "glBindVertexArrayAPPLE", ExactSpelling = true)]
			internal extern static void glBindVertexArrayAPPLE(UInt32 array);

			[DllImport(Library, EntryPoint = "glBindVertexArrayOES", ExactSpelling = true)]
			internal extern static void glBindVertexArrayOES(UInt32 array);

			[DllImport(Library, EntryPoint = "glBindVertexBuffer", ExactSpelling = true)]
			internal extern static unsafe void glBindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[DllImport(Library, EntryPoint = "glBindVertexBuffers", ExactSpelling = true)]
			internal extern static unsafe void glBindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);

			[DllImport(Library, EntryPoint = "glBindVertexShaderEXT", ExactSpelling = true)]
			internal extern static void glBindVertexShaderEXT(UInt32 id);

			[DllImport(Library, EntryPoint = "glBindVideoCaptureStreamBufferNV", ExactSpelling = true)]
			internal extern static unsafe void glBindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, IntPtr offset);

			[DllImport(Library, EntryPoint = "glBindVideoCaptureStreamTextureNV", ExactSpelling = true)]
			internal extern static void glBindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, Int32 target, UInt32 texture);

			[DllImport(Library, EntryPoint = "glBinormal3bEXT", ExactSpelling = true)]
			internal extern static void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz);

			[DllImport(Library, EntryPoint = "glBinormal3bvEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3bvEXT(sbyte* v);

			[DllImport(Library, EntryPoint = "glBinormal3dEXT", ExactSpelling = true)]
			internal extern static void glBinormal3dEXT(double bx, double by, double bz);

			[DllImport(Library, EntryPoint = "glBinormal3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3dvEXT(double* v);

			[DllImport(Library, EntryPoint = "glBinormal3fEXT", ExactSpelling = true)]
			internal extern static void glBinormal3fEXT(float bx, float by, float bz);

			[DllImport(Library, EntryPoint = "glBinormal3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3fvEXT(float* v);

			[DllImport(Library, EntryPoint = "glBinormal3iEXT", ExactSpelling = true)]
			internal extern static void glBinormal3iEXT(Int32 bx, Int32 by, Int32 bz);

			[DllImport(Library, EntryPoint = "glBinormal3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3ivEXT(Int32* v);

			[DllImport(Library, EntryPoint = "glBinormal3sEXT", ExactSpelling = true)]
			internal extern static void glBinormal3sEXT(Int16 bx, Int16 by, Int16 bz);

			[DllImport(Library, EntryPoint = "glBinormal3svEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3svEXT(Int16* v);

			[DllImport(Library, EntryPoint = "glBinormalPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormalPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glBitmap", ExactSpelling = true)]
			internal extern static unsafe void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

			[DllImport(Library, EntryPoint = "glBitmapxOES", ExactSpelling = true)]
			internal extern static unsafe void glBitmapxOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte* bitmap);

			[DllImport(Library, EntryPoint = "glBlendBarrier", ExactSpelling = true)]
			internal extern static void glBlendBarrier();

			[DllImport(Library, EntryPoint = "glBlendBarrierKHR", ExactSpelling = true)]
			internal extern static void glBlendBarrierKHR();

			[DllImport(Library, EntryPoint = "glBlendBarrierNV", ExactSpelling = true)]
			internal extern static void glBlendBarrierNV();

			[DllImport(Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
			internal extern static void glBlendColor(float red, float green, float blue, float alpha);

			[DllImport(Library, EntryPoint = "glBlendColorEXT", ExactSpelling = true)]
			internal extern static void glBlendColorEXT(float red, float green, float blue, float alpha);

			[DllImport(Library, EntryPoint = "glBlendColorxOES", ExactSpelling = true)]
			internal extern static unsafe void glBlendColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[DllImport(Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
			internal extern static void glBlendEquation(Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationEXT", ExactSpelling = true)]
			internal extern static void glBlendEquationEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationIndexedAMD", ExactSpelling = true)]
			internal extern static void glBlendEquationIndexedAMD(UInt32 buf, Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationOES", ExactSpelling = true)]
			internal extern static void glBlendEquationOES(Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparate(Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparateEXT", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateEXT(Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparateIndexedAMD", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateIndexedAMD(UInt32 buf, Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparateOES", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateOES(Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparatei(UInt32 buf, Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparateiARB", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateiARB(UInt32 buf, Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparateiEXT", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateiEXT(UInt32 buf, Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationSeparateiOES", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateiOES(UInt32 buf, Int32 modeRGB, Int32 modeAlpha);

			[DllImport(Library, EntryPoint = "glBlendEquationi", ExactSpelling = true)]
			internal extern static void glBlendEquationi(UInt32 buf, Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationiARB", ExactSpelling = true)]
			internal extern static void glBlendEquationiARB(UInt32 buf, Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationiEXT", ExactSpelling = true)]
			internal extern static void glBlendEquationiEXT(UInt32 buf, Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendEquationiOES", ExactSpelling = true)]
			internal extern static void glBlendEquationiOES(UInt32 buf, Int32 mode);

			[DllImport(Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
			internal extern static void glBlendFunc(Int32 sfactor, Int32 dfactor);

			[DllImport(Library, EntryPoint = "glBlendFuncIndexedAMD", ExactSpelling = true)]
			internal extern static void glBlendFuncIndexedAMD(UInt32 buf, Int32 src, Int32 dst);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparate(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateEXT", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateEXT(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateINGR", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateINGR(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateIndexedAMD", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateIndexedAMD(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateOES", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateOES(Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparatei(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateiARB", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateiARB(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateiEXT", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateiEXT(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[DllImport(Library, EntryPoint = "glBlendFuncSeparateiOES", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateiOES(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[DllImport(Library, EntryPoint = "glBlendFunci", ExactSpelling = true)]
			internal extern static void glBlendFunci(UInt32 buf, Int32 src, Int32 dst);

			[DllImport(Library, EntryPoint = "glBlendFunciARB", ExactSpelling = true)]
			internal extern static void glBlendFunciARB(UInt32 buf, Int32 src, Int32 dst);

			[DllImport(Library, EntryPoint = "glBlendFunciEXT", ExactSpelling = true)]
			internal extern static void glBlendFunciEXT(UInt32 buf, Int32 src, Int32 dst);

			[DllImport(Library, EntryPoint = "glBlendFunciOES", ExactSpelling = true)]
			internal extern static void glBlendFunciOES(UInt32 buf, Int32 src, Int32 dst);

			[DllImport(Library, EntryPoint = "glBlendParameteriNV", ExactSpelling = true)]
			internal extern static void glBlendParameteriNV(Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
			internal extern static void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[DllImport(Library, EntryPoint = "glBlitFramebufferANGLE", ExactSpelling = true)]
			internal extern static void glBlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[DllImport(Library, EntryPoint = "glBlitFramebufferEXT", ExactSpelling = true)]
			internal extern static void glBlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[DllImport(Library, EntryPoint = "glBlitFramebufferNV", ExactSpelling = true)]
			internal extern static void glBlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[DllImport(Library, EntryPoint = "glBlitNamedFramebuffer", ExactSpelling = true)]
			internal extern static void glBlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[DllImport(Library, EntryPoint = "glBufferAddressRangeNV", ExactSpelling = true)]
			internal extern static void glBufferAddressRangeNV(Int32 pname, UInt32 index, UInt64 address, UInt32 length);

			[DllImport(Library, EntryPoint = "glBufferData", ExactSpelling = true)]
			internal extern static unsafe void glBufferData(Int32 target, UInt32 size, IntPtr data, Int32 usage);

			[DllImport(Library, EntryPoint = "glBufferDataARB", ExactSpelling = true)]
			internal extern static unsafe void glBufferDataARB(Int32 target, UInt32 size, IntPtr data, Int32 usage);

			[DllImport(Library, EntryPoint = "glBufferPageCommitmentARB", ExactSpelling = true)]
			internal extern static unsafe void glBufferPageCommitmentARB(Int32 target, IntPtr offset, UInt32 size, bool commit);

			[DllImport(Library, EntryPoint = "glBufferParameteriAPPLE", ExactSpelling = true)]
			internal extern static void glBufferParameteriAPPLE(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glBufferStorage", ExactSpelling = true)]
			internal extern static unsafe void glBufferStorage(Int32 target, UInt32 size, IntPtr data, UInt32 flags);

			[DllImport(Library, EntryPoint = "glBufferStorageEXT", ExactSpelling = true)]
			internal extern static unsafe void glBufferStorageEXT(Int32 target, UInt32 size, IntPtr data, UInt32 flags);

			[DllImport(Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glBufferSubData(Int32 target, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glBufferSubDataARB", ExactSpelling = true)]
			internal extern static unsafe void glBufferSubDataARB(Int32 target, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glCallCommandListNV", ExactSpelling = true)]
			internal extern static void glCallCommandListNV(UInt32 list);

			[DllImport(Library, EntryPoint = "glCallList", ExactSpelling = true)]
			internal extern static void glCallList(UInt32 list);

			[DllImport(Library, EntryPoint = "glCallLists", ExactSpelling = true)]
			internal extern static unsafe void glCallLists(Int32 n, Int32 type, IntPtr lists);

			[DllImport(Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
			internal extern static Int32 glCheckFramebufferStatus(Int32 target);

			[DllImport(Library, EntryPoint = "glCheckFramebufferStatusEXT", ExactSpelling = true)]
			internal extern static Int32 glCheckFramebufferStatusEXT(Int32 target);

			[DllImport(Library, EntryPoint = "glCheckFramebufferStatusOES", ExactSpelling = true)]
			internal extern static Int32 glCheckFramebufferStatusOES(Int32 target);

			[DllImport(Library, EntryPoint = "glCheckNamedFramebufferStatus", ExactSpelling = true)]
			internal extern static Int32 glCheckNamedFramebufferStatus(UInt32 framebuffer, Int32 target);

			[DllImport(Library, EntryPoint = "glCheckNamedFramebufferStatusEXT", ExactSpelling = true)]
			internal extern static Int32 glCheckNamedFramebufferStatusEXT(UInt32 framebuffer, Int32 target);

			[DllImport(Library, EntryPoint = "glClampColor", ExactSpelling = true)]
			internal extern static void glClampColor(Int32 target, Int32 clamp);

			[DllImport(Library, EntryPoint = "glClampColorARB", ExactSpelling = true)]
			internal extern static void glClampColorARB(Int32 target, Int32 clamp);

			[DllImport(Library, EntryPoint = "glClear", ExactSpelling = true)]
			internal extern static void glClear(UInt32 mask);

			[DllImport(Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
			internal extern static void glClearAccum(float red, float green, float blue, float alpha);

			[DllImport(Library, EntryPoint = "glClearAccumxOES", ExactSpelling = true)]
			internal extern static unsafe void glClearAccumxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[DllImport(Library, EntryPoint = "glClearBufferData", ExactSpelling = true)]
			internal extern static unsafe void glClearBufferData(Int32 target, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glClearBufferSubData(Int32 target, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearBufferfi", ExactSpelling = true)]
			internal extern static void glClearBufferfi(Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil);

			[DllImport(Library, EntryPoint = "glClearBufferfv", ExactSpelling = true)]
			internal extern static unsafe void glClearBufferfv(Int32 buffer, Int32 drawbuffer, float* value);

			[DllImport(Library, EntryPoint = "glClearBufferiv", ExactSpelling = true)]
			internal extern static unsafe void glClearBufferiv(Int32 buffer, Int32 drawbuffer, Int32* value);

			[DllImport(Library, EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
			internal extern static unsafe void glClearBufferuiv(Int32 buffer, Int32 drawbuffer, UInt32* value);

			[DllImport(Library, EntryPoint = "glClearColor", ExactSpelling = true)]
			internal extern static void glClearColor(float red, float green, float blue, float alpha);

			[DllImport(Library, EntryPoint = "glClearColorIiEXT", ExactSpelling = true)]
			internal extern static void glClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[DllImport(Library, EntryPoint = "glClearColorIuiEXT", ExactSpelling = true)]
			internal extern static void glClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[DllImport(Library, EntryPoint = "glClearColorx", ExactSpelling = true)]
			internal extern static unsafe void glClearColorx(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[DllImport(Library, EntryPoint = "glClearColorxOES", ExactSpelling = true)]
			internal extern static unsafe void glClearColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[DllImport(Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
			internal extern static void glClearDepth(double depth);

			[DllImport(Library, EntryPoint = "glClearDepthdNV", ExactSpelling = true)]
			internal extern static void glClearDepthdNV(double depth);

			[DllImport(Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
			internal extern static void glClearDepthf(float d);

			[DllImport(Library, EntryPoint = "glClearDepthfOES", ExactSpelling = true)]
			internal extern static void glClearDepthfOES(float depth);

			[DllImport(Library, EntryPoint = "glClearDepthx", ExactSpelling = true)]
			internal extern static unsafe void glClearDepthx(IntPtr depth);

			[DllImport(Library, EntryPoint = "glClearDepthxOES", ExactSpelling = true)]
			internal extern static unsafe void glClearDepthxOES(IntPtr depth);

			[DllImport(Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
			internal extern static void glClearIndex(float c);

			[DllImport(Library, EntryPoint = "glClearNamedBufferData", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferData(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearNamedBufferDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferDataEXT(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferSubData(UInt32 buffer, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearNamedBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferSubDataEXT(UInt32 buffer, Int32 internalformat, UInt32 offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearNamedFramebufferfi", ExactSpelling = true)]
			internal extern static void glClearNamedFramebufferfi(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil);

			[DllImport(Library, EntryPoint = "glClearNamedFramebufferfv", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedFramebufferfv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float* value);

			[DllImport(Library, EntryPoint = "glClearNamedFramebufferiv", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedFramebufferiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, Int32* value);

			[DllImport(Library, EntryPoint = "glClearNamedFramebufferuiv", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedFramebufferuiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, UInt32* value);

			[DllImport(Library, EntryPoint = "glClearPixelLocalStorageuiEXT", ExactSpelling = true)]
			internal extern static unsafe void glClearPixelLocalStorageuiEXT(Int32 offset, Int32 n, UInt32* values);

			[DllImport(Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
			internal extern static void glClearStencil(Int32 s);

			[DllImport(Library, EntryPoint = "glClearTexImage", ExactSpelling = true)]
			internal extern static unsafe void glClearTexImage(UInt32 texture, Int32 level, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClearTexSubImage", ExactSpelling = true)]
			internal extern static unsafe void glClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
			internal extern static void glClientActiveTexture(Int32 texture);

			[DllImport(Library, EntryPoint = "glClientActiveTextureARB", ExactSpelling = true)]
			internal extern static void glClientActiveTextureARB(Int32 texture);

			[DllImport(Library, EntryPoint = "glClientActiveVertexStreamATI", ExactSpelling = true)]
			internal extern static void glClientActiveVertexStreamATI(Int32 stream);

			[DllImport(Library, EntryPoint = "glClientAttribDefaultEXT", ExactSpelling = true)]
			internal extern static void glClientAttribDefaultEXT(UInt32 mask);

			[DllImport(Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
			internal extern static Int32 glClientWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "glClientWaitSyncAPPLE", ExactSpelling = true)]
			internal extern static Int32 glClientWaitSyncAPPLE(Int32 sync, UInt32 flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "glClipControl", ExactSpelling = true)]
			internal extern static void glClipControl(Int32 origin, Int32 depth);

			[DllImport(Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
			internal extern static unsafe void glClipPlane(Int32 plane, double* equation);

			[DllImport(Library, EntryPoint = "glClipPlanef", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanef(Int32 p, float* eqn);

			[DllImport(Library, EntryPoint = "glClipPlanefIMG", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanefIMG(Int32 p, float* eqn);

			[DllImport(Library, EntryPoint = "glClipPlanefOES", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanefOES(Int32 plane, float* equation);

			[DllImport(Library, EntryPoint = "glClipPlanex", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanex(Int32 plane, IntPtr* equation);

			[DllImport(Library, EntryPoint = "glClipPlanexIMG", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanexIMG(Int32 p, IntPtr* eqn);

			[DllImport(Library, EntryPoint = "glClipPlanexOES", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanexOES(Int32 plane, IntPtr* equation);

			[DllImport(Library, EntryPoint = "glColor3b", ExactSpelling = true)]
			internal extern static void glColor3b(sbyte red, sbyte green, sbyte blue);

			[DllImport(Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
			internal extern static unsafe void glColor3bv(sbyte* v);

			[DllImport(Library, EntryPoint = "glColor3d", ExactSpelling = true)]
			internal extern static void glColor3d(double red, double green, double blue);

			[DllImport(Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
			internal extern static unsafe void glColor3dv(double* v);

			[DllImport(Library, EntryPoint = "glColor3f", ExactSpelling = true)]
			internal extern static void glColor3f(float red, float green, float blue);

			[DllImport(Library, EntryPoint = "glColor3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glColor3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor3fVertex3fvSUN(float* c, float* v);

			[DllImport(Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
			internal extern static unsafe void glColor3fv(float* v);

			[DllImport(Library, EntryPoint = "glColor3hNV", ExactSpelling = true)]
			internal extern static void glColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[DllImport(Library, EntryPoint = "glColor3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glColor3hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glColor3i", ExactSpelling = true)]
			internal extern static void glColor3i(Int32 red, Int32 green, Int32 blue);

			[DllImport(Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
			internal extern static unsafe void glColor3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glColor3s", ExactSpelling = true)]
			internal extern static void glColor3s(Int16 red, Int16 green, Int16 blue);

			[DllImport(Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
			internal extern static unsafe void glColor3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
			internal extern static void glColor3ub(byte red, byte green, byte blue);

			[DllImport(Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
			internal extern static unsafe void glColor3ubv(byte* v);

			[DllImport(Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
			internal extern static void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[DllImport(Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
			internal extern static unsafe void glColor3uiv(UInt32* v);

			[DllImport(Library, EntryPoint = "glColor3us", ExactSpelling = true)]
			internal extern static void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[DllImport(Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
			internal extern static unsafe void glColor3usv(UInt16* v);

			[DllImport(Library, EntryPoint = "glColor3xOES", ExactSpelling = true)]
			internal extern static unsafe void glColor3xOES(IntPtr red, IntPtr green, IntPtr blue);

			[DllImport(Library, EntryPoint = "glColor3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glColor3xvOES(IntPtr* components);

			[DllImport(Library, EntryPoint = "glColor4b", ExactSpelling = true)]
			internal extern static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

			[DllImport(Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
			internal extern static unsafe void glColor4bv(sbyte* v);

			[DllImport(Library, EntryPoint = "glColor4d", ExactSpelling = true)]
			internal extern static void glColor4d(double red, double green, double blue, double alpha);

			[DllImport(Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
			internal extern static unsafe void glColor4dv(double* v);

			[DllImport(Library, EntryPoint = "glColor4f", ExactSpelling = true)]
			internal extern static void glColor4f(float red, float green, float blue, float alpha);

			[DllImport(Library, EntryPoint = "glColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v);

			[DllImport(Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
			internal extern static unsafe void glColor4fv(float* v);

			[DllImport(Library, EntryPoint = "glColor4hNV", ExactSpelling = true)]
			internal extern static void glColor4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[DllImport(Library, EntryPoint = "glColor4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glColor4hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glColor4i", ExactSpelling = true)]
			internal extern static void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[DllImport(Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
			internal extern static unsafe void glColor4iv(Int32* v);

			[DllImport(Library, EntryPoint = "glColor4s", ExactSpelling = true)]
			internal extern static void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

			[DllImport(Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
			internal extern static unsafe void glColor4sv(Int16* v);

			[DllImport(Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
			internal extern static void glColor4ub(byte red, byte green, byte blue, byte alpha);

			[DllImport(Library, EntryPoint = "glColor4ubVertex2fSUN", ExactSpelling = true)]
			internal extern static void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);

			[DllImport(Library, EntryPoint = "glColor4ubVertex2fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubVertex2fvSUN(byte* c, float* v);

			[DllImport(Library, EntryPoint = "glColor4ubVertex3fSUN", ExactSpelling = true)]
			internal extern static void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glColor4ubVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubVertex3fvSUN(byte* c, float* v);

			[DllImport(Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubv(byte* v);

			[DllImport(Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
			internal extern static void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[DllImport(Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
			internal extern static unsafe void glColor4uiv(UInt32* v);

			[DllImport(Library, EntryPoint = "glColor4us", ExactSpelling = true)]
			internal extern static void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[DllImport(Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
			internal extern static unsafe void glColor4usv(UInt16* v);

			[DllImport(Library, EntryPoint = "glColor4x", ExactSpelling = true)]
			internal extern static unsafe void glColor4x(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[DllImport(Library, EntryPoint = "glColor4xOES", ExactSpelling = true)]
			internal extern static unsafe void glColor4xOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[DllImport(Library, EntryPoint = "glColor4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glColor4xvOES(IntPtr* components);

			[DllImport(Library, EntryPoint = "glColorFormatNV", ExactSpelling = true)]
			internal extern static void glColorFormatNV(Int32 size, Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glColorFragmentOp1ATI", ExactSpelling = true)]
			internal extern static void glColorFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[DllImport(Library, EntryPoint = "glColorFragmentOp2ATI", ExactSpelling = true)]
			internal extern static void glColorFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[DllImport(Library, EntryPoint = "glColorFragmentOp3ATI", ExactSpelling = true)]
			internal extern static void glColorFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[DllImport(Library, EntryPoint = "glColorMask", ExactSpelling = true)]
			internal extern static void glColorMask(bool red, bool green, bool blue, bool alpha);

			[DllImport(Library, EntryPoint = "glColorMaskIndexedEXT", ExactSpelling = true)]
			internal extern static void glColorMaskIndexedEXT(UInt32 index, bool r, bool g, bool b, bool a);

			[DllImport(Library, EntryPoint = "glColorMaski", ExactSpelling = true)]
			internal extern static void glColorMaski(UInt32 index, bool r, bool g, bool b, bool a);

			[DllImport(Library, EntryPoint = "glColorMaskiEXT", ExactSpelling = true)]
			internal extern static void glColorMaskiEXT(UInt32 index, bool r, bool g, bool b, bool a);

			[DllImport(Library, EntryPoint = "glColorMaskiOES", ExactSpelling = true)]
			internal extern static void glColorMaskiOES(UInt32 index, bool r, bool g, bool b, bool a);

			[DllImport(Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
			internal extern static void glColorMaterial(Int32 face, Int32 mode);

			[DllImport(Library, EntryPoint = "glColorP3ui", ExactSpelling = true)]
			internal extern static void glColorP3ui(Int32 type, UInt32 color);

			[DllImport(Library, EntryPoint = "glColorP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glColorP3uiv(Int32 type, UInt32* color);

			[DllImport(Library, EntryPoint = "glColorP4ui", ExactSpelling = true)]
			internal extern static void glColorP4ui(Int32 type, UInt32 color);

			[DllImport(Library, EntryPoint = "glColorP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glColorP4uiv(Int32 type, UInt32* color);

			[DllImport(Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
			internal extern static unsafe void glColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glColorPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glColorPointerEXT(Int32 size, Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glColorPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glColorPointervINTEL", ExactSpelling = true)]
			internal extern static unsafe void glColorPointervINTEL(Int32 size, Int32 type, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glColorSubTable", ExactSpelling = true)]
			internal extern static unsafe void glColorSubTable(Int32 target, Int32 start, Int32 count, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glColorSubTableEXT", ExactSpelling = true)]
			internal extern static unsafe void glColorSubTableEXT(Int32 target, Int32 start, Int32 count, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glColorTable", ExactSpelling = true)]
			internal extern static unsafe void glColorTable(Int32 target, Int32 internalformat, Int32 width, Int32 format, Int32 type, IntPtr table);

			[DllImport(Library, EntryPoint = "glColorTableEXT", ExactSpelling = true)]
			internal extern static unsafe void glColorTableEXT(Int32 target, Int32 internalFormat, Int32 width, Int32 format, Int32 type, IntPtr table);

			[DllImport(Library, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glColorTableParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glColorTableParameterfvSGI", ExactSpelling = true)]
			internal extern static unsafe void glColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glColorTableParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glColorTableParameterivSGI", ExactSpelling = true)]
			internal extern static unsafe void glColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glColorTableSGI", ExactSpelling = true)]
			internal extern static unsafe void glColorTableSGI(Int32 target, Int32 internalformat, Int32 width, Int32 format, Int32 type, IntPtr table);

			[DllImport(Library, EntryPoint = "glCombinerInputNV", ExactSpelling = true)]
			internal extern static void glCombinerInputNV(Int32 stage, Int32 portion, Int32 variable, Int32 input, Int32 mapping, Int32 componentUsage);

			[DllImport(Library, EntryPoint = "glCombinerOutputNV", ExactSpelling = true)]
			internal extern static void glCombinerOutputNV(Int32 stage, Int32 portion, Int32 abOutput, Int32 cdOutput, Int32 sumOutput, Int32 scale, Int32 bias, bool abDotProduct, bool cdDotProduct, bool muxSum);

			[DllImport(Library, EntryPoint = "glCombinerParameterfNV", ExactSpelling = true)]
			internal extern static void glCombinerParameterfNV(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glCombinerParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glCombinerParameterfvNV(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glCombinerParameteriNV", ExactSpelling = true)]
			internal extern static void glCombinerParameteriNV(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glCombinerParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glCombinerParameterivNV(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glCombinerStageParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glCombinerStageParameterfvNV(Int32 stage, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glCommandListSegmentsNV", ExactSpelling = true)]
			internal extern static void glCommandListSegmentsNV(UInt32 list, UInt32 segments);

			[DllImport(Library, EntryPoint = "glCompileCommandListNV", ExactSpelling = true)]
			internal extern static void glCompileCommandListNV(UInt32 list);

			[DllImport(Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
			internal extern static void glCompileShader(UInt32 shader);

			[DllImport(Library, EntryPoint = "glCompileShaderARB", ExactSpelling = true)]
			internal extern static void glCompileShaderARB(UInt32 shaderObj);

			[DllImport(Library, EntryPoint = "glCompileShaderIncludeARB", ExactSpelling = true)]
			internal extern static unsafe void glCompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);

			[DllImport(Library, EntryPoint = "glCompressedMultiTexImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedMultiTexImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedMultiTexImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedMultiTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedMultiTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedMultiTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexImage1DARB", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage1DARB(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexImage2DARB", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage2DARB(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage3D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexImage3DARB", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage3DARB(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexImage3DOES", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexImage3DOES(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage1DARB", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage1DARB(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage2DARB", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage2DARB(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage3D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage3DARB", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage3DARB(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTexSubImage3DOES", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTexSubImage3DOES(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTextureImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedTextureImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedTextureImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage3D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[DllImport(Library, EntryPoint = "glConservativeRasterParameterfNV", ExactSpelling = true)]
			internal extern static void glConservativeRasterParameterfNV(Int32 pname, float value);

			[DllImport(Library, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 width, Int32 format, Int32 type, IntPtr image);

			[DllImport(Library, EntryPoint = "glConvolutionFilter1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionFilter1DEXT(Int32 target, Int32 internalformat, Int32 width, Int32 format, Int32 type, IntPtr image);

			[DllImport(Library, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr image);

			[DllImport(Library, EntryPoint = "glConvolutionFilter2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionFilter2DEXT(Int32 target, Int32 internalformat, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr image);

			[DllImport(Library, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
			internal extern static void glConvolutionParameterf(Int32 target, Int32 pname, float @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameterfEXT", ExactSpelling = true)]
			internal extern static void glConvolutionParameterfEXT(Int32 target, Int32 pname, float @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
			internal extern static void glConvolutionParameteri(Int32 target, Int32 pname, Int32 @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameteriEXT", ExactSpelling = true)]
			internal extern static void glConvolutionParameteriEXT(Int32 target, Int32 pname, Int32 @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glConvolutionParameterxOES", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterxOES(Int32 target, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glConvolutionParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glCopyBufferSubData(Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[DllImport(Library, EntryPoint = "glCopyBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glCopyBufferSubDataNV(Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[DllImport(Library, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
			internal extern static void glCopyColorSubTable(Int32 target, Int32 start, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyColorSubTableEXT", ExactSpelling = true)]
			internal extern static void glCopyColorSubTableEXT(Int32 target, Int32 start, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
			internal extern static void glCopyColorTable(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyColorTableSGI", ExactSpelling = true)]
			internal extern static void glCopyColorTableSGI(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
			internal extern static void glCopyConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyConvolutionFilter1DEXT", ExactSpelling = true)]
			internal extern static void glCopyConvolutionFilter1DEXT(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
			internal extern static void glCopyConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyConvolutionFilter2DEXT", ExactSpelling = true)]
			internal extern static void glCopyConvolutionFilter2DEXT(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyImageSubData", ExactSpelling = true)]
			internal extern static void glCopyImageSubData(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

			[DllImport(Library, EntryPoint = "glCopyImageSubDataEXT", ExactSpelling = true)]
			internal extern static void glCopyImageSubDataEXT(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

			[DllImport(Library, EntryPoint = "glCopyImageSubDataNV", ExactSpelling = true)]
			internal extern static void glCopyImageSubDataNV(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[DllImport(Library, EntryPoint = "glCopyImageSubDataOES", ExactSpelling = true)]
			internal extern static void glCopyImageSubDataOES(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

			[DllImport(Library, EntryPoint = "glCopyMultiTexImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyMultiTexImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyMultiTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyMultiTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyMultiTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glCopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[DllImport(Library, EntryPoint = "glCopyPathNV", ExactSpelling = true)]
			internal extern static void glCopyPathNV(UInt32 resultPath, UInt32 srcPath);

			[DllImport(Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
			internal extern static void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 type);

			[DllImport(Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
			internal extern static void glCopyTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyTexImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyTexImage1DEXT(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
			internal extern static void glCopyTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyTexImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyTexImage2DEXT(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage1DEXT(Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage2DEXT(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage3D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage3DEXT(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTexSubImage3DOES", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage3DOES(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTextureImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyTextureImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[DllImport(Library, EntryPoint = "glCopyTextureLevelsAPPLE", ExactSpelling = true)]
			internal extern static void glCopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);

			[DllImport(Library, EntryPoint = "glCopyTextureSubImage1D", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyTextureSubImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[DllImport(Library, EntryPoint = "glCopyTextureSubImage2D", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTextureSubImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTextureSubImage3D", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCopyTextureSubImage3DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glCoverFillPathInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glCoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glCoverFillPathNV", ExactSpelling = true)]
			internal extern static void glCoverFillPathNV(UInt32 path, Int32 coverMode);

			[DllImport(Library, EntryPoint = "glCoverStrokePathInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glCoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glCoverStrokePathNV", ExactSpelling = true)]
			internal extern static void glCoverStrokePathNV(UInt32 path, Int32 coverMode);

			[DllImport(Library, EntryPoint = "glCoverageMaskNV", ExactSpelling = true)]
			internal extern static void glCoverageMaskNV(bool mask);

			[DllImport(Library, EntryPoint = "glCoverageModulationNV", ExactSpelling = true)]
			internal extern static void glCoverageModulationNV(Int32 components);

			[DllImport(Library, EntryPoint = "glCoverageModulationTableNV", ExactSpelling = true)]
			internal extern static unsafe void glCoverageModulationTableNV(Int32 n, float* v);

			[DllImport(Library, EntryPoint = "glCoverageOperationNV", ExactSpelling = true)]
			internal extern static void glCoverageOperationNV(Int32 operation);

			[DllImport(Library, EntryPoint = "glCreateBuffers", ExactSpelling = true)]
			internal extern static unsafe void glCreateBuffers(Int32 n, UInt32* buffers);

			[DllImport(Library, EntryPoint = "glCreateCommandListsNV", ExactSpelling = true)]
			internal extern static unsafe void glCreateCommandListsNV(Int32 n, UInt32* lists);

			[DllImport(Library, EntryPoint = "glCreateFramebuffers", ExactSpelling = true)]
			internal extern static unsafe void glCreateFramebuffers(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glCreatePerfQueryINTEL", ExactSpelling = true)]
			internal extern static unsafe void glCreatePerfQueryINTEL(UInt32 queryId, UInt32* queryHandle);

			[DllImport(Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
			internal extern static UInt32 glCreateProgram();

			[DllImport(Library, EntryPoint = "glCreateProgramObjectARB", ExactSpelling = true)]
			internal extern static UInt32 glCreateProgramObjectARB();

			[DllImport(Library, EntryPoint = "glCreateProgramPipelines", ExactSpelling = true)]
			internal extern static unsafe void glCreateProgramPipelines(Int32 n, UInt32* pipelines);

			[DllImport(Library, EntryPoint = "glCreateQueries", ExactSpelling = true)]
			internal extern static unsafe void glCreateQueries(Int32 target, Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glCreateRenderbuffers", ExactSpelling = true)]
			internal extern static unsafe void glCreateRenderbuffers(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glCreateSamplers", ExactSpelling = true)]
			internal extern static unsafe void glCreateSamplers(Int32 n, UInt32* samplers);

			[DllImport(Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
			internal extern static UInt32 glCreateShader(Int32 shaderType);

			[DllImport(Library, EntryPoint = "glCreateShaderObjectARB", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderObjectARB(Int32 shaderType);

			[DllImport(Library, EntryPoint = "glCreateShaderProgramEXT", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderProgramEXT(Int32 type, String @string);

			[DllImport(Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderProgramv(Int32 type, Int32 count, String[] strings);

			[DllImport(Library, EntryPoint = "glCreateShaderProgramvEXT", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderProgramvEXT(Int32 type, Int32 count, String[] strings);

			[DllImport(Library, EntryPoint = "glCreateStatesNV", ExactSpelling = true)]
			internal extern static unsafe void glCreateStatesNV(Int32 n, UInt32* states);

			[DllImport(Library, EntryPoint = "glCreateSyncFromCLeventARB", ExactSpelling = true)]
			internal extern static unsafe Int32 glCreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags);

			[DllImport(Library, EntryPoint = "glCreateTextures", ExactSpelling = true)]
			internal extern static unsafe void glCreateTextures(Int32 target, Int32 n, UInt32* textures);

			[DllImport(Library, EntryPoint = "glCreateTransformFeedbacks", ExactSpelling = true)]
			internal extern static unsafe void glCreateTransformFeedbacks(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glCreateVertexArrays", ExactSpelling = true)]
			internal extern static unsafe void glCreateVertexArrays(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glCullFace", ExactSpelling = true)]
			internal extern static void glCullFace(Int32 mode);

			[DllImport(Library, EntryPoint = "glCullParameterdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glCullParameterdvEXT(Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glCullParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glCullParameterfvEXT(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glCurrentPaletteMatrixARB", ExactSpelling = true)]
			internal extern static void glCurrentPaletteMatrixARB(Int32 index);

			[DllImport(Library, EntryPoint = "glCurrentPaletteMatrixOES", ExactSpelling = true)]
			internal extern static void glCurrentPaletteMatrixOES(UInt32 matrixpaletteindex);

			[DllImport(Library, EntryPoint = "glDebugMessageCallback", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageCallback(Gl.DebugProc callback, IntPtr userParam);

			[DllImport(Library, EntryPoint = "glDebugMessageCallbackAMD", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageCallbackAMD(Gl.DebugProc callback, IntPtr userParam);

			[DllImport(Library, EntryPoint = "glDebugMessageCallbackARB", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageCallbackARB(Gl.DebugProc callback, IntPtr userParam);

			[DllImport(Library, EntryPoint = "glDebugMessageCallbackKHR", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageCallbackKHR(Gl.DebugProc callback, IntPtr userParam);

			[DllImport(Library, EntryPoint = "glDebugMessageControl", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageControl(Int32 source, Int32 type, Int32 severity, Int32 count, UInt32* ids, bool enabled);

			[DllImport(Library, EntryPoint = "glDebugMessageControlARB", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageControlARB(Int32 source, Int32 type, Int32 severity, Int32 count, UInt32* ids, bool enabled);

			[DllImport(Library, EntryPoint = "glDebugMessageControlKHR", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageControlKHR(Int32 source, Int32 type, Int32 severity, Int32 count, UInt32* ids, bool enabled);

			[DllImport(Library, EntryPoint = "glDebugMessageEnableAMD", ExactSpelling = true)]
			internal extern static unsafe void glDebugMessageEnableAMD(Int32 category, Int32 severity, Int32 count, UInt32* ids, bool enabled);

			[DllImport(Library, EntryPoint = "glDebugMessageInsert", ExactSpelling = true)]
			internal extern static void glDebugMessageInsert(Int32 source, Int32 type, UInt32 id, Int32 severity, Int32 length, String buf);

			[DllImport(Library, EntryPoint = "glDebugMessageInsertAMD", ExactSpelling = true)]
			internal extern static void glDebugMessageInsertAMD(Int32 category, Int32 severity, UInt32 id, Int32 length, String buf);

			[DllImport(Library, EntryPoint = "glDebugMessageInsertARB", ExactSpelling = true)]
			internal extern static void glDebugMessageInsertARB(Int32 source, Int32 type, UInt32 id, Int32 severity, Int32 length, String buf);

			[DllImport(Library, EntryPoint = "glDebugMessageInsertKHR", ExactSpelling = true)]
			internal extern static void glDebugMessageInsertKHR(Int32 source, Int32 type, UInt32 id, Int32 severity, Int32 length, String buf);

			[DllImport(Library, EntryPoint = "glDeformSGIX", ExactSpelling = true)]
			internal extern static void glDeformSGIX(UInt32 mask);

			[DllImport(Library, EntryPoint = "glDeformationMap3dSGIX", ExactSpelling = true)]
			internal extern static unsafe void glDeformationMap3dSGIX(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double w1, double w2, Int32 wstride, Int32 worder, double* points);

			[DllImport(Library, EntryPoint = "glDeformationMap3fSGIX", ExactSpelling = true)]
			internal extern static unsafe void glDeformationMap3fSGIX(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float w1, float w2, Int32 wstride, Int32 worder, float* points);

			[DllImport(Library, EntryPoint = "glDeleteAsyncMarkersSGIX", ExactSpelling = true)]
			internal extern static void glDeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);

			[DllImport(Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
			internal extern static unsafe void glDeleteBuffers(Int32 n, UInt32* buffers);

			[DllImport(Library, EntryPoint = "glDeleteBuffersARB", ExactSpelling = true)]
			internal extern static unsafe void glDeleteBuffersARB(Int32 n, UInt32* buffers);

			[DllImport(Library, EntryPoint = "glDeleteCommandListsNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteCommandListsNV(Int32 n, UInt32* lists);

			[DllImport(Library, EntryPoint = "glDeleteFencesAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFencesAPPLE(Int32 n, UInt32* fences);

			[DllImport(Library, EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFencesNV(Int32 n, UInt32* fences);

			[DllImport(Library, EntryPoint = "glDeleteFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glDeleteFragmentShaderATI(UInt32 id);

			[DllImport(Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFramebuffers(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glDeleteFramebuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glDeleteFramebuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFramebuffersOES(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
			internal extern static void glDeleteLists(UInt32 list, Int32 range);

			[DllImport(Library, EntryPoint = "glDeleteNamedStringARB", ExactSpelling = true)]
			internal extern static void glDeleteNamedStringARB(Int32 namelen, String name);

			[DllImport(Library, EntryPoint = "glDeleteNamesAMD", ExactSpelling = true)]
			internal extern static unsafe void glDeleteNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			[DllImport(Library, EntryPoint = "glDeleteObjectARB", ExactSpelling = true)]
			internal extern static void glDeleteObjectARB(UInt32 obj);

			[DllImport(Library, EntryPoint = "glDeleteOcclusionQueriesNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteOcclusionQueriesNV(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glDeletePathsNV", ExactSpelling = true)]
			internal extern static void glDeletePathsNV(UInt32 path, Int32 range);

			[DllImport(Library, EntryPoint = "glDeletePerfMonitorsAMD", ExactSpelling = true)]
			internal extern static unsafe void glDeletePerfMonitorsAMD(Int32 n, UInt32* monitors);

			[DllImport(Library, EntryPoint = "glDeletePerfQueryINTEL", ExactSpelling = true)]
			internal extern static void glDeletePerfQueryINTEL(UInt32 queryHandle);

			[DllImport(Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
			internal extern static void glDeleteProgram(UInt32 program);

			[DllImport(Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramPipelines(Int32 n, UInt32* pipelines);

			[DllImport(Library, EntryPoint = "glDeleteProgramPipelinesEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[DllImport(Library, EntryPoint = "glDeleteProgramsARB", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramsARB(Int32 n, UInt32* programs);

			[DllImport(Library, EntryPoint = "glDeleteProgramsNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramsNV(Int32 n, UInt32* programs);

			[DllImport(Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
			internal extern static unsafe void glDeleteQueries(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glDeleteQueriesARB", ExactSpelling = true)]
			internal extern static unsafe void glDeleteQueriesARB(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glDeleteQueriesEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteQueriesEXT(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
			internal extern static unsafe void glDeleteRenderbuffers(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glDeleteRenderbuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glDeleteRenderbuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glDeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
			internal extern static unsafe void glDeleteSamplers(Int32 count, UInt32* samplers);

			[DllImport(Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
			internal extern static void glDeleteShader(UInt32 shader);

			[DllImport(Library, EntryPoint = "glDeleteStatesNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteStatesNV(Int32 n, UInt32* states);

			[DllImport(Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
			internal extern static void glDeleteSync(Int32 sync);

			[DllImport(Library, EntryPoint = "glDeleteSyncAPPLE", ExactSpelling = true)]
			internal extern static void glDeleteSyncAPPLE(Int32 sync);

			[DllImport(Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
			internal extern static unsafe void glDeleteTextures(Int32 n, UInt32* textures);

			[DllImport(Library, EntryPoint = "glDeleteTexturesEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteTexturesEXT(Int32 n, UInt32* textures);

			[DllImport(Library, EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
			internal extern static unsafe void glDeleteTransformFeedbacks(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glDeleteTransformFeedbacksNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteTransformFeedbacksNV(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
			internal extern static unsafe void glDeleteVertexArrays(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glDeleteVertexArraysAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glDeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glDeleteVertexArraysOES", ExactSpelling = true)]
			internal extern static unsafe void glDeleteVertexArraysOES(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glDeleteVertexShaderEXT", ExactSpelling = true)]
			internal extern static void glDeleteVertexShaderEXT(UInt32 id);

			[DllImport(Library, EntryPoint = "glDepthBoundsEXT", ExactSpelling = true)]
			internal extern static void glDepthBoundsEXT(double zmin, double zmax);

			[DllImport(Library, EntryPoint = "glDepthBoundsdNV", ExactSpelling = true)]
			internal extern static void glDepthBoundsdNV(double zmin, double zmax);

			[DllImport(Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
			internal extern static void glDepthFunc(Int32 func);

			[DllImport(Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
			internal extern static void glDepthMask(bool flag);

			[DllImport(Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
			internal extern static void glDepthRange(double near, double far);

			[DllImport(Library, EntryPoint = "glDepthRangeArrayfvNV", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangeArrayfvNV(UInt32 first, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangeArrayv(UInt32 first, Int32 count, double* v);

			[DllImport(Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
			internal extern static void glDepthRangeIndexed(UInt32 index, double n, double f);

			[DllImport(Library, EntryPoint = "glDepthRangeIndexedfNV", ExactSpelling = true)]
			internal extern static void glDepthRangeIndexedfNV(UInt32 index, float n, float f);

			[DllImport(Library, EntryPoint = "glDepthRangedNV", ExactSpelling = true)]
			internal extern static void glDepthRangedNV(double zNear, double zFar);

			[DllImport(Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
			internal extern static void glDepthRangef(float n, float f);

			[DllImport(Library, EntryPoint = "glDepthRangefOES", ExactSpelling = true)]
			internal extern static void glDepthRangefOES(float n, float f);

			[DllImport(Library, EntryPoint = "glDepthRangex", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangex(IntPtr n, IntPtr f);

			[DllImport(Library, EntryPoint = "glDepthRangexOES", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangexOES(IntPtr n, IntPtr f);

			[DllImport(Library, EntryPoint = "glDetachObjectARB", ExactSpelling = true)]
			internal extern static void glDetachObjectARB(UInt32 containerObj, UInt32 attachedObj);

			[DllImport(Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
			internal extern static void glDetachShader(UInt32 program, UInt32 shader);

			[DllImport(Library, EntryPoint = "glDetailTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glDetailTexFuncSGIS(Int32 target, Int32 n, float* points);

			[DllImport(Library, EntryPoint = "glDisable", ExactSpelling = true)]
			internal extern static void glDisable(Int32 cap);

			[DllImport(Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
			internal extern static void glDisableClientState(Int32 array);

			[DllImport(Library, EntryPoint = "glDisableClientStateIndexedEXT", ExactSpelling = true)]
			internal extern static void glDisableClientStateIndexedEXT(Int32 array, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableClientStateiEXT", ExactSpelling = true)]
			internal extern static void glDisableClientStateiEXT(Int32 array, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableDriverControlQCOM", ExactSpelling = true)]
			internal extern static void glDisableDriverControlQCOM(UInt32 driverControl);

			[DllImport(Library, EntryPoint = "glDisableIndexedEXT", ExactSpelling = true)]
			internal extern static void glDisableIndexedEXT(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableVariantClientStateEXT", ExactSpelling = true)]
			internal extern static void glDisableVariantClientStateEXT(UInt32 id);

			[DllImport(Library, EntryPoint = "glDisableVertexArrayAttrib", ExactSpelling = true)]
			internal extern static void glDisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableVertexArrayAttribEXT", ExactSpelling = true)]
			internal extern static void glDisableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableVertexArrayEXT", ExactSpelling = true)]
			internal extern static void glDisableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[DllImport(Library, EntryPoint = "glDisableVertexAttribAPPLE", ExactSpelling = true)]
			internal extern static void glDisableVertexAttribAPPLE(UInt32 index, Int32 pname);

			[DllImport(Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
			internal extern static void glDisableVertexAttribArray(UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableVertexAttribArrayARB", ExactSpelling = true)]
			internal extern static void glDisableVertexAttribArrayARB(UInt32 index);

			[DllImport(Library, EntryPoint = "glDisablei", ExactSpelling = true)]
			internal extern static void glDisablei(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableiEXT", ExactSpelling = true)]
			internal extern static void glDisableiEXT(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableiNV", ExactSpelling = true)]
			internal extern static void glDisableiNV(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glDisableiOES", ExactSpelling = true)]
			internal extern static void glDisableiOES(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glDiscardFramebufferEXT", ExactSpelling = true)]
			internal extern static unsafe void glDiscardFramebufferEXT(Int32 target, Int32 numAttachments, Int32* attachments);

			[DllImport(Library, EntryPoint = "glDispatchCompute", ExactSpelling = true)]
			internal extern static void glDispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);

			[DllImport(Library, EntryPoint = "glDispatchComputeGroupSizeARB", ExactSpelling = true)]
			internal extern static void glDispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);

			[DllImport(Library, EntryPoint = "glDispatchComputeIndirect", ExactSpelling = true)]
			internal extern static unsafe void glDispatchComputeIndirect(IntPtr indirect);

			[DllImport(Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
			internal extern static void glDrawArrays(Int32 mode, Int32 first, Int32 count);

			[DllImport(Library, EntryPoint = "glDrawArraysEXT", ExactSpelling = true)]
			internal extern static void glDrawArraysEXT(Int32 mode, Int32 first, Int32 count);

			[DllImport(Library, EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
			internal extern static unsafe void glDrawArraysIndirect(Int32 mode, IntPtr indirect);

			[DllImport(Library, EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
			internal extern static void glDrawArraysInstanced(Int32 mode, Int32 first, Int32 count, Int32 instancecount);

			[DllImport(Library, EntryPoint = "glDrawArraysInstancedANGLE", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedANGLE(Int32 mode, Int32 first, Int32 count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawArraysInstancedARB", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedARB(Int32 mode, Int32 first, Int32 count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawArraysInstancedBaseInstance", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedBaseInstance(Int32 mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);

			[DllImport(Library, EntryPoint = "glDrawArraysInstancedBaseInstanceEXT", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedBaseInstanceEXT(Int32 mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);

			[DllImport(Library, EntryPoint = "glDrawArraysInstancedEXT", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedEXT(Int32 mode, Int32 start, Int32 count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawArraysInstancedNV", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedNV(Int32 mode, Int32 first, Int32 count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
			internal extern static void glDrawBuffer(Int32 buf);

			[DllImport(Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffers(Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glDrawBuffersARB", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffersARB(Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glDrawBuffersATI", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffersATI(Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glDrawBuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffersEXT(Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glDrawBuffersIndexedEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffersIndexedEXT(Int32 n, Int32* location, Int32* indices);

			[DllImport(Library, EntryPoint = "glDrawBuffersNV", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffersNV(Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glDrawCommandsAddressNV", ExactSpelling = true)]
			internal extern static unsafe void glDrawCommandsAddressNV(Int32 primitiveMode, UInt64* indirects, Int32* sizes, UInt32 count);

			[DllImport(Library, EntryPoint = "glDrawCommandsNV", ExactSpelling = true)]
			internal extern static unsafe void glDrawCommandsNV(Int32 primitiveMode, UInt32 buffer, IntPtr* indirects, Int32* sizes, UInt32 count);

			[DllImport(Library, EntryPoint = "glDrawCommandsStatesAddressNV", ExactSpelling = true)]
			internal extern static unsafe void glDrawCommandsStatesAddressNV(UInt64* indirects, Int32* sizes, UInt32* states, UInt32* fbos, UInt32 count);

			[DllImport(Library, EntryPoint = "glDrawCommandsStatesNV", ExactSpelling = true)]
			internal extern static unsafe void glDrawCommandsStatesNV(UInt32 buffer, IntPtr* indirects, Int32* sizes, UInt32* states, UInt32* fbos, UInt32 count);

			[DllImport(Library, EntryPoint = "glDrawElementArrayAPPLE", ExactSpelling = true)]
			internal extern static void glDrawElementArrayAPPLE(Int32 mode, Int32 first, Int32 count);

			[DllImport(Library, EntryPoint = "glDrawElementArrayATI", ExactSpelling = true)]
			internal extern static void glDrawElementArrayATI(Int32 mode, Int32 count);

			[DllImport(Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
			internal extern static unsafe void glDrawElements(Int32 mode, Int32 count, Int32 type, IntPtr indices);

			[DllImport(Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawElementsBaseVertexEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsBaseVertexEXT(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawElementsBaseVertexOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsBaseVertexOES(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsIndirect(Int32 mode, Int32 type, IntPtr indirect);

			[DllImport(Library, EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstanced(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedANGLE", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedANGLE(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedARB", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedARB(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseInstance", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseInstanceEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseInstanceEXT(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertexBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertexBaseInstanceEXT(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertexEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertexEXT(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertexOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertexOES(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedEXT(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawElementsInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedNV(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount);

			[DllImport(Library, EntryPoint = "glDrawMeshArraysSUN", ExactSpelling = true)]
			internal extern static void glDrawMeshArraysSUN(Int32 mode, Int32 first, Int32 count, Int32 width);

			[DllImport(Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
			internal extern static unsafe void glDrawPixels(Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glDrawRangeElementArrayAPPLE", ExactSpelling = true)]
			internal extern static void glDrawRangeElementArrayAPPLE(Int32 mode, UInt32 start, UInt32 end, Int32 first, Int32 count);

			[DllImport(Library, EntryPoint = "glDrawRangeElementArrayATI", ExactSpelling = true)]
			internal extern static void glDrawRangeElementArrayATI(Int32 mode, UInt32 start, UInt32 end, Int32 count);

			[DllImport(Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
			internal extern static unsafe void glDrawRangeElements(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices);

			[DllImport(Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glDrawRangeElementsBaseVertex(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawRangeElementsBaseVertexEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawRangeElementsBaseVertexEXT(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawRangeElementsBaseVertexOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawRangeElementsBaseVertexOES(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[DllImport(Library, EntryPoint = "glDrawRangeElementsEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawRangeElementsEXT(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices);

			[DllImport(Library, EntryPoint = "glDrawTexfOES", ExactSpelling = true)]
			internal extern static void glDrawTexfOES(float x, float y, float z, float width, float height);

			[DllImport(Library, EntryPoint = "glDrawTexfvOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexfvOES(float* coords);

			[DllImport(Library, EntryPoint = "glDrawTexiOES", ExactSpelling = true)]
			internal extern static void glDrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glDrawTexivOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexivOES(Int32* coords);

			[DllImport(Library, EntryPoint = "glDrawTexsOES", ExactSpelling = true)]
			internal extern static void glDrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);

			[DllImport(Library, EntryPoint = "glDrawTexsvOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexsvOES(Int16* coords);

			[DllImport(Library, EntryPoint = "glDrawTextureNV", ExactSpelling = true)]
			internal extern static void glDrawTextureNV(UInt32 texture, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

			[DllImport(Library, EntryPoint = "glDrawTexxOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexxOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height);

			[DllImport(Library, EntryPoint = "glDrawTexxvOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexxvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedback(Int32 mode, UInt32 id);

			[DllImport(Library, EntryPoint = "glDrawTransformFeedbackInstanced", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedbackInstanced(Int32 mode, UInt32 id, Int32 instancecount);

			[DllImport(Library, EntryPoint = "glDrawTransformFeedbackNV", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedbackNV(Int32 mode, UInt32 id);

			[DllImport(Library, EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedbackStream(Int32 mode, UInt32 id, UInt32 stream);

			[DllImport(Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedbackStreamInstanced(Int32 mode, UInt32 id, UInt32 stream, Int32 instancecount);

			[DllImport(Library, EntryPoint = "glEGLImageTargetRenderbufferStorageOES", ExactSpelling = true)]
			internal extern static unsafe void glEGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image);

			[DllImport(Library, EntryPoint = "glEGLImageTargetTexture2DOES", ExactSpelling = true)]
			internal extern static unsafe void glEGLImageTargetTexture2DOES(Int32 target, IntPtr image);

			[DllImport(Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
			internal extern static void glEdgeFlag(bool flag);

			[DllImport(Library, EntryPoint = "glEdgeFlagFormatNV", ExactSpelling = true)]
			internal extern static void glEdgeFlagFormatNV(Int32 stride);

			[DllImport(Library, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
			internal extern static unsafe void glEdgeFlagPointer(Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glEdgeFlagPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glEdgeFlagPointerEXT(Int32 stride, Int32 count, bool* pointer);

			[DllImport(Library, EntryPoint = "glEdgeFlagPointerListIBM", ExactSpelling = true)]
			internal extern static void glEdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
			internal extern static unsafe void glEdgeFlagv(bool* flag);

			[DllImport(Library, EntryPoint = "glElementPointerAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glElementPointerAPPLE(Int32 type, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glElementPointerATI", ExactSpelling = true)]
			internal extern static unsafe void glElementPointerATI(Int32 type, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glEnable", ExactSpelling = true)]
			internal extern static void glEnable(Int32 cap);

			[DllImport(Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
			internal extern static void glEnableClientState(Int32 array);

			[DllImport(Library, EntryPoint = "glEnableClientStateIndexedEXT", ExactSpelling = true)]
			internal extern static void glEnableClientStateIndexedEXT(Int32 array, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableClientStateiEXT", ExactSpelling = true)]
			internal extern static void glEnableClientStateiEXT(Int32 array, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableDriverControlQCOM", ExactSpelling = true)]
			internal extern static void glEnableDriverControlQCOM(UInt32 driverControl);

			[DllImport(Library, EntryPoint = "glEnableIndexedEXT", ExactSpelling = true)]
			internal extern static void glEnableIndexedEXT(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableVariantClientStateEXT", ExactSpelling = true)]
			internal extern static void glEnableVariantClientStateEXT(UInt32 id);

			[DllImport(Library, EntryPoint = "glEnableVertexArrayAttrib", ExactSpelling = true)]
			internal extern static void glEnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableVertexArrayAttribEXT", ExactSpelling = true)]
			internal extern static void glEnableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableVertexArrayEXT", ExactSpelling = true)]
			internal extern static void glEnableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[DllImport(Library, EntryPoint = "glEnableVertexAttribAPPLE", ExactSpelling = true)]
			internal extern static void glEnableVertexAttribAPPLE(UInt32 index, Int32 pname);

			[DllImport(Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
			internal extern static void glEnableVertexAttribArray(UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableVertexAttribArrayARB", ExactSpelling = true)]
			internal extern static void glEnableVertexAttribArrayARB(UInt32 index);

			[DllImport(Library, EntryPoint = "glEnablei", ExactSpelling = true)]
			internal extern static void glEnablei(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableiEXT", ExactSpelling = true)]
			internal extern static void glEnableiEXT(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableiNV", ExactSpelling = true)]
			internal extern static void glEnableiNV(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnableiOES", ExactSpelling = true)]
			internal extern static void glEnableiOES(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glEnd", ExactSpelling = true)]
			internal extern static void glEnd();

			[DllImport(Library, EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
			internal extern static void glEndConditionalRender();

			[DllImport(Library, EntryPoint = "glEndConditionalRenderNV", ExactSpelling = true)]
			internal extern static void glEndConditionalRenderNV();

			[DllImport(Library, EntryPoint = "glEndConditionalRenderNVX", ExactSpelling = true)]
			internal extern static void glEndConditionalRenderNVX();

			[DllImport(Library, EntryPoint = "glEndFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glEndFragmentShaderATI();

			[DllImport(Library, EntryPoint = "glEndList", ExactSpelling = true)]
			internal extern static void glEndList();

			[DllImport(Library, EntryPoint = "glEndOcclusionQueryNV", ExactSpelling = true)]
			internal extern static void glEndOcclusionQueryNV();

			[DllImport(Library, EntryPoint = "glEndPerfMonitorAMD", ExactSpelling = true)]
			internal extern static void glEndPerfMonitorAMD(UInt32 monitor);

			[DllImport(Library, EntryPoint = "glEndPerfQueryINTEL", ExactSpelling = true)]
			internal extern static void glEndPerfQueryINTEL(UInt32 queryHandle);

			[DllImport(Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
			internal extern static void glEndQuery(Int32 target);

			[DllImport(Library, EntryPoint = "glEndQueryARB", ExactSpelling = true)]
			internal extern static void glEndQueryARB(Int32 target);

			[DllImport(Library, EntryPoint = "glEndQueryEXT", ExactSpelling = true)]
			internal extern static void glEndQueryEXT(Int32 target);

			[DllImport(Library, EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
			internal extern static void glEndQueryIndexed(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glEndTilingQCOM", ExactSpelling = true)]
			internal extern static void glEndTilingQCOM(UInt32 preserveMask);

			[DllImport(Library, EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
			internal extern static void glEndTransformFeedback();

			[DllImport(Library, EntryPoint = "glEndTransformFeedbackEXT", ExactSpelling = true)]
			internal extern static void glEndTransformFeedbackEXT();

			[DllImport(Library, EntryPoint = "glEndTransformFeedbackNV", ExactSpelling = true)]
			internal extern static void glEndTransformFeedbackNV();

			[DllImport(Library, EntryPoint = "glEndVertexShaderEXT", ExactSpelling = true)]
			internal extern static void glEndVertexShaderEXT();

			[DllImport(Library, EntryPoint = "glEndVideoCaptureNV", ExactSpelling = true)]
			internal extern static void glEndVideoCaptureNV(UInt32 video_capture_slot);

			[DllImport(Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
			internal extern static void glEvalCoord1d(double u);

			[DllImport(Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1dv(double* u);

			[DllImport(Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
			internal extern static void glEvalCoord1f(float u);

			[DllImport(Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1fv(float* u);

			[DllImport(Library, EntryPoint = "glEvalCoord1xOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1xOES(IntPtr u);

			[DllImport(Library, EntryPoint = "glEvalCoord1xvOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
			internal extern static void glEvalCoord2d(double u, double v);

			[DllImport(Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2dv(double* u);

			[DllImport(Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
			internal extern static void glEvalCoord2f(float u, float v);

			[DllImport(Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2fv(float* u);

			[DllImport(Library, EntryPoint = "glEvalCoord2xOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2xOES(IntPtr u, IntPtr v);

			[DllImport(Library, EntryPoint = "glEvalCoord2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glEvalMapsNV", ExactSpelling = true)]
			internal extern static void glEvalMapsNV(Int32 target, Int32 mode);

			[DllImport(Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
			internal extern static void glEvalMesh1(Int32 mode, Int32 i1, Int32 i2);

			[DllImport(Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
			internal extern static void glEvalMesh2(Int32 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

			[DllImport(Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
			internal extern static void glEvalPoint1(Int32 i);

			[DllImport(Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
			internal extern static void glEvalPoint2(Int32 i, Int32 j);

			[DllImport(Library, EntryPoint = "glEvaluateDepthValuesARB", ExactSpelling = true)]
			internal extern static void glEvaluateDepthValuesARB();

			[DllImport(Library, EntryPoint = "glExecuteProgramNV", ExactSpelling = true)]
			internal extern static unsafe void glExecuteProgramNV(Int32 target, UInt32 id, float* @params);

			[DllImport(Library, EntryPoint = "glExtGetBufferPointervQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetBufferPointervQCOM(Int32 target, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glExtGetBuffersQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetBuffersQCOM(UInt32* buffers, Int32 maxBuffers, Int32* numBuffers);

			[DllImport(Library, EntryPoint = "glExtGetFramebuffersQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetFramebuffersQCOM(UInt32* framebuffers, Int32 maxFramebuffers, Int32* numFramebuffers);

			[DllImport(Library, EntryPoint = "glExtGetProgramBinarySourceQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetProgramBinarySourceQCOM(UInt32 program, Int32 shadertype, String source, Int32* length);

			[DllImport(Library, EntryPoint = "glExtGetProgramsQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetProgramsQCOM(UInt32* programs, Int32 maxPrograms, Int32* numPrograms);

			[DllImport(Library, EntryPoint = "glExtGetRenderbuffersQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetRenderbuffersQCOM(UInt32* renderbuffers, Int32 maxRenderbuffers, Int32* numRenderbuffers);

			[DllImport(Library, EntryPoint = "glExtGetShadersQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetShadersQCOM(UInt32* shaders, Int32 maxShaders, Int32* numShaders);

			[DllImport(Library, EntryPoint = "glExtGetTexLevelParameterivQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetTexLevelParameterivQCOM(UInt32 texture, Int32 face, Int32 level, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glExtGetTexSubImageQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetTexSubImageQCOM(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr texels);

			[DllImport(Library, EntryPoint = "glExtGetTexturesQCOM", ExactSpelling = true)]
			internal extern static unsafe void glExtGetTexturesQCOM(UInt32* textures, Int32 maxTextures, Int32* numTextures);

			[DllImport(Library, EntryPoint = "glExtIsProgramBinaryQCOM", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glExtIsProgramBinaryQCOM(UInt32 program);

			[DllImport(Library, EntryPoint = "glExtTexObjectStateOverrideiQCOM", ExactSpelling = true)]
			internal extern static void glExtTexObjectStateOverrideiQCOM(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glExtractComponentEXT", ExactSpelling = true)]
			internal extern static void glExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);

			[DllImport(Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
			internal extern static unsafe void glFeedbackBuffer(Int32 size, Int32 type, float* buffer);

			[DllImport(Library, EntryPoint = "glFeedbackBufferxOES", ExactSpelling = true)]
			internal extern static unsafe void glFeedbackBufferxOES(Int32 n, Int32 type, IntPtr* buffer);

			[DllImport(Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
			internal extern static Int32 glFenceSync(Int32 condition, UInt32 flags);

			[DllImport(Library, EntryPoint = "glFenceSyncAPPLE", ExactSpelling = true)]
			internal extern static Int32 glFenceSyncAPPLE(Int32 condition, UInt32 flags);

			[DllImport(Library, EntryPoint = "glFinalCombinerInputNV", ExactSpelling = true)]
			internal extern static void glFinalCombinerInputNV(Int32 variable, Int32 input, Int32 mapping, Int32 componentUsage);

			[DllImport(Library, EntryPoint = "glFinish", ExactSpelling = true)]
			internal extern static void glFinish();

			[DllImport(Library, EntryPoint = "glFinishAsyncSGIX", ExactSpelling = true)]
			internal extern static unsafe Int32 glFinishAsyncSGIX(UInt32* markerp);

			[DllImport(Library, EntryPoint = "glFinishFenceAPPLE", ExactSpelling = true)]
			internal extern static void glFinishFenceAPPLE(UInt32 fence);

			[DllImport(Library, EntryPoint = "glFinishFenceNV", ExactSpelling = true)]
			internal extern static void glFinishFenceNV(UInt32 fence);

			[DllImport(Library, EntryPoint = "glFinishObjectAPPLE", ExactSpelling = true)]
			internal extern static void glFinishObjectAPPLE(Int32 @object, Int32 name);

			[DllImport(Library, EntryPoint = "glFinishTextureSUNX", ExactSpelling = true)]
			internal extern static void glFinishTextureSUNX();

			[DllImport(Library, EntryPoint = "glFlush", ExactSpelling = true)]
			internal extern static void glFlush();

			[DllImport(Library, EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedBufferRange(Int32 target, IntPtr offset, UInt32 length);

			[DllImport(Library, EntryPoint = "glFlushMappedBufferRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedBufferRangeAPPLE(Int32 target, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glFlushMappedBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedBufferRangeEXT(Int32 target, IntPtr offset, UInt32 length);

			[DllImport(Library, EntryPoint = "glFlushMappedNamedBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length);

			[DllImport(Library, EntryPoint = "glFlushMappedNamedBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length);

			[DllImport(Library, EntryPoint = "glFlushPixelDataRangeNV", ExactSpelling = true)]
			internal extern static void glFlushPixelDataRangeNV(Int32 target);

			[DllImport(Library, EntryPoint = "glFlushRasterSGIX", ExactSpelling = true)]
			internal extern static void glFlushRasterSGIX();

			[DllImport(Library, EntryPoint = "glFlushStaticDataIBM", ExactSpelling = true)]
			internal extern static void glFlushStaticDataIBM(Int32 target);

			[DllImport(Library, EntryPoint = "glFlushVertexArrayRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glFlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glFlushVertexArrayRangeNV", ExactSpelling = true)]
			internal extern static void glFlushVertexArrayRangeNV();

			[DllImport(Library, EntryPoint = "glFogCoordFormatNV", ExactSpelling = true)]
			internal extern static void glFogCoordFormatNV(Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordPointer(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glFogCoordPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glFogCoordPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glFogCoordd", ExactSpelling = true)]
			internal extern static void glFogCoordd(double coord);

			[DllImport(Library, EntryPoint = "glFogCoorddEXT", ExactSpelling = true)]
			internal extern static void glFogCoorddEXT(double coord);

			[DllImport(Library, EntryPoint = "glFogCoorddv", ExactSpelling = true)]
			internal extern static unsafe void glFogCoorddv(double* coord);

			[DllImport(Library, EntryPoint = "glFogCoorddvEXT", ExactSpelling = true)]
			internal extern static unsafe void glFogCoorddvEXT(double* coord);

			[DllImport(Library, EntryPoint = "glFogCoordf", ExactSpelling = true)]
			internal extern static void glFogCoordf(float coord);

			[DllImport(Library, EntryPoint = "glFogCoordfEXT", ExactSpelling = true)]
			internal extern static void glFogCoordfEXT(float coord);

			[DllImport(Library, EntryPoint = "glFogCoordfv", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordfv(float* coord);

			[DllImport(Library, EntryPoint = "glFogCoordfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordfvEXT(float* coord);

			[DllImport(Library, EntryPoint = "glFogCoordhNV", ExactSpelling = true)]
			internal extern static void glFogCoordhNV(UInt16 fog);

			[DllImport(Library, EntryPoint = "glFogCoordhvNV", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordhvNV(UInt16* fog);

			[DllImport(Library, EntryPoint = "glFogFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glFogFuncSGIS(Int32 n, float* points);

			[DllImport(Library, EntryPoint = "glFogf", ExactSpelling = true)]
			internal extern static void glFogf(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glFogfv", ExactSpelling = true)]
			internal extern static unsafe void glFogfv(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glFogi", ExactSpelling = true)]
			internal extern static void glFogi(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glFogiv", ExactSpelling = true)]
			internal extern static unsafe void glFogiv(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glFogx", ExactSpelling = true)]
			internal extern static unsafe void glFogx(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glFogxOES", ExactSpelling = true)]
			internal extern static unsafe void glFogxOES(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glFogxv", ExactSpelling = true)]
			internal extern static unsafe void glFogxv(Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glFogxvOES", ExactSpelling = true)]
			internal extern static unsafe void glFogxvOES(Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glFragmentColorMaterialSGIX", ExactSpelling = true)]
			internal extern static void glFragmentColorMaterialSGIX(Int32 face, Int32 mode);

			[DllImport(Library, EntryPoint = "glFragmentCoverageColorNV", ExactSpelling = true)]
			internal extern static void glFragmentCoverageColorNV(UInt32 color);

			[DllImport(Library, EntryPoint = "glFragmentLightModelfSGIX", ExactSpelling = true)]
			internal extern static void glFragmentLightModelfSGIX(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glFragmentLightModelfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glFragmentLightModelfvSGIX(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glFragmentLightModeliSGIX", ExactSpelling = true)]
			internal extern static void glFragmentLightModeliSGIX(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glFragmentLightModelivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glFragmentLightModelivSGIX(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glFragmentLightfSGIX", ExactSpelling = true)]
			internal extern static void glFragmentLightfSGIX(Int32 light, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glFragmentLightfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glFragmentLightfvSGIX(Int32 light, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glFragmentLightiSGIX", ExactSpelling = true)]
			internal extern static void glFragmentLightiSGIX(Int32 light, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glFragmentLightivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glFragmentLightivSGIX(Int32 light, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glFragmentMaterialfSGIX", ExactSpelling = true)]
			internal extern static void glFragmentMaterialfSGIX(Int32 face, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glFragmentMaterialfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glFragmentMaterialfvSGIX(Int32 face, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glFragmentMaterialiSGIX", ExactSpelling = true)]
			internal extern static void glFragmentMaterialiSGIX(Int32 face, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glFragmentMaterialivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glFragmentMaterialivSGIX(Int32 face, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glFrameTerminatorGREMEDY", ExactSpelling = true)]
			internal extern static void glFrameTerminatorGREMEDY();

			[DllImport(Library, EntryPoint = "glFrameZoomSGIX", ExactSpelling = true)]
			internal extern static void glFrameZoomSGIX(Int32 factor);

			[DllImport(Library, EntryPoint = "glFramebufferDrawBufferEXT", ExactSpelling = true)]
			internal extern static void glFramebufferDrawBufferEXT(UInt32 framebuffer, Int32 mode);

			[DllImport(Library, EntryPoint = "glFramebufferDrawBuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glFramebufferParameteri", ExactSpelling = true)]
			internal extern static void glFramebufferParameteri(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glFramebufferPixelLocalStorageSizeEXT", ExactSpelling = true)]
			internal extern static void glFramebufferPixelLocalStorageSizeEXT(UInt32 target, Int32 size);

			[DllImport(Library, EntryPoint = "glFramebufferReadBufferEXT", ExactSpelling = true)]
			internal extern static void glFramebufferReadBufferEXT(UInt32 framebuffer, Int32 mode);

			[DllImport(Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
			internal extern static void glFramebufferRenderbuffer(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glFramebufferRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glFramebufferRenderbufferEXT(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glFramebufferRenderbufferOES", ExactSpelling = true)]
			internal extern static void glFramebufferRenderbufferOES(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glFramebufferSampleLocationsfvARB", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferSampleLocationsfvARB(Int32 target, UInt32 start, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glFramebufferSampleLocationsfvNV", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferSampleLocationsfvNV(Int32 target, UInt32 start, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
			internal extern static void glFramebufferTexture(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
			internal extern static void glFramebufferTexture1D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTexture1DEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTexture1DEXT(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTexture2DEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DEXT(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTexture2DDownsampleIMG", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DDownsampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 xscale, Int32 yscale);

			[DllImport(Library, EntryPoint = "glFramebufferTexture2DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DMultisampleEXT(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

			[DllImport(Library, EntryPoint = "glFramebufferTexture2DMultisampleIMG", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DMultisampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

			[DllImport(Library, EntryPoint = "glFramebufferTexture2DOES", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DOES(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
			internal extern static void glFramebufferTexture3D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[DllImport(Library, EntryPoint = "glFramebufferTexture3DEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTexture3DEXT(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[DllImport(Library, EntryPoint = "glFramebufferTexture3DOES", ExactSpelling = true)]
			internal extern static void glFramebufferTexture3DOES(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[DllImport(Library, EntryPoint = "glFramebufferTextureARB", ExactSpelling = true)]
			internal extern static void glFramebufferTextureARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTextureEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTextureEXT(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFramebufferTextureFaceARB", ExactSpelling = true)]
			internal extern static void glFramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[DllImport(Library, EntryPoint = "glFramebufferTextureFaceEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTextureFaceEXT(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[DllImport(Library, EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
			internal extern static void glFramebufferTextureLayer(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[DllImport(Library, EntryPoint = "glFramebufferTextureLayerARB", ExactSpelling = true)]
			internal extern static void glFramebufferTextureLayerARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[DllImport(Library, EntryPoint = "glFramebufferTextureLayerEXT", ExactSpelling = true)]
			internal extern static void glFramebufferTextureLayerEXT(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[DllImport(Library, EntryPoint = "glFramebufferTextureLayerDownsampleIMG", ExactSpelling = true)]
			internal extern static void glFramebufferTextureLayerDownsampleIMG(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer, Int32 xscale, Int32 yscale);

			[DllImport(Library, EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR", ExactSpelling = true)]
			internal extern static void glFramebufferTextureMultisampleMultiviewOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 samples, Int32 baseViewIndex, Int32 numViews);

			[DllImport(Library, EntryPoint = "glFramebufferTextureMultiviewOVR", ExactSpelling = true)]
			internal extern static void glFramebufferTextureMultiviewOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 baseViewIndex, Int32 numViews);

			[DllImport(Library, EntryPoint = "glFramebufferTextureOES", ExactSpelling = true)]
			internal extern static void glFramebufferTextureOES(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glFreeObjectBufferATI", ExactSpelling = true)]
			internal extern static void glFreeObjectBufferATI(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
			internal extern static void glFrontFace(Int32 mode);

			[DllImport(Library, EntryPoint = "glFrustum", ExactSpelling = true)]
			internal extern static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

			[DllImport(Library, EntryPoint = "glFrustumf", ExactSpelling = true)]
			internal extern static void glFrustumf(float l, float r, float b, float t, float n, float f);

			[DllImport(Library, EntryPoint = "glFrustumfOES", ExactSpelling = true)]
			internal extern static void glFrustumfOES(float l, float r, float b, float t, float n, float f);

			[DllImport(Library, EntryPoint = "glFrustumx", ExactSpelling = true)]
			internal extern static unsafe void glFrustumx(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[DllImport(Library, EntryPoint = "glFrustumxOES", ExactSpelling = true)]
			internal extern static unsafe void glFrustumxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[DllImport(Library, EntryPoint = "glGenAsyncMarkersSGIX", ExactSpelling = true)]
			internal extern static UInt32 glGenAsyncMarkersSGIX(Int32 range);

			[DllImport(Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
			internal extern static unsafe void glGenBuffers(Int32 n, UInt32* buffers);

			[DllImport(Library, EntryPoint = "glGenBuffersARB", ExactSpelling = true)]
			internal extern static unsafe void glGenBuffersARB(Int32 n, UInt32* buffers);

			[DllImport(Library, EntryPoint = "glGenFencesAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGenFencesAPPLE(Int32 n, UInt32* fences);

			[DllImport(Library, EntryPoint = "glGenFencesNV", ExactSpelling = true)]
			internal extern static unsafe void glGenFencesNV(Int32 n, UInt32* fences);

			[DllImport(Library, EntryPoint = "glGenFragmentShadersATI", ExactSpelling = true)]
			internal extern static UInt32 glGenFragmentShadersATI(UInt32 range);

			[DllImport(Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
			internal extern static unsafe void glGenFramebuffers(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glGenFramebuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenFramebuffersEXT(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glGenFramebuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glGenFramebuffersOES(Int32 n, UInt32* framebuffers);

			[DllImport(Library, EntryPoint = "glGenLists", ExactSpelling = true)]
			internal extern static UInt32 glGenLists(Int32 range);

			[DllImport(Library, EntryPoint = "glGenNamesAMD", ExactSpelling = true)]
			internal extern static unsafe void glGenNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			[DllImport(Library, EntryPoint = "glGenOcclusionQueriesNV", ExactSpelling = true)]
			internal extern static unsafe void glGenOcclusionQueriesNV(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glGenPathsNV", ExactSpelling = true)]
			internal extern static UInt32 glGenPathsNV(Int32 range);

			[DllImport(Library, EntryPoint = "glGenPerfMonitorsAMD", ExactSpelling = true)]
			internal extern static unsafe void glGenPerfMonitorsAMD(Int32 n, UInt32* monitors);

			[DllImport(Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramPipelines(Int32 n, UInt32* pipelines);

			[DllImport(Library, EntryPoint = "glGenProgramPipelinesEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[DllImport(Library, EntryPoint = "glGenProgramsARB", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramsARB(Int32 n, UInt32* programs);

			[DllImport(Library, EntryPoint = "glGenProgramsNV", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramsNV(Int32 n, UInt32* programs);

			[DllImport(Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
			internal extern static unsafe void glGenQueries(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glGenQueriesARB", ExactSpelling = true)]
			internal extern static unsafe void glGenQueriesARB(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glGenQueriesEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenQueriesEXT(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
			internal extern static unsafe void glGenRenderbuffers(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glGenRenderbuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenRenderbuffersEXT(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glGenRenderbuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glGenRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[DllImport(Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
			internal extern static unsafe void glGenSamplers(Int32 count, UInt32* samplers);

			[DllImport(Library, EntryPoint = "glGenSymbolsEXT", ExactSpelling = true)]
			internal extern static UInt32 glGenSymbolsEXT(Int32 datatype, Int32 storagetype, Int32 range, UInt32 components);

			[DllImport(Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
			internal extern static unsafe void glGenTextures(Int32 n, UInt32* textures);

			[DllImport(Library, EntryPoint = "glGenTexturesEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenTexturesEXT(Int32 n, UInt32* textures);

			[DllImport(Library, EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
			internal extern static unsafe void glGenTransformFeedbacks(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glGenTransformFeedbacksNV", ExactSpelling = true)]
			internal extern static unsafe void glGenTransformFeedbacksNV(Int32 n, UInt32* ids);

			[DllImport(Library, EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
			internal extern static unsafe void glGenVertexArrays(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glGenVertexArraysAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGenVertexArraysAPPLE(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glGenVertexArraysOES", ExactSpelling = true)]
			internal extern static unsafe void glGenVertexArraysOES(Int32 n, UInt32* arrays);

			[DllImport(Library, EntryPoint = "glGenVertexShadersEXT", ExactSpelling = true)]
			internal extern static UInt32 glGenVertexShadersEXT(UInt32 range);

			[DllImport(Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
			internal extern static void glGenerateMipmap(Int32 target);

			[DllImport(Library, EntryPoint = "glGenerateMipmapEXT", ExactSpelling = true)]
			internal extern static void glGenerateMipmapEXT(Int32 target);

			[DllImport(Library, EntryPoint = "glGenerateMipmapOES", ExactSpelling = true)]
			internal extern static void glGenerateMipmapOES(Int32 target);

			[DllImport(Library, EntryPoint = "glGenerateMultiTexMipmapEXT", ExactSpelling = true)]
			internal extern static void glGenerateMultiTexMipmapEXT(Int32 texunit, Int32 target);

			[DllImport(Library, EntryPoint = "glGenerateTextureMipmap", ExactSpelling = true)]
			internal extern static void glGenerateTextureMipmap(UInt32 texture);

			[DllImport(Library, EntryPoint = "glGenerateTextureMipmapEXT", ExactSpelling = true)]
			internal extern static void glGenerateTextureMipmapEXT(UInt32 texture, Int32 target);

			[DllImport(Library, EntryPoint = "glGetActiveAtomicCounterBufferiv", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetActiveAttribARB", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveSubroutineName(UInt32 program, Int32 shadertype, UInt32 index, Int32 bufsize, Int32* length, String name);

			[DllImport(Library, EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveSubroutineUniformName(UInt32 program, Int32 shadertype, UInt32 index, Int32 bufsize, Int32* length, String name);

			[DllImport(Library, EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveSubroutineUniformiv(UInt32 program, Int32 shadertype, UInt32 index, Int32 pname, Int32* values);

			[DllImport(Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetActiveUniformARB", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, Int32* length, String uniformBlockName);

			[DllImport(Library, EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, Int32* length, String uniformName);

			[DllImport(Library, EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetActiveVaryingNV", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetArrayObjectfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetArrayObjectfvATI(Int32 array, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetArrayObjectivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetArrayObjectivATI(Int32 array, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetAttachedObjectsARB", ExactSpelling = true)]
			internal extern static unsafe void glGetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, Int32* count, UInt32* obj);

			[DllImport(Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
			internal extern static unsafe void glGetAttachedShaders(UInt32 program, Int32 maxCount, Int32* count, UInt32* shaders);

			[DllImport(Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
			internal extern static Int32 glGetAttribLocation(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetAttribLocationARB", ExactSpelling = true)]
			internal extern static Int32 glGetAttribLocationARB(UInt32 programObj, String name);

			[DllImport(Library, EntryPoint = "glGetBooleanIndexedvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetBooleanIndexedvEXT(Int32 target, UInt32 index, bool* data);

			[DllImport(Library, EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
			internal extern static unsafe void glGetBooleani_v(Int32 target, UInt32 index, bool* data);

			[DllImport(Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
			internal extern static unsafe void glGetBooleanv(Int32 pname, bool* data);

			[DllImport(Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferParameteri64v(Int32 target, Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetBufferParameterivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferParameterivARB(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetBufferParameterui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferParameterui64vNV(Int32 target, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferPointerv(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetBufferPointervARB", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferPointervARB(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetBufferPointervOES", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferPointervOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferSubData(Int32 target, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glGetBufferSubDataARB", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferSubDataARB(Int32 target, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlane(Int32 plane, double* equation);

			[DllImport(Library, EntryPoint = "glGetClipPlanef", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanef(Int32 plane, float* equation);

			[DllImport(Library, EntryPoint = "glGetClipPlanefOES", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanefOES(Int32 plane, float* equation);

			[DllImport(Library, EntryPoint = "glGetClipPlanex", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanex(Int32 plane, IntPtr* equation);

			[DllImport(Library, EntryPoint = "glGetClipPlanexOES", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanexOES(Int32 plane, IntPtr* equation);

			[DllImport(Library, EntryPoint = "glGetColorTable", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTable(Int32 target, Int32 format, Int32 type, IntPtr table);

			[DllImport(Library, EntryPoint = "glGetColorTableEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableEXT(Int32 target, Int32 format, Int32 type, IntPtr data);

			[DllImport(Library, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetColorTableParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetColorTableParameterfvSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetColorTableParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetColorTableParameterivSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetColorTableSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableSGI(Int32 target, Int32 format, Int32 type, IntPtr table);

			[DllImport(Library, EntryPoint = "glGetCombinerInputParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCombinerInputParameterfvNV(Int32 stage, Int32 portion, Int32 variable, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetCombinerInputParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCombinerInputParameterivNV(Int32 stage, Int32 portion, Int32 variable, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetCombinerOutputParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCombinerOutputParameterfvNV(Int32 stage, Int32 portion, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetCombinerOutputParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCombinerOutputParameterivNV(Int32 stage, Int32 portion, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetCombinerStageParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCombinerStageParameterfvNV(Int32 stage, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetCommandHeaderNV", ExactSpelling = true)]
			internal extern static UInt32 glGetCommandHeaderNV(Int32 tokenID, UInt32 size);

			[DllImport(Library, EntryPoint = "glGetCompressedMultiTexImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedMultiTexImageEXT(Int32 texunit, Int32 target, Int32 lod, IntPtr img);

			[DllImport(Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTexImage(Int32 target, Int32 level, IntPtr img);

			[DllImport(Library, EntryPoint = "glGetCompressedTexImageARB", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTexImageARB(Int32 target, Int32 level, IntPtr img);

			[DllImport(Library, EntryPoint = "glGetCompressedTextureImage", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetCompressedTextureImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTextureImageEXT(UInt32 texture, Int32 target, Int32 lod, IntPtr img);

			[DllImport(Library, EntryPoint = "glGetCompressedTextureSubImage", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionFilter(Int32 target, Int32 format, Int32 type, IntPtr image);

			[DllImport(Library, EntryPoint = "glGetConvolutionFilterEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr image);

			[DllImport(Library, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetConvolutionParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetConvolutionParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetConvolutionParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetCoverageModulationTableNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCoverageModulationTableNV(Int32 bufsize, float* v);

			[DllImport(Library, EntryPoint = "glGetDebugMessageLog", ExactSpelling = true)]
			internal extern static unsafe UInt32 glGetDebugMessageLog(UInt32 count, Int32 bufSize, Int32* sources, Int32* types, UInt32* ids, Int32* severities, Int32* lengths, String messageLog);

			[DllImport(Library, EntryPoint = "glGetDebugMessageLogAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glGetDebugMessageLogAMD(UInt32 count, Int32 bufsize, Int32* categories, UInt32* severities, UInt32* ids, Int32* lengths, String message);

			[DllImport(Library, EntryPoint = "glGetDebugMessageLogARB", ExactSpelling = true)]
			internal extern static unsafe UInt32 glGetDebugMessageLogARB(UInt32 count, Int32 bufSize, Int32* sources, Int32* types, UInt32* ids, Int32* severities, Int32* lengths, String messageLog);

			[DllImport(Library, EntryPoint = "glGetDebugMessageLogKHR", ExactSpelling = true)]
			internal extern static unsafe UInt32 glGetDebugMessageLogKHR(UInt32 count, Int32 bufSize, Int32* sources, Int32* types, UInt32* ids, Int32* severities, Int32* lengths, String messageLog);

			[DllImport(Library, EntryPoint = "glGetDetailTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetDetailTexFuncSGIS(Int32 target, float* points);

			[DllImport(Library, EntryPoint = "glGetDoubleIndexedvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetDoubleIndexedvEXT(Int32 target, UInt32 index, double* data);

			[DllImport(Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
			internal extern static unsafe void glGetDoublei_v(Int32 target, UInt32 index, double* data);

			[DllImport(Library, EntryPoint = "glGetDoublei_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetDoublei_vEXT(Int32 pname, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
			internal extern static unsafe void glGetDoublev(Int32 pname, double* data);

			[DllImport(Library, EntryPoint = "glGetDriverControlStringQCOM", ExactSpelling = true)]
			internal extern static unsafe void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, Int32* length, String driverControlString);

			[DllImport(Library, EntryPoint = "glGetDriverControlsQCOM", ExactSpelling = true)]
			internal extern static unsafe void glGetDriverControlsQCOM(Int32* num, Int32 size, UInt32* driverControls);

			[DllImport(Library, EntryPoint = "glGetError", ExactSpelling = true)]
			internal extern static Int32 glGetError();

			[DllImport(Library, EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetFenceivNV(UInt32 fence, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFinalCombinerInputParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetFinalCombinerInputParameterfvNV(Int32 variable, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetFinalCombinerInputParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetFinalCombinerInputParameterivNV(Int32 variable, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFirstPerfQueryIdINTEL", ExactSpelling = true)]
			internal extern static unsafe void glGetFirstPerfQueryIdINTEL(UInt32* queryId);

			[DllImport(Library, EntryPoint = "glGetFixedv", ExactSpelling = true)]
			internal extern static unsafe void glGetFixedv(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetFixedvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetFixedvOES(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetFloatIndexedvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetFloatIndexedvEXT(Int32 target, UInt32 index, float* data);

			[DllImport(Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
			internal extern static unsafe void glGetFloati_v(Int32 target, UInt32 index, float* data);

			[DllImport(Library, EntryPoint = "glGetFloati_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetFloati_vEXT(Int32 pname, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glGetFloati_vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetFloati_vNV(Int32 target, UInt32 index, float* data);

			[DllImport(Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
			internal extern static unsafe void glGetFloatv(Int32 pname, float* data);

			[DllImport(Library, EntryPoint = "glGetFogFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetFogFuncSGIS(float* points);

			[DllImport(Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
			internal extern static Int32 glGetFragDataIndex(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetFragDataIndexEXT", ExactSpelling = true)]
			internal extern static Int32 glGetFragDataIndexEXT(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
			internal extern static Int32 glGetFragDataLocation(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetFragDataLocationEXT", ExactSpelling = true)]
			internal extern static Int32 glGetFragDataLocationEXT(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetFragmentLightfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetFragmentLightfvSGIX(Int32 light, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetFragmentLightivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetFragmentLightivSGIX(Int32 light, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFragmentMaterialfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetFragmentMaterialfvSGIX(Int32 face, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetFragmentMaterialivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetFragmentMaterialivSGIX(Int32 face, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferAttachmentParameteriv(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferAttachmentParameterivEXT(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFramebufferAttachmentParameterivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferAttachmentParameterivOES(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFramebufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFramebufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT", ExactSpelling = true)]
			internal extern static Int32 glGetFramebufferPixelLocalStorageSizeEXT(UInt32 target);

			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatus", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatus();

			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatusARB", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatusARB();

			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatusEXT", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatusEXT();

			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatusKHR", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatusKHR();

			[DllImport(Library, EntryPoint = "glGetHandleARB", ExactSpelling = true)]
			internal extern static UInt32 glGetHandleARB(Int32 pname);

			[DllImport(Library, EntryPoint = "glGetHistogram", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogram(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetHistogramEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetHistogramParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetHistogramParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetHistogramParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetImageHandleARB", ExactSpelling = true)]
			internal extern static UInt64 glGetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[DllImport(Library, EntryPoint = "glGetImageHandleNV", ExactSpelling = true)]
			internal extern static UInt64 glGetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[DllImport(Library, EntryPoint = "glGetImageTransformParameterfvHP", ExactSpelling = true)]
			internal extern static unsafe void glGetImageTransformParameterfvHP(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetImageTransformParameterivHP", ExactSpelling = true)]
			internal extern static unsafe void glGetImageTransformParameterivHP(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetInfoLogARB", ExactSpelling = true)]
			internal extern static unsafe void glGetInfoLogARB(UInt32 obj, Int32 maxLength, Int32* length, String infoLog);

			[DllImport(Library, EntryPoint = "glGetInstrumentsSGIX", ExactSpelling = true)]
			internal extern static Int32 glGetInstrumentsSGIX();

			[DllImport(Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
			internal extern static unsafe void glGetInteger64i_v(Int32 target, UInt32 index, Int64* data);

			[DllImport(Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
			internal extern static unsafe void glGetInteger64v(Int32 pname, Int64* data);

			[DllImport(Library, EntryPoint = "glGetInteger64vAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGetInteger64vAPPLE(Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetIntegerIndexedvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerIndexedvEXT(Int32 target, UInt32 index, Int32* data);

			[DllImport(Library, EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegeri_v(Int32 target, UInt32 index, Int32* data);

			[DllImport(Library, EntryPoint = "glGetIntegeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegeri_vEXT(Int32 target, UInt32 index, Int32* data);

			[DllImport(Library, EntryPoint = "glGetIntegerui64i_vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerui64i_vNV(Int32 value, UInt32 index, UInt64* result);

			[DllImport(Library, EntryPoint = "glGetIntegerui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerui64vNV(Int32 value, UInt64* result);

			[DllImport(Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerv(Int32 pname, Int32* data);

			[DllImport(Library, EntryPoint = "glGetInternalformatSampleivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetInternalformatSampleivNV(Int32 target, Int32 internalformat, Int32 samples, Int32 pname, Int32 bufSize, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetInternalformati64v", ExactSpelling = true)]
			internal extern static unsafe void glGetInternalformati64v(Int32 target, Int32 internalformat, Int32 pname, Int32 bufSize, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetInternalformativ", ExactSpelling = true)]
			internal extern static unsafe void glGetInternalformativ(Int32 target, Int32 internalformat, Int32 pname, Int32 bufSize, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetInvariantBooleanvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetInvariantBooleanvEXT(UInt32 id, Int32 value, bool* data);

			[DllImport(Library, EntryPoint = "glGetInvariantFloatvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetInvariantFloatvEXT(UInt32 id, Int32 value, float* data);

			[DllImport(Library, EntryPoint = "glGetInvariantIntegervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetInvariantIntegervEXT(UInt32 id, Int32 value, Int32* data);

			[DllImport(Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightfv(Int32 light, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightiv(Int32 light, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetLightxOES", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxOES(Int32 light, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetLightxv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetLightxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetListParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetListParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetLocalConstantBooleanvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetLocalConstantBooleanvEXT(UInt32 id, Int32 value, bool* data);

			[DllImport(Library, EntryPoint = "glGetLocalConstantFloatvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetLocalConstantFloatvEXT(UInt32 id, Int32 value, float* data);

			[DllImport(Library, EntryPoint = "glGetLocalConstantIntegervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetLocalConstantIntegervEXT(UInt32 id, Int32 value, Int32* data);

			[DllImport(Library, EntryPoint = "glGetMapAttribParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetMapAttribParameterfvNV(Int32 target, UInt32 index, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMapAttribParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetMapAttribParameterivNV(Int32 target, UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMapControlPointsNV", ExactSpelling = true)]
			internal extern static unsafe void glGetMapControlPointsNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, bool packed, IntPtr points);

			[DllImport(Library, EntryPoint = "glGetMapParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetMapParameterfvNV(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMapParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetMapParameterivNV(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapdv(Int32 target, Int32 query, double* v);

			[DllImport(Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapfv(Int32 target, Int32 query, float* v);

			[DllImport(Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapiv(Int32 target, Int32 query, Int32* v);

			[DllImport(Library, EntryPoint = "glGetMapxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetMapxvOES(Int32 target, Int32 query, IntPtr* v);

			[DllImport(Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialfv(Int32 face, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMaterialxOES", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glGetMaterialxv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxv(Int32 face, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetMaterialxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxvOES(Int32 face, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetMinmax", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmax(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetMinmaxEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMinmaxParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMinmaxParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexEnvfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexEnvivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexGendvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexGenfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexGenivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexImageEXT(Int32 texunit, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetMultiTexLevelParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexLevelParameterfvEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexLevelParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexLevelParameterivEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetMultiTexParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
			internal extern static unsafe void glGetMultisamplefv(Int32 pname, UInt32 index, float* val);

			[DllImport(Library, EntryPoint = "glGetMultisamplefvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetMultisamplefvNV(Int32 pname, UInt32 index, float* val);

			[DllImport(Library, EntryPoint = "glGetNamedBufferParameteri64v", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameteri64v(UInt32 buffer, Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetNamedBufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameteriv(UInt32 buffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedBufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameterivEXT(UInt32 buffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedBufferParameterui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameterui64vNV(UInt32 buffer, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetNamedBufferPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferPointerv(UInt32 buffer, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetNamedBufferPointervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferPointervEXT(UInt32 buffer, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glGetNamedBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedFramebufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferParameteriv(UInt32 framebuffer, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetNamedFramebufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterIivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterIuivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterdvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterfvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glGetNamedProgramStringEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramStringEXT(UInt32 program, Int32 target, Int32 pname, IntPtr @string);

			[DllImport(Library, EntryPoint = "glGetNamedProgramivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramivEXT(UInt32 program, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedRenderbufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedRenderbufferParameteriv(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedRenderbufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNamedStringARB", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedStringARB(Int32 namelen, String name, Int32 bufSize, Int32* stringlen, String @string);

			[DllImport(Library, EntryPoint = "glGetNamedStringivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedStringivARB(Int32 namelen, String name, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetNextPerfQueryIdINTEL", ExactSpelling = true)]
			internal extern static unsafe void glGetNextPerfQueryIdINTEL(UInt32 queryId, UInt32* nextQueryId);

			[DllImport(Library, EntryPoint = "glGetObjectBufferfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectBufferfvATI(UInt32 buffer, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetObjectBufferivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectBufferivATI(UInt32 buffer, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetObjectLabel", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectLabel(Int32 identifier, UInt32 name, Int32 bufSize, Int32* length, String label);

			[DllImport(Library, EntryPoint = "glGetObjectLabelEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectLabelEXT(Int32 type, UInt32 @object, Int32 bufSize, Int32* length, String label);

			[DllImport(Library, EntryPoint = "glGetObjectLabelKHR", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectLabelKHR(Int32 identifier, UInt32 name, Int32 bufSize, Int32* length, String label);

			[DllImport(Library, EntryPoint = "glGetObjectParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectParameterfvARB(UInt32 obj, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetObjectParameterivAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectParameterivAPPLE(Int32 objectType, UInt32 name, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetObjectParameterivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectParameterivARB(UInt32 obj, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetObjectPtrLabel", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectPtrLabel(IntPtr ptr, Int32 bufSize, Int32* length, String label);

			[DllImport(Library, EntryPoint = "glGetObjectPtrLabelKHR", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, Int32* length, String label);

			[DllImport(Library, EntryPoint = "glGetOcclusionQueryivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetOcclusionQueryivNV(UInt32 id, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetOcclusionQueryuivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetOcclusionQueryuivNV(UInt32 id, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetPathColorGenfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathColorGenfvNV(Int32 color, Int32 pname, float* value);

			[DllImport(Library, EntryPoint = "glGetPathColorGenivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathColorGenivNV(Int32 color, Int32 pname, Int32* value);

			[DllImport(Library, EntryPoint = "glGetPathCommandsNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathCommandsNV(UInt32 path, byte* commands);

			[DllImport(Library, EntryPoint = "glGetPathCoordsNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathCoordsNV(UInt32 path, float* coords);

			[DllImport(Library, EntryPoint = "glGetPathDashArrayNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathDashArrayNV(UInt32 path, float* dashArray);

			[DllImport(Library, EntryPoint = "glGetPathLengthNV", ExactSpelling = true)]
			internal extern static float glGetPathLengthNV(UInt32 path, Int32 startSegment, Int32 numSegments);

			[DllImport(Library, EntryPoint = "glGetPathMetricRangeNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathMetricRangeNV(UInt32 metricQueryMask, UInt32 firstPathName, Int32 numPaths, Int32 stride, float* metrics);

			[DllImport(Library, EntryPoint = "glGetPathMetricsNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathMetricsNV(UInt32 metricQueryMask, Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 stride, float* metrics);

			[DllImport(Library, EntryPoint = "glGetPathParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathParameterfvNV(UInt32 path, Int32 pname, float* value);

			[DllImport(Library, EntryPoint = "glGetPathParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathParameterivNV(UInt32 path, Int32 pname, Int32* value);

			[DllImport(Library, EntryPoint = "glGetPathSpacingNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathSpacingNV(Int32 pathListMode, Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, float advanceScale, float kerningScale, Int32 transformType, float* returnedSpacing);

			[DllImport(Library, EntryPoint = "glGetPathTexGenfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathTexGenfvNV(Int32 texCoordSet, Int32 pname, float* value);

			[DllImport(Library, EntryPoint = "glGetPathTexGenivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetPathTexGenivNV(Int32 texCoordSet, Int32 pname, Int32* value);

			[DllImport(Library, EntryPoint = "glGetPerfCounterInfoINTEL", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfCounterInfoINTEL(UInt32 queryId, UInt32 counterId, UInt32 counterNameLength, String counterName, UInt32 counterDescLength, String counterDesc, UInt32* counterOffset, UInt32* counterDataSize, UInt32* counterTypeEnum, UInt32* counterDataTypeEnum, UInt64* rawCounterMaxValue);

			[DllImport(Library, EntryPoint = "glGetPerfMonitorCounterDataAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCounterDataAMD(UInt32 monitor, Int32 pname, Int32 dataSize, UInt32* data, Int32* bytesWritten);

			[DllImport(Library, EntryPoint = "glGetPerfMonitorCounterInfoAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, IntPtr data);

			[DllImport(Library, EntryPoint = "glGetPerfMonitorCounterStringAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, Int32* length, String counterString);

			[DllImport(Library, EntryPoint = "glGetPerfMonitorCountersAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCountersAMD(UInt32 group, Int32* numCounters, Int32* maxActiveCounters, Int32 counterSize, UInt32* counters);

			[DllImport(Library, EntryPoint = "glGetPerfMonitorGroupStringAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, Int32* length, String groupString);

			[DllImport(Library, EntryPoint = "glGetPerfMonitorGroupsAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorGroupsAMD(Int32* numGroups, Int32 groupsSize, UInt32* groups);

			[DllImport(Library, EntryPoint = "glGetPerfQueryDataINTEL", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfQueryDataINTEL(UInt32 queryHandle, UInt32 flags, Int32 dataSize, void* data, UInt32* bytesWritten);

			[DllImport(Library, EntryPoint = "glGetPerfQueryIdByNameINTEL", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfQueryIdByNameINTEL(String queryName, UInt32* queryId);

			[DllImport(Library, EntryPoint = "glGetPerfQueryInfoINTEL", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfQueryInfoINTEL(UInt32 queryId, UInt32 queryNameLength, String queryName, UInt32* dataSize, UInt32* noCounters, UInt32* noInstances, UInt32* capsMask);

			[DllImport(Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapfv(Int32 map, float* values);

			[DllImport(Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapuiv(Int32 map, UInt32* values);

			[DllImport(Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapusv(Int32 map, UInt16* values);

			[DllImport(Library, EntryPoint = "glGetPixelMapxv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapxv(Int32 map, Int32 size, IntPtr* values);

			[DllImport(Library, EntryPoint = "glGetPixelTexGenParameterfvSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetPixelTexGenParameterivSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetPixelTransformParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetPixelTransformParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetPointerIndexedvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPointerIndexedvEXT(Int32 target, UInt32 index, IntPtr* data);

			[DllImport(Library, EntryPoint = "glGetPointeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPointeri_vEXT(Int32 pname, UInt32 index, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetPointerv(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetPointervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPointervEXT(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetPointervKHR", ExactSpelling = true)]
			internal extern static unsafe void glGetPointervKHR(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glGetPolygonStipple(byte* mask);

			[DllImport(Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramBinary(UInt32 program, Int32 bufSize, Int32* length, Int32* binaryFormat, IntPtr binary);

			[DllImport(Library, EntryPoint = "glGetProgramBinaryOES", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramBinaryOES(UInt32 program, Int32 bufSize, Int32* length, Int32* binaryFormat, IntPtr binary);

			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterIivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterIuivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterdvARB(Int32 target, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterfvARB(Int32 target, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramInfoLog(UInt32 program, Int32 bufSize, Int32* length, String infoLog);

			[DllImport(Library, EntryPoint = "glGetProgramInterfaceiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramInterfaceiv(UInt32 program, Int32 programInterface, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterIivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterIuivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterdvARB(Int32 target, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterfvARB(Int32 target, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glGetProgramNamedParameterdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramNamedParameterdvNV(UInt32 id, Int32 len, byte* name, double* @params);

			[DllImport(Library, EntryPoint = "glGetProgramNamedParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramNamedParameterfvNV(UInt32 id, Int32 len, byte* name, float* @params);

			[DllImport(Library, EntryPoint = "glGetProgramParameterdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramParameterdvNV(Int32 target, UInt32 index, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetProgramParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramParameterfvNV(Int32 target, UInt32 index, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, Int32* length, String infoLog);

			[DllImport(Library, EntryPoint = "glGetProgramPipelineInfoLogEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, Int32* length, String infoLog);

			[DllImport(Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineiv(UInt32 pipeline, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramPipelineivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineivEXT(UInt32 pipeline, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramResourceIndex", ExactSpelling = true)]
			internal extern static UInt32 glGetProgramResourceIndex(UInt32 program, Int32 programInterface, String name);

			[DllImport(Library, EntryPoint = "glGetProgramResourceLocation", ExactSpelling = true)]
			internal extern static Int32 glGetProgramResourceLocation(UInt32 program, Int32 programInterface, String name);

			[DllImport(Library, EntryPoint = "glGetProgramResourceLocationIndex", ExactSpelling = true)]
			internal extern static Int32 glGetProgramResourceLocationIndex(UInt32 program, Int32 programInterface, String name);

			[DllImport(Library, EntryPoint = "glGetProgramResourceLocationIndexEXT", ExactSpelling = true)]
			internal extern static Int32 glGetProgramResourceLocationIndexEXT(UInt32 program, Int32 programInterface, String name);

			[DllImport(Library, EntryPoint = "glGetProgramResourceName", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramResourceName(UInt32 program, Int32 programInterface, UInt32 index, Int32 bufSize, Int32* length, String name);

			[DllImport(Library, EntryPoint = "glGetProgramResourcefvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramResourcefvNV(UInt32 program, Int32 programInterface, UInt32 index, Int32 propCount, Int32* props, Int32 bufSize, Int32* length, float* @params);

			[DllImport(Library, EntryPoint = "glGetProgramResourceiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramResourceiv(UInt32 program, Int32 programInterface, UInt32 index, Int32 propCount, Int32* props, Int32 bufSize, Int32* length, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramStageiv(UInt32 program, Int32 shadertype, Int32 pname, Int32* values);

			[DllImport(Library, EntryPoint = "glGetProgramStringARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramStringARB(Int32 target, Int32 pname, IntPtr @string);

			[DllImport(Library, EntryPoint = "glGetProgramStringNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramStringNV(UInt32 id, Int32 pname, byte* program);

			[DllImport(Library, EntryPoint = "glGetProgramSubroutineParameteruivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramSubroutineParameteruivNV(Int32 target, UInt32 index, UInt32* param);

			[DllImport(Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramiv(UInt32 program, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramivARB(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetProgramivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramivNV(UInt32 id, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryBufferObjecti64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[DllImport(Library, EntryPoint = "glGetQueryBufferObjectiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjectiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[DllImport(Library, EntryPoint = "glGetQueryBufferObjectui64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[DllImport(Library, EntryPoint = "glGetQueryBufferObjectuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[DllImport(Library, EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryIndexediv(Int32 target, UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjecti64v(UInt32 id, Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjecti64vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjecti64vEXT(UInt32 id, Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectiv(UInt32 id, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectivARB(UInt32 id, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectivEXT(UInt32 id, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectui64v(UInt32 id, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectui64vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectui64vEXT(UInt32 id, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectuiv(UInt32 id, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectuivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectuivARB(UInt32 id, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryObjectuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectuivEXT(UInt32 id, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryiv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryivARB(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetQueryivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetRenderbufferParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetRenderbufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetRenderbufferParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetRenderbufferParameterivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetRenderbufferParameterivOES(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIivEXT(UInt32 sampler, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterIivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIivOES(UInt32 sampler, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIuivEXT(UInt32 sampler, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterIuivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIuivOES(UInt32 sampler, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterfv(UInt32 sampler, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
			internal extern static unsafe void glGetSeparableFilter(Int32 target, Int32 format, Int32 type, IntPtr row, IntPtr column, IntPtr span);

			[DllImport(Library, EntryPoint = "glGetSeparableFilterEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetSeparableFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr row, IntPtr column, IntPtr span);

			[DllImport(Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, Int32* length, String infoLog);

			[DllImport(Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderPrecisionFormat(Int32 shadertype, Int32 precisiontype, Int32* range, Int32* precision);

			[DllImport(Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderSource(UInt32 shader, Int32 bufSize, Int32* length, String source);

			[DllImport(Library, EntryPoint = "glGetShaderSourceARB", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderSourceARB(UInt32 obj, Int32 maxLength, Int32* length, String source);

			[DllImport(Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderiv(UInt32 shader, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetSharpenTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetSharpenTexFuncSGIS(Int32 target, float* points);

			[DllImport(Library, EntryPoint = "glGetStageIndexNV", ExactSpelling = true)]
			internal extern static UInt16 glGetStageIndexNV(Int32 shadertype);

			[DllImport(Library, EntryPoint = "glGetString", ExactSpelling = true)]
			internal extern static IntPtr glGetString(Int32 name);

			[DllImport(Library, EntryPoint = "glGetStringi", ExactSpelling = true)]
			internal extern static IntPtr glGetStringi(Int32 name, UInt32 index);

			[DllImport(Library, EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
			internal extern static UInt32 glGetSubroutineIndex(UInt32 program, Int32 shadertype, String name);

			[DllImport(Library, EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
			internal extern static Int32 glGetSubroutineUniformLocation(UInt32 program, Int32 shadertype, String name);

			[DllImport(Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
			internal extern static unsafe void glGetSynciv(Int32 sync, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[DllImport(Library, EntryPoint = "glGetSyncivAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGetSyncivAPPLE(Int32 sync, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[DllImport(Library, EntryPoint = "glGetTexBumpParameterfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetTexBumpParameterfvATI(Int32 pname, float* param);

			[DllImport(Library, EntryPoint = "glGetTexBumpParameterivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetTexBumpParameterivATI(Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexEnvxv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTexEnvxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTexFilterFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetTexFilterFuncSGIS(Int32 target, Int32 filter, float* weights);

			[DllImport(Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGendv(Int32 coord, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenfv(Int32 coord, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTexGenfvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexGenivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexGenxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTexImage(Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameterfv(Int32 target, Int32 level, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameteriv(Int32 target, Int32 level, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexLevelParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameterxvOES(Int32 target, Int32 level, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterIiv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterIivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterIivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterIivOES(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterIuiv(Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterIuivEXT(Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterIuivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterIuivOES(Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterPointervAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterPointervAPPLE(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTexParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glGetTextureHandleARB", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureHandleARB(UInt32 texture);

			[DllImport(Library, EntryPoint = "glGetTextureHandleNV", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureHandleNV(UInt32 texture);

			[DllImport(Library, EntryPoint = "glGetTextureImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureImage(UInt32 texture, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetTextureImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureImageEXT(UInt32 texture, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetTextureLevelParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameterfv(UInt32 texture, Int32 level, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTextureLevelParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameterfvEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTextureLevelParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameteriv(UInt32 texture, Int32 level, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureLevelParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameterivEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterfv(UInt32 texture, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameteriv(UInt32 texture, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTextureSamplerHandleARB", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);

			[DllImport(Library, EntryPoint = "glGetTextureSamplerHandleNV", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler);

			[DllImport(Library, EntryPoint = "glGetTextureSubImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetTrackMatrixivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetTrackMatrixivNV(Int32 target, UInt32 address, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetTransformFeedbackVaryingEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbackVaryingEXT(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			[DllImport(Library, EntryPoint = "glGetTransformFeedbackVaryingNV", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, Int32* location);

			[DllImport(Library, EntryPoint = "glGetTransformFeedbacki64_v", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbacki64_v(UInt32 xfb, Int32 pname, UInt32 index, Int64* param);

			[DllImport(Library, EntryPoint = "glGetTransformFeedbacki_v", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbacki_v(UInt32 xfb, Int32 pname, UInt32 index, Int32* param);

			[DllImport(Library, EntryPoint = "glGetTransformFeedbackiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbackiv(UInt32 xfb, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetTranslatedShaderSourceANGLE", ExactSpelling = true)]
			internal extern static unsafe void glGetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, Int32* length, String source);

			[DllImport(Library, EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
			internal extern static UInt32 glGetUniformBlockIndex(UInt32 program, String uniformBlockName);

			[DllImport(Library, EntryPoint = "glGetUniformBufferSizeEXT", ExactSpelling = true)]
			internal extern static Int32 glGetUniformBufferSizeEXT(UInt32 program, Int32 location);

			[DllImport(Library, EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, UInt32* uniformIndices);

			[DllImport(Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
			internal extern static Int32 glGetUniformLocation(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetUniformLocationARB", ExactSpelling = true)]
			internal extern static Int32 glGetUniformLocationARB(UInt32 programObj, String name);

			[DllImport(Library, EntryPoint = "glGetUniformOffsetEXT", ExactSpelling = true)]
			internal extern static IntPtr glGetUniformOffsetEXT(UInt32 program, Int32 location);

			[DllImport(Library, EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformSubroutineuiv(Int32 shadertype, Int32 location, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetUniformdv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformdv(UInt32 program, Int32 location, double* @params);

			[DllImport(Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformfv(UInt32 program, Int32 location, float* @params);

			[DllImport(Library, EntryPoint = "glGetUniformfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformfvARB(UInt32 programObj, Int32 location, float* @params);

			[DllImport(Library, EntryPoint = "glGetUniformi64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformi64vARB(UInt32 program, Int32 location, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetUniformi64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformi64vNV(UInt32 program, Int32 location, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformiv(UInt32 program, Int32 location, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetUniformivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformivARB(UInt32 programObj, Int32 location, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetUniformui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformui64vARB(UInt32 program, Int32 location, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetUniformui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformui64vNV(UInt32 program, Int32 location, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformuiv(UInt32 program, Int32 location, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetUniformuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformuivEXT(UInt32 program, Int32 location, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetVariantArrayObjectfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetVariantArrayObjectfvATI(UInt32 id, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetVariantArrayObjectivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetVariantArrayObjectivATI(UInt32 id, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVariantBooleanvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVariantBooleanvEXT(UInt32 id, Int32 value, bool* data);

			[DllImport(Library, EntryPoint = "glGetVariantFloatvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVariantFloatvEXT(UInt32 id, Int32 value, float* data);

			[DllImport(Library, EntryPoint = "glGetVariantIntegervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVariantIntegervEXT(UInt32 id, Int32 value, Int32* data);

			[DllImport(Library, EntryPoint = "glGetVariantPointervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVariantPointervEXT(UInt32 id, Int32 value, IntPtr* data);

			[DllImport(Library, EntryPoint = "glGetVaryingLocationNV", ExactSpelling = true)]
			internal extern static Int32 glGetVaryingLocationNV(UInt32 program, String name);

			[DllImport(Library, EntryPoint = "glGetVertexArrayIndexed64iv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, Int32 pname, Int64* param);

			[DllImport(Library, EntryPoint = "glGetVertexArrayIndexediv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetVertexArrayIntegeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIntegeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetVertexArrayIntegervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIntegervEXT(UInt32 vaobj, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetVertexArrayPointeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayPointeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glGetVertexArrayPointervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayPointervEXT(UInt32 vaobj, Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glGetVertexArrayiv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayiv(UInt32 vaobj, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glGetVertexAttribArrayObjectfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribArrayObjectfvATI(UInt32 index, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribArrayObjectivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribArrayObjectivATI(UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribIiv(UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribIivEXT(UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribIuiv(UInt32 index, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribIuivEXT(UInt32 index, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLdv(UInt32 index, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribLdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLdvEXT(UInt32 index, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribLi64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLi64vNV(UInt32 index, Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribLui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLui64vARB(UInt32 index, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribLui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLui64vNV(UInt32 index, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribPointerv(UInt32 index, Int32 pname, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glGetVertexAttribPointervARB", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribPointervARB(UInt32 index, Int32 pname, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glGetVertexAttribPointervNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribPointervNV(UInt32 index, Int32 pname, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribdv(UInt32 index, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribdvARB(UInt32 index, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribdvNV(UInt32 index, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribfv(UInt32 index, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribfvARB(UInt32 index, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribfvNV(UInt32 index, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribiv(UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribivARB(UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVertexAttribivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribivNV(UInt32 index, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVideoCaptureStreamdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glGetVideoCaptureStreamfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glGetVideoCaptureStreamivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVideoCaptureivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoCaptureivNV(UInt32 video_capture_slot, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVideoi64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoi64vNV(UInt32 video_slot, Int32 pname, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetVideoivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoivNV(UInt32 video_slot, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetVideoui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoui64vNV(UInt32 video_slot, Int32 pname, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetVideouivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideouivNV(UInt32 video_slot, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetnColorTable", ExactSpelling = true)]
			internal extern static unsafe void glGetnColorTable(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[DllImport(Library, EntryPoint = "glGetnColorTableARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnColorTableARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[DllImport(Library, EntryPoint = "glGetnCompressedTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetnCompressedTexImage(Int32 target, Int32 lod, Int32 bufSize, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetnCompressedTexImageARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnCompressedTexImageARB(Int32 target, Int32 lod, Int32 bufSize, IntPtr img);

			[DllImport(Library, EntryPoint = "glGetnConvolutionFilter", ExactSpelling = true)]
			internal extern static unsafe void glGetnConvolutionFilter(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[DllImport(Library, EntryPoint = "glGetnConvolutionFilterARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnConvolutionFilterARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[DllImport(Library, EntryPoint = "glGetnHistogram", ExactSpelling = true)]
			internal extern static unsafe void glGetnHistogram(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetnHistogramARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnHistogramARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetnMapdv", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapdv(Int32 target, Int32 query, Int32 bufSize, double* v);

			[DllImport(Library, EntryPoint = "glGetnMapdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapdvARB(Int32 target, Int32 query, Int32 bufSize, double* v);

			[DllImport(Library, EntryPoint = "glGetnMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapfv(Int32 target, Int32 query, Int32 bufSize, float* v);

			[DllImport(Library, EntryPoint = "glGetnMapfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapfvARB(Int32 target, Int32 query, Int32 bufSize, float* v);

			[DllImport(Library, EntryPoint = "glGetnMapiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapiv(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[DllImport(Library, EntryPoint = "glGetnMapivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapivARB(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[DllImport(Library, EntryPoint = "glGetnMinmax", ExactSpelling = true)]
			internal extern static unsafe void glGetnMinmax(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetnMinmaxARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnMinmaxARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[DllImport(Library, EntryPoint = "glGetnPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapfv(Int32 map, Int32 bufSize, float* values);

			[DllImport(Library, EntryPoint = "glGetnPixelMapfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapfvARB(Int32 map, Int32 bufSize, float* values);

			[DllImport(Library, EntryPoint = "glGetnPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapuiv(Int32 map, Int32 bufSize, UInt32* values);

			[DllImport(Library, EntryPoint = "glGetnPixelMapuivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapuivARB(Int32 map, Int32 bufSize, UInt32* values);

			[DllImport(Library, EntryPoint = "glGetnPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapusv(Int32 map, Int32 bufSize, UInt16* values);

			[DllImport(Library, EntryPoint = "glGetnPixelMapusvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapusvARB(Int32 map, Int32 bufSize, UInt16* values);

			[DllImport(Library, EntryPoint = "glGetnPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glGetnPolygonStipple(Int32 bufSize, byte* pattern);

			[DllImport(Library, EntryPoint = "glGetnPolygonStippleARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnPolygonStippleARB(Int32 bufSize, byte* pattern);

			[DllImport(Library, EntryPoint = "glGetnSeparableFilter", ExactSpelling = true)]
			internal extern static unsafe void glGetnSeparableFilter(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[DllImport(Library, EntryPoint = "glGetnSeparableFilterARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnSeparableFilterARB(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[DllImport(Library, EntryPoint = "glGetnTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetnTexImage(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glGetnTexImageARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnTexImageARB(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr img);

			[DllImport(Library, EntryPoint = "glGetnUniformdv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformfv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformfvKHR", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfvKHR(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformi64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformi64vARB(UInt32 program, Int32 location, Int32 bufSize, Int64* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformivKHR", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformivKHR(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformui64vARB(UInt32 program, Int32 location, Int32 bufSize, UInt64* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformuivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGetnUniformuivKHR", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformuivKHR(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorbSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorbSUN(sbyte factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactordSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactordSUN(double factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorfSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorfSUN(float factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactoriSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactoriSUN(Int32 factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorsSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorsSUN(Int16 factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorubSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorubSUN(byte factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactoruiSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactoruiSUN(UInt32 factor);

			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorusSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorusSUN(UInt16 factor);

			[DllImport(Library, EntryPoint = "glHint", ExactSpelling = true)]
			internal extern static void glHint(Int32 target, Int32 mode);

			[DllImport(Library, EntryPoint = "glHintPGI", ExactSpelling = true)]
			internal extern static void glHintPGI(Int32 target, Int32 mode);

			[DllImport(Library, EntryPoint = "glHistogram", ExactSpelling = true)]
			internal extern static void glHistogram(Int32 target, Int32 width, Int32 internalformat, bool sink);

			[DllImport(Library, EntryPoint = "glHistogramEXT", ExactSpelling = true)]
			internal extern static void glHistogramEXT(Int32 target, Int32 width, Int32 internalformat, bool sink);

			[DllImport(Library, EntryPoint = "glIglooInterfaceSGIX", ExactSpelling = true)]
			internal extern static unsafe void glIglooInterfaceSGIX(Int32 pname, IntPtr @params);

			[DllImport(Library, EntryPoint = "glImageTransformParameterfHP", ExactSpelling = true)]
			internal extern static void glImageTransformParameterfHP(Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glImageTransformParameterfvHP", ExactSpelling = true)]
			internal extern static unsafe void glImageTransformParameterfvHP(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glImageTransformParameteriHP", ExactSpelling = true)]
			internal extern static void glImageTransformParameteriHP(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glImageTransformParameterivHP", ExactSpelling = true)]
			internal extern static unsafe void glImageTransformParameterivHP(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glImportSyncEXT", ExactSpelling = true)]
			internal extern static unsafe Int32 glImportSyncEXT(Int32 external_sync_type, IntPtr external_sync, UInt32 flags);

			[DllImport(Library, EntryPoint = "glIndexFormatNV", ExactSpelling = true)]
			internal extern static void glIndexFormatNV(Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glIndexFuncEXT", ExactSpelling = true)]
			internal extern static void glIndexFuncEXT(Int32 func, float @ref);

			[DllImport(Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
			internal extern static void glIndexMask(UInt32 mask);

			[DllImport(Library, EntryPoint = "glIndexMaterialEXT", ExactSpelling = true)]
			internal extern static void glIndexMaterialEXT(Int32 face, Int32 mode);

			[DllImport(Library, EntryPoint = "glIndexPointer", ExactSpelling = true)]
			internal extern static unsafe void glIndexPointer(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glIndexPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glIndexPointerEXT(Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glIndexPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glIndexPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glIndexd", ExactSpelling = true)]
			internal extern static void glIndexd(double c);

			[DllImport(Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
			internal extern static unsafe void glIndexdv(double* c);

			[DllImport(Library, EntryPoint = "glIndexf", ExactSpelling = true)]
			internal extern static void glIndexf(float c);

			[DllImport(Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
			internal extern static unsafe void glIndexfv(float* c);

			[DllImport(Library, EntryPoint = "glIndexi", ExactSpelling = true)]
			internal extern static void glIndexi(Int32 c);

			[DllImport(Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
			internal extern static unsafe void glIndexiv(Int32* c);

			[DllImport(Library, EntryPoint = "glIndexs", ExactSpelling = true)]
			internal extern static void glIndexs(Int16 c);

			[DllImport(Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
			internal extern static unsafe void glIndexsv(Int16* c);

			[DllImport(Library, EntryPoint = "glIndexub", ExactSpelling = true)]
			internal extern static void glIndexub(byte c);

			[DllImport(Library, EntryPoint = "glIndexubv", ExactSpelling = true)]
			internal extern static unsafe void glIndexubv(byte* c);

			[DllImport(Library, EntryPoint = "glIndexxOES", ExactSpelling = true)]
			internal extern static unsafe void glIndexxOES(IntPtr component);

			[DllImport(Library, EntryPoint = "glIndexxvOES", ExactSpelling = true)]
			internal extern static unsafe void glIndexxvOES(IntPtr* component);

			[DllImport(Library, EntryPoint = "glInitNames", ExactSpelling = true)]
			internal extern static void glInitNames();

			[DllImport(Library, EntryPoint = "glInsertComponentEXT", ExactSpelling = true)]
			internal extern static void glInsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);

			[DllImport(Library, EntryPoint = "glInsertEventMarkerEXT", ExactSpelling = true)]
			internal extern static void glInsertEventMarkerEXT(Int32 length, String marker);

			[DllImport(Library, EntryPoint = "glInstrumentsBufferSGIX", ExactSpelling = true)]
			internal extern static unsafe void glInstrumentsBufferSGIX(Int32 size, Int32* buffer);

			[DllImport(Library, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
			internal extern static unsafe void glInterleavedArrays(Int32 format, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glInterpolatePathsNV", ExactSpelling = true)]
			internal extern static void glInterpolatePathsNV(UInt32 resultPath, UInt32 pathA, UInt32 pathB, float weight);

			[DllImport(Library, EntryPoint = "glInvalidateBufferData", ExactSpelling = true)]
			internal extern static void glInvalidateBufferData(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glInvalidateBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateBufferSubData(UInt32 buffer, IntPtr offset, UInt32 length);

			[DllImport(Library, EntryPoint = "glInvalidateFramebuffer", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateFramebuffer(Int32 target, Int32 numAttachments, Int32* attachments);

			[DllImport(Library, EntryPoint = "glInvalidateNamedFramebufferData", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments);

			[DllImport(Library, EntryPoint = "glInvalidateNamedFramebufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glInvalidateSubFramebuffer", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateSubFramebuffer(Int32 target, Int32 numAttachments, Int32* attachments, Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glInvalidateTexImage", ExactSpelling = true)]
			internal extern static void glInvalidateTexImage(UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glInvalidateTexSubImage", ExactSpelling = true)]
			internal extern static void glInvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);

			[DllImport(Library, EntryPoint = "glIsAsyncMarkerSGIX", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsAsyncMarkerSGIX(UInt32 marker);

			[DllImport(Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsBuffer(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glIsBufferARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsBufferARB(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glIsBufferResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsBufferResidentNV(Int32 target);

			[DllImport(Library, EntryPoint = "glIsCommandListNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsCommandListNV(UInt32 list);

			[DllImport(Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnabled(Int32 cap);

			[DllImport(Library, EntryPoint = "glIsEnabledIndexedEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnabledIndexedEXT(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glIsEnabledi", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnabledi(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glIsEnablediEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnablediEXT(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glIsEnablediNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnablediNV(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glIsEnablediOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnablediOES(Int32 target, UInt32 index);

			[DllImport(Library, EntryPoint = "glIsFenceAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFenceAPPLE(UInt32 fence);

			[DllImport(Library, EntryPoint = "glIsFenceNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFenceNV(UInt32 fence);

			[DllImport(Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFramebuffer(UInt32 framebuffer);

			[DllImport(Library, EntryPoint = "glIsFramebufferEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFramebufferEXT(UInt32 framebuffer);

			[DllImport(Library, EntryPoint = "glIsFramebufferOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFramebufferOES(UInt32 framebuffer);

			[DllImport(Library, EntryPoint = "glIsImageHandleResidentARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsImageHandleResidentARB(UInt64 handle);

			[DllImport(Library, EntryPoint = "glIsImageHandleResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsImageHandleResidentNV(UInt64 handle);

			[DllImport(Library, EntryPoint = "glIsList", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsList(UInt32 list);

			[DllImport(Library, EntryPoint = "glIsNameAMD", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsNameAMD(Int32 identifier, UInt32 name);

			[DllImport(Library, EntryPoint = "glIsNamedBufferResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsNamedBufferResidentNV(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glIsNamedStringARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsNamedStringARB(Int32 namelen, String name);

			[DllImport(Library, EntryPoint = "glIsObjectBufferATI", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsObjectBufferATI(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glIsOcclusionQueryNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsOcclusionQueryNV(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsPathNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsPathNV(UInt32 path);

			[DllImport(Library, EntryPoint = "glIsPointInFillPathNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsPointInFillPathNV(UInt32 path, UInt32 mask, float x, float y);

			[DllImport(Library, EntryPoint = "glIsPointInStrokePathNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsPointInStrokePathNV(UInt32 path, float x, float y);

			[DllImport(Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsProgram(UInt32 program);

			[DllImport(Library, EntryPoint = "glIsProgramARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsProgramARB(UInt32 program);

			[DllImport(Library, EntryPoint = "glIsProgramNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsProgramNV(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsProgramPipeline(UInt32 pipeline);

			[DllImport(Library, EntryPoint = "glIsProgramPipelineEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsProgramPipelineEXT(UInt32 pipeline);

			[DllImport(Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsQuery(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsQueryARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsQueryARB(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsQueryEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsQueryEXT(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsRenderbuffer(UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glIsRenderbufferEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsRenderbufferEXT(UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glIsRenderbufferOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsRenderbufferOES(UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsSampler(UInt32 sampler);

			[DllImport(Library, EntryPoint = "glIsShader", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsShader(UInt32 shader);

			[DllImport(Library, EntryPoint = "glIsStateNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsStateNV(UInt32 state);

			[DllImport(Library, EntryPoint = "glIsSync", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsSync(Int32 sync);

			[DllImport(Library, EntryPoint = "glIsSyncAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsSyncAPPLE(Int32 sync);

			[DllImport(Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTexture(UInt32 texture);

			[DllImport(Library, EntryPoint = "glIsTextureEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTextureEXT(UInt32 texture);

			[DllImport(Library, EntryPoint = "glIsTextureHandleResidentARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTextureHandleResidentARB(UInt64 handle);

			[DllImport(Library, EntryPoint = "glIsTextureHandleResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTextureHandleResidentNV(UInt64 handle);

			[DllImport(Library, EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTransformFeedback(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsTransformFeedbackNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTransformFeedbackNV(UInt32 id);

			[DllImport(Library, EntryPoint = "glIsVariantEnabledEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsVariantEnabledEXT(UInt32 id, Int32 cap);

			[DllImport(Library, EntryPoint = "glIsVertexArray", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsVertexArray(UInt32 array);

			[DllImport(Library, EntryPoint = "glIsVertexArrayAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsVertexArrayAPPLE(UInt32 array);

			[DllImport(Library, EntryPoint = "glIsVertexArrayOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsVertexArrayOES(UInt32 array);

			[DllImport(Library, EntryPoint = "glIsVertexAttribEnabledAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsVertexAttribEnabledAPPLE(UInt32 index, Int32 pname);

			[DllImport(Library, EntryPoint = "glLabelObjectEXT", ExactSpelling = true)]
			internal extern static void glLabelObjectEXT(Int32 type, UInt32 @object, Int32 length, String label);

			[DllImport(Library, EntryPoint = "glLightEnviSGIX", ExactSpelling = true)]
			internal extern static void glLightEnviSGIX(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
			internal extern static void glLightModelf(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
			internal extern static unsafe void glLightModelfv(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
			internal extern static void glLightModeli(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
			internal extern static unsafe void glLightModeliv(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glLightModelx", ExactSpelling = true)]
			internal extern static unsafe void glLightModelx(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glLightModelxOES", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxOES(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glLightModelxv", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxv(Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glLightModelxvOES", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxvOES(Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glLightf", ExactSpelling = true)]
			internal extern static void glLightf(Int32 light, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glLightfv", ExactSpelling = true)]
			internal extern static unsafe void glLightfv(Int32 light, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glLighti", ExactSpelling = true)]
			internal extern static void glLighti(Int32 light, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glLightiv", ExactSpelling = true)]
			internal extern static unsafe void glLightiv(Int32 light, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glLightx", ExactSpelling = true)]
			internal extern static unsafe void glLightx(Int32 light, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glLightxOES", ExactSpelling = true)]
			internal extern static unsafe void glLightxOES(Int32 light, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glLightxv", ExactSpelling = true)]
			internal extern static unsafe void glLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glLightxvOES", ExactSpelling = true)]
			internal extern static unsafe void glLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
			internal extern static void glLineStipple(Int32 factor, UInt16 pattern);

			[DllImport(Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
			internal extern static void glLineWidth(float width);

			[DllImport(Library, EntryPoint = "glLineWidthx", ExactSpelling = true)]
			internal extern static unsafe void glLineWidthx(IntPtr width);

			[DllImport(Library, EntryPoint = "glLineWidthxOES", ExactSpelling = true)]
			internal extern static unsafe void glLineWidthxOES(IntPtr width);

			[DllImport(Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
			internal extern static void glLinkProgram(UInt32 program);

			[DllImport(Library, EntryPoint = "glLinkProgramARB", ExactSpelling = true)]
			internal extern static void glLinkProgramARB(UInt32 programObj);

			[DllImport(Library, EntryPoint = "glListBase", ExactSpelling = true)]
			internal extern static void glListBase(UInt32 @base);

			[DllImport(Library, EntryPoint = "glListDrawCommandsStatesClientNV", ExactSpelling = true)]
			internal extern static unsafe void glListDrawCommandsStatesClientNV(UInt32 list, UInt32 segment, IntPtr* indirects, Int32* sizes, UInt32* states, UInt32* fbos, UInt32 count);

			[DllImport(Library, EntryPoint = "glListParameterfSGIX", ExactSpelling = true)]
			internal extern static void glListParameterfSGIX(UInt32 list, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glListParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glListParameteriSGIX", ExactSpelling = true)]
			internal extern static void glListParameteriSGIX(UInt32 list, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glListParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
			internal extern static void glLoadIdentity();

			[DllImport(Library, EntryPoint = "glLoadIdentityDeformationMapSGIX", ExactSpelling = true)]
			internal extern static void glLoadIdentityDeformationMapSGIX(UInt32 mask);

			[DllImport(Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixd(double* m);

			[DllImport(Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixf(float* m);

			[DllImport(Library, EntryPoint = "glLoadMatrixx", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixx(IntPtr* m);

			[DllImport(Library, EntryPoint = "glLoadMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixxOES(IntPtr* m);

			[DllImport(Library, EntryPoint = "glLoadName", ExactSpelling = true)]
			internal extern static void glLoadName(UInt32 name);

			[DllImport(Library, EntryPoint = "glLoadPaletteFromModelViewMatrixOES", ExactSpelling = true)]
			internal extern static void glLoadPaletteFromModelViewMatrixOES();

			[DllImport(Library, EntryPoint = "glLoadProgramNV", ExactSpelling = true)]
			internal extern static unsafe void glLoadProgramNV(Int32 target, UInt32 id, Int32 len, byte* program);

			[DllImport(Library, EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glLoadTransposeMatrixd(double* m);

			[DllImport(Library, EntryPoint = "glLoadTransposeMatrixdARB", ExactSpelling = true)]
			internal extern static unsafe void glLoadTransposeMatrixdARB(double* m);

			[DllImport(Library, EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glLoadTransposeMatrixf(float* m);

			[DllImport(Library, EntryPoint = "glLoadTransposeMatrixfARB", ExactSpelling = true)]
			internal extern static unsafe void glLoadTransposeMatrixfARB(float* m);

			[DllImport(Library, EntryPoint = "glLoadTransposeMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glLoadTransposeMatrixxOES(IntPtr* m);

			[DllImport(Library, EntryPoint = "glLockArraysEXT", ExactSpelling = true)]
			internal extern static void glLockArraysEXT(Int32 first, Int32 count);

			[DllImport(Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
			internal extern static void glLogicOp(Int32 opcode);

			[DllImport(Library, EntryPoint = "glMakeBufferNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeBufferNonResidentNV(Int32 target);

			[DllImport(Library, EntryPoint = "glMakeBufferResidentNV", ExactSpelling = true)]
			internal extern static void glMakeBufferResidentNV(Int32 target, Int32 access);

			[DllImport(Library, EntryPoint = "glMakeImageHandleNonResidentARB", ExactSpelling = true)]
			internal extern static void glMakeImageHandleNonResidentARB(UInt64 handle);

			[DllImport(Library, EntryPoint = "glMakeImageHandleNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeImageHandleNonResidentNV(UInt64 handle);

			[DllImport(Library, EntryPoint = "glMakeImageHandleResidentARB", ExactSpelling = true)]
			internal extern static void glMakeImageHandleResidentARB(UInt64 handle, Int32 access);

			[DllImport(Library, EntryPoint = "glMakeImageHandleResidentNV", ExactSpelling = true)]
			internal extern static void glMakeImageHandleResidentNV(UInt64 handle, Int32 access);

			[DllImport(Library, EntryPoint = "glMakeNamedBufferNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeNamedBufferNonResidentNV(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glMakeNamedBufferResidentNV", ExactSpelling = true)]
			internal extern static void glMakeNamedBufferResidentNV(UInt32 buffer, Int32 access);

			[DllImport(Library, EntryPoint = "glMakeTextureHandleNonResidentARB", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleNonResidentARB(UInt64 handle);

			[DllImport(Library, EntryPoint = "glMakeTextureHandleNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleNonResidentNV(UInt64 handle);

			[DllImport(Library, EntryPoint = "glMakeTextureHandleResidentARB", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleResidentARB(UInt64 handle);

			[DllImport(Library, EntryPoint = "glMakeTextureHandleResidentNV", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleResidentNV(UInt64 handle);

			[DllImport(Library, EntryPoint = "glMap1d", ExactSpelling = true)]
			internal extern static unsafe void glMap1d(Int32 target, double u1, double u2, Int32 stride, Int32 order, double* points);

			[DllImport(Library, EntryPoint = "glMap1f", ExactSpelling = true)]
			internal extern static unsafe void glMap1f(Int32 target, float u1, float u2, Int32 stride, Int32 order, float* points);

			[DllImport(Library, EntryPoint = "glMap1xOES", ExactSpelling = true)]
			internal extern static unsafe void glMap1xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points);

			[DllImport(Library, EntryPoint = "glMap2d", ExactSpelling = true)]
			internal extern static unsafe void glMap2d(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[DllImport(Library, EntryPoint = "glMap2f", ExactSpelling = true)]
			internal extern static unsafe void glMap2f(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[DllImport(Library, EntryPoint = "glMap2xOES", ExactSpelling = true)]
			internal extern static unsafe void glMap2xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points);

			[DllImport(Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
			internal extern static IntPtr glMapBuffer(Int32 target, Int32 access);

			[DllImport(Library, EntryPoint = "glMapBufferARB", ExactSpelling = true)]
			internal extern static IntPtr glMapBufferARB(Int32 target, Int32 access);

			[DllImport(Library, EntryPoint = "glMapBufferOES", ExactSpelling = true)]
			internal extern static IntPtr glMapBufferOES(Int32 target, Int32 access);

			[DllImport(Library, EntryPoint = "glMapBufferRange", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapBufferRange(Int32 target, IntPtr offset, UInt32 length, UInt32 access);

			[DllImport(Library, EntryPoint = "glMapBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapBufferRangeEXT(Int32 target, IntPtr offset, UInt32 length, UInt32 access);

			[DllImport(Library, EntryPoint = "glMapControlPointsNV", ExactSpelling = true)]
			internal extern static unsafe void glMapControlPointsNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, IntPtr points);

			[DllImport(Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
			internal extern static void glMapGrid1d(Int32 un, double u1, double u2);

			[DllImport(Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
			internal extern static void glMapGrid1f(Int32 un, float u1, float u2);

			[DllImport(Library, EntryPoint = "glMapGrid1xOES", ExactSpelling = true)]
			internal extern static unsafe void glMapGrid1xOES(Int32 n, IntPtr u1, IntPtr u2);

			[DllImport(Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
			internal extern static void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);

			[DllImport(Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
			internal extern static void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);

			[DllImport(Library, EntryPoint = "glMapGrid2xOES", ExactSpelling = true)]
			internal extern static unsafe void glMapGrid2xOES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2);

			[DllImport(Library, EntryPoint = "glMapNamedBuffer", ExactSpelling = true)]
			internal extern static IntPtr glMapNamedBuffer(UInt32 buffer, Int32 access);

			[DllImport(Library, EntryPoint = "glMapNamedBufferEXT", ExactSpelling = true)]
			internal extern static IntPtr glMapNamedBufferEXT(UInt32 buffer, Int32 access);

			[DllImport(Library, EntryPoint = "glMapNamedBufferRange", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[DllImport(Library, EntryPoint = "glMapNamedBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[DllImport(Library, EntryPoint = "glMapObjectBufferATI", ExactSpelling = true)]
			internal extern static IntPtr glMapObjectBufferATI(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glMapParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glMapParameterfvNV(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glMapParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glMapParameterivNV(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glMapTexture2DINTEL", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32* stride, Int32* layout);

			[DllImport(Library, EntryPoint = "glMapVertexAttrib1dAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glMapVertexAttrib1dAPPLE(UInt32 index, UInt32 size, double u1, double u2, Int32 stride, Int32 order, double* points);

			[DllImport(Library, EntryPoint = "glMapVertexAttrib1fAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glMapVertexAttrib1fAPPLE(UInt32 index, UInt32 size, float u1, float u2, Int32 stride, Int32 order, float* points);

			[DllImport(Library, EntryPoint = "glMapVertexAttrib2dAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glMapVertexAttrib2dAPPLE(UInt32 index, UInt32 size, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[DllImport(Library, EntryPoint = "glMapVertexAttrib2fAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glMapVertexAttrib2fAPPLE(UInt32 index, UInt32 size, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[DllImport(Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
			internal extern static void glMaterialf(Int32 face, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialfv(Int32 face, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glMateriali", ExactSpelling = true)]
			internal extern static void glMateriali(Int32 face, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glMaterialx", ExactSpelling = true)]
			internal extern static unsafe void glMaterialx(Int32 face, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glMaterialxOES", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glMaterialxv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxv(Int32 face, Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glMaterialxvOES", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxvOES(Int32 face, Int32 pname, IntPtr* param);

			[DllImport(Library, EntryPoint = "glMatrixFrustumEXT", ExactSpelling = true)]
			internal extern static void glMatrixFrustumEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[DllImport(Library, EntryPoint = "glMatrixIndexPointerARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glMatrixIndexPointerOES", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glMatrixIndexubvARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexubvARB(Int32 size, byte* indices);

			[DllImport(Library, EntryPoint = "glMatrixIndexuivARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexuivARB(Int32 size, UInt32* indices);

			[DllImport(Library, EntryPoint = "glMatrixIndexusvARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexusvARB(Int32 size, UInt16* indices);

			[DllImport(Library, EntryPoint = "glMatrixLoad3x2fNV", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoad3x2fNV(Int32 matrixMode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixLoad3x3fNV", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoad3x3fNV(Int32 matrixMode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixLoadIdentityEXT", ExactSpelling = true)]
			internal extern static void glMatrixLoadIdentityEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glMatrixLoadTranspose3x3fNV", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadTranspose3x3fNV(Int32 matrixMode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixLoadTransposedEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadTransposedEXT(Int32 mode, double* m);

			[DllImport(Library, EntryPoint = "glMatrixLoadTransposefEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadTransposefEXT(Int32 mode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixLoaddEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoaddEXT(Int32 mode, double* m);

			[DllImport(Library, EntryPoint = "glMatrixLoadfEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadfEXT(Int32 mode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
			internal extern static void glMatrixMode(Int32 mode);

			[DllImport(Library, EntryPoint = "glMatrixMult3x2fNV", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMult3x2fNV(Int32 matrixMode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixMult3x3fNV", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMult3x3fNV(Int32 matrixMode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixMultTranspose3x3fNV", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultTranspose3x3fNV(Int32 matrixMode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixMultTransposedEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultTransposedEXT(Int32 mode, double* m);

			[DllImport(Library, EntryPoint = "glMatrixMultTransposefEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultTransposefEXT(Int32 mode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixMultdEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultdEXT(Int32 mode, double* m);

			[DllImport(Library, EntryPoint = "glMatrixMultfEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultfEXT(Int32 mode, float* m);

			[DllImport(Library, EntryPoint = "glMatrixOrthoEXT", ExactSpelling = true)]
			internal extern static void glMatrixOrthoEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[DllImport(Library, EntryPoint = "glMatrixPopEXT", ExactSpelling = true)]
			internal extern static void glMatrixPopEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glMatrixPushEXT", ExactSpelling = true)]
			internal extern static void glMatrixPushEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glMatrixRotatedEXT", ExactSpelling = true)]
			internal extern static void glMatrixRotatedEXT(Int32 mode, double angle, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glMatrixRotatefEXT", ExactSpelling = true)]
			internal extern static void glMatrixRotatefEXT(Int32 mode, float angle, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glMatrixScaledEXT", ExactSpelling = true)]
			internal extern static void glMatrixScaledEXT(Int32 mode, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glMatrixScalefEXT", ExactSpelling = true)]
			internal extern static void glMatrixScalefEXT(Int32 mode, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glMatrixTranslatedEXT", ExactSpelling = true)]
			internal extern static void glMatrixTranslatedEXT(Int32 mode, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glMatrixTranslatefEXT", ExactSpelling = true)]
			internal extern static void glMatrixTranslatefEXT(Int32 mode, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glMaxShaderCompilerThreadsARB", ExactSpelling = true)]
			internal extern static void glMaxShaderCompilerThreadsARB(UInt32 count);

			[DllImport(Library, EntryPoint = "glMemoryBarrier", ExactSpelling = true)]
			internal extern static void glMemoryBarrier(UInt32 barriers);

			[DllImport(Library, EntryPoint = "glMemoryBarrierByRegion", ExactSpelling = true)]
			internal extern static void glMemoryBarrierByRegion(UInt32 barriers);

			[DllImport(Library, EntryPoint = "glMemoryBarrierEXT", ExactSpelling = true)]
			internal extern static void glMemoryBarrierEXT(UInt32 barriers);

			[DllImport(Library, EntryPoint = "glMinSampleShading", ExactSpelling = true)]
			internal extern static void glMinSampleShading(float value);

			[DllImport(Library, EntryPoint = "glMinSampleShadingARB", ExactSpelling = true)]
			internal extern static void glMinSampleShadingARB(float value);

			[DllImport(Library, EntryPoint = "glMinSampleShadingOES", ExactSpelling = true)]
			internal extern static void glMinSampleShadingOES(float value);

			[DllImport(Library, EntryPoint = "glMinmax", ExactSpelling = true)]
			internal extern static void glMinmax(Int32 target, Int32 internalformat, bool sink);

			[DllImport(Library, EntryPoint = "glMinmaxEXT", ExactSpelling = true)]
			internal extern static void glMinmaxEXT(Int32 target, Int32 internalformat, bool sink);

			[DllImport(Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixd(double* m);

			[DllImport(Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixf(float* m);

			[DllImport(Library, EntryPoint = "glMultMatrixx", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixx(IntPtr* m);

			[DllImport(Library, EntryPoint = "glMultMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixxOES(IntPtr* m);

			[DllImport(Library, EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glMultTransposeMatrixd(double* m);

			[DllImport(Library, EntryPoint = "glMultTransposeMatrixdARB", ExactSpelling = true)]
			internal extern static unsafe void glMultTransposeMatrixdARB(double* m);

			[DllImport(Library, EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glMultTransposeMatrixf(float* m);

			[DllImport(Library, EntryPoint = "glMultTransposeMatrixfARB", ExactSpelling = true)]
			internal extern static unsafe void glMultTransposeMatrixfARB(float* m);

			[DllImport(Library, EntryPoint = "glMultTransposeMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glMultTransposeMatrixxOES(IntPtr* m);

			[DllImport(Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArrays(Int32 mode, Int32* first, Int32* count, Int32 drawcount);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysEXT(Int32 mode, Int32* first, Int32* count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirect", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirect(Int32 mode, IntPtr indirect, Int32 drawcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectAMD", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectAMD(Int32 mode, IntPtr indirect, Int32 primcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectBindlessCountNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectBindlessNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectBindlessNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectCountARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectCountARB(Int32 mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectEXT(Int32 mode, IntPtr indirect, Int32 drawcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawElementArrayAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementArrayAPPLE(Int32 mode, Int32* first, Int32* count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElements(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsBaseVertex(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount, Int32* basevertex);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsBaseVertexEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsBaseVertexEXT(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32* basevertex);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsBaseVertexOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsBaseVertexOES(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32* basevertex);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsEXT(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirect", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirect(Int32 mode, Int32 type, IntPtr indirect, Int32 drawcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectAMD", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectAMD(Int32 mode, Int32 type, IntPtr indirect, Int32 primcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectBindlessCountNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectBindlessNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectBindlessNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectCountARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectCountARB(Int32 mode, Int32 type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectEXT(Int32 mode, Int32 type, IntPtr indirect, Int32 drawcount, Int32 stride);

			[DllImport(Library, EntryPoint = "glMultiDrawRangeElementArrayAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawRangeElementArrayAPPLE(Int32 mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);

			[DllImport(Library, EntryPoint = "glMultiModeDrawArraysIBM", ExactSpelling = true)]
			internal extern static unsafe void glMultiModeDrawArraysIBM(Int32* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);

			[DllImport(Library, EntryPoint = "glMultiModeDrawElementsIBM", ExactSpelling = true)]
			internal extern static unsafe void glMultiModeDrawElementsIBM(Int32* mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32 modestride);

			[DllImport(Library, EntryPoint = "glMultiTexBufferEXT", ExactSpelling = true)]
			internal extern static void glMultiTexBufferEXT(Int32 texunit, Int32 target, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1bOES(Int32 texture, sbyte s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1bvOES(Int32 texture, sbyte* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1d(Int32 target, double s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1dARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1dARB(Int32 target, double s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1dv(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1dvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1dvARB(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1f(Int32 target, float s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1fARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1fARB(Int32 target, float s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1fv(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1fvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1fvARB(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1hNV(Int32 target, UInt16 s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1hvNV(Int32 target, UInt16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1i(Int32 target, Int32 s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1iARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1iARB(Int32 target, Int32 s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1iv(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1ivARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1ivARB(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1s(Int32 target, Int16 s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1sARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1sARB(Int32 target, Int16 s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1sv(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1svARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1svARB(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1xOES(Int32 texture, IntPtr s);

			[DllImport(Library, EntryPoint = "glMultiTexCoord1xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1xvOES(Int32 texture, IntPtr* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2bOES(Int32 texture, sbyte s, sbyte t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2bvOES(Int32 texture, sbyte* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2d(Int32 target, double s, double t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2dARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2dARB(Int32 target, double s, double t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2dv(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2dvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2dvARB(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2f(Int32 target, float s, float t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2fARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2fARB(Int32 target, float s, float t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2fv(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2fvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2fvARB(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2hNV(Int32 target, UInt16 s, UInt16 t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2hvNV(Int32 target, UInt16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2i(Int32 target, Int32 s, Int32 t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2iARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2iARB(Int32 target, Int32 s, Int32 t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2iv(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2ivARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2ivARB(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2s(Int32 target, Int16 s, Int16 t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2sARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2sARB(Int32 target, Int16 s, Int16 t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2sv(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2svARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2svARB(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2xOES(Int32 texture, IntPtr s, IntPtr t);

			[DllImport(Library, EntryPoint = "glMultiTexCoord2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2xvOES(Int32 texture, IntPtr* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3bOES(Int32 texture, sbyte s, sbyte t, sbyte r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3bvOES(Int32 texture, sbyte* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3d(Int32 target, double s, double t, double r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3dARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3dARB(Int32 target, double s, double t, double r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3dv(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3dvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3dvARB(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3f(Int32 target, float s, float t, float r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3fARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3fARB(Int32 target, float s, float t, float r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3fv(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3fvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3fvARB(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3hvNV(Int32 target, UInt16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3i(Int32 target, Int32 s, Int32 t, Int32 r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3iARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3iARB(Int32 target, Int32 s, Int32 t, Int32 r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3iv(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3ivARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3ivARB(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3s(Int32 target, Int16 s, Int16 t, Int16 r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3sARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3sARB(Int32 target, Int16 s, Int16 t, Int16 r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3sv(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3svARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3svARB(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r);

			[DllImport(Library, EntryPoint = "glMultiTexCoord3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3xvOES(Int32 texture, IntPtr* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4bOES(Int32 texture, sbyte s, sbyte t, sbyte r, sbyte q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4bvOES(Int32 texture, sbyte* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4d(Int32 target, double s, double t, double r, double q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4dARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4dARB(Int32 target, double s, double t, double r, double q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4dv(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4dvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4dvARB(Int32 target, double* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4f(Int32 target, float s, float t, float r, float q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4fARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4fARB(Int32 target, float s, float t, float r, float q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4fv(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4fvARB(Int32 target, float* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4hvNV(Int32 target, UInt16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4i(Int32 target, Int32 s, Int32 t, Int32 r, Int32 q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4iARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4iARB(Int32 target, Int32 s, Int32 t, Int32 r, Int32 q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4iv(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4ivARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4ivARB(Int32 target, Int32* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4s(Int32 target, Int16 s, Int16 t, Int16 r, Int16 q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4sARB", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4sARB(Int32 target, Int16 s, Int16 t, Int16 r, Int16 q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4sv(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4svARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4svARB(Int32 target, Int16* v);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4x", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4x(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[DllImport(Library, EntryPoint = "glMultiTexCoord4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4xvOES(Int32 texture, IntPtr* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP1ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP1ui(Int32 texture, Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP1uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP1uiv(Int32 texture, Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP2ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP2ui(Int32 texture, Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP2uiv(Int32 texture, Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP3ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP3ui(Int32 texture, Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP3uiv(Int32 texture, Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP4ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP4ui(Int32 texture, Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP4uiv(Int32 texture, Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glMultiTexCoordPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordPointerEXT(Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glMultiTexEnvfEXT", ExactSpelling = true)]
			internal extern static void glMultiTexEnvfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glMultiTexEnvfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glMultiTexEnviEXT", ExactSpelling = true)]
			internal extern static void glMultiTexEnviEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glMultiTexEnvivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glMultiTexGendEXT", ExactSpelling = true)]
			internal extern static void glMultiTexGendEXT(Int32 texunit, Int32 coord, Int32 pname, double param);

			[DllImport(Library, EntryPoint = "glMultiTexGendvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glMultiTexGenfEXT", ExactSpelling = true)]
			internal extern static void glMultiTexGenfEXT(Int32 texunit, Int32 coord, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glMultiTexGenfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glMultiTexGeniEXT", ExactSpelling = true)]
			internal extern static void glMultiTexGeniEXT(Int32 texunit, Int32 coord, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glMultiTexGenivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glMultiTexImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glMultiTexImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glMultiTexImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glMultiTexParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glMultiTexParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glMultiTexParameterfEXT", ExactSpelling = true)]
			internal extern static void glMultiTexParameterfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glMultiTexParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glMultiTexParameteriEXT", ExactSpelling = true)]
			internal extern static void glMultiTexParameteriEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glMultiTexParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glMultiTexRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glMultiTexRenderbufferEXT(Int32 texunit, Int32 target, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glMultiTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glMultiTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glMultiTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glNamedBufferData", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[DllImport(Library, EntryPoint = "glNamedBufferDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferDataEXT(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[DllImport(Library, EntryPoint = "glNamedBufferPageCommitmentARB", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferPageCommitmentARB(UInt32 buffer, IntPtr offset, UInt32 size, bool commit);

			[DllImport(Library, EntryPoint = "glNamedBufferPageCommitmentEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferPageCommitmentEXT(UInt32 buffer, IntPtr offset, UInt32 size, bool commit);

			[DllImport(Library, EntryPoint = "glNamedBufferStorage", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, UInt32 flags);

			[DllImport(Library, EntryPoint = "glNamedBufferStorageEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferStorageEXT(UInt32 buffer, UInt32 size, IntPtr data, UInt32 flags);

			[DllImport(Library, EntryPoint = "glNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glNamedBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[DllImport(Library, EntryPoint = "glNamedCopyBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[DllImport(Library, EntryPoint = "glNamedFramebufferDrawBuffer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferDrawBuffer(UInt32 framebuffer, Int32 buf);

			[DllImport(Library, EntryPoint = "glNamedFramebufferDrawBuffers", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, Int32* bufs);

			[DllImport(Library, EntryPoint = "glNamedFramebufferParameteri", ExactSpelling = true)]
			internal extern static void glNamedFramebufferParameteri(UInt32 framebuffer, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glNamedFramebufferParameteriEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferParameteriEXT(UInt32 framebuffer, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glNamedFramebufferReadBuffer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferReadBuffer(UInt32 framebuffer, Int32 src);

			[DllImport(Library, EntryPoint = "glNamedFramebufferRenderbuffer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferRenderbuffer(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glNamedFramebufferRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferRenderbufferEXT(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glNamedFramebufferSampleLocationsfvARB", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferSampleLocationsfvARB(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glNamedFramebufferSampleLocationsfvNV", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferSampleLocationsfvNV(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture1DEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture1DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture2DEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture2DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture3DEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture3DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureFaceEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureFaceEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureLayer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureLayer(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureLayerEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureLayerEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4dEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameter4dEXT(UInt32 program, Int32 target, UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameter4dvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4fEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameter4fEXT(UInt32 program, Int32 target, UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameter4fvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4iEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameterI4iEXT(UInt32 program, Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameterI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4uiEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameterI4uiEXT(UInt32 program, Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameterI4uivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameters4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameters4fvEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, float* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParametersI4ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParametersI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, Int32* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramLocalParametersI4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParametersI4uivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[DllImport(Library, EntryPoint = "glNamedProgramStringEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramStringEXT(UInt32 program, Int32 target, Int32 format, Int32 len, IntPtr @string);

			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorage", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorage(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageEXT", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageEXT(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisample", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glNamedStringARB", ExactSpelling = true)]
			internal extern static void glNamedStringARB(Int32 type, Int32 namelen, String name, Int32 stringlen, String @string);

			[DllImport(Library, EntryPoint = "glNewList", ExactSpelling = true)]
			internal extern static void glNewList(UInt32 list, Int32 mode);

			[DllImport(Library, EntryPoint = "glNewObjectBufferATI", ExactSpelling = true)]
			internal extern static unsafe UInt32 glNewObjectBufferATI(Int32 size, IntPtr pointer, Int32 usage);

			[DllImport(Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
			internal extern static void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

			[DllImport(Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3bv(sbyte* v);

			[DllImport(Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
			internal extern static void glNormal3d(double nx, double ny, double nz);

			[DllImport(Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3dv(double* v);

			[DllImport(Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
			internal extern static void glNormal3f(float nx, float ny, float nz);

			[DllImport(Library, EntryPoint = "glNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glNormal3fVertex3fvSUN(float* n, float* v);

			[DllImport(Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3fv(float* v);

			[DllImport(Library, EntryPoint = "glNormal3hNV", ExactSpelling = true)]
			internal extern static void glNormal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);

			[DllImport(Library, EntryPoint = "glNormal3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glNormal3hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
			internal extern static void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

			[DllImport(Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
			internal extern static void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

			[DllImport(Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glNormal3x", ExactSpelling = true)]
			internal extern static unsafe void glNormal3x(IntPtr nx, IntPtr ny, IntPtr nz);

			[DllImport(Library, EntryPoint = "glNormal3xOES", ExactSpelling = true)]
			internal extern static unsafe void glNormal3xOES(IntPtr nx, IntPtr ny, IntPtr nz);

			[DllImport(Library, EntryPoint = "glNormal3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glNormal3xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glNormalFormatNV", ExactSpelling = true)]
			internal extern static void glNormalFormatNV(Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glNormalP3ui", ExactSpelling = true)]
			internal extern static void glNormalP3ui(Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glNormalP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glNormalP3uiv(Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
			internal extern static unsafe void glNormalPointer(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glNormalPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glNormalPointerEXT(Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glNormalPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glNormalPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glNormalPointervINTEL", ExactSpelling = true)]
			internal extern static unsafe void glNormalPointervINTEL(Int32 type, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glNormalStream3bATI", ExactSpelling = true)]
			internal extern static void glNormalStream3bATI(Int32 stream, sbyte nx, sbyte ny, sbyte nz);

			[DllImport(Library, EntryPoint = "glNormalStream3bvATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3bvATI(Int32 stream, sbyte* coords);

			[DllImport(Library, EntryPoint = "glNormalStream3dATI", ExactSpelling = true)]
			internal extern static void glNormalStream3dATI(Int32 stream, double nx, double ny, double nz);

			[DllImport(Library, EntryPoint = "glNormalStream3dvATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3dvATI(Int32 stream, double* coords);

			[DllImport(Library, EntryPoint = "glNormalStream3fATI", ExactSpelling = true)]
			internal extern static void glNormalStream3fATI(Int32 stream, float nx, float ny, float nz);

			[DllImport(Library, EntryPoint = "glNormalStream3fvATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3fvATI(Int32 stream, float* coords);

			[DllImport(Library, EntryPoint = "glNormalStream3iATI", ExactSpelling = true)]
			internal extern static void glNormalStream3iATI(Int32 stream, Int32 nx, Int32 ny, Int32 nz);

			[DllImport(Library, EntryPoint = "glNormalStream3ivATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3ivATI(Int32 stream, Int32* coords);

			[DllImport(Library, EntryPoint = "glNormalStream3sATI", ExactSpelling = true)]
			internal extern static void glNormalStream3sATI(Int32 stream, Int16 nx, Int16 ny, Int16 nz);

			[DllImport(Library, EntryPoint = "glNormalStream3svATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3svATI(Int32 stream, Int16* coords);

			[DllImport(Library, EntryPoint = "glObjectLabel", ExactSpelling = true)]
			internal extern static void glObjectLabel(Int32 identifier, UInt32 name, Int32 length, String label);

			[DllImport(Library, EntryPoint = "glObjectLabelKHR", ExactSpelling = true)]
			internal extern static void glObjectLabelKHR(Int32 identifier, UInt32 name, Int32 length, String label);

			[DllImport(Library, EntryPoint = "glObjectPtrLabel", ExactSpelling = true)]
			internal extern static unsafe void glObjectPtrLabel(IntPtr ptr, Int32 length, String label);

			[DllImport(Library, EntryPoint = "glObjectPtrLabelKHR", ExactSpelling = true)]
			internal extern static unsafe void glObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);

			[DllImport(Library, EntryPoint = "glObjectPurgeableAPPLE", ExactSpelling = true)]
			internal extern static Int32 glObjectPurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			[DllImport(Library, EntryPoint = "glObjectUnpurgeableAPPLE", ExactSpelling = true)]
			internal extern static Int32 glObjectUnpurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			[DllImport(Library, EntryPoint = "glOrtho", ExactSpelling = true)]
			internal extern static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

			[DllImport(Library, EntryPoint = "glOrthof", ExactSpelling = true)]
			internal extern static void glOrthof(float l, float r, float b, float t, float n, float f);

			[DllImport(Library, EntryPoint = "glOrthofOES", ExactSpelling = true)]
			internal extern static void glOrthofOES(float l, float r, float b, float t, float n, float f);

			[DllImport(Library, EntryPoint = "glOrthox", ExactSpelling = true)]
			internal extern static unsafe void glOrthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[DllImport(Library, EntryPoint = "glOrthoxOES", ExactSpelling = true)]
			internal extern static unsafe void glOrthoxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[DllImport(Library, EntryPoint = "glPNTrianglesfATI", ExactSpelling = true)]
			internal extern static void glPNTrianglesfATI(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPNTrianglesiATI", ExactSpelling = true)]
			internal extern static void glPNTrianglesiATI(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPassTexCoordATI", ExactSpelling = true)]
			internal extern static void glPassTexCoordATI(UInt32 dst, UInt32 coord, Int32 swizzle);

			[DllImport(Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
			internal extern static void glPassThrough(float token);

			[DllImport(Library, EntryPoint = "glPassThroughxOES", ExactSpelling = true)]
			internal extern static unsafe void glPassThroughxOES(IntPtr token);

			[DllImport(Library, EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glPatchParameterfv(Int32 pname, float* values);

			[DllImport(Library, EntryPoint = "glPatchParameteri", ExactSpelling = true)]
			internal extern static void glPatchParameteri(Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glPatchParameteriEXT", ExactSpelling = true)]
			internal extern static void glPatchParameteriEXT(Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glPatchParameteriOES", ExactSpelling = true)]
			internal extern static void glPatchParameteriOES(Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glPathColorGenNV", ExactSpelling = true)]
			internal extern static unsafe void glPathColorGenNV(Int32 color, Int32 genMode, Int32 colorFormat, float* coeffs);

			[DllImport(Library, EntryPoint = "glPathCommandsNV", ExactSpelling = true)]
			internal extern static unsafe void glPathCommandsNV(UInt32 path, Int32 numCommands, byte* commands, Int32 numCoords, Int32 coordType, IntPtr coords);

			[DllImport(Library, EntryPoint = "glPathCoordsNV", ExactSpelling = true)]
			internal extern static unsafe void glPathCoordsNV(UInt32 path, Int32 numCoords, Int32 coordType, IntPtr coords);

			[DllImport(Library, EntryPoint = "glPathCoverDepthFuncNV", ExactSpelling = true)]
			internal extern static void glPathCoverDepthFuncNV(Int32 func);

			[DllImport(Library, EntryPoint = "glPathDashArrayNV", ExactSpelling = true)]
			internal extern static unsafe void glPathDashArrayNV(UInt32 path, Int32 dashCount, float* dashArray);

			[DllImport(Library, EntryPoint = "glPathFogGenNV", ExactSpelling = true)]
			internal extern static void glPathFogGenNV(Int32 genMode);

			[DllImport(Library, EntryPoint = "glPathGlyphIndexArrayNV", ExactSpelling = true)]
			internal extern static unsafe Int32 glPathGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale);

			[DllImport(Library, EntryPoint = "glPathGlyphIndexRangeNV", ExactSpelling = true)]
			internal extern static unsafe Int32 glPathGlyphIndexRangeNV(Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32* baseAndCount);

			[DllImport(Library, EntryPoint = "glPathGlyphRangeNV", ExactSpelling = true)]
			internal extern static unsafe void glPathGlyphRangeNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 firstGlyph, Int32 numGlyphs, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale);

			[DllImport(Library, EntryPoint = "glPathGlyphsNV", ExactSpelling = true)]
			internal extern static unsafe void glPathGlyphsNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, Int32 numGlyphs, Int32 type, IntPtr charcodes, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale);

			[DllImport(Library, EntryPoint = "glPathMemoryGlyphIndexArrayNV", ExactSpelling = true)]
			internal extern static unsafe Int32 glPathMemoryGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, UInt32 fontSize, IntPtr fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale);

			[DllImport(Library, EntryPoint = "glPathParameterfNV", ExactSpelling = true)]
			internal extern static void glPathParameterfNV(UInt32 path, Int32 pname, float value);

			[DllImport(Library, EntryPoint = "glPathParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glPathParameterfvNV(UInt32 path, Int32 pname, float* value);

			[DllImport(Library, EntryPoint = "glPathParameteriNV", ExactSpelling = true)]
			internal extern static void glPathParameteriNV(UInt32 path, Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glPathParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glPathParameterivNV(UInt32 path, Int32 pname, Int32* value);

			[DllImport(Library, EntryPoint = "glPathStencilDepthOffsetNV", ExactSpelling = true)]
			internal extern static void glPathStencilDepthOffsetNV(float factor, float units);

			[DllImport(Library, EntryPoint = "glPathStencilFuncNV", ExactSpelling = true)]
			internal extern static void glPathStencilFuncNV(Int32 func, Int32 @ref, UInt32 mask);

			[DllImport(Library, EntryPoint = "glPathStringNV", ExactSpelling = true)]
			internal extern static unsafe void glPathStringNV(UInt32 path, Int32 format, Int32 length, IntPtr pathString);

			[DllImport(Library, EntryPoint = "glPathSubCommandsNV", ExactSpelling = true)]
			internal extern static unsafe void glPathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, Int32 numCommands, byte* commands, Int32 numCoords, Int32 coordType, IntPtr coords);

			[DllImport(Library, EntryPoint = "glPathSubCoordsNV", ExactSpelling = true)]
			internal extern static unsafe void glPathSubCoordsNV(UInt32 path, Int32 coordStart, Int32 numCoords, Int32 coordType, IntPtr coords);

			[DllImport(Library, EntryPoint = "glPathTexGenNV", ExactSpelling = true)]
			internal extern static unsafe void glPathTexGenNV(Int32 texCoordSet, Int32 genMode, Int32 components, float* coeffs);

			[DllImport(Library, EntryPoint = "glPauseTransformFeedback", ExactSpelling = true)]
			internal extern static void glPauseTransformFeedback();

			[DllImport(Library, EntryPoint = "glPauseTransformFeedbackNV", ExactSpelling = true)]
			internal extern static void glPauseTransformFeedbackNV();

			[DllImport(Library, EntryPoint = "glPixelDataRangeNV", ExactSpelling = true)]
			internal extern static unsafe void glPixelDataRangeNV(Int32 target, Int32 length, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapfv(Int32 map, Int32 mapsize, float* values);

			[DllImport(Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapuiv(Int32 map, Int32 mapsize, UInt32* values);

			[DllImport(Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapusv(Int32 map, Int32 mapsize, UInt16* values);

			[DllImport(Library, EntryPoint = "glPixelMapx", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapx(Int32 map, Int32 size, IntPtr* values);

			[DllImport(Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
			internal extern static void glPixelStoref(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
			internal extern static void glPixelStorei(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPixelStorex", ExactSpelling = true)]
			internal extern static unsafe void glPixelStorex(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glPixelTexGenParameterfSGIS", ExactSpelling = true)]
			internal extern static void glPixelTexGenParameterfSGIS(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPixelTexGenParameterfvSGIS", ExactSpelling = true)]
			internal extern static unsafe void glPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glPixelTexGenParameteriSGIS", ExactSpelling = true)]
			internal extern static void glPixelTexGenParameteriSGIS(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPixelTexGenParameterivSGIS", ExactSpelling = true)]
			internal extern static unsafe void glPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glPixelTexGenSGIX", ExactSpelling = true)]
			internal extern static void glPixelTexGenSGIX(Int32 mode);

			[DllImport(Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
			internal extern static void glPixelTransferf(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
			internal extern static void glPixelTransferi(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPixelTransferxOES", ExactSpelling = true)]
			internal extern static unsafe void glPixelTransferxOES(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glPixelTransformParameterfEXT", ExactSpelling = true)]
			internal extern static void glPixelTransformParameterfEXT(Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPixelTransformParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glPixelTransformParameteriEXT", ExactSpelling = true)]
			internal extern static void glPixelTransformParameteriEXT(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPixelTransformParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
			internal extern static void glPixelZoom(float xfactor, float yfactor);

			[DllImport(Library, EntryPoint = "glPixelZoomxOES", ExactSpelling = true)]
			internal extern static unsafe void glPixelZoomxOES(IntPtr xfactor, IntPtr yfactor);

			[DllImport(Library, EntryPoint = "glPointAlongPathNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glPointAlongPathNV(UInt32 path, Int32 startSegment, Int32 numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY);

			[DllImport(Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
			internal extern static void glPointParameterf(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPointParameterfARB", ExactSpelling = true)]
			internal extern static void glPointParameterfARB(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPointParameterfEXT", ExactSpelling = true)]
			internal extern static void glPointParameterfEXT(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPointParameterfSGIS", ExactSpelling = true)]
			internal extern static void glPointParameterfSGIS(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterfv(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glPointParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterfvARB(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glPointParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterfvEXT(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glPointParameterfvSGIS", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterfvSGIS(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
			internal extern static void glPointParameteri(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPointParameteriNV", ExactSpelling = true)]
			internal extern static void glPointParameteriNV(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameteriv(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glPointParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterivNV(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glPointParameterx", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterx(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glPointParameterxOES", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxOES(Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glPointParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxv(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glPointParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxvOES(Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glPointSize", ExactSpelling = true)]
			internal extern static void glPointSize(float size);

			[DllImport(Library, EntryPoint = "glPointSizePointerOES", ExactSpelling = true)]
			internal extern static unsafe void glPointSizePointerOES(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glPointSizex", ExactSpelling = true)]
			internal extern static unsafe void glPointSizex(IntPtr size);

			[DllImport(Library, EntryPoint = "glPointSizexOES", ExactSpelling = true)]
			internal extern static unsafe void glPointSizexOES(IntPtr size);

			[DllImport(Library, EntryPoint = "glPollAsyncSGIX", ExactSpelling = true)]
			internal extern static unsafe Int32 glPollAsyncSGIX(UInt32* markerp);

			[DllImport(Library, EntryPoint = "glPollInstrumentsSGIX", ExactSpelling = true)]
			internal extern static unsafe Int32 glPollInstrumentsSGIX(Int32* marker_p);

			[DllImport(Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
			internal extern static void glPolygonMode(Int32 face, Int32 mode);

			[DllImport(Library, EntryPoint = "glPolygonModeNV", ExactSpelling = true)]
			internal extern static void glPolygonModeNV(Int32 face, Int32 mode);

			[DllImport(Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
			internal extern static void glPolygonOffset(float factor, float units);

			[DllImport(Library, EntryPoint = "glPolygonOffsetClampEXT", ExactSpelling = true)]
			internal extern static void glPolygonOffsetClampEXT(float factor, float units, float clamp);

			[DllImport(Library, EntryPoint = "glPolygonOffsetEXT", ExactSpelling = true)]
			internal extern static void glPolygonOffsetEXT(float factor, float bias);

			[DllImport(Library, EntryPoint = "glPolygonOffsetx", ExactSpelling = true)]
			internal extern static unsafe void glPolygonOffsetx(IntPtr factor, IntPtr units);

			[DllImport(Library, EntryPoint = "glPolygonOffsetxOES", ExactSpelling = true)]
			internal extern static unsafe void glPolygonOffsetxOES(IntPtr factor, IntPtr units);

			[DllImport(Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glPolygonStipple(byte* mask);

			[DllImport(Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
			internal extern static void glPopAttrib();

			[DllImport(Library, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
			internal extern static void glPopClientAttrib();

			[DllImport(Library, EntryPoint = "glPopDebugGroup", ExactSpelling = true)]
			internal extern static void glPopDebugGroup();

			[DllImport(Library, EntryPoint = "glPopDebugGroupKHR", ExactSpelling = true)]
			internal extern static void glPopDebugGroupKHR();

			[DllImport(Library, EntryPoint = "glPopGroupMarkerEXT", ExactSpelling = true)]
			internal extern static void glPopGroupMarkerEXT();

			[DllImport(Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
			internal extern static void glPopMatrix();

			[DllImport(Library, EntryPoint = "glPopName", ExactSpelling = true)]
			internal extern static void glPopName();

			[DllImport(Library, EntryPoint = "glPresentFrameDualFillNV", ExactSpelling = true)]
			internal extern static void glPresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, Int32 target1, UInt32 fill1, Int32 target2, UInt32 fill2, Int32 target3, UInt32 fill3);

			[DllImport(Library, EntryPoint = "glPresentFrameKeyedNV", ExactSpelling = true)]
			internal extern static void glPresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, UInt32 key0, Int32 target1, UInt32 fill1, UInt32 key1);

			[DllImport(Library, EntryPoint = "glPrimitiveBoundingBox", ExactSpelling = true)]
			internal extern static void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

			[DllImport(Library, EntryPoint = "glPrimitiveBoundingBoxARB", ExactSpelling = true)]
			internal extern static void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

			[DllImport(Library, EntryPoint = "glPrimitiveBoundingBoxEXT", ExactSpelling = true)]
			internal extern static void glPrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

			[DllImport(Library, EntryPoint = "glPrimitiveBoundingBoxOES", ExactSpelling = true)]
			internal extern static void glPrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

			[DllImport(Library, EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
			internal extern static void glPrimitiveRestartIndex(UInt32 index);

			[DllImport(Library, EntryPoint = "glPrimitiveRestartIndexNV", ExactSpelling = true)]
			internal extern static void glPrimitiveRestartIndexNV(UInt32 index);

			[DllImport(Library, EntryPoint = "glPrimitiveRestartNV", ExactSpelling = true)]
			internal extern static void glPrimitiveRestartNV();

			[DllImport(Library, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
			internal extern static unsafe void glPrioritizeTextures(Int32 n, UInt32* textures, float* priorities);

			[DllImport(Library, EntryPoint = "glPrioritizeTexturesEXT", ExactSpelling = true)]
			internal extern static unsafe void glPrioritizeTexturesEXT(Int32 n, UInt32* textures, float* priorities);

			[DllImport(Library, EntryPoint = "glPrioritizeTexturesxOES", ExactSpelling = true)]
			internal extern static unsafe void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, IntPtr* priorities);

			[DllImport(Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
			internal extern static unsafe void glProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

			[DllImport(Library, EntryPoint = "glProgramBinaryOES", ExactSpelling = true)]
			internal extern static unsafe void glProgramBinaryOES(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

			[DllImport(Library, EntryPoint = "glProgramBufferParametersIivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramBufferParametersIivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, Int32* @params);

			[DllImport(Library, EntryPoint = "glProgramBufferParametersIuivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramBufferParametersIuivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, UInt32* @params);

			[DllImport(Library, EntryPoint = "glProgramBufferParametersfvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramBufferParametersfvNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, float* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParameter4dARB", ExactSpelling = true)]
			internal extern static void glProgramEnvParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glProgramEnvParameter4dvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameter4dvARB(Int32 target, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParameter4fARB", ExactSpelling = true)]
			internal extern static void glProgramEnvParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glProgramEnvParameter4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameter4fvARB(Int32 target, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4iNV", ExactSpelling = true)]
			internal extern static void glProgramEnvParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4uiNV", ExactSpelling = true)]
			internal extern static void glProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParameters4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameters4fvEXT(Int32 target, UInt32 index, Int32 count, float* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParametersI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[DllImport(Library, EntryPoint = "glProgramEnvParametersI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParameter4dARB", ExactSpelling = true)]
			internal extern static void glProgramLocalParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glProgramLocalParameter4dvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameter4dvARB(Int32 target, UInt32 index, double* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParameter4fARB", ExactSpelling = true)]
			internal extern static void glProgramLocalParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glProgramLocalParameter4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameter4fvARB(Int32 target, UInt32 index, float* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4iNV", ExactSpelling = true)]
			internal extern static void glProgramLocalParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4uiNV", ExactSpelling = true)]
			internal extern static void glProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParameters4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameters4fvEXT(Int32 target, UInt32 index, Int32 count, float* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParametersI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[DllImport(Library, EntryPoint = "glProgramLocalParametersI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[DllImport(Library, EntryPoint = "glProgramNamedParameter4dNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4dNV(UInt32 id, Int32 len, byte* name, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glProgramNamedParameter4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4dvNV(UInt32 id, Int32 len, byte* name, double* v);

			[DllImport(Library, EntryPoint = "glProgramNamedParameter4fNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4fNV(UInt32 id, Int32 len, byte* name, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glProgramNamedParameter4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4fvNV(UInt32 id, Int32 len, byte* name, float* v);

			[DllImport(Library, EntryPoint = "glProgramParameter4dNV", ExactSpelling = true)]
			internal extern static void glProgramParameter4dNV(Int32 target, UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glProgramParameter4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameter4dvNV(Int32 target, UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glProgramParameter4fNV", ExactSpelling = true)]
			internal extern static void glProgramParameter4fNV(Int32 target, UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glProgramParameter4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameter4fvNV(Int32 target, UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
			internal extern static void glProgramParameteri(UInt32 program, Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glProgramParameteriARB", ExactSpelling = true)]
			internal extern static void glProgramParameteriARB(UInt32 program, Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glProgramParameteriEXT", ExactSpelling = true)]
			internal extern static void glProgramParameteriEXT(UInt32 program, Int32 pname, Int32 value);

			[DllImport(Library, EntryPoint = "glProgramParameters4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameters4dvNV(Int32 target, UInt32 index, Int32 count, double* v);

			[DllImport(Library, EntryPoint = "glProgramParameters4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramParameters4fvNV(Int32 target, UInt32 index, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glProgramPathFragmentInputGenNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramPathFragmentInputGenNV(UInt32 program, Int32 location, Int32 genMode, Int32 components, float* coeffs);

			[DllImport(Library, EntryPoint = "glProgramStringARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramStringARB(Int32 target, Int32 format, Int32 len, IntPtr @string);

			[DllImport(Library, EntryPoint = "glProgramSubroutineParametersuivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramSubroutineParametersuivNV(Int32 target, Int32 count, UInt32* @params);

			[DllImport(Library, EntryPoint = "glProgramUniform1d", ExactSpelling = true)]
			internal extern static void glProgramUniform1d(UInt32 program, Int32 location, double v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform1dEXT(UInt32 program, Int32 location, double x);

			[DllImport(Library, EntryPoint = "glProgramUniform1dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
			internal extern static void glProgramUniform1f(UInt32 program, Int32 location, float v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1fEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform1fEXT(UInt32 program, Int32 location, float v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
			internal extern static void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform1i64ARB(UInt32 program, Int32 location, Int64 x);

			[DllImport(Library, EntryPoint = "glProgramUniform1i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);

			[DllImport(Library, EntryPoint = "glProgramUniform1i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1iEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
			internal extern static void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform1ui64ARB(UInt32 program, Int32 location, UInt64 x);

			[DllImport(Library, EntryPoint = "glProgramUniform1ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);

			[DllImport(Library, EntryPoint = "glProgramUniform1ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1uiEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);

			[DllImport(Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform1uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2d", ExactSpelling = true)]
			internal extern static void glProgramUniform2d(UInt32 program, Int32 location, double v0, double v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform2dEXT(UInt32 program, Int32 location, double x, double y);

			[DllImport(Library, EntryPoint = "glProgramUniform2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
			internal extern static void glProgramUniform2f(UInt32 program, Int32 location, float v0, float v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2fEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform2fEXT(UInt32 program, Int32 location, float v0, float v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
			internal extern static void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform2i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y);

			[DllImport(Library, EntryPoint = "glProgramUniform2i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);

			[DllImport(Library, EntryPoint = "glProgramUniform2i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2iEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
			internal extern static void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform2ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[DllImport(Library, EntryPoint = "glProgramUniform2ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[DllImport(Library, EntryPoint = "glProgramUniform2ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2uiEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);

			[DllImport(Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform2uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3d", ExactSpelling = true)]
			internal extern static void glProgramUniform3d(UInt32 program, Int32 location, double v0, double v1, double v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform3dEXT(UInt32 program, Int32 location, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glProgramUniform3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
			internal extern static void glProgramUniform3f(UInt32 program, Int32 location, float v0, float v1, float v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3fEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform3fEXT(UInt32 program, Int32 location, float v0, float v1, float v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
			internal extern static void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform3i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[DllImport(Library, EntryPoint = "glProgramUniform3i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[DllImport(Library, EntryPoint = "glProgramUniform3i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3iEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
			internal extern static void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform3ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[DllImport(Library, EntryPoint = "glProgramUniform3ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[DllImport(Library, EntryPoint = "glProgramUniform3ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3uiEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[DllImport(Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform3uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4d", ExactSpelling = true)]
			internal extern static void glProgramUniform4d(UInt32 program, Int32 location, double v0, double v1, double v2, double v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform4dEXT(UInt32 program, Int32 location, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glProgramUniform4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
			internal extern static void glProgramUniform4f(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4fEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform4fEXT(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
			internal extern static void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform4i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[DllImport(Library, EntryPoint = "glProgramUniform4i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[DllImport(Library, EntryPoint = "glProgramUniform4i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4iEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
			internal extern static void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform4ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[DllImport(Library, EntryPoint = "glProgramUniform4ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[DllImport(Library, EntryPoint = "glProgramUniform4ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4uiEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[DllImport(Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniform4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);

			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniformHandleui64NV(UInt32 program, Int32 location, UInt64 value);

			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformHandleui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3dv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glProgramUniformui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);

			[DllImport(Library, EntryPoint = "glProgramUniformui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glProgramVertexLimitNV", ExactSpelling = true)]
			internal extern static void glProgramVertexLimitNV(Int32 target, Int32 limit);

			[DllImport(Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
			internal extern static void glProvokingVertex(Int32 mode);

			[DllImport(Library, EntryPoint = "glProvokingVertexEXT", ExactSpelling = true)]
			internal extern static void glProvokingVertexEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
			internal extern static void glPushAttrib(UInt32 mask);

			[DllImport(Library, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
			internal extern static void glPushClientAttrib(UInt32 mask);

			[DllImport(Library, EntryPoint = "glPushClientAttribDefaultEXT", ExactSpelling = true)]
			internal extern static void glPushClientAttribDefaultEXT(UInt32 mask);

			[DllImport(Library, EntryPoint = "glPushDebugGroup", ExactSpelling = true)]
			internal extern static void glPushDebugGroup(Int32 source, UInt32 id, Int32 length, String message);

			[DllImport(Library, EntryPoint = "glPushDebugGroupKHR", ExactSpelling = true)]
			internal extern static void glPushDebugGroupKHR(Int32 source, UInt32 id, Int32 length, String message);

			[DllImport(Library, EntryPoint = "glPushGroupMarkerEXT", ExactSpelling = true)]
			internal extern static void glPushGroupMarkerEXT(Int32 length, String marker);

			[DllImport(Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
			internal extern static void glPushMatrix();

			[DllImport(Library, EntryPoint = "glPushName", ExactSpelling = true)]
			internal extern static void glPushName(UInt32 name);

			[DllImport(Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
			internal extern static void glQueryCounter(UInt32 id, Int32 target);

			[DllImport(Library, EntryPoint = "glQueryCounterEXT", ExactSpelling = true)]
			internal extern static void glQueryCounterEXT(UInt32 id, Int32 target);

			[DllImport(Library, EntryPoint = "glQueryMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe UInt32 glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);

			[DllImport(Library, EntryPoint = "glQueryObjectParameteruiAMD", ExactSpelling = true)]
			internal extern static void glQueryObjectParameteruiAMD(Int32 target, UInt32 id, Int32 pname, UInt32 param);

			[DllImport(Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
			internal extern static void glRasterPos2d(double x, double y);

			[DllImport(Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2dv(double* v);

			[DllImport(Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
			internal extern static void glRasterPos2f(float x, float y);

			[DllImport(Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2fv(float* v);

			[DllImport(Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
			internal extern static void glRasterPos2i(Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2iv(Int32* v);

			[DllImport(Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
			internal extern static void glRasterPos2s(Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2sv(Int16* v);

			[DllImport(Library, EntryPoint = "glRasterPos2xOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2xOES(IntPtr x, IntPtr y);

			[DllImport(Library, EntryPoint = "glRasterPos2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
			internal extern static void glRasterPos3d(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3dv(double* v);

			[DllImport(Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
			internal extern static void glRasterPos3f(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3fv(float* v);

			[DllImport(Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
			internal extern static void glRasterPos3i(Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
			internal extern static void glRasterPos3s(Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glRasterPos3xOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3xOES(IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glRasterPos3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
			internal extern static void glRasterPos4d(double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4dv(double* v);

			[DllImport(Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
			internal extern static void glRasterPos4f(float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4fv(float* v);

			[DllImport(Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
			internal extern static void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4iv(Int32* v);

			[DllImport(Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
			internal extern static void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4sv(Int16* v);

			[DllImport(Library, EntryPoint = "glRasterPos4xOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4xOES(IntPtr x, IntPtr y, IntPtr z, IntPtr w);

			[DllImport(Library, EntryPoint = "glRasterPos4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glRasterSamplesEXT", ExactSpelling = true)]
			internal extern static void glRasterSamplesEXT(UInt32 samples, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
			internal extern static void glReadBuffer(Int32 src);

			[DllImport(Library, EntryPoint = "glReadBufferIndexedEXT", ExactSpelling = true)]
			internal extern static void glReadBufferIndexedEXT(Int32 src, Int32 index);

			[DllImport(Library, EntryPoint = "glReadBufferNV", ExactSpelling = true)]
			internal extern static void glReadBufferNV(Int32 mode);

			[DllImport(Library, EntryPoint = "glReadInstrumentsSGIX", ExactSpelling = true)]
			internal extern static void glReadInstrumentsSGIX(Int32 marker);

			[DllImport(Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
			internal extern static unsafe void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glReadnPixels", ExactSpelling = true)]
			internal extern static unsafe void glReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glReadnPixelsARB", ExactSpelling = true)]
			internal extern static unsafe void glReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glReadnPixelsEXT", ExactSpelling = true)]
			internal extern static unsafe void glReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glReadnPixelsKHR", ExactSpelling = true)]
			internal extern static unsafe void glReadnPixelsKHR(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[DllImport(Library, EntryPoint = "glRectd", ExactSpelling = true)]
			internal extern static void glRectd(double x1, double y1, double x2, double y2);

			[DllImport(Library, EntryPoint = "glRectdv", ExactSpelling = true)]
			internal extern static unsafe void glRectdv(double* v1, double* v2);

			[DllImport(Library, EntryPoint = "glRectf", ExactSpelling = true)]
			internal extern static void glRectf(float x1, float y1, float x2, float y2);

			[DllImport(Library, EntryPoint = "glRectfv", ExactSpelling = true)]
			internal extern static unsafe void glRectfv(float* v1, float* v2);

			[DllImport(Library, EntryPoint = "glRecti", ExactSpelling = true)]
			internal extern static void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

			[DllImport(Library, EntryPoint = "glRectiv", ExactSpelling = true)]
			internal extern static unsafe void glRectiv(Int32* v1, Int32* v2);

			[DllImport(Library, EntryPoint = "glRects", ExactSpelling = true)]
			internal extern static void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

			[DllImport(Library, EntryPoint = "glRectsv", ExactSpelling = true)]
			internal extern static unsafe void glRectsv(Int16* v1, Int16* v2);

			[DllImport(Library, EntryPoint = "glRectxOES", ExactSpelling = true)]
			internal extern static unsafe void glRectxOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2);

			[DllImport(Library, EntryPoint = "glRectxvOES", ExactSpelling = true)]
			internal extern static unsafe void glRectxvOES(IntPtr* v1, IntPtr* v2);

			[DllImport(Library, EntryPoint = "glReferencePlaneSGIX", ExactSpelling = true)]
			internal extern static unsafe void glReferencePlaneSGIX(double* equation);

			[DllImport(Library, EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
			internal extern static void glReleaseShaderCompiler();

			[DllImport(Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
			internal extern static Int32 glRenderMode(Int32 mode);

			[DllImport(Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
			internal extern static void glRenderbufferStorage(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageEXT", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageEXT(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleANGLE", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleANGLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleAPPLE", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleAPPLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleEXT(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleIMG", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleIMG(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleNV", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleNV(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glRenderbufferStorageOES", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageOES(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glReplacementCodePointerSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodePointerSUN(Int32 type, Int32 stride, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glReplacementCodeubSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeubSUN(byte code);

			[DllImport(Library, EntryPoint = "glReplacementCodeubvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeubvSUN(byte* code);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, float r, float g, float b, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, float* c, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, float* c, float* n, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, byte r, byte g, byte b, byte a, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, byte* c, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, float* n, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiSUN(UInt32 code);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* c, float* n, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* n, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, float s, float t, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, float* tc, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiVertex3fSUN(UInt32 rc, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glReplacementCodeuiVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiVertex3fvSUN(UInt32* rc, float* v);

			[DllImport(Library, EntryPoint = "glReplacementCodeuivSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuivSUN(UInt32* code);

			[DllImport(Library, EntryPoint = "glReplacementCodeusSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeusSUN(UInt16 code);

			[DllImport(Library, EntryPoint = "glReplacementCodeusvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeusvSUN(UInt16* code);

			[DllImport(Library, EntryPoint = "glRequestResidentProgramsNV", ExactSpelling = true)]
			internal extern static unsafe void glRequestResidentProgramsNV(Int32 n, UInt32* programs);

			[DllImport(Library, EntryPoint = "glResetHistogram", ExactSpelling = true)]
			internal extern static void glResetHistogram(Int32 target);

			[DllImport(Library, EntryPoint = "glResetHistogramEXT", ExactSpelling = true)]
			internal extern static void glResetHistogramEXT(Int32 target);

			[DllImport(Library, EntryPoint = "glResetMinmax", ExactSpelling = true)]
			internal extern static void glResetMinmax(Int32 target);

			[DllImport(Library, EntryPoint = "glResetMinmaxEXT", ExactSpelling = true)]
			internal extern static void glResetMinmaxEXT(Int32 target);

			[DllImport(Library, EntryPoint = "glResizeBuffersMESA", ExactSpelling = true)]
			internal extern static void glResizeBuffersMESA();

			[DllImport(Library, EntryPoint = "glResolveDepthValuesNV", ExactSpelling = true)]
			internal extern static void glResolveDepthValuesNV();

			[DllImport(Library, EntryPoint = "glResolveMultisampleFramebufferAPPLE", ExactSpelling = true)]
			internal extern static void glResolveMultisampleFramebufferAPPLE();

			[DllImport(Library, EntryPoint = "glResumeTransformFeedback", ExactSpelling = true)]
			internal extern static void glResumeTransformFeedback();

			[DllImport(Library, EntryPoint = "glResumeTransformFeedbackNV", ExactSpelling = true)]
			internal extern static void glResumeTransformFeedbackNV();

			[DllImport(Library, EntryPoint = "glRotated", ExactSpelling = true)]
			internal extern static void glRotated(double angle, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glRotatef", ExactSpelling = true)]
			internal extern static void glRotatef(float angle, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glRotatex", ExactSpelling = true)]
			internal extern static unsafe void glRotatex(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glRotatexOES", ExactSpelling = true)]
			internal extern static unsafe void glRotatexOES(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
			internal extern static void glSampleCoverage(float value, bool invert);

			[DllImport(Library, EntryPoint = "glSampleCoverageARB", ExactSpelling = true)]
			internal extern static void glSampleCoverageARB(float value, bool invert);

			[DllImport(Library, EntryPoint = "glSampleCoveragex", ExactSpelling = true)]
			internal extern static void glSampleCoveragex(Int32 value, bool invert);

			[DllImport(Library, EntryPoint = "glSampleCoveragexOES", ExactSpelling = true)]
			internal extern static void glSampleCoveragexOES(Int32 value, bool invert);

			[DllImport(Library, EntryPoint = "glSampleMapATI", ExactSpelling = true)]
			internal extern static void glSampleMapATI(UInt32 dst, UInt32 interp, Int32 swizzle);

			[DllImport(Library, EntryPoint = "glSampleMaskEXT", ExactSpelling = true)]
			internal extern static void glSampleMaskEXT(float value, bool invert);

			[DllImport(Library, EntryPoint = "glSampleMaskIndexedNV", ExactSpelling = true)]
			internal extern static void glSampleMaskIndexedNV(UInt32 index, UInt32 mask);

			[DllImport(Library, EntryPoint = "glSampleMaskSGIS", ExactSpelling = true)]
			internal extern static void glSampleMaskSGIS(float value, bool invert);

			[DllImport(Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
			internal extern static void glSampleMaski(UInt32 maskNumber, UInt32 mask);

			[DllImport(Library, EntryPoint = "glSamplePatternEXT", ExactSpelling = true)]
			internal extern static void glSamplePatternEXT(Int32 pattern);

			[DllImport(Library, EntryPoint = "glSamplePatternSGIS", ExactSpelling = true)]
			internal extern static void glSamplePatternSGIS(Int32 pattern);

			[DllImport(Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glSamplerParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIivEXT(UInt32 sampler, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glSamplerParameterIivOES", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIivOES(UInt32 sampler, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* param);

			[DllImport(Library, EntryPoint = "glSamplerParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIuivEXT(UInt32 sampler, Int32 pname, UInt32* param);

			[DllImport(Library, EntryPoint = "glSamplerParameterIuivOES", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIuivOES(UInt32 sampler, Int32 pname, UInt32* param);

			[DllImport(Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
			internal extern static void glSamplerParameterf(UInt32 sampler, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterfv(UInt32 sampler, Int32 pname, float* param);

			[DllImport(Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
			internal extern static void glSamplerParameteri(UInt32 sampler, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glScaled", ExactSpelling = true)]
			internal extern static void glScaled(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glScalef", ExactSpelling = true)]
			internal extern static void glScalef(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glScalex", ExactSpelling = true)]
			internal extern static unsafe void glScalex(IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glScalexOES", ExactSpelling = true)]
			internal extern static unsafe void glScalexOES(IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glScissor", ExactSpelling = true)]
			internal extern static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
			internal extern static unsafe void glScissorArrayv(UInt32 first, Int32 count, Int32* v);

			[DllImport(Library, EntryPoint = "glScissorArrayvNV", ExactSpelling = true)]
			internal extern static unsafe void glScissorArrayvNV(UInt32 first, Int32 count, Int32* v);

			[DllImport(Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
			internal extern static void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glScissorIndexedNV", ExactSpelling = true)]
			internal extern static void glScissorIndexedNV(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
			internal extern static unsafe void glScissorIndexedv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glScissorIndexedvNV", ExactSpelling = true)]
			internal extern static unsafe void glScissorIndexedvNV(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
			internal extern static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3bEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3bv(sbyte* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3bvEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3bvEXT(sbyte* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
			internal extern static void glSecondaryColor3d(double red, double green, double blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3dEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3dEXT(double red, double green, double blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3dv(double* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3dvEXT(double* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
			internal extern static void glSecondaryColor3f(float red, float green, float blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3fEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3fEXT(float red, float green, float blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3fv(float* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3fvEXT(float* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3hNV", ExactSpelling = true)]
			internal extern static void glSecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
			internal extern static void glSecondaryColor3i(Int32 red, Int32 green, Int32 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3iEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3ivEXT(Int32* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
			internal extern static void glSecondaryColor3s(Int16 red, Int16 green, Int16 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3sEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3svEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3svEXT(Int16* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
			internal extern static void glSecondaryColor3ub(byte red, byte green, byte blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3ubEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3ubEXT(byte red, byte green, byte blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3ubv(byte* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3ubvEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3ubvEXT(byte* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
			internal extern static void glSecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3uiEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3uiv(UInt32* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3uivEXT(UInt32* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
			internal extern static void glSecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3usEXT", ExactSpelling = true)]
			internal extern static void glSecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);

			[DllImport(Library, EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3usv(UInt16* v);

			[DllImport(Library, EntryPoint = "glSecondaryColor3usvEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3usvEXT(UInt16* v);

			[DllImport(Library, EntryPoint = "glSecondaryColorFormatNV", ExactSpelling = true)]
			internal extern static void glSecondaryColorFormatNV(Int32 size, Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glSecondaryColorP3ui", ExactSpelling = true)]
			internal extern static void glSecondaryColorP3ui(Int32 type, UInt32 color);

			[DllImport(Library, EntryPoint = "glSecondaryColorP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorP3uiv(Int32 type, UInt32* color);

			[DllImport(Library, EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glSecondaryColorPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorPointerEXT(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glSecondaryColorPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
			internal extern static unsafe void glSelectBuffer(Int32 size, UInt32* buffer);

			[DllImport(Library, EntryPoint = "glSelectPerfMonitorCountersAMD", ExactSpelling = true)]
			internal extern static unsafe void glSelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, UInt32* counterList);

			[DllImport(Library, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
			internal extern static unsafe void glSeparableFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr row, IntPtr column);

			[DllImport(Library, EntryPoint = "glSeparableFilter2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glSeparableFilter2DEXT(Int32 target, Int32 internalformat, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr row, IntPtr column);

			[DllImport(Library, EntryPoint = "glSetFenceAPPLE", ExactSpelling = true)]
			internal extern static void glSetFenceAPPLE(UInt32 fence);

			[DllImport(Library, EntryPoint = "glSetFenceNV", ExactSpelling = true)]
			internal extern static void glSetFenceNV(UInt32 fence, Int32 condition);

			[DllImport(Library, EntryPoint = "glSetFragmentShaderConstantATI", ExactSpelling = true)]
			internal extern static unsafe void glSetFragmentShaderConstantATI(UInt32 dst, float* value);

			[DllImport(Library, EntryPoint = "glSetInvariantEXT", ExactSpelling = true)]
			internal extern static unsafe void glSetInvariantEXT(UInt32 id, Int32 type, IntPtr addr);

			[DllImport(Library, EntryPoint = "glSetLocalConstantEXT", ExactSpelling = true)]
			internal extern static unsafe void glSetLocalConstantEXT(UInt32 id, Int32 type, IntPtr addr);

			[DllImport(Library, EntryPoint = "glSetMultisamplefvAMD", ExactSpelling = true)]
			internal extern static unsafe void glSetMultisamplefvAMD(Int32 pname, UInt32 index, float* val);

			[DllImport(Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
			internal extern static void glShadeModel(Int32 mode);

			[DllImport(Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
			internal extern static unsafe void glShaderBinary(Int32 count, UInt32* shaders, Int32 binaryformat, IntPtr binary, Int32 length);

			[DllImport(Library, EntryPoint = "glShaderOp1EXT", ExactSpelling = true)]
			internal extern static void glShaderOp1EXT(Int32 op, UInt32 res, UInt32 arg1);

			[DllImport(Library, EntryPoint = "glShaderOp2EXT", ExactSpelling = true)]
			internal extern static void glShaderOp2EXT(Int32 op, UInt32 res, UInt32 arg1, UInt32 arg2);

			[DllImport(Library, EntryPoint = "glShaderOp3EXT", ExactSpelling = true)]
			internal extern static void glShaderOp3EXT(Int32 op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);

			[DllImport(Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
			internal extern static unsafe void glShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);

			[DllImport(Library, EntryPoint = "glShaderSourceARB", ExactSpelling = true)]
			internal extern static unsafe void glShaderSourceARB(UInt32 shaderObj, Int32 count, String[] @string, Int32* length);

			[DllImport(Library, EntryPoint = "glShaderStorageBlockBinding", ExactSpelling = true)]
			internal extern static void glShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);

			[DllImport(Library, EntryPoint = "glSharpenTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glSharpenTexFuncSGIS(Int32 target, Int32 n, float* points);

			[DllImport(Library, EntryPoint = "glSpriteParameterfSGIX", ExactSpelling = true)]
			internal extern static void glSpriteParameterfSGIX(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glSpriteParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glSpriteParameterfvSGIX(Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glSpriteParameteriSGIX", ExactSpelling = true)]
			internal extern static void glSpriteParameteriSGIX(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glSpriteParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glSpriteParameterivSGIX(Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glStartInstrumentsSGIX", ExactSpelling = true)]
			internal extern static void glStartInstrumentsSGIX();

			[DllImport(Library, EntryPoint = "glStartTilingQCOM", ExactSpelling = true)]
			internal extern static void glStartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);

			[DllImport(Library, EntryPoint = "glStateCaptureNV", ExactSpelling = true)]
			internal extern static void glStateCaptureNV(UInt32 state, Int32 mode);

			[DllImport(Library, EntryPoint = "glStencilClearTagEXT", ExactSpelling = true)]
			internal extern static void glStencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);

			[DllImport(Library, EntryPoint = "glStencilFillPathInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glStencilFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glStencilFillPathNV", ExactSpelling = true)]
			internal extern static void glStencilFillPathNV(UInt32 path, Int32 fillMode, UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
			internal extern static void glStencilFunc(Int32 func, Int32 @ref, UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
			internal extern static void glStencilFuncSeparate(Int32 face, Int32 func, Int32 @ref, UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilFuncSeparateATI", ExactSpelling = true)]
			internal extern static void glStencilFuncSeparateATI(Int32 frontfunc, Int32 backfunc, Int32 @ref, UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
			internal extern static void glStencilMask(UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
			internal extern static void glStencilMaskSeparate(Int32 face, UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
			internal extern static void glStencilOp(Int32 fail, Int32 zfail, Int32 zpass);

			[DllImport(Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
			internal extern static void glStencilOpSeparate(Int32 face, Int32 sfail, Int32 dpfail, Int32 dppass);

			[DllImport(Library, EntryPoint = "glStencilOpSeparateATI", ExactSpelling = true)]
			internal extern static void glStencilOpSeparateATI(Int32 face, Int32 sfail, Int32 dpfail, Int32 dppass);

			[DllImport(Library, EntryPoint = "glStencilOpValueAMD", ExactSpelling = true)]
			internal extern static void glStencilOpValueAMD(Int32 face, UInt32 value);

			[DllImport(Library, EntryPoint = "glStencilStrokePathInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glStencilStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glStencilStrokePathNV", ExactSpelling = true)]
			internal extern static void glStencilStrokePathNV(UInt32 path, Int32 reference, UInt32 mask);

			[DllImport(Library, EntryPoint = "glStencilThenCoverFillPathInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glStencilThenCoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 coverMode, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glStencilThenCoverFillPathNV", ExactSpelling = true)]
			internal extern static void glStencilThenCoverFillPathNV(UInt32 path, Int32 fillMode, UInt32 mask, Int32 coverMode);

			[DllImport(Library, EntryPoint = "glStencilThenCoverStrokePathInstancedNV", ExactSpelling = true)]
			internal extern static unsafe void glStencilThenCoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 coverMode, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glStencilThenCoverStrokePathNV", ExactSpelling = true)]
			internal extern static void glStencilThenCoverStrokePathNV(UInt32 path, Int32 reference, UInt32 mask, Int32 coverMode);

			[DllImport(Library, EntryPoint = "glStopInstrumentsSGIX", ExactSpelling = true)]
			internal extern static void glStopInstrumentsSGIX(Int32 marker);

			[DllImport(Library, EntryPoint = "glStringMarkerGREMEDY", ExactSpelling = true)]
			internal extern static unsafe void glStringMarkerGREMEDY(Int32 len, IntPtr @string);

			[DllImport(Library, EntryPoint = "glSubpixelPrecisionBiasNV", ExactSpelling = true)]
			internal extern static void glSubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits);

			[DllImport(Library, EntryPoint = "glSwizzleEXT", ExactSpelling = true)]
			internal extern static void glSwizzleEXT(UInt32 res, UInt32 @in, Int32 outX, Int32 outY, Int32 outZ, Int32 outW);

			[DllImport(Library, EntryPoint = "glSyncTextureINTEL", ExactSpelling = true)]
			internal extern static void glSyncTextureINTEL(UInt32 texture);

			[DllImport(Library, EntryPoint = "glTagSampleBufferSGIX", ExactSpelling = true)]
			internal extern static void glTagSampleBufferSGIX();

			[DllImport(Library, EntryPoint = "glTangent3bEXT", ExactSpelling = true)]
			internal extern static void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz);

			[DllImport(Library, EntryPoint = "glTangent3bvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3bvEXT(sbyte* v);

			[DllImport(Library, EntryPoint = "glTangent3dEXT", ExactSpelling = true)]
			internal extern static void glTangent3dEXT(double tx, double ty, double tz);

			[DllImport(Library, EntryPoint = "glTangent3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3dvEXT(double* v);

			[DllImport(Library, EntryPoint = "glTangent3fEXT", ExactSpelling = true)]
			internal extern static void glTangent3fEXT(float tx, float ty, float tz);

			[DllImport(Library, EntryPoint = "glTangent3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3fvEXT(float* v);

			[DllImport(Library, EntryPoint = "glTangent3iEXT", ExactSpelling = true)]
			internal extern static void glTangent3iEXT(Int32 tx, Int32 ty, Int32 tz);

			[DllImport(Library, EntryPoint = "glTangent3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3ivEXT(Int32* v);

			[DllImport(Library, EntryPoint = "glTangent3sEXT", ExactSpelling = true)]
			internal extern static void glTangent3sEXT(Int16 tx, Int16 ty, Int16 tz);

			[DllImport(Library, EntryPoint = "glTangent3svEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3svEXT(Int16* v);

			[DllImport(Library, EntryPoint = "glTangentPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangentPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glTbufferMask3DFX", ExactSpelling = true)]
			internal extern static void glTbufferMask3DFX(UInt32 mask);

			[DllImport(Library, EntryPoint = "glTessellationFactorAMD", ExactSpelling = true)]
			internal extern static void glTessellationFactorAMD(float factor);

			[DllImport(Library, EntryPoint = "glTessellationModeAMD", ExactSpelling = true)]
			internal extern static void glTessellationModeAMD(Int32 mode);

			[DllImport(Library, EntryPoint = "glTestFenceAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glTestFenceAPPLE(UInt32 fence);

			[DllImport(Library, EntryPoint = "glTestFenceNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glTestFenceNV(UInt32 fence);

			[DllImport(Library, EntryPoint = "glTestObjectAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glTestObjectAPPLE(Int32 @object, UInt32 name);

			[DllImport(Library, EntryPoint = "glTexBuffer", ExactSpelling = true)]
			internal extern static void glTexBuffer(Int32 target, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTexBufferARB", ExactSpelling = true)]
			internal extern static void glTexBufferARB(Int32 target, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTexBufferEXT", ExactSpelling = true)]
			internal extern static void glTexBufferEXT(Int32 target, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTexBufferOES", ExactSpelling = true)]
			internal extern static void glTexBufferOES(Int32 target, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTexBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glTexBufferRange(Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glTexBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexBufferRangeEXT(Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glTexBufferRangeOES", ExactSpelling = true)]
			internal extern static unsafe void glTexBufferRangeOES(Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glTexBumpParameterfvATI", ExactSpelling = true)]
			internal extern static unsafe void glTexBumpParameterfvATI(Int32 pname, float* param);

			[DllImport(Library, EntryPoint = "glTexBumpParameterivATI", ExactSpelling = true)]
			internal extern static unsafe void glTexBumpParameterivATI(Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glTexCoord1bOES", ExactSpelling = true)]
			internal extern static void glTexCoord1bOES(sbyte s);

			[DllImport(Library, EntryPoint = "glTexCoord1bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
			internal extern static void glTexCoord1d(double s);

			[DllImport(Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1dv(double* v);

			[DllImport(Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
			internal extern static void glTexCoord1f(float s);

			[DllImport(Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1fv(float* v);

			[DllImport(Library, EntryPoint = "glTexCoord1hNV", ExactSpelling = true)]
			internal extern static void glTexCoord1hNV(UInt16 s);

			[DllImport(Library, EntryPoint = "glTexCoord1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
			internal extern static void glTexCoord1i(Int32 s);

			[DllImport(Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1iv(Int32* v);

			[DllImport(Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
			internal extern static void glTexCoord1s(Int16 s);

			[DllImport(Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1sv(Int16* v);

			[DllImport(Library, EntryPoint = "glTexCoord1xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1xOES(IntPtr s);

			[DllImport(Library, EntryPoint = "glTexCoord1xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glTexCoord2bOES", ExactSpelling = true)]
			internal extern static void glTexCoord2bOES(sbyte s, sbyte t);

			[DllImport(Library, EntryPoint = "glTexCoord2bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
			internal extern static void glTexCoord2d(double s, double t);

			[DllImport(Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2dv(double* v);

			[DllImport(Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
			internal extern static void glTexCoord2f(float s, float t);

			[DllImport(Library, EntryPoint = "glTexCoord2fColor3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord2fColor4ubVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord2fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glTexCoord2fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fVertex3fvSUN(float* tc, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fv(float* v);

			[DllImport(Library, EntryPoint = "glTexCoord2hNV", ExactSpelling = true)]
			internal extern static void glTexCoord2hNV(UInt16 s, UInt16 t);

			[DllImport(Library, EntryPoint = "glTexCoord2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
			internal extern static void glTexCoord2i(Int32 s, Int32 t);

			[DllImport(Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2iv(Int32* v);

			[DllImport(Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
			internal extern static void glTexCoord2s(Int16 s, Int16 t);

			[DllImport(Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2sv(Int16* v);

			[DllImport(Library, EntryPoint = "glTexCoord2xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2xOES(IntPtr s, IntPtr t);

			[DllImport(Library, EntryPoint = "glTexCoord2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glTexCoord3bOES", ExactSpelling = true)]
			internal extern static void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);

			[DllImport(Library, EntryPoint = "glTexCoord3bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
			internal extern static void glTexCoord3d(double s, double t, double r);

			[DllImport(Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3dv(double* v);

			[DllImport(Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
			internal extern static void glTexCoord3f(float s, float t, float r);

			[DllImport(Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3fv(float* v);

			[DllImport(Library, EntryPoint = "glTexCoord3hNV", ExactSpelling = true)]
			internal extern static void glTexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);

			[DllImport(Library, EntryPoint = "glTexCoord3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
			internal extern static void glTexCoord3i(Int32 s, Int32 t, Int32 r);

			[DllImport(Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
			internal extern static void glTexCoord3s(Int16 s, Int16 t, Int16 r);

			[DllImport(Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glTexCoord3xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3xOES(IntPtr s, IntPtr t, IntPtr r);

			[DllImport(Library, EntryPoint = "glTexCoord3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glTexCoord4bOES", ExactSpelling = true)]
			internal extern static void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);

			[DllImport(Library, EntryPoint = "glTexCoord4bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
			internal extern static void glTexCoord4d(double s, double t, double r, double q);

			[DllImport(Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4dv(double* v);

			[DllImport(Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
			internal extern static void glTexCoord4f(float s, float t, float r, float q);

			[DllImport(Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord4fVertex4fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glTexCoord4fVertex4fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fVertex4fvSUN(float* tc, float* v);

			[DllImport(Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fv(float* v);

			[DllImport(Library, EntryPoint = "glTexCoord4hNV", ExactSpelling = true)]
			internal extern static void glTexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[DllImport(Library, EntryPoint = "glTexCoord4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
			internal extern static void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

			[DllImport(Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4iv(Int32* v);

			[DllImport(Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
			internal extern static void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

			[DllImport(Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4sv(Int16* v);

			[DllImport(Library, EntryPoint = "glTexCoord4xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4xOES(IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[DllImport(Library, EntryPoint = "glTexCoord4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glTexCoordFormatNV", ExactSpelling = true)]
			internal extern static void glTexCoordFormatNV(Int32 size, Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glTexCoordP1ui", ExactSpelling = true)]
			internal extern static void glTexCoordP1ui(Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glTexCoordP1uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP1uiv(Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glTexCoordP2ui", ExactSpelling = true)]
			internal extern static void glTexCoordP2ui(Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glTexCoordP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP2uiv(Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glTexCoordP3ui", ExactSpelling = true)]
			internal extern static void glTexCoordP3ui(Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glTexCoordP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP3uiv(Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glTexCoordP4ui", ExactSpelling = true)]
			internal extern static void glTexCoordP4ui(Int32 type, UInt32 coords);

			[DllImport(Library, EntryPoint = "glTexCoordP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP4uiv(Int32 type, UInt32* coords);

			[DllImport(Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glTexCoordPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordPointerEXT(Int32 size, Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glTexCoordPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glTexCoordPointervINTEL", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordPointervINTEL(Int32 size, Int32 type, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
			internal extern static void glTexEnvf(Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
			internal extern static void glTexEnvi(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexEnvx", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvx(Int32 target, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glTexEnvxOES", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxOES(Int32 target, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glTexEnvxv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glTexEnvxvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glTexFilterFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glTexFilterFuncSGIS(Int32 target, Int32 filter, Int32 n, float* weights);

			[DllImport(Library, EntryPoint = "glTexGend", ExactSpelling = true)]
			internal extern static void glTexGend(Int32 coord, Int32 pname, double param);

			[DllImport(Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
			internal extern static unsafe void glTexGendv(Int32 coord, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
			internal extern static void glTexGenf(Int32 coord, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glTexGenfOES", ExactSpelling = true)]
			internal extern static void glTexGenfOES(Int32 coord, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
			internal extern static unsafe void glTexGenfv(Int32 coord, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glTexGenfvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
			internal extern static void glTexGeni(Int32 coord, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glTexGeniOES", ExactSpelling = true)]
			internal extern static void glTexGeniOES(Int32 coord, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
			internal extern static unsafe void glTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexGenivOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexGenxOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenxOES(Int32 coord, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glTexGenxvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
			internal extern static void glTexImage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTexImage2DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTexImage2DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[DllImport(Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage3D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexImage3DEXT(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
			internal extern static void glTexImage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTexImage3DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTexImage3DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[DllImport(Library, EntryPoint = "glTexImage3DOES", ExactSpelling = true)]
			internal extern static unsafe void glTexImage3DOES(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexImage4DSGIS", ExactSpelling = true)]
			internal extern static unsafe void glTexImage4DSGIS(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexPageCommitmentARB", ExactSpelling = true)]
			internal extern static void glTexPageCommitmentARB(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[DllImport(Library, EntryPoint = "glTexPageCommitmentEXT", ExactSpelling = true)]
			internal extern static void glTexPageCommitmentEXT(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[DllImport(Library, EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterIiv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterIivEXT(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterIivOES", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterIivOES(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterIuiv(Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterIuivEXT(Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterIuivOES", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterIuivOES(Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
			internal extern static void glTexParameterf(Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterfv(Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
			internal extern static void glTexParameteri(Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTexParameterx", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterx(Int32 target, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glTexParameterxOES", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxOES(Int32 target, Int32 pname, IntPtr param);

			[DllImport(Library, EntryPoint = "glTexParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glTexParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[DllImport(Library, EntryPoint = "glTexRenderbufferNV", ExactSpelling = true)]
			internal extern static void glTexRenderbufferNV(Int32 target, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glTexStorage1D", ExactSpelling = true)]
			internal extern static void glTexStorage1D(Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[DllImport(Library, EntryPoint = "glTexStorage1DEXT", ExactSpelling = true)]
			internal extern static void glTexStorage1DEXT(Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[DllImport(Library, EntryPoint = "glTexStorage2D", ExactSpelling = true)]
			internal extern static void glTexStorage2D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glTexStorage2DEXT", ExactSpelling = true)]
			internal extern static void glTexStorage2DEXT(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glTexStorage2DMultisample", ExactSpelling = true)]
			internal extern static void glTexStorage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTexStorage3D", ExactSpelling = true)]
			internal extern static void glTexStorage3D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[DllImport(Library, EntryPoint = "glTexStorage3DEXT", ExactSpelling = true)]
			internal extern static void glTexStorage3DEXT(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[DllImport(Library, EntryPoint = "glTexStorage3DMultisample", ExactSpelling = true)]
			internal extern static void glTexStorage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTexStorage3DMultisampleOES", ExactSpelling = true)]
			internal extern static void glTexStorage3DMultisampleOES(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTexStorageSparseAMD", ExactSpelling = true)]
			internal extern static void glTexStorageSparseAMD(Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[DllImport(Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage1DEXT(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage2DEXT(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage3D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage3DEXT(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage3DOES", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage3DOES(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTexSubImage4DSGIS", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage4DSGIS(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureBarrier", ExactSpelling = true)]
			internal extern static void glTextureBarrier();

			[DllImport(Library, EntryPoint = "glTextureBarrierNV", ExactSpelling = true)]
			internal extern static void glTextureBarrierNV();

			[DllImport(Library, EntryPoint = "glTextureBuffer", ExactSpelling = true)]
			internal extern static void glTextureBuffer(UInt32 texture, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTextureBufferEXT", ExactSpelling = true)]
			internal extern static void glTextureBufferEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTextureBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glTextureBufferRange(UInt32 texture, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glTextureBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureBufferRangeEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glTextureColorMaskSGIS", ExactSpelling = true)]
			internal extern static void glTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);

			[DllImport(Library, EntryPoint = "glTextureImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureImage2DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTextureImage2DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[DllImport(Library, EntryPoint = "glTextureImage2DMultisampleNV", ExactSpelling = true)]
			internal extern static void glTextureImage2DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[DllImport(Library, EntryPoint = "glTextureImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureImage3DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTextureImage3DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[DllImport(Library, EntryPoint = "glTextureImage3DMultisampleNV", ExactSpelling = true)]
			internal extern static void glTextureImage3DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[DllImport(Library, EntryPoint = "glTextureLightEXT", ExactSpelling = true)]
			internal extern static void glTextureLightEXT(Int32 pname);

			[DllImport(Library, EntryPoint = "glTextureMaterialEXT", ExactSpelling = true)]
			internal extern static void glTextureMaterialEXT(Int32 face, Int32 mode);

			[DllImport(Library, EntryPoint = "glTextureNormalEXT", ExactSpelling = true)]
			internal extern static void glTextureNormalEXT(Int32 mode);

			[DllImport(Library, EntryPoint = "glTexturePageCommitmentEXT", ExactSpelling = true)]
			internal extern static void glTexturePageCommitmentEXT(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[DllImport(Library, EntryPoint = "glTextureParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTextureParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTextureParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glTextureParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[DllImport(Library, EntryPoint = "glTextureParameterf", ExactSpelling = true)]
			internal extern static void glTextureParameterf(UInt32 texture, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glTextureParameterfEXT", ExactSpelling = true)]
			internal extern static void glTextureParameterfEXT(UInt32 texture, Int32 target, Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glTextureParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterfv(UInt32 texture, Int32 pname, float* param);

			[DllImport(Library, EntryPoint = "glTextureParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glTextureParameteri", ExactSpelling = true)]
			internal extern static void glTextureParameteri(UInt32 texture, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glTextureParameteriEXT", ExactSpelling = true)]
			internal extern static void glTextureParameteriEXT(UInt32 texture, Int32 target, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glTextureParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameteriv(UInt32 texture, Int32 pname, Int32* param);

			[DllImport(Library, EntryPoint = "glTextureParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glTextureRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glTextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glTextureRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glTextureRenderbufferEXT(UInt32 texture, Int32 target, UInt32 renderbuffer);

			[DllImport(Library, EntryPoint = "glTextureStorage1D", ExactSpelling = true)]
			internal extern static void glTextureStorage1D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width);

			[DllImport(Library, EntryPoint = "glTextureStorage1DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage1DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[DllImport(Library, EntryPoint = "glTextureStorage2D", ExactSpelling = true)]
			internal extern static void glTextureStorage2D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glTextureStorage2DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage2DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glTextureStorage2DMultisample", ExactSpelling = true)]
			internal extern static void glTextureStorage2DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTextureStorage2DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage2DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTextureStorage3D", ExactSpelling = true)]
			internal extern static void glTextureStorage3D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[DllImport(Library, EntryPoint = "glTextureStorage3DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage3DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[DllImport(Library, EntryPoint = "glTextureStorage3DMultisample", ExactSpelling = true)]
			internal extern static void glTextureStorage3DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTextureStorage3DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage3DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[DllImport(Library, EntryPoint = "glTextureStorageSparseAMD", ExactSpelling = true)]
			internal extern static void glTextureStorageSparseAMD(UInt32 texture, Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[DllImport(Library, EntryPoint = "glTextureSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureSubImage3D", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[DllImport(Library, EntryPoint = "glTextureView", ExactSpelling = true)]
			internal extern static void glTextureView(UInt32 texture, Int32 target, UInt32 origtexture, Int32 internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

			[DllImport(Library, EntryPoint = "glTextureViewEXT", ExactSpelling = true)]
			internal extern static void glTextureViewEXT(UInt32 texture, Int32 target, UInt32 origtexture, Int32 internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

			[DllImport(Library, EntryPoint = "glTextureViewOES", ExactSpelling = true)]
			internal extern static void glTextureViewOES(UInt32 texture, Int32 target, UInt32 origtexture, Int32 internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

			[DllImport(Library, EntryPoint = "glTrackMatrixNV", ExactSpelling = true)]
			internal extern static void glTrackMatrixNV(Int32 target, UInt32 address, Int32 matrix, Int32 transform);

			[DllImport(Library, EntryPoint = "glTransformFeedbackAttribsNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackAttribsNV(Int32 count, Int32* attribs, Int32 bufferMode);

			[DllImport(Library, EntryPoint = "glTransformFeedbackBufferBase", ExactSpelling = true)]
			internal extern static void glTransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glTransformFeedbackBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[DllImport(Library, EntryPoint = "glTransformFeedbackStreamAttribsNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, Int32 bufferMode);

			[DllImport(Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
			internal extern static void glTransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, Int32 bufferMode);

			[DllImport(Library, EntryPoint = "glTransformFeedbackVaryingsEXT", ExactSpelling = true)]
			internal extern static void glTransformFeedbackVaryingsEXT(UInt32 program, Int32 count, String[] varyings, Int32 bufferMode);

			[DllImport(Library, EntryPoint = "glTransformFeedbackVaryingsNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, Int32 bufferMode);

			[DllImport(Library, EntryPoint = "glTransformPathNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformPathNV(UInt32 resultPath, UInt32 srcPath, Int32 transformType, float* transformValues);

			[DllImport(Library, EntryPoint = "glTranslated", ExactSpelling = true)]
			internal extern static void glTranslated(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
			internal extern static void glTranslatef(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glTranslatex", ExactSpelling = true)]
			internal extern static unsafe void glTranslatex(IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glTranslatexOES", ExactSpelling = true)]
			internal extern static unsafe void glTranslatexOES(IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glUniform1d", ExactSpelling = true)]
			internal extern static void glUniform1d(Int32 location, double x);

			[DllImport(Library, EntryPoint = "glUniform1dv", ExactSpelling = true)]
			internal extern static unsafe void glUniform1dv(Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
			internal extern static void glUniform1f(Int32 location, float v0);

			[DllImport(Library, EntryPoint = "glUniform1fARB", ExactSpelling = true)]
			internal extern static void glUniform1fARB(Int32 location, float v0);

			[DllImport(Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform1fv(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform1fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform1fvARB(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
			internal extern static void glUniform1i(Int32 location, Int32 v0);

			[DllImport(Library, EntryPoint = "glUniform1i64ARB", ExactSpelling = true)]
			internal extern static void glUniform1i64ARB(Int32 location, Int64 x);

			[DllImport(Library, EntryPoint = "glUniform1i64NV", ExactSpelling = true)]
			internal extern static void glUniform1i64NV(Int32 location, Int64 x);

			[DllImport(Library, EntryPoint = "glUniform1i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform1i64vARB(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform1i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform1i64vNV(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform1iARB", ExactSpelling = true)]
			internal extern static void glUniform1iARB(Int32 location, Int32 v0);

			[DllImport(Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform1iv(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform1ivARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform1ivARB(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform1ui", ExactSpelling = true)]
			internal extern static void glUniform1ui(Int32 location, UInt32 v0);

			[DllImport(Library, EntryPoint = "glUniform1ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform1ui64ARB(Int32 location, UInt64 x);

			[DllImport(Library, EntryPoint = "glUniform1ui64NV", ExactSpelling = true)]
			internal extern static void glUniform1ui64NV(Int32 location, UInt64 x);

			[DllImport(Library, EntryPoint = "glUniform1ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform1ui64vARB(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform1ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform1ui64vNV(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform1uiEXT", ExactSpelling = true)]
			internal extern static void glUniform1uiEXT(Int32 location, UInt32 v0);

			[DllImport(Library, EntryPoint = "glUniform1uiv", ExactSpelling = true)]
			internal extern static unsafe void glUniform1uiv(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform1uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glUniform1uivEXT(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform2d", ExactSpelling = true)]
			internal extern static void glUniform2d(Int32 location, double x, double y);

			[DllImport(Library, EntryPoint = "glUniform2dv", ExactSpelling = true)]
			internal extern static unsafe void glUniform2dv(Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
			internal extern static void glUniform2f(Int32 location, float v0, float v1);

			[DllImport(Library, EntryPoint = "glUniform2fARB", ExactSpelling = true)]
			internal extern static void glUniform2fARB(Int32 location, float v0, float v1);

			[DllImport(Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform2fv(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform2fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform2fvARB(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
			internal extern static void glUniform2i(Int32 location, Int32 v0, Int32 v1);

			[DllImport(Library, EntryPoint = "glUniform2i64ARB", ExactSpelling = true)]
			internal extern static void glUniform2i64ARB(Int32 location, Int64 x, Int64 y);

			[DllImport(Library, EntryPoint = "glUniform2i64NV", ExactSpelling = true)]
			internal extern static void glUniform2i64NV(Int32 location, Int64 x, Int64 y);

			[DllImport(Library, EntryPoint = "glUniform2i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform2i64vARB(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform2i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform2i64vNV(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform2iARB", ExactSpelling = true)]
			internal extern static void glUniform2iARB(Int32 location, Int32 v0, Int32 v1);

			[DllImport(Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform2iv(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform2ivARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform2ivARB(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform2ui", ExactSpelling = true)]
			internal extern static void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1);

			[DllImport(Library, EntryPoint = "glUniform2ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform2ui64ARB(Int32 location, UInt64 x, UInt64 y);

			[DllImport(Library, EntryPoint = "glUniform2ui64NV", ExactSpelling = true)]
			internal extern static void glUniform2ui64NV(Int32 location, UInt64 x, UInt64 y);

			[DllImport(Library, EntryPoint = "glUniform2ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform2ui64vARB(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform2ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform2ui64vNV(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform2uiEXT", ExactSpelling = true)]
			internal extern static void glUniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);

			[DllImport(Library, EntryPoint = "glUniform2uiv", ExactSpelling = true)]
			internal extern static unsafe void glUniform2uiv(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform2uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glUniform2uivEXT(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform3d", ExactSpelling = true)]
			internal extern static void glUniform3d(Int32 location, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glUniform3dv", ExactSpelling = true)]
			internal extern static unsafe void glUniform3dv(Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
			internal extern static void glUniform3f(Int32 location, float v0, float v1, float v2);

			[DllImport(Library, EntryPoint = "glUniform3fARB", ExactSpelling = true)]
			internal extern static void glUniform3fARB(Int32 location, float v0, float v1, float v2);

			[DllImport(Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform3fv(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform3fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform3fvARB(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
			internal extern static void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[DllImport(Library, EntryPoint = "glUniform3i64ARB", ExactSpelling = true)]
			internal extern static void glUniform3i64ARB(Int32 location, Int64 x, Int64 y, Int64 z);

			[DllImport(Library, EntryPoint = "glUniform3i64NV", ExactSpelling = true)]
			internal extern static void glUniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);

			[DllImport(Library, EntryPoint = "glUniform3i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform3i64vARB(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform3i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform3i64vNV(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform3iARB", ExactSpelling = true)]
			internal extern static void glUniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[DllImport(Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform3iv(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform3ivARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform3ivARB(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform3ui", ExactSpelling = true)]
			internal extern static void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[DllImport(Library, EntryPoint = "glUniform3ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform3ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[DllImport(Library, EntryPoint = "glUniform3ui64NV", ExactSpelling = true)]
			internal extern static void glUniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[DllImport(Library, EntryPoint = "glUniform3ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform3ui64vARB(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform3ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform3ui64vNV(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform3uiEXT", ExactSpelling = true)]
			internal extern static void glUniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[DllImport(Library, EntryPoint = "glUniform3uiv", ExactSpelling = true)]
			internal extern static unsafe void glUniform3uiv(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform3uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glUniform3uivEXT(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform4d", ExactSpelling = true)]
			internal extern static void glUniform4d(Int32 location, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glUniform4dv", ExactSpelling = true)]
			internal extern static unsafe void glUniform4dv(Int32 location, Int32 count, double* value);

			[DllImport(Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
			internal extern static void glUniform4f(Int32 location, float v0, float v1, float v2, float v3);

			[DllImport(Library, EntryPoint = "glUniform4fARB", ExactSpelling = true)]
			internal extern static void glUniform4fARB(Int32 location, float v0, float v1, float v2, float v3);

			[DllImport(Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform4fv(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform4fvARB(Int32 location, Int32 count, float* value);

			[DllImport(Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
			internal extern static void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[DllImport(Library, EntryPoint = "glUniform4i64ARB", ExactSpelling = true)]
			internal extern static void glUniform4i64ARB(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[DllImport(Library, EntryPoint = "glUniform4i64NV", ExactSpelling = true)]
			internal extern static void glUniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[DllImport(Library, EntryPoint = "glUniform4i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform4i64vARB(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform4i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform4i64vNV(Int32 location, Int32 count, Int64* value);

			[DllImport(Library, EntryPoint = "glUniform4iARB", ExactSpelling = true)]
			internal extern static void glUniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[DllImport(Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform4iv(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform4ivARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform4ivARB(Int32 location, Int32 count, Int32* value);

			[DllImport(Library, EntryPoint = "glUniform4ui", ExactSpelling = true)]
			internal extern static void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[DllImport(Library, EntryPoint = "glUniform4ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform4ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[DllImport(Library, EntryPoint = "glUniform4ui64NV", ExactSpelling = true)]
			internal extern static void glUniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[DllImport(Library, EntryPoint = "glUniform4ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform4ui64vARB(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform4ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform4ui64vNV(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniform4uiEXT", ExactSpelling = true)]
			internal extern static void glUniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[DllImport(Library, EntryPoint = "glUniform4uiv", ExactSpelling = true)]
			internal extern static unsafe void glUniform4uiv(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniform4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glUniform4uivEXT(Int32 location, Int32 count, UInt32* value);

			[DllImport(Library, EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
			internal extern static void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);

			[DllImport(Library, EntryPoint = "glUniformBufferEXT", ExactSpelling = true)]
			internal extern static void glUniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glUniformHandleui64ARB", ExactSpelling = true)]
			internal extern static void glUniformHandleui64ARB(Int32 location, UInt64 value);

			[DllImport(Library, EntryPoint = "glUniformHandleui64NV", ExactSpelling = true)]
			internal extern static void glUniformHandleui64NV(Int32 location, UInt64 value);

			[DllImport(Library, EntryPoint = "glUniformHandleui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniformHandleui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformHandleui64vNV(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2fvARB(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2x3dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2x3fvNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2x3fvNV(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2x4dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix2x4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2x4fvNV(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3fvARB(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3x2dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3x2fvNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3x2fvNV(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3x4dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix3x4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3x4fvNV(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4fvARB(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4x2dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4x2fvNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4x2fvNV(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4x3dv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, double* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformMatrix4x3fvNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4x3fvNV(Int32 location, Int32 count, bool transpose, float* value);

			[DllImport(Library, EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
			internal extern static unsafe void glUniformSubroutinesuiv(Int32 shadertype, Int32 count, UInt32* indices);

			[DllImport(Library, EntryPoint = "glUniformui64NV", ExactSpelling = true)]
			internal extern static void glUniformui64NV(Int32 location, UInt64 value);

			[DllImport(Library, EntryPoint = "glUniformui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformui64vNV(Int32 location, Int32 count, UInt64* value);

			[DllImport(Library, EntryPoint = "glUnlockArraysEXT", ExactSpelling = true)]
			internal extern static void glUnlockArraysEXT();

			[DllImport(Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapBuffer(Int32 target);

			[DllImport(Library, EntryPoint = "glUnmapBufferARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapBufferARB(Int32 target);

			[DllImport(Library, EntryPoint = "glUnmapBufferOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapBufferOES(Int32 target);

			[DllImport(Library, EntryPoint = "glUnmapNamedBuffer", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapNamedBuffer(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glUnmapNamedBufferEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapNamedBufferEXT(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glUnmapObjectBufferATI", ExactSpelling = true)]
			internal extern static void glUnmapObjectBufferATI(UInt32 buffer);

			[DllImport(Library, EntryPoint = "glUnmapTexture2DINTEL", ExactSpelling = true)]
			internal extern static void glUnmapTexture2DINTEL(UInt32 texture, Int32 level);

			[DllImport(Library, EntryPoint = "glUpdateObjectBufferATI", ExactSpelling = true)]
			internal extern static unsafe void glUpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, Int32 preserve);

			[DllImport(Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
			internal extern static void glUseProgram(UInt32 program);

			[DllImport(Library, EntryPoint = "glUseProgramObjectARB", ExactSpelling = true)]
			internal extern static void glUseProgramObjectARB(UInt32 programObj);

			[DllImport(Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
			internal extern static void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

			[DllImport(Library, EntryPoint = "glUseProgramStagesEXT", ExactSpelling = true)]
			internal extern static void glUseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);

			[DllImport(Library, EntryPoint = "glUseShaderProgramEXT", ExactSpelling = true)]
			internal extern static void glUseShaderProgramEXT(Int32 type, UInt32 program);

			[DllImport(Library, EntryPoint = "glVDPAUFiniNV", ExactSpelling = true)]
			internal extern static void glVDPAUFiniNV();

			[DllImport(Library, EntryPoint = "glVDPAUGetSurfaceivNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUGetSurfaceivNV(IntPtr surface, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[DllImport(Library, EntryPoint = "glVDPAUInitNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);

			[DllImport(Library, EntryPoint = "glVDPAUIsSurfaceNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glVDPAUIsSurfaceNV(IntPtr surface);

			[DllImport(Library, EntryPoint = "glVDPAUMapSurfacesNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);

			[DllImport(Library, EntryPoint = "glVDPAURegisterOutputSurfaceNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[DllImport(Library, EntryPoint = "glVDPAURegisterVideoSurfaceNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[DllImport(Library, EntryPoint = "glVDPAUSurfaceAccessNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUSurfaceAccessNV(IntPtr surface, Int32 access);

			[DllImport(Library, EntryPoint = "glVDPAUUnmapSurfacesNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);

			[DllImport(Library, EntryPoint = "glVDPAUUnregisterSurfaceNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUUnregisterSurfaceNV(IntPtr surface);

			[DllImport(Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
			internal extern static void glValidateProgram(UInt32 program);

			[DllImport(Library, EntryPoint = "glValidateProgramARB", ExactSpelling = true)]
			internal extern static void glValidateProgramARB(UInt32 programObj);

			[DllImport(Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
			internal extern static void glValidateProgramPipeline(UInt32 pipeline);

			[DllImport(Library, EntryPoint = "glValidateProgramPipelineEXT", ExactSpelling = true)]
			internal extern static void glValidateProgramPipelineEXT(UInt32 pipeline);

			[DllImport(Library, EntryPoint = "glVariantArrayObjectATI", ExactSpelling = true)]
			internal extern static void glVariantArrayObjectATI(UInt32 id, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset);

			[DllImport(Library, EntryPoint = "glVariantPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantPointerEXT(UInt32 id, Int32 type, UInt32 stride, IntPtr addr);

			[DllImport(Library, EntryPoint = "glVariantbvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantbvEXT(UInt32 id, sbyte* addr);

			[DllImport(Library, EntryPoint = "glVariantdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantdvEXT(UInt32 id, double* addr);

			[DllImport(Library, EntryPoint = "glVariantfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantfvEXT(UInt32 id, float* addr);

			[DllImport(Library, EntryPoint = "glVariantivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantivEXT(UInt32 id, Int32* addr);

			[DllImport(Library, EntryPoint = "glVariantsvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantsvEXT(UInt32 id, Int16* addr);

			[DllImport(Library, EntryPoint = "glVariantubvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantubvEXT(UInt32 id, byte* addr);

			[DllImport(Library, EntryPoint = "glVariantuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantuivEXT(UInt32 id, UInt32* addr);

			[DllImport(Library, EntryPoint = "glVariantusvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVariantusvEXT(UInt32 id, UInt16* addr);

			[DllImport(Library, EntryPoint = "glVertex2bOES", ExactSpelling = true)]
			internal extern static void glVertex2bOES(sbyte x, sbyte y);

			[DllImport(Library, EntryPoint = "glVertex2bvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex2bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
			internal extern static void glVertex2d(double x, double y);

			[DllImport(Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2dv(double* v);

			[DllImport(Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
			internal extern static void glVertex2f(float x, float y);

			[DllImport(Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2fv(float* v);

			[DllImport(Library, EntryPoint = "glVertex2hNV", ExactSpelling = true)]
			internal extern static void glVertex2hNV(UInt16 x, UInt16 y);

			[DllImport(Library, EntryPoint = "glVertex2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertex2hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
			internal extern static void glVertex2i(Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2iv(Int32* v);

			[DllImport(Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
			internal extern static void glVertex2s(Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2sv(Int16* v);

			[DllImport(Library, EntryPoint = "glVertex2xOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex2xOES(IntPtr x);

			[DllImport(Library, EntryPoint = "glVertex2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex2xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glVertex3bOES", ExactSpelling = true)]
			internal extern static void glVertex3bOES(sbyte x, sbyte y, sbyte z);

			[DllImport(Library, EntryPoint = "glVertex3bvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex3bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
			internal extern static void glVertex3d(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3dv(double* v);

			[DllImport(Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
			internal extern static void glVertex3f(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3fv(float* v);

			[DllImport(Library, EntryPoint = "glVertex3hNV", ExactSpelling = true)]
			internal extern static void glVertex3hNV(UInt16 x, UInt16 y, UInt16 z);

			[DllImport(Library, EntryPoint = "glVertex3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertex3hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
			internal extern static void glVertex3i(Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
			internal extern static void glVertex3s(Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glVertex3xOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex3xOES(IntPtr x, IntPtr y);

			[DllImport(Library, EntryPoint = "glVertex3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex3xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glVertex4bOES", ExactSpelling = true)]
			internal extern static void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);

			[DllImport(Library, EntryPoint = "glVertex4bvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex4bvOES(sbyte* coords);

			[DllImport(Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
			internal extern static void glVertex4d(double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4dv(double* v);

			[DllImport(Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
			internal extern static void glVertex4f(float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4fv(float* v);

			[DllImport(Library, EntryPoint = "glVertex4hNV", ExactSpelling = true)]
			internal extern static void glVertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[DllImport(Library, EntryPoint = "glVertex4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertex4hvNV(UInt16* v);

			[DllImport(Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
			internal extern static void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4iv(Int32* v);

			[DllImport(Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
			internal extern static void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4sv(Int16* v);

			[DllImport(Library, EntryPoint = "glVertex4xOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex4xOES(IntPtr x, IntPtr y, IntPtr z);

			[DllImport(Library, EntryPoint = "glVertex4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex4xvOES(IntPtr* coords);

			[DllImport(Library, EntryPoint = "glVertexArrayAttribBinding", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[DllImport(Library, EntryPoint = "glVertexArrayAttribFormat", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexArrayAttribIFormat", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexArrayAttribLFormat", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexArrayBindVertexBufferEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayBindVertexBufferEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[DllImport(Library, EntryPoint = "glVertexArrayBindingDivisor", ExactSpelling = true)]
			internal extern static void glVertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexArrayColorOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayEdgeFlagOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayEdgeFlagOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayElementBuffer", ExactSpelling = true)]
			internal extern static void glVertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);

			[DllImport(Library, EntryPoint = "glVertexArrayFogCoordOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayFogCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayIndexOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayIndexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayMultiTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayNormalOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayNormalOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayParameteriAPPLE", ExactSpelling = true)]
			internal extern static void glVertexArrayParameteriAPPLE(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glVertexArrayRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexArrayRangeNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayRangeNV(Int32 length, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexArraySecondaryColorOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArraySecondaryColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayTexCoordOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribBindingEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribBindingEXT(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribDivisorEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribDivisorEXT(UInt32 vaobj, UInt32 index, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribFormatEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribIFormatEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribIFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribIOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexAttribIOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribLFormatEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribLFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexAttribOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexBindingDivisorEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexBindingDivisorEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexBuffer", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexBuffers", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);

			[DllImport(Library, EntryPoint = "glVertexArrayVertexOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[DllImport(Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
			internal extern static void glVertexAttrib1d(UInt32 index, double x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1dARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib1dARB(UInt32 index, double x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1dNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib1dNV(UInt32 index, double x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1dvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1dvARB(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1dvNV(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
			internal extern static void glVertexAttrib1f(UInt32 index, float x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1fARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib1fARB(UInt32 index, float x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1fNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib1fNV(UInt32 index, float x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1fv(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1fvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1fvARB(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1fvNV(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib1hNV(UInt32 index, UInt16 x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1hvNV(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
			internal extern static void glVertexAttrib1s(UInt32 index, Int16 x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1sARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib1sARB(UInt32 index, Int16 x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1sNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib1sNV(UInt32 index, Int16 x);

			[DllImport(Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1sv(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1svARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1svARB(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib1svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1svNV(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
			internal extern static void glVertexAttrib2d(UInt32 index, double x, double y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2dARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib2dARB(UInt32 index, double x, double y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2dNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib2dNV(UInt32 index, double x, double y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2dvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2dvARB(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2dvNV(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
			internal extern static void glVertexAttrib2f(UInt32 index, float x, float y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2fARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib2fARB(UInt32 index, float x, float y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2fNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib2fNV(UInt32 index, float x, float y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2fv(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2fvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2fvARB(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2fvNV(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2hvNV(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
			internal extern static void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2sARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2sNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2sv(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2svARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2svARB(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib2svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2svNV(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
			internal extern static void glVertexAttrib3d(UInt32 index, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3dARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib3dARB(UInt32 index, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3dNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib3dNV(UInt32 index, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3dvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3dvARB(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3dvNV(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
			internal extern static void glVertexAttrib3f(UInt32 index, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3fARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib3fARB(UInt32 index, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3fNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib3fNV(UInt32 index, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3fv(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3fvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3fvARB(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3fvNV(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3hvNV(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
			internal extern static void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3sARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3sNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3sv(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3svARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3svARB(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib3svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3svNV(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nbv(UInt32 index, sbyte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NbvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4NbvARB(UInt32 index, sbyte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Niv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NivARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4NivARB(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nsv(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NsvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4NsvARB(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
			internal extern static void glVertexAttrib4Nub(UInt32 index, byte x, byte y, byte z, byte w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NubARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib4NubARB(UInt32 index, byte x, byte y, byte z, byte w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nubv(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NubvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4NubvARB(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nuiv(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NuivARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4NuivARB(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nusv(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4NusvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4NusvARB(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4bv(UInt32 index, sbyte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4bvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4bvARB(UInt32 index, sbyte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
			internal extern static void glVertexAttrib4d(UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4dARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib4dARB(UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4dNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib4dNV(UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4dvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4dvARB(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4dvNV(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
			internal extern static void glVertexAttrib4f(UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4fARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib4fARB(UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4fNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib4fNV(UInt32 index, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4fv(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4fvARB(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4fvNV(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4hvNV(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4iv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4ivARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4ivARB(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
			internal extern static void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4sARB", ExactSpelling = true)]
			internal extern static void glVertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4sNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4sv(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4svARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4svARB(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4svNV(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4ubNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib4ubNV(UInt32 index, byte x, byte y, byte z, byte w);

			[DllImport(Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4ubv(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4ubvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4ubvARB(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4ubvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4ubvNV(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4uiv(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4uivARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4uivARB(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4usv(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttrib4usvARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4usvARB(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribArrayObjectATI", ExactSpelling = true)]
			internal extern static void glVertexAttribArrayObjectATI(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);

			[DllImport(Library, EntryPoint = "glVertexAttribBinding", ExactSpelling = true)]
			internal extern static void glVertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);

			[DllImport(Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
			internal extern static void glVertexAttribDivisor(UInt32 index, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexAttribDivisorANGLE", ExactSpelling = true)]
			internal extern static void glVertexAttribDivisorANGLE(UInt32 index, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexAttribDivisorARB", ExactSpelling = true)]
			internal extern static void glVertexAttribDivisorARB(UInt32 index, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexAttribDivisorEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribDivisorEXT(UInt32 index, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexAttribDivisorNV", ExactSpelling = true)]
			internal extern static void glVertexAttribDivisorNV(UInt32 index, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexAttribFormat", ExactSpelling = true)]
			internal extern static void glVertexAttribFormat(UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexAttribFormatNV", ExactSpelling = true)]
			internal extern static void glVertexAttribFormatNV(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride);

			[DllImport(Library, EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
			internal extern static void glVertexAttribI1i(UInt32 index, Int32 x);

			[DllImport(Library, EntryPoint = "glVertexAttribI1iEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI1iEXT(UInt32 index, Int32 x);

			[DllImport(Library, EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI1iv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI1ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI1ivEXT(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
			internal extern static void glVertexAttribI1ui(UInt32 index, UInt32 x);

			[DllImport(Library, EntryPoint = "glVertexAttribI1uiEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI1uiEXT(UInt32 index, UInt32 x);

			[DllImport(Library, EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI1uiv(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI1uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI1uivEXT(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
			internal extern static void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glVertexAttribI2iEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI2iv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI2ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI2ivEXT(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
			internal extern static void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);

			[DllImport(Library, EntryPoint = "glVertexAttribI2uiEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);

			[DllImport(Library, EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI2uiv(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI2uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI2uivEXT(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
			internal extern static void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glVertexAttribI3iEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI3iv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI3ivEXT(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
			internal extern static void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);

			[DllImport(Library, EntryPoint = "glVertexAttribI3uiEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);

			[DllImport(Library, EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI3uiv(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI3uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI3uivEXT(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4bv(UInt32 index, sbyte* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4bvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4bvEXT(UInt32 index, sbyte* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
			internal extern static void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glVertexAttribI4iEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4iv(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4ivEXT(UInt32 index, Int32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4sv(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4svEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4svEXT(UInt32 index, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4ubv(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4ubvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4ubvEXT(UInt32 index, byte* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
			internal extern static void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[DllImport(Library, EntryPoint = "glVertexAttribI4uiEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[DllImport(Library, EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4uiv(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4uivEXT(UInt32 index, UInt32* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4usv(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribI4usvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribI4usvEXT(UInt32 index, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribIFormat", ExactSpelling = true)]
			internal extern static void glVertexAttribIFormat(UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexAttribIFormatNV", ExactSpelling = true)]
			internal extern static void glVertexAttribIFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribIPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribIPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribIPointerEXT(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
			internal extern static void glVertexAttribL1d(UInt32 index, double x);

			[DllImport(Library, EntryPoint = "glVertexAttribL1dEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribL1dEXT(UInt32 index, double x);

			[DllImport(Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL1dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1dvEXT(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL1i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL1i64NV(UInt32 index, Int64 x);

			[DllImport(Library, EntryPoint = "glVertexAttribL1i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1i64vNV(UInt32 index, Int64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64ARB", ExactSpelling = true)]
			internal extern static void glVertexAttribL1ui64ARB(UInt32 index, UInt64 x);

			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);

			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1ui64vARB(UInt32 index, UInt64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
			internal extern static void glVertexAttribL2d(UInt32 index, double x, double y);

			[DllImport(Library, EntryPoint = "glVertexAttribL2dEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribL2dEXT(UInt32 index, double x, double y);

			[DllImport(Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2dvEXT(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL2i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);

			[DllImport(Library, EntryPoint = "glVertexAttribL2i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2i64vNV(UInt32 index, Int64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL2ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);

			[DllImport(Library, EntryPoint = "glVertexAttribL2ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
			internal extern static void glVertexAttribL3d(UInt32 index, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertexAttribL3dEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribL3dEXT(UInt32 index, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3dvEXT(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL3i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);

			[DllImport(Library, EntryPoint = "glVertexAttribL3i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3i64vNV(UInt32 index, Int64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL3ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);

			[DllImport(Library, EntryPoint = "glVertexAttribL3ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
			internal extern static void glVertexAttribL4d(UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertexAttribL4dEXT", ExactSpelling = true)]
			internal extern static void glVertexAttribL4dEXT(UInt32 index, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4dv(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4dvEXT(UInt32 index, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL4i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);

			[DllImport(Library, EntryPoint = "glVertexAttribL4i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4i64vNV(UInt32 index, Int64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribL4ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[DllImport(Library, EntryPoint = "glVertexAttribL4ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);

			[DllImport(Library, EntryPoint = "glVertexAttribLFormat", ExactSpelling = true)]
			internal extern static void glVertexAttribLFormat(UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[DllImport(Library, EntryPoint = "glVertexAttribLFormatNV", ExactSpelling = true)]
			internal extern static void glVertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribLPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribLPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribLPointerEXT(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP1ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexAttribP1uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP1uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP2ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexAttribP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP2uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP3ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexAttribP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP3uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP4ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexAttribP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP4uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexAttribParameteriAMD", ExactSpelling = true)]
			internal extern static void glVertexAttribParameteriAMD(UInt32 index, Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribPointer(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribPointerARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribPointerARB(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribPointerNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexAttribs1dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1dvNV(UInt32 index, Int32 count, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs1fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1fvNV(UInt32 index, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs1svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs2dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2dvNV(UInt32 index, Int32 count, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs2fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2fvNV(UInt32 index, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs2svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs3dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3dvNV(UInt32 index, Int32 count, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs3fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3fvNV(UInt32 index, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs3svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4dvNV(UInt32 index, Int32 count, double* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4fvNV(UInt32 index, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs4svNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);

			[DllImport(Library, EntryPoint = "glVertexAttribs4ubvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4ubvNV(UInt32 index, Int32 count, byte* v);

			[DllImport(Library, EntryPoint = "glVertexBindingDivisor", ExactSpelling = true)]
			internal extern static void glVertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);

			[DllImport(Library, EntryPoint = "glVertexBlendARB", ExactSpelling = true)]
			internal extern static void glVertexBlendARB(Int32 count);

			[DllImport(Library, EntryPoint = "glVertexBlendEnvfATI", ExactSpelling = true)]
			internal extern static void glVertexBlendEnvfATI(Int32 pname, float param);

			[DllImport(Library, EntryPoint = "glVertexBlendEnviATI", ExactSpelling = true)]
			internal extern static void glVertexBlendEnviATI(Int32 pname, Int32 param);

			[DllImport(Library, EntryPoint = "glVertexFormatNV", ExactSpelling = true)]
			internal extern static void glVertexFormatNV(Int32 size, Int32 type, Int32 stride);

			[DllImport(Library, EntryPoint = "glVertexP2ui", ExactSpelling = true)]
			internal extern static void glVertexP2ui(Int32 type, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexP2uiv(Int32 type, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexP3ui", ExactSpelling = true)]
			internal extern static void glVertexP3ui(Int32 type, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexP3uiv(Int32 type, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexP4ui", ExactSpelling = true)]
			internal extern static void glVertexP4ui(Int32 type, UInt32 value);

			[DllImport(Library, EntryPoint = "glVertexP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexP4uiv(Int32 type, UInt32* value);

			[DllImport(Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexPointerEXT(Int32 size, Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glVertexPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[DllImport(Library, EntryPoint = "glVertexPointervINTEL", ExactSpelling = true)]
			internal extern static unsafe void glVertexPointervINTEL(Int32 size, Int32 type, IntPtr* pointer);

			[DllImport(Library, EntryPoint = "glVertexStream1dATI", ExactSpelling = true)]
			internal extern static void glVertexStream1dATI(Int32 stream, double x);

			[DllImport(Library, EntryPoint = "glVertexStream1dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1dvATI(Int32 stream, double* coords);

			[DllImport(Library, EntryPoint = "glVertexStream1fATI", ExactSpelling = true)]
			internal extern static void glVertexStream1fATI(Int32 stream, float x);

			[DllImport(Library, EntryPoint = "glVertexStream1fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1fvATI(Int32 stream, float* coords);

			[DllImport(Library, EntryPoint = "glVertexStream1iATI", ExactSpelling = true)]
			internal extern static void glVertexStream1iATI(Int32 stream, Int32 x);

			[DllImport(Library, EntryPoint = "glVertexStream1ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1ivATI(Int32 stream, Int32* coords);

			[DllImport(Library, EntryPoint = "glVertexStream1sATI", ExactSpelling = true)]
			internal extern static void glVertexStream1sATI(Int32 stream, Int16 x);

			[DllImport(Library, EntryPoint = "glVertexStream1svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1svATI(Int32 stream, Int16* coords);

			[DllImport(Library, EntryPoint = "glVertexStream2dATI", ExactSpelling = true)]
			internal extern static void glVertexStream2dATI(Int32 stream, double x, double y);

			[DllImport(Library, EntryPoint = "glVertexStream2dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2dvATI(Int32 stream, double* coords);

			[DllImport(Library, EntryPoint = "glVertexStream2fATI", ExactSpelling = true)]
			internal extern static void glVertexStream2fATI(Int32 stream, float x, float y);

			[DllImport(Library, EntryPoint = "glVertexStream2fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2fvATI(Int32 stream, float* coords);

			[DllImport(Library, EntryPoint = "glVertexStream2iATI", ExactSpelling = true)]
			internal extern static void glVertexStream2iATI(Int32 stream, Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glVertexStream2ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2ivATI(Int32 stream, Int32* coords);

			[DllImport(Library, EntryPoint = "glVertexStream2sATI", ExactSpelling = true)]
			internal extern static void glVertexStream2sATI(Int32 stream, Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glVertexStream2svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2svATI(Int32 stream, Int16* coords);

			[DllImport(Library, EntryPoint = "glVertexStream3dATI", ExactSpelling = true)]
			internal extern static void glVertexStream3dATI(Int32 stream, double x, double y, double z);

			[DllImport(Library, EntryPoint = "glVertexStream3dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3dvATI(Int32 stream, double* coords);

			[DllImport(Library, EntryPoint = "glVertexStream3fATI", ExactSpelling = true)]
			internal extern static void glVertexStream3fATI(Int32 stream, float x, float y, float z);

			[DllImport(Library, EntryPoint = "glVertexStream3fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3fvATI(Int32 stream, float* coords);

			[DllImport(Library, EntryPoint = "glVertexStream3iATI", ExactSpelling = true)]
			internal extern static void glVertexStream3iATI(Int32 stream, Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glVertexStream3ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3ivATI(Int32 stream, Int32* coords);

			[DllImport(Library, EntryPoint = "glVertexStream3sATI", ExactSpelling = true)]
			internal extern static void glVertexStream3sATI(Int32 stream, Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glVertexStream3svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3svATI(Int32 stream, Int16* coords);

			[DllImport(Library, EntryPoint = "glVertexStream4dATI", ExactSpelling = true)]
			internal extern static void glVertexStream4dATI(Int32 stream, double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glVertexStream4dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4dvATI(Int32 stream, double* coords);

			[DllImport(Library, EntryPoint = "glVertexStream4fATI", ExactSpelling = true)]
			internal extern static void glVertexStream4fATI(Int32 stream, float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glVertexStream4fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4fvATI(Int32 stream, float* coords);

			[DllImport(Library, EntryPoint = "glVertexStream4iATI", ExactSpelling = true)]
			internal extern static void glVertexStream4iATI(Int32 stream, Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glVertexStream4ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4ivATI(Int32 stream, Int32* coords);

			[DllImport(Library, EntryPoint = "glVertexStream4sATI", ExactSpelling = true)]
			internal extern static void glVertexStream4sATI(Int32 stream, Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glVertexStream4svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4svATI(Int32 stream, Int16* coords);

			[DllImport(Library, EntryPoint = "glVertexWeightPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexWeightPointerEXT(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glVertexWeightfEXT", ExactSpelling = true)]
			internal extern static void glVertexWeightfEXT(float weight);

			[DllImport(Library, EntryPoint = "glVertexWeightfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexWeightfvEXT(float* weight);

			[DllImport(Library, EntryPoint = "glVertexWeighthNV", ExactSpelling = true)]
			internal extern static void glVertexWeighthNV(UInt16 weight);

			[DllImport(Library, EntryPoint = "glVertexWeighthvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexWeighthvNV(UInt16* weight);

			[DllImport(Library, EntryPoint = "glVideoCaptureNV", ExactSpelling = true)]
			internal extern static unsafe Int32 glVideoCaptureNV(UInt32 video_capture_slot, UInt32* sequence_num, UInt64* capture_time);

			[DllImport(Library, EntryPoint = "glVideoCaptureStreamParameterdvNV", ExactSpelling = true)]
			internal extern static unsafe void glVideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			[DllImport(Library, EntryPoint = "glVideoCaptureStreamParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glVideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			[DllImport(Library, EntryPoint = "glVideoCaptureStreamParameterivNV", ExactSpelling = true)]
			internal extern static unsafe void glVideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			[DllImport(Library, EntryPoint = "glViewport", ExactSpelling = true)]
			internal extern static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

			[DllImport(Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
			internal extern static unsafe void glViewportArrayv(UInt32 first, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glViewportArrayvNV", ExactSpelling = true)]
			internal extern static unsafe void glViewportArrayvNV(UInt32 first, Int32 count, float* v);

			[DllImport(Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
			internal extern static void glViewportIndexedf(UInt32 index, float x, float y, float w, float h);

			[DllImport(Library, EntryPoint = "glViewportIndexedfNV", ExactSpelling = true)]
			internal extern static void glViewportIndexedfNV(UInt32 index, float x, float y, float w, float h);

			[DllImport(Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
			internal extern static unsafe void glViewportIndexedfv(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glViewportIndexedfvNV", ExactSpelling = true)]
			internal extern static unsafe void glViewportIndexedfvNV(UInt32 index, float* v);

			[DllImport(Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
			internal extern static void glWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "glWaitSyncAPPLE", ExactSpelling = true)]
			internal extern static void glWaitSyncAPPLE(Int32 sync, UInt32 flags, UInt64 timeout);

			[DllImport(Library, EntryPoint = "glWeightPathsNV", ExactSpelling = true)]
			internal extern static unsafe void glWeightPathsNV(UInt32 resultPath, Int32 numPaths, UInt32* paths, float* weights);

			[DllImport(Library, EntryPoint = "glWeightPointerARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glWeightPointerOES", ExactSpelling = true)]
			internal extern static unsafe void glWeightPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[DllImport(Library, EntryPoint = "glWeightbvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightbvARB(Int32 size, sbyte* weights);

			[DllImport(Library, EntryPoint = "glWeightdvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightdvARB(Int32 size, double* weights);

			[DllImport(Library, EntryPoint = "glWeightfvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightfvARB(Int32 size, float* weights);

			[DllImport(Library, EntryPoint = "glWeightivARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightivARB(Int32 size, Int32* weights);

			[DllImport(Library, EntryPoint = "glWeightsvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightsvARB(Int32 size, Int16* weights);

			[DllImport(Library, EntryPoint = "glWeightubvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightubvARB(Int32 size, byte* weights);

			[DllImport(Library, EntryPoint = "glWeightuivARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightuivARB(Int32 size, UInt32* weights);

			[DllImport(Library, EntryPoint = "glWeightusvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightusvARB(Int32 size, UInt16* weights);

			[DllImport(Library, EntryPoint = "glWindowPos2d", ExactSpelling = true)]
			internal extern static void glWindowPos2d(double x, double y);

			[DllImport(Library, EntryPoint = "glWindowPos2dARB", ExactSpelling = true)]
			internal extern static void glWindowPos2dARB(double x, double y);

			[DllImport(Library, EntryPoint = "glWindowPos2dMESA", ExactSpelling = true)]
			internal extern static void glWindowPos2dMESA(double x, double y);

			[DllImport(Library, EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2dv(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos2dvARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2dvARB(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos2dvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2dvMESA(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos2f", ExactSpelling = true)]
			internal extern static void glWindowPos2f(float x, float y);

			[DllImport(Library, EntryPoint = "glWindowPos2fARB", ExactSpelling = true)]
			internal extern static void glWindowPos2fARB(float x, float y);

			[DllImport(Library, EntryPoint = "glWindowPos2fMESA", ExactSpelling = true)]
			internal extern static void glWindowPos2fMESA(float x, float y);

			[DllImport(Library, EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2fv(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos2fvARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2fvARB(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos2fvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2fvMESA(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos2i", ExactSpelling = true)]
			internal extern static void glWindowPos2i(Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glWindowPos2iARB", ExactSpelling = true)]
			internal extern static void glWindowPos2iARB(Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glWindowPos2iMESA", ExactSpelling = true)]
			internal extern static void glWindowPos2iMESA(Int32 x, Int32 y);

			[DllImport(Library, EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2iv(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos2ivARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2ivARB(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos2ivMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2ivMESA(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos2s", ExactSpelling = true)]
			internal extern static void glWindowPos2s(Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glWindowPos2sARB", ExactSpelling = true)]
			internal extern static void glWindowPos2sARB(Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glWindowPos2sMESA", ExactSpelling = true)]
			internal extern static void glWindowPos2sMESA(Int16 x, Int16 y);

			[DllImport(Library, EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2sv(Int16* v);

			[DllImport(Library, EntryPoint = "glWindowPos2svARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2svARB(Int16* v);

			[DllImport(Library, EntryPoint = "glWindowPos2svMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2svMESA(Int16* v);

			[DllImport(Library, EntryPoint = "glWindowPos3d", ExactSpelling = true)]
			internal extern static void glWindowPos3d(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glWindowPos3dARB", ExactSpelling = true)]
			internal extern static void glWindowPos3dARB(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glWindowPos3dMESA", ExactSpelling = true)]
			internal extern static void glWindowPos3dMESA(double x, double y, double z);

			[DllImport(Library, EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3dv(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos3dvARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3dvARB(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos3dvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3dvMESA(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos3f", ExactSpelling = true)]
			internal extern static void glWindowPos3f(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glWindowPos3fARB", ExactSpelling = true)]
			internal extern static void glWindowPos3fARB(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glWindowPos3fMESA", ExactSpelling = true)]
			internal extern static void glWindowPos3fMESA(float x, float y, float z);

			[DllImport(Library, EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3fv(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos3fvARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3fvARB(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos3fvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3fvMESA(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos3i", ExactSpelling = true)]
			internal extern static void glWindowPos3i(Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glWindowPos3iARB", ExactSpelling = true)]
			internal extern static void glWindowPos3iARB(Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glWindowPos3iMESA", ExactSpelling = true)]
			internal extern static void glWindowPos3iMESA(Int32 x, Int32 y, Int32 z);

			[DllImport(Library, EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3iv(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos3ivARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3ivARB(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos3ivMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3ivMESA(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos3s", ExactSpelling = true)]
			internal extern static void glWindowPos3s(Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glWindowPos3sARB", ExactSpelling = true)]
			internal extern static void glWindowPos3sARB(Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glWindowPos3sMESA", ExactSpelling = true)]
			internal extern static void glWindowPos3sMESA(Int16 x, Int16 y, Int16 z);

			[DllImport(Library, EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3sv(Int16* v);

			[DllImport(Library, EntryPoint = "glWindowPos3svARB", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3svARB(Int16* v);

			[DllImport(Library, EntryPoint = "glWindowPos3svMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3svMESA(Int16* v);

			[DllImport(Library, EntryPoint = "glWindowPos4dMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4dMESA(double x, double y, double z, double w);

			[DllImport(Library, EntryPoint = "glWindowPos4dvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4dvMESA(double* v);

			[DllImport(Library, EntryPoint = "glWindowPos4fMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4fMESA(float x, float y, float z, float w);

			[DllImport(Library, EntryPoint = "glWindowPos4fvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4fvMESA(float* v);

			[DllImport(Library, EntryPoint = "glWindowPos4iMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);

			[DllImport(Library, EntryPoint = "glWindowPos4ivMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4ivMESA(Int32* v);

			[DllImport(Library, EntryPoint = "glWindowPos4sMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);

			[DllImport(Library, EntryPoint = "glWindowPos4svMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4svMESA(Int16* v);

			[DllImport(Library, EntryPoint = "glWriteMaskEXT", ExactSpelling = true)]
			internal extern static void glWriteMaskEXT(UInt32 res, UInt32 @in, Int32 outX, Int32 outY, Int32 outZ, Int32 outW);

		}
	}

}

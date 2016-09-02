
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
	public unsafe partial class Gl
	{
		internal unsafe static partial class Delegates
		{
			internal delegate void glAccum(Int32 op, float value);

			[ThreadStatic]
			internal static glAccum pglAccum;

			internal unsafe delegate void glAccumxOES(Int32 op, IntPtr value);

			[ThreadStatic]
			internal static glAccumxOES pglAccumxOES;

			internal delegate void glActiveProgramEXT(UInt32 program);

			[ThreadStatic]
			internal static glActiveProgramEXT pglActiveProgramEXT;

			internal delegate void glActiveShaderProgram(UInt32 pipeline, UInt32 program);

			[ThreadStatic]
			internal static glActiveShaderProgram pglActiveShaderProgram;

			internal delegate void glActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);

			[ThreadStatic]
			internal static glActiveShaderProgramEXT pglActiveShaderProgramEXT;

			internal delegate void glActiveStencilFaceEXT(Int32 face);

			[ThreadStatic]
			internal static glActiveStencilFaceEXT pglActiveStencilFaceEXT;

			internal delegate void glActiveTexture(Int32 texture);

			[AliasOf("glActiveTexture")]
			[AliasOf("glActiveTextureARB")]
			[ThreadStatic]
			internal static glActiveTexture pglActiveTexture;

			internal delegate void glActiveVaryingNV(UInt32 program, String name);

			[ThreadStatic]
			internal static glActiveVaryingNV pglActiveVaryingNV;

			internal delegate void glAlphaFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[ThreadStatic]
			internal static glAlphaFragmentOp1ATI pglAlphaFragmentOp1ATI;

			internal delegate void glAlphaFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[ThreadStatic]
			internal static glAlphaFragmentOp2ATI pglAlphaFragmentOp2ATI;

			internal delegate void glAlphaFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[ThreadStatic]
			internal static glAlphaFragmentOp3ATI pglAlphaFragmentOp3ATI;

			internal delegate void glAlphaFunc(Int32 func, float @ref);

			[ThreadStatic]
			internal static glAlphaFunc pglAlphaFunc;

			internal delegate void glAlphaFuncQCOM(Int32 func, float @ref);

			[ThreadStatic]
			internal static glAlphaFuncQCOM pglAlphaFuncQCOM;

			internal unsafe delegate void glAlphaFuncx(Int32 func, IntPtr @ref);

			[ThreadStatic]
			internal static glAlphaFuncx pglAlphaFuncx;

			internal unsafe delegate void glAlphaFuncxOES(Int32 func, IntPtr @ref);

			[ThreadStatic]
			internal static glAlphaFuncxOES pglAlphaFuncxOES;

			internal delegate void glApplyFramebufferAttachmentCMAAINTEL();

			[ThreadStatic]
			internal static glApplyFramebufferAttachmentCMAAINTEL pglApplyFramebufferAttachmentCMAAINTEL;

			internal delegate void glApplyTextureEXT(Int32 mode);

			[ThreadStatic]
			internal static glApplyTextureEXT pglApplyTextureEXT;

			internal unsafe delegate bool glAreProgramsResidentNV(Int32 n, UInt32* programs, bool* residences);

			[ThreadStatic]
			internal static glAreProgramsResidentNV pglAreProgramsResidentNV;

			internal unsafe delegate bool glAreTexturesResident(Int32 n, UInt32* textures, bool* residences);

			[ThreadStatic]
			internal static glAreTexturesResident pglAreTexturesResident;

			internal unsafe delegate bool glAreTexturesResidentEXT(Int32 n, UInt32* textures, bool* residences);

			[ThreadStatic]
			internal static glAreTexturesResidentEXT pglAreTexturesResidentEXT;

			internal delegate void glArrayElement(Int32 i);

			[AliasOf("glArrayElement")]
			[AliasOf("glArrayElementEXT")]
			[ThreadStatic]
			internal static glArrayElement pglArrayElement;

			internal delegate void glArrayObjectATI(Int32 array, Int32 size, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset);

			[ThreadStatic]
			internal static glArrayObjectATI pglArrayObjectATI;

			internal delegate void glAsyncMarkerSGIX(UInt32 marker);

			[ThreadStatic]
			internal static glAsyncMarkerSGIX pglAsyncMarkerSGIX;

			internal delegate void glAttachShader(UInt32 program, UInt32 shader);

			[AliasOf("glAttachShader")]
			[AliasOf("glAttachObjectARB")]
			[ThreadStatic]
			internal static glAttachShader pglAttachShader;

			internal delegate void glBegin(Int32 mode);

			[ThreadStatic]
			internal static glBegin pglBegin;

			internal delegate void glBeginConditionalRender(UInt32 id, Int32 mode);

			[AliasOf("glBeginConditionalRender")]
			[AliasOf("glBeginConditionalRenderNV")]
			[ThreadStatic]
			internal static glBeginConditionalRender pglBeginConditionalRender;

			internal delegate void glBeginConditionalRenderNVX(UInt32 id);

			[ThreadStatic]
			internal static glBeginConditionalRenderNVX pglBeginConditionalRenderNVX;

			internal delegate void glBeginFragmentShaderATI();

			[ThreadStatic]
			internal static glBeginFragmentShaderATI pglBeginFragmentShaderATI;

			internal delegate void glBeginOcclusionQueryNV(UInt32 id);

			[ThreadStatic]
			internal static glBeginOcclusionQueryNV pglBeginOcclusionQueryNV;

			internal delegate void glBeginPerfMonitorAMD(UInt32 monitor);

			[ThreadStatic]
			internal static glBeginPerfMonitorAMD pglBeginPerfMonitorAMD;

			internal delegate void glBeginPerfQueryINTEL(UInt32 queryHandle);

			[ThreadStatic]
			internal static glBeginPerfQueryINTEL pglBeginPerfQueryINTEL;

			internal delegate void glBeginQuery(Int32 target, UInt32 id);

			[AliasOf("glBeginQuery")]
			[AliasOf("glBeginQueryARB")]
			[ThreadStatic]
			internal static glBeginQuery pglBeginQuery;

			internal delegate void glBeginQueryEXT(Int32 target, UInt32 id);

			[ThreadStatic]
			internal static glBeginQueryEXT pglBeginQueryEXT;

			internal delegate void glBeginQueryIndexed(Int32 target, UInt32 index, UInt32 id);

			[ThreadStatic]
			internal static glBeginQueryIndexed pglBeginQueryIndexed;

			internal delegate void glBeginTransformFeedback(Int32 primitiveMode);

			[AliasOf("glBeginTransformFeedback")]
			[AliasOf("glBeginTransformFeedbackEXT")]
			[AliasOf("glBeginTransformFeedbackNV")]
			[ThreadStatic]
			internal static glBeginTransformFeedback pglBeginTransformFeedback;

			internal delegate void glBeginVertexShaderEXT();

			[ThreadStatic]
			internal static glBeginVertexShaderEXT pglBeginVertexShaderEXT;

			internal delegate void glBeginVideoCaptureNV(UInt32 video_capture_slot);

			[ThreadStatic]
			internal static glBeginVideoCaptureNV pglBeginVideoCaptureNV;

			internal delegate void glBindAttribLocation(UInt32 program, UInt32 index, String name);

			[AliasOf("glBindAttribLocation")]
			[AliasOf("glBindAttribLocationARB")]
			[ThreadStatic]
			internal static glBindAttribLocation pglBindAttribLocation;

			internal delegate void glBindBuffer(Int32 target, UInt32 buffer);

			[AliasOf("glBindBuffer")]
			[AliasOf("glBindBufferARB")]
			[ThreadStatic]
			internal static glBindBuffer pglBindBuffer;

			internal delegate void glBindBufferBase(Int32 target, UInt32 index, UInt32 buffer);

			[AliasOf("glBindBufferBase")]
			[AliasOf("glBindBufferBaseEXT")]
			[AliasOf("glBindBufferBaseNV")]
			[ThreadStatic]
			internal static glBindBufferBase pglBindBufferBase;

			internal unsafe delegate void glBindBufferOffsetEXT(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset);

			[AliasOf("glBindBufferOffsetEXT")]
			[AliasOf("glBindBufferOffsetNV")]
			[ThreadStatic]
			internal static glBindBufferOffsetEXT pglBindBufferOffsetEXT;

			internal unsafe delegate void glBindBufferRange(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[AliasOf("glBindBufferRange")]
			[AliasOf("glBindBufferRangeEXT")]
			[AliasOf("glBindBufferRangeNV")]
			[ThreadStatic]
			internal static glBindBufferRange pglBindBufferRange;

			internal unsafe delegate void glBindBuffersBase(Int32 target, UInt32 first, Int32 count, UInt32* buffers);

			[ThreadStatic]
			internal static glBindBuffersBase pglBindBuffersBase;

			internal unsafe delegate void glBindBuffersRange(Int32 target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, UInt32* sizes);

			[ThreadStatic]
			internal static glBindBuffersRange pglBindBuffersRange;

			internal delegate void glBindFragDataLocation(UInt32 program, UInt32 color, String name);

			[AliasOf("glBindFragDataLocation")]
			[AliasOf("glBindFragDataLocationEXT")]
			[ThreadStatic]
			internal static glBindFragDataLocation pglBindFragDataLocation;

			internal delegate void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

			[AliasOf("glBindFragDataLocationIndexed")]
			[AliasOf("glBindFragDataLocationIndexedEXT")]
			[ThreadStatic]
			internal static glBindFragDataLocationIndexed pglBindFragDataLocationIndexed;

			internal delegate void glBindFragmentShaderATI(UInt32 id);

			[ThreadStatic]
			internal static glBindFragmentShaderATI pglBindFragmentShaderATI;

			internal delegate void glBindFramebuffer(Int32 target, UInt32 framebuffer);

			[ThreadStatic]
			internal static glBindFramebuffer pglBindFramebuffer;

			internal delegate void glBindFramebufferEXT(Int32 target, UInt32 framebuffer);

			[ThreadStatic]
			internal static glBindFramebufferEXT pglBindFramebufferEXT;

			internal delegate void glBindFramebufferOES(Int32 target, UInt32 framebuffer);

			[ThreadStatic]
			internal static glBindFramebufferOES pglBindFramebufferOES;

			internal delegate void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[ThreadStatic]
			internal static glBindImageTexture pglBindImageTexture;

			internal delegate void glBindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[ThreadStatic]
			internal static glBindImageTextureEXT pglBindImageTextureEXT;

			internal unsafe delegate void glBindImageTextures(UInt32 first, Int32 count, UInt32* textures);

			[ThreadStatic]
			internal static glBindImageTextures pglBindImageTextures;

			internal delegate UInt32 glBindLightParameterEXT(Int32 light, Int32 value);

			[ThreadStatic]
			internal static glBindLightParameterEXT pglBindLightParameterEXT;

			internal delegate UInt32 glBindMaterialParameterEXT(Int32 face, Int32 value);

			[ThreadStatic]
			internal static glBindMaterialParameterEXT pglBindMaterialParameterEXT;

			internal delegate void glBindMultiTextureEXT(Int32 texunit, Int32 target, UInt32 texture);

			[ThreadStatic]
			internal static glBindMultiTextureEXT pglBindMultiTextureEXT;

			internal delegate UInt32 glBindParameterEXT(Int32 value);

			[ThreadStatic]
			internal static glBindParameterEXT pglBindParameterEXT;

			internal delegate void glBindProgramARB(Int32 target, UInt32 program);

			[AliasOf("glBindProgramARB")]
			[AliasOf("glBindProgramNV")]
			[ThreadStatic]
			internal static glBindProgramARB pglBindProgramARB;

			internal delegate void glBindProgramPipeline(UInt32 pipeline);

			[ThreadStatic]
			internal static glBindProgramPipeline pglBindProgramPipeline;

			internal delegate void glBindProgramPipelineEXT(UInt32 pipeline);

			[ThreadStatic]
			internal static glBindProgramPipelineEXT pglBindProgramPipelineEXT;

			internal delegate void glBindRenderbuffer(Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glBindRenderbuffer pglBindRenderbuffer;

			internal delegate void glBindRenderbufferEXT(Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glBindRenderbufferEXT pglBindRenderbufferEXT;

			internal delegate void glBindRenderbufferOES(Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glBindRenderbufferOES pglBindRenderbufferOES;

			internal delegate void glBindSampler(UInt32 unit, UInt32 sampler);

			[ThreadStatic]
			internal static glBindSampler pglBindSampler;

			internal unsafe delegate void glBindSamplers(UInt32 first, Int32 count, UInt32* samplers);

			[ThreadStatic]
			internal static glBindSamplers pglBindSamplers;

			internal delegate UInt32 glBindTexGenParameterEXT(Int32 unit, Int32 coord, Int32 value);

			[ThreadStatic]
			internal static glBindTexGenParameterEXT pglBindTexGenParameterEXT;

			internal delegate void glBindTexture(Int32 target, UInt32 texture);

			[AliasOf("glBindTexture")]
			[AliasOf("glBindTextureEXT")]
			[ThreadStatic]
			internal static glBindTexture pglBindTexture;

			internal delegate void glBindTextureUnit(UInt32 unit, UInt32 texture);

			[ThreadStatic]
			internal static glBindTextureUnit pglBindTextureUnit;

			internal delegate UInt32 glBindTextureUnitParameterEXT(Int32 unit, Int32 value);

			[ThreadStatic]
			internal static glBindTextureUnitParameterEXT pglBindTextureUnitParameterEXT;

			internal unsafe delegate void glBindTextures(UInt32 first, Int32 count, UInt32* textures);

			[ThreadStatic]
			internal static glBindTextures pglBindTextures;

			internal delegate void glBindTransformFeedback(Int32 target, UInt32 id);

			[ThreadStatic]
			internal static glBindTransformFeedback pglBindTransformFeedback;

			internal delegate void glBindTransformFeedbackNV(Int32 target, UInt32 id);

			[ThreadStatic]
			internal static glBindTransformFeedbackNV pglBindTransformFeedbackNV;

			internal delegate void glBindVertexArray(UInt32 array);

			[AliasOf("glBindVertexArray")]
			[AliasOf("glBindVertexArrayOES")]
			[ThreadStatic]
			internal static glBindVertexArray pglBindVertexArray;

			internal delegate void glBindVertexArrayAPPLE(UInt32 array);

			[ThreadStatic]
			internal static glBindVertexArrayAPPLE pglBindVertexArrayAPPLE;

			internal unsafe delegate void glBindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[ThreadStatic]
			internal static glBindVertexBuffer pglBindVertexBuffer;

			internal unsafe delegate void glBindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);

			[ThreadStatic]
			internal static glBindVertexBuffers pglBindVertexBuffers;

			internal delegate void glBindVertexShaderEXT(UInt32 id);

			[ThreadStatic]
			internal static glBindVertexShaderEXT pglBindVertexShaderEXT;

			internal unsafe delegate void glBindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, IntPtr offset);

			[ThreadStatic]
			internal static glBindVideoCaptureStreamBufferNV pglBindVideoCaptureStreamBufferNV;

			internal delegate void glBindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, Int32 target, UInt32 texture);

			[ThreadStatic]
			internal static glBindVideoCaptureStreamTextureNV pglBindVideoCaptureStreamTextureNV;

			internal delegate void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz);

			[ThreadStatic]
			internal static glBinormal3bEXT pglBinormal3bEXT;

			internal unsafe delegate void glBinormal3bvEXT(sbyte* v);

			[ThreadStatic]
			internal static glBinormal3bvEXT pglBinormal3bvEXT;

			internal delegate void glBinormal3dEXT(double bx, double by, double bz);

			[ThreadStatic]
			internal static glBinormal3dEXT pglBinormal3dEXT;

			internal unsafe delegate void glBinormal3dvEXT(double* v);

			[ThreadStatic]
			internal static glBinormal3dvEXT pglBinormal3dvEXT;

			internal delegate void glBinormal3fEXT(float bx, float by, float bz);

			[ThreadStatic]
			internal static glBinormal3fEXT pglBinormal3fEXT;

			internal unsafe delegate void glBinormal3fvEXT(float* v);

			[ThreadStatic]
			internal static glBinormal3fvEXT pglBinormal3fvEXT;

			internal delegate void glBinormal3iEXT(Int32 bx, Int32 by, Int32 bz);

			[ThreadStatic]
			internal static glBinormal3iEXT pglBinormal3iEXT;

			internal unsafe delegate void glBinormal3ivEXT(Int32* v);

			[ThreadStatic]
			internal static glBinormal3ivEXT pglBinormal3ivEXT;

			internal delegate void glBinormal3sEXT(Int16 bx, Int16 by, Int16 bz);

			[ThreadStatic]
			internal static glBinormal3sEXT pglBinormal3sEXT;

			internal unsafe delegate void glBinormal3svEXT(Int16* v);

			[ThreadStatic]
			internal static glBinormal3svEXT pglBinormal3svEXT;

			internal unsafe delegate void glBinormalPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glBinormalPointerEXT pglBinormalPointerEXT;

			internal unsafe delegate void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

			[ThreadStatic]
			internal static glBitmap pglBitmap;

			internal unsafe delegate void glBitmapxOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte* bitmap);

			[ThreadStatic]
			internal static glBitmapxOES pglBitmapxOES;

			internal delegate void glBlendBarrier();

			[AliasOf("glBlendBarrier")]
			[AliasOf("glBlendBarrierKHR")]
			[AliasOf("glBlendBarrierNV")]
			[ThreadStatic]
			internal static glBlendBarrier pglBlendBarrier;

			internal delegate void glBlendColor(float red, float green, float blue, float alpha);

			[AliasOf("glBlendColor")]
			[AliasOf("glBlendColorEXT")]
			[ThreadStatic]
			internal static glBlendColor pglBlendColor;

			internal unsafe delegate void glBlendColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glBlendColorxOES pglBlendColorxOES;

			internal delegate void glBlendEquation(Int32 mode);

			[AliasOf("glBlendEquation")]
			[AliasOf("glBlendEquationEXT")]
			[ThreadStatic]
			internal static glBlendEquation pglBlendEquation;

			internal delegate void glBlendEquationOES(Int32 mode);

			[ThreadStatic]
			internal static glBlendEquationOES pglBlendEquationOES;

			internal delegate void glBlendEquationSeparate(Int32 modeRGB, Int32 modeAlpha);

			[AliasOf("glBlendEquationSeparate")]
			[AliasOf("glBlendEquationSeparateEXT")]
			[ThreadStatic]
			internal static glBlendEquationSeparate pglBlendEquationSeparate;

			internal delegate void glBlendEquationSeparateOES(Int32 modeRGB, Int32 modeAlpha);

			[ThreadStatic]
			internal static glBlendEquationSeparateOES pglBlendEquationSeparateOES;

			internal delegate void glBlendEquationSeparatei(UInt32 buf, Int32 modeRGB, Int32 modeAlpha);

			[AliasOf("glBlendEquationSeparatei")]
			[AliasOf("glBlendEquationSeparateIndexedAMD")]
			[AliasOf("glBlendEquationSeparateiARB")]
			[AliasOf("glBlendEquationSeparateiEXT")]
			[AliasOf("glBlendEquationSeparateiOES")]
			[ThreadStatic]
			internal static glBlendEquationSeparatei pglBlendEquationSeparatei;

			internal delegate void glBlendEquationi(UInt32 buf, Int32 mode);

			[AliasOf("glBlendEquationi")]
			[AliasOf("glBlendEquationIndexedAMD")]
			[AliasOf("glBlendEquationiARB")]
			[AliasOf("glBlendEquationiEXT")]
			[AliasOf("glBlendEquationiOES")]
			[ThreadStatic]
			internal static glBlendEquationi pglBlendEquationi;

			internal delegate void glBlendFunc(Int32 sfactor, Int32 dfactor);

			[ThreadStatic]
			internal static glBlendFunc pglBlendFunc;

			internal delegate void glBlendFuncSeparate(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha);

			[AliasOf("glBlendFuncSeparate")]
			[AliasOf("glBlendFuncSeparateEXT")]
			[AliasOf("glBlendFuncSeparateINGR")]
			[ThreadStatic]
			internal static glBlendFuncSeparate pglBlendFuncSeparate;

			internal delegate void glBlendFuncSeparateOES(Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[ThreadStatic]
			internal static glBlendFuncSeparateOES pglBlendFuncSeparateOES;

			internal delegate void glBlendFuncSeparatei(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[AliasOf("glBlendFuncSeparatei")]
			[AliasOf("glBlendFuncSeparateIndexedAMD")]
			[AliasOf("glBlendFuncSeparateiARB")]
			[AliasOf("glBlendFuncSeparateiEXT")]
			[AliasOf("glBlendFuncSeparateiOES")]
			[ThreadStatic]
			internal static glBlendFuncSeparatei pglBlendFuncSeparatei;

			internal delegate void glBlendFunci(UInt32 buf, Int32 src, Int32 dst);

			[AliasOf("glBlendFunci")]
			[AliasOf("glBlendFuncIndexedAMD")]
			[AliasOf("glBlendFunciARB")]
			[AliasOf("glBlendFunciEXT")]
			[AliasOf("glBlendFunciOES")]
			[ThreadStatic]
			internal static glBlendFunci pglBlendFunci;

			internal delegate void glBlendParameteriNV(Int32 pname, Int32 value);

			[ThreadStatic]
			internal static glBlendParameteriNV pglBlendParameteriNV;

			internal delegate void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[AliasOf("glBlitFramebuffer")]
			[AliasOf("glBlitFramebufferEXT")]
			[AliasOf("glBlitFramebufferNV")]
			[ThreadStatic]
			internal static glBlitFramebuffer pglBlitFramebuffer;

			internal delegate void glBlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[ThreadStatic]
			internal static glBlitFramebufferANGLE pglBlitFramebufferANGLE;

			internal delegate void glBlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[ThreadStatic]
			internal static glBlitNamedFramebuffer pglBlitNamedFramebuffer;

			internal delegate void glBufferAddressRangeNV(Int32 pname, UInt32 index, UInt64 address, UInt32 length);

			[ThreadStatic]
			internal static glBufferAddressRangeNV pglBufferAddressRangeNV;

			internal unsafe delegate void glBufferData(Int32 target, UInt32 size, IntPtr data, Int32 usage);

			[AliasOf("glBufferData")]
			[AliasOf("glBufferDataARB")]
			[ThreadStatic]
			internal static glBufferData pglBufferData;

			internal unsafe delegate void glBufferPageCommitmentARB(Int32 target, IntPtr offset, UInt32 size, bool commit);

			[ThreadStatic]
			internal static glBufferPageCommitmentARB pglBufferPageCommitmentARB;

			internal delegate void glBufferParameteriAPPLE(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glBufferParameteriAPPLE pglBufferParameteriAPPLE;

			internal unsafe delegate void glBufferStorage(Int32 target, UInt32 size, IntPtr data, UInt32 flags);

			[AliasOf("glBufferStorage")]
			[AliasOf("glBufferStorageEXT")]
			[ThreadStatic]
			internal static glBufferStorage pglBufferStorage;

			internal unsafe delegate void glBufferSubData(Int32 target, IntPtr offset, UInt32 size, IntPtr data);

			[AliasOf("glBufferSubData")]
			[AliasOf("glBufferSubDataARB")]
			[ThreadStatic]
			internal static glBufferSubData pglBufferSubData;

			internal delegate void glCallCommandListNV(UInt32 list);

			[ThreadStatic]
			internal static glCallCommandListNV pglCallCommandListNV;

			internal delegate void glCallList(UInt32 list);

			[ThreadStatic]
			internal static glCallList pglCallList;

			internal unsafe delegate void glCallLists(Int32 n, Int32 type, IntPtr lists);

			[ThreadStatic]
			internal static glCallLists pglCallLists;

			internal delegate Int32 glCheckFramebufferStatus(Int32 target);

			[AliasOf("glCheckFramebufferStatus")]
			[AliasOf("glCheckFramebufferStatusEXT")]
			[ThreadStatic]
			internal static glCheckFramebufferStatus pglCheckFramebufferStatus;

			internal delegate Int32 glCheckFramebufferStatusOES(Int32 target);

			[ThreadStatic]
			internal static glCheckFramebufferStatusOES pglCheckFramebufferStatusOES;

			internal delegate Int32 glCheckNamedFramebufferStatus(UInt32 framebuffer, Int32 target);

			[ThreadStatic]
			internal static glCheckNamedFramebufferStatus pglCheckNamedFramebufferStatus;

			internal delegate Int32 glCheckNamedFramebufferStatusEXT(UInt32 framebuffer, Int32 target);

			[ThreadStatic]
			internal static glCheckNamedFramebufferStatusEXT pglCheckNamedFramebufferStatusEXT;

			internal delegate void glClampColor(Int32 target, Int32 clamp);

			[AliasOf("glClampColor")]
			[AliasOf("glClampColorARB")]
			[ThreadStatic]
			internal static glClampColor pglClampColor;

			internal delegate void glClear(UInt32 mask);

			[ThreadStatic]
			internal static glClear pglClear;

			internal delegate void glClearAccum(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glClearAccum pglClearAccum;

			internal unsafe delegate void glClearAccumxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glClearAccumxOES pglClearAccumxOES;

			internal unsafe delegate void glClearBufferData(Int32 target, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearBufferData pglClearBufferData;

			internal unsafe delegate void glClearBufferSubData(Int32 target, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearBufferSubData pglClearBufferSubData;

			internal delegate void glClearBufferfi(Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil);

			[ThreadStatic]
			internal static glClearBufferfi pglClearBufferfi;

			internal unsafe delegate void glClearBufferfv(Int32 buffer, Int32 drawbuffer, float* value);

			[ThreadStatic]
			internal static glClearBufferfv pglClearBufferfv;

			internal unsafe delegate void glClearBufferiv(Int32 buffer, Int32 drawbuffer, Int32* value);

			[ThreadStatic]
			internal static glClearBufferiv pglClearBufferiv;

			internal unsafe delegate void glClearBufferuiv(Int32 buffer, Int32 drawbuffer, UInt32* value);

			[ThreadStatic]
			internal static glClearBufferuiv pglClearBufferuiv;

			internal delegate void glClearColor(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glClearColor pglClearColor;

			internal delegate void glClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[ThreadStatic]
			internal static glClearColorIiEXT pglClearColorIiEXT;

			internal delegate void glClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[ThreadStatic]
			internal static glClearColorIuiEXT pglClearColorIuiEXT;

			internal unsafe delegate void glClearColorx(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glClearColorx pglClearColorx;

			internal unsafe delegate void glClearColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glClearColorxOES pglClearColorxOES;

			internal delegate void glClearDepth(double depth);

			[ThreadStatic]
			internal static glClearDepth pglClearDepth;

			internal delegate void glClearDepthdNV(double depth);

			[ThreadStatic]
			internal static glClearDepthdNV pglClearDepthdNV;

			internal delegate void glClearDepthf(float d);

			[AliasOf("glClearDepthf")]
			[AliasOf("glClearDepthfOES")]
			[ThreadStatic]
			internal static glClearDepthf pglClearDepthf;

			internal unsafe delegate void glClearDepthx(IntPtr depth);

			[ThreadStatic]
			internal static glClearDepthx pglClearDepthx;

			internal unsafe delegate void glClearDepthxOES(IntPtr depth);

			[ThreadStatic]
			internal static glClearDepthxOES pglClearDepthxOES;

			internal delegate void glClearIndex(float c);

			[ThreadStatic]
			internal static glClearIndex pglClearIndex;

			internal unsafe delegate void glClearNamedBufferData(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearNamedBufferData pglClearNamedBufferData;

			internal unsafe delegate void glClearNamedBufferDataEXT(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearNamedBufferDataEXT pglClearNamedBufferDataEXT;

			internal unsafe delegate void glClearNamedBufferSubData(UInt32 buffer, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearNamedBufferSubData pglClearNamedBufferSubData;

			internal unsafe delegate void glClearNamedBufferSubDataEXT(UInt32 buffer, Int32 internalformat, UInt32 offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearNamedBufferSubDataEXT pglClearNamedBufferSubDataEXT;

			internal delegate void glClearNamedFramebufferfi(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil);

			[ThreadStatic]
			internal static glClearNamedFramebufferfi pglClearNamedFramebufferfi;

			internal unsafe delegate void glClearNamedFramebufferfv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float* value);

			[ThreadStatic]
			internal static glClearNamedFramebufferfv pglClearNamedFramebufferfv;

			internal unsafe delegate void glClearNamedFramebufferiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, Int32* value);

			[ThreadStatic]
			internal static glClearNamedFramebufferiv pglClearNamedFramebufferiv;

			internal unsafe delegate void glClearNamedFramebufferuiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, UInt32* value);

			[ThreadStatic]
			internal static glClearNamedFramebufferuiv pglClearNamedFramebufferuiv;

			internal unsafe delegate void glClearPixelLocalStorageuiEXT(Int32 offset, Int32 n, UInt32* values);

			[ThreadStatic]
			internal static glClearPixelLocalStorageuiEXT pglClearPixelLocalStorageuiEXT;

			internal delegate void glClearStencil(Int32 s);

			[ThreadStatic]
			internal static glClearStencil pglClearStencil;

			internal unsafe delegate void glClearTexImage(UInt32 texture, Int32 level, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearTexImage pglClearTexImage;

			internal unsafe delegate void glClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearTexSubImage pglClearTexSubImage;

			internal delegate void glClientActiveTexture(Int32 texture);

			[AliasOf("glClientActiveTexture")]
			[AliasOf("glClientActiveTextureARB")]
			[ThreadStatic]
			internal static glClientActiveTexture pglClientActiveTexture;

			internal delegate void glClientActiveVertexStreamATI(Int32 stream);

			[ThreadStatic]
			internal static glClientActiveVertexStreamATI pglClientActiveVertexStreamATI;

			internal delegate void glClientAttribDefaultEXT(UInt32 mask);

			[ThreadStatic]
			internal static glClientAttribDefaultEXT pglClientAttribDefaultEXT;

			internal delegate Int32 glClientWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			[AliasOf("glClientWaitSync")]
			[AliasOf("glClientWaitSyncAPPLE")]
			[ThreadStatic]
			internal static glClientWaitSync pglClientWaitSync;

			internal delegate void glClipControl(Int32 origin, Int32 depth);

			[ThreadStatic]
			internal static glClipControl pglClipControl;

			internal unsafe delegate void glClipPlane(Int32 plane, double* equation);

			[ThreadStatic]
			internal static glClipPlane pglClipPlane;

			internal unsafe delegate void glClipPlanef(Int32 p, float* eqn);

			[ThreadStatic]
			internal static glClipPlanef pglClipPlanef;

			internal unsafe delegate void glClipPlanefIMG(Int32 p, float* eqn);

			[ThreadStatic]
			internal static glClipPlanefIMG pglClipPlanefIMG;

			internal unsafe delegate void glClipPlanefOES(Int32 plane, float* equation);

			[ThreadStatic]
			internal static glClipPlanefOES pglClipPlanefOES;

			internal unsafe delegate void glClipPlanex(Int32 plane, IntPtr* equation);

			[ThreadStatic]
			internal static glClipPlanex pglClipPlanex;

			internal unsafe delegate void glClipPlanexIMG(Int32 p, IntPtr* eqn);

			[ThreadStatic]
			internal static glClipPlanexIMG pglClipPlanexIMG;

			internal unsafe delegate void glClipPlanexOES(Int32 plane, IntPtr* equation);

			[ThreadStatic]
			internal static glClipPlanexOES pglClipPlanexOES;

			internal delegate void glColor3b(sbyte red, sbyte green, sbyte blue);

			[ThreadStatic]
			internal static glColor3b pglColor3b;

			internal unsafe delegate void glColor3bv(sbyte* v);

			[ThreadStatic]
			internal static glColor3bv pglColor3bv;

			internal delegate void glColor3d(double red, double green, double blue);

			[ThreadStatic]
			internal static glColor3d pglColor3d;

			internal unsafe delegate void glColor3dv(double* v);

			[ThreadStatic]
			internal static glColor3dv pglColor3dv;

			internal delegate void glColor3f(float red, float green, float blue);

			[ThreadStatic]
			internal static glColor3f pglColor3f;

			internal delegate void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);

			[ThreadStatic]
			internal static glColor3fVertex3fSUN pglColor3fVertex3fSUN;

			internal unsafe delegate void glColor3fVertex3fvSUN(float* c, float* v);

			[ThreadStatic]
			internal static glColor3fVertex3fvSUN pglColor3fVertex3fvSUN;

			internal unsafe delegate void glColor3fv(float* v);

			[ThreadStatic]
			internal static glColor3fv pglColor3fv;

			internal delegate void glColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[ThreadStatic]
			internal static glColor3hNV pglColor3hNV;

			internal unsafe delegate void glColor3hvNV(UInt16* v);

			[ThreadStatic]
			internal static glColor3hvNV pglColor3hvNV;

			internal delegate void glColor3i(Int32 red, Int32 green, Int32 blue);

			[ThreadStatic]
			internal static glColor3i pglColor3i;

			internal unsafe delegate void glColor3iv(Int32* v);

			[ThreadStatic]
			internal static glColor3iv pglColor3iv;

			internal delegate void glColor3s(Int16 red, Int16 green, Int16 blue);

			[ThreadStatic]
			internal static glColor3s pglColor3s;

			internal unsafe delegate void glColor3sv(Int16* v);

			[ThreadStatic]
			internal static glColor3sv pglColor3sv;

			internal delegate void glColor3ub(byte red, byte green, byte blue);

			[ThreadStatic]
			internal static glColor3ub pglColor3ub;

			internal unsafe delegate void glColor3ubv(byte* v);

			[ThreadStatic]
			internal static glColor3ubv pglColor3ubv;

			internal delegate void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[ThreadStatic]
			internal static glColor3ui pglColor3ui;

			internal unsafe delegate void glColor3uiv(UInt32* v);

			[ThreadStatic]
			internal static glColor3uiv pglColor3uiv;

			internal delegate void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[ThreadStatic]
			internal static glColor3us pglColor3us;

			internal unsafe delegate void glColor3usv(UInt16* v);

			[ThreadStatic]
			internal static glColor3usv pglColor3usv;

			internal unsafe delegate void glColor3xOES(IntPtr red, IntPtr green, IntPtr blue);

			[ThreadStatic]
			internal static glColor3xOES pglColor3xOES;

			internal unsafe delegate void glColor3xvOES(IntPtr* components);

			[ThreadStatic]
			internal static glColor3xvOES pglColor3xvOES;

			internal delegate void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

			[ThreadStatic]
			internal static glColor4b pglColor4b;

			internal unsafe delegate void glColor4bv(sbyte* v);

			[ThreadStatic]
			internal static glColor4bv pglColor4bv;

			internal delegate void glColor4d(double red, double green, double blue, double alpha);

			[ThreadStatic]
			internal static glColor4d pglColor4d;

			internal unsafe delegate void glColor4dv(double* v);

			[ThreadStatic]
			internal static glColor4dv pglColor4dv;

			internal delegate void glColor4f(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glColor4f pglColor4f;

			internal delegate void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glColor4fNormal3fVertex3fSUN pglColor4fNormal3fVertex3fSUN;

			internal unsafe delegate void glColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v);

			[ThreadStatic]
			internal static glColor4fNormal3fVertex3fvSUN pglColor4fNormal3fVertex3fvSUN;

			internal unsafe delegate void glColor4fv(float* v);

			[ThreadStatic]
			internal static glColor4fv pglColor4fv;

			internal delegate void glColor4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[ThreadStatic]
			internal static glColor4hNV pglColor4hNV;

			internal unsafe delegate void glColor4hvNV(UInt16* v);

			[ThreadStatic]
			internal static glColor4hvNV pglColor4hvNV;

			internal delegate void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[ThreadStatic]
			internal static glColor4i pglColor4i;

			internal unsafe delegate void glColor4iv(Int32* v);

			[ThreadStatic]
			internal static glColor4iv pglColor4iv;

			internal delegate void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

			[ThreadStatic]
			internal static glColor4s pglColor4s;

			internal unsafe delegate void glColor4sv(Int16* v);

			[ThreadStatic]
			internal static glColor4sv pglColor4sv;

			internal delegate void glColor4ub(byte red, byte green, byte blue, byte alpha);

			[ThreadStatic]
			internal static glColor4ub pglColor4ub;

			internal delegate void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);

			[ThreadStatic]
			internal static glColor4ubVertex2fSUN pglColor4ubVertex2fSUN;

			internal unsafe delegate void glColor4ubVertex2fvSUN(byte* c, float* v);

			[ThreadStatic]
			internal static glColor4ubVertex2fvSUN pglColor4ubVertex2fvSUN;

			internal delegate void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);

			[ThreadStatic]
			internal static glColor4ubVertex3fSUN pglColor4ubVertex3fSUN;

			internal unsafe delegate void glColor4ubVertex3fvSUN(byte* c, float* v);

			[ThreadStatic]
			internal static glColor4ubVertex3fvSUN pglColor4ubVertex3fvSUN;

			internal unsafe delegate void glColor4ubv(byte* v);

			[ThreadStatic]
			internal static glColor4ubv pglColor4ubv;

			internal delegate void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[ThreadStatic]
			internal static glColor4ui pglColor4ui;

			internal unsafe delegate void glColor4uiv(UInt32* v);

			[ThreadStatic]
			internal static glColor4uiv pglColor4uiv;

			internal delegate void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[ThreadStatic]
			internal static glColor4us pglColor4us;

			internal unsafe delegate void glColor4usv(UInt16* v);

			[ThreadStatic]
			internal static glColor4usv pglColor4usv;

			internal unsafe delegate void glColor4x(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glColor4x pglColor4x;

			internal unsafe delegate void glColor4xOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glColor4xOES pglColor4xOES;

			internal unsafe delegate void glColor4xvOES(IntPtr* components);

			[ThreadStatic]
			internal static glColor4xvOES pglColor4xvOES;

			internal delegate void glColorFormatNV(Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glColorFormatNV pglColorFormatNV;

			internal delegate void glColorFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[ThreadStatic]
			internal static glColorFragmentOp1ATI pglColorFragmentOp1ATI;

			internal delegate void glColorFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[ThreadStatic]
			internal static glColorFragmentOp2ATI pglColorFragmentOp2ATI;

			internal delegate void glColorFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[ThreadStatic]
			internal static glColorFragmentOp3ATI pglColorFragmentOp3ATI;

			internal delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			[ThreadStatic]
			internal static glColorMask pglColorMask;

			internal delegate void glColorMaski(UInt32 index, bool r, bool g, bool b, bool a);

			[AliasOf("glColorMaski")]
			[AliasOf("glColorMaskIndexedEXT")]
			[AliasOf("glColorMaskiEXT")]
			[AliasOf("glColorMaskiOES")]
			[ThreadStatic]
			internal static glColorMaski pglColorMaski;

			internal delegate void glColorMaterial(Int32 face, Int32 mode);

			[ThreadStatic]
			internal static glColorMaterial pglColorMaterial;

			internal delegate void glColorP3ui(Int32 type, UInt32 color);

			[ThreadStatic]
			internal static glColorP3ui pglColorP3ui;

			internal unsafe delegate void glColorP3uiv(Int32 type, UInt32* color);

			[ThreadStatic]
			internal static glColorP3uiv pglColorP3uiv;

			internal delegate void glColorP4ui(Int32 type, UInt32 color);

			[ThreadStatic]
			internal static glColorP4ui pglColorP4ui;

			internal unsafe delegate void glColorP4uiv(Int32 type, UInt32* color);

			[ThreadStatic]
			internal static glColorP4uiv pglColorP4uiv;

			internal unsafe delegate void glColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glColorPointer pglColorPointer;

			internal unsafe delegate void glColorPointerEXT(Int32 size, Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[ThreadStatic]
			internal static glColorPointerEXT pglColorPointerEXT;

			internal unsafe delegate void glColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glColorPointerListIBM pglColorPointerListIBM;

			internal unsafe delegate void glColorPointervINTEL(Int32 size, Int32 type, IntPtr* pointer);

			[ThreadStatic]
			internal static glColorPointervINTEL pglColorPointervINTEL;

			internal unsafe delegate void glColorSubTable(Int32 target, Int32 start, Int32 count, Int32 format, Int32 type, IntPtr data);

			[AliasOf("glColorSubTable")]
			[AliasOf("glColorSubTableEXT")]
			[ThreadStatic]
			internal static glColorSubTable pglColorSubTable;

			internal unsafe delegate void glColorTable(Int32 target, Int32 internalformat, Int32 width, Int32 format, Int32 type, IntPtr table);

			[AliasOf("glColorTable")]
			[AliasOf("glColorTableEXT")]
			[AliasOf("glColorTableSGI")]
			[ThreadStatic]
			internal static glColorTable pglColorTable;

			internal unsafe delegate void glColorTableParameterfv(Int32 target, Int32 pname, float* @params);

			[AliasOf("glColorTableParameterfv")]
			[AliasOf("glColorTableParameterfvSGI")]
			[ThreadStatic]
			internal static glColorTableParameterfv pglColorTableParameterfv;

			internal unsafe delegate void glColorTableParameteriv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glColorTableParameteriv")]
			[AliasOf("glColorTableParameterivSGI")]
			[ThreadStatic]
			internal static glColorTableParameteriv pglColorTableParameteriv;

			internal delegate void glCombinerInputNV(Int32 stage, Int32 portion, Int32 variable, Int32 input, Int32 mapping, Int32 componentUsage);

			[ThreadStatic]
			internal static glCombinerInputNV pglCombinerInputNV;

			internal delegate void glCombinerOutputNV(Int32 stage, Int32 portion, Int32 abOutput, Int32 cdOutput, Int32 sumOutput, Int32 scale, Int32 bias, bool abDotProduct, bool cdDotProduct, bool muxSum);

			[ThreadStatic]
			internal static glCombinerOutputNV pglCombinerOutputNV;

			internal delegate void glCombinerParameterfNV(Int32 pname, float param);

			[ThreadStatic]
			internal static glCombinerParameterfNV pglCombinerParameterfNV;

			internal unsafe delegate void glCombinerParameterfvNV(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glCombinerParameterfvNV pglCombinerParameterfvNV;

			internal delegate void glCombinerParameteriNV(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glCombinerParameteriNV pglCombinerParameteriNV;

			internal unsafe delegate void glCombinerParameterivNV(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glCombinerParameterivNV pglCombinerParameterivNV;

			internal unsafe delegate void glCombinerStageParameterfvNV(Int32 stage, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glCombinerStageParameterfvNV pglCombinerStageParameterfvNV;

			internal delegate void glCommandListSegmentsNV(UInt32 list, UInt32 segments);

			[ThreadStatic]
			internal static glCommandListSegmentsNV pglCommandListSegmentsNV;

			internal delegate void glCompileCommandListNV(UInt32 list);

			[ThreadStatic]
			internal static glCompileCommandListNV pglCompileCommandListNV;

			internal delegate void glCompileShader(UInt32 shader);

			[AliasOf("glCompileShader")]
			[AliasOf("glCompileShaderARB")]
			[ThreadStatic]
			internal static glCompileShader pglCompileShader;

			internal unsafe delegate void glCompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);

			[ThreadStatic]
			internal static glCompileShaderIncludeARB pglCompileShaderIncludeARB;

			internal unsafe delegate void glCompressedMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexImage1DEXT pglCompressedMultiTexImage1DEXT;

			internal unsafe delegate void glCompressedMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexImage2DEXT pglCompressedMultiTexImage2DEXT;

			internal unsafe delegate void glCompressedMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexImage3DEXT pglCompressedMultiTexImage3DEXT;

			internal unsafe delegate void glCompressedMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexSubImage1DEXT pglCompressedMultiTexSubImage1DEXT;

			internal unsafe delegate void glCompressedMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexSubImage2DEXT pglCompressedMultiTexSubImage2DEXT;

			internal unsafe delegate void glCompressedMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexSubImage3DEXT pglCompressedMultiTexSubImage3DEXT;

			internal unsafe delegate void glCompressedTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);

			[AliasOf("glCompressedTexImage1D")]
			[AliasOf("glCompressedTexImage1DARB")]
			[ThreadStatic]
			internal static glCompressedTexImage1D pglCompressedTexImage1D;

			internal unsafe delegate void glCompressedTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

			[AliasOf("glCompressedTexImage2D")]
			[AliasOf("glCompressedTexImage2DARB")]
			[ThreadStatic]
			internal static glCompressedTexImage2D pglCompressedTexImage2D;

			internal unsafe delegate void glCompressedTexImage3D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

			[AliasOf("glCompressedTexImage3D")]
			[AliasOf("glCompressedTexImage3DARB")]
			[AliasOf("glCompressedTexImage3DOES")]
			[ThreadStatic]
			internal static glCompressedTexImage3D pglCompressedTexImage3D;

			internal unsafe delegate void glCompressedTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[AliasOf("glCompressedTexSubImage1D")]
			[AliasOf("glCompressedTexSubImage1DARB")]
			[ThreadStatic]
			internal static glCompressedTexSubImage1D pglCompressedTexSubImage1D;

			internal unsafe delegate void glCompressedTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[AliasOf("glCompressedTexSubImage2D")]
			[AliasOf("glCompressedTexSubImage2DARB")]
			[ThreadStatic]
			internal static glCompressedTexSubImage2D pglCompressedTexSubImage2D;

			internal unsafe delegate void glCompressedTexSubImage3D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[AliasOf("glCompressedTexSubImage3D")]
			[AliasOf("glCompressedTexSubImage3DARB")]
			[AliasOf("glCompressedTexSubImage3DOES")]
			[ThreadStatic]
			internal static glCompressedTexSubImage3D pglCompressedTexSubImage3D;

			internal unsafe delegate void glCompressedTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureImage1DEXT pglCompressedTextureImage1DEXT;

			internal unsafe delegate void glCompressedTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureImage2DEXT pglCompressedTextureImage2DEXT;

			internal unsafe delegate void glCompressedTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureImage3DEXT pglCompressedTextureImage3DEXT;

			internal unsafe delegate void glCompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[ThreadStatic]
			internal static glCompressedTextureSubImage1D pglCompressedTextureSubImage1D;

			internal unsafe delegate void glCompressedTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureSubImage1DEXT pglCompressedTextureSubImage1DEXT;

			internal unsafe delegate void glCompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[ThreadStatic]
			internal static glCompressedTextureSubImage2D pglCompressedTextureSubImage2D;

			internal unsafe delegate void glCompressedTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureSubImage2DEXT pglCompressedTextureSubImage2DEXT;

			internal unsafe delegate void glCompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[ThreadStatic]
			internal static glCompressedTextureSubImage3D pglCompressedTextureSubImage3D;

			internal unsafe delegate void glCompressedTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureSubImage3DEXT pglCompressedTextureSubImage3DEXT;

			internal delegate void glConservativeRasterParameterfNV(Int32 pname, float value);

			[ThreadStatic]
			internal static glConservativeRasterParameterfNV pglConservativeRasterParameterfNV;

			internal unsafe delegate void glConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 width, Int32 format, Int32 type, IntPtr image);

			[AliasOf("glConvolutionFilter1D")]
			[AliasOf("glConvolutionFilter1DEXT")]
			[ThreadStatic]
			internal static glConvolutionFilter1D pglConvolutionFilter1D;

			internal unsafe delegate void glConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr image);

			[AliasOf("glConvolutionFilter2D")]
			[AliasOf("glConvolutionFilter2DEXT")]
			[ThreadStatic]
			internal static glConvolutionFilter2D pglConvolutionFilter2D;

			internal delegate void glConvolutionParameterf(Int32 target, Int32 pname, float @params);

			[AliasOf("glConvolutionParameterf")]
			[AliasOf("glConvolutionParameterfEXT")]
			[ThreadStatic]
			internal static glConvolutionParameterf pglConvolutionParameterf;

			internal unsafe delegate void glConvolutionParameterfv(Int32 target, Int32 pname, float* @params);

			[AliasOf("glConvolutionParameterfv")]
			[AliasOf("glConvolutionParameterfvEXT")]
			[ThreadStatic]
			internal static glConvolutionParameterfv pglConvolutionParameterfv;

			internal delegate void glConvolutionParameteri(Int32 target, Int32 pname, Int32 @params);

			[AliasOf("glConvolutionParameteri")]
			[AliasOf("glConvolutionParameteriEXT")]
			[ThreadStatic]
			internal static glConvolutionParameteri pglConvolutionParameteri;

			internal unsafe delegate void glConvolutionParameteriv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glConvolutionParameteriv")]
			[AliasOf("glConvolutionParameterivEXT")]
			[ThreadStatic]
			internal static glConvolutionParameteriv pglConvolutionParameteriv;

			internal unsafe delegate void glConvolutionParameterxOES(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glConvolutionParameterxOES pglConvolutionParameterxOES;

			internal unsafe delegate void glConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glConvolutionParameterxvOES pglConvolutionParameterxvOES;

			internal unsafe delegate void glCopyBufferSubData(Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[AliasOf("glCopyBufferSubData")]
			[AliasOf("glCopyBufferSubDataNV")]
			[ThreadStatic]
			internal static glCopyBufferSubData pglCopyBufferSubData;

			internal delegate void glCopyColorSubTable(Int32 target, Int32 start, Int32 x, Int32 y, Int32 width);

			[AliasOf("glCopyColorSubTable")]
			[AliasOf("glCopyColorSubTableEXT")]
			[ThreadStatic]
			internal static glCopyColorSubTable pglCopyColorSubTable;

			internal delegate void glCopyColorTable(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width);

			[AliasOf("glCopyColorTable")]
			[AliasOf("glCopyColorTableSGI")]
			[ThreadStatic]
			internal static glCopyColorTable pglCopyColorTable;

			internal delegate void glCopyConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width);

			[AliasOf("glCopyConvolutionFilter1D")]
			[AliasOf("glCopyConvolutionFilter1DEXT")]
			[ThreadStatic]
			internal static glCopyConvolutionFilter1D pglCopyConvolutionFilter1D;

			internal delegate void glCopyConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height);

			[AliasOf("glCopyConvolutionFilter2D")]
			[AliasOf("glCopyConvolutionFilter2DEXT")]
			[ThreadStatic]
			internal static glCopyConvolutionFilter2D pglCopyConvolutionFilter2D;

			internal delegate void glCopyImageSubData(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

			[AliasOf("glCopyImageSubData")]
			[AliasOf("glCopyImageSubDataEXT")]
			[AliasOf("glCopyImageSubDataOES")]
			[ThreadStatic]
			internal static glCopyImageSubData pglCopyImageSubData;

			internal delegate void glCopyImageSubDataNV(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[ThreadStatic]
			internal static glCopyImageSubDataNV pglCopyImageSubDataNV;

			internal delegate void glCopyMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[ThreadStatic]
			internal static glCopyMultiTexImage1DEXT pglCopyMultiTexImage1DEXT;

			internal delegate void glCopyMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[ThreadStatic]
			internal static glCopyMultiTexImage2DEXT pglCopyMultiTexImage2DEXT;

			internal delegate void glCopyMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[ThreadStatic]
			internal static glCopyMultiTexSubImage1DEXT pglCopyMultiTexSubImage1DEXT;

			internal delegate void glCopyMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyMultiTexSubImage2DEXT pglCopyMultiTexSubImage2DEXT;

			internal delegate void glCopyMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyMultiTexSubImage3DEXT pglCopyMultiTexSubImage3DEXT;

			internal unsafe delegate void glCopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[ThreadStatic]
			internal static glCopyNamedBufferSubData pglCopyNamedBufferSubData;

			internal delegate void glCopyPathNV(UInt32 resultPath, UInt32 srcPath);

			[ThreadStatic]
			internal static glCopyPathNV pglCopyPathNV;

			internal delegate void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 type);

			[ThreadStatic]
			internal static glCopyPixels pglCopyPixels;

			internal delegate void glCopyTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[AliasOf("glCopyTexImage1D")]
			[AliasOf("glCopyTexImage1DEXT")]
			[ThreadStatic]
			internal static glCopyTexImage1D pglCopyTexImage1D;

			internal delegate void glCopyTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[AliasOf("glCopyTexImage2D")]
			[AliasOf("glCopyTexImage2DEXT")]
			[ThreadStatic]
			internal static glCopyTexImage2D pglCopyTexImage2D;

			internal delegate void glCopyTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[AliasOf("glCopyTexSubImage1D")]
			[AliasOf("glCopyTexSubImage1DEXT")]
			[ThreadStatic]
			internal static glCopyTexSubImage1D pglCopyTexSubImage1D;

			internal delegate void glCopyTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[AliasOf("glCopyTexSubImage2D")]
			[AliasOf("glCopyTexSubImage2DEXT")]
			[ThreadStatic]
			internal static glCopyTexSubImage2D pglCopyTexSubImage2D;

			internal delegate void glCopyTexSubImage3D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[AliasOf("glCopyTexSubImage3D")]
			[AliasOf("glCopyTexSubImage3DEXT")]
			[AliasOf("glCopyTexSubImage3DOES")]
			[ThreadStatic]
			internal static glCopyTexSubImage3D pglCopyTexSubImage3D;

			internal delegate void glCopyTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[ThreadStatic]
			internal static glCopyTextureImage1DEXT pglCopyTextureImage1DEXT;

			internal delegate void glCopyTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[ThreadStatic]
			internal static glCopyTextureImage2DEXT pglCopyTextureImage2DEXT;

			internal delegate void glCopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);

			[ThreadStatic]
			internal static glCopyTextureLevelsAPPLE pglCopyTextureLevelsAPPLE;

			internal delegate void glCopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[ThreadStatic]
			internal static glCopyTextureSubImage1D pglCopyTextureSubImage1D;

			internal delegate void glCopyTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[ThreadStatic]
			internal static glCopyTextureSubImage1DEXT pglCopyTextureSubImage1DEXT;

			internal delegate void glCopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyTextureSubImage2D pglCopyTextureSubImage2D;

			internal delegate void glCopyTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyTextureSubImage2DEXT pglCopyTextureSubImage2DEXT;

			internal delegate void glCopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyTextureSubImage3D pglCopyTextureSubImage3D;

			internal delegate void glCopyTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyTextureSubImage3DEXT pglCopyTextureSubImage3DEXT;

			internal unsafe delegate void glCoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glCoverFillPathInstancedNV pglCoverFillPathInstancedNV;

			internal delegate void glCoverFillPathNV(UInt32 path, Int32 coverMode);

			[ThreadStatic]
			internal static glCoverFillPathNV pglCoverFillPathNV;

			internal unsafe delegate void glCoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glCoverStrokePathInstancedNV pglCoverStrokePathInstancedNV;

			internal delegate void glCoverStrokePathNV(UInt32 path, Int32 coverMode);

			[ThreadStatic]
			internal static glCoverStrokePathNV pglCoverStrokePathNV;

			internal delegate void glCoverageMaskNV(bool mask);

			[ThreadStatic]
			internal static glCoverageMaskNV pglCoverageMaskNV;

			internal delegate void glCoverageModulationNV(Int32 components);

			[ThreadStatic]
			internal static glCoverageModulationNV pglCoverageModulationNV;

			internal unsafe delegate void glCoverageModulationTableNV(Int32 n, float* v);

			[ThreadStatic]
			internal static glCoverageModulationTableNV pglCoverageModulationTableNV;

			internal delegate void glCoverageOperationNV(Int32 operation);

			[ThreadStatic]
			internal static glCoverageOperationNV pglCoverageOperationNV;

			internal unsafe delegate void glCreateBuffers(Int32 n, UInt32* buffers);

			[ThreadStatic]
			internal static glCreateBuffers pglCreateBuffers;

			internal unsafe delegate void glCreateCommandListsNV(Int32 n, UInt32* lists);

			[ThreadStatic]
			internal static glCreateCommandListsNV pglCreateCommandListsNV;

			internal unsafe delegate void glCreateFramebuffers(Int32 n, UInt32* framebuffers);

			[ThreadStatic]
			internal static glCreateFramebuffers pglCreateFramebuffers;

			internal unsafe delegate void glCreatePerfQueryINTEL(UInt32 queryId, UInt32* queryHandle);

			[ThreadStatic]
			internal static glCreatePerfQueryINTEL pglCreatePerfQueryINTEL;

			internal delegate UInt32 glCreateProgram();

			[AliasOf("glCreateProgram")]
			[AliasOf("glCreateProgramObjectARB")]
			[ThreadStatic]
			internal static glCreateProgram pglCreateProgram;

			internal unsafe delegate void glCreateProgramPipelines(Int32 n, UInt32* pipelines);

			[ThreadStatic]
			internal static glCreateProgramPipelines pglCreateProgramPipelines;

			internal unsafe delegate void glCreateQueries(Int32 target, Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glCreateQueries pglCreateQueries;

			internal unsafe delegate void glCreateRenderbuffers(Int32 n, UInt32* renderbuffers);

			[ThreadStatic]
			internal static glCreateRenderbuffers pglCreateRenderbuffers;

			internal unsafe delegate void glCreateSamplers(Int32 n, UInt32* samplers);

			[ThreadStatic]
			internal static glCreateSamplers pglCreateSamplers;

			internal delegate UInt32 glCreateShader(Int32 shaderType);

			[AliasOf("glCreateShader")]
			[AliasOf("glCreateShaderObjectARB")]
			[ThreadStatic]
			internal static glCreateShader pglCreateShader;

			internal delegate UInt32 glCreateShaderProgramEXT(Int32 type, String @string);

			[ThreadStatic]
			internal static glCreateShaderProgramEXT pglCreateShaderProgramEXT;

			internal delegate UInt32 glCreateShaderProgramv(Int32 type, Int32 count, String[] strings);

			[ThreadStatic]
			internal static glCreateShaderProgramv pglCreateShaderProgramv;

			internal delegate UInt32 glCreateShaderProgramvEXT(Int32 type, Int32 count, String[] strings);

			[ThreadStatic]
			internal static glCreateShaderProgramvEXT pglCreateShaderProgramvEXT;

			internal unsafe delegate void glCreateStatesNV(Int32 n, UInt32* states);

			[ThreadStatic]
			internal static glCreateStatesNV pglCreateStatesNV;

			internal unsafe delegate Int32 glCreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags);

			[ThreadStatic]
			internal static glCreateSyncFromCLeventARB pglCreateSyncFromCLeventARB;

			internal unsafe delegate void glCreateTextures(Int32 target, Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glCreateTextures pglCreateTextures;

			internal unsafe delegate void glCreateTransformFeedbacks(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glCreateTransformFeedbacks pglCreateTransformFeedbacks;

			internal unsafe delegate void glCreateVertexArrays(Int32 n, UInt32* arrays);

			[ThreadStatic]
			internal static glCreateVertexArrays pglCreateVertexArrays;

			internal delegate void glCullFace(Int32 mode);

			[ThreadStatic]
			internal static glCullFace pglCullFace;

			internal unsafe delegate void glCullParameterdvEXT(Int32 pname, double* @params);

			[ThreadStatic]
			internal static glCullParameterdvEXT pglCullParameterdvEXT;

			internal unsafe delegate void glCullParameterfvEXT(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glCullParameterfvEXT pglCullParameterfvEXT;

			internal delegate void glCurrentPaletteMatrixARB(Int32 index);

			[ThreadStatic]
			internal static glCurrentPaletteMatrixARB pglCurrentPaletteMatrixARB;

			internal delegate void glCurrentPaletteMatrixOES(UInt32 matrixpaletteindex);

			[ThreadStatic]
			internal static glCurrentPaletteMatrixOES pglCurrentPaletteMatrixOES;

			internal unsafe delegate void glDebugMessageCallback(Gl.DebugProc callback, IntPtr userParam);

			[AliasOf("glDebugMessageCallback")]
			[AliasOf("glDebugMessageCallbackARB")]
			[AliasOf("glDebugMessageCallbackKHR")]
			[ThreadStatic]
			internal static glDebugMessageCallback pglDebugMessageCallback;

			internal unsafe delegate void glDebugMessageCallbackAMD(Gl.DebugProc callback, IntPtr userParam);

			[ThreadStatic]
			internal static glDebugMessageCallbackAMD pglDebugMessageCallbackAMD;

			internal unsafe delegate void glDebugMessageControl(Int32 source, Int32 type, Int32 severity, Int32 count, UInt32* ids, bool enabled);

			[AliasOf("glDebugMessageControl")]
			[AliasOf("glDebugMessageControlARB")]
			[AliasOf("glDebugMessageControlKHR")]
			[ThreadStatic]
			internal static glDebugMessageControl pglDebugMessageControl;

			internal unsafe delegate void glDebugMessageEnableAMD(Int32 category, Int32 severity, Int32 count, UInt32* ids, bool enabled);

			[ThreadStatic]
			internal static glDebugMessageEnableAMD pglDebugMessageEnableAMD;

			internal delegate void glDebugMessageInsert(Int32 source, Int32 type, UInt32 id, Int32 severity, Int32 length, String buf);

			[AliasOf("glDebugMessageInsert")]
			[AliasOf("glDebugMessageInsertARB")]
			[AliasOf("glDebugMessageInsertKHR")]
			[ThreadStatic]
			internal static glDebugMessageInsert pglDebugMessageInsert;

			internal delegate void glDebugMessageInsertAMD(Int32 category, Int32 severity, UInt32 id, Int32 length, String buf);

			[ThreadStatic]
			internal static glDebugMessageInsertAMD pglDebugMessageInsertAMD;

			internal delegate void glDeformSGIX(UInt32 mask);

			[ThreadStatic]
			internal static glDeformSGIX pglDeformSGIX;

			internal unsafe delegate void glDeformationMap3dSGIX(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double w1, double w2, Int32 wstride, Int32 worder, double* points);

			[ThreadStatic]
			internal static glDeformationMap3dSGIX pglDeformationMap3dSGIX;

			internal unsafe delegate void glDeformationMap3fSGIX(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float w1, float w2, Int32 wstride, Int32 worder, float* points);

			[ThreadStatic]
			internal static glDeformationMap3fSGIX pglDeformationMap3fSGIX;

			internal delegate void glDeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);

			[ThreadStatic]
			internal static glDeleteAsyncMarkersSGIX pglDeleteAsyncMarkersSGIX;

			internal unsafe delegate void glDeleteBuffers(Int32 n, UInt32* buffers);

			[AliasOf("glDeleteBuffers")]
			[AliasOf("glDeleteBuffersARB")]
			[ThreadStatic]
			internal static glDeleteBuffers pglDeleteBuffers;

			internal unsafe delegate void glDeleteCommandListsNV(Int32 n, UInt32* lists);

			[ThreadStatic]
			internal static glDeleteCommandListsNV pglDeleteCommandListsNV;

			internal unsafe delegate void glDeleteFencesAPPLE(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glDeleteFencesAPPLE pglDeleteFencesAPPLE;

			internal unsafe delegate void glDeleteFencesNV(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glDeleteFencesNV pglDeleteFencesNV;

			internal delegate void glDeleteFragmentShaderATI(UInt32 id);

			[ThreadStatic]
			internal static glDeleteFragmentShaderATI pglDeleteFragmentShaderATI;

			internal unsafe delegate void glDeleteFramebuffers(Int32 n, UInt32* framebuffers);

			[AliasOf("glDeleteFramebuffers")]
			[AliasOf("glDeleteFramebuffersEXT")]
			[ThreadStatic]
			internal static glDeleteFramebuffers pglDeleteFramebuffers;

			internal unsafe delegate void glDeleteFramebuffersOES(Int32 n, UInt32* framebuffers);

			[ThreadStatic]
			internal static glDeleteFramebuffersOES pglDeleteFramebuffersOES;

			internal delegate void glDeleteLists(UInt32 list, Int32 range);

			[ThreadStatic]
			internal static glDeleteLists pglDeleteLists;

			internal delegate void glDeleteNamedStringARB(Int32 namelen, String name);

			[ThreadStatic]
			internal static glDeleteNamedStringARB pglDeleteNamedStringARB;

			internal unsafe delegate void glDeleteNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			[ThreadStatic]
			internal static glDeleteNamesAMD pglDeleteNamesAMD;

			internal delegate void glDeleteObjectARB(UInt32 obj);

			[ThreadStatic]
			internal static glDeleteObjectARB pglDeleteObjectARB;

			internal unsafe delegate void glDeleteOcclusionQueriesNV(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glDeleteOcclusionQueriesNV pglDeleteOcclusionQueriesNV;

			internal delegate void glDeletePathsNV(UInt32 path, Int32 range);

			[ThreadStatic]
			internal static glDeletePathsNV pglDeletePathsNV;

			internal unsafe delegate void glDeletePerfMonitorsAMD(Int32 n, UInt32* monitors);

			[ThreadStatic]
			internal static glDeletePerfMonitorsAMD pglDeletePerfMonitorsAMD;

			internal delegate void glDeletePerfQueryINTEL(UInt32 queryHandle);

			[ThreadStatic]
			internal static glDeletePerfQueryINTEL pglDeletePerfQueryINTEL;

			internal delegate void glDeleteProgram(UInt32 program);

			[ThreadStatic]
			internal static glDeleteProgram pglDeleteProgram;

			internal unsafe delegate void glDeleteProgramPipelines(Int32 n, UInt32* pipelines);

			[ThreadStatic]
			internal static glDeleteProgramPipelines pglDeleteProgramPipelines;

			internal unsafe delegate void glDeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[ThreadStatic]
			internal static glDeleteProgramPipelinesEXT pglDeleteProgramPipelinesEXT;

			internal unsafe delegate void glDeleteProgramsARB(Int32 n, UInt32* programs);

			[AliasOf("glDeleteProgramsARB")]
			[AliasOf("glDeleteProgramsNV")]
			[ThreadStatic]
			internal static glDeleteProgramsARB pglDeleteProgramsARB;

			internal unsafe delegate void glDeleteQueries(Int32 n, UInt32* ids);

			[AliasOf("glDeleteQueries")]
			[AliasOf("glDeleteQueriesARB")]
			[ThreadStatic]
			internal static glDeleteQueries pglDeleteQueries;

			internal unsafe delegate void glDeleteQueriesEXT(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glDeleteQueriesEXT pglDeleteQueriesEXT;

			internal unsafe delegate void glDeleteRenderbuffers(Int32 n, UInt32* renderbuffers);

			[AliasOf("glDeleteRenderbuffers")]
			[AliasOf("glDeleteRenderbuffersEXT")]
			[ThreadStatic]
			internal static glDeleteRenderbuffers pglDeleteRenderbuffers;

			internal unsafe delegate void glDeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[ThreadStatic]
			internal static glDeleteRenderbuffersOES pglDeleteRenderbuffersOES;

			internal unsafe delegate void glDeleteSamplers(Int32 count, UInt32* samplers);

			[ThreadStatic]
			internal static glDeleteSamplers pglDeleteSamplers;

			internal delegate void glDeleteShader(UInt32 shader);

			[ThreadStatic]
			internal static glDeleteShader pglDeleteShader;

			internal unsafe delegate void glDeleteStatesNV(Int32 n, UInt32* states);

			[ThreadStatic]
			internal static glDeleteStatesNV pglDeleteStatesNV;

			internal delegate void glDeleteSync(Int32 sync);

			[AliasOf("glDeleteSync")]
			[AliasOf("glDeleteSyncAPPLE")]
			[ThreadStatic]
			internal static glDeleteSync pglDeleteSync;

			internal unsafe delegate void glDeleteTextures(Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glDeleteTextures pglDeleteTextures;

			internal unsafe delegate void glDeleteTexturesEXT(Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glDeleteTexturesEXT pglDeleteTexturesEXT;

			internal unsafe delegate void glDeleteTransformFeedbacks(Int32 n, UInt32* ids);

			[AliasOf("glDeleteTransformFeedbacks")]
			[AliasOf("glDeleteTransformFeedbacksNV")]
			[ThreadStatic]
			internal static glDeleteTransformFeedbacks pglDeleteTransformFeedbacks;

			internal unsafe delegate void glDeleteVertexArrays(Int32 n, UInt32* arrays);

			[AliasOf("glDeleteVertexArrays")]
			[AliasOf("glDeleteVertexArraysAPPLE")]
			[AliasOf("glDeleteVertexArraysOES")]
			[ThreadStatic]
			internal static glDeleteVertexArrays pglDeleteVertexArrays;

			internal delegate void glDeleteVertexShaderEXT(UInt32 id);

			[ThreadStatic]
			internal static glDeleteVertexShaderEXT pglDeleteVertexShaderEXT;

			internal delegate void glDepthBoundsEXT(double zmin, double zmax);

			[ThreadStatic]
			internal static glDepthBoundsEXT pglDepthBoundsEXT;

			internal delegate void glDepthBoundsdNV(double zmin, double zmax);

			[ThreadStatic]
			internal static glDepthBoundsdNV pglDepthBoundsdNV;

			internal delegate void glDepthFunc(Int32 func);

			[ThreadStatic]
			internal static glDepthFunc pglDepthFunc;

			internal delegate void glDepthMask(bool flag);

			[ThreadStatic]
			internal static glDepthMask pglDepthMask;

			internal delegate void glDepthRange(double near, double far);

			[ThreadStatic]
			internal static glDepthRange pglDepthRange;

			internal unsafe delegate void glDepthRangeArrayfvNV(UInt32 first, Int32 count, float* v);

			[ThreadStatic]
			internal static glDepthRangeArrayfvNV pglDepthRangeArrayfvNV;

			internal unsafe delegate void glDepthRangeArrayv(UInt32 first, Int32 count, double* v);

			[ThreadStatic]
			internal static glDepthRangeArrayv pglDepthRangeArrayv;

			internal delegate void glDepthRangeIndexed(UInt32 index, double n, double f);

			[ThreadStatic]
			internal static glDepthRangeIndexed pglDepthRangeIndexed;

			internal delegate void glDepthRangeIndexedfNV(UInt32 index, float n, float f);

			[ThreadStatic]
			internal static glDepthRangeIndexedfNV pglDepthRangeIndexedfNV;

			internal delegate void glDepthRangedNV(double zNear, double zFar);

			[ThreadStatic]
			internal static glDepthRangedNV pglDepthRangedNV;

			internal delegate void glDepthRangef(float n, float f);

			[AliasOf("glDepthRangef")]
			[AliasOf("glDepthRangefOES")]
			[ThreadStatic]
			internal static glDepthRangef pglDepthRangef;

			internal unsafe delegate void glDepthRangex(IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glDepthRangex pglDepthRangex;

			internal unsafe delegate void glDepthRangexOES(IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glDepthRangexOES pglDepthRangexOES;

			internal delegate void glDetachShader(UInt32 program, UInt32 shader);

			[AliasOf("glDetachShader")]
			[AliasOf("glDetachObjectARB")]
			[ThreadStatic]
			internal static glDetachShader pglDetachShader;

			internal unsafe delegate void glDetailTexFuncSGIS(Int32 target, Int32 n, float* points);

			[ThreadStatic]
			internal static glDetailTexFuncSGIS pglDetailTexFuncSGIS;

			internal delegate void glDisable(Int32 cap);

			[ThreadStatic]
			internal static glDisable pglDisable;

			internal delegate void glDisableClientState(Int32 array);

			[ThreadStatic]
			internal static glDisableClientState pglDisableClientState;

			internal delegate void glDisableClientStateIndexedEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glDisableClientStateIndexedEXT pglDisableClientStateIndexedEXT;

			internal delegate void glDisableClientStateiEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glDisableClientStateiEXT pglDisableClientStateiEXT;

			internal delegate void glDisableDriverControlQCOM(UInt32 driverControl);

			[ThreadStatic]
			internal static glDisableDriverControlQCOM pglDisableDriverControlQCOM;

			internal delegate void glDisableVariantClientStateEXT(UInt32 id);

			[ThreadStatic]
			internal static glDisableVariantClientStateEXT pglDisableVariantClientStateEXT;

			internal delegate void glDisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[ThreadStatic]
			internal static glDisableVertexArrayAttrib pglDisableVertexArrayAttrib;

			internal delegate void glDisableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[ThreadStatic]
			internal static glDisableVertexArrayAttribEXT pglDisableVertexArrayAttribEXT;

			internal delegate void glDisableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[ThreadStatic]
			internal static glDisableVertexArrayEXT pglDisableVertexArrayEXT;

			internal delegate void glDisableVertexAttribAPPLE(UInt32 index, Int32 pname);

			[ThreadStatic]
			internal static glDisableVertexAttribAPPLE pglDisableVertexAttribAPPLE;

			internal delegate void glDisableVertexAttribArray(UInt32 index);

			[AliasOf("glDisableVertexAttribArray")]
			[AliasOf("glDisableVertexAttribArrayARB")]
			[ThreadStatic]
			internal static glDisableVertexAttribArray pglDisableVertexAttribArray;

			internal delegate void glDisablei(Int32 target, UInt32 index);

			[AliasOf("glDisablei")]
			[AliasOf("glDisableIndexedEXT")]
			[AliasOf("glDisableiEXT")]
			[AliasOf("glDisableiNV")]
			[AliasOf("glDisableiOES")]
			[ThreadStatic]
			internal static glDisablei pglDisablei;

			internal unsafe delegate void glDiscardFramebufferEXT(Int32 target, Int32 numAttachments, Int32* attachments);

			[ThreadStatic]
			internal static glDiscardFramebufferEXT pglDiscardFramebufferEXT;

			internal delegate void glDispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);

			[ThreadStatic]
			internal static glDispatchCompute pglDispatchCompute;

			internal delegate void glDispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);

			[ThreadStatic]
			internal static glDispatchComputeGroupSizeARB pglDispatchComputeGroupSizeARB;

			internal unsafe delegate void glDispatchComputeIndirect(IntPtr indirect);

			[ThreadStatic]
			internal static glDispatchComputeIndirect pglDispatchComputeIndirect;

			internal delegate void glDrawArrays(Int32 mode, Int32 first, Int32 count);

			[AliasOf("glDrawArrays")]
			[AliasOf("glDrawArraysEXT")]
			[ThreadStatic]
			internal static glDrawArrays pglDrawArrays;

			internal unsafe delegate void glDrawArraysIndirect(Int32 mode, IntPtr indirect);

			[ThreadStatic]
			internal static glDrawArraysIndirect pglDrawArraysIndirect;

			internal delegate void glDrawArraysInstanced(Int32 mode, Int32 first, Int32 count, Int32 instancecount);

			[AliasOf("glDrawArraysInstanced")]
			[AliasOf("glDrawArraysInstancedANGLE")]
			[AliasOf("glDrawArraysInstancedARB")]
			[AliasOf("glDrawArraysInstancedEXT")]
			[AliasOf("glDrawArraysInstancedNV")]
			[ThreadStatic]
			internal static glDrawArraysInstanced pglDrawArraysInstanced;

			internal delegate void glDrawArraysInstancedBaseInstance(Int32 mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);

			[AliasOf("glDrawArraysInstancedBaseInstance")]
			[AliasOf("glDrawArraysInstancedBaseInstanceEXT")]
			[ThreadStatic]
			internal static glDrawArraysInstancedBaseInstance pglDrawArraysInstancedBaseInstance;

			internal delegate void glDrawBuffer(Int32 buf);

			[ThreadStatic]
			internal static glDrawBuffer pglDrawBuffer;

			internal unsafe delegate void glDrawBuffers(Int32 n, Int32* bufs);

			[AliasOf("glDrawBuffers")]
			[AliasOf("glDrawBuffersARB")]
			[AliasOf("glDrawBuffersATI")]
			[AliasOf("glDrawBuffersEXT")]
			[ThreadStatic]
			internal static glDrawBuffers pglDrawBuffers;

			internal unsafe delegate void glDrawBuffersIndexedEXT(Int32 n, Int32* location, Int32* indices);

			[ThreadStatic]
			internal static glDrawBuffersIndexedEXT pglDrawBuffersIndexedEXT;

			internal unsafe delegate void glDrawBuffersNV(Int32 n, Int32* bufs);

			[ThreadStatic]
			internal static glDrawBuffersNV pglDrawBuffersNV;

			internal unsafe delegate void glDrawCommandsAddressNV(Int32 primitiveMode, UInt64* indirects, Int32* sizes, UInt32 count);

			[ThreadStatic]
			internal static glDrawCommandsAddressNV pglDrawCommandsAddressNV;

			internal unsafe delegate void glDrawCommandsNV(Int32 primitiveMode, UInt32 buffer, IntPtr* indirects, Int32* sizes, UInt32 count);

			[ThreadStatic]
			internal static glDrawCommandsNV pglDrawCommandsNV;

			internal unsafe delegate void glDrawCommandsStatesAddressNV(UInt64* indirects, Int32* sizes, UInt32* states, UInt32* fbos, UInt32 count);

			[ThreadStatic]
			internal static glDrawCommandsStatesAddressNV pglDrawCommandsStatesAddressNV;

			internal unsafe delegate void glDrawCommandsStatesNV(UInt32 buffer, IntPtr* indirects, Int32* sizes, UInt32* states, UInt32* fbos, UInt32 count);

			[ThreadStatic]
			internal static glDrawCommandsStatesNV pglDrawCommandsStatesNV;

			internal delegate void glDrawElementArrayAPPLE(Int32 mode, Int32 first, Int32 count);

			[ThreadStatic]
			internal static glDrawElementArrayAPPLE pglDrawElementArrayAPPLE;

			internal delegate void glDrawElementArrayATI(Int32 mode, Int32 count);

			[ThreadStatic]
			internal static glDrawElementArrayATI pglDrawElementArrayATI;

			internal unsafe delegate void glDrawElements(Int32 mode, Int32 count, Int32 type, IntPtr indices);

			[ThreadStatic]
			internal static glDrawElements pglDrawElements;

			internal unsafe delegate void glDrawElementsBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[AliasOf("glDrawElementsBaseVertex")]
			[AliasOf("glDrawElementsBaseVertexEXT")]
			[AliasOf("glDrawElementsBaseVertexOES")]
			[ThreadStatic]
			internal static glDrawElementsBaseVertex pglDrawElementsBaseVertex;

			internal unsafe delegate void glDrawElementsIndirect(Int32 mode, Int32 type, IntPtr indirect);

			[ThreadStatic]
			internal static glDrawElementsIndirect pglDrawElementsIndirect;

			internal unsafe delegate void glDrawElementsInstanced(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount);

			[AliasOf("glDrawElementsInstanced")]
			[AliasOf("glDrawElementsInstancedANGLE")]
			[AliasOf("glDrawElementsInstancedARB")]
			[AliasOf("glDrawElementsInstancedEXT")]
			[AliasOf("glDrawElementsInstancedNV")]
			[ThreadStatic]
			internal static glDrawElementsInstanced pglDrawElementsInstanced;

			internal unsafe delegate void glDrawElementsInstancedBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);

			[AliasOf("glDrawElementsInstancedBaseInstance")]
			[AliasOf("glDrawElementsInstancedBaseInstanceEXT")]
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseInstance pglDrawElementsInstancedBaseInstance;

			internal unsafe delegate void glDrawElementsInstancedBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex);

			[AliasOf("glDrawElementsInstancedBaseVertex")]
			[AliasOf("glDrawElementsInstancedBaseVertexEXT")]
			[AliasOf("glDrawElementsInstancedBaseVertexOES")]
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseVertex pglDrawElementsInstancedBaseVertex;

			internal unsafe delegate void glDrawElementsInstancedBaseVertexBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);

			[AliasOf("glDrawElementsInstancedBaseVertexBaseInstance")]
			[AliasOf("glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseVertexBaseInstance pglDrawElementsInstancedBaseVertexBaseInstance;

			internal delegate void glDrawMeshArraysSUN(Int32 mode, Int32 first, Int32 count, Int32 width);

			[ThreadStatic]
			internal static glDrawMeshArraysSUN pglDrawMeshArraysSUN;

			internal unsafe delegate void glDrawPixels(Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glDrawPixels pglDrawPixels;

			internal delegate void glDrawRangeElementArrayAPPLE(Int32 mode, UInt32 start, UInt32 end, Int32 first, Int32 count);

			[ThreadStatic]
			internal static glDrawRangeElementArrayAPPLE pglDrawRangeElementArrayAPPLE;

			internal delegate void glDrawRangeElementArrayATI(Int32 mode, UInt32 start, UInt32 end, Int32 count);

			[ThreadStatic]
			internal static glDrawRangeElementArrayATI pglDrawRangeElementArrayATI;

			internal unsafe delegate void glDrawRangeElements(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices);

			[AliasOf("glDrawRangeElements")]
			[AliasOf("glDrawRangeElementsEXT")]
			[ThreadStatic]
			internal static glDrawRangeElements pglDrawRangeElements;

			internal unsafe delegate void glDrawRangeElementsBaseVertex(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[AliasOf("glDrawRangeElementsBaseVertex")]
			[AliasOf("glDrawRangeElementsBaseVertexEXT")]
			[AliasOf("glDrawRangeElementsBaseVertexOES")]
			[ThreadStatic]
			internal static glDrawRangeElementsBaseVertex pglDrawRangeElementsBaseVertex;

			internal delegate void glDrawTexfOES(float x, float y, float z, float width, float height);

			[ThreadStatic]
			internal static glDrawTexfOES pglDrawTexfOES;

			internal unsafe delegate void glDrawTexfvOES(float* coords);

			[ThreadStatic]
			internal static glDrawTexfvOES pglDrawTexfvOES;

			internal delegate void glDrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glDrawTexiOES pglDrawTexiOES;

			internal unsafe delegate void glDrawTexivOES(Int32* coords);

			[ThreadStatic]
			internal static glDrawTexivOES pglDrawTexivOES;

			internal delegate void glDrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);

			[ThreadStatic]
			internal static glDrawTexsOES pglDrawTexsOES;

			internal unsafe delegate void glDrawTexsvOES(Int16* coords);

			[ThreadStatic]
			internal static glDrawTexsvOES pglDrawTexsvOES;

			internal delegate void glDrawTextureNV(UInt32 texture, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

			[ThreadStatic]
			internal static glDrawTextureNV pglDrawTextureNV;

			internal unsafe delegate void glDrawTexxOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height);

			[ThreadStatic]
			internal static glDrawTexxOES pglDrawTexxOES;

			internal unsafe delegate void glDrawTexxvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glDrawTexxvOES pglDrawTexxvOES;

			internal delegate void glDrawTransformFeedback(Int32 mode, UInt32 id);

			[AliasOf("glDrawTransformFeedback")]
			[AliasOf("glDrawTransformFeedbackNV")]
			[ThreadStatic]
			internal static glDrawTransformFeedback pglDrawTransformFeedback;

			internal delegate void glDrawTransformFeedbackInstanced(Int32 mode, UInt32 id, Int32 instancecount);

			[ThreadStatic]
			internal static glDrawTransformFeedbackInstanced pglDrawTransformFeedbackInstanced;

			internal delegate void glDrawTransformFeedbackStream(Int32 mode, UInt32 id, UInt32 stream);

			[ThreadStatic]
			internal static glDrawTransformFeedbackStream pglDrawTransformFeedbackStream;

			internal delegate void glDrawTransformFeedbackStreamInstanced(Int32 mode, UInt32 id, UInt32 stream, Int32 instancecount);

			[ThreadStatic]
			internal static glDrawTransformFeedbackStreamInstanced pglDrawTransformFeedbackStreamInstanced;

			internal unsafe delegate void glEGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image);

			[ThreadStatic]
			internal static glEGLImageTargetRenderbufferStorageOES pglEGLImageTargetRenderbufferStorageOES;

			internal unsafe delegate void glEGLImageTargetTexture2DOES(Int32 target, IntPtr image);

			[ThreadStatic]
			internal static glEGLImageTargetTexture2DOES pglEGLImageTargetTexture2DOES;

			internal delegate void glEdgeFlag(bool flag);

			[ThreadStatic]
			internal static glEdgeFlag pglEdgeFlag;

			internal delegate void glEdgeFlagFormatNV(Int32 stride);

			[ThreadStatic]
			internal static glEdgeFlagFormatNV pglEdgeFlagFormatNV;

			internal unsafe delegate void glEdgeFlagPointer(Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glEdgeFlagPointer pglEdgeFlagPointer;

			internal unsafe delegate void glEdgeFlagPointerEXT(Int32 stride, Int32 count, bool* pointer);

			[ThreadStatic]
			internal static glEdgeFlagPointerEXT pglEdgeFlagPointerEXT;

			internal delegate void glEdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glEdgeFlagPointerListIBM pglEdgeFlagPointerListIBM;

			internal unsafe delegate void glEdgeFlagv(bool* flag);

			[ThreadStatic]
			internal static glEdgeFlagv pglEdgeFlagv;

			internal unsafe delegate void glElementPointerAPPLE(Int32 type, IntPtr pointer);

			[ThreadStatic]
			internal static glElementPointerAPPLE pglElementPointerAPPLE;

			internal unsafe delegate void glElementPointerATI(Int32 type, IntPtr pointer);

			[ThreadStatic]
			internal static glElementPointerATI pglElementPointerATI;

			internal delegate void glEnable(Int32 cap);

			[ThreadStatic]
			internal static glEnable pglEnable;

			internal delegate void glEnableClientState(Int32 array);

			[ThreadStatic]
			internal static glEnableClientState pglEnableClientState;

			internal delegate void glEnableClientStateIndexedEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glEnableClientStateIndexedEXT pglEnableClientStateIndexedEXT;

			internal delegate void glEnableClientStateiEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glEnableClientStateiEXT pglEnableClientStateiEXT;

			internal delegate void glEnableDriverControlQCOM(UInt32 driverControl);

			[ThreadStatic]
			internal static glEnableDriverControlQCOM pglEnableDriverControlQCOM;

			internal delegate void glEnableVariantClientStateEXT(UInt32 id);

			[ThreadStatic]
			internal static glEnableVariantClientStateEXT pglEnableVariantClientStateEXT;

			internal delegate void glEnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[ThreadStatic]
			internal static glEnableVertexArrayAttrib pglEnableVertexArrayAttrib;

			internal delegate void glEnableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[ThreadStatic]
			internal static glEnableVertexArrayAttribEXT pglEnableVertexArrayAttribEXT;

			internal delegate void glEnableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[ThreadStatic]
			internal static glEnableVertexArrayEXT pglEnableVertexArrayEXT;

			internal delegate void glEnableVertexAttribAPPLE(UInt32 index, Int32 pname);

			[ThreadStatic]
			internal static glEnableVertexAttribAPPLE pglEnableVertexAttribAPPLE;

			internal delegate void glEnableVertexAttribArray(UInt32 index);

			[AliasOf("glEnableVertexAttribArray")]
			[AliasOf("glEnableVertexAttribArrayARB")]
			[ThreadStatic]
			internal static glEnableVertexAttribArray pglEnableVertexAttribArray;

			internal delegate void glEnablei(Int32 target, UInt32 index);

			[AliasOf("glEnablei")]
			[AliasOf("glEnableIndexedEXT")]
			[AliasOf("glEnableiEXT")]
			[AliasOf("glEnableiNV")]
			[AliasOf("glEnableiOES")]
			[ThreadStatic]
			internal static glEnablei pglEnablei;

			internal delegate void glEnd();

			[ThreadStatic]
			internal static glEnd pglEnd;

			internal delegate void glEndConditionalRender();

			[AliasOf("glEndConditionalRender")]
			[AliasOf("glEndConditionalRenderNV")]
			[AliasOf("glEndConditionalRenderNVX")]
			[ThreadStatic]
			internal static glEndConditionalRender pglEndConditionalRender;

			internal delegate void glEndFragmentShaderATI();

			[ThreadStatic]
			internal static glEndFragmentShaderATI pglEndFragmentShaderATI;

			internal delegate void glEndList();

			[ThreadStatic]
			internal static glEndList pglEndList;

			internal delegate void glEndOcclusionQueryNV();

			[ThreadStatic]
			internal static glEndOcclusionQueryNV pglEndOcclusionQueryNV;

			internal delegate void glEndPerfMonitorAMD(UInt32 monitor);

			[ThreadStatic]
			internal static glEndPerfMonitorAMD pglEndPerfMonitorAMD;

			internal delegate void glEndPerfQueryINTEL(UInt32 queryHandle);

			[ThreadStatic]
			internal static glEndPerfQueryINTEL pglEndPerfQueryINTEL;

			internal delegate void glEndQuery(Int32 target);

			[AliasOf("glEndQuery")]
			[AliasOf("glEndQueryARB")]
			[ThreadStatic]
			internal static glEndQuery pglEndQuery;

			internal delegate void glEndQueryEXT(Int32 target);

			[ThreadStatic]
			internal static glEndQueryEXT pglEndQueryEXT;

			internal delegate void glEndQueryIndexed(Int32 target, UInt32 index);

			[ThreadStatic]
			internal static glEndQueryIndexed pglEndQueryIndexed;

			internal delegate void glEndTilingQCOM(UInt32 preserveMask);

			[ThreadStatic]
			internal static glEndTilingQCOM pglEndTilingQCOM;

			internal delegate void glEndTransformFeedback();

			[AliasOf("glEndTransformFeedback")]
			[AliasOf("glEndTransformFeedbackEXT")]
			[AliasOf("glEndTransformFeedbackNV")]
			[ThreadStatic]
			internal static glEndTransformFeedback pglEndTransformFeedback;

			internal delegate void glEndVertexShaderEXT();

			[ThreadStatic]
			internal static glEndVertexShaderEXT pglEndVertexShaderEXT;

			internal delegate void glEndVideoCaptureNV(UInt32 video_capture_slot);

			[ThreadStatic]
			internal static glEndVideoCaptureNV pglEndVideoCaptureNV;

			internal delegate void glEvalCoord1d(double u);

			[ThreadStatic]
			internal static glEvalCoord1d pglEvalCoord1d;

			internal unsafe delegate void glEvalCoord1dv(double* u);

			[ThreadStatic]
			internal static glEvalCoord1dv pglEvalCoord1dv;

			internal delegate void glEvalCoord1f(float u);

			[ThreadStatic]
			internal static glEvalCoord1f pglEvalCoord1f;

			internal unsafe delegate void glEvalCoord1fv(float* u);

			[ThreadStatic]
			internal static glEvalCoord1fv pglEvalCoord1fv;

			internal unsafe delegate void glEvalCoord1xOES(IntPtr u);

			[ThreadStatic]
			internal static glEvalCoord1xOES pglEvalCoord1xOES;

			internal unsafe delegate void glEvalCoord1xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glEvalCoord1xvOES pglEvalCoord1xvOES;

			internal delegate void glEvalCoord2d(double u, double v);

			[ThreadStatic]
			internal static glEvalCoord2d pglEvalCoord2d;

			internal unsafe delegate void glEvalCoord2dv(double* u);

			[ThreadStatic]
			internal static glEvalCoord2dv pglEvalCoord2dv;

			internal delegate void glEvalCoord2f(float u, float v);

			[ThreadStatic]
			internal static glEvalCoord2f pglEvalCoord2f;

			internal unsafe delegate void glEvalCoord2fv(float* u);

			[ThreadStatic]
			internal static glEvalCoord2fv pglEvalCoord2fv;

			internal unsafe delegate void glEvalCoord2xOES(IntPtr u, IntPtr v);

			[ThreadStatic]
			internal static glEvalCoord2xOES pglEvalCoord2xOES;

			internal unsafe delegate void glEvalCoord2xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glEvalCoord2xvOES pglEvalCoord2xvOES;

			internal delegate void glEvalMapsNV(Int32 target, Int32 mode);

			[ThreadStatic]
			internal static glEvalMapsNV pglEvalMapsNV;

			internal delegate void glEvalMesh1(Int32 mode, Int32 i1, Int32 i2);

			[ThreadStatic]
			internal static glEvalMesh1 pglEvalMesh1;

			internal delegate void glEvalMesh2(Int32 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

			[ThreadStatic]
			internal static glEvalMesh2 pglEvalMesh2;

			internal delegate void glEvalPoint1(Int32 i);

			[ThreadStatic]
			internal static glEvalPoint1 pglEvalPoint1;

			internal delegate void glEvalPoint2(Int32 i, Int32 j);

			[ThreadStatic]
			internal static glEvalPoint2 pglEvalPoint2;

			internal delegate void glEvaluateDepthValuesARB();

			[ThreadStatic]
			internal static glEvaluateDepthValuesARB pglEvaluateDepthValuesARB;

			internal unsafe delegate void glExecuteProgramNV(Int32 target, UInt32 id, float* @params);

			[ThreadStatic]
			internal static glExecuteProgramNV pglExecuteProgramNV;

			internal unsafe delegate void glExtGetBufferPointervQCOM(Int32 target, IntPtr* @params);

			[ThreadStatic]
			internal static glExtGetBufferPointervQCOM pglExtGetBufferPointervQCOM;

			internal unsafe delegate void glExtGetBuffersQCOM(UInt32* buffers, Int32 maxBuffers, Int32* numBuffers);

			[ThreadStatic]
			internal static glExtGetBuffersQCOM pglExtGetBuffersQCOM;

			internal unsafe delegate void glExtGetFramebuffersQCOM(UInt32* framebuffers, Int32 maxFramebuffers, Int32* numFramebuffers);

			[ThreadStatic]
			internal static glExtGetFramebuffersQCOM pglExtGetFramebuffersQCOM;

			internal unsafe delegate void glExtGetProgramBinarySourceQCOM(UInt32 program, Int32 shadertype, String source, Int32* length);

			[ThreadStatic]
			internal static glExtGetProgramBinarySourceQCOM pglExtGetProgramBinarySourceQCOM;

			internal unsafe delegate void glExtGetProgramsQCOM(UInt32* programs, Int32 maxPrograms, Int32* numPrograms);

			[ThreadStatic]
			internal static glExtGetProgramsQCOM pglExtGetProgramsQCOM;

			internal unsafe delegate void glExtGetRenderbuffersQCOM(UInt32* renderbuffers, Int32 maxRenderbuffers, Int32* numRenderbuffers);

			[ThreadStatic]
			internal static glExtGetRenderbuffersQCOM pglExtGetRenderbuffersQCOM;

			internal unsafe delegate void glExtGetShadersQCOM(UInt32* shaders, Int32 maxShaders, Int32* numShaders);

			[ThreadStatic]
			internal static glExtGetShadersQCOM pglExtGetShadersQCOM;

			internal unsafe delegate void glExtGetTexLevelParameterivQCOM(UInt32 texture, Int32 face, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glExtGetTexLevelParameterivQCOM pglExtGetTexLevelParameterivQCOM;

			internal unsafe delegate void glExtGetTexSubImageQCOM(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr texels);

			[ThreadStatic]
			internal static glExtGetTexSubImageQCOM pglExtGetTexSubImageQCOM;

			internal unsafe delegate void glExtGetTexturesQCOM(UInt32* textures, Int32 maxTextures, Int32* numTextures);

			[ThreadStatic]
			internal static glExtGetTexturesQCOM pglExtGetTexturesQCOM;

			internal delegate bool glExtIsProgramBinaryQCOM(UInt32 program);

			[ThreadStatic]
			internal static glExtIsProgramBinaryQCOM pglExtIsProgramBinaryQCOM;

			internal delegate void glExtTexObjectStateOverrideiQCOM(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glExtTexObjectStateOverrideiQCOM pglExtTexObjectStateOverrideiQCOM;

			internal delegate void glExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);

			[ThreadStatic]
			internal static glExtractComponentEXT pglExtractComponentEXT;

			internal unsafe delegate void glFeedbackBuffer(Int32 size, Int32 type, float* buffer);

			[ThreadStatic]
			internal static glFeedbackBuffer pglFeedbackBuffer;

			internal unsafe delegate void glFeedbackBufferxOES(Int32 n, Int32 type, IntPtr* buffer);

			[ThreadStatic]
			internal static glFeedbackBufferxOES pglFeedbackBufferxOES;

			internal delegate Int32 glFenceSync(Int32 condition, UInt32 flags);

			[AliasOf("glFenceSync")]
			[AliasOf("glFenceSyncAPPLE")]
			[ThreadStatic]
			internal static glFenceSync pglFenceSync;

			internal delegate void glFinalCombinerInputNV(Int32 variable, Int32 input, Int32 mapping, Int32 componentUsage);

			[ThreadStatic]
			internal static glFinalCombinerInputNV pglFinalCombinerInputNV;

			internal delegate void glFinish();

			[ThreadStatic]
			internal static glFinish pglFinish;

			internal unsafe delegate Int32 glFinishAsyncSGIX(UInt32* markerp);

			[ThreadStatic]
			internal static glFinishAsyncSGIX pglFinishAsyncSGIX;

			internal delegate void glFinishFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glFinishFenceAPPLE pglFinishFenceAPPLE;

			internal delegate void glFinishFenceNV(UInt32 fence);

			[ThreadStatic]
			internal static glFinishFenceNV pglFinishFenceNV;

			internal delegate void glFinishObjectAPPLE(Int32 @object, Int32 name);

			[ThreadStatic]
			internal static glFinishObjectAPPLE pglFinishObjectAPPLE;

			internal delegate void glFinishTextureSUNX();

			[ThreadStatic]
			internal static glFinishTextureSUNX pglFinishTextureSUNX;

			internal delegate void glFlush();

			[ThreadStatic]
			internal static glFlush pglFlush;

			internal unsafe delegate void glFlushMappedBufferRange(Int32 target, IntPtr offset, UInt32 length);

			[AliasOf("glFlushMappedBufferRange")]
			[AliasOf("glFlushMappedBufferRangeAPPLE")]
			[AliasOf("glFlushMappedBufferRangeEXT")]
			[ThreadStatic]
			internal static glFlushMappedBufferRange pglFlushMappedBufferRange;

			internal unsafe delegate void glFlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length);

			[ThreadStatic]
			internal static glFlushMappedNamedBufferRange pglFlushMappedNamedBufferRange;

			internal unsafe delegate void glFlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length);

			[ThreadStatic]
			internal static glFlushMappedNamedBufferRangeEXT pglFlushMappedNamedBufferRangeEXT;

			internal delegate void glFlushPixelDataRangeNV(Int32 target);

			[ThreadStatic]
			internal static glFlushPixelDataRangeNV pglFlushPixelDataRangeNV;

			internal delegate void glFlushRasterSGIX();

			[ThreadStatic]
			internal static glFlushRasterSGIX pglFlushRasterSGIX;

			internal delegate void glFlushStaticDataIBM(Int32 target);

			[ThreadStatic]
			internal static glFlushStaticDataIBM pglFlushStaticDataIBM;

			internal unsafe delegate void glFlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[ThreadStatic]
			internal static glFlushVertexArrayRangeAPPLE pglFlushVertexArrayRangeAPPLE;

			internal delegate void glFlushVertexArrayRangeNV();

			[ThreadStatic]
			internal static glFlushVertexArrayRangeNV pglFlushVertexArrayRangeNV;

			internal delegate void glFogCoordFormatNV(Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glFogCoordFormatNV pglFogCoordFormatNV;

			internal unsafe delegate void glFogCoordPointer(Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glFogCoordPointer")]
			[AliasOf("glFogCoordPointerEXT")]
			[ThreadStatic]
			internal static glFogCoordPointer pglFogCoordPointer;

			internal unsafe delegate void glFogCoordPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glFogCoordPointerListIBM pglFogCoordPointerListIBM;

			internal delegate void glFogCoordd(double coord);

			[AliasOf("glFogCoordd")]
			[AliasOf("glFogCoorddEXT")]
			[ThreadStatic]
			internal static glFogCoordd pglFogCoordd;

			internal unsafe delegate void glFogCoorddv(double* coord);

			[AliasOf("glFogCoorddv")]
			[AliasOf("glFogCoorddvEXT")]
			[ThreadStatic]
			internal static glFogCoorddv pglFogCoorddv;

			internal delegate void glFogCoordf(float coord);

			[AliasOf("glFogCoordf")]
			[AliasOf("glFogCoordfEXT")]
			[ThreadStatic]
			internal static glFogCoordf pglFogCoordf;

			internal unsafe delegate void glFogCoordfv(float* coord);

			[AliasOf("glFogCoordfv")]
			[AliasOf("glFogCoordfvEXT")]
			[ThreadStatic]
			internal static glFogCoordfv pglFogCoordfv;

			internal delegate void glFogCoordhNV(UInt16 fog);

			[ThreadStatic]
			internal static glFogCoordhNV pglFogCoordhNV;

			internal unsafe delegate void glFogCoordhvNV(UInt16* fog);

			[ThreadStatic]
			internal static glFogCoordhvNV pglFogCoordhvNV;

			internal unsafe delegate void glFogFuncSGIS(Int32 n, float* points);

			[ThreadStatic]
			internal static glFogFuncSGIS pglFogFuncSGIS;

			internal delegate void glFogf(Int32 pname, float param);

			[ThreadStatic]
			internal static glFogf pglFogf;

			internal unsafe delegate void glFogfv(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glFogfv pglFogfv;

			internal delegate void glFogi(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFogi pglFogi;

			internal unsafe delegate void glFogiv(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glFogiv pglFogiv;

			internal unsafe delegate void glFogx(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glFogx pglFogx;

			internal unsafe delegate void glFogxOES(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glFogxOES pglFogxOES;

			internal unsafe delegate void glFogxv(Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glFogxv pglFogxv;

			internal unsafe delegate void glFogxvOES(Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glFogxvOES pglFogxvOES;

			internal delegate void glFragmentColorMaterialSGIX(Int32 face, Int32 mode);

			[ThreadStatic]
			internal static glFragmentColorMaterialSGIX pglFragmentColorMaterialSGIX;

			internal delegate void glFragmentCoverageColorNV(UInt32 color);

			[ThreadStatic]
			internal static glFragmentCoverageColorNV pglFragmentCoverageColorNV;

			internal delegate void glFragmentLightModelfSGIX(Int32 pname, float param);

			[ThreadStatic]
			internal static glFragmentLightModelfSGIX pglFragmentLightModelfSGIX;

			internal unsafe delegate void glFragmentLightModelfvSGIX(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glFragmentLightModelfvSGIX pglFragmentLightModelfvSGIX;

			internal delegate void glFragmentLightModeliSGIX(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFragmentLightModeliSGIX pglFragmentLightModeliSGIX;

			internal unsafe delegate void glFragmentLightModelivSGIX(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glFragmentLightModelivSGIX pglFragmentLightModelivSGIX;

			internal delegate void glFragmentLightfSGIX(Int32 light, Int32 pname, float param);

			[ThreadStatic]
			internal static glFragmentLightfSGIX pglFragmentLightfSGIX;

			internal unsafe delegate void glFragmentLightfvSGIX(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glFragmentLightfvSGIX pglFragmentLightfvSGIX;

			internal delegate void glFragmentLightiSGIX(Int32 light, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFragmentLightiSGIX pglFragmentLightiSGIX;

			internal unsafe delegate void glFragmentLightivSGIX(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glFragmentLightivSGIX pglFragmentLightivSGIX;

			internal delegate void glFragmentMaterialfSGIX(Int32 face, Int32 pname, float param);

			[ThreadStatic]
			internal static glFragmentMaterialfSGIX pglFragmentMaterialfSGIX;

			internal unsafe delegate void glFragmentMaterialfvSGIX(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glFragmentMaterialfvSGIX pglFragmentMaterialfvSGIX;

			internal delegate void glFragmentMaterialiSGIX(Int32 face, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFragmentMaterialiSGIX pglFragmentMaterialiSGIX;

			internal unsafe delegate void glFragmentMaterialivSGIX(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glFragmentMaterialivSGIX pglFragmentMaterialivSGIX;

			internal delegate void glFrameTerminatorGREMEDY();

			[ThreadStatic]
			internal static glFrameTerminatorGREMEDY pglFrameTerminatorGREMEDY;

			internal delegate void glFrameZoomSGIX(Int32 factor);

			[ThreadStatic]
			internal static glFrameZoomSGIX pglFrameZoomSGIX;

			internal delegate void glFramebufferDrawBufferEXT(UInt32 framebuffer, Int32 mode);

			[ThreadStatic]
			internal static glFramebufferDrawBufferEXT pglFramebufferDrawBufferEXT;

			internal unsafe delegate void glFramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, Int32* bufs);

			[ThreadStatic]
			internal static glFramebufferDrawBuffersEXT pglFramebufferDrawBuffersEXT;

			internal delegate void glFramebufferParameteri(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFramebufferParameteri pglFramebufferParameteri;

			internal delegate void glFramebufferPixelLocalStorageSizeEXT(UInt32 target, Int32 size);

			[ThreadStatic]
			internal static glFramebufferPixelLocalStorageSizeEXT pglFramebufferPixelLocalStorageSizeEXT;

			internal delegate void glFramebufferReadBufferEXT(UInt32 framebuffer, Int32 mode);

			[ThreadStatic]
			internal static glFramebufferReadBufferEXT pglFramebufferReadBufferEXT;

			internal delegate void glFramebufferRenderbuffer(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[AliasOf("glFramebufferRenderbuffer")]
			[AliasOf("glFramebufferRenderbufferEXT")]
			[ThreadStatic]
			internal static glFramebufferRenderbuffer pglFramebufferRenderbuffer;

			internal delegate void glFramebufferRenderbufferOES(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glFramebufferRenderbufferOES pglFramebufferRenderbufferOES;

			internal unsafe delegate void glFramebufferSampleLocationsfvARB(Int32 target, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvARB pglFramebufferSampleLocationsfvARB;

			internal unsafe delegate void glFramebufferSampleLocationsfvNV(Int32 target, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvNV pglFramebufferSampleLocationsfvNV;

			internal delegate void glFramebufferTexture(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			[AliasOf("glFramebufferTexture")]
			[AliasOf("glFramebufferTextureARB")]
			[AliasOf("glFramebufferTextureEXT")]
			[AliasOf("glFramebufferTextureOES")]
			[ThreadStatic]
			internal static glFramebufferTexture pglFramebufferTexture;

			internal delegate void glFramebufferTexture1D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[AliasOf("glFramebufferTexture1D")]
			[AliasOf("glFramebufferTexture1DEXT")]
			[ThreadStatic]
			internal static glFramebufferTexture1D pglFramebufferTexture1D;

			internal delegate void glFramebufferTexture2D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[AliasOf("glFramebufferTexture2D")]
			[AliasOf("glFramebufferTexture2DEXT")]
			[ThreadStatic]
			internal static glFramebufferTexture2D pglFramebufferTexture2D;

			internal delegate void glFramebufferTexture2DDownsampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 xscale, Int32 yscale);

			[ThreadStatic]
			internal static glFramebufferTexture2DDownsampleIMG pglFramebufferTexture2DDownsampleIMG;

			internal delegate void glFramebufferTexture2DMultisampleEXT(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

			[ThreadStatic]
			internal static glFramebufferTexture2DMultisampleEXT pglFramebufferTexture2DMultisampleEXT;

			internal delegate void glFramebufferTexture2DMultisampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

			[ThreadStatic]
			internal static glFramebufferTexture2DMultisampleIMG pglFramebufferTexture2DMultisampleIMG;

			internal delegate void glFramebufferTexture2DOES(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glFramebufferTexture2DOES pglFramebufferTexture2DOES;

			internal delegate void glFramebufferTexture3D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[AliasOf("glFramebufferTexture3D")]
			[AliasOf("glFramebufferTexture3DEXT")]
			[AliasOf("glFramebufferTexture3DOES")]
			[ThreadStatic]
			internal static glFramebufferTexture3D pglFramebufferTexture3D;

			internal delegate void glFramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[AliasOf("glFramebufferTextureFaceARB")]
			[AliasOf("glFramebufferTextureFaceEXT")]
			[ThreadStatic]
			internal static glFramebufferTextureFaceARB pglFramebufferTextureFaceARB;

			internal delegate void glFramebufferTextureLayer(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[AliasOf("glFramebufferTextureLayer")]
			[AliasOf("glFramebufferTextureLayerARB")]
			[AliasOf("glFramebufferTextureLayerEXT")]
			[ThreadStatic]
			internal static glFramebufferTextureLayer pglFramebufferTextureLayer;

			internal delegate void glFramebufferTextureLayerDownsampleIMG(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer, Int32 xscale, Int32 yscale);

			[ThreadStatic]
			internal static glFramebufferTextureLayerDownsampleIMG pglFramebufferTextureLayerDownsampleIMG;

			internal delegate void glFramebufferTextureMultisampleMultiviewOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 samples, Int32 baseViewIndex, Int32 numViews);

			[ThreadStatic]
			internal static glFramebufferTextureMultisampleMultiviewOVR pglFramebufferTextureMultisampleMultiviewOVR;

			internal delegate void glFramebufferTextureMultiviewOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 baseViewIndex, Int32 numViews);

			[ThreadStatic]
			internal static glFramebufferTextureMultiviewOVR pglFramebufferTextureMultiviewOVR;

			internal delegate void glFreeObjectBufferATI(UInt32 buffer);

			[ThreadStatic]
			internal static glFreeObjectBufferATI pglFreeObjectBufferATI;

			internal delegate void glFrontFace(Int32 mode);

			[ThreadStatic]
			internal static glFrontFace pglFrontFace;

			internal delegate void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glFrustum pglFrustum;

			internal delegate void glFrustumf(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glFrustumf pglFrustumf;

			internal delegate void glFrustumfOES(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glFrustumfOES pglFrustumfOES;

			internal unsafe delegate void glFrustumx(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glFrustumx pglFrustumx;

			internal unsafe delegate void glFrustumxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glFrustumxOES pglFrustumxOES;

			internal delegate UInt32 glGenAsyncMarkersSGIX(Int32 range);

			[ThreadStatic]
			internal static glGenAsyncMarkersSGIX pglGenAsyncMarkersSGIX;

			internal unsafe delegate void glGenBuffers(Int32 n, UInt32* buffers);

			[AliasOf("glGenBuffers")]
			[AliasOf("glGenBuffersARB")]
			[ThreadStatic]
			internal static glGenBuffers pglGenBuffers;

			internal unsafe delegate void glGenFencesAPPLE(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glGenFencesAPPLE pglGenFencesAPPLE;

			internal unsafe delegate void glGenFencesNV(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glGenFencesNV pglGenFencesNV;

			internal delegate UInt32 glGenFragmentShadersATI(UInt32 range);

			[ThreadStatic]
			internal static glGenFragmentShadersATI pglGenFragmentShadersATI;

			internal unsafe delegate void glGenFramebuffers(Int32 n, UInt32* framebuffers);

			[AliasOf("glGenFramebuffers")]
			[AliasOf("glGenFramebuffersEXT")]
			[ThreadStatic]
			internal static glGenFramebuffers pglGenFramebuffers;

			internal unsafe delegate void glGenFramebuffersOES(Int32 n, UInt32* framebuffers);

			[ThreadStatic]
			internal static glGenFramebuffersOES pglGenFramebuffersOES;

			internal delegate UInt32 glGenLists(Int32 range);

			[ThreadStatic]
			internal static glGenLists pglGenLists;

			internal unsafe delegate void glGenNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			[ThreadStatic]
			internal static glGenNamesAMD pglGenNamesAMD;

			internal unsafe delegate void glGenOcclusionQueriesNV(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glGenOcclusionQueriesNV pglGenOcclusionQueriesNV;

			internal delegate UInt32 glGenPathsNV(Int32 range);

			[ThreadStatic]
			internal static glGenPathsNV pglGenPathsNV;

			internal unsafe delegate void glGenPerfMonitorsAMD(Int32 n, UInt32* monitors);

			[ThreadStatic]
			internal static glGenPerfMonitorsAMD pglGenPerfMonitorsAMD;

			internal unsafe delegate void glGenProgramPipelines(Int32 n, UInt32* pipelines);

			[ThreadStatic]
			internal static glGenProgramPipelines pglGenProgramPipelines;

			internal unsafe delegate void glGenProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[ThreadStatic]
			internal static glGenProgramPipelinesEXT pglGenProgramPipelinesEXT;

			internal unsafe delegate void glGenProgramsARB(Int32 n, UInt32* programs);

			[AliasOf("glGenProgramsARB")]
			[AliasOf("glGenProgramsNV")]
			[ThreadStatic]
			internal static glGenProgramsARB pglGenProgramsARB;

			internal unsafe delegate void glGenQueries(Int32 n, UInt32* ids);

			[AliasOf("glGenQueries")]
			[AliasOf("glGenQueriesARB")]
			[ThreadStatic]
			internal static glGenQueries pglGenQueries;

			internal unsafe delegate void glGenQueriesEXT(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glGenQueriesEXT pglGenQueriesEXT;

			internal unsafe delegate void glGenRenderbuffers(Int32 n, UInt32* renderbuffers);

			[AliasOf("glGenRenderbuffers")]
			[AliasOf("glGenRenderbuffersEXT")]
			[ThreadStatic]
			internal static glGenRenderbuffers pglGenRenderbuffers;

			internal unsafe delegate void glGenRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[ThreadStatic]
			internal static glGenRenderbuffersOES pglGenRenderbuffersOES;

			internal unsafe delegate void glGenSamplers(Int32 count, UInt32* samplers);

			[ThreadStatic]
			internal static glGenSamplers pglGenSamplers;

			internal delegate UInt32 glGenSymbolsEXT(Int32 datatype, Int32 storagetype, Int32 range, UInt32 components);

			[ThreadStatic]
			internal static glGenSymbolsEXT pglGenSymbolsEXT;

			internal unsafe delegate void glGenTextures(Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glGenTextures pglGenTextures;

			internal unsafe delegate void glGenTexturesEXT(Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glGenTexturesEXT pglGenTexturesEXT;

			internal unsafe delegate void glGenTransformFeedbacks(Int32 n, UInt32* ids);

			[AliasOf("glGenTransformFeedbacks")]
			[AliasOf("glGenTransformFeedbacksNV")]
			[ThreadStatic]
			internal static glGenTransformFeedbacks pglGenTransformFeedbacks;

			internal unsafe delegate void glGenVertexArrays(Int32 n, UInt32* arrays);

			[AliasOf("glGenVertexArrays")]
			[AliasOf("glGenVertexArraysAPPLE")]
			[AliasOf("glGenVertexArraysOES")]
			[ThreadStatic]
			internal static glGenVertexArrays pglGenVertexArrays;

			internal delegate UInt32 glGenVertexShadersEXT(UInt32 range);

			[ThreadStatic]
			internal static glGenVertexShadersEXT pglGenVertexShadersEXT;

			internal delegate void glGenerateMipmap(Int32 target);

			[AliasOf("glGenerateMipmap")]
			[AliasOf("glGenerateMipmapEXT")]
			[ThreadStatic]
			internal static glGenerateMipmap pglGenerateMipmap;

			internal delegate void glGenerateMipmapOES(Int32 target);

			[ThreadStatic]
			internal static glGenerateMipmapOES pglGenerateMipmapOES;

			internal delegate void glGenerateMultiTexMipmapEXT(Int32 texunit, Int32 target);

			[ThreadStatic]
			internal static glGenerateMultiTexMipmapEXT pglGenerateMultiTexMipmapEXT;

			internal delegate void glGenerateTextureMipmap(UInt32 texture);

			[ThreadStatic]
			internal static glGenerateTextureMipmap pglGenerateTextureMipmap;

			internal delegate void glGenerateTextureMipmapEXT(UInt32 texture, Int32 target);

			[ThreadStatic]
			internal static glGenerateTextureMipmapEXT pglGenerateTextureMipmapEXT;

			internal unsafe delegate void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetActiveAtomicCounterBufferiv pglGetActiveAtomicCounterBufferiv;

			internal unsafe delegate void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[AliasOf("glGetActiveAttrib")]
			[AliasOf("glGetActiveAttribARB")]
			[ThreadStatic]
			internal static glGetActiveAttrib pglGetActiveAttrib;

			internal unsafe delegate void glGetActiveSubroutineName(UInt32 program, Int32 shadertype, UInt32 index, Int32 bufsize, Int32* length, [Out] StringBuilder name);

			[ThreadStatic]
			internal static glGetActiveSubroutineName pglGetActiveSubroutineName;

			internal unsafe delegate void glGetActiveSubroutineUniformName(UInt32 program, Int32 shadertype, UInt32 index, Int32 bufsize, Int32* length, [Out] StringBuilder name);

			[ThreadStatic]
			internal static glGetActiveSubroutineUniformName pglGetActiveSubroutineUniformName;

			internal unsafe delegate void glGetActiveSubroutineUniformiv(UInt32 program, Int32 shadertype, UInt32 index, Int32 pname, Int32* values);

			[ThreadStatic]
			internal static glGetActiveSubroutineUniformiv pglGetActiveSubroutineUniformiv;

			internal unsafe delegate void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[AliasOf("glGetActiveUniform")]
			[AliasOf("glGetActiveUniformARB")]
			[ThreadStatic]
			internal static glGetActiveUniform pglGetActiveUniform;

			internal unsafe delegate void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, Int32* length, [Out] StringBuilder uniformBlockName);

			[ThreadStatic]
			internal static glGetActiveUniformBlockName pglGetActiveUniformBlockName;

			internal unsafe delegate void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetActiveUniformBlockiv pglGetActiveUniformBlockiv;

			internal unsafe delegate void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, Int32* length, [Out] StringBuilder uniformName);

			[ThreadStatic]
			internal static glGetActiveUniformName pglGetActiveUniformName;

			internal unsafe delegate void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetActiveUniformsiv pglGetActiveUniformsiv;

			internal unsafe delegate void glGetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[ThreadStatic]
			internal static glGetActiveVaryingNV pglGetActiveVaryingNV;

			internal unsafe delegate void glGetArrayObjectfvATI(Int32 array, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetArrayObjectfvATI pglGetArrayObjectfvATI;

			internal unsafe delegate void glGetArrayObjectivATI(Int32 array, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetArrayObjectivATI pglGetArrayObjectivATI;

			internal unsafe delegate void glGetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, Int32* count, UInt32* obj);

			[ThreadStatic]
			internal static glGetAttachedObjectsARB pglGetAttachedObjectsARB;

			internal unsafe delegate void glGetAttachedShaders(UInt32 program, Int32 maxCount, Int32* count, UInt32* shaders);

			[ThreadStatic]
			internal static glGetAttachedShaders pglGetAttachedShaders;

			internal delegate Int32 glGetAttribLocation(UInt32 program, String name);

			[AliasOf("glGetAttribLocation")]
			[AliasOf("glGetAttribLocationARB")]
			[ThreadStatic]
			internal static glGetAttribLocation pglGetAttribLocation;

			internal unsafe delegate void glGetBooleani_v(Int32 target, UInt32 index, bool* data);

			[AliasOf("glGetBooleani_v")]
			[AliasOf("glGetBooleanIndexedvEXT")]
			[ThreadStatic]
			internal static glGetBooleani_v pglGetBooleani_v;

			internal unsafe delegate void glGetBooleanv(Int32 pname, bool* data);

			[ThreadStatic]
			internal static glGetBooleanv pglGetBooleanv;

			internal unsafe delegate void glGetBufferParameteri64v(Int32 target, Int32 pname, Int64* @params);

			[ThreadStatic]
			internal static glGetBufferParameteri64v pglGetBufferParameteri64v;

			internal unsafe delegate void glGetBufferParameteriv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glGetBufferParameteriv")]
			[AliasOf("glGetBufferParameterivARB")]
			[ThreadStatic]
			internal static glGetBufferParameteriv pglGetBufferParameteriv;

			internal unsafe delegate void glGetBufferParameterui64vNV(Int32 target, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetBufferParameterui64vNV pglGetBufferParameterui64vNV;

			internal unsafe delegate void glGetBufferPointerv(Int32 target, Int32 pname, IntPtr* @params);

			[AliasOf("glGetBufferPointerv")]
			[AliasOf("glGetBufferPointervARB")]
			[AliasOf("glGetBufferPointervOES")]
			[ThreadStatic]
			internal static glGetBufferPointerv pglGetBufferPointerv;

			internal unsafe delegate void glGetBufferSubData(Int32 target, IntPtr offset, UInt32 size, IntPtr data);

			[AliasOf("glGetBufferSubData")]
			[AliasOf("glGetBufferSubDataARB")]
			[ThreadStatic]
			internal static glGetBufferSubData pglGetBufferSubData;

			internal unsafe delegate void glGetClipPlane(Int32 plane, double* equation);

			[ThreadStatic]
			internal static glGetClipPlane pglGetClipPlane;

			internal unsafe delegate void glGetClipPlanef(Int32 plane, float* equation);

			[ThreadStatic]
			internal static glGetClipPlanef pglGetClipPlanef;

			internal unsafe delegate void glGetClipPlanefOES(Int32 plane, float* equation);

			[ThreadStatic]
			internal static glGetClipPlanefOES pglGetClipPlanefOES;

			internal unsafe delegate void glGetClipPlanex(Int32 plane, IntPtr* equation);

			[ThreadStatic]
			internal static glGetClipPlanex pglGetClipPlanex;

			internal unsafe delegate void glGetClipPlanexOES(Int32 plane, IntPtr* equation);

			[ThreadStatic]
			internal static glGetClipPlanexOES pglGetClipPlanexOES;

			internal unsafe delegate void glGetColorTable(Int32 target, Int32 format, Int32 type, IntPtr table);

			[AliasOf("glGetColorTable")]
			[AliasOf("glGetColorTableEXT")]
			[ThreadStatic]
			internal static glGetColorTable pglGetColorTable;

			internal unsafe delegate void glGetColorTableParameterfv(Int32 target, Int32 pname, float* @params);

			[AliasOf("glGetColorTableParameterfv")]
			[AliasOf("glGetColorTableParameterfvEXT")]
			[ThreadStatic]
			internal static glGetColorTableParameterfv pglGetColorTableParameterfv;

			internal unsafe delegate void glGetColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetColorTableParameterfvSGI pglGetColorTableParameterfvSGI;

			internal unsafe delegate void glGetColorTableParameteriv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glGetColorTableParameteriv")]
			[AliasOf("glGetColorTableParameterivEXT")]
			[ThreadStatic]
			internal static glGetColorTableParameteriv pglGetColorTableParameteriv;

			internal unsafe delegate void glGetColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetColorTableParameterivSGI pglGetColorTableParameterivSGI;

			internal unsafe delegate void glGetColorTableSGI(Int32 target, Int32 format, Int32 type, IntPtr table);

			[ThreadStatic]
			internal static glGetColorTableSGI pglGetColorTableSGI;

			internal unsafe delegate void glGetCombinerInputParameterfvNV(Int32 stage, Int32 portion, Int32 variable, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetCombinerInputParameterfvNV pglGetCombinerInputParameterfvNV;

			internal unsafe delegate void glGetCombinerInputParameterivNV(Int32 stage, Int32 portion, Int32 variable, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetCombinerInputParameterivNV pglGetCombinerInputParameterivNV;

			internal unsafe delegate void glGetCombinerOutputParameterfvNV(Int32 stage, Int32 portion, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetCombinerOutputParameterfvNV pglGetCombinerOutputParameterfvNV;

			internal unsafe delegate void glGetCombinerOutputParameterivNV(Int32 stage, Int32 portion, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetCombinerOutputParameterivNV pglGetCombinerOutputParameterivNV;

			internal unsafe delegate void glGetCombinerStageParameterfvNV(Int32 stage, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetCombinerStageParameterfvNV pglGetCombinerStageParameterfvNV;

			internal delegate UInt32 glGetCommandHeaderNV(Int32 tokenID, UInt32 size);

			[ThreadStatic]
			internal static glGetCommandHeaderNV pglGetCommandHeaderNV;

			internal unsafe delegate void glGetCompressedMultiTexImageEXT(Int32 texunit, Int32 target, Int32 lod, IntPtr img);

			[ThreadStatic]
			internal static glGetCompressedMultiTexImageEXT pglGetCompressedMultiTexImageEXT;

			internal unsafe delegate void glGetCompressedTexImage(Int32 target, Int32 level, IntPtr img);

			[AliasOf("glGetCompressedTexImage")]
			[AliasOf("glGetCompressedTexImageARB")]
			[ThreadStatic]
			internal static glGetCompressedTexImage pglGetCompressedTexImage;

			internal unsafe delegate void glGetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels);

			[ThreadStatic]
			internal static glGetCompressedTextureImage pglGetCompressedTextureImage;

			internal unsafe delegate void glGetCompressedTextureImageEXT(UInt32 texture, Int32 target, Int32 lod, IntPtr img);

			[ThreadStatic]
			internal static glGetCompressedTextureImageEXT pglGetCompressedTextureImageEXT;

			internal unsafe delegate void glGetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels);

			[ThreadStatic]
			internal static glGetCompressedTextureSubImage pglGetCompressedTextureSubImage;

			internal unsafe delegate void glGetConvolutionFilter(Int32 target, Int32 format, Int32 type, IntPtr image);

			[ThreadStatic]
			internal static glGetConvolutionFilter pglGetConvolutionFilter;

			internal unsafe delegate void glGetConvolutionFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr image);

			[ThreadStatic]
			internal static glGetConvolutionFilterEXT pglGetConvolutionFilterEXT;

			internal unsafe delegate void glGetConvolutionParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameterfv pglGetConvolutionParameterfv;

			internal unsafe delegate void glGetConvolutionParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameterfvEXT pglGetConvolutionParameterfvEXT;

			internal unsafe delegate void glGetConvolutionParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameteriv pglGetConvolutionParameteriv;

			internal unsafe delegate void glGetConvolutionParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameterivEXT pglGetConvolutionParameterivEXT;

			internal unsafe delegate void glGetConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameterxvOES pglGetConvolutionParameterxvOES;

			internal unsafe delegate void glGetCoverageModulationTableNV(Int32 bufsize, float* v);

			[ThreadStatic]
			internal static glGetCoverageModulationTableNV pglGetCoverageModulationTableNV;

			internal unsafe delegate UInt32 glGetDebugMessageLog(UInt32 count, Int32 bufSize, Int32* sources, Int32* types, UInt32* ids, Int32* severities, Int32* lengths, [Out] StringBuilder messageLog);

			[AliasOf("glGetDebugMessageLog")]
			[AliasOf("glGetDebugMessageLogARB")]
			[AliasOf("glGetDebugMessageLogKHR")]
			[ThreadStatic]
			internal static glGetDebugMessageLog pglGetDebugMessageLog;

			internal unsafe delegate UInt32 glGetDebugMessageLogAMD(UInt32 count, Int32 bufsize, Int32* categories, UInt32* severities, UInt32* ids, Int32* lengths, [Out] StringBuilder message);

			[ThreadStatic]
			internal static glGetDebugMessageLogAMD pglGetDebugMessageLogAMD;

			internal unsafe delegate void glGetDetailTexFuncSGIS(Int32 target, float* points);

			[ThreadStatic]
			internal static glGetDetailTexFuncSGIS pglGetDetailTexFuncSGIS;

			internal unsafe delegate void glGetDoublei_v(Int32 target, UInt32 index, double* data);

			[AliasOf("glGetDoublei_v")]
			[AliasOf("glGetDoubleIndexedvEXT")]
			[AliasOf("glGetDoublei_vEXT")]
			[ThreadStatic]
			internal static glGetDoublei_v pglGetDoublei_v;

			internal unsafe delegate void glGetDoublev(Int32 pname, double* data);

			[ThreadStatic]
			internal static glGetDoublev pglGetDoublev;

			internal unsafe delegate void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, Int32* length, [Out] StringBuilder driverControlString);

			[ThreadStatic]
			internal static glGetDriverControlStringQCOM pglGetDriverControlStringQCOM;

			internal unsafe delegate void glGetDriverControlsQCOM(Int32* num, Int32 size, UInt32* driverControls);

			[ThreadStatic]
			internal static glGetDriverControlsQCOM pglGetDriverControlsQCOM;

			internal delegate Int32 glGetError();

			[ThreadStatic]
			internal static glGetError pglGetError;

			internal unsafe delegate void glGetFenceivNV(UInt32 fence, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFenceivNV pglGetFenceivNV;

			internal unsafe delegate void glGetFinalCombinerInputParameterfvNV(Int32 variable, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetFinalCombinerInputParameterfvNV pglGetFinalCombinerInputParameterfvNV;

			internal unsafe delegate void glGetFinalCombinerInputParameterivNV(Int32 variable, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFinalCombinerInputParameterivNV pglGetFinalCombinerInputParameterivNV;

			internal unsafe delegate void glGetFirstPerfQueryIdINTEL(UInt32* queryId);

			[ThreadStatic]
			internal static glGetFirstPerfQueryIdINTEL pglGetFirstPerfQueryIdINTEL;

			internal unsafe delegate void glGetFixedv(Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetFixedv pglGetFixedv;

			internal unsafe delegate void glGetFixedvOES(Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetFixedvOES pglGetFixedvOES;

			internal unsafe delegate void glGetFloati_v(Int32 target, UInt32 index, float* data);

			[AliasOf("glGetFloati_v")]
			[AliasOf("glGetFloatIndexedvEXT")]
			[AliasOf("glGetFloati_vEXT")]
			[AliasOf("glGetFloati_vNV")]
			[ThreadStatic]
			internal static glGetFloati_v pglGetFloati_v;

			internal unsafe delegate void glGetFloatv(Int32 pname, float* data);

			[ThreadStatic]
			internal static glGetFloatv pglGetFloatv;

			internal unsafe delegate void glGetFogFuncSGIS(float* points);

			[ThreadStatic]
			internal static glGetFogFuncSGIS pglGetFogFuncSGIS;

			internal delegate Int32 glGetFragDataIndex(UInt32 program, String name);

			[AliasOf("glGetFragDataIndex")]
			[AliasOf("glGetFragDataIndexEXT")]
			[ThreadStatic]
			internal static glGetFragDataIndex pglGetFragDataIndex;

			internal delegate Int32 glGetFragDataLocation(UInt32 program, String name);

			[AliasOf("glGetFragDataLocation")]
			[AliasOf("glGetFragDataLocationEXT")]
			[ThreadStatic]
			internal static glGetFragDataLocation pglGetFragDataLocation;

			internal unsafe delegate void glGetFragmentLightfvSGIX(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetFragmentLightfvSGIX pglGetFragmentLightfvSGIX;

			internal unsafe delegate void glGetFragmentLightivSGIX(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFragmentLightivSGIX pglGetFragmentLightivSGIX;

			internal unsafe delegate void glGetFragmentMaterialfvSGIX(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetFragmentMaterialfvSGIX pglGetFragmentMaterialfvSGIX;

			internal unsafe delegate void glGetFragmentMaterialivSGIX(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFragmentMaterialivSGIX pglGetFragmentMaterialivSGIX;

			internal unsafe delegate void glGetFramebufferAttachmentParameteriv(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[AliasOf("glGetFramebufferAttachmentParameteriv")]
			[AliasOf("glGetFramebufferAttachmentParameterivEXT")]
			[ThreadStatic]
			internal static glGetFramebufferAttachmentParameteriv pglGetFramebufferAttachmentParameteriv;

			internal unsafe delegate void glGetFramebufferAttachmentParameterivOES(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFramebufferAttachmentParameterivOES pglGetFramebufferAttachmentParameterivOES;

			internal unsafe delegate void glGetFramebufferParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFramebufferParameteriv pglGetFramebufferParameteriv;

			internal unsafe delegate void glGetFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFramebufferParameterivEXT pglGetFramebufferParameterivEXT;

			internal delegate Int32 glGetFramebufferPixelLocalStorageSizeEXT(UInt32 target);

			[ThreadStatic]
			internal static glGetFramebufferPixelLocalStorageSizeEXT pglGetFramebufferPixelLocalStorageSizeEXT;

			internal delegate Int32 glGetGraphicsResetStatus();

			[AliasOf("glGetGraphicsResetStatus")]
			[AliasOf("glGetGraphicsResetStatusKHR")]
			[ThreadStatic]
			internal static glGetGraphicsResetStatus pglGetGraphicsResetStatus;

			internal delegate Int32 glGetGraphicsResetStatusARB();

			[ThreadStatic]
			internal static glGetGraphicsResetStatusARB pglGetGraphicsResetStatusARB;

			internal delegate Int32 glGetGraphicsResetStatusEXT();

			[ThreadStatic]
			internal static glGetGraphicsResetStatusEXT pglGetGraphicsResetStatusEXT;

			internal delegate UInt32 glGetHandleARB(Int32 pname);

			[ThreadStatic]
			internal static glGetHandleARB pglGetHandleARB;

			internal unsafe delegate void glGetHistogram(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[ThreadStatic]
			internal static glGetHistogram pglGetHistogram;

			internal unsafe delegate void glGetHistogramEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[ThreadStatic]
			internal static glGetHistogramEXT pglGetHistogramEXT;

			internal unsafe delegate void glGetHistogramParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetHistogramParameterfv pglGetHistogramParameterfv;

			internal unsafe delegate void glGetHistogramParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetHistogramParameterfvEXT pglGetHistogramParameterfvEXT;

			internal unsafe delegate void glGetHistogramParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetHistogramParameteriv pglGetHistogramParameteriv;

			internal unsafe delegate void glGetHistogramParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetHistogramParameterivEXT pglGetHistogramParameterivEXT;

			internal unsafe delegate void glGetHistogramParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetHistogramParameterxvOES pglGetHistogramParameterxvOES;

			internal delegate UInt64 glGetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[ThreadStatic]
			internal static glGetImageHandleARB pglGetImageHandleARB;

			internal delegate UInt64 glGetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[ThreadStatic]
			internal static glGetImageHandleNV pglGetImageHandleNV;

			internal unsafe delegate void glGetImageTransformParameterfvHP(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetImageTransformParameterfvHP pglGetImageTransformParameterfvHP;

			internal unsafe delegate void glGetImageTransformParameterivHP(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetImageTransformParameterivHP pglGetImageTransformParameterivHP;

			internal unsafe delegate void glGetInfoLogARB(UInt32 obj, Int32 maxLength, Int32* length, [Out] StringBuilder infoLog);

			[ThreadStatic]
			internal static glGetInfoLogARB pglGetInfoLogARB;

			internal delegate Int32 glGetInstrumentsSGIX();

			[ThreadStatic]
			internal static glGetInstrumentsSGIX pglGetInstrumentsSGIX;

			internal unsafe delegate void glGetInteger64i_v(Int32 target, UInt32 index, Int64* data);

			[ThreadStatic]
			internal static glGetInteger64i_v pglGetInteger64i_v;

			internal unsafe delegate void glGetInteger64v(Int32 pname, Int64* data);

			[AliasOf("glGetInteger64v")]
			[AliasOf("glGetInteger64vAPPLE")]
			[ThreadStatic]
			internal static glGetInteger64v pglGetInteger64v;

			internal unsafe delegate void glGetIntegeri_v(Int32 target, UInt32 index, Int32* data);

			[AliasOf("glGetIntegeri_v")]
			[AliasOf("glGetIntegerIndexedvEXT")]
			[ThreadStatic]
			internal static glGetIntegeri_v pglGetIntegeri_v;

			internal unsafe delegate void glGetIntegeri_vEXT(Int32 target, UInt32 index, Int32* data);

			[ThreadStatic]
			internal static glGetIntegeri_vEXT pglGetIntegeri_vEXT;

			internal unsafe delegate void glGetIntegerui64i_vNV(Int32 value, UInt32 index, UInt64* result);

			[ThreadStatic]
			internal static glGetIntegerui64i_vNV pglGetIntegerui64i_vNV;

			internal unsafe delegate void glGetIntegerui64vNV(Int32 value, UInt64* result);

			[ThreadStatic]
			internal static glGetIntegerui64vNV pglGetIntegerui64vNV;

			internal unsafe delegate void glGetIntegerv(Int32 pname, Int32* data);

			[ThreadStatic]
			internal static glGetIntegerv pglGetIntegerv;

			internal unsafe delegate void glGetInternalformatSampleivNV(Int32 target, Int32 internalformat, Int32 samples, Int32 pname, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetInternalformatSampleivNV pglGetInternalformatSampleivNV;

			internal unsafe delegate void glGetInternalformati64v(Int32 target, Int32 internalformat, Int32 pname, Int32 bufSize, Int64* @params);

			[ThreadStatic]
			internal static glGetInternalformati64v pglGetInternalformati64v;

			internal unsafe delegate void glGetInternalformativ(Int32 target, Int32 internalformat, Int32 pname, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetInternalformativ pglGetInternalformativ;

			internal unsafe delegate void glGetInvariantBooleanvEXT(UInt32 id, Int32 value, bool* data);

			[ThreadStatic]
			internal static glGetInvariantBooleanvEXT pglGetInvariantBooleanvEXT;

			internal unsafe delegate void glGetInvariantFloatvEXT(UInt32 id, Int32 value, float* data);

			[ThreadStatic]
			internal static glGetInvariantFloatvEXT pglGetInvariantFloatvEXT;

			internal unsafe delegate void glGetInvariantIntegervEXT(UInt32 id, Int32 value, Int32* data);

			[ThreadStatic]
			internal static glGetInvariantIntegervEXT pglGetInvariantIntegervEXT;

			internal unsafe delegate void glGetLightfv(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetLightfv pglGetLightfv;

			internal unsafe delegate void glGetLightiv(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetLightiv pglGetLightiv;

			internal unsafe delegate void glGetLightxOES(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetLightxOES pglGetLightxOES;

			internal unsafe delegate void glGetLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetLightxv pglGetLightxv;

			internal unsafe delegate void glGetLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetLightxvOES pglGetLightxvOES;

			internal unsafe delegate void glGetListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetListParameterfvSGIX pglGetListParameterfvSGIX;

			internal unsafe delegate void glGetListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetListParameterivSGIX pglGetListParameterivSGIX;

			internal unsafe delegate void glGetLocalConstantBooleanvEXT(UInt32 id, Int32 value, bool* data);

			[ThreadStatic]
			internal static glGetLocalConstantBooleanvEXT pglGetLocalConstantBooleanvEXT;

			internal unsafe delegate void glGetLocalConstantFloatvEXT(UInt32 id, Int32 value, float* data);

			[ThreadStatic]
			internal static glGetLocalConstantFloatvEXT pglGetLocalConstantFloatvEXT;

			internal unsafe delegate void glGetLocalConstantIntegervEXT(UInt32 id, Int32 value, Int32* data);

			[ThreadStatic]
			internal static glGetLocalConstantIntegervEXT pglGetLocalConstantIntegervEXT;

			internal unsafe delegate void glGetMapAttribParameterfvNV(Int32 target, UInt32 index, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMapAttribParameterfvNV pglGetMapAttribParameterfvNV;

			internal unsafe delegate void glGetMapAttribParameterivNV(Int32 target, UInt32 index, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMapAttribParameterivNV pglGetMapAttribParameterivNV;

			internal unsafe delegate void glGetMapControlPointsNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, bool packed, IntPtr points);

			[ThreadStatic]
			internal static glGetMapControlPointsNV pglGetMapControlPointsNV;

			internal unsafe delegate void glGetMapParameterfvNV(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMapParameterfvNV pglGetMapParameterfvNV;

			internal unsafe delegate void glGetMapParameterivNV(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMapParameterivNV pglGetMapParameterivNV;

			internal unsafe delegate void glGetMapdv(Int32 target, Int32 query, double* v);

			[ThreadStatic]
			internal static glGetMapdv pglGetMapdv;

			internal unsafe delegate void glGetMapfv(Int32 target, Int32 query, float* v);

			[ThreadStatic]
			internal static glGetMapfv pglGetMapfv;

			internal unsafe delegate void glGetMapiv(Int32 target, Int32 query, Int32* v);

			[ThreadStatic]
			internal static glGetMapiv pglGetMapiv;

			internal unsafe delegate void glGetMapxvOES(Int32 target, Int32 query, IntPtr* v);

			[ThreadStatic]
			internal static glGetMapxvOES pglGetMapxvOES;

			internal unsafe delegate void glGetMaterialfv(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMaterialfv pglGetMaterialfv;

			internal unsafe delegate void glGetMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMaterialiv pglGetMaterialiv;

			internal unsafe delegate void glGetMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glGetMaterialxOES pglGetMaterialxOES;

			internal unsafe delegate void glGetMaterialxv(Int32 face, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetMaterialxv pglGetMaterialxv;

			internal unsafe delegate void glGetMaterialxvOES(Int32 face, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetMaterialxvOES pglGetMaterialxvOES;

			internal unsafe delegate void glGetMinmax(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[ThreadStatic]
			internal static glGetMinmax pglGetMinmax;

			internal unsafe delegate void glGetMinmaxEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[ThreadStatic]
			internal static glGetMinmaxEXT pglGetMinmaxEXT;

			internal unsafe delegate void glGetMinmaxParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMinmaxParameterfv pglGetMinmaxParameterfv;

			internal unsafe delegate void glGetMinmaxParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMinmaxParameterfvEXT pglGetMinmaxParameterfvEXT;

			internal unsafe delegate void glGetMinmaxParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMinmaxParameteriv pglGetMinmaxParameteriv;

			internal unsafe delegate void glGetMinmaxParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMinmaxParameterivEXT pglGetMinmaxParameterivEXT;

			internal unsafe delegate void glGetMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexEnvfvEXT pglGetMultiTexEnvfvEXT;

			internal unsafe delegate void glGetMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexEnvivEXT pglGetMultiTexEnvivEXT;

			internal unsafe delegate void glGetMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetMultiTexGendvEXT pglGetMultiTexGendvEXT;

			internal unsafe delegate void glGetMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexGenfvEXT pglGetMultiTexGenfvEXT;

			internal unsafe delegate void glGetMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexGenivEXT pglGetMultiTexGenivEXT;

			internal unsafe delegate void glGetMultiTexImageEXT(Int32 texunit, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetMultiTexImageEXT pglGetMultiTexImageEXT;

			internal unsafe delegate void glGetMultiTexLevelParameterfvEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexLevelParameterfvEXT pglGetMultiTexLevelParameterfvEXT;

			internal unsafe delegate void glGetMultiTexLevelParameterivEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexLevelParameterivEXT pglGetMultiTexLevelParameterivEXT;

			internal unsafe delegate void glGetMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterIivEXT pglGetMultiTexParameterIivEXT;

			internal unsafe delegate void glGetMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterIuivEXT pglGetMultiTexParameterIuivEXT;

			internal unsafe delegate void glGetMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterfvEXT pglGetMultiTexParameterfvEXT;

			internal unsafe delegate void glGetMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterivEXT pglGetMultiTexParameterivEXT;

			internal unsafe delegate void glGetMultisamplefv(Int32 pname, UInt32 index, float* val);

			[AliasOf("glGetMultisamplefv")]
			[AliasOf("glGetMultisamplefvNV")]
			[ThreadStatic]
			internal static glGetMultisamplefv pglGetMultisamplefv;

			internal unsafe delegate void glGetNamedBufferParameteri64v(UInt32 buffer, Int32 pname, Int64* @params);

			[ThreadStatic]
			internal static glGetNamedBufferParameteri64v pglGetNamedBufferParameteri64v;

			internal unsafe delegate void glGetNamedBufferParameteriv(UInt32 buffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedBufferParameteriv pglGetNamedBufferParameteriv;

			internal unsafe delegate void glGetNamedBufferParameterivEXT(UInt32 buffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedBufferParameterivEXT pglGetNamedBufferParameterivEXT;

			internal unsafe delegate void glGetNamedBufferParameterui64vNV(UInt32 buffer, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetNamedBufferParameterui64vNV pglGetNamedBufferParameterui64vNV;

			internal unsafe delegate void glGetNamedBufferPointerv(UInt32 buffer, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetNamedBufferPointerv pglGetNamedBufferPointerv;

			internal unsafe delegate void glGetNamedBufferPointervEXT(UInt32 buffer, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetNamedBufferPointervEXT pglGetNamedBufferPointervEXT;

			internal unsafe delegate void glGetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[ThreadStatic]
			internal static glGetNamedBufferSubData pglGetNamedBufferSubData;

			internal unsafe delegate void glGetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[ThreadStatic]
			internal static glGetNamedBufferSubDataEXT pglGetNamedBufferSubDataEXT;

			internal unsafe delegate void glGetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedFramebufferAttachmentParameteriv pglGetNamedFramebufferAttachmentParameteriv;

			internal unsafe delegate void glGetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedFramebufferAttachmentParameterivEXT pglGetNamedFramebufferAttachmentParameterivEXT;

			internal unsafe delegate void glGetNamedFramebufferParameteriv(UInt32 framebuffer, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetNamedFramebufferParameteriv pglGetNamedFramebufferParameteriv;

			internal unsafe delegate void glGetNamedFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedFramebufferParameterivEXT pglGetNamedFramebufferParameterivEXT;

			internal unsafe delegate void glGetNamedProgramLocalParameterIivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterIivEXT pglGetNamedProgramLocalParameterIivEXT;

			internal unsafe delegate void glGetNamedProgramLocalParameterIuivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterIuivEXT pglGetNamedProgramLocalParameterIuivEXT;

			internal unsafe delegate void glGetNamedProgramLocalParameterdvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterdvEXT pglGetNamedProgramLocalParameterdvEXT;

			internal unsafe delegate void glGetNamedProgramLocalParameterfvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterfvEXT pglGetNamedProgramLocalParameterfvEXT;

			internal unsafe delegate void glGetNamedProgramStringEXT(UInt32 program, Int32 target, Int32 pname, IntPtr @string);

			[ThreadStatic]
			internal static glGetNamedProgramStringEXT pglGetNamedProgramStringEXT;

			internal unsafe delegate void glGetNamedProgramivEXT(UInt32 program, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedProgramivEXT pglGetNamedProgramivEXT;

			internal unsafe delegate void glGetNamedRenderbufferParameteriv(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedRenderbufferParameteriv pglGetNamedRenderbufferParameteriv;

			internal unsafe delegate void glGetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedRenderbufferParameterivEXT pglGetNamedRenderbufferParameterivEXT;

			internal unsafe delegate void glGetNamedStringARB(Int32 namelen, String name, Int32 bufSize, Int32* stringlen, [Out] StringBuilder @string);

			[ThreadStatic]
			internal static glGetNamedStringARB pglGetNamedStringARB;

			internal unsafe delegate void glGetNamedStringivARB(Int32 namelen, String name, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedStringivARB pglGetNamedStringivARB;

			internal unsafe delegate void glGetNextPerfQueryIdINTEL(UInt32 queryId, UInt32* nextQueryId);

			[ThreadStatic]
			internal static glGetNextPerfQueryIdINTEL pglGetNextPerfQueryIdINTEL;

			internal unsafe delegate void glGetObjectBufferfvATI(UInt32 buffer, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetObjectBufferfvATI pglGetObjectBufferfvATI;

			internal unsafe delegate void glGetObjectBufferivATI(UInt32 buffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetObjectBufferivATI pglGetObjectBufferivATI;

			internal unsafe delegate void glGetObjectLabel(Int32 identifier, UInt32 name, Int32 bufSize, Int32* length, [Out] StringBuilder label);

			[AliasOf("glGetObjectLabel")]
			[AliasOf("glGetObjectLabelKHR")]
			[ThreadStatic]
			internal static glGetObjectLabel pglGetObjectLabel;

			internal unsafe delegate void glGetObjectLabelEXT(Int32 type, UInt32 @object, Int32 bufSize, Int32* length, [Out] StringBuilder label);

			[ThreadStatic]
			internal static glGetObjectLabelEXT pglGetObjectLabelEXT;

			internal unsafe delegate void glGetObjectParameterfvARB(UInt32 obj, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetObjectParameterfvARB pglGetObjectParameterfvARB;

			internal unsafe delegate void glGetObjectParameterivAPPLE(Int32 objectType, UInt32 name, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetObjectParameterivAPPLE pglGetObjectParameterivAPPLE;

			internal unsafe delegate void glGetObjectParameterivARB(UInt32 obj, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetObjectParameterivARB pglGetObjectParameterivARB;

			internal unsafe delegate void glGetObjectPtrLabel(IntPtr ptr, Int32 bufSize, Int32* length, [Out] StringBuilder label);

			[AliasOf("glGetObjectPtrLabel")]
			[AliasOf("glGetObjectPtrLabelKHR")]
			[ThreadStatic]
			internal static glGetObjectPtrLabel pglGetObjectPtrLabel;

			internal unsafe delegate void glGetOcclusionQueryivNV(UInt32 id, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetOcclusionQueryivNV pglGetOcclusionQueryivNV;

			internal unsafe delegate void glGetOcclusionQueryuivNV(UInt32 id, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetOcclusionQueryuivNV pglGetOcclusionQueryuivNV;

			internal unsafe delegate void glGetPathColorGenfvNV(Int32 color, Int32 pname, float* value);

			[ThreadStatic]
			internal static glGetPathColorGenfvNV pglGetPathColorGenfvNV;

			internal unsafe delegate void glGetPathColorGenivNV(Int32 color, Int32 pname, Int32* value);

			[ThreadStatic]
			internal static glGetPathColorGenivNV pglGetPathColorGenivNV;

			internal unsafe delegate void glGetPathCommandsNV(UInt32 path, byte* commands);

			[ThreadStatic]
			internal static glGetPathCommandsNV pglGetPathCommandsNV;

			internal unsafe delegate void glGetPathCoordsNV(UInt32 path, float* coords);

			[ThreadStatic]
			internal static glGetPathCoordsNV pglGetPathCoordsNV;

			internal unsafe delegate void glGetPathDashArrayNV(UInt32 path, float* dashArray);

			[ThreadStatic]
			internal static glGetPathDashArrayNV pglGetPathDashArrayNV;

			internal delegate float glGetPathLengthNV(UInt32 path, Int32 startSegment, Int32 numSegments);

			[ThreadStatic]
			internal static glGetPathLengthNV pglGetPathLengthNV;

			internal unsafe delegate void glGetPathMetricRangeNV(UInt32 metricQueryMask, UInt32 firstPathName, Int32 numPaths, Int32 stride, float* metrics);

			[ThreadStatic]
			internal static glGetPathMetricRangeNV pglGetPathMetricRangeNV;

			internal unsafe delegate void glGetPathMetricsNV(UInt32 metricQueryMask, Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 stride, float* metrics);

			[ThreadStatic]
			internal static glGetPathMetricsNV pglGetPathMetricsNV;

			internal unsafe delegate void glGetPathParameterfvNV(UInt32 path, Int32 pname, float* value);

			[ThreadStatic]
			internal static glGetPathParameterfvNV pglGetPathParameterfvNV;

			internal unsafe delegate void glGetPathParameterivNV(UInt32 path, Int32 pname, Int32* value);

			[ThreadStatic]
			internal static glGetPathParameterivNV pglGetPathParameterivNV;

			internal unsafe delegate void glGetPathSpacingNV(Int32 pathListMode, Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, float advanceScale, float kerningScale, Int32 transformType, float* returnedSpacing);

			[ThreadStatic]
			internal static glGetPathSpacingNV pglGetPathSpacingNV;

			internal unsafe delegate void glGetPathTexGenfvNV(Int32 texCoordSet, Int32 pname, float* value);

			[ThreadStatic]
			internal static glGetPathTexGenfvNV pglGetPathTexGenfvNV;

			internal unsafe delegate void glGetPathTexGenivNV(Int32 texCoordSet, Int32 pname, Int32* value);

			[ThreadStatic]
			internal static glGetPathTexGenivNV pglGetPathTexGenivNV;

			internal unsafe delegate void glGetPerfCounterInfoINTEL(UInt32 queryId, UInt32 counterId, UInt32 counterNameLength, String counterName, UInt32 counterDescLength, String counterDesc, UInt32* counterOffset, UInt32* counterDataSize, UInt32* counterTypeEnum, UInt32* counterDataTypeEnum, UInt64* rawCounterMaxValue);

			[ThreadStatic]
			internal static glGetPerfCounterInfoINTEL pglGetPerfCounterInfoINTEL;

			internal unsafe delegate void glGetPerfMonitorCounterDataAMD(UInt32 monitor, Int32 pname, Int32 dataSize, UInt32* data, Int32* bytesWritten);

			[ThreadStatic]
			internal static glGetPerfMonitorCounterDataAMD pglGetPerfMonitorCounterDataAMD;

			internal unsafe delegate void glGetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, IntPtr data);

			[ThreadStatic]
			internal static glGetPerfMonitorCounterInfoAMD pglGetPerfMonitorCounterInfoAMD;

			internal unsafe delegate void glGetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, Int32* length, [Out] StringBuilder counterString);

			[ThreadStatic]
			internal static glGetPerfMonitorCounterStringAMD pglGetPerfMonitorCounterStringAMD;

			internal unsafe delegate void glGetPerfMonitorCountersAMD(UInt32 group, Int32* numCounters, Int32* maxActiveCounters, Int32 counterSize, UInt32* counters);

			[ThreadStatic]
			internal static glGetPerfMonitorCountersAMD pglGetPerfMonitorCountersAMD;

			internal unsafe delegate void glGetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, Int32* length, [Out] StringBuilder groupString);

			[ThreadStatic]
			internal static glGetPerfMonitorGroupStringAMD pglGetPerfMonitorGroupStringAMD;

			internal unsafe delegate void glGetPerfMonitorGroupsAMD(Int32* numGroups, Int32 groupsSize, UInt32* groups);

			[ThreadStatic]
			internal static glGetPerfMonitorGroupsAMD pglGetPerfMonitorGroupsAMD;

			internal unsafe delegate void glGetPerfQueryDataINTEL(UInt32 queryHandle, UInt32 flags, Int32 dataSize, void* data, UInt32* bytesWritten);

			[ThreadStatic]
			internal static glGetPerfQueryDataINTEL pglGetPerfQueryDataINTEL;

			internal unsafe delegate void glGetPerfQueryIdByNameINTEL(String queryName, UInt32* queryId);

			[ThreadStatic]
			internal static glGetPerfQueryIdByNameINTEL pglGetPerfQueryIdByNameINTEL;

			internal unsafe delegate void glGetPerfQueryInfoINTEL(UInt32 queryId, UInt32 queryNameLength, String queryName, UInt32* dataSize, UInt32* noCounters, UInt32* noInstances, UInt32* capsMask);

			[ThreadStatic]
			internal static glGetPerfQueryInfoINTEL pglGetPerfQueryInfoINTEL;

			internal unsafe delegate void glGetPixelMapfv(Int32 map, float* values);

			[ThreadStatic]
			internal static glGetPixelMapfv pglGetPixelMapfv;

			internal unsafe delegate void glGetPixelMapuiv(Int32 map, UInt32* values);

			[ThreadStatic]
			internal static glGetPixelMapuiv pglGetPixelMapuiv;

			internal unsafe delegate void glGetPixelMapusv(Int32 map, UInt16* values);

			[ThreadStatic]
			internal static glGetPixelMapusv pglGetPixelMapusv;

			internal unsafe delegate void glGetPixelMapxv(Int32 map, Int32 size, IntPtr* values);

			[ThreadStatic]
			internal static glGetPixelMapxv pglGetPixelMapxv;

			internal unsafe delegate void glGetPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetPixelTexGenParameterfvSGIS pglGetPixelTexGenParameterfvSGIS;

			internal unsafe delegate void glGetPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetPixelTexGenParameterivSGIS pglGetPixelTexGenParameterivSGIS;

			internal unsafe delegate void glGetPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetPixelTransformParameterfvEXT pglGetPixelTransformParameterfvEXT;

			internal unsafe delegate void glGetPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetPixelTransformParameterivEXT pglGetPixelTransformParameterivEXT;

			internal unsafe delegate void glGetPointerIndexedvEXT(Int32 target, UInt32 index, IntPtr* data);

			[ThreadStatic]
			internal static glGetPointerIndexedvEXT pglGetPointerIndexedvEXT;

			internal unsafe delegate void glGetPointeri_vEXT(Int32 pname, UInt32 index, IntPtr* @params);

			[ThreadStatic]
			internal static glGetPointeri_vEXT pglGetPointeri_vEXT;

			internal unsafe delegate void glGetPointerv(Int32 pname, IntPtr* @params);

			[AliasOf("glGetPointerv")]
			[AliasOf("glGetPointervEXT")]
			[AliasOf("glGetPointervKHR")]
			[ThreadStatic]
			internal static glGetPointerv pglGetPointerv;

			internal unsafe delegate void glGetPolygonStipple(byte* mask);

			[ThreadStatic]
			internal static glGetPolygonStipple pglGetPolygonStipple;

			internal unsafe delegate void glGetProgramBinary(UInt32 program, Int32 bufSize, Int32* length, Int32* binaryFormat, IntPtr binary);

			[AliasOf("glGetProgramBinary")]
			[AliasOf("glGetProgramBinaryOES")]
			[ThreadStatic]
			internal static glGetProgramBinary pglGetProgramBinary;

			internal unsafe delegate void glGetProgramEnvParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramEnvParameterIivNV pglGetProgramEnvParameterIivNV;

			internal unsafe delegate void glGetProgramEnvParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glGetProgramEnvParameterIuivNV pglGetProgramEnvParameterIuivNV;

			internal unsafe delegate void glGetProgramEnvParameterdvARB(Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glGetProgramEnvParameterdvARB pglGetProgramEnvParameterdvARB;

			internal unsafe delegate void glGetProgramEnvParameterfvARB(Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glGetProgramEnvParameterfvARB pglGetProgramEnvParameterfvARB;

			internal unsafe delegate void glGetProgramInfoLog(UInt32 program, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[ThreadStatic]
			internal static glGetProgramInfoLog pglGetProgramInfoLog;

			internal unsafe delegate void glGetProgramInterfaceiv(UInt32 program, Int32 programInterface, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramInterfaceiv pglGetProgramInterfaceiv;

			internal unsafe delegate void glGetProgramLocalParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramLocalParameterIivNV pglGetProgramLocalParameterIivNV;

			internal unsafe delegate void glGetProgramLocalParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glGetProgramLocalParameterIuivNV pglGetProgramLocalParameterIuivNV;

			internal unsafe delegate void glGetProgramLocalParameterdvARB(Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glGetProgramLocalParameterdvARB pglGetProgramLocalParameterdvARB;

			internal unsafe delegate void glGetProgramLocalParameterfvARB(Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glGetProgramLocalParameterfvARB pglGetProgramLocalParameterfvARB;

			internal unsafe delegate void glGetProgramNamedParameterdvNV(UInt32 id, Int32 len, byte* name, double* @params);

			[ThreadStatic]
			internal static glGetProgramNamedParameterdvNV pglGetProgramNamedParameterdvNV;

			internal unsafe delegate void glGetProgramNamedParameterfvNV(UInt32 id, Int32 len, byte* name, float* @params);

			[ThreadStatic]
			internal static glGetProgramNamedParameterfvNV pglGetProgramNamedParameterfvNV;

			internal unsafe delegate void glGetProgramParameterdvNV(Int32 target, UInt32 index, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetProgramParameterdvNV pglGetProgramParameterdvNV;

			internal unsafe delegate void glGetProgramParameterfvNV(Int32 target, UInt32 index, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetProgramParameterfvNV pglGetProgramParameterfvNV;

			internal unsafe delegate void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[ThreadStatic]
			internal static glGetProgramPipelineInfoLog pglGetProgramPipelineInfoLog;

			internal unsafe delegate void glGetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[ThreadStatic]
			internal static glGetProgramPipelineInfoLogEXT pglGetProgramPipelineInfoLogEXT;

			internal unsafe delegate void glGetProgramPipelineiv(UInt32 pipeline, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramPipelineiv pglGetProgramPipelineiv;

			internal unsafe delegate void glGetProgramPipelineivEXT(UInt32 pipeline, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramPipelineivEXT pglGetProgramPipelineivEXT;

			internal delegate UInt32 glGetProgramResourceIndex(UInt32 program, Int32 programInterface, String name);

			[ThreadStatic]
			internal static glGetProgramResourceIndex pglGetProgramResourceIndex;

			internal delegate Int32 glGetProgramResourceLocation(UInt32 program, Int32 programInterface, String name);

			[ThreadStatic]
			internal static glGetProgramResourceLocation pglGetProgramResourceLocation;

			internal delegate Int32 glGetProgramResourceLocationIndex(UInt32 program, Int32 programInterface, String name);

			[ThreadStatic]
			internal static glGetProgramResourceLocationIndex pglGetProgramResourceLocationIndex;

			internal delegate Int32 glGetProgramResourceLocationIndexEXT(UInt32 program, Int32 programInterface, String name);

			[ThreadStatic]
			internal static glGetProgramResourceLocationIndexEXT pglGetProgramResourceLocationIndexEXT;

			internal unsafe delegate void glGetProgramResourceName(UInt32 program, Int32 programInterface, UInt32 index, Int32 bufSize, Int32* length, [Out] StringBuilder name);

			[ThreadStatic]
			internal static glGetProgramResourceName pglGetProgramResourceName;

			internal unsafe delegate void glGetProgramResourcefvNV(UInt32 program, Int32 programInterface, UInt32 index, Int32 propCount, Int32* props, Int32 bufSize, Int32* length, float* @params);

			[ThreadStatic]
			internal static glGetProgramResourcefvNV pglGetProgramResourcefvNV;

			internal unsafe delegate void glGetProgramResourceiv(UInt32 program, Int32 programInterface, UInt32 index, Int32 propCount, Int32* props, Int32 bufSize, Int32* length, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramResourceiv pglGetProgramResourceiv;

			internal unsafe delegate void glGetProgramStageiv(UInt32 program, Int32 shadertype, Int32 pname, Int32* values);

			[ThreadStatic]
			internal static glGetProgramStageiv pglGetProgramStageiv;

			internal unsafe delegate void glGetProgramStringARB(Int32 target, Int32 pname, IntPtr @string);

			[ThreadStatic]
			internal static glGetProgramStringARB pglGetProgramStringARB;

			internal unsafe delegate void glGetProgramStringNV(UInt32 id, Int32 pname, byte* program);

			[ThreadStatic]
			internal static glGetProgramStringNV pglGetProgramStringNV;

			internal unsafe delegate void glGetProgramSubroutineParameteruivNV(Int32 target, UInt32 index, UInt32* param);

			[ThreadStatic]
			internal static glGetProgramSubroutineParameteruivNV pglGetProgramSubroutineParameteruivNV;

			internal unsafe delegate void glGetProgramiv(UInt32 program, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramiv pglGetProgramiv;

			internal unsafe delegate void glGetProgramivARB(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramivARB pglGetProgramivARB;

			internal unsafe delegate void glGetProgramivNV(UInt32 id, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramivNV pglGetProgramivNV;

			internal unsafe delegate void glGetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[ThreadStatic]
			internal static glGetQueryBufferObjecti64v pglGetQueryBufferObjecti64v;

			internal unsafe delegate void glGetQueryBufferObjectiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[ThreadStatic]
			internal static glGetQueryBufferObjectiv pglGetQueryBufferObjectiv;

			internal unsafe delegate void glGetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[ThreadStatic]
			internal static glGetQueryBufferObjectui64v pglGetQueryBufferObjectui64v;

			internal unsafe delegate void glGetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[ThreadStatic]
			internal static glGetQueryBufferObjectuiv pglGetQueryBufferObjectuiv;

			internal unsafe delegate void glGetQueryIndexediv(Int32 target, UInt32 index, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetQueryIndexediv pglGetQueryIndexediv;

			internal unsafe delegate void glGetQueryObjecti64v(UInt32 id, Int32 pname, Int64* @params);

			[AliasOf("glGetQueryObjecti64v")]
			[AliasOf("glGetQueryObjecti64vEXT")]
			[ThreadStatic]
			internal static glGetQueryObjecti64v pglGetQueryObjecti64v;

			internal unsafe delegate void glGetQueryObjectiv(UInt32 id, Int32 pname, Int32* @params);

			[AliasOf("glGetQueryObjectiv")]
			[AliasOf("glGetQueryObjectivARB")]
			[AliasOf("glGetQueryObjectivEXT")]
			[ThreadStatic]
			internal static glGetQueryObjectiv pglGetQueryObjectiv;

			internal unsafe delegate void glGetQueryObjectui64v(UInt32 id, Int32 pname, UInt64* @params);

			[AliasOf("glGetQueryObjectui64v")]
			[AliasOf("glGetQueryObjectui64vEXT")]
			[ThreadStatic]
			internal static glGetQueryObjectui64v pglGetQueryObjectui64v;

			internal unsafe delegate void glGetQueryObjectuiv(UInt32 id, Int32 pname, UInt32* @params);

			[AliasOf("glGetQueryObjectuiv")]
			[AliasOf("glGetQueryObjectuivARB")]
			[ThreadStatic]
			internal static glGetQueryObjectuiv pglGetQueryObjectuiv;

			internal unsafe delegate void glGetQueryObjectuivEXT(UInt32 id, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetQueryObjectuivEXT pglGetQueryObjectuivEXT;

			internal unsafe delegate void glGetQueryiv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glGetQueryiv")]
			[AliasOf("glGetQueryivARB")]
			[ThreadStatic]
			internal static glGetQueryiv pglGetQueryiv;

			internal unsafe delegate void glGetQueryivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetQueryivEXT pglGetQueryivEXT;

			internal unsafe delegate void glGetRenderbufferParameteriv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glGetRenderbufferParameteriv")]
			[AliasOf("glGetRenderbufferParameterivEXT")]
			[ThreadStatic]
			internal static glGetRenderbufferParameteriv pglGetRenderbufferParameteriv;

			internal unsafe delegate void glGetRenderbufferParameterivOES(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetRenderbufferParameterivOES pglGetRenderbufferParameterivOES;

			internal unsafe delegate void glGetSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* @params);

			[AliasOf("glGetSamplerParameterIiv")]
			[AliasOf("glGetSamplerParameterIivEXT")]
			[AliasOf("glGetSamplerParameterIivOES")]
			[ThreadStatic]
			internal static glGetSamplerParameterIiv pglGetSamplerParameterIiv;

			internal unsafe delegate void glGetSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* @params);

			[AliasOf("glGetSamplerParameterIuiv")]
			[AliasOf("glGetSamplerParameterIuivEXT")]
			[AliasOf("glGetSamplerParameterIuivOES")]
			[ThreadStatic]
			internal static glGetSamplerParameterIuiv pglGetSamplerParameterIuiv;

			internal unsafe delegate void glGetSamplerParameterfv(UInt32 sampler, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetSamplerParameterfv pglGetSamplerParameterfv;

			internal unsafe delegate void glGetSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetSamplerParameteriv pglGetSamplerParameteriv;

			internal unsafe delegate void glGetSeparableFilter(Int32 target, Int32 format, Int32 type, IntPtr row, IntPtr column, IntPtr span);

			[ThreadStatic]
			internal static glGetSeparableFilter pglGetSeparableFilter;

			internal unsafe delegate void glGetSeparableFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr row, IntPtr column, IntPtr span);

			[ThreadStatic]
			internal static glGetSeparableFilterEXT pglGetSeparableFilterEXT;

			internal unsafe delegate void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[ThreadStatic]
			internal static glGetShaderInfoLog pglGetShaderInfoLog;

			internal unsafe delegate void glGetShaderPrecisionFormat(Int32 shadertype, Int32 precisiontype, Int32* range, Int32* precision);

			[ThreadStatic]
			internal static glGetShaderPrecisionFormat pglGetShaderPrecisionFormat;

			internal unsafe delegate void glGetShaderSource(UInt32 shader, Int32 bufSize, Int32* length, [Out] StringBuilder source);

			[AliasOf("glGetShaderSource")]
			[AliasOf("glGetShaderSourceARB")]
			[ThreadStatic]
			internal static glGetShaderSource pglGetShaderSource;

			internal unsafe delegate void glGetShaderiv(UInt32 shader, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetShaderiv pglGetShaderiv;

			internal unsafe delegate void glGetSharpenTexFuncSGIS(Int32 target, float* points);

			[ThreadStatic]
			internal static glGetSharpenTexFuncSGIS pglGetSharpenTexFuncSGIS;

			internal delegate UInt16 glGetStageIndexNV(Int32 shadertype);

			[ThreadStatic]
			internal static glGetStageIndexNV pglGetStageIndexNV;

			internal delegate IntPtr glGetString(Int32 name);

			[ThreadStatic]
			internal static glGetString pglGetString;

			internal delegate IntPtr glGetStringi(Int32 name, UInt32 index);

			[ThreadStatic]
			internal static glGetStringi pglGetStringi;

			internal delegate UInt32 glGetSubroutineIndex(UInt32 program, Int32 shadertype, String name);

			[ThreadStatic]
			internal static glGetSubroutineIndex pglGetSubroutineIndex;

			internal delegate Int32 glGetSubroutineUniformLocation(UInt32 program, Int32 shadertype, String name);

			[ThreadStatic]
			internal static glGetSubroutineUniformLocation pglGetSubroutineUniformLocation;

			internal unsafe delegate void glGetSynciv(Int32 sync, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[AliasOf("glGetSynciv")]
			[AliasOf("glGetSyncivAPPLE")]
			[ThreadStatic]
			internal static glGetSynciv pglGetSynciv;

			internal unsafe delegate void glGetTexBumpParameterfvATI(Int32 pname, float* param);

			[ThreadStatic]
			internal static glGetTexBumpParameterfvATI pglGetTexBumpParameterfvATI;

			internal unsafe delegate void glGetTexBumpParameterivATI(Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetTexBumpParameterivATI pglGetTexBumpParameterivATI;

			internal unsafe delegate void glGetTexEnvfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexEnvfv pglGetTexEnvfv;

			internal unsafe delegate void glGetTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexEnviv pglGetTexEnviv;

			internal unsafe delegate void glGetTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexEnvxv pglGetTexEnvxv;

			internal unsafe delegate void glGetTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexEnvxvOES pglGetTexEnvxvOES;

			internal unsafe delegate void glGetTexFilterFuncSGIS(Int32 target, Int32 filter, float* weights);

			[ThreadStatic]
			internal static glGetTexFilterFuncSGIS pglGetTexFilterFuncSGIS;

			internal unsafe delegate void glGetTexGendv(Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetTexGendv pglGetTexGendv;

			internal unsafe delegate void glGetTexGenfv(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexGenfv pglGetTexGenfv;

			internal unsafe delegate void glGetTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexGenfvOES pglGetTexGenfvOES;

			internal unsafe delegate void glGetTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexGeniv pglGetTexGeniv;

			internal unsafe delegate void glGetTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexGenivOES pglGetTexGenivOES;

			internal unsafe delegate void glGetTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexGenxvOES pglGetTexGenxvOES;

			internal unsafe delegate void glGetTexImage(Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTexImage pglGetTexImage;

			internal unsafe delegate void glGetTexLevelParameterfv(Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameterfv pglGetTexLevelParameterfv;

			internal unsafe delegate void glGetTexLevelParameteriv(Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameteriv pglGetTexLevelParameteriv;

			internal unsafe delegate void glGetTexLevelParameterxvOES(Int32 target, Int32 level, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameterxvOES pglGetTexLevelParameterxvOES;

			internal unsafe delegate void glGetTexParameterIiv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glGetTexParameterIiv")]
			[AliasOf("glGetTexParameterIivEXT")]
			[AliasOf("glGetTexParameterIivOES")]
			[ThreadStatic]
			internal static glGetTexParameterIiv pglGetTexParameterIiv;

			internal unsafe delegate void glGetTexParameterIuiv(Int32 target, Int32 pname, UInt32* @params);

			[AliasOf("glGetTexParameterIuiv")]
			[AliasOf("glGetTexParameterIuivEXT")]
			[AliasOf("glGetTexParameterIuivOES")]
			[ThreadStatic]
			internal static glGetTexParameterIuiv pglGetTexParameterIuiv;

			internal unsafe delegate void glGetTexParameterPointervAPPLE(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexParameterPointervAPPLE pglGetTexParameterPointervAPPLE;

			internal unsafe delegate void glGetTexParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexParameterfv pglGetTexParameterfv;

			internal unsafe delegate void glGetTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexParameteriv pglGetTexParameteriv;

			internal unsafe delegate void glGetTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexParameterxv pglGetTexParameterxv;

			internal unsafe delegate void glGetTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexParameterxvOES pglGetTexParameterxvOES;

			internal delegate UInt64 glGetTextureHandleARB(UInt32 texture);

			[ThreadStatic]
			internal static glGetTextureHandleARB pglGetTextureHandleARB;

			internal delegate UInt64 glGetTextureHandleNV(UInt32 texture);

			[ThreadStatic]
			internal static glGetTextureHandleNV pglGetTextureHandleNV;

			internal unsafe delegate void glGetTextureImage(UInt32 texture, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTextureImage pglGetTextureImage;

			internal unsafe delegate void glGetTextureImageEXT(UInt32 texture, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTextureImageEXT pglGetTextureImageEXT;

			internal unsafe delegate void glGetTextureLevelParameterfv(UInt32 texture, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTextureLevelParameterfv pglGetTextureLevelParameterfv;

			internal unsafe delegate void glGetTextureLevelParameterfvEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTextureLevelParameterfvEXT pglGetTextureLevelParameterfvEXT;

			internal unsafe delegate void glGetTextureLevelParameteriv(UInt32 texture, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureLevelParameteriv pglGetTextureLevelParameteriv;

			internal unsafe delegate void glGetTextureLevelParameterivEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureLevelParameterivEXT pglGetTextureLevelParameterivEXT;

			internal unsafe delegate void glGetTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterIiv pglGetTextureParameterIiv;

			internal unsafe delegate void glGetTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterIivEXT pglGetTextureParameterIivEXT;

			internal unsafe delegate void glGetTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterIuiv pglGetTextureParameterIuiv;

			internal unsafe delegate void glGetTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterIuivEXT pglGetTextureParameterIuivEXT;

			internal unsafe delegate void glGetTextureParameterfv(UInt32 texture, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTextureParameterfv pglGetTextureParameterfv;

			internal unsafe delegate void glGetTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTextureParameterfvEXT pglGetTextureParameterfvEXT;

			internal unsafe delegate void glGetTextureParameteriv(UInt32 texture, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureParameteriv pglGetTextureParameteriv;

			internal unsafe delegate void glGetTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterivEXT pglGetTextureParameterivEXT;

			internal delegate UInt64 glGetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);

			[ThreadStatic]
			internal static glGetTextureSamplerHandleARB pglGetTextureSamplerHandleARB;

			internal delegate UInt64 glGetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler);

			[ThreadStatic]
			internal static glGetTextureSamplerHandleNV pglGetTextureSamplerHandleNV;

			internal unsafe delegate void glGetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTextureSubImage pglGetTextureSubImage;

			internal unsafe delegate void glGetTrackMatrixivNV(Int32 target, UInt32 address, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTrackMatrixivNV pglGetTrackMatrixivNV;

			internal unsafe delegate void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[AliasOf("glGetTransformFeedbackVarying")]
			[AliasOf("glGetTransformFeedbackVaryingEXT")]
			[ThreadStatic]
			internal static glGetTransformFeedbackVarying pglGetTransformFeedbackVarying;

			internal unsafe delegate void glGetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, Int32* location);

			[ThreadStatic]
			internal static glGetTransformFeedbackVaryingNV pglGetTransformFeedbackVaryingNV;

			internal unsafe delegate void glGetTransformFeedbacki64_v(UInt32 xfb, Int32 pname, UInt32 index, Int64* param);

			[ThreadStatic]
			internal static glGetTransformFeedbacki64_v pglGetTransformFeedbacki64_v;

			internal unsafe delegate void glGetTransformFeedbacki_v(UInt32 xfb, Int32 pname, UInt32 index, Int32* param);

			[ThreadStatic]
			internal static glGetTransformFeedbacki_v pglGetTransformFeedbacki_v;

			internal unsafe delegate void glGetTransformFeedbackiv(UInt32 xfb, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetTransformFeedbackiv pglGetTransformFeedbackiv;

			internal unsafe delegate void glGetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, Int32* length, String source);

			[ThreadStatic]
			internal static glGetTranslatedShaderSourceANGLE pglGetTranslatedShaderSourceANGLE;

			internal delegate UInt32 glGetUniformBlockIndex(UInt32 program, String uniformBlockName);

			[ThreadStatic]
			internal static glGetUniformBlockIndex pglGetUniformBlockIndex;

			internal delegate Int32 glGetUniformBufferSizeEXT(UInt32 program, Int32 location);

			[ThreadStatic]
			internal static glGetUniformBufferSizeEXT pglGetUniformBufferSizeEXT;

			internal unsafe delegate void glGetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, UInt32* uniformIndices);

			[ThreadStatic]
			internal static glGetUniformIndices pglGetUniformIndices;

			internal delegate Int32 glGetUniformLocation(UInt32 program, String name);

			[AliasOf("glGetUniformLocation")]
			[AliasOf("glGetUniformLocationARB")]
			[ThreadStatic]
			internal static glGetUniformLocation pglGetUniformLocation;

			internal delegate IntPtr glGetUniformOffsetEXT(UInt32 program, Int32 location);

			[ThreadStatic]
			internal static glGetUniformOffsetEXT pglGetUniformOffsetEXT;

			internal unsafe delegate void glGetUniformSubroutineuiv(Int32 shadertype, Int32 location, UInt32* @params);

			[ThreadStatic]
			internal static glGetUniformSubroutineuiv pglGetUniformSubroutineuiv;

			internal unsafe delegate void glGetUniformdv(UInt32 program, Int32 location, double* @params);

			[ThreadStatic]
			internal static glGetUniformdv pglGetUniformdv;

			internal unsafe delegate void glGetUniformfv(UInt32 program, Int32 location, float* @params);

			[AliasOf("glGetUniformfv")]
			[AliasOf("glGetUniformfvARB")]
			[ThreadStatic]
			internal static glGetUniformfv pglGetUniformfv;

			internal unsafe delegate void glGetUniformi64vARB(UInt32 program, Int32 location, Int64* @params);

			[ThreadStatic]
			internal static glGetUniformi64vARB pglGetUniformi64vARB;

			internal unsafe delegate void glGetUniformi64vNV(UInt32 program, Int32 location, Int64* @params);

			[ThreadStatic]
			internal static glGetUniformi64vNV pglGetUniformi64vNV;

			internal unsafe delegate void glGetUniformiv(UInt32 program, Int32 location, Int32* @params);

			[AliasOf("glGetUniformiv")]
			[AliasOf("glGetUniformivARB")]
			[ThreadStatic]
			internal static glGetUniformiv pglGetUniformiv;

			internal unsafe delegate void glGetUniformui64vARB(UInt32 program, Int32 location, UInt64* @params);

			[ThreadStatic]
			internal static glGetUniformui64vARB pglGetUniformui64vARB;

			internal unsafe delegate void glGetUniformui64vNV(UInt32 program, Int32 location, UInt64* @params);

			[ThreadStatic]
			internal static glGetUniformui64vNV pglGetUniformui64vNV;

			internal unsafe delegate void glGetUniformuiv(UInt32 program, Int32 location, UInt32* @params);

			[AliasOf("glGetUniformuiv")]
			[AliasOf("glGetUniformuivEXT")]
			[ThreadStatic]
			internal static glGetUniformuiv pglGetUniformuiv;

			internal unsafe delegate void glGetVariantArrayObjectfvATI(UInt32 id, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetVariantArrayObjectfvATI pglGetVariantArrayObjectfvATI;

			internal unsafe delegate void glGetVariantArrayObjectivATI(UInt32 id, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetVariantArrayObjectivATI pglGetVariantArrayObjectivATI;

			internal unsafe delegate void glGetVariantBooleanvEXT(UInt32 id, Int32 value, bool* data);

			[ThreadStatic]
			internal static glGetVariantBooleanvEXT pglGetVariantBooleanvEXT;

			internal unsafe delegate void glGetVariantFloatvEXT(UInt32 id, Int32 value, float* data);

			[ThreadStatic]
			internal static glGetVariantFloatvEXT pglGetVariantFloatvEXT;

			internal unsafe delegate void glGetVariantIntegervEXT(UInt32 id, Int32 value, Int32* data);

			[ThreadStatic]
			internal static glGetVariantIntegervEXT pglGetVariantIntegervEXT;

			internal unsafe delegate void glGetVariantPointervEXT(UInt32 id, Int32 value, IntPtr* data);

			[ThreadStatic]
			internal static glGetVariantPointervEXT pglGetVariantPointervEXT;

			internal delegate Int32 glGetVaryingLocationNV(UInt32 program, String name);

			[ThreadStatic]
			internal static glGetVaryingLocationNV pglGetVaryingLocationNV;

			internal unsafe delegate void glGetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, Int32 pname, Int64* param);

			[ThreadStatic]
			internal static glGetVertexArrayIndexed64iv pglGetVertexArrayIndexed64iv;

			internal unsafe delegate void glGetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetVertexArrayIndexediv pglGetVertexArrayIndexediv;

			internal unsafe delegate void glGetVertexArrayIntegeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetVertexArrayIntegeri_vEXT pglGetVertexArrayIntegeri_vEXT;

			internal unsafe delegate void glGetVertexArrayIntegervEXT(UInt32 vaobj, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetVertexArrayIntegervEXT pglGetVertexArrayIntegervEXT;

			internal unsafe delegate void glGetVertexArrayPointeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glGetVertexArrayPointeri_vEXT pglGetVertexArrayPointeri_vEXT;

			internal unsafe delegate void glGetVertexArrayPointervEXT(UInt32 vaobj, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glGetVertexArrayPointervEXT pglGetVertexArrayPointervEXT;

			internal unsafe delegate void glGetVertexArrayiv(UInt32 vaobj, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetVertexArrayiv pglGetVertexArrayiv;

			internal unsafe delegate void glGetVertexAttribArrayObjectfvATI(UInt32 index, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectfvATI pglGetVertexAttribArrayObjectfvATI;

			internal unsafe delegate void glGetVertexAttribArrayObjectivATI(UInt32 index, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectivATI pglGetVertexAttribArrayObjectivATI;

			internal unsafe delegate void glGetVertexAttribIiv(UInt32 index, Int32 pname, Int32* @params);

			[AliasOf("glGetVertexAttribIiv")]
			[AliasOf("glGetVertexAttribIivEXT")]
			[ThreadStatic]
			internal static glGetVertexAttribIiv pglGetVertexAttribIiv;

			internal unsafe delegate void glGetVertexAttribIuiv(UInt32 index, Int32 pname, UInt32* @params);

			[AliasOf("glGetVertexAttribIuiv")]
			[AliasOf("glGetVertexAttribIuivEXT")]
			[ThreadStatic]
			internal static glGetVertexAttribIuiv pglGetVertexAttribIuiv;

			internal unsafe delegate void glGetVertexAttribLdv(UInt32 index, Int32 pname, double* @params);

			[AliasOf("glGetVertexAttribLdv")]
			[AliasOf("glGetVertexAttribLdvEXT")]
			[ThreadStatic]
			internal static glGetVertexAttribLdv pglGetVertexAttribLdv;

			internal unsafe delegate void glGetVertexAttribLi64vNV(UInt32 index, Int32 pname, Int64* @params);

			[ThreadStatic]
			internal static glGetVertexAttribLi64vNV pglGetVertexAttribLi64vNV;

			internal unsafe delegate void glGetVertexAttribLui64vARB(UInt32 index, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetVertexAttribLui64vARB pglGetVertexAttribLui64vARB;

			internal unsafe delegate void glGetVertexAttribLui64vNV(UInt32 index, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetVertexAttribLui64vNV pglGetVertexAttribLui64vNV;

			internal unsafe delegate void glGetVertexAttribPointerv(UInt32 index, Int32 pname, IntPtr* pointer);

			[AliasOf("glGetVertexAttribPointerv")]
			[AliasOf("glGetVertexAttribPointervARB")]
			[AliasOf("glGetVertexAttribPointervNV")]
			[ThreadStatic]
			internal static glGetVertexAttribPointerv pglGetVertexAttribPointerv;

			internal unsafe delegate void glGetVertexAttribdv(UInt32 index, Int32 pname, double* @params);

			[AliasOf("glGetVertexAttribdv")]
			[AliasOf("glGetVertexAttribdvARB")]
			[AliasOf("glGetVertexAttribdvNV")]
			[ThreadStatic]
			internal static glGetVertexAttribdv pglGetVertexAttribdv;

			internal unsafe delegate void glGetVertexAttribfv(UInt32 index, Int32 pname, float* @params);

			[AliasOf("glGetVertexAttribfv")]
			[AliasOf("glGetVertexAttribfvARB")]
			[AliasOf("glGetVertexAttribfvNV")]
			[ThreadStatic]
			internal static glGetVertexAttribfv pglGetVertexAttribfv;

			internal unsafe delegate void glGetVertexAttribiv(UInt32 index, Int32 pname, Int32* @params);

			[AliasOf("glGetVertexAttribiv")]
			[AliasOf("glGetVertexAttribivARB")]
			[AliasOf("glGetVertexAttribivNV")]
			[ThreadStatic]
			internal static glGetVertexAttribiv pglGetVertexAttribiv;

			internal unsafe delegate void glGetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetVideoCaptureStreamdvNV pglGetVideoCaptureStreamdvNV;

			internal unsafe delegate void glGetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetVideoCaptureStreamfvNV pglGetVideoCaptureStreamfvNV;

			internal unsafe delegate void glGetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetVideoCaptureStreamivNV pglGetVideoCaptureStreamivNV;

			internal unsafe delegate void glGetVideoCaptureivNV(UInt32 video_capture_slot, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetVideoCaptureivNV pglGetVideoCaptureivNV;

			internal unsafe delegate void glGetVideoi64vNV(UInt32 video_slot, Int32 pname, Int64* @params);

			[ThreadStatic]
			internal static glGetVideoi64vNV pglGetVideoi64vNV;

			internal unsafe delegate void glGetVideoivNV(UInt32 video_slot, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetVideoivNV pglGetVideoivNV;

			internal unsafe delegate void glGetVideoui64vNV(UInt32 video_slot, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetVideoui64vNV pglGetVideoui64vNV;

			internal unsafe delegate void glGetVideouivNV(UInt32 video_slot, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetVideouivNV pglGetVideouivNV;

			internal unsafe delegate void glGetnColorTable(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[ThreadStatic]
			internal static glGetnColorTable pglGetnColorTable;

			internal unsafe delegate void glGetnColorTableARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[ThreadStatic]
			internal static glGetnColorTableARB pglGetnColorTableARB;

			internal unsafe delegate void glGetnCompressedTexImage(Int32 target, Int32 lod, Int32 bufSize, IntPtr pixels);

			[ThreadStatic]
			internal static glGetnCompressedTexImage pglGetnCompressedTexImage;

			internal unsafe delegate void glGetnCompressedTexImageARB(Int32 target, Int32 lod, Int32 bufSize, IntPtr img);

			[ThreadStatic]
			internal static glGetnCompressedTexImageARB pglGetnCompressedTexImageARB;

			internal unsafe delegate void glGetnConvolutionFilter(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[ThreadStatic]
			internal static glGetnConvolutionFilter pglGetnConvolutionFilter;

			internal unsafe delegate void glGetnConvolutionFilterARB(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[ThreadStatic]
			internal static glGetnConvolutionFilterARB pglGetnConvolutionFilterARB;

			internal unsafe delegate void glGetnHistogram(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[ThreadStatic]
			internal static glGetnHistogram pglGetnHistogram;

			internal unsafe delegate void glGetnHistogramARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[ThreadStatic]
			internal static glGetnHistogramARB pglGetnHistogramARB;

			internal unsafe delegate void glGetnMapdv(Int32 target, Int32 query, Int32 bufSize, double* v);

			[ThreadStatic]
			internal static glGetnMapdv pglGetnMapdv;

			internal unsafe delegate void glGetnMapdvARB(Int32 target, Int32 query, Int32 bufSize, double* v);

			[ThreadStatic]
			internal static glGetnMapdvARB pglGetnMapdvARB;

			internal unsafe delegate void glGetnMapfv(Int32 target, Int32 query, Int32 bufSize, float* v);

			[ThreadStatic]
			internal static glGetnMapfv pglGetnMapfv;

			internal unsafe delegate void glGetnMapfvARB(Int32 target, Int32 query, Int32 bufSize, float* v);

			[ThreadStatic]
			internal static glGetnMapfvARB pglGetnMapfvARB;

			internal unsafe delegate void glGetnMapiv(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[ThreadStatic]
			internal static glGetnMapiv pglGetnMapiv;

			internal unsafe delegate void glGetnMapivARB(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[ThreadStatic]
			internal static glGetnMapivARB pglGetnMapivARB;

			internal unsafe delegate void glGetnMinmax(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[ThreadStatic]
			internal static glGetnMinmax pglGetnMinmax;

			internal unsafe delegate void glGetnMinmaxARB(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[ThreadStatic]
			internal static glGetnMinmaxARB pglGetnMinmaxARB;

			internal unsafe delegate void glGetnPixelMapfv(Int32 map, Int32 bufSize, float* values);

			[ThreadStatic]
			internal static glGetnPixelMapfv pglGetnPixelMapfv;

			internal unsafe delegate void glGetnPixelMapfvARB(Int32 map, Int32 bufSize, float* values);

			[ThreadStatic]
			internal static glGetnPixelMapfvARB pglGetnPixelMapfvARB;

			internal unsafe delegate void glGetnPixelMapuiv(Int32 map, Int32 bufSize, UInt32* values);

			[ThreadStatic]
			internal static glGetnPixelMapuiv pglGetnPixelMapuiv;

			internal unsafe delegate void glGetnPixelMapuivARB(Int32 map, Int32 bufSize, UInt32* values);

			[ThreadStatic]
			internal static glGetnPixelMapuivARB pglGetnPixelMapuivARB;

			internal unsafe delegate void glGetnPixelMapusv(Int32 map, Int32 bufSize, UInt16* values);

			[ThreadStatic]
			internal static glGetnPixelMapusv pglGetnPixelMapusv;

			internal unsafe delegate void glGetnPixelMapusvARB(Int32 map, Int32 bufSize, UInt16* values);

			[ThreadStatic]
			internal static glGetnPixelMapusvARB pglGetnPixelMapusvARB;

			internal unsafe delegate void glGetnPolygonStipple(Int32 bufSize, byte* pattern);

			[ThreadStatic]
			internal static glGetnPolygonStipple pglGetnPolygonStipple;

			internal unsafe delegate void glGetnPolygonStippleARB(Int32 bufSize, byte* pattern);

			[ThreadStatic]
			internal static glGetnPolygonStippleARB pglGetnPolygonStippleARB;

			internal unsafe delegate void glGetnSeparableFilter(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[ThreadStatic]
			internal static glGetnSeparableFilter pglGetnSeparableFilter;

			internal unsafe delegate void glGetnSeparableFilterARB(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[ThreadStatic]
			internal static glGetnSeparableFilterARB pglGetnSeparableFilterARB;

			internal unsafe delegate void glGetnTexImage(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[ThreadStatic]
			internal static glGetnTexImage pglGetnTexImage;

			internal unsafe delegate void glGetnTexImageARB(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr img);

			[ThreadStatic]
			internal static glGetnTexImageARB pglGetnTexImageARB;

			internal unsafe delegate void glGetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[ThreadStatic]
			internal static glGetnUniformdv pglGetnUniformdv;

			internal unsafe delegate void glGetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[ThreadStatic]
			internal static glGetnUniformdvARB pglGetnUniformdvARB;

			internal unsafe delegate void glGetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[AliasOf("glGetnUniformfv")]
			[AliasOf("glGetnUniformfvKHR")]
			[ThreadStatic]
			internal static glGetnUniformfv pglGetnUniformfv;

			internal unsafe delegate void glGetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[ThreadStatic]
			internal static glGetnUniformfvARB pglGetnUniformfvARB;

			internal unsafe delegate void glGetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[ThreadStatic]
			internal static glGetnUniformfvEXT pglGetnUniformfvEXT;

			internal unsafe delegate void glGetnUniformi64vARB(UInt32 program, Int32 location, Int32 bufSize, Int64* @params);

			[ThreadStatic]
			internal static glGetnUniformi64vARB pglGetnUniformi64vARB;

			internal unsafe delegate void glGetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[AliasOf("glGetnUniformiv")]
			[AliasOf("glGetnUniformivKHR")]
			[ThreadStatic]
			internal static glGetnUniformiv pglGetnUniformiv;

			internal unsafe delegate void glGetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetnUniformivARB pglGetnUniformivARB;

			internal unsafe delegate void glGetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetnUniformivEXT pglGetnUniformivEXT;

			internal unsafe delegate void glGetnUniformui64vARB(UInt32 program, Int32 location, Int32 bufSize, UInt64* @params);

			[ThreadStatic]
			internal static glGetnUniformui64vARB pglGetnUniformui64vARB;

			internal unsafe delegate void glGetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[AliasOf("glGetnUniformuiv")]
			[AliasOf("glGetnUniformuivKHR")]
			[ThreadStatic]
			internal static glGetnUniformuiv pglGetnUniformuiv;

			internal unsafe delegate void glGetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[ThreadStatic]
			internal static glGetnUniformuivARB pglGetnUniformuivARB;

			internal delegate void glGlobalAlphaFactorbSUN(sbyte factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorbSUN pglGlobalAlphaFactorbSUN;

			internal delegate void glGlobalAlphaFactordSUN(double factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactordSUN pglGlobalAlphaFactordSUN;

			internal delegate void glGlobalAlphaFactorfSUN(float factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorfSUN pglGlobalAlphaFactorfSUN;

			internal delegate void glGlobalAlphaFactoriSUN(Int32 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactoriSUN pglGlobalAlphaFactoriSUN;

			internal delegate void glGlobalAlphaFactorsSUN(Int16 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorsSUN pglGlobalAlphaFactorsSUN;

			internal delegate void glGlobalAlphaFactorubSUN(byte factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorubSUN pglGlobalAlphaFactorubSUN;

			internal delegate void glGlobalAlphaFactoruiSUN(UInt32 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactoruiSUN pglGlobalAlphaFactoruiSUN;

			internal delegate void glGlobalAlphaFactorusSUN(UInt16 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorusSUN pglGlobalAlphaFactorusSUN;

			internal delegate void glHint(Int32 target, Int32 mode);

			[ThreadStatic]
			internal static glHint pglHint;

			internal delegate void glHintPGI(Int32 target, Int32 mode);

			[ThreadStatic]
			internal static glHintPGI pglHintPGI;

			internal delegate void glHistogram(Int32 target, Int32 width, Int32 internalformat, bool sink);

			[AliasOf("glHistogram")]
			[AliasOf("glHistogramEXT")]
			[ThreadStatic]
			internal static glHistogram pglHistogram;

			internal unsafe delegate void glIglooInterfaceSGIX(Int32 pname, IntPtr @params);

			[ThreadStatic]
			internal static glIglooInterfaceSGIX pglIglooInterfaceSGIX;

			internal delegate void glImageTransformParameterfHP(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glImageTransformParameterfHP pglImageTransformParameterfHP;

			internal unsafe delegate void glImageTransformParameterfvHP(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glImageTransformParameterfvHP pglImageTransformParameterfvHP;

			internal delegate void glImageTransformParameteriHP(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glImageTransformParameteriHP pglImageTransformParameteriHP;

			internal unsafe delegate void glImageTransformParameterivHP(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glImageTransformParameterivHP pglImageTransformParameterivHP;

			internal unsafe delegate Int32 glImportSyncEXT(Int32 external_sync_type, IntPtr external_sync, UInt32 flags);

			[ThreadStatic]
			internal static glImportSyncEXT pglImportSyncEXT;

			internal delegate void glIndexFormatNV(Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glIndexFormatNV pglIndexFormatNV;

			internal delegate void glIndexFuncEXT(Int32 func, float @ref);

			[ThreadStatic]
			internal static glIndexFuncEXT pglIndexFuncEXT;

			internal delegate void glIndexMask(UInt32 mask);

			[ThreadStatic]
			internal static glIndexMask pglIndexMask;

			internal delegate void glIndexMaterialEXT(Int32 face, Int32 mode);

			[ThreadStatic]
			internal static glIndexMaterialEXT pglIndexMaterialEXT;

			internal unsafe delegate void glIndexPointer(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glIndexPointer pglIndexPointer;

			internal unsafe delegate void glIndexPointerEXT(Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[ThreadStatic]
			internal static glIndexPointerEXT pglIndexPointerEXT;

			internal unsafe delegate void glIndexPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glIndexPointerListIBM pglIndexPointerListIBM;

			internal delegate void glIndexd(double c);

			[ThreadStatic]
			internal static glIndexd pglIndexd;

			internal unsafe delegate void glIndexdv(double* c);

			[ThreadStatic]
			internal static glIndexdv pglIndexdv;

			internal delegate void glIndexf(float c);

			[ThreadStatic]
			internal static glIndexf pglIndexf;

			internal unsafe delegate void glIndexfv(float* c);

			[ThreadStatic]
			internal static glIndexfv pglIndexfv;

			internal delegate void glIndexi(Int32 c);

			[ThreadStatic]
			internal static glIndexi pglIndexi;

			internal unsafe delegate void glIndexiv(Int32* c);

			[ThreadStatic]
			internal static glIndexiv pglIndexiv;

			internal delegate void glIndexs(Int16 c);

			[ThreadStatic]
			internal static glIndexs pglIndexs;

			internal unsafe delegate void glIndexsv(Int16* c);

			[ThreadStatic]
			internal static glIndexsv pglIndexsv;

			internal delegate void glIndexub(byte c);

			[ThreadStatic]
			internal static glIndexub pglIndexub;

			internal unsafe delegate void glIndexubv(byte* c);

			[ThreadStatic]
			internal static glIndexubv pglIndexubv;

			internal unsafe delegate void glIndexxOES(IntPtr component);

			[ThreadStatic]
			internal static glIndexxOES pglIndexxOES;

			internal unsafe delegate void glIndexxvOES(IntPtr* component);

			[ThreadStatic]
			internal static glIndexxvOES pglIndexxvOES;

			internal delegate void glInitNames();

			[ThreadStatic]
			internal static glInitNames pglInitNames;

			internal delegate void glInsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);

			[ThreadStatic]
			internal static glInsertComponentEXT pglInsertComponentEXT;

			internal delegate void glInsertEventMarkerEXT(Int32 length, String marker);

			[ThreadStatic]
			internal static glInsertEventMarkerEXT pglInsertEventMarkerEXT;

			internal unsafe delegate void glInstrumentsBufferSGIX(Int32 size, Int32* buffer);

			[ThreadStatic]
			internal static glInstrumentsBufferSGIX pglInstrumentsBufferSGIX;

			internal unsafe delegate void glInterleavedArrays(Int32 format, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glInterleavedArrays pglInterleavedArrays;

			internal delegate void glInterpolatePathsNV(UInt32 resultPath, UInt32 pathA, UInt32 pathB, float weight);

			[ThreadStatic]
			internal static glInterpolatePathsNV pglInterpolatePathsNV;

			internal delegate void glInvalidateBufferData(UInt32 buffer);

			[ThreadStatic]
			internal static glInvalidateBufferData pglInvalidateBufferData;

			internal unsafe delegate void glInvalidateBufferSubData(UInt32 buffer, IntPtr offset, UInt32 length);

			[ThreadStatic]
			internal static glInvalidateBufferSubData pglInvalidateBufferSubData;

			internal unsafe delegate void glInvalidateFramebuffer(Int32 target, Int32 numAttachments, Int32* attachments);

			[ThreadStatic]
			internal static glInvalidateFramebuffer pglInvalidateFramebuffer;

			internal unsafe delegate void glInvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments);

			[ThreadStatic]
			internal static glInvalidateNamedFramebufferData pglInvalidateNamedFramebufferData;

			internal unsafe delegate void glInvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glInvalidateNamedFramebufferSubData pglInvalidateNamedFramebufferSubData;

			internal unsafe delegate void glInvalidateSubFramebuffer(Int32 target, Int32 numAttachments, Int32* attachments, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glInvalidateSubFramebuffer pglInvalidateSubFramebuffer;

			internal delegate void glInvalidateTexImage(UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glInvalidateTexImage pglInvalidateTexImage;

			internal delegate void glInvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);

			[ThreadStatic]
			internal static glInvalidateTexSubImage pglInvalidateTexSubImage;

			internal delegate bool glIsAsyncMarkerSGIX(UInt32 marker);

			[ThreadStatic]
			internal static glIsAsyncMarkerSGIX pglIsAsyncMarkerSGIX;

			internal delegate bool glIsBuffer(UInt32 buffer);

			[AliasOf("glIsBuffer")]
			[AliasOf("glIsBufferARB")]
			[ThreadStatic]
			internal static glIsBuffer pglIsBuffer;

			internal delegate bool glIsBufferResidentNV(Int32 target);

			[ThreadStatic]
			internal static glIsBufferResidentNV pglIsBufferResidentNV;

			internal delegate bool glIsCommandListNV(UInt32 list);

			[ThreadStatic]
			internal static glIsCommandListNV pglIsCommandListNV;

			internal delegate bool glIsEnabled(Int32 cap);

			[ThreadStatic]
			internal static glIsEnabled pglIsEnabled;

			internal delegate bool glIsEnabledi(Int32 target, UInt32 index);

			[AliasOf("glIsEnabledi")]
			[AliasOf("glIsEnabledIndexedEXT")]
			[AliasOf("glIsEnablediEXT")]
			[AliasOf("glIsEnablediNV")]
			[AliasOf("glIsEnablediOES")]
			[ThreadStatic]
			internal static glIsEnabledi pglIsEnabledi;

			internal delegate bool glIsFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glIsFenceAPPLE pglIsFenceAPPLE;

			internal delegate bool glIsFenceNV(UInt32 fence);

			[ThreadStatic]
			internal static glIsFenceNV pglIsFenceNV;

			internal delegate bool glIsFramebuffer(UInt32 framebuffer);

			[AliasOf("glIsFramebuffer")]
			[AliasOf("glIsFramebufferEXT")]
			[ThreadStatic]
			internal static glIsFramebuffer pglIsFramebuffer;

			internal delegate bool glIsFramebufferOES(UInt32 framebuffer);

			[ThreadStatic]
			internal static glIsFramebufferOES pglIsFramebufferOES;

			internal delegate bool glIsImageHandleResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glIsImageHandleResidentARB pglIsImageHandleResidentARB;

			internal delegate bool glIsImageHandleResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glIsImageHandleResidentNV pglIsImageHandleResidentNV;

			internal delegate bool glIsList(UInt32 list);

			[ThreadStatic]
			internal static glIsList pglIsList;

			internal delegate bool glIsNameAMD(Int32 identifier, UInt32 name);

			[ThreadStatic]
			internal static glIsNameAMD pglIsNameAMD;

			internal delegate bool glIsNamedBufferResidentNV(UInt32 buffer);

			[ThreadStatic]
			internal static glIsNamedBufferResidentNV pglIsNamedBufferResidentNV;

			internal delegate bool glIsNamedStringARB(Int32 namelen, String name);

			[ThreadStatic]
			internal static glIsNamedStringARB pglIsNamedStringARB;

			internal delegate bool glIsObjectBufferATI(UInt32 buffer);

			[ThreadStatic]
			internal static glIsObjectBufferATI pglIsObjectBufferATI;

			internal delegate bool glIsOcclusionQueryNV(UInt32 id);

			[ThreadStatic]
			internal static glIsOcclusionQueryNV pglIsOcclusionQueryNV;

			internal delegate bool glIsPathNV(UInt32 path);

			[ThreadStatic]
			internal static glIsPathNV pglIsPathNV;

			internal delegate bool glIsPointInFillPathNV(UInt32 path, UInt32 mask, float x, float y);

			[ThreadStatic]
			internal static glIsPointInFillPathNV pglIsPointInFillPathNV;

			internal delegate bool glIsPointInStrokePathNV(UInt32 path, float x, float y);

			[ThreadStatic]
			internal static glIsPointInStrokePathNV pglIsPointInStrokePathNV;

			internal delegate bool glIsProgram(UInt32 program);

			[ThreadStatic]
			internal static glIsProgram pglIsProgram;

			internal delegate bool glIsProgramARB(UInt32 program);

			[AliasOf("glIsProgramARB")]
			[AliasOf("glIsProgramNV")]
			[ThreadStatic]
			internal static glIsProgramARB pglIsProgramARB;

			internal delegate bool glIsProgramPipeline(UInt32 pipeline);

			[ThreadStatic]
			internal static glIsProgramPipeline pglIsProgramPipeline;

			internal delegate bool glIsProgramPipelineEXT(UInt32 pipeline);

			[ThreadStatic]
			internal static glIsProgramPipelineEXT pglIsProgramPipelineEXT;

			internal delegate bool glIsQuery(UInt32 id);

			[AliasOf("glIsQuery")]
			[AliasOf("glIsQueryARB")]
			[ThreadStatic]
			internal static glIsQuery pglIsQuery;

			internal delegate bool glIsQueryEXT(UInt32 id);

			[ThreadStatic]
			internal static glIsQueryEXT pglIsQueryEXT;

			internal delegate bool glIsRenderbuffer(UInt32 renderbuffer);

			[AliasOf("glIsRenderbuffer")]
			[AliasOf("glIsRenderbufferEXT")]
			[ThreadStatic]
			internal static glIsRenderbuffer pglIsRenderbuffer;

			internal delegate bool glIsRenderbufferOES(UInt32 renderbuffer);

			[ThreadStatic]
			internal static glIsRenderbufferOES pglIsRenderbufferOES;

			internal delegate bool glIsSampler(UInt32 sampler);

			[ThreadStatic]
			internal static glIsSampler pglIsSampler;

			internal delegate bool glIsShader(UInt32 shader);

			[ThreadStatic]
			internal static glIsShader pglIsShader;

			internal delegate bool glIsStateNV(UInt32 state);

			[ThreadStatic]
			internal static glIsStateNV pglIsStateNV;

			internal delegate bool glIsSync(Int32 sync);

			[AliasOf("glIsSync")]
			[AliasOf("glIsSyncAPPLE")]
			[ThreadStatic]
			internal static glIsSync pglIsSync;

			internal delegate bool glIsTexture(UInt32 texture);

			[ThreadStatic]
			internal static glIsTexture pglIsTexture;

			internal delegate bool glIsTextureEXT(UInt32 texture);

			[ThreadStatic]
			internal static glIsTextureEXT pglIsTextureEXT;

			internal delegate bool glIsTextureHandleResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glIsTextureHandleResidentARB pglIsTextureHandleResidentARB;

			internal delegate bool glIsTextureHandleResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glIsTextureHandleResidentNV pglIsTextureHandleResidentNV;

			internal delegate bool glIsTransformFeedback(UInt32 id);

			[AliasOf("glIsTransformFeedback")]
			[AliasOf("glIsTransformFeedbackNV")]
			[ThreadStatic]
			internal static glIsTransformFeedback pglIsTransformFeedback;

			internal delegate bool glIsVariantEnabledEXT(UInt32 id, Int32 cap);

			[ThreadStatic]
			internal static glIsVariantEnabledEXT pglIsVariantEnabledEXT;

			internal delegate bool glIsVertexArray(UInt32 array);

			[AliasOf("glIsVertexArray")]
			[AliasOf("glIsVertexArrayAPPLE")]
			[AliasOf("glIsVertexArrayOES")]
			[ThreadStatic]
			internal static glIsVertexArray pglIsVertexArray;

			internal delegate bool glIsVertexAttribEnabledAPPLE(UInt32 index, Int32 pname);

			[ThreadStatic]
			internal static glIsVertexAttribEnabledAPPLE pglIsVertexAttribEnabledAPPLE;

			internal delegate void glLabelObjectEXT(Int32 type, UInt32 @object, Int32 length, String label);

			[ThreadStatic]
			internal static glLabelObjectEXT pglLabelObjectEXT;

			internal delegate void glLightEnviSGIX(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLightEnviSGIX pglLightEnviSGIX;

			internal delegate void glLightModelf(Int32 pname, float param);

			[ThreadStatic]
			internal static glLightModelf pglLightModelf;

			internal unsafe delegate void glLightModelfv(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glLightModelfv pglLightModelfv;

			internal delegate void glLightModeli(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLightModeli pglLightModeli;

			internal unsafe delegate void glLightModeliv(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glLightModeliv pglLightModeliv;

			internal unsafe delegate void glLightModelx(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glLightModelx pglLightModelx;

			internal unsafe delegate void glLightModelxOES(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glLightModelxOES pglLightModelxOES;

			internal unsafe delegate void glLightModelxv(Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glLightModelxv pglLightModelxv;

			internal unsafe delegate void glLightModelxvOES(Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glLightModelxvOES pglLightModelxvOES;

			internal delegate void glLightf(Int32 light, Int32 pname, float param);

			[ThreadStatic]
			internal static glLightf pglLightf;

			internal unsafe delegate void glLightfv(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glLightfv pglLightfv;

			internal delegate void glLighti(Int32 light, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLighti pglLighti;

			internal unsafe delegate void glLightiv(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glLightiv pglLightiv;

			internal unsafe delegate void glLightx(Int32 light, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glLightx pglLightx;

			internal unsafe delegate void glLightxOES(Int32 light, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glLightxOES pglLightxOES;

			internal unsafe delegate void glLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glLightxv pglLightxv;

			internal unsafe delegate void glLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glLightxvOES pglLightxvOES;

			internal delegate void glLineStipple(Int32 factor, UInt16 pattern);

			[ThreadStatic]
			internal static glLineStipple pglLineStipple;

			internal delegate void glLineWidth(float width);

			[ThreadStatic]
			internal static glLineWidth pglLineWidth;

			internal unsafe delegate void glLineWidthx(IntPtr width);

			[ThreadStatic]
			internal static glLineWidthx pglLineWidthx;

			internal unsafe delegate void glLineWidthxOES(IntPtr width);

			[ThreadStatic]
			internal static glLineWidthxOES pglLineWidthxOES;

			internal delegate void glLinkProgram(UInt32 program);

			[AliasOf("glLinkProgram")]
			[AliasOf("glLinkProgramARB")]
			[ThreadStatic]
			internal static glLinkProgram pglLinkProgram;

			internal delegate void glListBase(UInt32 @base);

			[ThreadStatic]
			internal static glListBase pglListBase;

			internal unsafe delegate void glListDrawCommandsStatesClientNV(UInt32 list, UInt32 segment, IntPtr* indirects, Int32* sizes, UInt32* states, UInt32* fbos, UInt32 count);

			[ThreadStatic]
			internal static glListDrawCommandsStatesClientNV pglListDrawCommandsStatesClientNV;

			internal delegate void glListParameterfSGIX(UInt32 list, Int32 pname, float param);

			[ThreadStatic]
			internal static glListParameterfSGIX pglListParameterfSGIX;

			internal unsafe delegate void glListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glListParameterfvSGIX pglListParameterfvSGIX;

			internal delegate void glListParameteriSGIX(UInt32 list, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glListParameteriSGIX pglListParameteriSGIX;

			internal unsafe delegate void glListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glListParameterivSGIX pglListParameterivSGIX;

			internal delegate void glLoadIdentity();

			[ThreadStatic]
			internal static glLoadIdentity pglLoadIdentity;

			internal delegate void glLoadIdentityDeformationMapSGIX(UInt32 mask);

			[ThreadStatic]
			internal static glLoadIdentityDeformationMapSGIX pglLoadIdentityDeformationMapSGIX;

			internal unsafe delegate void glLoadMatrixd(double* m);

			[ThreadStatic]
			internal static glLoadMatrixd pglLoadMatrixd;

			internal unsafe delegate void glLoadMatrixf(float* m);

			[ThreadStatic]
			internal static glLoadMatrixf pglLoadMatrixf;

			internal unsafe delegate void glLoadMatrixx(IntPtr* m);

			[ThreadStatic]
			internal static glLoadMatrixx pglLoadMatrixx;

			internal unsafe delegate void glLoadMatrixxOES(IntPtr* m);

			[ThreadStatic]
			internal static glLoadMatrixxOES pglLoadMatrixxOES;

			internal delegate void glLoadName(UInt32 name);

			[ThreadStatic]
			internal static glLoadName pglLoadName;

			internal delegate void glLoadPaletteFromModelViewMatrixOES();

			[ThreadStatic]
			internal static glLoadPaletteFromModelViewMatrixOES pglLoadPaletteFromModelViewMatrixOES;

			internal unsafe delegate void glLoadProgramNV(Int32 target, UInt32 id, Int32 len, byte* program);

			[ThreadStatic]
			internal static glLoadProgramNV pglLoadProgramNV;

			internal unsafe delegate void glLoadTransposeMatrixd(double* m);

			[AliasOf("glLoadTransposeMatrixd")]
			[AliasOf("glLoadTransposeMatrixdARB")]
			[ThreadStatic]
			internal static glLoadTransposeMatrixd pglLoadTransposeMatrixd;

			internal unsafe delegate void glLoadTransposeMatrixf(float* m);

			[AliasOf("glLoadTransposeMatrixf")]
			[AliasOf("glLoadTransposeMatrixfARB")]
			[ThreadStatic]
			internal static glLoadTransposeMatrixf pglLoadTransposeMatrixf;

			internal unsafe delegate void glLoadTransposeMatrixxOES(IntPtr* m);

			[ThreadStatic]
			internal static glLoadTransposeMatrixxOES pglLoadTransposeMatrixxOES;

			internal delegate void glLockArraysEXT(Int32 first, Int32 count);

			[ThreadStatic]
			internal static glLockArraysEXT pglLockArraysEXT;

			internal delegate void glLogicOp(Int32 opcode);

			[ThreadStatic]
			internal static glLogicOp pglLogicOp;

			internal delegate void glMakeBufferNonResidentNV(Int32 target);

			[ThreadStatic]
			internal static glMakeBufferNonResidentNV pglMakeBufferNonResidentNV;

			internal delegate void glMakeBufferResidentNV(Int32 target, Int32 access);

			[ThreadStatic]
			internal static glMakeBufferResidentNV pglMakeBufferResidentNV;

			internal delegate void glMakeImageHandleNonResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glMakeImageHandleNonResidentARB pglMakeImageHandleNonResidentARB;

			internal delegate void glMakeImageHandleNonResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glMakeImageHandleNonResidentNV pglMakeImageHandleNonResidentNV;

			internal delegate void glMakeImageHandleResidentARB(UInt64 handle, Int32 access);

			[ThreadStatic]
			internal static glMakeImageHandleResidentARB pglMakeImageHandleResidentARB;

			internal delegate void glMakeImageHandleResidentNV(UInt64 handle, Int32 access);

			[ThreadStatic]
			internal static glMakeImageHandleResidentNV pglMakeImageHandleResidentNV;

			internal delegate void glMakeNamedBufferNonResidentNV(UInt32 buffer);

			[ThreadStatic]
			internal static glMakeNamedBufferNonResidentNV pglMakeNamedBufferNonResidentNV;

			internal delegate void glMakeNamedBufferResidentNV(UInt32 buffer, Int32 access);

			[ThreadStatic]
			internal static glMakeNamedBufferResidentNV pglMakeNamedBufferResidentNV;

			internal delegate void glMakeTextureHandleNonResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentARB pglMakeTextureHandleNonResidentARB;

			internal delegate void glMakeTextureHandleNonResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentNV pglMakeTextureHandleNonResidentNV;

			internal delegate void glMakeTextureHandleResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleResidentARB pglMakeTextureHandleResidentARB;

			internal delegate void glMakeTextureHandleResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleResidentNV pglMakeTextureHandleResidentNV;

			internal unsafe delegate void glMap1d(Int32 target, double u1, double u2, Int32 stride, Int32 order, double* points);

			[ThreadStatic]
			internal static glMap1d pglMap1d;

			internal unsafe delegate void glMap1f(Int32 target, float u1, float u2, Int32 stride, Int32 order, float* points);

			[ThreadStatic]
			internal static glMap1f pglMap1f;

			internal unsafe delegate void glMap1xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points);

			[ThreadStatic]
			internal static glMap1xOES pglMap1xOES;

			internal unsafe delegate void glMap2d(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[ThreadStatic]
			internal static glMap2d pglMap2d;

			internal unsafe delegate void glMap2f(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[ThreadStatic]
			internal static glMap2f pglMap2f;

			internal unsafe delegate void glMap2xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points);

			[ThreadStatic]
			internal static glMap2xOES pglMap2xOES;

			internal delegate IntPtr glMapBuffer(Int32 target, Int32 access);

			[AliasOf("glMapBuffer")]
			[AliasOf("glMapBufferARB")]
			[AliasOf("glMapBufferOES")]
			[ThreadStatic]
			internal static glMapBuffer pglMapBuffer;

			internal unsafe delegate IntPtr glMapBufferRange(Int32 target, IntPtr offset, UInt32 length, UInt32 access);

			[AliasOf("glMapBufferRange")]
			[AliasOf("glMapBufferRangeEXT")]
			[ThreadStatic]
			internal static glMapBufferRange pglMapBufferRange;

			internal unsafe delegate void glMapControlPointsNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, IntPtr points);

			[ThreadStatic]
			internal static glMapControlPointsNV pglMapControlPointsNV;

			internal delegate void glMapGrid1d(Int32 un, double u1, double u2);

			[ThreadStatic]
			internal static glMapGrid1d pglMapGrid1d;

			internal delegate void glMapGrid1f(Int32 un, float u1, float u2);

			[ThreadStatic]
			internal static glMapGrid1f pglMapGrid1f;

			internal unsafe delegate void glMapGrid1xOES(Int32 n, IntPtr u1, IntPtr u2);

			[ThreadStatic]
			internal static glMapGrid1xOES pglMapGrid1xOES;

			internal delegate void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);

			[ThreadStatic]
			internal static glMapGrid2d pglMapGrid2d;

			internal delegate void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);

			[ThreadStatic]
			internal static glMapGrid2f pglMapGrid2f;

			internal unsafe delegate void glMapGrid2xOES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2);

			[ThreadStatic]
			internal static glMapGrid2xOES pglMapGrid2xOES;

			internal delegate IntPtr glMapNamedBuffer(UInt32 buffer, Int32 access);

			[ThreadStatic]
			internal static glMapNamedBuffer pglMapNamedBuffer;

			internal delegate IntPtr glMapNamedBufferEXT(UInt32 buffer, Int32 access);

			[ThreadStatic]
			internal static glMapNamedBufferEXT pglMapNamedBufferEXT;

			internal unsafe delegate IntPtr glMapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[ThreadStatic]
			internal static glMapNamedBufferRange pglMapNamedBufferRange;

			internal unsafe delegate IntPtr glMapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[ThreadStatic]
			internal static glMapNamedBufferRangeEXT pglMapNamedBufferRangeEXT;

			internal delegate IntPtr glMapObjectBufferATI(UInt32 buffer);

			[ThreadStatic]
			internal static glMapObjectBufferATI pglMapObjectBufferATI;

			internal unsafe delegate void glMapParameterfvNV(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMapParameterfvNV pglMapParameterfvNV;

			internal unsafe delegate void glMapParameterivNV(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMapParameterivNV pglMapParameterivNV;

			internal unsafe delegate IntPtr glMapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32* stride, Int32* layout);

			[ThreadStatic]
			internal static glMapTexture2DINTEL pglMapTexture2DINTEL;

			internal unsafe delegate void glMapVertexAttrib1dAPPLE(UInt32 index, UInt32 size, double u1, double u2, Int32 stride, Int32 order, double* points);

			[ThreadStatic]
			internal static glMapVertexAttrib1dAPPLE pglMapVertexAttrib1dAPPLE;

			internal unsafe delegate void glMapVertexAttrib1fAPPLE(UInt32 index, UInt32 size, float u1, float u2, Int32 stride, Int32 order, float* points);

			[ThreadStatic]
			internal static glMapVertexAttrib1fAPPLE pglMapVertexAttrib1fAPPLE;

			internal unsafe delegate void glMapVertexAttrib2dAPPLE(UInt32 index, UInt32 size, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[ThreadStatic]
			internal static glMapVertexAttrib2dAPPLE pglMapVertexAttrib2dAPPLE;

			internal unsafe delegate void glMapVertexAttrib2fAPPLE(UInt32 index, UInt32 size, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[ThreadStatic]
			internal static glMapVertexAttrib2fAPPLE pglMapVertexAttrib2fAPPLE;

			internal delegate void glMaterialf(Int32 face, Int32 pname, float param);

			[ThreadStatic]
			internal static glMaterialf pglMaterialf;

			internal unsafe delegate void glMaterialfv(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMaterialfv pglMaterialfv;

			internal delegate void glMateriali(Int32 face, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMateriali pglMateriali;

			internal unsafe delegate void glMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMaterialiv pglMaterialiv;

			internal unsafe delegate void glMaterialx(Int32 face, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glMaterialx pglMaterialx;

			internal unsafe delegate void glMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glMaterialxOES pglMaterialxOES;

			internal unsafe delegate void glMaterialxv(Int32 face, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glMaterialxv pglMaterialxv;

			internal unsafe delegate void glMaterialxvOES(Int32 face, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glMaterialxvOES pglMaterialxvOES;

			internal delegate void glMatrixFrustumEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glMatrixFrustumEXT pglMatrixFrustumEXT;

			internal unsafe delegate void glMatrixIndexPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glMatrixIndexPointerARB pglMatrixIndexPointerARB;

			internal unsafe delegate void glMatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glMatrixIndexPointerOES pglMatrixIndexPointerOES;

			internal unsafe delegate void glMatrixIndexubvARB(Int32 size, byte* indices);

			[ThreadStatic]
			internal static glMatrixIndexubvARB pglMatrixIndexubvARB;

			internal unsafe delegate void glMatrixIndexuivARB(Int32 size, UInt32* indices);

			[ThreadStatic]
			internal static glMatrixIndexuivARB pglMatrixIndexuivARB;

			internal unsafe delegate void glMatrixIndexusvARB(Int32 size, UInt16* indices);

			[ThreadStatic]
			internal static glMatrixIndexusvARB pglMatrixIndexusvARB;

			internal unsafe delegate void glMatrixLoad3x2fNV(Int32 matrixMode, float* m);

			[ThreadStatic]
			internal static glMatrixLoad3x2fNV pglMatrixLoad3x2fNV;

			internal unsafe delegate void glMatrixLoad3x3fNV(Int32 matrixMode, float* m);

			[ThreadStatic]
			internal static glMatrixLoad3x3fNV pglMatrixLoad3x3fNV;

			internal delegate void glMatrixLoadIdentityEXT(Int32 mode);

			[ThreadStatic]
			internal static glMatrixLoadIdentityEXT pglMatrixLoadIdentityEXT;

			internal unsafe delegate void glMatrixLoadTranspose3x3fNV(Int32 matrixMode, float* m);

			[ThreadStatic]
			internal static glMatrixLoadTranspose3x3fNV pglMatrixLoadTranspose3x3fNV;

			internal unsafe delegate void glMatrixLoadTransposedEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixLoadTransposedEXT pglMatrixLoadTransposedEXT;

			internal unsafe delegate void glMatrixLoadTransposefEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixLoadTransposefEXT pglMatrixLoadTransposefEXT;

			internal unsafe delegate void glMatrixLoaddEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixLoaddEXT pglMatrixLoaddEXT;

			internal unsafe delegate void glMatrixLoadfEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixLoadfEXT pglMatrixLoadfEXT;

			internal delegate void glMatrixMode(Int32 mode);

			[ThreadStatic]
			internal static glMatrixMode pglMatrixMode;

			internal unsafe delegate void glMatrixMult3x2fNV(Int32 matrixMode, float* m);

			[ThreadStatic]
			internal static glMatrixMult3x2fNV pglMatrixMult3x2fNV;

			internal unsafe delegate void glMatrixMult3x3fNV(Int32 matrixMode, float* m);

			[ThreadStatic]
			internal static glMatrixMult3x3fNV pglMatrixMult3x3fNV;

			internal unsafe delegate void glMatrixMultTranspose3x3fNV(Int32 matrixMode, float* m);

			[ThreadStatic]
			internal static glMatrixMultTranspose3x3fNV pglMatrixMultTranspose3x3fNV;

			internal unsafe delegate void glMatrixMultTransposedEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixMultTransposedEXT pglMatrixMultTransposedEXT;

			internal unsafe delegate void glMatrixMultTransposefEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixMultTransposefEXT pglMatrixMultTransposefEXT;

			internal unsafe delegate void glMatrixMultdEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixMultdEXT pglMatrixMultdEXT;

			internal unsafe delegate void glMatrixMultfEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixMultfEXT pglMatrixMultfEXT;

			internal delegate void glMatrixOrthoEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glMatrixOrthoEXT pglMatrixOrthoEXT;

			internal delegate void glMatrixPopEXT(Int32 mode);

			[ThreadStatic]
			internal static glMatrixPopEXT pglMatrixPopEXT;

			internal delegate void glMatrixPushEXT(Int32 mode);

			[ThreadStatic]
			internal static glMatrixPushEXT pglMatrixPushEXT;

			internal delegate void glMatrixRotatedEXT(Int32 mode, double angle, double x, double y, double z);

			[ThreadStatic]
			internal static glMatrixRotatedEXT pglMatrixRotatedEXT;

			internal delegate void glMatrixRotatefEXT(Int32 mode, float angle, float x, float y, float z);

			[ThreadStatic]
			internal static glMatrixRotatefEXT pglMatrixRotatefEXT;

			internal delegate void glMatrixScaledEXT(Int32 mode, double x, double y, double z);

			[ThreadStatic]
			internal static glMatrixScaledEXT pglMatrixScaledEXT;

			internal delegate void glMatrixScalefEXT(Int32 mode, float x, float y, float z);

			[ThreadStatic]
			internal static glMatrixScalefEXT pglMatrixScalefEXT;

			internal delegate void glMatrixTranslatedEXT(Int32 mode, double x, double y, double z);

			[ThreadStatic]
			internal static glMatrixTranslatedEXT pglMatrixTranslatedEXT;

			internal delegate void glMatrixTranslatefEXT(Int32 mode, float x, float y, float z);

			[ThreadStatic]
			internal static glMatrixTranslatefEXT pglMatrixTranslatefEXT;

			internal delegate void glMaxShaderCompilerThreadsARB(UInt32 count);

			[ThreadStatic]
			internal static glMaxShaderCompilerThreadsARB pglMaxShaderCompilerThreadsARB;

			internal delegate void glMemoryBarrier(UInt32 barriers);

			[AliasOf("glMemoryBarrier")]
			[AliasOf("glMemoryBarrierEXT")]
			[ThreadStatic]
			internal static glMemoryBarrier pglMemoryBarrier;

			internal delegate void glMemoryBarrierByRegion(UInt32 barriers);

			[ThreadStatic]
			internal static glMemoryBarrierByRegion pglMemoryBarrierByRegion;

			internal delegate void glMinSampleShading(float value);

			[AliasOf("glMinSampleShading")]
			[AliasOf("glMinSampleShadingARB")]
			[AliasOf("glMinSampleShadingOES")]
			[ThreadStatic]
			internal static glMinSampleShading pglMinSampleShading;

			internal delegate void glMinmax(Int32 target, Int32 internalformat, bool sink);

			[AliasOf("glMinmax")]
			[AliasOf("glMinmaxEXT")]
			[ThreadStatic]
			internal static glMinmax pglMinmax;

			internal unsafe delegate void glMultMatrixd(double* m);

			[ThreadStatic]
			internal static glMultMatrixd pglMultMatrixd;

			internal unsafe delegate void glMultMatrixf(float* m);

			[ThreadStatic]
			internal static glMultMatrixf pglMultMatrixf;

			internal unsafe delegate void glMultMatrixx(IntPtr* m);

			[ThreadStatic]
			internal static glMultMatrixx pglMultMatrixx;

			internal unsafe delegate void glMultMatrixxOES(IntPtr* m);

			[ThreadStatic]
			internal static glMultMatrixxOES pglMultMatrixxOES;

			internal unsafe delegate void glMultTransposeMatrixd(double* m);

			[AliasOf("glMultTransposeMatrixd")]
			[AliasOf("glMultTransposeMatrixdARB")]
			[ThreadStatic]
			internal static glMultTransposeMatrixd pglMultTransposeMatrixd;

			internal unsafe delegate void glMultTransposeMatrixf(float* m);

			[AliasOf("glMultTransposeMatrixf")]
			[AliasOf("glMultTransposeMatrixfARB")]
			[ThreadStatic]
			internal static glMultTransposeMatrixf pglMultTransposeMatrixf;

			internal unsafe delegate void glMultTransposeMatrixxOES(IntPtr* m);

			[ThreadStatic]
			internal static glMultTransposeMatrixxOES pglMultTransposeMatrixxOES;

			internal unsafe delegate void glMultiDrawArrays(Int32 mode, Int32* first, Int32* count, Int32 drawcount);

			[AliasOf("glMultiDrawArrays")]
			[AliasOf("glMultiDrawArraysEXT")]
			[ThreadStatic]
			internal static glMultiDrawArrays pglMultiDrawArrays;

			internal unsafe delegate void glMultiDrawArraysIndirect(Int32 mode, IntPtr indirect, Int32 drawcount, Int32 stride);

			[AliasOf("glMultiDrawArraysIndirect")]
			[AliasOf("glMultiDrawArraysIndirectAMD")]
			[AliasOf("glMultiDrawArraysIndirectEXT")]
			[ThreadStatic]
			internal static glMultiDrawArraysIndirect pglMultiDrawArraysIndirect;

			internal unsafe delegate void glMultiDrawArraysIndirectBindlessCountNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount);

			[ThreadStatic]
			internal static glMultiDrawArraysIndirectBindlessCountNV pglMultiDrawArraysIndirectBindlessCountNV;

			internal unsafe delegate void glMultiDrawArraysIndirectBindlessNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			[ThreadStatic]
			internal static glMultiDrawArraysIndirectBindlessNV pglMultiDrawArraysIndirectBindlessNV;

			internal unsafe delegate void glMultiDrawArraysIndirectCountARB(Int32 mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[ThreadStatic]
			internal static glMultiDrawArraysIndirectCountARB pglMultiDrawArraysIndirectCountARB;

			internal unsafe delegate void glMultiDrawElementArrayAPPLE(Int32 mode, Int32* first, Int32* count, Int32 primcount);

			[ThreadStatic]
			internal static glMultiDrawElementArrayAPPLE pglMultiDrawElementArrayAPPLE;

			internal unsafe delegate void glMultiDrawElements(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount);

			[AliasOf("glMultiDrawElements")]
			[AliasOf("glMultiDrawElementsEXT")]
			[ThreadStatic]
			internal static glMultiDrawElements pglMultiDrawElements;

			internal unsafe delegate void glMultiDrawElementsBaseVertex(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount, Int32* basevertex);

			[AliasOf("glMultiDrawElementsBaseVertex")]
			[AliasOf("glMultiDrawElementsBaseVertexEXT")]
			[AliasOf("glMultiDrawElementsBaseVertexOES")]
			[ThreadStatic]
			internal static glMultiDrawElementsBaseVertex pglMultiDrawElementsBaseVertex;

			internal unsafe delegate void glMultiDrawElementsIndirect(Int32 mode, Int32 type, IntPtr indirect, Int32 drawcount, Int32 stride);

			[AliasOf("glMultiDrawElementsIndirect")]
			[AliasOf("glMultiDrawElementsIndirectAMD")]
			[AliasOf("glMultiDrawElementsIndirectEXT")]
			[ThreadStatic]
			internal static glMultiDrawElementsIndirect pglMultiDrawElementsIndirect;

			internal unsafe delegate void glMultiDrawElementsIndirectBindlessCountNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount);

			[ThreadStatic]
			internal static glMultiDrawElementsIndirectBindlessCountNV pglMultiDrawElementsIndirectBindlessCountNV;

			internal unsafe delegate void glMultiDrawElementsIndirectBindlessNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			[ThreadStatic]
			internal static glMultiDrawElementsIndirectBindlessNV pglMultiDrawElementsIndirectBindlessNV;

			internal unsafe delegate void glMultiDrawElementsIndirectCountARB(Int32 mode, Int32 type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[ThreadStatic]
			internal static glMultiDrawElementsIndirectCountARB pglMultiDrawElementsIndirectCountARB;

			internal unsafe delegate void glMultiDrawRangeElementArrayAPPLE(Int32 mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);

			[ThreadStatic]
			internal static glMultiDrawRangeElementArrayAPPLE pglMultiDrawRangeElementArrayAPPLE;

			internal unsafe delegate void glMultiModeDrawArraysIBM(Int32* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);

			[ThreadStatic]
			internal static glMultiModeDrawArraysIBM pglMultiModeDrawArraysIBM;

			internal unsafe delegate void glMultiModeDrawElementsIBM(Int32* mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32 modestride);

			[ThreadStatic]
			internal static glMultiModeDrawElementsIBM pglMultiModeDrawElementsIBM;

			internal delegate void glMultiTexBufferEXT(Int32 texunit, Int32 target, Int32 internalformat, UInt32 buffer);

			[ThreadStatic]
			internal static glMultiTexBufferEXT pglMultiTexBufferEXT;

			internal delegate void glMultiTexCoord1bOES(Int32 texture, sbyte s);

			[ThreadStatic]
			internal static glMultiTexCoord1bOES pglMultiTexCoord1bOES;

			internal unsafe delegate void glMultiTexCoord1bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord1bvOES pglMultiTexCoord1bvOES;

			internal delegate void glMultiTexCoord1d(Int32 target, double s);

			[AliasOf("glMultiTexCoord1d")]
			[AliasOf("glMultiTexCoord1dARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1d pglMultiTexCoord1d;

			internal unsafe delegate void glMultiTexCoord1dv(Int32 target, double* v);

			[AliasOf("glMultiTexCoord1dv")]
			[AliasOf("glMultiTexCoord1dvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1dv pglMultiTexCoord1dv;

			internal delegate void glMultiTexCoord1f(Int32 target, float s);

			[AliasOf("glMultiTexCoord1f")]
			[AliasOf("glMultiTexCoord1fARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1f pglMultiTexCoord1f;

			internal unsafe delegate void glMultiTexCoord1fv(Int32 target, float* v);

			[AliasOf("glMultiTexCoord1fv")]
			[AliasOf("glMultiTexCoord1fvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1fv pglMultiTexCoord1fv;

			internal delegate void glMultiTexCoord1hNV(Int32 target, UInt16 s);

			[ThreadStatic]
			internal static glMultiTexCoord1hNV pglMultiTexCoord1hNV;

			internal unsafe delegate void glMultiTexCoord1hvNV(Int32 target, UInt16* v);

			[ThreadStatic]
			internal static glMultiTexCoord1hvNV pglMultiTexCoord1hvNV;

			internal delegate void glMultiTexCoord1i(Int32 target, Int32 s);

			[AliasOf("glMultiTexCoord1i")]
			[AliasOf("glMultiTexCoord1iARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1i pglMultiTexCoord1i;

			internal unsafe delegate void glMultiTexCoord1iv(Int32 target, Int32* v);

			[AliasOf("glMultiTexCoord1iv")]
			[AliasOf("glMultiTexCoord1ivARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1iv pglMultiTexCoord1iv;

			internal delegate void glMultiTexCoord1s(Int32 target, Int16 s);

			[AliasOf("glMultiTexCoord1s")]
			[AliasOf("glMultiTexCoord1sARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1s pglMultiTexCoord1s;

			internal unsafe delegate void glMultiTexCoord1sv(Int32 target, Int16* v);

			[AliasOf("glMultiTexCoord1sv")]
			[AliasOf("glMultiTexCoord1svARB")]
			[ThreadStatic]
			internal static glMultiTexCoord1sv pglMultiTexCoord1sv;

			internal unsafe delegate void glMultiTexCoord1xOES(Int32 texture, IntPtr s);

			[ThreadStatic]
			internal static glMultiTexCoord1xOES pglMultiTexCoord1xOES;

			internal unsafe delegate void glMultiTexCoord1xvOES(Int32 texture, IntPtr* coords);

			[ThreadStatic]
			internal static glMultiTexCoord1xvOES pglMultiTexCoord1xvOES;

			internal delegate void glMultiTexCoord2bOES(Int32 texture, sbyte s, sbyte t);

			[ThreadStatic]
			internal static glMultiTexCoord2bOES pglMultiTexCoord2bOES;

			internal unsafe delegate void glMultiTexCoord2bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord2bvOES pglMultiTexCoord2bvOES;

			internal delegate void glMultiTexCoord2d(Int32 target, double s, double t);

			[AliasOf("glMultiTexCoord2d")]
			[AliasOf("glMultiTexCoord2dARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2d pglMultiTexCoord2d;

			internal unsafe delegate void glMultiTexCoord2dv(Int32 target, double* v);

			[AliasOf("glMultiTexCoord2dv")]
			[AliasOf("glMultiTexCoord2dvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2dv pglMultiTexCoord2dv;

			internal delegate void glMultiTexCoord2f(Int32 target, float s, float t);

			[AliasOf("glMultiTexCoord2f")]
			[AliasOf("glMultiTexCoord2fARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2f pglMultiTexCoord2f;

			internal unsafe delegate void glMultiTexCoord2fv(Int32 target, float* v);

			[AliasOf("glMultiTexCoord2fv")]
			[AliasOf("glMultiTexCoord2fvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2fv pglMultiTexCoord2fv;

			internal delegate void glMultiTexCoord2hNV(Int32 target, UInt16 s, UInt16 t);

			[ThreadStatic]
			internal static glMultiTexCoord2hNV pglMultiTexCoord2hNV;

			internal unsafe delegate void glMultiTexCoord2hvNV(Int32 target, UInt16* v);

			[ThreadStatic]
			internal static glMultiTexCoord2hvNV pglMultiTexCoord2hvNV;

			internal delegate void glMultiTexCoord2i(Int32 target, Int32 s, Int32 t);

			[AliasOf("glMultiTexCoord2i")]
			[AliasOf("glMultiTexCoord2iARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2i pglMultiTexCoord2i;

			internal unsafe delegate void glMultiTexCoord2iv(Int32 target, Int32* v);

			[AliasOf("glMultiTexCoord2iv")]
			[AliasOf("glMultiTexCoord2ivARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2iv pglMultiTexCoord2iv;

			internal delegate void glMultiTexCoord2s(Int32 target, Int16 s, Int16 t);

			[AliasOf("glMultiTexCoord2s")]
			[AliasOf("glMultiTexCoord2sARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2s pglMultiTexCoord2s;

			internal unsafe delegate void glMultiTexCoord2sv(Int32 target, Int16* v);

			[AliasOf("glMultiTexCoord2sv")]
			[AliasOf("glMultiTexCoord2svARB")]
			[ThreadStatic]
			internal static glMultiTexCoord2sv pglMultiTexCoord2sv;

			internal unsafe delegate void glMultiTexCoord2xOES(Int32 texture, IntPtr s, IntPtr t);

			[ThreadStatic]
			internal static glMultiTexCoord2xOES pglMultiTexCoord2xOES;

			internal unsafe delegate void glMultiTexCoord2xvOES(Int32 texture, IntPtr* coords);

			[ThreadStatic]
			internal static glMultiTexCoord2xvOES pglMultiTexCoord2xvOES;

			internal delegate void glMultiTexCoord3bOES(Int32 texture, sbyte s, sbyte t, sbyte r);

			[ThreadStatic]
			internal static glMultiTexCoord3bOES pglMultiTexCoord3bOES;

			internal unsafe delegate void glMultiTexCoord3bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord3bvOES pglMultiTexCoord3bvOES;

			internal delegate void glMultiTexCoord3d(Int32 target, double s, double t, double r);

			[AliasOf("glMultiTexCoord3d")]
			[AliasOf("glMultiTexCoord3dARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3d pglMultiTexCoord3d;

			internal unsafe delegate void glMultiTexCoord3dv(Int32 target, double* v);

			[AliasOf("glMultiTexCoord3dv")]
			[AliasOf("glMultiTexCoord3dvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3dv pglMultiTexCoord3dv;

			internal delegate void glMultiTexCoord3f(Int32 target, float s, float t, float r);

			[AliasOf("glMultiTexCoord3f")]
			[AliasOf("glMultiTexCoord3fARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3f pglMultiTexCoord3f;

			internal unsafe delegate void glMultiTexCoord3fv(Int32 target, float* v);

			[AliasOf("glMultiTexCoord3fv")]
			[AliasOf("glMultiTexCoord3fvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3fv pglMultiTexCoord3fv;

			internal delegate void glMultiTexCoord3hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r);

			[ThreadStatic]
			internal static glMultiTexCoord3hNV pglMultiTexCoord3hNV;

			internal unsafe delegate void glMultiTexCoord3hvNV(Int32 target, UInt16* v);

			[ThreadStatic]
			internal static glMultiTexCoord3hvNV pglMultiTexCoord3hvNV;

			internal delegate void glMultiTexCoord3i(Int32 target, Int32 s, Int32 t, Int32 r);

			[AliasOf("glMultiTexCoord3i")]
			[AliasOf("glMultiTexCoord3iARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3i pglMultiTexCoord3i;

			internal unsafe delegate void glMultiTexCoord3iv(Int32 target, Int32* v);

			[AliasOf("glMultiTexCoord3iv")]
			[AliasOf("glMultiTexCoord3ivARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3iv pglMultiTexCoord3iv;

			internal delegate void glMultiTexCoord3s(Int32 target, Int16 s, Int16 t, Int16 r);

			[AliasOf("glMultiTexCoord3s")]
			[AliasOf("glMultiTexCoord3sARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3s pglMultiTexCoord3s;

			internal unsafe delegate void glMultiTexCoord3sv(Int32 target, Int16* v);

			[AliasOf("glMultiTexCoord3sv")]
			[AliasOf("glMultiTexCoord3svARB")]
			[ThreadStatic]
			internal static glMultiTexCoord3sv pglMultiTexCoord3sv;

			internal unsafe delegate void glMultiTexCoord3xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r);

			[ThreadStatic]
			internal static glMultiTexCoord3xOES pglMultiTexCoord3xOES;

			internal unsafe delegate void glMultiTexCoord3xvOES(Int32 texture, IntPtr* coords);

			[ThreadStatic]
			internal static glMultiTexCoord3xvOES pglMultiTexCoord3xvOES;

			internal delegate void glMultiTexCoord4bOES(Int32 texture, sbyte s, sbyte t, sbyte r, sbyte q);

			[ThreadStatic]
			internal static glMultiTexCoord4bOES pglMultiTexCoord4bOES;

			internal unsafe delegate void glMultiTexCoord4bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord4bvOES pglMultiTexCoord4bvOES;

			internal delegate void glMultiTexCoord4d(Int32 target, double s, double t, double r, double q);

			[AliasOf("glMultiTexCoord4d")]
			[AliasOf("glMultiTexCoord4dARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4d pglMultiTexCoord4d;

			internal unsafe delegate void glMultiTexCoord4dv(Int32 target, double* v);

			[AliasOf("glMultiTexCoord4dv")]
			[AliasOf("glMultiTexCoord4dvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4dv pglMultiTexCoord4dv;

			internal delegate void glMultiTexCoord4f(Int32 target, float s, float t, float r, float q);

			[AliasOf("glMultiTexCoord4f")]
			[AliasOf("glMultiTexCoord4fARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4f pglMultiTexCoord4f;

			internal unsafe delegate void glMultiTexCoord4fv(Int32 target, float* v);

			[AliasOf("glMultiTexCoord4fv")]
			[AliasOf("glMultiTexCoord4fvARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4fv pglMultiTexCoord4fv;

			internal delegate void glMultiTexCoord4hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[ThreadStatic]
			internal static glMultiTexCoord4hNV pglMultiTexCoord4hNV;

			internal unsafe delegate void glMultiTexCoord4hvNV(Int32 target, UInt16* v);

			[ThreadStatic]
			internal static glMultiTexCoord4hvNV pglMultiTexCoord4hvNV;

			internal delegate void glMultiTexCoord4i(Int32 target, Int32 s, Int32 t, Int32 r, Int32 q);

			[AliasOf("glMultiTexCoord4i")]
			[AliasOf("glMultiTexCoord4iARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4i pglMultiTexCoord4i;

			internal unsafe delegate void glMultiTexCoord4iv(Int32 target, Int32* v);

			[AliasOf("glMultiTexCoord4iv")]
			[AliasOf("glMultiTexCoord4ivARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4iv pglMultiTexCoord4iv;

			internal delegate void glMultiTexCoord4s(Int32 target, Int16 s, Int16 t, Int16 r, Int16 q);

			[AliasOf("glMultiTexCoord4s")]
			[AliasOf("glMultiTexCoord4sARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4s pglMultiTexCoord4s;

			internal unsafe delegate void glMultiTexCoord4sv(Int32 target, Int16* v);

			[AliasOf("glMultiTexCoord4sv")]
			[AliasOf("glMultiTexCoord4svARB")]
			[ThreadStatic]
			internal static glMultiTexCoord4sv pglMultiTexCoord4sv;

			internal unsafe delegate void glMultiTexCoord4x(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[ThreadStatic]
			internal static glMultiTexCoord4x pglMultiTexCoord4x;

			internal unsafe delegate void glMultiTexCoord4xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[ThreadStatic]
			internal static glMultiTexCoord4xOES pglMultiTexCoord4xOES;

			internal unsafe delegate void glMultiTexCoord4xvOES(Int32 texture, IntPtr* coords);

			[ThreadStatic]
			internal static glMultiTexCoord4xvOES pglMultiTexCoord4xvOES;

			internal delegate void glMultiTexCoordP1ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP1ui pglMultiTexCoordP1ui;

			internal unsafe delegate void glMultiTexCoordP1uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP1uiv pglMultiTexCoordP1uiv;

			internal delegate void glMultiTexCoordP2ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP2ui pglMultiTexCoordP2ui;

			internal unsafe delegate void glMultiTexCoordP2uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP2uiv pglMultiTexCoordP2uiv;

			internal delegate void glMultiTexCoordP3ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP3ui pglMultiTexCoordP3ui;

			internal unsafe delegate void glMultiTexCoordP3uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP3uiv pglMultiTexCoordP3uiv;

			internal delegate void glMultiTexCoordP4ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP4ui pglMultiTexCoordP4ui;

			internal unsafe delegate void glMultiTexCoordP4uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP4uiv pglMultiTexCoordP4uiv;

			internal unsafe delegate void glMultiTexCoordPointerEXT(Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glMultiTexCoordPointerEXT pglMultiTexCoordPointerEXT;

			internal delegate void glMultiTexEnvfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glMultiTexEnvfEXT pglMultiTexEnvfEXT;

			internal unsafe delegate void glMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMultiTexEnvfvEXT pglMultiTexEnvfvEXT;

			internal delegate void glMultiTexEnviEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMultiTexEnviEXT pglMultiTexEnviEXT;

			internal unsafe delegate void glMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexEnvivEXT pglMultiTexEnvivEXT;

			internal delegate void glMultiTexGendEXT(Int32 texunit, Int32 coord, Int32 pname, double param);

			[ThreadStatic]
			internal static glMultiTexGendEXT pglMultiTexGendEXT;

			internal unsafe delegate void glMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glMultiTexGendvEXT pglMultiTexGendvEXT;

			internal delegate void glMultiTexGenfEXT(Int32 texunit, Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glMultiTexGenfEXT pglMultiTexGenfEXT;

			internal unsafe delegate void glMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMultiTexGenfvEXT pglMultiTexGenfvEXT;

			internal delegate void glMultiTexGeniEXT(Int32 texunit, Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMultiTexGeniEXT pglMultiTexGeniEXT;

			internal unsafe delegate void glMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexGenivEXT pglMultiTexGenivEXT;

			internal unsafe delegate void glMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexImage1DEXT pglMultiTexImage1DEXT;

			internal unsafe delegate void glMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexImage2DEXT pglMultiTexImage2DEXT;

			internal unsafe delegate void glMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexImage3DEXT pglMultiTexImage3DEXT;

			internal unsafe delegate void glMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexParameterIivEXT pglMultiTexParameterIivEXT;

			internal unsafe delegate void glMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glMultiTexParameterIuivEXT pglMultiTexParameterIuivEXT;

			internal delegate void glMultiTexParameterfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glMultiTexParameterfEXT pglMultiTexParameterfEXT;

			internal unsafe delegate void glMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMultiTexParameterfvEXT pglMultiTexParameterfvEXT;

			internal delegate void glMultiTexParameteriEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMultiTexParameteriEXT pglMultiTexParameteriEXT;

			internal unsafe delegate void glMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexParameterivEXT pglMultiTexParameterivEXT;

			internal delegate void glMultiTexRenderbufferEXT(Int32 texunit, Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glMultiTexRenderbufferEXT pglMultiTexRenderbufferEXT;

			internal unsafe delegate void glMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexSubImage1DEXT pglMultiTexSubImage1DEXT;

			internal unsafe delegate void glMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexSubImage2DEXT pglMultiTexSubImage2DEXT;

			internal unsafe delegate void glMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexSubImage3DEXT pglMultiTexSubImage3DEXT;

			internal unsafe delegate void glNamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[ThreadStatic]
			internal static glNamedBufferData pglNamedBufferData;

			internal unsafe delegate void glNamedBufferDataEXT(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[ThreadStatic]
			internal static glNamedBufferDataEXT pglNamedBufferDataEXT;

			internal unsafe delegate void glNamedBufferPageCommitmentARB(UInt32 buffer, IntPtr offset, UInt32 size, bool commit);

			[ThreadStatic]
			internal static glNamedBufferPageCommitmentARB pglNamedBufferPageCommitmentARB;

			internal unsafe delegate void glNamedBufferPageCommitmentEXT(UInt32 buffer, IntPtr offset, UInt32 size, bool commit);

			[ThreadStatic]
			internal static glNamedBufferPageCommitmentEXT pglNamedBufferPageCommitmentEXT;

			internal unsafe delegate void glNamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, UInt32 flags);

			[AliasOf("glNamedBufferStorage")]
			[AliasOf("glNamedBufferStorageEXT")]
			[ThreadStatic]
			internal static glNamedBufferStorage pglNamedBufferStorage;

			internal unsafe delegate void glNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[AliasOf("glNamedBufferSubData")]
			[AliasOf("glNamedBufferSubDataEXT")]
			[ThreadStatic]
			internal static glNamedBufferSubData pglNamedBufferSubData;

			internal unsafe delegate void glNamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[ThreadStatic]
			internal static glNamedCopyBufferSubDataEXT pglNamedCopyBufferSubDataEXT;

			internal delegate void glNamedFramebufferDrawBuffer(UInt32 framebuffer, Int32 buf);

			[ThreadStatic]
			internal static glNamedFramebufferDrawBuffer pglNamedFramebufferDrawBuffer;

			internal unsafe delegate void glNamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, Int32* bufs);

			[ThreadStatic]
			internal static glNamedFramebufferDrawBuffers pglNamedFramebufferDrawBuffers;

			internal delegate void glNamedFramebufferParameteri(UInt32 framebuffer, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glNamedFramebufferParameteri pglNamedFramebufferParameteri;

			internal delegate void glNamedFramebufferParameteriEXT(UInt32 framebuffer, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glNamedFramebufferParameteriEXT pglNamedFramebufferParameteriEXT;

			internal delegate void glNamedFramebufferReadBuffer(UInt32 framebuffer, Int32 src);

			[ThreadStatic]
			internal static glNamedFramebufferReadBuffer pglNamedFramebufferReadBuffer;

			internal delegate void glNamedFramebufferRenderbuffer(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glNamedFramebufferRenderbuffer pglNamedFramebufferRenderbuffer;

			internal delegate void glNamedFramebufferRenderbufferEXT(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glNamedFramebufferRenderbufferEXT pglNamedFramebufferRenderbufferEXT;

			internal unsafe delegate void glNamedFramebufferSampleLocationsfvARB(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvARB pglNamedFramebufferSampleLocationsfvARB;

			internal unsafe delegate void glNamedFramebufferSampleLocationsfvNV(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvNV pglNamedFramebufferSampleLocationsfvNV;

			internal delegate void glNamedFramebufferTexture(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTexture pglNamedFramebufferTexture;

			internal delegate void glNamedFramebufferTexture1DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTexture1DEXT pglNamedFramebufferTexture1DEXT;

			internal delegate void glNamedFramebufferTexture2DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTexture2DEXT pglNamedFramebufferTexture2DEXT;

			internal delegate void glNamedFramebufferTexture3DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[ThreadStatic]
			internal static glNamedFramebufferTexture3DEXT pglNamedFramebufferTexture3DEXT;

			internal delegate void glNamedFramebufferTextureEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTextureEXT pglNamedFramebufferTextureEXT;

			internal delegate void glNamedFramebufferTextureFaceEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[ThreadStatic]
			internal static glNamedFramebufferTextureFaceEXT pglNamedFramebufferTextureFaceEXT;

			internal delegate void glNamedFramebufferTextureLayer(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[ThreadStatic]
			internal static glNamedFramebufferTextureLayer pglNamedFramebufferTextureLayer;

			internal delegate void glNamedFramebufferTextureLayerEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[ThreadStatic]
			internal static glNamedFramebufferTextureLayerEXT pglNamedFramebufferTextureLayerEXT;

			internal delegate void glNamedProgramLocalParameter4dEXT(UInt32 program, Int32 target, UInt32 index, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4dEXT pglNamedProgramLocalParameter4dEXT;

			internal unsafe delegate void glNamedProgramLocalParameter4dvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4dvEXT pglNamedProgramLocalParameter4dvEXT;

			internal delegate void glNamedProgramLocalParameter4fEXT(UInt32 program, Int32 target, UInt32 index, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4fEXT pglNamedProgramLocalParameter4fEXT;

			internal unsafe delegate void glNamedProgramLocalParameter4fvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4fvEXT pglNamedProgramLocalParameter4fvEXT;

			internal delegate void glNamedProgramLocalParameterI4iEXT(UInt32 program, Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4iEXT pglNamedProgramLocalParameterI4iEXT;

			internal unsafe delegate void glNamedProgramLocalParameterI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4ivEXT pglNamedProgramLocalParameterI4ivEXT;

			internal delegate void glNamedProgramLocalParameterI4uiEXT(UInt32 program, Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4uiEXT pglNamedProgramLocalParameterI4uiEXT;

			internal unsafe delegate void glNamedProgramLocalParameterI4uivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4uivEXT pglNamedProgramLocalParameterI4uivEXT;

			internal unsafe delegate void glNamedProgramLocalParameters4fvEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, float* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameters4fvEXT pglNamedProgramLocalParameters4fvEXT;

			internal unsafe delegate void glNamedProgramLocalParametersI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParametersI4ivEXT pglNamedProgramLocalParametersI4ivEXT;

			internal unsafe delegate void glNamedProgramLocalParametersI4uivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParametersI4uivEXT pglNamedProgramLocalParametersI4uivEXT;

			internal unsafe delegate void glNamedProgramStringEXT(UInt32 program, Int32 target, Int32 format, Int32 len, IntPtr @string);

			[ThreadStatic]
			internal static glNamedProgramStringEXT pglNamedProgramStringEXT;

			internal delegate void glNamedRenderbufferStorage(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorage pglNamedRenderbufferStorage;

			internal delegate void glNamedRenderbufferStorageEXT(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageEXT pglNamedRenderbufferStorageEXT;

			internal delegate void glNamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisample pglNamedRenderbufferStorageMultisample;

			internal delegate void glNamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisampleCoverageEXT pglNamedRenderbufferStorageMultisampleCoverageEXT;

			internal delegate void glNamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisampleEXT pglNamedRenderbufferStorageMultisampleEXT;

			internal delegate void glNamedStringARB(Int32 type, Int32 namelen, String name, Int32 stringlen, String @string);

			[ThreadStatic]
			internal static glNamedStringARB pglNamedStringARB;

			internal delegate void glNewList(UInt32 list, Int32 mode);

			[ThreadStatic]
			internal static glNewList pglNewList;

			internal unsafe delegate UInt32 glNewObjectBufferATI(Int32 size, IntPtr pointer, Int32 usage);

			[ThreadStatic]
			internal static glNewObjectBufferATI pglNewObjectBufferATI;

			internal delegate void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

			[ThreadStatic]
			internal static glNormal3b pglNormal3b;

			internal unsafe delegate void glNormal3bv(sbyte* v);

			[ThreadStatic]
			internal static glNormal3bv pglNormal3bv;

			internal delegate void glNormal3d(double nx, double ny, double nz);

			[ThreadStatic]
			internal static glNormal3d pglNormal3d;

			internal unsafe delegate void glNormal3dv(double* v);

			[ThreadStatic]
			internal static glNormal3dv pglNormal3dv;

			internal delegate void glNormal3f(float nx, float ny, float nz);

			[ThreadStatic]
			internal static glNormal3f pglNormal3f;

			internal delegate void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glNormal3fVertex3fSUN pglNormal3fVertex3fSUN;

			internal unsafe delegate void glNormal3fVertex3fvSUN(float* n, float* v);

			[ThreadStatic]
			internal static glNormal3fVertex3fvSUN pglNormal3fVertex3fvSUN;

			internal unsafe delegate void glNormal3fv(float* v);

			[ThreadStatic]
			internal static glNormal3fv pglNormal3fv;

			internal delegate void glNormal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);

			[ThreadStatic]
			internal static glNormal3hNV pglNormal3hNV;

			internal unsafe delegate void glNormal3hvNV(UInt16* v);

			[ThreadStatic]
			internal static glNormal3hvNV pglNormal3hvNV;

			internal delegate void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

			[ThreadStatic]
			internal static glNormal3i pglNormal3i;

			internal unsafe delegate void glNormal3iv(Int32* v);

			[ThreadStatic]
			internal static glNormal3iv pglNormal3iv;

			internal delegate void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

			[ThreadStatic]
			internal static glNormal3s pglNormal3s;

			internal unsafe delegate void glNormal3sv(Int16* v);

			[ThreadStatic]
			internal static glNormal3sv pglNormal3sv;

			internal unsafe delegate void glNormal3x(IntPtr nx, IntPtr ny, IntPtr nz);

			[ThreadStatic]
			internal static glNormal3x pglNormal3x;

			internal unsafe delegate void glNormal3xOES(IntPtr nx, IntPtr ny, IntPtr nz);

			[ThreadStatic]
			internal static glNormal3xOES pglNormal3xOES;

			internal unsafe delegate void glNormal3xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glNormal3xvOES pglNormal3xvOES;

			internal delegate void glNormalFormatNV(Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glNormalFormatNV pglNormalFormatNV;

			internal delegate void glNormalP3ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glNormalP3ui pglNormalP3ui;

			internal unsafe delegate void glNormalP3uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glNormalP3uiv pglNormalP3uiv;

			internal unsafe delegate void glNormalPointer(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glNormalPointer pglNormalPointer;

			internal unsafe delegate void glNormalPointerEXT(Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[ThreadStatic]
			internal static glNormalPointerEXT pglNormalPointerEXT;

			internal unsafe delegate void glNormalPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glNormalPointerListIBM pglNormalPointerListIBM;

			internal unsafe delegate void glNormalPointervINTEL(Int32 type, IntPtr* pointer);

			[ThreadStatic]
			internal static glNormalPointervINTEL pglNormalPointervINTEL;

			internal delegate void glNormalStream3bATI(Int32 stream, sbyte nx, sbyte ny, sbyte nz);

			[ThreadStatic]
			internal static glNormalStream3bATI pglNormalStream3bATI;

			internal unsafe delegate void glNormalStream3bvATI(Int32 stream, sbyte* coords);

			[ThreadStatic]
			internal static glNormalStream3bvATI pglNormalStream3bvATI;

			internal delegate void glNormalStream3dATI(Int32 stream, double nx, double ny, double nz);

			[ThreadStatic]
			internal static glNormalStream3dATI pglNormalStream3dATI;

			internal unsafe delegate void glNormalStream3dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glNormalStream3dvATI pglNormalStream3dvATI;

			internal delegate void glNormalStream3fATI(Int32 stream, float nx, float ny, float nz);

			[ThreadStatic]
			internal static glNormalStream3fATI pglNormalStream3fATI;

			internal unsafe delegate void glNormalStream3fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glNormalStream3fvATI pglNormalStream3fvATI;

			internal delegate void glNormalStream3iATI(Int32 stream, Int32 nx, Int32 ny, Int32 nz);

			[ThreadStatic]
			internal static glNormalStream3iATI pglNormalStream3iATI;

			internal unsafe delegate void glNormalStream3ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glNormalStream3ivATI pglNormalStream3ivATI;

			internal delegate void glNormalStream3sATI(Int32 stream, Int16 nx, Int16 ny, Int16 nz);

			[ThreadStatic]
			internal static glNormalStream3sATI pglNormalStream3sATI;

			internal unsafe delegate void glNormalStream3svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glNormalStream3svATI pglNormalStream3svATI;

			internal delegate void glObjectLabel(Int32 identifier, UInt32 name, Int32 length, String label);

			[AliasOf("glObjectLabel")]
			[AliasOf("glObjectLabelKHR")]
			[ThreadStatic]
			internal static glObjectLabel pglObjectLabel;

			internal unsafe delegate void glObjectPtrLabel(IntPtr ptr, Int32 length, String label);

			[AliasOf("glObjectPtrLabel")]
			[AliasOf("glObjectPtrLabelKHR")]
			[ThreadStatic]
			internal static glObjectPtrLabel pglObjectPtrLabel;

			internal delegate Int32 glObjectPurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			[ThreadStatic]
			internal static glObjectPurgeableAPPLE pglObjectPurgeableAPPLE;

			internal delegate Int32 glObjectUnpurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			[ThreadStatic]
			internal static glObjectUnpurgeableAPPLE pglObjectUnpurgeableAPPLE;

			internal delegate void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glOrtho pglOrtho;

			internal delegate void glOrthof(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glOrthof pglOrthof;

			internal delegate void glOrthofOES(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glOrthofOES pglOrthofOES;

			internal unsafe delegate void glOrthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glOrthox pglOrthox;

			internal unsafe delegate void glOrthoxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glOrthoxOES pglOrthoxOES;

			internal delegate void glPNTrianglesfATI(Int32 pname, float param);

			[ThreadStatic]
			internal static glPNTrianglesfATI pglPNTrianglesfATI;

			internal delegate void glPNTrianglesiATI(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPNTrianglesiATI pglPNTrianglesiATI;

			internal delegate void glPassTexCoordATI(UInt32 dst, UInt32 coord, Int32 swizzle);

			[ThreadStatic]
			internal static glPassTexCoordATI pglPassTexCoordATI;

			internal delegate void glPassThrough(float token);

			[ThreadStatic]
			internal static glPassThrough pglPassThrough;

			internal unsafe delegate void glPassThroughxOES(IntPtr token);

			[ThreadStatic]
			internal static glPassThroughxOES pglPassThroughxOES;

			internal unsafe delegate void glPatchParameterfv(Int32 pname, float* values);

			[ThreadStatic]
			internal static glPatchParameterfv pglPatchParameterfv;

			internal delegate void glPatchParameteri(Int32 pname, Int32 value);

			[AliasOf("glPatchParameteri")]
			[AliasOf("glPatchParameteriEXT")]
			[AliasOf("glPatchParameteriOES")]
			[ThreadStatic]
			internal static glPatchParameteri pglPatchParameteri;

			internal unsafe delegate void glPathColorGenNV(Int32 color, Int32 genMode, Int32 colorFormat, float* coeffs);

			[ThreadStatic]
			internal static glPathColorGenNV pglPathColorGenNV;

			internal unsafe delegate void glPathCommandsNV(UInt32 path, Int32 numCommands, byte* commands, Int32 numCoords, Int32 coordType, IntPtr coords);

			[ThreadStatic]
			internal static glPathCommandsNV pglPathCommandsNV;

			internal unsafe delegate void glPathCoordsNV(UInt32 path, Int32 numCoords, Int32 coordType, IntPtr coords);

			[ThreadStatic]
			internal static glPathCoordsNV pglPathCoordsNV;

			internal delegate void glPathCoverDepthFuncNV(Int32 func);

			[ThreadStatic]
			internal static glPathCoverDepthFuncNV pglPathCoverDepthFuncNV;

			internal unsafe delegate void glPathDashArrayNV(UInt32 path, Int32 dashCount, float* dashArray);

			[ThreadStatic]
			internal static glPathDashArrayNV pglPathDashArrayNV;

			internal delegate void glPathFogGenNV(Int32 genMode);

			[ThreadStatic]
			internal static glPathFogGenNV pglPathFogGenNV;

			internal unsafe delegate Int32 glPathGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale);

			[ThreadStatic]
			internal static glPathGlyphIndexArrayNV pglPathGlyphIndexArrayNV;

			internal unsafe delegate Int32 glPathGlyphIndexRangeNV(Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32* baseAndCount);

			[ThreadStatic]
			internal static glPathGlyphIndexRangeNV pglPathGlyphIndexRangeNV;

			internal unsafe delegate void glPathGlyphRangeNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 firstGlyph, Int32 numGlyphs, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale);

			[ThreadStatic]
			internal static glPathGlyphRangeNV pglPathGlyphRangeNV;

			internal unsafe delegate void glPathGlyphsNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, Int32 numGlyphs, Int32 type, IntPtr charcodes, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale);

			[ThreadStatic]
			internal static glPathGlyphsNV pglPathGlyphsNV;

			internal unsafe delegate Int32 glPathMemoryGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, UInt32 fontSize, IntPtr fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale);

			[ThreadStatic]
			internal static glPathMemoryGlyphIndexArrayNV pglPathMemoryGlyphIndexArrayNV;

			internal delegate void glPathParameterfNV(UInt32 path, Int32 pname, float value);

			[ThreadStatic]
			internal static glPathParameterfNV pglPathParameterfNV;

			internal unsafe delegate void glPathParameterfvNV(UInt32 path, Int32 pname, float* value);

			[ThreadStatic]
			internal static glPathParameterfvNV pglPathParameterfvNV;

			internal delegate void glPathParameteriNV(UInt32 path, Int32 pname, Int32 value);

			[ThreadStatic]
			internal static glPathParameteriNV pglPathParameteriNV;

			internal unsafe delegate void glPathParameterivNV(UInt32 path, Int32 pname, Int32* value);

			[ThreadStatic]
			internal static glPathParameterivNV pglPathParameterivNV;

			internal delegate void glPathStencilDepthOffsetNV(float factor, float units);

			[ThreadStatic]
			internal static glPathStencilDepthOffsetNV pglPathStencilDepthOffsetNV;

			internal delegate void glPathStencilFuncNV(Int32 func, Int32 @ref, UInt32 mask);

			[ThreadStatic]
			internal static glPathStencilFuncNV pglPathStencilFuncNV;

			internal unsafe delegate void glPathStringNV(UInt32 path, Int32 format, Int32 length, IntPtr pathString);

			[ThreadStatic]
			internal static glPathStringNV pglPathStringNV;

			internal unsafe delegate void glPathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, Int32 numCommands, byte* commands, Int32 numCoords, Int32 coordType, IntPtr coords);

			[ThreadStatic]
			internal static glPathSubCommandsNV pglPathSubCommandsNV;

			internal unsafe delegate void glPathSubCoordsNV(UInt32 path, Int32 coordStart, Int32 numCoords, Int32 coordType, IntPtr coords);

			[ThreadStatic]
			internal static glPathSubCoordsNV pglPathSubCoordsNV;

			internal unsafe delegate void glPathTexGenNV(Int32 texCoordSet, Int32 genMode, Int32 components, float* coeffs);

			[ThreadStatic]
			internal static glPathTexGenNV pglPathTexGenNV;

			internal delegate void glPauseTransformFeedback();

			[AliasOf("glPauseTransformFeedback")]
			[AliasOf("glPauseTransformFeedbackNV")]
			[ThreadStatic]
			internal static glPauseTransformFeedback pglPauseTransformFeedback;

			internal unsafe delegate void glPixelDataRangeNV(Int32 target, Int32 length, IntPtr pointer);

			[ThreadStatic]
			internal static glPixelDataRangeNV pglPixelDataRangeNV;

			internal unsafe delegate void glPixelMapfv(Int32 map, Int32 mapsize, float* values);

			[ThreadStatic]
			internal static glPixelMapfv pglPixelMapfv;

			internal unsafe delegate void glPixelMapuiv(Int32 map, Int32 mapsize, UInt32* values);

			[ThreadStatic]
			internal static glPixelMapuiv pglPixelMapuiv;

			internal unsafe delegate void glPixelMapusv(Int32 map, Int32 mapsize, UInt16* values);

			[ThreadStatic]
			internal static glPixelMapusv pglPixelMapusv;

			internal unsafe delegate void glPixelMapx(Int32 map, Int32 size, IntPtr* values);

			[ThreadStatic]
			internal static glPixelMapx pglPixelMapx;

			internal delegate void glPixelStoref(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelStoref pglPixelStoref;

			internal delegate void glPixelStorei(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelStorei pglPixelStorei;

			internal unsafe delegate void glPixelStorex(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glPixelStorex pglPixelStorex;

			internal delegate void glPixelTexGenParameterfSGIS(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelTexGenParameterfSGIS pglPixelTexGenParameterfSGIS;

			internal unsafe delegate void glPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glPixelTexGenParameterfvSGIS pglPixelTexGenParameterfvSGIS;

			internal delegate void glPixelTexGenParameteriSGIS(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelTexGenParameteriSGIS pglPixelTexGenParameteriSGIS;

			internal unsafe delegate void glPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glPixelTexGenParameterivSGIS pglPixelTexGenParameterivSGIS;

			internal delegate void glPixelTexGenSGIX(Int32 mode);

			[ThreadStatic]
			internal static glPixelTexGenSGIX pglPixelTexGenSGIX;

			internal delegate void glPixelTransferf(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelTransferf pglPixelTransferf;

			internal delegate void glPixelTransferi(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelTransferi pglPixelTransferi;

			internal unsafe delegate void glPixelTransferxOES(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glPixelTransferxOES pglPixelTransferxOES;

			internal delegate void glPixelTransformParameterfEXT(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelTransformParameterfEXT pglPixelTransformParameterfEXT;

			internal unsafe delegate void glPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glPixelTransformParameterfvEXT pglPixelTransformParameterfvEXT;

			internal delegate void glPixelTransformParameteriEXT(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelTransformParameteriEXT pglPixelTransformParameteriEXT;

			internal unsafe delegate void glPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glPixelTransformParameterivEXT pglPixelTransformParameterivEXT;

			internal delegate void glPixelZoom(float xfactor, float yfactor);

			[ThreadStatic]
			internal static glPixelZoom pglPixelZoom;

			internal unsafe delegate void glPixelZoomxOES(IntPtr xfactor, IntPtr yfactor);

			[ThreadStatic]
			internal static glPixelZoomxOES pglPixelZoomxOES;

			internal unsafe delegate bool glPointAlongPathNV(UInt32 path, Int32 startSegment, Int32 numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY);

			[ThreadStatic]
			internal static glPointAlongPathNV pglPointAlongPathNV;

			internal delegate void glPointParameterf(Int32 pname, float param);

			[AliasOf("glPointParameterf")]
			[AliasOf("glPointParameterfARB")]
			[AliasOf("glPointParameterfEXT")]
			[AliasOf("glPointParameterfSGIS")]
			[ThreadStatic]
			internal static glPointParameterf pglPointParameterf;

			internal unsafe delegate void glPointParameterfv(Int32 pname, float* @params);

			[AliasOf("glPointParameterfv")]
			[AliasOf("glPointParameterfvARB")]
			[AliasOf("glPointParameterfvEXT")]
			[AliasOf("glPointParameterfvSGIS")]
			[ThreadStatic]
			internal static glPointParameterfv pglPointParameterfv;

			internal delegate void glPointParameteri(Int32 pname, Int32 param);

			[AliasOf("glPointParameteri")]
			[AliasOf("glPointParameteriNV")]
			[ThreadStatic]
			internal static glPointParameteri pglPointParameteri;

			internal unsafe delegate void glPointParameteriv(Int32 pname, Int32* @params);

			[AliasOf("glPointParameteriv")]
			[AliasOf("glPointParameterivNV")]
			[ThreadStatic]
			internal static glPointParameteriv pglPointParameteriv;

			internal unsafe delegate void glPointParameterx(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glPointParameterx pglPointParameterx;

			internal unsafe delegate void glPointParameterxOES(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glPointParameterxOES pglPointParameterxOES;

			internal unsafe delegate void glPointParameterxv(Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glPointParameterxv pglPointParameterxv;

			internal unsafe delegate void glPointParameterxvOES(Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glPointParameterxvOES pglPointParameterxvOES;

			internal delegate void glPointSize(float size);

			[ThreadStatic]
			internal static glPointSize pglPointSize;

			internal unsafe delegate void glPointSizePointerOES(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glPointSizePointerOES pglPointSizePointerOES;

			internal unsafe delegate void glPointSizex(IntPtr size);

			[ThreadStatic]
			internal static glPointSizex pglPointSizex;

			internal unsafe delegate void glPointSizexOES(IntPtr size);

			[ThreadStatic]
			internal static glPointSizexOES pglPointSizexOES;

			internal unsafe delegate Int32 glPollAsyncSGIX(UInt32* markerp);

			[ThreadStatic]
			internal static glPollAsyncSGIX pglPollAsyncSGIX;

			internal unsafe delegate Int32 glPollInstrumentsSGIX(Int32* marker_p);

			[ThreadStatic]
			internal static glPollInstrumentsSGIX pglPollInstrumentsSGIX;

			internal delegate void glPolygonMode(Int32 face, Int32 mode);

			[AliasOf("glPolygonMode")]
			[AliasOf("glPolygonModeNV")]
			[ThreadStatic]
			internal static glPolygonMode pglPolygonMode;

			internal delegate void glPolygonOffset(float factor, float units);

			[ThreadStatic]
			internal static glPolygonOffset pglPolygonOffset;

			internal delegate void glPolygonOffsetClampEXT(float factor, float units, float clamp);

			[ThreadStatic]
			internal static glPolygonOffsetClampEXT pglPolygonOffsetClampEXT;

			internal delegate void glPolygonOffsetEXT(float factor, float bias);

			[ThreadStatic]
			internal static glPolygonOffsetEXT pglPolygonOffsetEXT;

			internal unsafe delegate void glPolygonOffsetx(IntPtr factor, IntPtr units);

			[ThreadStatic]
			internal static glPolygonOffsetx pglPolygonOffsetx;

			internal unsafe delegate void glPolygonOffsetxOES(IntPtr factor, IntPtr units);

			[ThreadStatic]
			internal static glPolygonOffsetxOES pglPolygonOffsetxOES;

			internal unsafe delegate void glPolygonStipple(byte* mask);

			[ThreadStatic]
			internal static glPolygonStipple pglPolygonStipple;

			internal delegate void glPopAttrib();

			[ThreadStatic]
			internal static glPopAttrib pglPopAttrib;

			internal delegate void glPopClientAttrib();

			[ThreadStatic]
			internal static glPopClientAttrib pglPopClientAttrib;

			internal delegate void glPopDebugGroup();

			[AliasOf("glPopDebugGroup")]
			[AliasOf("glPopDebugGroupKHR")]
			[ThreadStatic]
			internal static glPopDebugGroup pglPopDebugGroup;

			internal delegate void glPopGroupMarkerEXT();

			[ThreadStatic]
			internal static glPopGroupMarkerEXT pglPopGroupMarkerEXT;

			internal delegate void glPopMatrix();

			[ThreadStatic]
			internal static glPopMatrix pglPopMatrix;

			internal delegate void glPopName();

			[ThreadStatic]
			internal static glPopName pglPopName;

			internal delegate void glPresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, Int32 target1, UInt32 fill1, Int32 target2, UInt32 fill2, Int32 target3, UInt32 fill3);

			[ThreadStatic]
			internal static glPresentFrameDualFillNV pglPresentFrameDualFillNV;

			internal delegate void glPresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, UInt32 key0, Int32 target1, UInt32 fill1, UInt32 key1);

			[ThreadStatic]
			internal static glPresentFrameKeyedNV pglPresentFrameKeyedNV;

			internal delegate void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

			[AliasOf("glPrimitiveBoundingBox")]
			[AliasOf("glPrimitiveBoundingBoxARB")]
			[AliasOf("glPrimitiveBoundingBoxEXT")]
			[AliasOf("glPrimitiveBoundingBoxOES")]
			[ThreadStatic]
			internal static glPrimitiveBoundingBox pglPrimitiveBoundingBox;

			internal delegate void glPrimitiveRestartIndex(UInt32 index);

			[ThreadStatic]
			internal static glPrimitiveRestartIndex pglPrimitiveRestartIndex;

			internal delegate void glPrimitiveRestartIndexNV(UInt32 index);

			[ThreadStatic]
			internal static glPrimitiveRestartIndexNV pglPrimitiveRestartIndexNV;

			internal delegate void glPrimitiveRestartNV();

			[ThreadStatic]
			internal static glPrimitiveRestartNV pglPrimitiveRestartNV;

			internal unsafe delegate void glPrioritizeTextures(Int32 n, UInt32* textures, float* priorities);

			[AliasOf("glPrioritizeTextures")]
			[AliasOf("glPrioritizeTexturesEXT")]
			[ThreadStatic]
			internal static glPrioritizeTextures pglPrioritizeTextures;

			internal unsafe delegate void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, IntPtr* priorities);

			[ThreadStatic]
			internal static glPrioritizeTexturesxOES pglPrioritizeTexturesxOES;

			internal unsafe delegate void glProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

			[AliasOf("glProgramBinary")]
			[AliasOf("glProgramBinaryOES")]
			[ThreadStatic]
			internal static glProgramBinary pglProgramBinary;

			internal unsafe delegate void glProgramBufferParametersIivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glProgramBufferParametersIivNV pglProgramBufferParametersIivNV;

			internal unsafe delegate void glProgramBufferParametersIuivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glProgramBufferParametersIuivNV pglProgramBufferParametersIuivNV;

			internal unsafe delegate void glProgramBufferParametersfvNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, float* @params);

			[ThreadStatic]
			internal static glProgramBufferParametersfvNV pglProgramBufferParametersfvNV;

			internal delegate void glProgramEnvParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glProgramEnvParameter4dARB pglProgramEnvParameter4dARB;

			internal unsafe delegate void glProgramEnvParameter4dvARB(Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glProgramEnvParameter4dvARB pglProgramEnvParameter4dvARB;

			internal delegate void glProgramEnvParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glProgramEnvParameter4fARB pglProgramEnvParameter4fARB;

			internal unsafe delegate void glProgramEnvParameter4fvARB(Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glProgramEnvParameter4fvARB pglProgramEnvParameter4fvARB;

			internal delegate void glProgramEnvParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glProgramEnvParameterI4iNV pglProgramEnvParameterI4iNV;

			internal unsafe delegate void glProgramEnvParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glProgramEnvParameterI4ivNV pglProgramEnvParameterI4ivNV;

			internal delegate void glProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[ThreadStatic]
			internal static glProgramEnvParameterI4uiNV pglProgramEnvParameterI4uiNV;

			internal unsafe delegate void glProgramEnvParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glProgramEnvParameterI4uivNV pglProgramEnvParameterI4uivNV;

			internal unsafe delegate void glProgramEnvParameters4fvEXT(Int32 target, UInt32 index, Int32 count, float* @params);

			[ThreadStatic]
			internal static glProgramEnvParameters4fvEXT pglProgramEnvParameters4fvEXT;

			internal unsafe delegate void glProgramEnvParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glProgramEnvParametersI4ivNV pglProgramEnvParametersI4ivNV;

			internal unsafe delegate void glProgramEnvParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glProgramEnvParametersI4uivNV pglProgramEnvParametersI4uivNV;

			internal delegate void glProgramLocalParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glProgramLocalParameter4dARB pglProgramLocalParameter4dARB;

			internal unsafe delegate void glProgramLocalParameter4dvARB(Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glProgramLocalParameter4dvARB pglProgramLocalParameter4dvARB;

			internal delegate void glProgramLocalParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glProgramLocalParameter4fARB pglProgramLocalParameter4fARB;

			internal unsafe delegate void glProgramLocalParameter4fvARB(Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glProgramLocalParameter4fvARB pglProgramLocalParameter4fvARB;

			internal delegate void glProgramLocalParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glProgramLocalParameterI4iNV pglProgramLocalParameterI4iNV;

			internal unsafe delegate void glProgramLocalParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glProgramLocalParameterI4ivNV pglProgramLocalParameterI4ivNV;

			internal delegate void glProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[ThreadStatic]
			internal static glProgramLocalParameterI4uiNV pglProgramLocalParameterI4uiNV;

			internal unsafe delegate void glProgramLocalParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glProgramLocalParameterI4uivNV pglProgramLocalParameterI4uivNV;

			internal unsafe delegate void glProgramLocalParameters4fvEXT(Int32 target, UInt32 index, Int32 count, float* @params);

			[ThreadStatic]
			internal static glProgramLocalParameters4fvEXT pglProgramLocalParameters4fvEXT;

			internal unsafe delegate void glProgramLocalParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glProgramLocalParametersI4ivNV pglProgramLocalParametersI4ivNV;

			internal unsafe delegate void glProgramLocalParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glProgramLocalParametersI4uivNV pglProgramLocalParametersI4uivNV;

			internal unsafe delegate void glProgramNamedParameter4dNV(UInt32 id, Int32 len, byte* name, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glProgramNamedParameter4dNV pglProgramNamedParameter4dNV;

			internal unsafe delegate void glProgramNamedParameter4dvNV(UInt32 id, Int32 len, byte* name, double* v);

			[ThreadStatic]
			internal static glProgramNamedParameter4dvNV pglProgramNamedParameter4dvNV;

			internal unsafe delegate void glProgramNamedParameter4fNV(UInt32 id, Int32 len, byte* name, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glProgramNamedParameter4fNV pglProgramNamedParameter4fNV;

			internal unsafe delegate void glProgramNamedParameter4fvNV(UInt32 id, Int32 len, byte* name, float* v);

			[ThreadStatic]
			internal static glProgramNamedParameter4fvNV pglProgramNamedParameter4fvNV;

			internal delegate void glProgramParameter4dNV(Int32 target, UInt32 index, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glProgramParameter4dNV pglProgramParameter4dNV;

			internal unsafe delegate void glProgramParameter4dvNV(Int32 target, UInt32 index, double* v);

			[ThreadStatic]
			internal static glProgramParameter4dvNV pglProgramParameter4dvNV;

			internal delegate void glProgramParameter4fNV(Int32 target, UInt32 index, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glProgramParameter4fNV pglProgramParameter4fNV;

			internal unsafe delegate void glProgramParameter4fvNV(Int32 target, UInt32 index, float* v);

			[ThreadStatic]
			internal static glProgramParameter4fvNV pglProgramParameter4fvNV;

			internal delegate void glProgramParameteri(UInt32 program, Int32 pname, Int32 value);

			[AliasOf("glProgramParameteri")]
			[AliasOf("glProgramParameteriARB")]
			[AliasOf("glProgramParameteriEXT")]
			[ThreadStatic]
			internal static glProgramParameteri pglProgramParameteri;

			internal unsafe delegate void glProgramParameters4dvNV(Int32 target, UInt32 index, Int32 count, double* v);

			[ThreadStatic]
			internal static glProgramParameters4dvNV pglProgramParameters4dvNV;

			internal unsafe delegate void glProgramParameters4fvNV(Int32 target, UInt32 index, Int32 count, float* v);

			[ThreadStatic]
			internal static glProgramParameters4fvNV pglProgramParameters4fvNV;

			internal unsafe delegate void glProgramPathFragmentInputGenNV(UInt32 program, Int32 location, Int32 genMode, Int32 components, float* coeffs);

			[ThreadStatic]
			internal static glProgramPathFragmentInputGenNV pglProgramPathFragmentInputGenNV;

			internal unsafe delegate void glProgramStringARB(Int32 target, Int32 format, Int32 len, IntPtr @string);

			[ThreadStatic]
			internal static glProgramStringARB pglProgramStringARB;

			internal unsafe delegate void glProgramSubroutineParametersuivNV(Int32 target, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glProgramSubroutineParametersuivNV pglProgramSubroutineParametersuivNV;

			internal delegate void glProgramUniform1d(UInt32 program, Int32 location, double v0);

			[ThreadStatic]
			internal static glProgramUniform1d pglProgramUniform1d;

			internal delegate void glProgramUniform1dEXT(UInt32 program, Int32 location, double x);

			[ThreadStatic]
			internal static glProgramUniform1dEXT pglProgramUniform1dEXT;

			internal unsafe delegate void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform1dv pglProgramUniform1dv;

			internal unsafe delegate void glProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform1dvEXT pglProgramUniform1dvEXT;

			internal delegate void glProgramUniform1f(UInt32 program, Int32 location, float v0);

			[AliasOf("glProgramUniform1f")]
			[AliasOf("glProgramUniform1fEXT")]
			[ThreadStatic]
			internal static glProgramUniform1f pglProgramUniform1f;

			internal unsafe delegate void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform1fv")]
			[AliasOf("glProgramUniform1fvEXT")]
			[ThreadStatic]
			internal static glProgramUniform1fv pglProgramUniform1fv;

			internal delegate void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

			[AliasOf("glProgramUniform1i")]
			[AliasOf("glProgramUniform1iEXT")]
			[ThreadStatic]
			internal static glProgramUniform1i pglProgramUniform1i;

			internal delegate void glProgramUniform1i64ARB(UInt32 program, Int32 location, Int64 x);

			[ThreadStatic]
			internal static glProgramUniform1i64ARB pglProgramUniform1i64ARB;

			internal delegate void glProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);

			[ThreadStatic]
			internal static glProgramUniform1i64NV pglProgramUniform1i64NV;

			internal unsafe delegate void glProgramUniform1i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform1i64vARB pglProgramUniform1i64vARB;

			internal unsafe delegate void glProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform1i64vNV pglProgramUniform1i64vNV;

			internal unsafe delegate void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform1iv")]
			[AliasOf("glProgramUniform1ivEXT")]
			[ThreadStatic]
			internal static glProgramUniform1iv pglProgramUniform1iv;

			internal delegate void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

			[AliasOf("glProgramUniform1ui")]
			[AliasOf("glProgramUniform1uiEXT")]
			[ThreadStatic]
			internal static glProgramUniform1ui pglProgramUniform1ui;

			internal delegate void glProgramUniform1ui64ARB(UInt32 program, Int32 location, UInt64 x);

			[ThreadStatic]
			internal static glProgramUniform1ui64ARB pglProgramUniform1ui64ARB;

			internal delegate void glProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);

			[ThreadStatic]
			internal static glProgramUniform1ui64NV pglProgramUniform1ui64NV;

			internal unsafe delegate void glProgramUniform1ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform1ui64vARB pglProgramUniform1ui64vARB;

			internal unsafe delegate void glProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform1ui64vNV pglProgramUniform1ui64vNV;

			internal unsafe delegate void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform1uiv")]
			[AliasOf("glProgramUniform1uivEXT")]
			[ThreadStatic]
			internal static glProgramUniform1uiv pglProgramUniform1uiv;

			internal delegate void glProgramUniform2d(UInt32 program, Int32 location, double v0, double v1);

			[ThreadStatic]
			internal static glProgramUniform2d pglProgramUniform2d;

			internal delegate void glProgramUniform2dEXT(UInt32 program, Int32 location, double x, double y);

			[ThreadStatic]
			internal static glProgramUniform2dEXT pglProgramUniform2dEXT;

			internal unsafe delegate void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform2dv pglProgramUniform2dv;

			internal unsafe delegate void glProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform2dvEXT pglProgramUniform2dvEXT;

			internal delegate void glProgramUniform2f(UInt32 program, Int32 location, float v0, float v1);

			[AliasOf("glProgramUniform2f")]
			[AliasOf("glProgramUniform2fEXT")]
			[ThreadStatic]
			internal static glProgramUniform2f pglProgramUniform2f;

			internal unsafe delegate void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform2fv")]
			[AliasOf("glProgramUniform2fvEXT")]
			[ThreadStatic]
			internal static glProgramUniform2fv pglProgramUniform2fv;

			internal delegate void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

			[AliasOf("glProgramUniform2i")]
			[AliasOf("glProgramUniform2iEXT")]
			[ThreadStatic]
			internal static glProgramUniform2i pglProgramUniform2i;

			internal delegate void glProgramUniform2i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y);

			[ThreadStatic]
			internal static glProgramUniform2i64ARB pglProgramUniform2i64ARB;

			internal delegate void glProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);

			[ThreadStatic]
			internal static glProgramUniform2i64NV pglProgramUniform2i64NV;

			internal unsafe delegate void glProgramUniform2i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform2i64vARB pglProgramUniform2i64vARB;

			internal unsafe delegate void glProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform2i64vNV pglProgramUniform2i64vNV;

			internal unsafe delegate void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform2iv")]
			[AliasOf("glProgramUniform2ivEXT")]
			[ThreadStatic]
			internal static glProgramUniform2iv pglProgramUniform2iv;

			internal delegate void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);

			[AliasOf("glProgramUniform2ui")]
			[AliasOf("glProgramUniform2uiEXT")]
			[ThreadStatic]
			internal static glProgramUniform2ui pglProgramUniform2ui;

			internal delegate void glProgramUniform2ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[ThreadStatic]
			internal static glProgramUniform2ui64ARB pglProgramUniform2ui64ARB;

			internal delegate void glProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[ThreadStatic]
			internal static glProgramUniform2ui64NV pglProgramUniform2ui64NV;

			internal unsafe delegate void glProgramUniform2ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform2ui64vARB pglProgramUniform2ui64vARB;

			internal unsafe delegate void glProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform2ui64vNV pglProgramUniform2ui64vNV;

			internal unsafe delegate void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform2uiv")]
			[AliasOf("glProgramUniform2uivEXT")]
			[ThreadStatic]
			internal static glProgramUniform2uiv pglProgramUniform2uiv;

			internal delegate void glProgramUniform3d(UInt32 program, Int32 location, double v0, double v1, double v2);

			[ThreadStatic]
			internal static glProgramUniform3d pglProgramUniform3d;

			internal delegate void glProgramUniform3dEXT(UInt32 program, Int32 location, double x, double y, double z);

			[ThreadStatic]
			internal static glProgramUniform3dEXT pglProgramUniform3dEXT;

			internal unsafe delegate void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform3dv pglProgramUniform3dv;

			internal unsafe delegate void glProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform3dvEXT pglProgramUniform3dvEXT;

			internal delegate void glProgramUniform3f(UInt32 program, Int32 location, float v0, float v1, float v2);

			[AliasOf("glProgramUniform3f")]
			[AliasOf("glProgramUniform3fEXT")]
			[ThreadStatic]
			internal static glProgramUniform3f pglProgramUniform3f;

			internal unsafe delegate void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform3fv")]
			[AliasOf("glProgramUniform3fvEXT")]
			[ThreadStatic]
			internal static glProgramUniform3fv pglProgramUniform3fv;

			internal delegate void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[AliasOf("glProgramUniform3i")]
			[AliasOf("glProgramUniform3iEXT")]
			[ThreadStatic]
			internal static glProgramUniform3i pglProgramUniform3i;

			internal delegate void glProgramUniform3i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[ThreadStatic]
			internal static glProgramUniform3i64ARB pglProgramUniform3i64ARB;

			internal delegate void glProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[ThreadStatic]
			internal static glProgramUniform3i64NV pglProgramUniform3i64NV;

			internal unsafe delegate void glProgramUniform3i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform3i64vARB pglProgramUniform3i64vARB;

			internal unsafe delegate void glProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform3i64vNV pglProgramUniform3i64vNV;

			internal unsafe delegate void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform3iv")]
			[AliasOf("glProgramUniform3ivEXT")]
			[ThreadStatic]
			internal static glProgramUniform3iv pglProgramUniform3iv;

			internal delegate void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[AliasOf("glProgramUniform3ui")]
			[AliasOf("glProgramUniform3uiEXT")]
			[ThreadStatic]
			internal static glProgramUniform3ui pglProgramUniform3ui;

			internal delegate void glProgramUniform3ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[ThreadStatic]
			internal static glProgramUniform3ui64ARB pglProgramUniform3ui64ARB;

			internal delegate void glProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[ThreadStatic]
			internal static glProgramUniform3ui64NV pglProgramUniform3ui64NV;

			internal unsafe delegate void glProgramUniform3ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform3ui64vARB pglProgramUniform3ui64vARB;

			internal unsafe delegate void glProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform3ui64vNV pglProgramUniform3ui64vNV;

			internal unsafe delegate void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform3uiv")]
			[AliasOf("glProgramUniform3uivEXT")]
			[ThreadStatic]
			internal static glProgramUniform3uiv pglProgramUniform3uiv;

			internal delegate void glProgramUniform4d(UInt32 program, Int32 location, double v0, double v1, double v2, double v3);

			[ThreadStatic]
			internal static glProgramUniform4d pglProgramUniform4d;

			internal delegate void glProgramUniform4dEXT(UInt32 program, Int32 location, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glProgramUniform4dEXT pglProgramUniform4dEXT;

			internal unsafe delegate void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform4dv pglProgramUniform4dv;

			internal unsafe delegate void glProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform4dvEXT pglProgramUniform4dvEXT;

			internal delegate void glProgramUniform4f(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);

			[AliasOf("glProgramUniform4f")]
			[AliasOf("glProgramUniform4fEXT")]
			[ThreadStatic]
			internal static glProgramUniform4f pglProgramUniform4f;

			internal unsafe delegate void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, float* value);

			[AliasOf("glProgramUniform4fv")]
			[AliasOf("glProgramUniform4fvEXT")]
			[ThreadStatic]
			internal static glProgramUniform4fv pglProgramUniform4fv;

			internal delegate void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[AliasOf("glProgramUniform4i")]
			[AliasOf("glProgramUniform4iEXT")]
			[ThreadStatic]
			internal static glProgramUniform4i pglProgramUniform4i;

			internal delegate void glProgramUniform4i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[ThreadStatic]
			internal static glProgramUniform4i64ARB pglProgramUniform4i64ARB;

			internal delegate void glProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[ThreadStatic]
			internal static glProgramUniform4i64NV pglProgramUniform4i64NV;

			internal unsafe delegate void glProgramUniform4i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform4i64vARB pglProgramUniform4i64vARB;

			internal unsafe delegate void glProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glProgramUniform4i64vNV pglProgramUniform4i64vNV;

			internal unsafe delegate void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);

			[AliasOf("glProgramUniform4iv")]
			[AliasOf("glProgramUniform4ivEXT")]
			[ThreadStatic]
			internal static glProgramUniform4iv pglProgramUniform4iv;

			internal delegate void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[AliasOf("glProgramUniform4ui")]
			[AliasOf("glProgramUniform4uiEXT")]
			[ThreadStatic]
			internal static glProgramUniform4ui pglProgramUniform4ui;

			internal delegate void glProgramUniform4ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[ThreadStatic]
			internal static glProgramUniform4ui64ARB pglProgramUniform4ui64ARB;

			internal delegate void glProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[ThreadStatic]
			internal static glProgramUniform4ui64NV pglProgramUniform4ui64NV;

			internal unsafe delegate void glProgramUniform4ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform4ui64vARB pglProgramUniform4ui64vARB;

			internal unsafe delegate void glProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniform4ui64vNV pglProgramUniform4ui64vNV;

			internal unsafe delegate void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);

			[AliasOf("glProgramUniform4uiv")]
			[AliasOf("glProgramUniform4uivEXT")]
			[ThreadStatic]
			internal static glProgramUniform4uiv pglProgramUniform4uiv;

			internal delegate void glProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glProgramUniformHandleui64ARB pglProgramUniformHandleui64ARB;

			internal delegate void glProgramUniformHandleui64NV(UInt32 program, Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glProgramUniformHandleui64NV pglProgramUniformHandleui64NV;

			internal unsafe delegate void glProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[ThreadStatic]
			internal static glProgramUniformHandleui64vARB pglProgramUniformHandleui64vARB;

			internal unsafe delegate void glProgramUniformHandleui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[ThreadStatic]
			internal static glProgramUniformHandleui64vNV pglProgramUniformHandleui64vNV;

			internal unsafe delegate void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2dv pglProgramUniformMatrix2dv;

			internal unsafe delegate void glProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2dvEXT pglProgramUniformMatrix2dvEXT;

			internal unsafe delegate void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix2fv")]
			[AliasOf("glProgramUniformMatrix2fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2fv pglProgramUniformMatrix2fv;

			internal unsafe delegate void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2x3dv pglProgramUniformMatrix2x3dv;

			internal unsafe delegate void glProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2x3dvEXT pglProgramUniformMatrix2x3dvEXT;

			internal unsafe delegate void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix2x3fv")]
			[AliasOf("glProgramUniformMatrix2x3fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3fv pglProgramUniformMatrix2x3fv;

			internal unsafe delegate void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2x4dv pglProgramUniformMatrix2x4dv;

			internal unsafe delegate void glProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2x4dvEXT pglProgramUniformMatrix2x4dvEXT;

			internal unsafe delegate void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix2x4fv")]
			[AliasOf("glProgramUniformMatrix2x4fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4fv pglProgramUniformMatrix2x4fv;

			internal unsafe delegate void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3dv pglProgramUniformMatrix3dv;

			internal unsafe delegate void glProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3dvEXT pglProgramUniformMatrix3dvEXT;

			internal unsafe delegate void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix3fv")]
			[AliasOf("glProgramUniformMatrix3fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3fv pglProgramUniformMatrix3fv;

			internal unsafe delegate void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3x2dv pglProgramUniformMatrix3x2dv;

			internal unsafe delegate void glProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3x2dvEXT pglProgramUniformMatrix3x2dvEXT;

			internal unsafe delegate void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix3x2fv")]
			[AliasOf("glProgramUniformMatrix3x2fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2fv pglProgramUniformMatrix3x2fv;

			internal unsafe delegate void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3x4dv pglProgramUniformMatrix3x4dv;

			internal unsafe delegate void glProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3x4dvEXT pglProgramUniformMatrix3x4dvEXT;

			internal unsafe delegate void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix3x4fv")]
			[AliasOf("glProgramUniformMatrix3x4fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4fv pglProgramUniformMatrix3x4fv;

			internal unsafe delegate void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4dv pglProgramUniformMatrix4dv;

			internal unsafe delegate void glProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4dvEXT pglProgramUniformMatrix4dvEXT;

			internal unsafe delegate void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix4fv")]
			[AliasOf("glProgramUniformMatrix4fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4fv pglProgramUniformMatrix4fv;

			internal unsafe delegate void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4x2dv pglProgramUniformMatrix4x2dv;

			internal unsafe delegate void glProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4x2dvEXT pglProgramUniformMatrix4x2dvEXT;

			internal unsafe delegate void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix4x2fv")]
			[AliasOf("glProgramUniformMatrix4x2fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2fv pglProgramUniformMatrix4x2fv;

			internal unsafe delegate void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4x3dv pglProgramUniformMatrix4x3dv;

			internal unsafe delegate void glProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4x3dvEXT pglProgramUniformMatrix4x3dvEXT;

			internal unsafe delegate void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glProgramUniformMatrix4x3fv")]
			[AliasOf("glProgramUniformMatrix4x3fvEXT")]
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3fv pglProgramUniformMatrix4x3fv;

			internal delegate void glProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glProgramUniformui64NV pglProgramUniformui64NV;

			internal unsafe delegate void glProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniformui64vNV pglProgramUniformui64vNV;

			internal delegate void glProgramVertexLimitNV(Int32 target, Int32 limit);

			[ThreadStatic]
			internal static glProgramVertexLimitNV pglProgramVertexLimitNV;

			internal delegate void glProvokingVertex(Int32 mode);

			[AliasOf("glProvokingVertex")]
			[AliasOf("glProvokingVertexEXT")]
			[ThreadStatic]
			internal static glProvokingVertex pglProvokingVertex;

			internal delegate void glPushAttrib(UInt32 mask);

			[ThreadStatic]
			internal static glPushAttrib pglPushAttrib;

			internal delegate void glPushClientAttrib(UInt32 mask);

			[ThreadStatic]
			internal static glPushClientAttrib pglPushClientAttrib;

			internal delegate void glPushClientAttribDefaultEXT(UInt32 mask);

			[ThreadStatic]
			internal static glPushClientAttribDefaultEXT pglPushClientAttribDefaultEXT;

			internal delegate void glPushDebugGroup(Int32 source, UInt32 id, Int32 length, String message);

			[AliasOf("glPushDebugGroup")]
			[AliasOf("glPushDebugGroupKHR")]
			[ThreadStatic]
			internal static glPushDebugGroup pglPushDebugGroup;

			internal delegate void glPushGroupMarkerEXT(Int32 length, String marker);

			[ThreadStatic]
			internal static glPushGroupMarkerEXT pglPushGroupMarkerEXT;

			internal delegate void glPushMatrix();

			[ThreadStatic]
			internal static glPushMatrix pglPushMatrix;

			internal delegate void glPushName(UInt32 name);

			[ThreadStatic]
			internal static glPushName pglPushName;

			internal delegate void glQueryCounter(UInt32 id, Int32 target);

			[AliasOf("glQueryCounter")]
			[AliasOf("glQueryCounterEXT")]
			[ThreadStatic]
			internal static glQueryCounter pglQueryCounter;

			internal unsafe delegate UInt32 glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);

			[ThreadStatic]
			internal static glQueryMatrixxOES pglQueryMatrixxOES;

			internal delegate void glQueryObjectParameteruiAMD(Int32 target, UInt32 id, Int32 pname, UInt32 param);

			[ThreadStatic]
			internal static glQueryObjectParameteruiAMD pglQueryObjectParameteruiAMD;

			internal delegate void glRasterPos2d(double x, double y);

			[ThreadStatic]
			internal static glRasterPos2d pglRasterPos2d;

			internal unsafe delegate void glRasterPos2dv(double* v);

			[ThreadStatic]
			internal static glRasterPos2dv pglRasterPos2dv;

			internal delegate void glRasterPos2f(float x, float y);

			[ThreadStatic]
			internal static glRasterPos2f pglRasterPos2f;

			internal unsafe delegate void glRasterPos2fv(float* v);

			[ThreadStatic]
			internal static glRasterPos2fv pglRasterPos2fv;

			internal delegate void glRasterPos2i(Int32 x, Int32 y);

			[ThreadStatic]
			internal static glRasterPos2i pglRasterPos2i;

			internal unsafe delegate void glRasterPos2iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos2iv pglRasterPos2iv;

			internal delegate void glRasterPos2s(Int16 x, Int16 y);

			[ThreadStatic]
			internal static glRasterPos2s pglRasterPos2s;

			internal unsafe delegate void glRasterPos2sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos2sv pglRasterPos2sv;

			internal unsafe delegate void glRasterPos2xOES(IntPtr x, IntPtr y);

			[ThreadStatic]
			internal static glRasterPos2xOES pglRasterPos2xOES;

			internal unsafe delegate void glRasterPos2xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glRasterPos2xvOES pglRasterPos2xvOES;

			internal delegate void glRasterPos3d(double x, double y, double z);

			[ThreadStatic]
			internal static glRasterPos3d pglRasterPos3d;

			internal unsafe delegate void glRasterPos3dv(double* v);

			[ThreadStatic]
			internal static glRasterPos3dv pglRasterPos3dv;

			internal delegate void glRasterPos3f(float x, float y, float z);

			[ThreadStatic]
			internal static glRasterPos3f pglRasterPos3f;

			internal unsafe delegate void glRasterPos3fv(float* v);

			[ThreadStatic]
			internal static glRasterPos3fv pglRasterPos3fv;

			internal delegate void glRasterPos3i(Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glRasterPos3i pglRasterPos3i;

			internal unsafe delegate void glRasterPos3iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos3iv pglRasterPos3iv;

			internal delegate void glRasterPos3s(Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glRasterPos3s pglRasterPos3s;

			internal unsafe delegate void glRasterPos3sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos3sv pglRasterPos3sv;

			internal unsafe delegate void glRasterPos3xOES(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glRasterPos3xOES pglRasterPos3xOES;

			internal unsafe delegate void glRasterPos3xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glRasterPos3xvOES pglRasterPos3xvOES;

			internal delegate void glRasterPos4d(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glRasterPos4d pglRasterPos4d;

			internal unsafe delegate void glRasterPos4dv(double* v);

			[ThreadStatic]
			internal static glRasterPos4dv pglRasterPos4dv;

			internal delegate void glRasterPos4f(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glRasterPos4f pglRasterPos4f;

			internal unsafe delegate void glRasterPos4fv(float* v);

			[ThreadStatic]
			internal static glRasterPos4fv pglRasterPos4fv;

			internal delegate void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glRasterPos4i pglRasterPos4i;

			internal unsafe delegate void glRasterPos4iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos4iv pglRasterPos4iv;

			internal delegate void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glRasterPos4s pglRasterPos4s;

			internal unsafe delegate void glRasterPos4sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos4sv pglRasterPos4sv;

			internal unsafe delegate void glRasterPos4xOES(IntPtr x, IntPtr y, IntPtr z, IntPtr w);

			[ThreadStatic]
			internal static glRasterPos4xOES pglRasterPos4xOES;

			internal unsafe delegate void glRasterPos4xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glRasterPos4xvOES pglRasterPos4xvOES;

			internal delegate void glRasterSamplesEXT(UInt32 samples, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glRasterSamplesEXT pglRasterSamplesEXT;

			internal delegate void glReadBuffer(Int32 src);

			[ThreadStatic]
			internal static glReadBuffer pglReadBuffer;

			internal delegate void glReadBufferIndexedEXT(Int32 src, Int32 index);

			[ThreadStatic]
			internal static glReadBufferIndexedEXT pglReadBufferIndexedEXT;

			internal delegate void glReadBufferNV(Int32 mode);

			[ThreadStatic]
			internal static glReadBufferNV pglReadBufferNV;

			internal delegate void glReadInstrumentsSGIX(Int32 marker);

			[ThreadStatic]
			internal static glReadInstrumentsSGIX pglReadInstrumentsSGIX;

			internal unsafe delegate void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glReadPixels pglReadPixels;

			internal unsafe delegate void glReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[AliasOf("glReadnPixels")]
			[AliasOf("glReadnPixelsARB")]
			[AliasOf("glReadnPixelsEXT")]
			[AliasOf("glReadnPixelsKHR")]
			[ThreadStatic]
			internal static glReadnPixels pglReadnPixels;

			internal delegate void glRectd(double x1, double y1, double x2, double y2);

			[ThreadStatic]
			internal static glRectd pglRectd;

			internal unsafe delegate void glRectdv(double* v1, double* v2);

			[ThreadStatic]
			internal static glRectdv pglRectdv;

			internal delegate void glRectf(float x1, float y1, float x2, float y2);

			[ThreadStatic]
			internal static glRectf pglRectf;

			internal unsafe delegate void glRectfv(float* v1, float* v2);

			[ThreadStatic]
			internal static glRectfv pglRectfv;

			internal delegate void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

			[ThreadStatic]
			internal static glRecti pglRecti;

			internal unsafe delegate void glRectiv(Int32* v1, Int32* v2);

			[ThreadStatic]
			internal static glRectiv pglRectiv;

			internal delegate void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

			[ThreadStatic]
			internal static glRects pglRects;

			internal unsafe delegate void glRectsv(Int16* v1, Int16* v2);

			[ThreadStatic]
			internal static glRectsv pglRectsv;

			internal unsafe delegate void glRectxOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2);

			[ThreadStatic]
			internal static glRectxOES pglRectxOES;

			internal unsafe delegate void glRectxvOES(IntPtr* v1, IntPtr* v2);

			[ThreadStatic]
			internal static glRectxvOES pglRectxvOES;

			internal unsafe delegate void glReferencePlaneSGIX(double* equation);

			[ThreadStatic]
			internal static glReferencePlaneSGIX pglReferencePlaneSGIX;

			internal delegate void glReleaseShaderCompiler();

			[ThreadStatic]
			internal static glReleaseShaderCompiler pglReleaseShaderCompiler;

			internal delegate Int32 glRenderMode(Int32 mode);

			[ThreadStatic]
			internal static glRenderMode pglRenderMode;

			internal delegate void glRenderbufferStorage(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[AliasOf("glRenderbufferStorage")]
			[AliasOf("glRenderbufferStorageEXT")]
			[ThreadStatic]
			internal static glRenderbufferStorage pglRenderbufferStorage;

			internal delegate void glRenderbufferStorageMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[AliasOf("glRenderbufferStorageMultisample")]
			[AliasOf("glRenderbufferStorageMultisampleEXT")]
			[AliasOf("glRenderbufferStorageMultisampleNV")]
			[ThreadStatic]
			internal static glRenderbufferStorageMultisample pglRenderbufferStorageMultisample;

			internal delegate void glRenderbufferStorageMultisampleANGLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleANGLE pglRenderbufferStorageMultisampleANGLE;

			internal delegate void glRenderbufferStorageMultisampleAPPLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleAPPLE pglRenderbufferStorageMultisampleAPPLE;

			internal delegate void glRenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleCoverageNV pglRenderbufferStorageMultisampleCoverageNV;

			internal delegate void glRenderbufferStorageMultisampleIMG(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleIMG pglRenderbufferStorageMultisampleIMG;

			internal delegate void glRenderbufferStorageOES(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageOES pglRenderbufferStorageOES;

			internal unsafe delegate void glReplacementCodePointerSUN(Int32 type, Int32 stride, IntPtr* pointer);

			[ThreadStatic]
			internal static glReplacementCodePointerSUN pglReplacementCodePointerSUN;

			internal delegate void glReplacementCodeubSUN(byte code);

			[ThreadStatic]
			internal static glReplacementCodeubSUN pglReplacementCodeubSUN;

			internal unsafe delegate void glReplacementCodeubvSUN(byte* code);

			[ThreadStatic]
			internal static glReplacementCodeubvSUN pglReplacementCodeubvSUN;

			internal delegate void glReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, float r, float g, float b, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiColor3fVertex3fSUN pglReplacementCodeuiColor3fVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, float* c, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiColor3fVertex3fvSUN pglReplacementCodeuiColor3fVertex3fvSUN;

			internal delegate void glReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiColor4fNormal3fVertex3fSUN pglReplacementCodeuiColor4fNormal3fVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, float* c, float* n, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiColor4fNormal3fVertex3fvSUN pglReplacementCodeuiColor4fNormal3fVertex3fvSUN;

			internal delegate void glReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, byte r, byte g, byte b, byte a, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiColor4ubVertex3fSUN pglReplacementCodeuiColor4ubVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, byte* c, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiColor4ubVertex3fvSUN pglReplacementCodeuiColor4ubVertex3fvSUN;

			internal delegate void glReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiNormal3fVertex3fSUN pglReplacementCodeuiNormal3fVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, float* n, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiNormal3fVertex3fvSUN pglReplacementCodeuiNormal3fVertex3fvSUN;

			internal delegate void glReplacementCodeuiSUN(UInt32 code);

			[ThreadStatic]
			internal static glReplacementCodeuiSUN pglReplacementCodeuiSUN;

			internal delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* c, float* n, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;

			internal delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN pglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* n, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN pglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;

			internal delegate void glReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, float s, float t, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fVertex3fSUN pglReplacementCodeuiTexCoord2fVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, float* tc, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fVertex3fvSUN pglReplacementCodeuiTexCoord2fVertex3fvSUN;

			internal delegate void glReplacementCodeuiVertex3fSUN(UInt32 rc, float x, float y, float z);

			[ThreadStatic]
			internal static glReplacementCodeuiVertex3fSUN pglReplacementCodeuiVertex3fSUN;

			internal unsafe delegate void glReplacementCodeuiVertex3fvSUN(UInt32* rc, float* v);

			[ThreadStatic]
			internal static glReplacementCodeuiVertex3fvSUN pglReplacementCodeuiVertex3fvSUN;

			internal unsafe delegate void glReplacementCodeuivSUN(UInt32* code);

			[ThreadStatic]
			internal static glReplacementCodeuivSUN pglReplacementCodeuivSUN;

			internal delegate void glReplacementCodeusSUN(UInt16 code);

			[ThreadStatic]
			internal static glReplacementCodeusSUN pglReplacementCodeusSUN;

			internal unsafe delegate void glReplacementCodeusvSUN(UInt16* code);

			[ThreadStatic]
			internal static glReplacementCodeusvSUN pglReplacementCodeusvSUN;

			internal unsafe delegate void glRequestResidentProgramsNV(Int32 n, UInt32* programs);

			[ThreadStatic]
			internal static glRequestResidentProgramsNV pglRequestResidentProgramsNV;

			internal delegate void glResetHistogram(Int32 target);

			[AliasOf("glResetHistogram")]
			[AliasOf("glResetHistogramEXT")]
			[ThreadStatic]
			internal static glResetHistogram pglResetHistogram;

			internal delegate void glResetMinmax(Int32 target);

			[AliasOf("glResetMinmax")]
			[AliasOf("glResetMinmaxEXT")]
			[ThreadStatic]
			internal static glResetMinmax pglResetMinmax;

			internal delegate void glResizeBuffersMESA();

			[ThreadStatic]
			internal static glResizeBuffersMESA pglResizeBuffersMESA;

			internal delegate void glResolveDepthValuesNV();

			[ThreadStatic]
			internal static glResolveDepthValuesNV pglResolveDepthValuesNV;

			internal delegate void glResolveMultisampleFramebufferAPPLE();

			[ThreadStatic]
			internal static glResolveMultisampleFramebufferAPPLE pglResolveMultisampleFramebufferAPPLE;

			internal delegate void glResumeTransformFeedback();

			[AliasOf("glResumeTransformFeedback")]
			[AliasOf("glResumeTransformFeedbackNV")]
			[ThreadStatic]
			internal static glResumeTransformFeedback pglResumeTransformFeedback;

			internal delegate void glRotated(double angle, double x, double y, double z);

			[ThreadStatic]
			internal static glRotated pglRotated;

			internal delegate void glRotatef(float angle, float x, float y, float z);

			[ThreadStatic]
			internal static glRotatef pglRotatef;

			internal unsafe delegate void glRotatex(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glRotatex pglRotatex;

			internal unsafe delegate void glRotatexOES(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glRotatexOES pglRotatexOES;

			internal delegate void glSampleCoverage(float value, bool invert);

			[AliasOf("glSampleCoverage")]
			[AliasOf("glSampleCoverageARB")]
			[ThreadStatic]
			internal static glSampleCoverage pglSampleCoverage;

			internal delegate void glSampleCoveragex(Int32 value, bool invert);

			[ThreadStatic]
			internal static glSampleCoveragex pglSampleCoveragex;

			internal delegate void glSampleCoveragexOES(Int32 value, bool invert);

			[ThreadStatic]
			internal static glSampleCoveragexOES pglSampleCoveragexOES;

			internal delegate void glSampleMapATI(UInt32 dst, UInt32 interp, Int32 swizzle);

			[ThreadStatic]
			internal static glSampleMapATI pglSampleMapATI;

			internal delegate void glSampleMaskEXT(float value, bool invert);

			[AliasOf("glSampleMaskEXT")]
			[AliasOf("glSampleMaskSGIS")]
			[ThreadStatic]
			internal static glSampleMaskEXT pglSampleMaskEXT;

			internal delegate void glSampleMaskIndexedNV(UInt32 index, UInt32 mask);

			[ThreadStatic]
			internal static glSampleMaskIndexedNV pglSampleMaskIndexedNV;

			internal delegate void glSampleMaski(UInt32 maskNumber, UInt32 mask);

			[ThreadStatic]
			internal static glSampleMaski pglSampleMaski;

			internal delegate void glSamplePatternEXT(Int32 pattern);

			[AliasOf("glSamplePatternEXT")]
			[AliasOf("glSamplePatternSGIS")]
			[ThreadStatic]
			internal static glSamplePatternEXT pglSamplePatternEXT;

			internal unsafe delegate void glSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* param);

			[AliasOf("glSamplerParameterIiv")]
			[AliasOf("glSamplerParameterIivEXT")]
			[AliasOf("glSamplerParameterIivOES")]
			[ThreadStatic]
			internal static glSamplerParameterIiv pglSamplerParameterIiv;

			internal unsafe delegate void glSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* param);

			[AliasOf("glSamplerParameterIuiv")]
			[AliasOf("glSamplerParameterIuivEXT")]
			[AliasOf("glSamplerParameterIuivOES")]
			[ThreadStatic]
			internal static glSamplerParameterIuiv pglSamplerParameterIuiv;

			internal delegate void glSamplerParameterf(UInt32 sampler, Int32 pname, float param);

			[ThreadStatic]
			internal static glSamplerParameterf pglSamplerParameterf;

			internal unsafe delegate void glSamplerParameterfv(UInt32 sampler, Int32 pname, float* param);

			[ThreadStatic]
			internal static glSamplerParameterfv pglSamplerParameterfv;

			internal delegate void glSamplerParameteri(UInt32 sampler, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glSamplerParameteri pglSamplerParameteri;

			internal unsafe delegate void glSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glSamplerParameteriv pglSamplerParameteriv;

			internal delegate void glScaled(double x, double y, double z);

			[ThreadStatic]
			internal static glScaled pglScaled;

			internal delegate void glScalef(float x, float y, float z);

			[ThreadStatic]
			internal static glScalef pglScalef;

			internal unsafe delegate void glScalex(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glScalex pglScalex;

			internal unsafe delegate void glScalexOES(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glScalexOES pglScalexOES;

			internal delegate void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glScissor pglScissor;

			internal unsafe delegate void glScissorArrayv(UInt32 first, Int32 count, Int32* v);

			[AliasOf("glScissorArrayv")]
			[AliasOf("glScissorArrayvNV")]
			[ThreadStatic]
			internal static glScissorArrayv pglScissorArrayv;

			internal delegate void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

			[AliasOf("glScissorIndexed")]
			[AliasOf("glScissorIndexedNV")]
			[ThreadStatic]
			internal static glScissorIndexed pglScissorIndexed;

			internal unsafe delegate void glScissorIndexedv(UInt32 index, Int32* v);

			[AliasOf("glScissorIndexedv")]
			[AliasOf("glScissorIndexedvNV")]
			[ThreadStatic]
			internal static glScissorIndexedv pglScissorIndexedv;

			internal delegate void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);

			[AliasOf("glSecondaryColor3b")]
			[AliasOf("glSecondaryColor3bEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3b pglSecondaryColor3b;

			internal unsafe delegate void glSecondaryColor3bv(sbyte* v);

			[AliasOf("glSecondaryColor3bv")]
			[AliasOf("glSecondaryColor3bvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3bv pglSecondaryColor3bv;

			internal delegate void glSecondaryColor3d(double red, double green, double blue);

			[AliasOf("glSecondaryColor3d")]
			[AliasOf("glSecondaryColor3dEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3d pglSecondaryColor3d;

			internal unsafe delegate void glSecondaryColor3dv(double* v);

			[AliasOf("glSecondaryColor3dv")]
			[AliasOf("glSecondaryColor3dvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3dv pglSecondaryColor3dv;

			internal delegate void glSecondaryColor3f(float red, float green, float blue);

			[AliasOf("glSecondaryColor3f")]
			[AliasOf("glSecondaryColor3fEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3f pglSecondaryColor3f;

			internal unsafe delegate void glSecondaryColor3fv(float* v);

			[AliasOf("glSecondaryColor3fv")]
			[AliasOf("glSecondaryColor3fvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3fv pglSecondaryColor3fv;

			internal delegate void glSecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[ThreadStatic]
			internal static glSecondaryColor3hNV pglSecondaryColor3hNV;

			internal unsafe delegate void glSecondaryColor3hvNV(UInt16* v);

			[ThreadStatic]
			internal static glSecondaryColor3hvNV pglSecondaryColor3hvNV;

			internal delegate void glSecondaryColor3i(Int32 red, Int32 green, Int32 blue);

			[AliasOf("glSecondaryColor3i")]
			[AliasOf("glSecondaryColor3iEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3i pglSecondaryColor3i;

			internal unsafe delegate void glSecondaryColor3iv(Int32* v);

			[AliasOf("glSecondaryColor3iv")]
			[AliasOf("glSecondaryColor3ivEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3iv pglSecondaryColor3iv;

			internal delegate void glSecondaryColor3s(Int16 red, Int16 green, Int16 blue);

			[AliasOf("glSecondaryColor3s")]
			[AliasOf("glSecondaryColor3sEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3s pglSecondaryColor3s;

			internal unsafe delegate void glSecondaryColor3sv(Int16* v);

			[AliasOf("glSecondaryColor3sv")]
			[AliasOf("glSecondaryColor3svEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3sv pglSecondaryColor3sv;

			internal delegate void glSecondaryColor3ub(byte red, byte green, byte blue);

			[AliasOf("glSecondaryColor3ub")]
			[AliasOf("glSecondaryColor3ubEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3ub pglSecondaryColor3ub;

			internal unsafe delegate void glSecondaryColor3ubv(byte* v);

			[AliasOf("glSecondaryColor3ubv")]
			[AliasOf("glSecondaryColor3ubvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3ubv pglSecondaryColor3ubv;

			internal delegate void glSecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[AliasOf("glSecondaryColor3ui")]
			[AliasOf("glSecondaryColor3uiEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3ui pglSecondaryColor3ui;

			internal unsafe delegate void glSecondaryColor3uiv(UInt32* v);

			[AliasOf("glSecondaryColor3uiv")]
			[AliasOf("glSecondaryColor3uivEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3uiv pglSecondaryColor3uiv;

			internal delegate void glSecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[AliasOf("glSecondaryColor3us")]
			[AliasOf("glSecondaryColor3usEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3us pglSecondaryColor3us;

			internal unsafe delegate void glSecondaryColor3usv(UInt16* v);

			[AliasOf("glSecondaryColor3usv")]
			[AliasOf("glSecondaryColor3usvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3usv pglSecondaryColor3usv;

			internal delegate void glSecondaryColorFormatNV(Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glSecondaryColorFormatNV pglSecondaryColorFormatNV;

			internal delegate void glSecondaryColorP3ui(Int32 type, UInt32 color);

			[ThreadStatic]
			internal static glSecondaryColorP3ui pglSecondaryColorP3ui;

			internal unsafe delegate void glSecondaryColorP3uiv(Int32 type, UInt32* color);

			[ThreadStatic]
			internal static glSecondaryColorP3uiv pglSecondaryColorP3uiv;

			internal unsafe delegate void glSecondaryColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glSecondaryColorPointer")]
			[AliasOf("glSecondaryColorPointerEXT")]
			[ThreadStatic]
			internal static glSecondaryColorPointer pglSecondaryColorPointer;

			internal unsafe delegate void glSecondaryColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glSecondaryColorPointerListIBM pglSecondaryColorPointerListIBM;

			internal unsafe delegate void glSelectBuffer(Int32 size, UInt32* buffer);

			[ThreadStatic]
			internal static glSelectBuffer pglSelectBuffer;

			internal unsafe delegate void glSelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, UInt32* counterList);

			[ThreadStatic]
			internal static glSelectPerfMonitorCountersAMD pglSelectPerfMonitorCountersAMD;

			internal unsafe delegate void glSeparableFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr row, IntPtr column);

			[AliasOf("glSeparableFilter2D")]
			[AliasOf("glSeparableFilter2DEXT")]
			[ThreadStatic]
			internal static glSeparableFilter2D pglSeparableFilter2D;

			internal delegate void glSetFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glSetFenceAPPLE pglSetFenceAPPLE;

			internal delegate void glSetFenceNV(UInt32 fence, Int32 condition);

			[ThreadStatic]
			internal static glSetFenceNV pglSetFenceNV;

			internal unsafe delegate void glSetFragmentShaderConstantATI(UInt32 dst, float* value);

			[ThreadStatic]
			internal static glSetFragmentShaderConstantATI pglSetFragmentShaderConstantATI;

			internal unsafe delegate void glSetInvariantEXT(UInt32 id, Int32 type, IntPtr addr);

			[ThreadStatic]
			internal static glSetInvariantEXT pglSetInvariantEXT;

			internal unsafe delegate void glSetLocalConstantEXT(UInt32 id, Int32 type, IntPtr addr);

			[ThreadStatic]
			internal static glSetLocalConstantEXT pglSetLocalConstantEXT;

			internal unsafe delegate void glSetMultisamplefvAMD(Int32 pname, UInt32 index, float* val);

			[ThreadStatic]
			internal static glSetMultisamplefvAMD pglSetMultisamplefvAMD;

			internal delegate void glShadeModel(Int32 mode);

			[ThreadStatic]
			internal static glShadeModel pglShadeModel;

			internal unsafe delegate void glShaderBinary(Int32 count, UInt32* shaders, Int32 binaryformat, IntPtr binary, Int32 length);

			[ThreadStatic]
			internal static glShaderBinary pglShaderBinary;

			internal delegate void glShaderOp1EXT(Int32 op, UInt32 res, UInt32 arg1);

			[ThreadStatic]
			internal static glShaderOp1EXT pglShaderOp1EXT;

			internal delegate void glShaderOp2EXT(Int32 op, UInt32 res, UInt32 arg1, UInt32 arg2);

			[ThreadStatic]
			internal static glShaderOp2EXT pglShaderOp2EXT;

			internal delegate void glShaderOp3EXT(Int32 op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);

			[ThreadStatic]
			internal static glShaderOp3EXT pglShaderOp3EXT;

			internal unsafe delegate void glShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);

			[AliasOf("glShaderSource")]
			[AliasOf("glShaderSourceARB")]
			[ThreadStatic]
			internal static glShaderSource pglShaderSource;

			internal delegate void glShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);

			[ThreadStatic]
			internal static glShaderStorageBlockBinding pglShaderStorageBlockBinding;

			internal unsafe delegate void glSharpenTexFuncSGIS(Int32 target, Int32 n, float* points);

			[ThreadStatic]
			internal static glSharpenTexFuncSGIS pglSharpenTexFuncSGIS;

			internal delegate void glSpriteParameterfSGIX(Int32 pname, float param);

			[ThreadStatic]
			internal static glSpriteParameterfSGIX pglSpriteParameterfSGIX;

			internal unsafe delegate void glSpriteParameterfvSGIX(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glSpriteParameterfvSGIX pglSpriteParameterfvSGIX;

			internal delegate void glSpriteParameteriSGIX(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glSpriteParameteriSGIX pglSpriteParameteriSGIX;

			internal unsafe delegate void glSpriteParameterivSGIX(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glSpriteParameterivSGIX pglSpriteParameterivSGIX;

			internal delegate void glStartInstrumentsSGIX();

			[ThreadStatic]
			internal static glStartInstrumentsSGIX pglStartInstrumentsSGIX;

			internal delegate void glStartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);

			[ThreadStatic]
			internal static glStartTilingQCOM pglStartTilingQCOM;

			internal delegate void glStateCaptureNV(UInt32 state, Int32 mode);

			[ThreadStatic]
			internal static glStateCaptureNV pglStateCaptureNV;

			internal delegate void glStencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);

			[ThreadStatic]
			internal static glStencilClearTagEXT pglStencilClearTagEXT;

			internal unsafe delegate void glStencilFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glStencilFillPathInstancedNV pglStencilFillPathInstancedNV;

			internal delegate void glStencilFillPathNV(UInt32 path, Int32 fillMode, UInt32 mask);

			[ThreadStatic]
			internal static glStencilFillPathNV pglStencilFillPathNV;

			internal delegate void glStencilFunc(Int32 func, Int32 @ref, UInt32 mask);

			[ThreadStatic]
			internal static glStencilFunc pglStencilFunc;

			internal delegate void glStencilFuncSeparate(Int32 face, Int32 func, Int32 @ref, UInt32 mask);

			[ThreadStatic]
			internal static glStencilFuncSeparate pglStencilFuncSeparate;

			internal delegate void glStencilFuncSeparateATI(Int32 frontfunc, Int32 backfunc, Int32 @ref, UInt32 mask);

			[ThreadStatic]
			internal static glStencilFuncSeparateATI pglStencilFuncSeparateATI;

			internal delegate void glStencilMask(UInt32 mask);

			[ThreadStatic]
			internal static glStencilMask pglStencilMask;

			internal delegate void glStencilMaskSeparate(Int32 face, UInt32 mask);

			[ThreadStatic]
			internal static glStencilMaskSeparate pglStencilMaskSeparate;

			internal delegate void glStencilOp(Int32 fail, Int32 zfail, Int32 zpass);

			[ThreadStatic]
			internal static glStencilOp pglStencilOp;

			internal delegate void glStencilOpSeparate(Int32 face, Int32 sfail, Int32 dpfail, Int32 dppass);

			[AliasOf("glStencilOpSeparate")]
			[AliasOf("glStencilOpSeparateATI")]
			[ThreadStatic]
			internal static glStencilOpSeparate pglStencilOpSeparate;

			internal delegate void glStencilOpValueAMD(Int32 face, UInt32 value);

			[ThreadStatic]
			internal static glStencilOpValueAMD pglStencilOpValueAMD;

			internal unsafe delegate void glStencilStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glStencilStrokePathInstancedNV pglStencilStrokePathInstancedNV;

			internal delegate void glStencilStrokePathNV(UInt32 path, Int32 reference, UInt32 mask);

			[ThreadStatic]
			internal static glStencilStrokePathNV pglStencilStrokePathNV;

			internal unsafe delegate void glStencilThenCoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 coverMode, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glStencilThenCoverFillPathInstancedNV pglStencilThenCoverFillPathInstancedNV;

			internal delegate void glStencilThenCoverFillPathNV(UInt32 path, Int32 fillMode, UInt32 mask, Int32 coverMode);

			[ThreadStatic]
			internal static glStencilThenCoverFillPathNV pglStencilThenCoverFillPathNV;

			internal unsafe delegate void glStencilThenCoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 coverMode, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glStencilThenCoverStrokePathInstancedNV pglStencilThenCoverStrokePathInstancedNV;

			internal delegate void glStencilThenCoverStrokePathNV(UInt32 path, Int32 reference, UInt32 mask, Int32 coverMode);

			[ThreadStatic]
			internal static glStencilThenCoverStrokePathNV pglStencilThenCoverStrokePathNV;

			internal delegate void glStopInstrumentsSGIX(Int32 marker);

			[ThreadStatic]
			internal static glStopInstrumentsSGIX pglStopInstrumentsSGIX;

			internal unsafe delegate void glStringMarkerGREMEDY(Int32 len, IntPtr @string);

			[ThreadStatic]
			internal static glStringMarkerGREMEDY pglStringMarkerGREMEDY;

			internal delegate void glSubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits);

			[ThreadStatic]
			internal static glSubpixelPrecisionBiasNV pglSubpixelPrecisionBiasNV;

			internal delegate void glSwizzleEXT(UInt32 res, UInt32 @in, Int32 outX, Int32 outY, Int32 outZ, Int32 outW);

			[ThreadStatic]
			internal static glSwizzleEXT pglSwizzleEXT;

			internal delegate void glSyncTextureINTEL(UInt32 texture);

			[ThreadStatic]
			internal static glSyncTextureINTEL pglSyncTextureINTEL;

			internal delegate void glTagSampleBufferSGIX();

			[ThreadStatic]
			internal static glTagSampleBufferSGIX pglTagSampleBufferSGIX;

			internal delegate void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz);

			[ThreadStatic]
			internal static glTangent3bEXT pglTangent3bEXT;

			internal unsafe delegate void glTangent3bvEXT(sbyte* v);

			[ThreadStatic]
			internal static glTangent3bvEXT pglTangent3bvEXT;

			internal delegate void glTangent3dEXT(double tx, double ty, double tz);

			[ThreadStatic]
			internal static glTangent3dEXT pglTangent3dEXT;

			internal unsafe delegate void glTangent3dvEXT(double* v);

			[ThreadStatic]
			internal static glTangent3dvEXT pglTangent3dvEXT;

			internal delegate void glTangent3fEXT(float tx, float ty, float tz);

			[ThreadStatic]
			internal static glTangent3fEXT pglTangent3fEXT;

			internal unsafe delegate void glTangent3fvEXT(float* v);

			[ThreadStatic]
			internal static glTangent3fvEXT pglTangent3fvEXT;

			internal delegate void glTangent3iEXT(Int32 tx, Int32 ty, Int32 tz);

			[ThreadStatic]
			internal static glTangent3iEXT pglTangent3iEXT;

			internal unsafe delegate void glTangent3ivEXT(Int32* v);

			[ThreadStatic]
			internal static glTangent3ivEXT pglTangent3ivEXT;

			internal delegate void glTangent3sEXT(Int16 tx, Int16 ty, Int16 tz);

			[ThreadStatic]
			internal static glTangent3sEXT pglTangent3sEXT;

			internal unsafe delegate void glTangent3svEXT(Int16* v);

			[ThreadStatic]
			internal static glTangent3svEXT pglTangent3svEXT;

			internal unsafe delegate void glTangentPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glTangentPointerEXT pglTangentPointerEXT;

			internal delegate void glTbufferMask3DFX(UInt32 mask);

			[ThreadStatic]
			internal static glTbufferMask3DFX pglTbufferMask3DFX;

			internal delegate void glTessellationFactorAMD(float factor);

			[ThreadStatic]
			internal static glTessellationFactorAMD pglTessellationFactorAMD;

			internal delegate void glTessellationModeAMD(Int32 mode);

			[ThreadStatic]
			internal static glTessellationModeAMD pglTessellationModeAMD;

			internal delegate bool glTestFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glTestFenceAPPLE pglTestFenceAPPLE;

			internal delegate bool glTestFenceNV(UInt32 fence);

			[ThreadStatic]
			internal static glTestFenceNV pglTestFenceNV;

			internal delegate bool glTestObjectAPPLE(Int32 @object, UInt32 name);

			[ThreadStatic]
			internal static glTestObjectAPPLE pglTestObjectAPPLE;

			internal delegate void glTexBuffer(Int32 target, Int32 internalformat, UInt32 buffer);

			[AliasOf("glTexBuffer")]
			[AliasOf("glTexBufferARB")]
			[AliasOf("glTexBufferEXT")]
			[AliasOf("glTexBufferOES")]
			[ThreadStatic]
			internal static glTexBuffer pglTexBuffer;

			internal unsafe delegate void glTexBufferRange(Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[AliasOf("glTexBufferRange")]
			[AliasOf("glTexBufferRangeEXT")]
			[AliasOf("glTexBufferRangeOES")]
			[ThreadStatic]
			internal static glTexBufferRange pglTexBufferRange;

			internal unsafe delegate void glTexBumpParameterfvATI(Int32 pname, float* param);

			[ThreadStatic]
			internal static glTexBumpParameterfvATI pglTexBumpParameterfvATI;

			internal unsafe delegate void glTexBumpParameterivATI(Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glTexBumpParameterivATI pglTexBumpParameterivATI;

			internal delegate void glTexCoord1bOES(sbyte s);

			[ThreadStatic]
			internal static glTexCoord1bOES pglTexCoord1bOES;

			internal unsafe delegate void glTexCoord1bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord1bvOES pglTexCoord1bvOES;

			internal delegate void glTexCoord1d(double s);

			[ThreadStatic]
			internal static glTexCoord1d pglTexCoord1d;

			internal unsafe delegate void glTexCoord1dv(double* v);

			[ThreadStatic]
			internal static glTexCoord1dv pglTexCoord1dv;

			internal delegate void glTexCoord1f(float s);

			[ThreadStatic]
			internal static glTexCoord1f pglTexCoord1f;

			internal unsafe delegate void glTexCoord1fv(float* v);

			[ThreadStatic]
			internal static glTexCoord1fv pglTexCoord1fv;

			internal delegate void glTexCoord1hNV(UInt16 s);

			[ThreadStatic]
			internal static glTexCoord1hNV pglTexCoord1hNV;

			internal unsafe delegate void glTexCoord1hvNV(UInt16* v);

			[ThreadStatic]
			internal static glTexCoord1hvNV pglTexCoord1hvNV;

			internal delegate void glTexCoord1i(Int32 s);

			[ThreadStatic]
			internal static glTexCoord1i pglTexCoord1i;

			internal unsafe delegate void glTexCoord1iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord1iv pglTexCoord1iv;

			internal delegate void glTexCoord1s(Int16 s);

			[ThreadStatic]
			internal static glTexCoord1s pglTexCoord1s;

			internal unsafe delegate void glTexCoord1sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord1sv pglTexCoord1sv;

			internal unsafe delegate void glTexCoord1xOES(IntPtr s);

			[ThreadStatic]
			internal static glTexCoord1xOES pglTexCoord1xOES;

			internal unsafe delegate void glTexCoord1xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glTexCoord1xvOES pglTexCoord1xvOES;

			internal delegate void glTexCoord2bOES(sbyte s, sbyte t);

			[ThreadStatic]
			internal static glTexCoord2bOES pglTexCoord2bOES;

			internal unsafe delegate void glTexCoord2bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord2bvOES pglTexCoord2bvOES;

			internal delegate void glTexCoord2d(double s, double t);

			[ThreadStatic]
			internal static glTexCoord2d pglTexCoord2d;

			internal unsafe delegate void glTexCoord2dv(double* v);

			[ThreadStatic]
			internal static glTexCoord2dv pglTexCoord2dv;

			internal delegate void glTexCoord2f(float s, float t);

			[ThreadStatic]
			internal static glTexCoord2f pglTexCoord2f;

			internal delegate void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);

			[ThreadStatic]
			internal static glTexCoord2fColor3fVertex3fSUN pglTexCoord2fColor3fVertex3fSUN;

			internal unsafe delegate void glTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);

			[ThreadStatic]
			internal static glTexCoord2fColor3fVertex3fvSUN pglTexCoord2fColor3fVertex3fvSUN;

			internal delegate void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glTexCoord2fColor4fNormal3fVertex3fSUN pglTexCoord2fColor4fNormal3fVertex3fSUN;

			internal unsafe delegate void glTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);

			[ThreadStatic]
			internal static glTexCoord2fColor4fNormal3fVertex3fvSUN pglTexCoord2fColor4fNormal3fVertex3fvSUN;

			internal delegate void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);

			[ThreadStatic]
			internal static glTexCoord2fColor4ubVertex3fSUN pglTexCoord2fColor4ubVertex3fSUN;

			internal unsafe delegate void glTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);

			[ThreadStatic]
			internal static glTexCoord2fColor4ubVertex3fvSUN pglTexCoord2fColor4ubVertex3fvSUN;

			internal delegate void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[ThreadStatic]
			internal static glTexCoord2fNormal3fVertex3fSUN pglTexCoord2fNormal3fVertex3fSUN;

			internal unsafe delegate void glTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);

			[ThreadStatic]
			internal static glTexCoord2fNormal3fVertex3fvSUN pglTexCoord2fNormal3fVertex3fvSUN;

			internal delegate void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);

			[ThreadStatic]
			internal static glTexCoord2fVertex3fSUN pglTexCoord2fVertex3fSUN;

			internal unsafe delegate void glTexCoord2fVertex3fvSUN(float* tc, float* v);

			[ThreadStatic]
			internal static glTexCoord2fVertex3fvSUN pglTexCoord2fVertex3fvSUN;

			internal unsafe delegate void glTexCoord2fv(float* v);

			[ThreadStatic]
			internal static glTexCoord2fv pglTexCoord2fv;

			internal delegate void glTexCoord2hNV(UInt16 s, UInt16 t);

			[ThreadStatic]
			internal static glTexCoord2hNV pglTexCoord2hNV;

			internal unsafe delegate void glTexCoord2hvNV(UInt16* v);

			[ThreadStatic]
			internal static glTexCoord2hvNV pglTexCoord2hvNV;

			internal delegate void glTexCoord2i(Int32 s, Int32 t);

			[ThreadStatic]
			internal static glTexCoord2i pglTexCoord2i;

			internal unsafe delegate void glTexCoord2iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord2iv pglTexCoord2iv;

			internal delegate void glTexCoord2s(Int16 s, Int16 t);

			[ThreadStatic]
			internal static glTexCoord2s pglTexCoord2s;

			internal unsafe delegate void glTexCoord2sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord2sv pglTexCoord2sv;

			internal unsafe delegate void glTexCoord2xOES(IntPtr s, IntPtr t);

			[ThreadStatic]
			internal static glTexCoord2xOES pglTexCoord2xOES;

			internal unsafe delegate void glTexCoord2xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glTexCoord2xvOES pglTexCoord2xvOES;

			internal delegate void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);

			[ThreadStatic]
			internal static glTexCoord3bOES pglTexCoord3bOES;

			internal unsafe delegate void glTexCoord3bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord3bvOES pglTexCoord3bvOES;

			internal delegate void glTexCoord3d(double s, double t, double r);

			[ThreadStatic]
			internal static glTexCoord3d pglTexCoord3d;

			internal unsafe delegate void glTexCoord3dv(double* v);

			[ThreadStatic]
			internal static glTexCoord3dv pglTexCoord3dv;

			internal delegate void glTexCoord3f(float s, float t, float r);

			[ThreadStatic]
			internal static glTexCoord3f pglTexCoord3f;

			internal unsafe delegate void glTexCoord3fv(float* v);

			[ThreadStatic]
			internal static glTexCoord3fv pglTexCoord3fv;

			internal delegate void glTexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);

			[ThreadStatic]
			internal static glTexCoord3hNV pglTexCoord3hNV;

			internal unsafe delegate void glTexCoord3hvNV(UInt16* v);

			[ThreadStatic]
			internal static glTexCoord3hvNV pglTexCoord3hvNV;

			internal delegate void glTexCoord3i(Int32 s, Int32 t, Int32 r);

			[ThreadStatic]
			internal static glTexCoord3i pglTexCoord3i;

			internal unsafe delegate void glTexCoord3iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord3iv pglTexCoord3iv;

			internal delegate void glTexCoord3s(Int16 s, Int16 t, Int16 r);

			[ThreadStatic]
			internal static glTexCoord3s pglTexCoord3s;

			internal unsafe delegate void glTexCoord3sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord3sv pglTexCoord3sv;

			internal unsafe delegate void glTexCoord3xOES(IntPtr s, IntPtr t, IntPtr r);

			[ThreadStatic]
			internal static glTexCoord3xOES pglTexCoord3xOES;

			internal unsafe delegate void glTexCoord3xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glTexCoord3xvOES pglTexCoord3xvOES;

			internal delegate void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);

			[ThreadStatic]
			internal static glTexCoord4bOES pglTexCoord4bOES;

			internal unsafe delegate void glTexCoord4bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord4bvOES pglTexCoord4bvOES;

			internal delegate void glTexCoord4d(double s, double t, double r, double q);

			[ThreadStatic]
			internal static glTexCoord4d pglTexCoord4d;

			internal unsafe delegate void glTexCoord4dv(double* v);

			[ThreadStatic]
			internal static glTexCoord4dv pglTexCoord4dv;

			internal delegate void glTexCoord4f(float s, float t, float r, float q);

			[ThreadStatic]
			internal static glTexCoord4f pglTexCoord4f;

			internal delegate void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glTexCoord4fColor4fNormal3fVertex4fSUN pglTexCoord4fColor4fNormal3fVertex4fSUN;

			internal unsafe delegate void glTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);

			[ThreadStatic]
			internal static glTexCoord4fColor4fNormal3fVertex4fvSUN pglTexCoord4fColor4fNormal3fVertex4fvSUN;

			internal delegate void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glTexCoord4fVertex4fSUN pglTexCoord4fVertex4fSUN;

			internal unsafe delegate void glTexCoord4fVertex4fvSUN(float* tc, float* v);

			[ThreadStatic]
			internal static glTexCoord4fVertex4fvSUN pglTexCoord4fVertex4fvSUN;

			internal unsafe delegate void glTexCoord4fv(float* v);

			[ThreadStatic]
			internal static glTexCoord4fv pglTexCoord4fv;

			internal delegate void glTexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[ThreadStatic]
			internal static glTexCoord4hNV pglTexCoord4hNV;

			internal unsafe delegate void glTexCoord4hvNV(UInt16* v);

			[ThreadStatic]
			internal static glTexCoord4hvNV pglTexCoord4hvNV;

			internal delegate void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

			[ThreadStatic]
			internal static glTexCoord4i pglTexCoord4i;

			internal unsafe delegate void glTexCoord4iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord4iv pglTexCoord4iv;

			internal delegate void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

			[ThreadStatic]
			internal static glTexCoord4s pglTexCoord4s;

			internal unsafe delegate void glTexCoord4sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord4sv pglTexCoord4sv;

			internal unsafe delegate void glTexCoord4xOES(IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[ThreadStatic]
			internal static glTexCoord4xOES pglTexCoord4xOES;

			internal unsafe delegate void glTexCoord4xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glTexCoord4xvOES pglTexCoord4xvOES;

			internal delegate void glTexCoordFormatNV(Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glTexCoordFormatNV pglTexCoordFormatNV;

			internal delegate void glTexCoordP1ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP1ui pglTexCoordP1ui;

			internal unsafe delegate void glTexCoordP1uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP1uiv pglTexCoordP1uiv;

			internal delegate void glTexCoordP2ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP2ui pglTexCoordP2ui;

			internal unsafe delegate void glTexCoordP2uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP2uiv pglTexCoordP2uiv;

			internal delegate void glTexCoordP3ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP3ui pglTexCoordP3ui;

			internal unsafe delegate void glTexCoordP3uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP3uiv pglTexCoordP3uiv;

			internal delegate void glTexCoordP4ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP4ui pglTexCoordP4ui;

			internal unsafe delegate void glTexCoordP4uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP4uiv pglTexCoordP4uiv;

			internal unsafe delegate void glTexCoordPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glTexCoordPointer pglTexCoordPointer;

			internal unsafe delegate void glTexCoordPointerEXT(Int32 size, Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[ThreadStatic]
			internal static glTexCoordPointerEXT pglTexCoordPointerEXT;

			internal unsafe delegate void glTexCoordPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glTexCoordPointerListIBM pglTexCoordPointerListIBM;

			internal unsafe delegate void glTexCoordPointervINTEL(Int32 size, Int32 type, IntPtr* pointer);

			[ThreadStatic]
			internal static glTexCoordPointervINTEL pglTexCoordPointervINTEL;

			internal delegate void glTexEnvf(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexEnvf pglTexEnvf;

			internal unsafe delegate void glTexEnvfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexEnvfv pglTexEnvfv;

			internal delegate void glTexEnvi(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexEnvi pglTexEnvi;

			internal unsafe delegate void glTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexEnviv pglTexEnviv;

			internal unsafe delegate void glTexEnvx(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexEnvx pglTexEnvx;

			internal unsafe delegate void glTexEnvxOES(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexEnvxOES pglTexEnvxOES;

			internal unsafe delegate void glTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexEnvxv pglTexEnvxv;

			internal unsafe delegate void glTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexEnvxvOES pglTexEnvxvOES;

			internal unsafe delegate void glTexFilterFuncSGIS(Int32 target, Int32 filter, Int32 n, float* weights);

			[ThreadStatic]
			internal static glTexFilterFuncSGIS pglTexFilterFuncSGIS;

			internal delegate void glTexGend(Int32 coord, Int32 pname, double param);

			[ThreadStatic]
			internal static glTexGend pglTexGend;

			internal unsafe delegate void glTexGendv(Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glTexGendv pglTexGendv;

			internal delegate void glTexGenf(Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexGenf pglTexGenf;

			internal delegate void glTexGenfOES(Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexGenfOES pglTexGenfOES;

			internal unsafe delegate void glTexGenfv(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexGenfv pglTexGenfv;

			internal unsafe delegate void glTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexGenfvOES pglTexGenfvOES;

			internal delegate void glTexGeni(Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexGeni pglTexGeni;

			internal delegate void glTexGeniOES(Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexGeniOES pglTexGeniOES;

			internal unsafe delegate void glTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexGeniv pglTexGeniv;

			internal unsafe delegate void glTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexGenivOES pglTexGenivOES;

			internal unsafe delegate void glTexGenxOES(Int32 coord, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexGenxOES pglTexGenxOES;

			internal unsafe delegate void glTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexGenxvOES pglTexGenxvOES;

			internal unsafe delegate void glTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage1D pglTexImage1D;

			internal unsafe delegate void glTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage2D pglTexImage2D;

			internal delegate void glTexImage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTexImage2DMultisample pglTexImage2DMultisample;

			internal delegate void glTexImage2DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[ThreadStatic]
			internal static glTexImage2DMultisampleCoverageNV pglTexImage2DMultisampleCoverageNV;

			internal unsafe delegate void glTexImage3D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[AliasOf("glTexImage3D")]
			[AliasOf("glTexImage3DEXT")]
			[AliasOf("glTexImage3DOES")]
			[ThreadStatic]
			internal static glTexImage3D pglTexImage3D;

			internal delegate void glTexImage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTexImage3DMultisample pglTexImage3DMultisample;

			internal delegate void glTexImage3DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[ThreadStatic]
			internal static glTexImage3DMultisampleCoverageNV pglTexImage3DMultisampleCoverageNV;

			internal unsafe delegate void glTexImage4DSGIS(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage4DSGIS pglTexImage4DSGIS;

			internal delegate void glTexPageCommitmentARB(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[AliasOf("glTexPageCommitmentARB")]
			[AliasOf("glTexPageCommitmentEXT")]
			[ThreadStatic]
			internal static glTexPageCommitmentARB pglTexPageCommitmentARB;

			internal unsafe delegate void glTexParameterIiv(Int32 target, Int32 pname, Int32* @params);

			[AliasOf("glTexParameterIiv")]
			[AliasOf("glTexParameterIivEXT")]
			[AliasOf("glTexParameterIivOES")]
			[ThreadStatic]
			internal static glTexParameterIiv pglTexParameterIiv;

			internal unsafe delegate void glTexParameterIuiv(Int32 target, Int32 pname, UInt32* @params);

			[AliasOf("glTexParameterIuiv")]
			[AliasOf("glTexParameterIuivEXT")]
			[AliasOf("glTexParameterIuivOES")]
			[ThreadStatic]
			internal static glTexParameterIuiv pglTexParameterIuiv;

			internal delegate void glTexParameterf(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexParameterf pglTexParameterf;

			internal unsafe delegate void glTexParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexParameterfv pglTexParameterfv;

			internal delegate void glTexParameteri(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexParameteri pglTexParameteri;

			internal unsafe delegate void glTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexParameteriv pglTexParameteriv;

			internal unsafe delegate void glTexParameterx(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexParameterx pglTexParameterx;

			internal unsafe delegate void glTexParameterxOES(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexParameterxOES pglTexParameterxOES;

			internal unsafe delegate void glTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexParameterxv pglTexParameterxv;

			internal unsafe delegate void glTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexParameterxvOES pglTexParameterxvOES;

			internal delegate void glTexRenderbufferNV(Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glTexRenderbufferNV pglTexRenderbufferNV;

			internal delegate void glTexStorage1D(Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[AliasOf("glTexStorage1D")]
			[AliasOf("glTexStorage1DEXT")]
			[ThreadStatic]
			internal static glTexStorage1D pglTexStorage1D;

			internal delegate void glTexStorage2D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[AliasOf("glTexStorage2D")]
			[AliasOf("glTexStorage2DEXT")]
			[ThreadStatic]
			internal static glTexStorage2D pglTexStorage2D;

			internal delegate void glTexStorage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTexStorage2DMultisample pglTexStorage2DMultisample;

			internal delegate void glTexStorage3D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[AliasOf("glTexStorage3D")]
			[AliasOf("glTexStorage3DEXT")]
			[ThreadStatic]
			internal static glTexStorage3D pglTexStorage3D;

			internal delegate void glTexStorage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[AliasOf("glTexStorage3DMultisample")]
			[AliasOf("glTexStorage3DMultisampleOES")]
			[ThreadStatic]
			internal static glTexStorage3DMultisample pglTexStorage3DMultisample;

			internal delegate void glTexStorageSparseAMD(Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[ThreadStatic]
			internal static glTexStorageSparseAMD pglTexStorageSparseAMD;

			internal unsafe delegate void glTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[AliasOf("glTexSubImage1D")]
			[AliasOf("glTexSubImage1DEXT")]
			[ThreadStatic]
			internal static glTexSubImage1D pglTexSubImage1D;

			internal unsafe delegate void glTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[AliasOf("glTexSubImage2D")]
			[AliasOf("glTexSubImage2DEXT")]
			[ThreadStatic]
			internal static glTexSubImage2D pglTexSubImage2D;

			internal unsafe delegate void glTexSubImage3D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[AliasOf("glTexSubImage3D")]
			[AliasOf("glTexSubImage3DEXT")]
			[AliasOf("glTexSubImage3DOES")]
			[ThreadStatic]
			internal static glTexSubImage3D pglTexSubImage3D;

			internal unsafe delegate void glTexSubImage4DSGIS(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexSubImage4DSGIS pglTexSubImage4DSGIS;

			internal delegate void glTextureBarrier();

			[ThreadStatic]
			internal static glTextureBarrier pglTextureBarrier;

			internal delegate void glTextureBarrierNV();

			[ThreadStatic]
			internal static glTextureBarrierNV pglTextureBarrierNV;

			internal delegate void glTextureBuffer(UInt32 texture, Int32 internalformat, UInt32 buffer);

			[ThreadStatic]
			internal static glTextureBuffer pglTextureBuffer;

			internal delegate void glTextureBufferEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer);

			[ThreadStatic]
			internal static glTextureBufferEXT pglTextureBufferEXT;

			internal unsafe delegate void glTextureBufferRange(UInt32 texture, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[ThreadStatic]
			internal static glTextureBufferRange pglTextureBufferRange;

			internal unsafe delegate void glTextureBufferRangeEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[ThreadStatic]
			internal static glTextureBufferRangeEXT pglTextureBufferRangeEXT;

			internal delegate void glTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);

			[ThreadStatic]
			internal static glTextureColorMaskSGIS pglTextureColorMaskSGIS;

			internal unsafe delegate void glTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureImage1DEXT pglTextureImage1DEXT;

			internal unsafe delegate void glTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureImage2DEXT pglTextureImage2DEXT;

			internal delegate void glTextureImage2DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[ThreadStatic]
			internal static glTextureImage2DMultisampleCoverageNV pglTextureImage2DMultisampleCoverageNV;

			internal delegate void glTextureImage2DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[ThreadStatic]
			internal static glTextureImage2DMultisampleNV pglTextureImage2DMultisampleNV;

			internal unsafe delegate void glTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureImage3DEXT pglTextureImage3DEXT;

			internal delegate void glTextureImage3DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[ThreadStatic]
			internal static glTextureImage3DMultisampleCoverageNV pglTextureImage3DMultisampleCoverageNV;

			internal delegate void glTextureImage3DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[ThreadStatic]
			internal static glTextureImage3DMultisampleNV pglTextureImage3DMultisampleNV;

			internal delegate void glTextureLightEXT(Int32 pname);

			[ThreadStatic]
			internal static glTextureLightEXT pglTextureLightEXT;

			internal delegate void glTextureMaterialEXT(Int32 face, Int32 mode);

			[ThreadStatic]
			internal static glTextureMaterialEXT pglTextureMaterialEXT;

			internal delegate void glTextureNormalEXT(Int32 mode);

			[ThreadStatic]
			internal static glTextureNormalEXT pglTextureNormalEXT;

			internal delegate void glTexturePageCommitmentEXT(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[ThreadStatic]
			internal static glTexturePageCommitmentEXT pglTexturePageCommitmentEXT;

			internal unsafe delegate void glTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTextureParameterIiv pglTextureParameterIiv;

			internal unsafe delegate void glTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTextureParameterIivEXT pglTextureParameterIivEXT;

			internal unsafe delegate void glTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glTextureParameterIuiv pglTextureParameterIuiv;

			internal unsafe delegate void glTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glTextureParameterIuivEXT pglTextureParameterIuivEXT;

			internal delegate void glTextureParameterf(UInt32 texture, Int32 pname, float param);

			[ThreadStatic]
			internal static glTextureParameterf pglTextureParameterf;

			internal delegate void glTextureParameterfEXT(UInt32 texture, Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTextureParameterfEXT pglTextureParameterfEXT;

			internal unsafe delegate void glTextureParameterfv(UInt32 texture, Int32 pname, float* param);

			[ThreadStatic]
			internal static glTextureParameterfv pglTextureParameterfv;

			internal unsafe delegate void glTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTextureParameterfvEXT pglTextureParameterfvEXT;

			internal delegate void glTextureParameteri(UInt32 texture, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTextureParameteri pglTextureParameteri;

			internal delegate void glTextureParameteriEXT(UInt32 texture, Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTextureParameteriEXT pglTextureParameteriEXT;

			internal unsafe delegate void glTextureParameteriv(UInt32 texture, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glTextureParameteriv pglTextureParameteriv;

			internal unsafe delegate void glTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTextureParameterivEXT pglTextureParameterivEXT;

			internal unsafe delegate void glTextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer);

			[ThreadStatic]
			internal static glTextureRangeAPPLE pglTextureRangeAPPLE;

			internal delegate void glTextureRenderbufferEXT(UInt32 texture, Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glTextureRenderbufferEXT pglTextureRenderbufferEXT;

			internal delegate void glTextureStorage1D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width);

			[ThreadStatic]
			internal static glTextureStorage1D pglTextureStorage1D;

			internal delegate void glTextureStorage1DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[ThreadStatic]
			internal static glTextureStorage1DEXT pglTextureStorage1DEXT;

			internal delegate void glTextureStorage2D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glTextureStorage2D pglTextureStorage2D;

			internal delegate void glTextureStorage2DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glTextureStorage2DEXT pglTextureStorage2DEXT;

			internal delegate void glTextureStorage2DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTextureStorage2DMultisample pglTextureStorage2DMultisample;

			internal delegate void glTextureStorage2DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTextureStorage2DMultisampleEXT pglTextureStorage2DMultisampleEXT;

			internal delegate void glTextureStorage3D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[ThreadStatic]
			internal static glTextureStorage3D pglTextureStorage3D;

			internal delegate void glTextureStorage3DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[ThreadStatic]
			internal static glTextureStorage3DEXT pglTextureStorage3DEXT;

			internal delegate void glTextureStorage3DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTextureStorage3DMultisample pglTextureStorage3DMultisample;

			internal delegate void glTextureStorage3DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTextureStorage3DMultisampleEXT pglTextureStorage3DMultisampleEXT;

			internal delegate void glTextureStorageSparseAMD(UInt32 texture, Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[ThreadStatic]
			internal static glTextureStorageSparseAMD pglTextureStorageSparseAMD;

			internal unsafe delegate void glTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage1D pglTextureSubImage1D;

			internal unsafe delegate void glTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage1DEXT pglTextureSubImage1DEXT;

			internal unsafe delegate void glTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage2D pglTextureSubImage2D;

			internal unsafe delegate void glTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage2DEXT pglTextureSubImage2DEXT;

			internal unsafe delegate void glTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage3D pglTextureSubImage3D;

			internal unsafe delegate void glTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage3DEXT pglTextureSubImage3DEXT;

			internal delegate void glTextureView(UInt32 texture, Int32 target, UInt32 origtexture, Int32 internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

			[AliasOf("glTextureView")]
			[AliasOf("glTextureViewEXT")]
			[AliasOf("glTextureViewOES")]
			[ThreadStatic]
			internal static glTextureView pglTextureView;

			internal delegate void glTrackMatrixNV(Int32 target, UInt32 address, Int32 matrix, Int32 transform);

			[ThreadStatic]
			internal static glTrackMatrixNV pglTrackMatrixNV;

			internal unsafe delegate void glTransformFeedbackAttribsNV(Int32 count, Int32* attribs, Int32 bufferMode);

			[ThreadStatic]
			internal static glTransformFeedbackAttribsNV pglTransformFeedbackAttribsNV;

			internal delegate void glTransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);

			[ThreadStatic]
			internal static glTransformFeedbackBufferBase pglTransformFeedbackBufferBase;

			internal unsafe delegate void glTransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[ThreadStatic]
			internal static glTransformFeedbackBufferRange pglTransformFeedbackBufferRange;

			internal unsafe delegate void glTransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, Int32 bufferMode);

			[ThreadStatic]
			internal static glTransformFeedbackStreamAttribsNV pglTransformFeedbackStreamAttribsNV;

			internal delegate void glTransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, Int32 bufferMode);

			[AliasOf("glTransformFeedbackVaryings")]
			[AliasOf("glTransformFeedbackVaryingsEXT")]
			[ThreadStatic]
			internal static glTransformFeedbackVaryings pglTransformFeedbackVaryings;

			internal unsafe delegate void glTransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, Int32 bufferMode);

			[ThreadStatic]
			internal static glTransformFeedbackVaryingsNV pglTransformFeedbackVaryingsNV;

			internal unsafe delegate void glTransformPathNV(UInt32 resultPath, UInt32 srcPath, Int32 transformType, float* transformValues);

			[ThreadStatic]
			internal static glTransformPathNV pglTransformPathNV;

			internal delegate void glTranslated(double x, double y, double z);

			[ThreadStatic]
			internal static glTranslated pglTranslated;

			internal delegate void glTranslatef(float x, float y, float z);

			[ThreadStatic]
			internal static glTranslatef pglTranslatef;

			internal unsafe delegate void glTranslatex(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glTranslatex pglTranslatex;

			internal unsafe delegate void glTranslatexOES(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glTranslatexOES pglTranslatexOES;

			internal delegate void glUniform1d(Int32 location, double x);

			[ThreadStatic]
			internal static glUniform1d pglUniform1d;

			internal unsafe delegate void glUniform1dv(Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glUniform1dv pglUniform1dv;

			internal delegate void glUniform1f(Int32 location, float v0);

			[AliasOf("glUniform1f")]
			[AliasOf("glUniform1fARB")]
			[ThreadStatic]
			internal static glUniform1f pglUniform1f;

			internal unsafe delegate void glUniform1fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform1fv")]
			[AliasOf("glUniform1fvARB")]
			[ThreadStatic]
			internal static glUniform1fv pglUniform1fv;

			internal delegate void glUniform1i(Int32 location, Int32 v0);

			[AliasOf("glUniform1i")]
			[AliasOf("glUniform1iARB")]
			[ThreadStatic]
			internal static glUniform1i pglUniform1i;

			internal delegate void glUniform1i64ARB(Int32 location, Int64 x);

			[ThreadStatic]
			internal static glUniform1i64ARB pglUniform1i64ARB;

			internal delegate void glUniform1i64NV(Int32 location, Int64 x);

			[ThreadStatic]
			internal static glUniform1i64NV pglUniform1i64NV;

			internal unsafe delegate void glUniform1i64vARB(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform1i64vARB pglUniform1i64vARB;

			internal unsafe delegate void glUniform1i64vNV(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform1i64vNV pglUniform1i64vNV;

			internal unsafe delegate void glUniform1iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform1iv")]
			[AliasOf("glUniform1ivARB")]
			[ThreadStatic]
			internal static glUniform1iv pglUniform1iv;

			internal delegate void glUniform1ui(Int32 location, UInt32 v0);

			[AliasOf("glUniform1ui")]
			[AliasOf("glUniform1uiEXT")]
			[ThreadStatic]
			internal static glUniform1ui pglUniform1ui;

			internal delegate void glUniform1ui64ARB(Int32 location, UInt64 x);

			[ThreadStatic]
			internal static glUniform1ui64ARB pglUniform1ui64ARB;

			internal delegate void glUniform1ui64NV(Int32 location, UInt64 x);

			[ThreadStatic]
			internal static glUniform1ui64NV pglUniform1ui64NV;

			internal unsafe delegate void glUniform1ui64vARB(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform1ui64vARB pglUniform1ui64vARB;

			internal unsafe delegate void glUniform1ui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform1ui64vNV pglUniform1ui64vNV;

			internal unsafe delegate void glUniform1uiv(Int32 location, Int32 count, UInt32* value);

			[AliasOf("glUniform1uiv")]
			[AliasOf("glUniform1uivEXT")]
			[ThreadStatic]
			internal static glUniform1uiv pglUniform1uiv;

			internal delegate void glUniform2d(Int32 location, double x, double y);

			[ThreadStatic]
			internal static glUniform2d pglUniform2d;

			internal unsafe delegate void glUniform2dv(Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glUniform2dv pglUniform2dv;

			internal delegate void glUniform2f(Int32 location, float v0, float v1);

			[AliasOf("glUniform2f")]
			[AliasOf("glUniform2fARB")]
			[ThreadStatic]
			internal static glUniform2f pglUniform2f;

			internal unsafe delegate void glUniform2fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform2fv")]
			[AliasOf("glUniform2fvARB")]
			[ThreadStatic]
			internal static glUniform2fv pglUniform2fv;

			internal delegate void glUniform2i(Int32 location, Int32 v0, Int32 v1);

			[AliasOf("glUniform2i")]
			[AliasOf("glUniform2iARB")]
			[ThreadStatic]
			internal static glUniform2i pglUniform2i;

			internal delegate void glUniform2i64ARB(Int32 location, Int64 x, Int64 y);

			[ThreadStatic]
			internal static glUniform2i64ARB pglUniform2i64ARB;

			internal delegate void glUniform2i64NV(Int32 location, Int64 x, Int64 y);

			[ThreadStatic]
			internal static glUniform2i64NV pglUniform2i64NV;

			internal unsafe delegate void glUniform2i64vARB(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform2i64vARB pglUniform2i64vARB;

			internal unsafe delegate void glUniform2i64vNV(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform2i64vNV pglUniform2i64vNV;

			internal unsafe delegate void glUniform2iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform2iv")]
			[AliasOf("glUniform2ivARB")]
			[ThreadStatic]
			internal static glUniform2iv pglUniform2iv;

			internal delegate void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1);

			[AliasOf("glUniform2ui")]
			[AliasOf("glUniform2uiEXT")]
			[ThreadStatic]
			internal static glUniform2ui pglUniform2ui;

			internal delegate void glUniform2ui64ARB(Int32 location, UInt64 x, UInt64 y);

			[ThreadStatic]
			internal static glUniform2ui64ARB pglUniform2ui64ARB;

			internal delegate void glUniform2ui64NV(Int32 location, UInt64 x, UInt64 y);

			[ThreadStatic]
			internal static glUniform2ui64NV pglUniform2ui64NV;

			internal unsafe delegate void glUniform2ui64vARB(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform2ui64vARB pglUniform2ui64vARB;

			internal unsafe delegate void glUniform2ui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform2ui64vNV pglUniform2ui64vNV;

			internal unsafe delegate void glUniform2uiv(Int32 location, Int32 count, UInt32* value);

			[AliasOf("glUniform2uiv")]
			[AliasOf("glUniform2uivEXT")]
			[ThreadStatic]
			internal static glUniform2uiv pglUniform2uiv;

			internal delegate void glUniform3d(Int32 location, double x, double y, double z);

			[ThreadStatic]
			internal static glUniform3d pglUniform3d;

			internal unsafe delegate void glUniform3dv(Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glUniform3dv pglUniform3dv;

			internal delegate void glUniform3f(Int32 location, float v0, float v1, float v2);

			[AliasOf("glUniform3f")]
			[AliasOf("glUniform3fARB")]
			[ThreadStatic]
			internal static glUniform3f pglUniform3f;

			internal unsafe delegate void glUniform3fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform3fv")]
			[AliasOf("glUniform3fvARB")]
			[ThreadStatic]
			internal static glUniform3fv pglUniform3fv;

			internal delegate void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[AliasOf("glUniform3i")]
			[AliasOf("glUniform3iARB")]
			[ThreadStatic]
			internal static glUniform3i pglUniform3i;

			internal delegate void glUniform3i64ARB(Int32 location, Int64 x, Int64 y, Int64 z);

			[ThreadStatic]
			internal static glUniform3i64ARB pglUniform3i64ARB;

			internal delegate void glUniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);

			[ThreadStatic]
			internal static glUniform3i64NV pglUniform3i64NV;

			internal unsafe delegate void glUniform3i64vARB(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform3i64vARB pglUniform3i64vARB;

			internal unsafe delegate void glUniform3i64vNV(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform3i64vNV pglUniform3i64vNV;

			internal unsafe delegate void glUniform3iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform3iv")]
			[AliasOf("glUniform3ivARB")]
			[ThreadStatic]
			internal static glUniform3iv pglUniform3iv;

			internal delegate void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

			[AliasOf("glUniform3ui")]
			[AliasOf("glUniform3uiEXT")]
			[ThreadStatic]
			internal static glUniform3ui pglUniform3ui;

			internal delegate void glUniform3ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[ThreadStatic]
			internal static glUniform3ui64ARB pglUniform3ui64ARB;

			internal delegate void glUniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[ThreadStatic]
			internal static glUniform3ui64NV pglUniform3ui64NV;

			internal unsafe delegate void glUniform3ui64vARB(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform3ui64vARB pglUniform3ui64vARB;

			internal unsafe delegate void glUniform3ui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform3ui64vNV pglUniform3ui64vNV;

			internal unsafe delegate void glUniform3uiv(Int32 location, Int32 count, UInt32* value);

			[AliasOf("glUniform3uiv")]
			[AliasOf("glUniform3uivEXT")]
			[ThreadStatic]
			internal static glUniform3uiv pglUniform3uiv;

			internal delegate void glUniform4d(Int32 location, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glUniform4d pglUniform4d;

			internal unsafe delegate void glUniform4dv(Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glUniform4dv pglUniform4dv;

			internal delegate void glUniform4f(Int32 location, float v0, float v1, float v2, float v3);

			[AliasOf("glUniform4f")]
			[AliasOf("glUniform4fARB")]
			[ThreadStatic]
			internal static glUniform4f pglUniform4f;

			internal unsafe delegate void glUniform4fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform4fv")]
			[AliasOf("glUniform4fvARB")]
			[ThreadStatic]
			internal static glUniform4fv pglUniform4fv;

			internal delegate void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[AliasOf("glUniform4i")]
			[AliasOf("glUniform4iARB")]
			[ThreadStatic]
			internal static glUniform4i pglUniform4i;

			internal delegate void glUniform4i64ARB(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[ThreadStatic]
			internal static glUniform4i64ARB pglUniform4i64ARB;

			internal delegate void glUniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[ThreadStatic]
			internal static glUniform4i64NV pglUniform4i64NV;

			internal unsafe delegate void glUniform4i64vARB(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform4i64vARB pglUniform4i64vARB;

			internal unsafe delegate void glUniform4i64vNV(Int32 location, Int32 count, Int64* value);

			[ThreadStatic]
			internal static glUniform4i64vNV pglUniform4i64vNV;

			internal unsafe delegate void glUniform4iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform4iv")]
			[AliasOf("glUniform4ivARB")]
			[ThreadStatic]
			internal static glUniform4iv pglUniform4iv;

			internal delegate void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

			[AliasOf("glUniform4ui")]
			[AliasOf("glUniform4uiEXT")]
			[ThreadStatic]
			internal static glUniform4ui pglUniform4ui;

			internal delegate void glUniform4ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[ThreadStatic]
			internal static glUniform4ui64ARB pglUniform4ui64ARB;

			internal delegate void glUniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[ThreadStatic]
			internal static glUniform4ui64NV pglUniform4ui64NV;

			internal unsafe delegate void glUniform4ui64vARB(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform4ui64vARB pglUniform4ui64vARB;

			internal unsafe delegate void glUniform4ui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniform4ui64vNV pglUniform4ui64vNV;

			internal unsafe delegate void glUniform4uiv(Int32 location, Int32 count, UInt32* value);

			[AliasOf("glUniform4uiv")]
			[AliasOf("glUniform4uivEXT")]
			[ThreadStatic]
			internal static glUniform4uiv pglUniform4uiv;

			internal delegate void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);

			[ThreadStatic]
			internal static glUniformBlockBinding pglUniformBlockBinding;

			internal delegate void glUniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);

			[ThreadStatic]
			internal static glUniformBufferEXT pglUniformBufferEXT;

			internal delegate void glUniformHandleui64ARB(Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glUniformHandleui64ARB pglUniformHandleui64ARB;

			internal delegate void glUniformHandleui64NV(Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glUniformHandleui64NV pglUniformHandleui64NV;

			internal unsafe delegate void glUniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniformHandleui64vARB pglUniformHandleui64vARB;

			internal unsafe delegate void glUniformHandleui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniformHandleui64vNV pglUniformHandleui64vNV;

			internal unsafe delegate void glUniformMatrix2dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix2dv pglUniformMatrix2dv;

			internal unsafe delegate void glUniformMatrix2fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix2fv")]
			[AliasOf("glUniformMatrix2fvARB")]
			[ThreadStatic]
			internal static glUniformMatrix2fv pglUniformMatrix2fv;

			internal unsafe delegate void glUniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix2x3dv pglUniformMatrix2x3dv;

			internal unsafe delegate void glUniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix2x3fv")]
			[AliasOf("glUniformMatrix2x3fvNV")]
			[ThreadStatic]
			internal static glUniformMatrix2x3fv pglUniformMatrix2x3fv;

			internal unsafe delegate void glUniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix2x4dv pglUniformMatrix2x4dv;

			internal unsafe delegate void glUniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix2x4fv")]
			[AliasOf("glUniformMatrix2x4fvNV")]
			[ThreadStatic]
			internal static glUniformMatrix2x4fv pglUniformMatrix2x4fv;

			internal unsafe delegate void glUniformMatrix3dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix3dv pglUniformMatrix3dv;

			internal unsafe delegate void glUniformMatrix3fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix3fv")]
			[AliasOf("glUniformMatrix3fvARB")]
			[ThreadStatic]
			internal static glUniformMatrix3fv pglUniformMatrix3fv;

			internal unsafe delegate void glUniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix3x2dv pglUniformMatrix3x2dv;

			internal unsafe delegate void glUniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix3x2fv")]
			[AliasOf("glUniformMatrix3x2fvNV")]
			[ThreadStatic]
			internal static glUniformMatrix3x2fv pglUniformMatrix3x2fv;

			internal unsafe delegate void glUniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix3x4dv pglUniformMatrix3x4dv;

			internal unsafe delegate void glUniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix3x4fv")]
			[AliasOf("glUniformMatrix3x4fvNV")]
			[ThreadStatic]
			internal static glUniformMatrix3x4fv pglUniformMatrix3x4fv;

			internal unsafe delegate void glUniformMatrix4dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix4dv pglUniformMatrix4dv;

			internal unsafe delegate void glUniformMatrix4fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix4fv")]
			[AliasOf("glUniformMatrix4fvARB")]
			[ThreadStatic]
			internal static glUniformMatrix4fv pglUniformMatrix4fv;

			internal unsafe delegate void glUniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix4x2dv pglUniformMatrix4x2dv;

			internal unsafe delegate void glUniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix4x2fv")]
			[AliasOf("glUniformMatrix4x2fvNV")]
			[ThreadStatic]
			internal static glUniformMatrix4x2fv pglUniformMatrix4x2fv;

			internal unsafe delegate void glUniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glUniformMatrix4x3dv pglUniformMatrix4x3dv;

			internal unsafe delegate void glUniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix4x3fv")]
			[AliasOf("glUniformMatrix4x3fvNV")]
			[ThreadStatic]
			internal static glUniformMatrix4x3fv pglUniformMatrix4x3fv;

			internal unsafe delegate void glUniformSubroutinesuiv(Int32 shadertype, Int32 count, UInt32* indices);

			[ThreadStatic]
			internal static glUniformSubroutinesuiv pglUniformSubroutinesuiv;

			internal delegate void glUniformui64NV(Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glUniformui64NV pglUniformui64NV;

			internal unsafe delegate void glUniformui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniformui64vNV pglUniformui64vNV;

			internal delegate void glUnlockArraysEXT();

			[ThreadStatic]
			internal static glUnlockArraysEXT pglUnlockArraysEXT;

			internal delegate bool glUnmapBuffer(Int32 target);

			[AliasOf("glUnmapBuffer")]
			[AliasOf("glUnmapBufferARB")]
			[AliasOf("glUnmapBufferOES")]
			[ThreadStatic]
			internal static glUnmapBuffer pglUnmapBuffer;

			internal delegate bool glUnmapNamedBuffer(UInt32 buffer);

			[ThreadStatic]
			internal static glUnmapNamedBuffer pglUnmapNamedBuffer;

			internal delegate bool glUnmapNamedBufferEXT(UInt32 buffer);

			[ThreadStatic]
			internal static glUnmapNamedBufferEXT pglUnmapNamedBufferEXT;

			internal delegate void glUnmapObjectBufferATI(UInt32 buffer);

			[ThreadStatic]
			internal static glUnmapObjectBufferATI pglUnmapObjectBufferATI;

			internal delegate void glUnmapTexture2DINTEL(UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glUnmapTexture2DINTEL pglUnmapTexture2DINTEL;

			internal unsafe delegate void glUpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, Int32 preserve);

			[ThreadStatic]
			internal static glUpdateObjectBufferATI pglUpdateObjectBufferATI;

			internal delegate void glUseProgram(UInt32 program);

			[AliasOf("glUseProgram")]
			[AliasOf("glUseProgramObjectARB")]
			[ThreadStatic]
			internal static glUseProgram pglUseProgram;

			internal delegate void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

			[ThreadStatic]
			internal static glUseProgramStages pglUseProgramStages;

			internal delegate void glUseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);

			[ThreadStatic]
			internal static glUseProgramStagesEXT pglUseProgramStagesEXT;

			internal delegate void glUseShaderProgramEXT(Int32 type, UInt32 program);

			[ThreadStatic]
			internal static glUseShaderProgramEXT pglUseShaderProgramEXT;

			internal delegate void glVDPAUFiniNV();

			[ThreadStatic]
			internal static glVDPAUFiniNV pglVDPAUFiniNV;

			internal unsafe delegate void glVDPAUGetSurfaceivNV(IntPtr surface, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[ThreadStatic]
			internal static glVDPAUGetSurfaceivNV pglVDPAUGetSurfaceivNV;

			internal unsafe delegate void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);

			[ThreadStatic]
			internal static glVDPAUInitNV pglVDPAUInitNV;

			internal unsafe delegate bool glVDPAUIsSurfaceNV(IntPtr surface);

			[ThreadStatic]
			internal static glVDPAUIsSurfaceNV pglVDPAUIsSurfaceNV;

			internal unsafe delegate void glVDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);

			[ThreadStatic]
			internal static glVDPAUMapSurfacesNV pglVDPAUMapSurfacesNV;

			internal unsafe delegate IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[ThreadStatic]
			internal static glVDPAURegisterOutputSurfaceNV pglVDPAURegisterOutputSurfaceNV;

			internal unsafe delegate IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[ThreadStatic]
			internal static glVDPAURegisterVideoSurfaceNV pglVDPAURegisterVideoSurfaceNV;

			internal unsafe delegate void glVDPAUSurfaceAccessNV(IntPtr surface, Int32 access);

			[ThreadStatic]
			internal static glVDPAUSurfaceAccessNV pglVDPAUSurfaceAccessNV;

			internal unsafe delegate void glVDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);

			[ThreadStatic]
			internal static glVDPAUUnmapSurfacesNV pglVDPAUUnmapSurfacesNV;

			internal unsafe delegate void glVDPAUUnregisterSurfaceNV(IntPtr surface);

			[ThreadStatic]
			internal static glVDPAUUnregisterSurfaceNV pglVDPAUUnregisterSurfaceNV;

			internal delegate void glValidateProgram(UInt32 program);

			[AliasOf("glValidateProgram")]
			[AliasOf("glValidateProgramARB")]
			[ThreadStatic]
			internal static glValidateProgram pglValidateProgram;

			internal delegate void glValidateProgramPipeline(UInt32 pipeline);

			[ThreadStatic]
			internal static glValidateProgramPipeline pglValidateProgramPipeline;

			internal delegate void glValidateProgramPipelineEXT(UInt32 pipeline);

			[ThreadStatic]
			internal static glValidateProgramPipelineEXT pglValidateProgramPipelineEXT;

			internal delegate void glVariantArrayObjectATI(UInt32 id, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset);

			[ThreadStatic]
			internal static glVariantArrayObjectATI pglVariantArrayObjectATI;

			internal unsafe delegate void glVariantPointerEXT(UInt32 id, Int32 type, UInt32 stride, IntPtr addr);

			[ThreadStatic]
			internal static glVariantPointerEXT pglVariantPointerEXT;

			internal unsafe delegate void glVariantbvEXT(UInt32 id, sbyte* addr);

			[ThreadStatic]
			internal static glVariantbvEXT pglVariantbvEXT;

			internal unsafe delegate void glVariantdvEXT(UInt32 id, double* addr);

			[ThreadStatic]
			internal static glVariantdvEXT pglVariantdvEXT;

			internal unsafe delegate void glVariantfvEXT(UInt32 id, float* addr);

			[ThreadStatic]
			internal static glVariantfvEXT pglVariantfvEXT;

			internal unsafe delegate void glVariantivEXT(UInt32 id, Int32* addr);

			[ThreadStatic]
			internal static glVariantivEXT pglVariantivEXT;

			internal unsafe delegate void glVariantsvEXT(UInt32 id, Int16* addr);

			[ThreadStatic]
			internal static glVariantsvEXT pglVariantsvEXT;

			internal unsafe delegate void glVariantubvEXT(UInt32 id, byte* addr);

			[ThreadStatic]
			internal static glVariantubvEXT pglVariantubvEXT;

			internal unsafe delegate void glVariantuivEXT(UInt32 id, UInt32* addr);

			[ThreadStatic]
			internal static glVariantuivEXT pglVariantuivEXT;

			internal unsafe delegate void glVariantusvEXT(UInt32 id, UInt16* addr);

			[ThreadStatic]
			internal static glVariantusvEXT pglVariantusvEXT;

			internal delegate void glVertex2bOES(sbyte x, sbyte y);

			[ThreadStatic]
			internal static glVertex2bOES pglVertex2bOES;

			internal unsafe delegate void glVertex2bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glVertex2bvOES pglVertex2bvOES;

			internal delegate void glVertex2d(double x, double y);

			[ThreadStatic]
			internal static glVertex2d pglVertex2d;

			internal unsafe delegate void glVertex2dv(double* v);

			[ThreadStatic]
			internal static glVertex2dv pglVertex2dv;

			internal delegate void glVertex2f(float x, float y);

			[ThreadStatic]
			internal static glVertex2f pglVertex2f;

			internal unsafe delegate void glVertex2fv(float* v);

			[ThreadStatic]
			internal static glVertex2fv pglVertex2fv;

			internal delegate void glVertex2hNV(UInt16 x, UInt16 y);

			[ThreadStatic]
			internal static glVertex2hNV pglVertex2hNV;

			internal unsafe delegate void glVertex2hvNV(UInt16* v);

			[ThreadStatic]
			internal static glVertex2hvNV pglVertex2hvNV;

			internal delegate void glVertex2i(Int32 x, Int32 y);

			[ThreadStatic]
			internal static glVertex2i pglVertex2i;

			internal unsafe delegate void glVertex2iv(Int32* v);

			[ThreadStatic]
			internal static glVertex2iv pglVertex2iv;

			internal delegate void glVertex2s(Int16 x, Int16 y);

			[ThreadStatic]
			internal static glVertex2s pglVertex2s;

			internal unsafe delegate void glVertex2sv(Int16* v);

			[ThreadStatic]
			internal static glVertex2sv pglVertex2sv;

			internal unsafe delegate void glVertex2xOES(IntPtr x);

			[ThreadStatic]
			internal static glVertex2xOES pglVertex2xOES;

			internal unsafe delegate void glVertex2xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glVertex2xvOES pglVertex2xvOES;

			internal delegate void glVertex3bOES(sbyte x, sbyte y, sbyte z);

			[ThreadStatic]
			internal static glVertex3bOES pglVertex3bOES;

			internal unsafe delegate void glVertex3bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glVertex3bvOES pglVertex3bvOES;

			internal delegate void glVertex3d(double x, double y, double z);

			[ThreadStatic]
			internal static glVertex3d pglVertex3d;

			internal unsafe delegate void glVertex3dv(double* v);

			[ThreadStatic]
			internal static glVertex3dv pglVertex3dv;

			internal delegate void glVertex3f(float x, float y, float z);

			[ThreadStatic]
			internal static glVertex3f pglVertex3f;

			internal unsafe delegate void glVertex3fv(float* v);

			[ThreadStatic]
			internal static glVertex3fv pglVertex3fv;

			internal delegate void glVertex3hNV(UInt16 x, UInt16 y, UInt16 z);

			[ThreadStatic]
			internal static glVertex3hNV pglVertex3hNV;

			internal unsafe delegate void glVertex3hvNV(UInt16* v);

			[ThreadStatic]
			internal static glVertex3hvNV pglVertex3hvNV;

			internal delegate void glVertex3i(Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glVertex3i pglVertex3i;

			internal unsafe delegate void glVertex3iv(Int32* v);

			[ThreadStatic]
			internal static glVertex3iv pglVertex3iv;

			internal delegate void glVertex3s(Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glVertex3s pglVertex3s;

			internal unsafe delegate void glVertex3sv(Int16* v);

			[ThreadStatic]
			internal static glVertex3sv pglVertex3sv;

			internal unsafe delegate void glVertex3xOES(IntPtr x, IntPtr y);

			[ThreadStatic]
			internal static glVertex3xOES pglVertex3xOES;

			internal unsafe delegate void glVertex3xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glVertex3xvOES pglVertex3xvOES;

			internal delegate void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);

			[ThreadStatic]
			internal static glVertex4bOES pglVertex4bOES;

			internal unsafe delegate void glVertex4bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glVertex4bvOES pglVertex4bvOES;

			internal delegate void glVertex4d(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glVertex4d pglVertex4d;

			internal unsafe delegate void glVertex4dv(double* v);

			[ThreadStatic]
			internal static glVertex4dv pglVertex4dv;

			internal delegate void glVertex4f(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glVertex4f pglVertex4f;

			internal unsafe delegate void glVertex4fv(float* v);

			[ThreadStatic]
			internal static glVertex4fv pglVertex4fv;

			internal delegate void glVertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[ThreadStatic]
			internal static glVertex4hNV pglVertex4hNV;

			internal unsafe delegate void glVertex4hvNV(UInt16* v);

			[ThreadStatic]
			internal static glVertex4hvNV pglVertex4hvNV;

			internal delegate void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glVertex4i pglVertex4i;

			internal unsafe delegate void glVertex4iv(Int32* v);

			[ThreadStatic]
			internal static glVertex4iv pglVertex4iv;

			internal delegate void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glVertex4s pglVertex4s;

			internal unsafe delegate void glVertex4sv(Int16* v);

			[ThreadStatic]
			internal static glVertex4sv pglVertex4sv;

			internal unsafe delegate void glVertex4xOES(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glVertex4xOES pglVertex4xOES;

			internal unsafe delegate void glVertex4xvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glVertex4xvOES pglVertex4xvOES;

			internal delegate void glVertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[ThreadStatic]
			internal static glVertexArrayAttribBinding pglVertexArrayAttribBinding;

			internal delegate void glVertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayAttribFormat pglVertexArrayAttribFormat;

			internal delegate void glVertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayAttribIFormat pglVertexArrayAttribIFormat;

			internal delegate void glVertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayAttribLFormat pglVertexArrayAttribLFormat;

			internal unsafe delegate void glVertexArrayBindVertexBufferEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[ThreadStatic]
			internal static glVertexArrayBindVertexBufferEXT pglVertexArrayBindVertexBufferEXT;

			internal delegate void glVertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[ThreadStatic]
			internal static glVertexArrayBindingDivisor pglVertexArrayBindingDivisor;

			internal unsafe delegate void glVertexArrayColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayColorOffsetEXT pglVertexArrayColorOffsetEXT;

			internal unsafe delegate void glVertexArrayEdgeFlagOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayEdgeFlagOffsetEXT pglVertexArrayEdgeFlagOffsetEXT;

			internal delegate void glVertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);

			[ThreadStatic]
			internal static glVertexArrayElementBuffer pglVertexArrayElementBuffer;

			internal unsafe delegate void glVertexArrayFogCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayFogCoordOffsetEXT pglVertexArrayFogCoordOffsetEXT;

			internal unsafe delegate void glVertexArrayIndexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayIndexOffsetEXT pglVertexArrayIndexOffsetEXT;

			internal unsafe delegate void glVertexArrayMultiTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayMultiTexCoordOffsetEXT pglVertexArrayMultiTexCoordOffsetEXT;

			internal unsafe delegate void glVertexArrayNormalOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayNormalOffsetEXT pglVertexArrayNormalOffsetEXT;

			internal delegate void glVertexArrayParameteriAPPLE(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glVertexArrayParameteriAPPLE pglVertexArrayParameteriAPPLE;

			internal unsafe delegate void glVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexArrayRangeAPPLE pglVertexArrayRangeAPPLE;

			internal unsafe delegate void glVertexArrayRangeNV(Int32 length, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexArrayRangeNV pglVertexArrayRangeNV;

			internal unsafe delegate void glVertexArraySecondaryColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArraySecondaryColorOffsetEXT pglVertexArraySecondaryColorOffsetEXT;

			internal unsafe delegate void glVertexArrayTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayTexCoordOffsetEXT pglVertexArrayTexCoordOffsetEXT;

			internal delegate void glVertexArrayVertexAttribBindingEXT(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribBindingEXT pglVertexArrayVertexAttribBindingEXT;

			internal delegate void glVertexArrayVertexAttribDivisorEXT(UInt32 vaobj, UInt32 index, UInt32 divisor);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribDivisorEXT pglVertexArrayVertexAttribDivisorEXT;

			internal delegate void glVertexArrayVertexAttribFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribFormatEXT pglVertexArrayVertexAttribFormatEXT;

			internal delegate void glVertexArrayVertexAttribIFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribIFormatEXT pglVertexArrayVertexAttribIFormatEXT;

			internal unsafe delegate void glVertexArrayVertexAttribIOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribIOffsetEXT pglVertexArrayVertexAttribIOffsetEXT;

			internal delegate void glVertexArrayVertexAttribLFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribLFormatEXT pglVertexArrayVertexAttribLFormatEXT;

			internal unsafe delegate void glVertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribLOffsetEXT pglVertexArrayVertexAttribLOffsetEXT;

			internal unsafe delegate void glVertexArrayVertexAttribOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribOffsetEXT pglVertexArrayVertexAttribOffsetEXT;

			internal delegate void glVertexArrayVertexBindingDivisorEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[ThreadStatic]
			internal static glVertexArrayVertexBindingDivisorEXT pglVertexArrayVertexBindingDivisorEXT;

			internal unsafe delegate void glVertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[ThreadStatic]
			internal static glVertexArrayVertexBuffer pglVertexArrayVertexBuffer;

			internal unsafe delegate void glVertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);

			[ThreadStatic]
			internal static glVertexArrayVertexBuffers pglVertexArrayVertexBuffers;

			internal unsafe delegate void glVertexArrayVertexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexOffsetEXT pglVertexArrayVertexOffsetEXT;

			internal delegate void glVertexAttrib1d(UInt32 index, double x);

			[AliasOf("glVertexAttrib1d")]
			[AliasOf("glVertexAttrib1dARB")]
			[AliasOf("glVertexAttrib1dNV")]
			[ThreadStatic]
			internal static glVertexAttrib1d pglVertexAttrib1d;

			internal unsafe delegate void glVertexAttrib1dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib1dv")]
			[AliasOf("glVertexAttrib1dvARB")]
			[AliasOf("glVertexAttrib1dvNV")]
			[ThreadStatic]
			internal static glVertexAttrib1dv pglVertexAttrib1dv;

			internal delegate void glVertexAttrib1f(UInt32 index, float x);

			[AliasOf("glVertexAttrib1f")]
			[AliasOf("glVertexAttrib1fARB")]
			[AliasOf("glVertexAttrib1fNV")]
			[ThreadStatic]
			internal static glVertexAttrib1f pglVertexAttrib1f;

			internal unsafe delegate void glVertexAttrib1fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib1fv")]
			[AliasOf("glVertexAttrib1fvARB")]
			[AliasOf("glVertexAttrib1fvNV")]
			[ThreadStatic]
			internal static glVertexAttrib1fv pglVertexAttrib1fv;

			internal delegate void glVertexAttrib1hNV(UInt32 index, UInt16 x);

			[ThreadStatic]
			internal static glVertexAttrib1hNV pglVertexAttrib1hNV;

			internal unsafe delegate void glVertexAttrib1hvNV(UInt32 index, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttrib1hvNV pglVertexAttrib1hvNV;

			internal delegate void glVertexAttrib1s(UInt32 index, Int16 x);

			[AliasOf("glVertexAttrib1s")]
			[AliasOf("glVertexAttrib1sARB")]
			[AliasOf("glVertexAttrib1sNV")]
			[ThreadStatic]
			internal static glVertexAttrib1s pglVertexAttrib1s;

			internal unsafe delegate void glVertexAttrib1sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib1sv")]
			[AliasOf("glVertexAttrib1svARB")]
			[AliasOf("glVertexAttrib1svNV")]
			[ThreadStatic]
			internal static glVertexAttrib1sv pglVertexAttrib1sv;

			internal delegate void glVertexAttrib2d(UInt32 index, double x, double y);

			[AliasOf("glVertexAttrib2d")]
			[AliasOf("glVertexAttrib2dARB")]
			[AliasOf("glVertexAttrib2dNV")]
			[ThreadStatic]
			internal static glVertexAttrib2d pglVertexAttrib2d;

			internal unsafe delegate void glVertexAttrib2dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib2dv")]
			[AliasOf("glVertexAttrib2dvARB")]
			[AliasOf("glVertexAttrib2dvNV")]
			[ThreadStatic]
			internal static glVertexAttrib2dv pglVertexAttrib2dv;

			internal delegate void glVertexAttrib2f(UInt32 index, float x, float y);

			[AliasOf("glVertexAttrib2f")]
			[AliasOf("glVertexAttrib2fARB")]
			[AliasOf("glVertexAttrib2fNV")]
			[ThreadStatic]
			internal static glVertexAttrib2f pglVertexAttrib2f;

			internal unsafe delegate void glVertexAttrib2fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib2fv")]
			[AliasOf("glVertexAttrib2fvARB")]
			[AliasOf("glVertexAttrib2fvNV")]
			[ThreadStatic]
			internal static glVertexAttrib2fv pglVertexAttrib2fv;

			internal delegate void glVertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);

			[ThreadStatic]
			internal static glVertexAttrib2hNV pglVertexAttrib2hNV;

			internal unsafe delegate void glVertexAttrib2hvNV(UInt32 index, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttrib2hvNV pglVertexAttrib2hvNV;

			internal delegate void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y);

			[AliasOf("glVertexAttrib2s")]
			[AliasOf("glVertexAttrib2sARB")]
			[AliasOf("glVertexAttrib2sNV")]
			[ThreadStatic]
			internal static glVertexAttrib2s pglVertexAttrib2s;

			internal unsafe delegate void glVertexAttrib2sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib2sv")]
			[AliasOf("glVertexAttrib2svARB")]
			[AliasOf("glVertexAttrib2svNV")]
			[ThreadStatic]
			internal static glVertexAttrib2sv pglVertexAttrib2sv;

			internal delegate void glVertexAttrib3d(UInt32 index, double x, double y, double z);

			[AliasOf("glVertexAttrib3d")]
			[AliasOf("glVertexAttrib3dARB")]
			[AliasOf("glVertexAttrib3dNV")]
			[ThreadStatic]
			internal static glVertexAttrib3d pglVertexAttrib3d;

			internal unsafe delegate void glVertexAttrib3dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib3dv")]
			[AliasOf("glVertexAttrib3dvARB")]
			[AliasOf("glVertexAttrib3dvNV")]
			[ThreadStatic]
			internal static glVertexAttrib3dv pglVertexAttrib3dv;

			internal delegate void glVertexAttrib3f(UInt32 index, float x, float y, float z);

			[AliasOf("glVertexAttrib3f")]
			[AliasOf("glVertexAttrib3fARB")]
			[AliasOf("glVertexAttrib3fNV")]
			[ThreadStatic]
			internal static glVertexAttrib3f pglVertexAttrib3f;

			internal unsafe delegate void glVertexAttrib3fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib3fv")]
			[AliasOf("glVertexAttrib3fvARB")]
			[AliasOf("glVertexAttrib3fvNV")]
			[ThreadStatic]
			internal static glVertexAttrib3fv pglVertexAttrib3fv;

			internal delegate void glVertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);

			[ThreadStatic]
			internal static glVertexAttrib3hNV pglVertexAttrib3hNV;

			internal unsafe delegate void glVertexAttrib3hvNV(UInt32 index, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttrib3hvNV pglVertexAttrib3hvNV;

			internal delegate void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);

			[AliasOf("glVertexAttrib3s")]
			[AliasOf("glVertexAttrib3sARB")]
			[AliasOf("glVertexAttrib3sNV")]
			[ThreadStatic]
			internal static glVertexAttrib3s pglVertexAttrib3s;

			internal unsafe delegate void glVertexAttrib3sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib3sv")]
			[AliasOf("glVertexAttrib3svARB")]
			[AliasOf("glVertexAttrib3svNV")]
			[ThreadStatic]
			internal static glVertexAttrib3sv pglVertexAttrib3sv;

			internal unsafe delegate void glVertexAttrib4Nbv(UInt32 index, sbyte* v);

			[AliasOf("glVertexAttrib4Nbv")]
			[AliasOf("glVertexAttrib4NbvARB")]
			[ThreadStatic]
			internal static glVertexAttrib4Nbv pglVertexAttrib4Nbv;

			internal unsafe delegate void glVertexAttrib4Niv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttrib4Niv")]
			[AliasOf("glVertexAttrib4NivARB")]
			[ThreadStatic]
			internal static glVertexAttrib4Niv pglVertexAttrib4Niv;

			internal unsafe delegate void glVertexAttrib4Nsv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib4Nsv")]
			[AliasOf("glVertexAttrib4NsvARB")]
			[ThreadStatic]
			internal static glVertexAttrib4Nsv pglVertexAttrib4Nsv;

			internal delegate void glVertexAttrib4Nub(UInt32 index, byte x, byte y, byte z, byte w);

			[AliasOf("glVertexAttrib4Nub")]
			[AliasOf("glVertexAttrib4NubARB")]
			[AliasOf("glVertexAttrib4ubNV")]
			[ThreadStatic]
			internal static glVertexAttrib4Nub pglVertexAttrib4Nub;

			internal unsafe delegate void glVertexAttrib4Nubv(UInt32 index, byte* v);

			[AliasOf("glVertexAttrib4Nubv")]
			[AliasOf("glVertexAttrib4NubvARB")]
			[AliasOf("glVertexAttrib4ubvNV")]
			[ThreadStatic]
			internal static glVertexAttrib4Nubv pglVertexAttrib4Nubv;

			internal unsafe delegate void glVertexAttrib4Nuiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttrib4Nuiv")]
			[AliasOf("glVertexAttrib4NuivARB")]
			[ThreadStatic]
			internal static glVertexAttrib4Nuiv pglVertexAttrib4Nuiv;

			internal unsafe delegate void glVertexAttrib4Nusv(UInt32 index, UInt16* v);

			[AliasOf("glVertexAttrib4Nusv")]
			[AliasOf("glVertexAttrib4NusvARB")]
			[ThreadStatic]
			internal static glVertexAttrib4Nusv pglVertexAttrib4Nusv;

			internal unsafe delegate void glVertexAttrib4bv(UInt32 index, sbyte* v);

			[AliasOf("glVertexAttrib4bv")]
			[AliasOf("glVertexAttrib4bvARB")]
			[ThreadStatic]
			internal static glVertexAttrib4bv pglVertexAttrib4bv;

			internal delegate void glVertexAttrib4d(UInt32 index, double x, double y, double z, double w);

			[AliasOf("glVertexAttrib4d")]
			[AliasOf("glVertexAttrib4dARB")]
			[AliasOf("glVertexAttrib4dNV")]
			[ThreadStatic]
			internal static glVertexAttrib4d pglVertexAttrib4d;

			internal unsafe delegate void glVertexAttrib4dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib4dv")]
			[AliasOf("glVertexAttrib4dvARB")]
			[AliasOf("glVertexAttrib4dvNV")]
			[ThreadStatic]
			internal static glVertexAttrib4dv pglVertexAttrib4dv;

			internal delegate void glVertexAttrib4f(UInt32 index, float x, float y, float z, float w);

			[AliasOf("glVertexAttrib4f")]
			[AliasOf("glVertexAttrib4fARB")]
			[AliasOf("glVertexAttrib4fNV")]
			[ThreadStatic]
			internal static glVertexAttrib4f pglVertexAttrib4f;

			internal unsafe delegate void glVertexAttrib4fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib4fv")]
			[AliasOf("glVertexAttrib4fvARB")]
			[AliasOf("glVertexAttrib4fvNV")]
			[ThreadStatic]
			internal static glVertexAttrib4fv pglVertexAttrib4fv;

			internal delegate void glVertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[ThreadStatic]
			internal static glVertexAttrib4hNV pglVertexAttrib4hNV;

			internal unsafe delegate void glVertexAttrib4hvNV(UInt32 index, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttrib4hvNV pglVertexAttrib4hvNV;

			internal unsafe delegate void glVertexAttrib4iv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttrib4iv")]
			[AliasOf("glVertexAttrib4ivARB")]
			[ThreadStatic]
			internal static glVertexAttrib4iv pglVertexAttrib4iv;

			internal delegate void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

			[AliasOf("glVertexAttrib4s")]
			[AliasOf("glVertexAttrib4sARB")]
			[AliasOf("glVertexAttrib4sNV")]
			[ThreadStatic]
			internal static glVertexAttrib4s pglVertexAttrib4s;

			internal unsafe delegate void glVertexAttrib4sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib4sv")]
			[AliasOf("glVertexAttrib4svARB")]
			[AliasOf("glVertexAttrib4svNV")]
			[ThreadStatic]
			internal static glVertexAttrib4sv pglVertexAttrib4sv;

			internal unsafe delegate void glVertexAttrib4ubv(UInt32 index, byte* v);

			[AliasOf("glVertexAttrib4ubv")]
			[AliasOf("glVertexAttrib4ubvARB")]
			[ThreadStatic]
			internal static glVertexAttrib4ubv pglVertexAttrib4ubv;

			internal unsafe delegate void glVertexAttrib4uiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttrib4uiv")]
			[AliasOf("glVertexAttrib4uivARB")]
			[ThreadStatic]
			internal static glVertexAttrib4uiv pglVertexAttrib4uiv;

			internal unsafe delegate void glVertexAttrib4usv(UInt32 index, UInt16* v);

			[AliasOf("glVertexAttrib4usv")]
			[AliasOf("glVertexAttrib4usvARB")]
			[ThreadStatic]
			internal static glVertexAttrib4usv pglVertexAttrib4usv;

			internal delegate void glVertexAttribArrayObjectATI(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);

			[ThreadStatic]
			internal static glVertexAttribArrayObjectATI pglVertexAttribArrayObjectATI;

			internal delegate void glVertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);

			[ThreadStatic]
			internal static glVertexAttribBinding pglVertexAttribBinding;

			internal delegate void glVertexAttribDivisor(UInt32 index, UInt32 divisor);

			[AliasOf("glVertexAttribDivisor")]
			[AliasOf("glVertexAttribDivisorANGLE")]
			[AliasOf("glVertexAttribDivisorARB")]
			[AliasOf("glVertexAttribDivisorEXT")]
			[AliasOf("glVertexAttribDivisorNV")]
			[ThreadStatic]
			internal static glVertexAttribDivisor pglVertexAttribDivisor;

			internal delegate void glVertexAttribFormat(UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexAttribFormat pglVertexAttribFormat;

			internal delegate void glVertexAttribFormatNV(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride);

			[ThreadStatic]
			internal static glVertexAttribFormatNV pglVertexAttribFormatNV;

			internal delegate void glVertexAttribI1i(UInt32 index, Int32 x);

			[AliasOf("glVertexAttribI1i")]
			[AliasOf("glVertexAttribI1iEXT")]
			[ThreadStatic]
			internal static glVertexAttribI1i pglVertexAttribI1i;

			internal unsafe delegate void glVertexAttribI1iv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttribI1iv")]
			[AliasOf("glVertexAttribI1ivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI1iv pglVertexAttribI1iv;

			internal delegate void glVertexAttribI1ui(UInt32 index, UInt32 x);

			[AliasOf("glVertexAttribI1ui")]
			[AliasOf("glVertexAttribI1uiEXT")]
			[ThreadStatic]
			internal static glVertexAttribI1ui pglVertexAttribI1ui;

			internal unsafe delegate void glVertexAttribI1uiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttribI1uiv")]
			[AliasOf("glVertexAttribI1uivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI1uiv pglVertexAttribI1uiv;

			internal delegate void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y);

			[AliasOf("glVertexAttribI2i")]
			[AliasOf("glVertexAttribI2iEXT")]
			[ThreadStatic]
			internal static glVertexAttribI2i pglVertexAttribI2i;

			internal unsafe delegate void glVertexAttribI2iv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttribI2iv")]
			[AliasOf("glVertexAttribI2ivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI2iv pglVertexAttribI2iv;

			internal delegate void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);

			[AliasOf("glVertexAttribI2ui")]
			[AliasOf("glVertexAttribI2uiEXT")]
			[ThreadStatic]
			internal static glVertexAttribI2ui pglVertexAttribI2ui;

			internal unsafe delegate void glVertexAttribI2uiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttribI2uiv")]
			[AliasOf("glVertexAttribI2uivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI2uiv pglVertexAttribI2uiv;

			internal delegate void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);

			[AliasOf("glVertexAttribI3i")]
			[AliasOf("glVertexAttribI3iEXT")]
			[ThreadStatic]
			internal static glVertexAttribI3i pglVertexAttribI3i;

			internal unsafe delegate void glVertexAttribI3iv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttribI3iv")]
			[AliasOf("glVertexAttribI3ivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI3iv pglVertexAttribI3iv;

			internal delegate void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);

			[AliasOf("glVertexAttribI3ui")]
			[AliasOf("glVertexAttribI3uiEXT")]
			[ThreadStatic]
			internal static glVertexAttribI3ui pglVertexAttribI3ui;

			internal unsafe delegate void glVertexAttribI3uiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttribI3uiv")]
			[AliasOf("glVertexAttribI3uivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI3uiv pglVertexAttribI3uiv;

			internal unsafe delegate void glVertexAttribI4bv(UInt32 index, sbyte* v);

			[AliasOf("glVertexAttribI4bv")]
			[AliasOf("glVertexAttribI4bvEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4bv pglVertexAttribI4bv;

			internal delegate void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[AliasOf("glVertexAttribI4i")]
			[AliasOf("glVertexAttribI4iEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4i pglVertexAttribI4i;

			internal unsafe delegate void glVertexAttribI4iv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttribI4iv")]
			[AliasOf("glVertexAttribI4ivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4iv pglVertexAttribI4iv;

			internal unsafe delegate void glVertexAttribI4sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttribI4sv")]
			[AliasOf("glVertexAttribI4svEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4sv pglVertexAttribI4sv;

			internal unsafe delegate void glVertexAttribI4ubv(UInt32 index, byte* v);

			[AliasOf("glVertexAttribI4ubv")]
			[AliasOf("glVertexAttribI4ubvEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4ubv pglVertexAttribI4ubv;

			internal delegate void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[AliasOf("glVertexAttribI4ui")]
			[AliasOf("glVertexAttribI4uiEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4ui pglVertexAttribI4ui;

			internal unsafe delegate void glVertexAttribI4uiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttribI4uiv")]
			[AliasOf("glVertexAttribI4uivEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4uiv pglVertexAttribI4uiv;

			internal unsafe delegate void glVertexAttribI4usv(UInt32 index, UInt16* v);

			[AliasOf("glVertexAttribI4usv")]
			[AliasOf("glVertexAttribI4usvEXT")]
			[ThreadStatic]
			internal static glVertexAttribI4usv pglVertexAttribI4usv;

			internal delegate void glVertexAttribIFormat(UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexAttribIFormat pglVertexAttribIFormat;

			internal delegate void glVertexAttribIFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glVertexAttribIFormatNV pglVertexAttribIFormatNV;

			internal unsafe delegate void glVertexAttribIPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glVertexAttribIPointer")]
			[AliasOf("glVertexAttribIPointerEXT")]
			[ThreadStatic]
			internal static glVertexAttribIPointer pglVertexAttribIPointer;

			internal delegate void glVertexAttribL1d(UInt32 index, double x);

			[AliasOf("glVertexAttribL1d")]
			[AliasOf("glVertexAttribL1dEXT")]
			[ThreadStatic]
			internal static glVertexAttribL1d pglVertexAttribL1d;

			internal unsafe delegate void glVertexAttribL1dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL1dv")]
			[AliasOf("glVertexAttribL1dvEXT")]
			[ThreadStatic]
			internal static glVertexAttribL1dv pglVertexAttribL1dv;

			internal delegate void glVertexAttribL1i64NV(UInt32 index, Int64 x);

			[ThreadStatic]
			internal static glVertexAttribL1i64NV pglVertexAttribL1i64NV;

			internal unsafe delegate void glVertexAttribL1i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL1i64vNV pglVertexAttribL1i64vNV;

			internal delegate void glVertexAttribL1ui64ARB(UInt32 index, UInt64 x);

			[ThreadStatic]
			internal static glVertexAttribL1ui64ARB pglVertexAttribL1ui64ARB;

			internal delegate void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);

			[ThreadStatic]
			internal static glVertexAttribL1ui64NV pglVertexAttribL1ui64NV;

			internal unsafe delegate void glVertexAttribL1ui64vARB(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL1ui64vARB pglVertexAttribL1ui64vARB;

			internal unsafe delegate void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL1ui64vNV pglVertexAttribL1ui64vNV;

			internal delegate void glVertexAttribL2d(UInt32 index, double x, double y);

			[AliasOf("glVertexAttribL2d")]
			[AliasOf("glVertexAttribL2dEXT")]
			[ThreadStatic]
			internal static glVertexAttribL2d pglVertexAttribL2d;

			internal unsafe delegate void glVertexAttribL2dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL2dv")]
			[AliasOf("glVertexAttribL2dvEXT")]
			[ThreadStatic]
			internal static glVertexAttribL2dv pglVertexAttribL2dv;

			internal delegate void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);

			[ThreadStatic]
			internal static glVertexAttribL2i64NV pglVertexAttribL2i64NV;

			internal unsafe delegate void glVertexAttribL2i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL2i64vNV pglVertexAttribL2i64vNV;

			internal delegate void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);

			[ThreadStatic]
			internal static glVertexAttribL2ui64NV pglVertexAttribL2ui64NV;

			internal unsafe delegate void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL2ui64vNV pglVertexAttribL2ui64vNV;

			internal delegate void glVertexAttribL3d(UInt32 index, double x, double y, double z);

			[AliasOf("glVertexAttribL3d")]
			[AliasOf("glVertexAttribL3dEXT")]
			[ThreadStatic]
			internal static glVertexAttribL3d pglVertexAttribL3d;

			internal unsafe delegate void glVertexAttribL3dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL3dv")]
			[AliasOf("glVertexAttribL3dvEXT")]
			[ThreadStatic]
			internal static glVertexAttribL3dv pglVertexAttribL3dv;

			internal delegate void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);

			[ThreadStatic]
			internal static glVertexAttribL3i64NV pglVertexAttribL3i64NV;

			internal unsafe delegate void glVertexAttribL3i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL3i64vNV pglVertexAttribL3i64vNV;

			internal delegate void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);

			[ThreadStatic]
			internal static glVertexAttribL3ui64NV pglVertexAttribL3ui64NV;

			internal unsafe delegate void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL3ui64vNV pglVertexAttribL3ui64vNV;

			internal delegate void glVertexAttribL4d(UInt32 index, double x, double y, double z, double w);

			[AliasOf("glVertexAttribL4d")]
			[AliasOf("glVertexAttribL4dEXT")]
			[ThreadStatic]
			internal static glVertexAttribL4d pglVertexAttribL4d;

			internal unsafe delegate void glVertexAttribL4dv(UInt32 index, double* v);

			[AliasOf("glVertexAttribL4dv")]
			[AliasOf("glVertexAttribL4dvEXT")]
			[ThreadStatic]
			internal static glVertexAttribL4dv pglVertexAttribL4dv;

			internal delegate void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);

			[ThreadStatic]
			internal static glVertexAttribL4i64NV pglVertexAttribL4i64NV;

			internal unsafe delegate void glVertexAttribL4i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL4i64vNV pglVertexAttribL4i64vNV;

			internal delegate void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[ThreadStatic]
			internal static glVertexAttribL4ui64NV pglVertexAttribL4ui64NV;

			internal unsafe delegate void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL4ui64vNV pglVertexAttribL4ui64vNV;

			internal delegate void glVertexAttribLFormat(UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexAttribLFormat pglVertexAttribLFormat;

			internal delegate void glVertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glVertexAttribLFormatNV pglVertexAttribLFormatNV;

			internal unsafe delegate void glVertexAttribLPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glVertexAttribLPointer")]
			[AliasOf("glVertexAttribLPointerEXT")]
			[ThreadStatic]
			internal static glVertexAttribLPointer pglVertexAttribLPointer;

			internal delegate void glVertexAttribP1ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP1ui pglVertexAttribP1ui;

			internal unsafe delegate void glVertexAttribP1uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP1uiv pglVertexAttribP1uiv;

			internal delegate void glVertexAttribP2ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP2ui pglVertexAttribP2ui;

			internal unsafe delegate void glVertexAttribP2uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP2uiv pglVertexAttribP2uiv;

			internal delegate void glVertexAttribP3ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP3ui pglVertexAttribP3ui;

			internal unsafe delegate void glVertexAttribP3uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP3uiv pglVertexAttribP3uiv;

			internal delegate void glVertexAttribP4ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP4ui pglVertexAttribP4ui;

			internal unsafe delegate void glVertexAttribP4uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP4uiv pglVertexAttribP4uiv;

			internal delegate void glVertexAttribParameteriAMD(UInt32 index, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glVertexAttribParameteriAMD pglVertexAttribParameteriAMD;

			internal unsafe delegate void glVertexAttribPointer(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr pointer);

			[AliasOf("glVertexAttribPointer")]
			[AliasOf("glVertexAttribPointerARB")]
			[ThreadStatic]
			internal static glVertexAttribPointer pglVertexAttribPointer;

			internal unsafe delegate void glVertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexAttribPointerNV pglVertexAttribPointerNV;

			internal unsafe delegate void glVertexAttribs1dvNV(UInt32 index, Int32 count, double* v);

			[ThreadStatic]
			internal static glVertexAttribs1dvNV pglVertexAttribs1dvNV;

			internal unsafe delegate void glVertexAttribs1fvNV(UInt32 index, Int32 count, float* v);

			[ThreadStatic]
			internal static glVertexAttribs1fvNV pglVertexAttribs1fvNV;

			internal unsafe delegate void glVertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttribs1hvNV pglVertexAttribs1hvNV;

			internal unsafe delegate void glVertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);

			[ThreadStatic]
			internal static glVertexAttribs1svNV pglVertexAttribs1svNV;

			internal unsafe delegate void glVertexAttribs2dvNV(UInt32 index, Int32 count, double* v);

			[ThreadStatic]
			internal static glVertexAttribs2dvNV pglVertexAttribs2dvNV;

			internal unsafe delegate void glVertexAttribs2fvNV(UInt32 index, Int32 count, float* v);

			[ThreadStatic]
			internal static glVertexAttribs2fvNV pglVertexAttribs2fvNV;

			internal unsafe delegate void glVertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttribs2hvNV pglVertexAttribs2hvNV;

			internal unsafe delegate void glVertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);

			[ThreadStatic]
			internal static glVertexAttribs2svNV pglVertexAttribs2svNV;

			internal unsafe delegate void glVertexAttribs3dvNV(UInt32 index, Int32 count, double* v);

			[ThreadStatic]
			internal static glVertexAttribs3dvNV pglVertexAttribs3dvNV;

			internal unsafe delegate void glVertexAttribs3fvNV(UInt32 index, Int32 count, float* v);

			[ThreadStatic]
			internal static glVertexAttribs3fvNV pglVertexAttribs3fvNV;

			internal unsafe delegate void glVertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttribs3hvNV pglVertexAttribs3hvNV;

			internal unsafe delegate void glVertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);

			[ThreadStatic]
			internal static glVertexAttribs3svNV pglVertexAttribs3svNV;

			internal unsafe delegate void glVertexAttribs4dvNV(UInt32 index, Int32 count, double* v);

			[ThreadStatic]
			internal static glVertexAttribs4dvNV pglVertexAttribs4dvNV;

			internal unsafe delegate void glVertexAttribs4fvNV(UInt32 index, Int32 count, float* v);

			[ThreadStatic]
			internal static glVertexAttribs4fvNV pglVertexAttribs4fvNV;

			internal unsafe delegate void glVertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);

			[ThreadStatic]
			internal static glVertexAttribs4hvNV pglVertexAttribs4hvNV;

			internal unsafe delegate void glVertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);

			[ThreadStatic]
			internal static glVertexAttribs4svNV pglVertexAttribs4svNV;

			internal unsafe delegate void glVertexAttribs4ubvNV(UInt32 index, Int32 count, byte* v);

			[ThreadStatic]
			internal static glVertexAttribs4ubvNV pglVertexAttribs4ubvNV;

			internal delegate void glVertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);

			[ThreadStatic]
			internal static glVertexBindingDivisor pglVertexBindingDivisor;

			internal delegate void glVertexBlendARB(Int32 count);

			[ThreadStatic]
			internal static glVertexBlendARB pglVertexBlendARB;

			internal delegate void glVertexBlendEnvfATI(Int32 pname, float param);

			[ThreadStatic]
			internal static glVertexBlendEnvfATI pglVertexBlendEnvfATI;

			internal delegate void glVertexBlendEnviATI(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glVertexBlendEnviATI pglVertexBlendEnviATI;

			internal delegate void glVertexFormatNV(Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glVertexFormatNV pglVertexFormatNV;

			internal delegate void glVertexP2ui(Int32 type, UInt32 value);

			[ThreadStatic]
			internal static glVertexP2ui pglVertexP2ui;

			internal unsafe delegate void glVertexP2uiv(Int32 type, UInt32* value);

			[ThreadStatic]
			internal static glVertexP2uiv pglVertexP2uiv;

			internal delegate void glVertexP3ui(Int32 type, UInt32 value);

			[ThreadStatic]
			internal static glVertexP3ui pglVertexP3ui;

			internal unsafe delegate void glVertexP3uiv(Int32 type, UInt32* value);

			[ThreadStatic]
			internal static glVertexP3uiv pglVertexP3uiv;

			internal delegate void glVertexP4ui(Int32 type, UInt32 value);

			[ThreadStatic]
			internal static glVertexP4ui pglVertexP4ui;

			internal unsafe delegate void glVertexP4uiv(Int32 type, UInt32* value);

			[ThreadStatic]
			internal static glVertexP4uiv pglVertexP4uiv;

			internal unsafe delegate void glVertexPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexPointer pglVertexPointer;

			internal unsafe delegate void glVertexPointerEXT(Int32 size, Int32 type, Int32 stride, Int32 count, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexPointerEXT pglVertexPointerEXT;

			internal unsafe delegate void glVertexPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[ThreadStatic]
			internal static glVertexPointerListIBM pglVertexPointerListIBM;

			internal unsafe delegate void glVertexPointervINTEL(Int32 size, Int32 type, IntPtr* pointer);

			[ThreadStatic]
			internal static glVertexPointervINTEL pglVertexPointervINTEL;

			internal delegate void glVertexStream1dATI(Int32 stream, double x);

			[ThreadStatic]
			internal static glVertexStream1dATI pglVertexStream1dATI;

			internal unsafe delegate void glVertexStream1dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream1dvATI pglVertexStream1dvATI;

			internal delegate void glVertexStream1fATI(Int32 stream, float x);

			[ThreadStatic]
			internal static glVertexStream1fATI pglVertexStream1fATI;

			internal unsafe delegate void glVertexStream1fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream1fvATI pglVertexStream1fvATI;

			internal delegate void glVertexStream1iATI(Int32 stream, Int32 x);

			[ThreadStatic]
			internal static glVertexStream1iATI pglVertexStream1iATI;

			internal unsafe delegate void glVertexStream1ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream1ivATI pglVertexStream1ivATI;

			internal delegate void glVertexStream1sATI(Int32 stream, Int16 x);

			[ThreadStatic]
			internal static glVertexStream1sATI pglVertexStream1sATI;

			internal unsafe delegate void glVertexStream1svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream1svATI pglVertexStream1svATI;

			internal delegate void glVertexStream2dATI(Int32 stream, double x, double y);

			[ThreadStatic]
			internal static glVertexStream2dATI pglVertexStream2dATI;

			internal unsafe delegate void glVertexStream2dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream2dvATI pglVertexStream2dvATI;

			internal delegate void glVertexStream2fATI(Int32 stream, float x, float y);

			[ThreadStatic]
			internal static glVertexStream2fATI pglVertexStream2fATI;

			internal unsafe delegate void glVertexStream2fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream2fvATI pglVertexStream2fvATI;

			internal delegate void glVertexStream2iATI(Int32 stream, Int32 x, Int32 y);

			[ThreadStatic]
			internal static glVertexStream2iATI pglVertexStream2iATI;

			internal unsafe delegate void glVertexStream2ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream2ivATI pglVertexStream2ivATI;

			internal delegate void glVertexStream2sATI(Int32 stream, Int16 x, Int16 y);

			[ThreadStatic]
			internal static glVertexStream2sATI pglVertexStream2sATI;

			internal unsafe delegate void glVertexStream2svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream2svATI pglVertexStream2svATI;

			internal delegate void glVertexStream3dATI(Int32 stream, double x, double y, double z);

			[ThreadStatic]
			internal static glVertexStream3dATI pglVertexStream3dATI;

			internal unsafe delegate void glVertexStream3dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream3dvATI pglVertexStream3dvATI;

			internal delegate void glVertexStream3fATI(Int32 stream, float x, float y, float z);

			[ThreadStatic]
			internal static glVertexStream3fATI pglVertexStream3fATI;

			internal unsafe delegate void glVertexStream3fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream3fvATI pglVertexStream3fvATI;

			internal delegate void glVertexStream3iATI(Int32 stream, Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glVertexStream3iATI pglVertexStream3iATI;

			internal unsafe delegate void glVertexStream3ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream3ivATI pglVertexStream3ivATI;

			internal delegate void glVertexStream3sATI(Int32 stream, Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glVertexStream3sATI pglVertexStream3sATI;

			internal unsafe delegate void glVertexStream3svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream3svATI pglVertexStream3svATI;

			internal delegate void glVertexStream4dATI(Int32 stream, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glVertexStream4dATI pglVertexStream4dATI;

			internal unsafe delegate void glVertexStream4dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream4dvATI pglVertexStream4dvATI;

			internal delegate void glVertexStream4fATI(Int32 stream, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glVertexStream4fATI pglVertexStream4fATI;

			internal unsafe delegate void glVertexStream4fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream4fvATI pglVertexStream4fvATI;

			internal delegate void glVertexStream4iATI(Int32 stream, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glVertexStream4iATI pglVertexStream4iATI;

			internal unsafe delegate void glVertexStream4ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream4ivATI pglVertexStream4ivATI;

			internal delegate void glVertexStream4sATI(Int32 stream, Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glVertexStream4sATI pglVertexStream4sATI;

			internal unsafe delegate void glVertexStream4svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream4svATI pglVertexStream4svATI;

			internal unsafe delegate void glVertexWeightPointerEXT(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexWeightPointerEXT pglVertexWeightPointerEXT;

			internal delegate void glVertexWeightfEXT(float weight);

			[ThreadStatic]
			internal static glVertexWeightfEXT pglVertexWeightfEXT;

			internal unsafe delegate void glVertexWeightfvEXT(float* weight);

			[ThreadStatic]
			internal static glVertexWeightfvEXT pglVertexWeightfvEXT;

			internal delegate void glVertexWeighthNV(UInt16 weight);

			[ThreadStatic]
			internal static glVertexWeighthNV pglVertexWeighthNV;

			internal unsafe delegate void glVertexWeighthvNV(UInt16* weight);

			[ThreadStatic]
			internal static glVertexWeighthvNV pglVertexWeighthvNV;

			internal unsafe delegate Int32 glVideoCaptureNV(UInt32 video_capture_slot, UInt32* sequence_num, UInt64* capture_time);

			[ThreadStatic]
			internal static glVideoCaptureNV pglVideoCaptureNV;

			internal unsafe delegate void glVideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glVideoCaptureStreamParameterdvNV pglVideoCaptureStreamParameterdvNV;

			internal unsafe delegate void glVideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glVideoCaptureStreamParameterfvNV pglVideoCaptureStreamParameterfvNV;

			internal unsafe delegate void glVideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glVideoCaptureStreamParameterivNV pglVideoCaptureStreamParameterivNV;

			internal delegate void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glViewport pglViewport;

			internal unsafe delegate void glViewportArrayv(UInt32 first, Int32 count, float* v);

			[AliasOf("glViewportArrayv")]
			[AliasOf("glViewportArrayvNV")]
			[ThreadStatic]
			internal static glViewportArrayv pglViewportArrayv;

			internal delegate void glViewportIndexedf(UInt32 index, float x, float y, float w, float h);

			[AliasOf("glViewportIndexedf")]
			[AliasOf("glViewportIndexedfNV")]
			[ThreadStatic]
			internal static glViewportIndexedf pglViewportIndexedf;

			internal unsafe delegate void glViewportIndexedfv(UInt32 index, float* v);

			[AliasOf("glViewportIndexedfv")]
			[AliasOf("glViewportIndexedfvNV")]
			[ThreadStatic]
			internal static glViewportIndexedfv pglViewportIndexedfv;

			internal delegate void glWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			[AliasOf("glWaitSync")]
			[AliasOf("glWaitSyncAPPLE")]
			[ThreadStatic]
			internal static glWaitSync pglWaitSync;

			internal unsafe delegate void glWeightPathsNV(UInt32 resultPath, Int32 numPaths, UInt32* paths, float* weights);

			[ThreadStatic]
			internal static glWeightPathsNV pglWeightPathsNV;

			internal unsafe delegate void glWeightPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glWeightPointerARB pglWeightPointerARB;

			internal unsafe delegate void glWeightPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glWeightPointerOES pglWeightPointerOES;

			internal unsafe delegate void glWeightbvARB(Int32 size, sbyte* weights);

			[ThreadStatic]
			internal static glWeightbvARB pglWeightbvARB;

			internal unsafe delegate void glWeightdvARB(Int32 size, double* weights);

			[ThreadStatic]
			internal static glWeightdvARB pglWeightdvARB;

			internal unsafe delegate void glWeightfvARB(Int32 size, float* weights);

			[ThreadStatic]
			internal static glWeightfvARB pglWeightfvARB;

			internal unsafe delegate void glWeightivARB(Int32 size, Int32* weights);

			[ThreadStatic]
			internal static glWeightivARB pglWeightivARB;

			internal unsafe delegate void glWeightsvARB(Int32 size, Int16* weights);

			[ThreadStatic]
			internal static glWeightsvARB pglWeightsvARB;

			internal unsafe delegate void glWeightubvARB(Int32 size, byte* weights);

			[ThreadStatic]
			internal static glWeightubvARB pglWeightubvARB;

			internal unsafe delegate void glWeightuivARB(Int32 size, UInt32* weights);

			[ThreadStatic]
			internal static glWeightuivARB pglWeightuivARB;

			internal unsafe delegate void glWeightusvARB(Int32 size, UInt16* weights);

			[ThreadStatic]
			internal static glWeightusvARB pglWeightusvARB;

			internal delegate void glWindowPos2d(double x, double y);

			[AliasOf("glWindowPos2d")]
			[AliasOf("glWindowPos2dARB")]
			[AliasOf("glWindowPos2dMESA")]
			[ThreadStatic]
			internal static glWindowPos2d pglWindowPos2d;

			internal unsafe delegate void glWindowPos2dv(double* v);

			[AliasOf("glWindowPos2dv")]
			[AliasOf("glWindowPos2dvARB")]
			[AliasOf("glWindowPos2dvMESA")]
			[ThreadStatic]
			internal static glWindowPos2dv pglWindowPos2dv;

			internal delegate void glWindowPos2f(float x, float y);

			[AliasOf("glWindowPos2f")]
			[AliasOf("glWindowPos2fARB")]
			[AliasOf("glWindowPos2fMESA")]
			[ThreadStatic]
			internal static glWindowPos2f pglWindowPos2f;

			internal unsafe delegate void glWindowPos2fv(float* v);

			[AliasOf("glWindowPos2fv")]
			[AliasOf("glWindowPos2fvARB")]
			[AliasOf("glWindowPos2fvMESA")]
			[ThreadStatic]
			internal static glWindowPos2fv pglWindowPos2fv;

			internal delegate void glWindowPos2i(Int32 x, Int32 y);

			[AliasOf("glWindowPos2i")]
			[AliasOf("glWindowPos2iARB")]
			[AliasOf("glWindowPos2iMESA")]
			[ThreadStatic]
			internal static glWindowPos2i pglWindowPos2i;

			internal unsafe delegate void glWindowPos2iv(Int32* v);

			[AliasOf("glWindowPos2iv")]
			[AliasOf("glWindowPos2ivARB")]
			[AliasOf("glWindowPos2ivMESA")]
			[ThreadStatic]
			internal static glWindowPos2iv pglWindowPos2iv;

			internal delegate void glWindowPos2s(Int16 x, Int16 y);

			[AliasOf("glWindowPos2s")]
			[AliasOf("glWindowPos2sARB")]
			[AliasOf("glWindowPos2sMESA")]
			[ThreadStatic]
			internal static glWindowPos2s pglWindowPos2s;

			internal unsafe delegate void glWindowPos2sv(Int16* v);

			[AliasOf("glWindowPos2sv")]
			[AliasOf("glWindowPos2svARB")]
			[AliasOf("glWindowPos2svMESA")]
			[ThreadStatic]
			internal static glWindowPos2sv pglWindowPos2sv;

			internal delegate void glWindowPos3d(double x, double y, double z);

			[AliasOf("glWindowPos3d")]
			[AliasOf("glWindowPos3dARB")]
			[AliasOf("glWindowPos3dMESA")]
			[ThreadStatic]
			internal static glWindowPos3d pglWindowPos3d;

			internal unsafe delegate void glWindowPos3dv(double* v);

			[AliasOf("glWindowPos3dv")]
			[AliasOf("glWindowPos3dvARB")]
			[AliasOf("glWindowPos3dvMESA")]
			[ThreadStatic]
			internal static glWindowPos3dv pglWindowPos3dv;

			internal delegate void glWindowPos3f(float x, float y, float z);

			[AliasOf("glWindowPos3f")]
			[AliasOf("glWindowPos3fARB")]
			[AliasOf("glWindowPos3fMESA")]
			[ThreadStatic]
			internal static glWindowPos3f pglWindowPos3f;

			internal unsafe delegate void glWindowPos3fv(float* v);

			[AliasOf("glWindowPos3fv")]
			[AliasOf("glWindowPos3fvARB")]
			[AliasOf("glWindowPos3fvMESA")]
			[ThreadStatic]
			internal static glWindowPos3fv pglWindowPos3fv;

			internal delegate void glWindowPos3i(Int32 x, Int32 y, Int32 z);

			[AliasOf("glWindowPos3i")]
			[AliasOf("glWindowPos3iARB")]
			[AliasOf("glWindowPos3iMESA")]
			[ThreadStatic]
			internal static glWindowPos3i pglWindowPos3i;

			internal unsafe delegate void glWindowPos3iv(Int32* v);

			[AliasOf("glWindowPos3iv")]
			[AliasOf("glWindowPos3ivARB")]
			[AliasOf("glWindowPos3ivMESA")]
			[ThreadStatic]
			internal static glWindowPos3iv pglWindowPos3iv;

			internal delegate void glWindowPos3s(Int16 x, Int16 y, Int16 z);

			[AliasOf("glWindowPos3s")]
			[AliasOf("glWindowPos3sARB")]
			[AliasOf("glWindowPos3sMESA")]
			[ThreadStatic]
			internal static glWindowPos3s pglWindowPos3s;

			internal unsafe delegate void glWindowPos3sv(Int16* v);

			[AliasOf("glWindowPos3sv")]
			[AliasOf("glWindowPos3svARB")]
			[AliasOf("glWindowPos3svMESA")]
			[ThreadStatic]
			internal static glWindowPos3sv pglWindowPos3sv;

			internal delegate void glWindowPos4dMESA(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glWindowPos4dMESA pglWindowPos4dMESA;

			internal unsafe delegate void glWindowPos4dvMESA(double* v);

			[ThreadStatic]
			internal static glWindowPos4dvMESA pglWindowPos4dvMESA;

			internal delegate void glWindowPos4fMESA(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glWindowPos4fMESA pglWindowPos4fMESA;

			internal unsafe delegate void glWindowPos4fvMESA(float* v);

			[ThreadStatic]
			internal static glWindowPos4fvMESA pglWindowPos4fvMESA;

			internal delegate void glWindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glWindowPos4iMESA pglWindowPos4iMESA;

			internal unsafe delegate void glWindowPos4ivMESA(Int32* v);

			[ThreadStatic]
			internal static glWindowPos4ivMESA pglWindowPos4ivMESA;

			internal delegate void glWindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glWindowPos4sMESA pglWindowPos4sMESA;

			internal unsafe delegate void glWindowPos4svMESA(Int16* v);

			[ThreadStatic]
			internal static glWindowPos4svMESA pglWindowPos4svMESA;

			internal delegate void glWriteMaskEXT(UInt32 res, UInt32 @in, Int32 outX, Int32 outY, Int32 outZ, Int32 outW);

			[ThreadStatic]
			internal static glWriteMaskEXT pglWriteMaskEXT;

		}
	}

}

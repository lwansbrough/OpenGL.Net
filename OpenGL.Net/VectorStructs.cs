
// Copyright (c) 2010 Ananth B.
// All rights reserved.
// 
// The contents of this file are made available under the terms of the
// Eclipse Public License v1.0 (the "License") which accompanies this
// distribution, and is available at the following URL:
// http://www.opensource.org/licenses/eclipse-1.0.php
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either expressed or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// By using this software in any fashion, you are agreeing to be bound by the
// terms of the License.
//
// Copyright (C) 2016 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Vector interface.
	/// </summary>
	public interface IVector
	{
		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int Rank { get; }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int Size { get; }
	}

	/// <summary>
	/// Vector of 2 sbyte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("sbyte2: x={x}, y={y}")]
	public partial struct sbyte2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a sbyte2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the vector's components value.
		/// </param>
		public sbyte2(sbyte v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a sbyte2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public sbyte2(sbyte x, sbyte y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public sbyte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this sbyte2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this sbyte2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 sbyte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("sbyte3: x={x}, y={y}, z={z}")]
	public partial struct sbyte3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a sbyte3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the vector's components value.
		/// </param>
		public sbyte3(sbyte v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a sbyte3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public sbyte3(sbyte x, sbyte y, sbyte z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public sbyte z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public sbyte s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public sbyte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this sbyte3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this sbyte3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 sbyte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("sbyte4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct sbyte4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a sbyte4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the vector's components value.
		/// </param>
		public sbyte4(sbyte v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a sbyte4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public sbyte4(sbyte x, sbyte y, sbyte z, sbyte w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public sbyte z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public sbyte s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public sbyte w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public sbyte s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public sbyte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this sbyte4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this sbyte4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 sbyte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("sbyte8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct sbyte8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a sbyte8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the vector's components value.
		/// </param>
		public sbyte8(sbyte v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a sbyte8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public sbyte8(sbyte s0, sbyte s1, sbyte s2, sbyte s3, sbyte s4, sbyte s5, sbyte s6, sbyte s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public sbyte s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public sbyte s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(4)]
		public sbyte s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(5)]
		public sbyte s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(6)]
		public sbyte s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(7)]
		public sbyte s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public sbyte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this sbyte8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this sbyte8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 sbyte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("sbyte16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct sbyte16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a sbyte16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the vector's components value.
		/// </param>
		public sbyte16(sbyte v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a sbyte16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public sbyte16(sbyte s0, sbyte s1, sbyte s2, sbyte s3, sbyte s4, sbyte s5, sbyte s6, sbyte s7, sbyte s8, sbyte s9, sbyte sa, sbyte sb, sbyte sc, sbyte sd, sbyte se, sbyte sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public sbyte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public sbyte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public sbyte s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public sbyte s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(4)]
		public sbyte s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(5)]
		public sbyte s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(6)]
		public sbyte s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(7)]
		public sbyte s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(8)]
		public sbyte s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(9)]
		public sbyte s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(10)]
		public sbyte sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(10)]
		public sbyte sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(11)]
		public sbyte sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(11)]
		public sbyte sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(12)]
		public sbyte sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(12)]
		public sbyte sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(13)]
		public sbyte sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(13)]
		public sbyte sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(14)]
		public sbyte se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(14)]
		public sbyte sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(15)]
		public sbyte sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(15)]
		public sbyte sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public sbyte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this sbyte16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this sbyte16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 byte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("byte2: x={x}, y={y}")]
	public partial struct byte2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a byte2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the vector's components value.
		/// </param>
		public byte2(byte v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a byte2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public byte2(byte x, byte y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public byte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this byte2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this byte2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 byte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("byte3: x={x}, y={y}, z={z}")]
	public partial struct byte3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a byte3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the vector's components value.
		/// </param>
		public byte3(byte v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a byte3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public byte3(byte x, byte y, byte z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public byte z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public byte s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public byte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this byte3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this byte3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 byte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("byte4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct byte4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a byte4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the vector's components value.
		/// </param>
		public byte4(byte v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a byte4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public byte4(byte x, byte y, byte z, byte w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public byte z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public byte s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public byte w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public byte s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public byte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this byte4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this byte4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 byte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("byte8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct byte8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a byte8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the vector's components value.
		/// </param>
		public byte8(byte v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a byte8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public byte8(byte s0, byte s1, byte s2, byte s3, byte s4, byte s5, byte s6, byte s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public byte s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public byte s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(4)]
		public byte s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(5)]
		public byte s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(6)]
		public byte s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(7)]
		public byte s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public byte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this byte8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this byte8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 byte.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("byte16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct byte16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a byte16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the vector's components value.
		/// </param>
		public byte16(byte v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a byte16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public byte16(byte s0, byte s1, byte s2, byte s3, byte s4, byte s5, byte s6, byte s7, byte s8, byte s9, byte sa, byte sb, byte sc, byte sd, byte se, byte sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public byte s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(1)]
		public byte s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(2)]
		public byte s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(3)]
		public byte s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(4)]
		public byte s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(5)]
		public byte s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(6)]
		public byte s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(7)]
		public byte s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(8)]
		public byte s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(9)]
		public byte s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(10)]
		public byte sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(10)]
		public byte sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(11)]
		public byte sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(11)]
		public byte sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(12)]
		public byte sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(12)]
		public byte sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(13)]
		public byte sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(13)]
		public byte sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(14)]
		public byte se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(14)]
		public byte sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(15)]
		public byte sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(15)]
		public byte sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public byte this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this byte16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this byte16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 1); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 short.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("short2: x={x}, y={y}")]
	public partial struct short2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a short2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the vector's components value.
		/// </param>
		public short2(short v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a short2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public short2(short x, short y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public short this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this short2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this short2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 short.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("short3: x={x}, y={y}, z={z}")]
	public partial struct short3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a short3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the vector's components value.
		/// </param>
		public short3(short v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a short3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public short3(short x, short y, short z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public short z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public short s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public short this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this short3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this short3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 short.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("short4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct short4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a short4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the vector's components value.
		/// </param>
		public short4(short v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a short4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public short4(short x, short y, short z, short w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public short z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public short s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public short w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public short s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public short this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this short4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this short4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 short.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("short8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct short8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a short8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the vector's components value.
		/// </param>
		public short8(short v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a short8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public short8(short s0, short s1, short s2, short s3, short s4, short s5, short s6, short s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public short s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public short s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(8)]
		public short s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(10)]
		public short s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(12)]
		public short s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(14)]
		public short s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public short this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this short8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this short8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 short.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("short16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct short16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a short16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the vector's components value.
		/// </param>
		public short16(short v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a short16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public short16(short s0, short s1, short s2, short s3, short s4, short s5, short s6, short s7, short s8, short s9, short sa, short sb, short sc, short sd, short se, short sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public short s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public short s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public short s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public short s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(8)]
		public short s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(10)]
		public short s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(12)]
		public short s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(14)]
		public short s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(16)]
		public short s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(18)]
		public short s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(20)]
		public short sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(20)]
		public short sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(22)]
		public short sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(22)]
		public short sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(24)]
		public short sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(24)]
		public short sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(26)]
		public short sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(26)]
		public short sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(28)]
		public short se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(28)]
		public short sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(30)]
		public short sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(30)]
		public short sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public short this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this short16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this short16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 ushort.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ushort2: x={x}, y={y}")]
	public partial struct ushort2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ushort2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the vector's components value.
		/// </param>
		public ushort2(ushort v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a ushort2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public ushort2(ushort x, ushort y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ushort this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ushort2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ushort2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 ushort.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ushort3: x={x}, y={y}, z={z}")]
	public partial struct ushort3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ushort3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the vector's components value.
		/// </param>
		public ushort3(ushort v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a ushort3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public ushort3(ushort x, ushort y, ushort z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public ushort z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public ushort s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ushort this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ushort3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ushort3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 ushort.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ushort4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct ushort4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ushort4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the vector's components value.
		/// </param>
		public ushort4(ushort v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a ushort4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public ushort4(ushort x, ushort y, ushort z, ushort w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public ushort z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public ushort s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public ushort w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public ushort s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ushort this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ushort4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ushort4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 ushort.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ushort8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct ushort8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ushort8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the vector's components value.
		/// </param>
		public ushort8(ushort v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a ushort8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public ushort8(ushort s0, ushort s1, ushort s2, ushort s3, ushort s4, ushort s5, ushort s6, ushort s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public ushort s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public ushort s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ushort s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(10)]
		public ushort s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(12)]
		public ushort s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(14)]
		public ushort s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ushort this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ushort8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ushort8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 ushort.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ushort16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct ushort16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ushort16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the vector's components value.
		/// </param>
		public ushort16(ushort v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a ushort16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public ushort16(ushort s0, ushort s1, ushort s2, ushort s3, ushort s4, ushort s5, ushort s6, ushort s7, ushort s8, ushort s9, ushort sa, ushort sb, ushort sc, ushort sd, ushort se, ushort sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ushort s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(2)]
		public ushort s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(4)]
		public ushort s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(6)]
		public ushort s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ushort s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(10)]
		public ushort s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(12)]
		public ushort s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(14)]
		public ushort s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ushort s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(18)]
		public ushort s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(20)]
		public ushort sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(20)]
		public ushort sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(22)]
		public ushort sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(22)]
		public ushort sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(24)]
		public ushort sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(24)]
		public ushort sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(26)]
		public ushort sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(26)]
		public ushort sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(28)]
		public ushort se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(28)]
		public ushort sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(30)]
		public ushort sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(30)]
		public ushort sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ushort this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ushort16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ushort16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 2); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 int.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("int2: x={x}, y={y}")]
	public partial struct int2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a int2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the vector's components value.
		/// </param>
		public int2(int v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a int2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public int2(int x, int y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public int this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this int2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this int2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 int.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("int3: x={x}, y={y}, z={z}")]
	public partial struct int3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a int3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the vector's components value.
		/// </param>
		public int3(int v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a int3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public int3(int x, int y, int z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public int z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public int s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public int this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this int3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this int3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 int.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("int4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct int4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a int4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the vector's components value.
		/// </param>
		public int4(int v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a int4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public int4(int x, int y, int z, int w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public int z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public int s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public int w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public int s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public int this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this int4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this int4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 int.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("int8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct int8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a int8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the vector's components value.
		/// </param>
		public int8(int v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a int8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public int8(int s0, int s1, int s2, int s3, int s4, int s5, int s6, int s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public int s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public int s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(16)]
		public int s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(20)]
		public int s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(24)]
		public int s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(28)]
		public int s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public int this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this int8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this int8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 int.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("int16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct int16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a int16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the vector's components value.
		/// </param>
		public int16(int v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a int16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public int16(int s0, int s1, int s2, int s3, int s4, int s5, int s6, int s7, int s8, int s9, int sa, int sb, int sc, int sd, int se, int sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public int s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public int s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public int s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public int s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(16)]
		public int s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(20)]
		public int s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(24)]
		public int s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(28)]
		public int s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(32)]
		public int s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(36)]
		public int s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(40)]
		public int sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(40)]
		public int sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(44)]
		public int sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(44)]
		public int sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(48)]
		public int sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(48)]
		public int sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(52)]
		public int sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(52)]
		public int sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(56)]
		public int se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(56)]
		public int sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(60)]
		public int sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(60)]
		public int sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public int this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this int16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this int16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 uint.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("uint2: x={x}, y={y}")]
	public partial struct uint2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a uint2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the vector's components value.
		/// </param>
		public uint2(uint v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a uint2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public uint2(uint x, uint y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public uint this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this uint2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this uint2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 uint.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("uint3: x={x}, y={y}, z={z}")]
	public partial struct uint3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a uint3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the vector's components value.
		/// </param>
		public uint3(uint v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a uint3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public uint3(uint x, uint y, uint z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public uint z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public uint s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public uint this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this uint3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this uint3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 uint.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("uint4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct uint4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a uint4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the vector's components value.
		/// </param>
		public uint4(uint v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a uint4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public uint4(uint x, uint y, uint z, uint w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public uint z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public uint s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public uint w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public uint s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public uint this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this uint4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this uint4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 uint.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("uint8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct uint8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a uint8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the vector's components value.
		/// </param>
		public uint8(uint v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a uint8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public uint8(uint s0, uint s1, uint s2, uint s3, uint s4, uint s5, uint s6, uint s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public uint s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public uint s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(16)]
		public uint s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(20)]
		public uint s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(24)]
		public uint s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(28)]
		public uint s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public uint this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this uint8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this uint8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 uint.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("uint16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct uint16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a uint16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the vector's components value.
		/// </param>
		public uint16(uint v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a uint16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public uint16(uint s0, uint s1, uint s2, uint s3, uint s4, uint s5, uint s6, uint s7, uint s8, uint s9, uint sa, uint sb, uint sc, uint sd, uint se, uint sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public uint s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public uint s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public uint s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public uint s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(16)]
		public uint s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(20)]
		public uint s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(24)]
		public uint s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(28)]
		public uint s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(32)]
		public uint s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(36)]
		public uint s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(40)]
		public uint sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(40)]
		public uint sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(44)]
		public uint sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(44)]
		public uint sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(48)]
		public uint sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(48)]
		public uint sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(52)]
		public uint sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(52)]
		public uint sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(56)]
		public uint se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(56)]
		public uint sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(60)]
		public uint sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(60)]
		public uint sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public uint this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this uint16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this uint16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 long.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("long2: x={x}, y={y}")]
	public partial struct long2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a long2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="long"/> that specify the vector's components value.
		/// </param>
		public long2(long v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a long2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public long2(long x, long y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public long this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this long2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this long2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 long.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("long3: x={x}, y={y}, z={z}")]
	public partial struct long3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a long3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="long"/> that specify the vector's components value.
		/// </param>
		public long3(long v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a long3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public long3(long x, long y, long z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public long z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public long s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public long this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this long3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this long3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 long.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("long4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct long4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a long4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="long"/> that specify the vector's components value.
		/// </param>
		public long4(long v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a long4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public long4(long x, long y, long z, long w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public long z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public long s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public long w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public long s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public long this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this long4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this long4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 long.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("long8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct long8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a long8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="long"/> that specify the vector's components value.
		/// </param>
		public long8(long v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a long8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public long8(long s0, long s1, long s2, long s3, long s4, long s5, long s6, long s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public long s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public long s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(32)]
		public long s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(40)]
		public long s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(48)]
		public long s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(56)]
		public long s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public long this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this long8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this long8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 long.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("long16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct long16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a long16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="long"/> that specify the vector's components value.
		/// </param>
		public long16(long v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a long16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public long16(long s0, long s1, long s2, long s3, long s4, long s5, long s6, long s7, long s8, long s9, long sa, long sb, long sc, long sd, long se, long sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public long s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public long s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public long s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public long s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(32)]
		public long s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(40)]
		public long s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(48)]
		public long s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(56)]
		public long s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(64)]
		public long s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(72)]
		public long s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(80)]
		public long sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(80)]
		public long sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(88)]
		public long sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(88)]
		public long sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(96)]
		public long sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(96)]
		public long sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(104)]
		public long sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(104)]
		public long sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(112)]
		public long se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(112)]
		public long sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(120)]
		public long sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(120)]
		public long sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public long this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this long16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this long16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 ulong.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ulong2: x={x}, y={y}")]
	public partial struct ulong2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ulong2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ulong"/> that specify the vector's components value.
		/// </param>
		public ulong2(ulong v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a ulong2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public ulong2(ulong x, ulong y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ulong this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ulong2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ulong2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 ulong.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ulong3: x={x}, y={y}, z={z}")]
	public partial struct ulong3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ulong3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ulong"/> that specify the vector's components value.
		/// </param>
		public ulong3(ulong v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a ulong3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public ulong3(ulong x, ulong y, ulong z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ulong z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ulong s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ulong this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ulong3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ulong3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 ulong.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ulong4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct ulong4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ulong4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ulong"/> that specify the vector's components value.
		/// </param>
		public ulong4(ulong v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a ulong4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public ulong4(ulong x, ulong y, ulong z, ulong w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ulong z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ulong s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public ulong w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public ulong s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ulong this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ulong4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ulong4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 ulong.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ulong8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct ulong8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ulong8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ulong"/> that specify the vector's components value.
		/// </param>
		public ulong8(ulong v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a ulong8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public ulong8(ulong s0, ulong s1, ulong s2, ulong s3, ulong s4, ulong s5, ulong s6, ulong s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ulong s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public ulong s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(32)]
		public ulong s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(40)]
		public ulong s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(48)]
		public ulong s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(56)]
		public ulong s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ulong this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ulong8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ulong8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 ulong.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("ulong16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct ulong16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a ulong16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ulong"/> that specify the vector's components value.
		/// </param>
		public ulong16(ulong v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a ulong16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public ulong16(ulong s0, ulong s1, ulong s2, ulong s3, ulong s4, ulong s5, ulong s6, ulong s7, ulong s8, ulong s9, ulong sa, ulong sb, ulong sc, ulong sd, ulong se, ulong sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public ulong s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public ulong s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public ulong s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public ulong s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(32)]
		public ulong s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(40)]
		public ulong s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(48)]
		public ulong s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(56)]
		public ulong s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(64)]
		public ulong s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(72)]
		public ulong s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(80)]
		public ulong sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(80)]
		public ulong sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(88)]
		public ulong sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(88)]
		public ulong sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(96)]
		public ulong sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(96)]
		public ulong sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(104)]
		public ulong sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(104)]
		public ulong sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(112)]
		public ulong se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(112)]
		public ulong sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(120)]
		public ulong sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(120)]
		public ulong sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public ulong this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this ulong16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this ulong16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 float.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("float2: x={x}, y={y}")]
	public partial struct float2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a float2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the vector's components value.
		/// </param>
		public float2(float v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a float2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public float2(float x, float y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public float this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this float2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this float2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 float.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("float3: x={x}, y={y}, z={z}")]
	public partial struct float3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a float3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the vector's components value.
		/// </param>
		public float3(float v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a float3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public float3(float x, float y, float z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public float z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public float s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public float this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this float3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this float3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 float.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("float4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct float4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a float4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the vector's components value.
		/// </param>
		public float4(float v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a float4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public float4(float x, float y, float z, float w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public float z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public float s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public float w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public float s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public float this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this float4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this float4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 float.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("float8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct float8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a float8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the vector's components value.
		/// </param>
		public float8(float v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a float8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public float8(float s0, float s1, float s2, float s3, float s4, float s5, float s6, float s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public float s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public float s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(16)]
		public float s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(20)]
		public float s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(24)]
		public float s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(28)]
		public float s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public float this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this float8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this float8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 float.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("float16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct float16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a float16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the vector's components value.
		/// </param>
		public float16(float v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a float16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public float16(float s0, float s1, float s2, float s3, float s4, float s5, float s6, float s7, float s8, float s9, float sa, float sb, float sc, float sd, float se, float sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public float s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(4)]
		public float s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(8)]
		public float s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(12)]
		public float s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(16)]
		public float s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(20)]
		public float s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(24)]
		public float s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(28)]
		public float s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(32)]
		public float s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(36)]
		public float s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(40)]
		public float sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(40)]
		public float sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(44)]
		public float sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(44)]
		public float sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(48)]
		public float sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(48)]
		public float sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(52)]
		public float sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(52)]
		public float sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(56)]
		public float se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(56)]
		public float sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(60)]
		public float sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(60)]
		public float sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public float this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this float16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this float16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 4); } }

		#endregion
	}

	/// <summary>
	/// Vector of 2 double.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("double2: x={x}, y={y}")]
	public partial struct double2 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a double2 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the vector's components value.
		/// </param>
		public double2(double v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
		}


		/// <summary>
		/// Construct a double2 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		public double2(double x, double y)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double s1;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public double this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this double2.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this double2.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1}|", x, y);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (2); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (2 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 3 double.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("double3: x={x}, y={y}, z={z}")]
	public partial struct double3 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a double3 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the vector's components value.
		/// </param>
		public double3(double v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
		}


		/// <summary>
		/// Construct a double3 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		public double3(double x, double y, double z)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public double z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public double s2;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public double this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this double3.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this double3.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2}|", x, y, z);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (3); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (3 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 4 double.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("double4: x={x}, y={y}, z={z}, w={w}")]
	public partial struct double4 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a double4 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the vector's components value.
		/// </param>
		public double4(double v)
		{
			x = 			s0 = v;
			y = 			s1 = v;
			z = 			s2 = v;
			w = 			s3 = v;
		}


		/// <summary>
		/// Construct a double4 specifying all vector components.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		public double4(double x, double y, double z, double w)
		{
			this.x = 			this.s0 = x;
			this.y = 			this.s1 = y;
			this.z = 			this.s2 = z;
			this.w = 			this.s3 = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double x;

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double y;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public double z;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public double s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public double w;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public double s3;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public double this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (x);
					case 1: return (y);
					case 2: return (z);
					case 3: return (w);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this double4.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this double4.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3}|", x, y, z, w);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (4); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (4 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 8 double.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("double8: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}")]
	public partial struct double8 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a double8 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the vector's components value.
		/// </param>
		public double8(double v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
		}


		/// <summary>
		/// Construct a double8 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		public double8(double s0, double s1, double s2, double s3, double s4, double s5, double s6, double s7)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public double s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public double s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(32)]
		public double s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(40)]
		public double s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(48)]
		public double s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(56)]
		public double s7;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public double this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this double8.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this double8.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7}|", s0, s1, s2, s3, s4, s5, s6, s7);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (8); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (8 * 8); } }

		#endregion
	}

	/// <summary>
	/// Vector of 16 double.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerDisplay("double16: s0={s0}, s1={s1}, s2={s2}, s3={s3}, s4={s4}, s5={s5}, s6={s6}, s7={s7}, s8={s8}, s9={s9}, sa={sa}, sb={sb}, sc={sc}, sd={sd}, se={se}, sf={sf}")]
	public partial struct double16 : IVector
	{
		#region Constructors

		/// <summary>
		/// Construct a double16 with all components equals to the specified value.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the vector's components value.
		/// </param>
		public double16(double v)
		{
			s0 = v;
			s1 = v;
			s2 = v;
			s3 = v;
			s4 = v;
			s5 = v;
			s6 = v;
			s7 = v;
			s8 = v;
			s9 = v;
			sa = 			sA = v;
			sb = 			sB = v;
			sc = 			sC = v;
			sd = 			sD = v;
			se = 			sE = v;
			sf = 			sF = v;
		}


		/// <summary>
		/// Construct a double16 specifying all vector components.
		/// </summary>
		/// <param name="s0">
		/// A <see cref="sbyte"/> that specify the 1th vector's component value.
		/// </param>
		/// <param name="s1">
		/// A <see cref="sbyte"/> that specify the 2th vector's component value.
		/// </param>
		/// <param name="s2">
		/// A <see cref="sbyte"/> that specify the 3th vector's component value.
		/// </param>
		/// <param name="s3">
		/// A <see cref="sbyte"/> that specify the 4th vector's component value.
		/// </param>
		/// <param name="s4">
		/// A <see cref="sbyte"/> that specify the 5th vector's component value.
		/// </param>
		/// <param name="s5">
		/// A <see cref="sbyte"/> that specify the 6th vector's component value.
		/// </param>
		/// <param name="s6">
		/// A <see cref="sbyte"/> that specify the 7th vector's component value.
		/// </param>
		/// <param name="s7">
		/// A <see cref="sbyte"/> that specify the 8th vector's component value.
		/// </param>
		/// <param name="s8">
		/// A <see cref="sbyte"/> that specify the 9th vector's component value.
		/// </param>
		/// <param name="s9">
		/// A <see cref="sbyte"/> that specify the 10th vector's component value.
		/// </param>
		/// <param name="sa">
		/// A <see cref="sbyte"/> that specify the 11th vector's component value.
		/// </param>
		/// <param name="sb">
		/// A <see cref="sbyte"/> that specify the 12th vector's component value.
		/// </param>
		/// <param name="sc">
		/// A <see cref="sbyte"/> that specify the 13th vector's component value.
		/// </param>
		/// <param name="sd">
		/// A <see cref="sbyte"/> that specify the 14th vector's component value.
		/// </param>
		/// <param name="se">
		/// A <see cref="sbyte"/> that specify the 15th vector's component value.
		/// </param>
		/// <param name="sf">
		/// A <see cref="sbyte"/> that specify the 16th vector's component value.
		/// </param>
		public double16(double s0, double s1, double s2, double s3, double s4, double s5, double s6, double s7, double s8, double s9, double sa, double sb, double sc, double sd, double se, double sf)
		{
			this.s0 = s0;
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			this.s4 = s4;
			this.s5 = s5;
			this.s6 = s6;
			this.s7 = s7;
			this.s8 = s8;
			this.s9 = s9;
			this.sa = 			this.sA = sa;
			this.sb = 			this.sB = sb;
			this.sc = 			this.sC = sc;
			this.sd = 			this.sD = sd;
			this.se = 			this.sE = se;
			this.sf = 			this.sF = sf;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The 1th vector component.
		/// </summary>
		[FieldOffset(0)]
		public double s0;

		/// <summary>
		/// The 2th vector component.
		/// </summary>
		[FieldOffset(8)]
		public double s1;

		/// <summary>
		/// The 3th vector component.
		/// </summary>
		[FieldOffset(16)]
		public double s2;

		/// <summary>
		/// The 4th vector component.
		/// </summary>
		[FieldOffset(24)]
		public double s3;

		/// <summary>
		/// The 5th vector component.
		/// </summary>
		[FieldOffset(32)]
		public double s4;

		/// <summary>
		/// The 6th vector component.
		/// </summary>
		[FieldOffset(40)]
		public double s5;

		/// <summary>
		/// The 7th vector component.
		/// </summary>
		[FieldOffset(48)]
		public double s6;

		/// <summary>
		/// The 8th vector component.
		/// </summary>
		[FieldOffset(56)]
		public double s7;

		/// <summary>
		/// The 9th vector component.
		/// </summary>
		[FieldOffset(64)]
		public double s8;

		/// <summary>
		/// The 10th vector component.
		/// </summary>
		[FieldOffset(72)]
		public double s9;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(80)]
		public double sa;

		/// <summary>
		/// The 11th vector component.
		/// </summary>
		[FieldOffset(80)]
		public double sA;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(88)]
		public double sb;

		/// <summary>
		/// The 12th vector component.
		/// </summary>
		[FieldOffset(88)]
		public double sB;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(96)]
		public double sc;

		/// <summary>
		/// The 13th vector component.
		/// </summary>
		[FieldOffset(96)]
		public double sC;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(104)]
		public double sd;

		/// <summary>
		/// The 14th vector component.
		/// </summary>
		[FieldOffset(104)]
		public double sD;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(112)]
		public double se;

		/// <summary>
		/// The 15th vector component.
		/// </summary>
		[FieldOffset(112)]
		public double sE;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(120)]
		public double sf;

		/// <summary>
		/// The 16th vector component.
		/// </summary>
		[FieldOffset(120)]
		public double sF;

		#endregion

		#region Accessor

		/// <summary>
		/// Get or set a vector component.
		/// </summary>
		/// <param name="index">
		/// A <see cref="Int32"/> that specify the component index.
		/// </param>
		/// <returns>
		/// It returns the vector component specified by <paramref name="index"/>.
		/// </returns>
		public double this[int index]
		{
			get 
			{
				switch (index) {
					case 0: return (s0);
					case 1: return (s1);
					case 2: return (s2);
					case 3: return (s3);
					case 4: return (s4);
					case 5: return (s5);
					case 6: return (s6);
					case 7: return (s7);
					case 8: return (s8);
					case 9: return (s9);
					case 10: return (sa);
					case 11: return (sb);
					case 12: return (sc);
					case 13: return (sd);
					case 14: return (se);
					case 15: return (sf);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (index) {
					case 0: s0 = value; break;
					case 1: s1 = value; break;
					case 2: s2 = value; break;
					case 3: s3 = value; break;
					case 4: s4 = value; break;
					case 5: s5 = value; break;
					case 6: s6 = value; break;
					case 7: s7 = value; break;
					case 8: s8 = value; break;
					case 9: s9 = value; break;
					case 10: sa = value; break;
					case 11: sb = value; break;
					case 12: sc = value; break;
					case 13: sd = value; break;
					case 14: se = value; break;
					case 15: sf = value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get a string representing this double16.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this double16.
		/// </returns>
		public override string ToString()
		{
			return String.Format("|{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}|", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, sa, sb, sc, sd, se, sf);
		}

		#endregion

		#region IVectorType implementation

		/// <summary>
		/// Get the rank of the vector.
		/// </summary>
		int IVector.Rank { get { return (16); } }

		/// <summary>
		/// Vector interface.
		/// </summary>
		int IVector.Size { get { return (16 * 8); } }

		#endregion
	}

}
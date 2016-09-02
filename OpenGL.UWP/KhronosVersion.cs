﻿
// Copyright (C) 2015-2016 Luca Piccioni
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
// US

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Version abstraction for Khrono APIs.
	/// </summary>
	[DebuggerDisplay("KhronosVersion: Version={Major}.{Minor}.{Revision} (API='{Api}')")]
	public class KhronosVersion : IEquatable<KhronosVersion>, IComparable<KhronosVersion>
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <param name="api">
		/// A <see cref="String"/> that specifies the API name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> is less than 0.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="api"/> is null.
		/// </exception>
		public KhronosVersion(int major, int minor, string api) :
			this(major, minor, 0, api)
		{

		}

		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <param name="revision">
		/// A <see cref="Int32"/> that specifies that revision version number.
		/// </param>
		/// <param name="api">
		/// A <see cref="String"/> that specifies the API name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
		/// <paramref name="revision"/> are less than 0.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="api"/> is null.
		/// </exception>
		public KhronosVersion(int major, int minor, int revision, string api)
		{
			if (major <= 0)
				throw new ArgumentException("less or equal to 0 not allowed", "major");
			if (minor < 0)
				throw new ArgumentException("less than 0 not allowed", "minor");
			if (revision < 0)
				throw new ArgumentException("less than 0 not allowed", "revision");
			if (api == null)
				throw new ArgumentNullException("api");

			Major = major;
			Minor = minor;
			Revision = revision;

			Api = api;
		}

		#endregion

		#region API Description

		/// <summary>
		/// OpenGL API.
		/// </summary>
		public const string ApiGl = "gl";

		/// <summary>
		/// OpenGL for Windows API.
		/// </summary>
		public const string ApiWgl = "wgl";

		/// <summary>
		/// OpenGL on X11 API.
		/// </summary>
		public const string ApiGlx = "glx";

		/// <summary>
		/// OpenGL on EGL API.
		/// </summary>
		public const string ApiEgl = "egl";

		/// <summary>
		/// OpenGL ES 1.x API.
		/// </summary>
		public const string ApiGles1 = "gles1";

		/// <summary>
		/// OpenGL ES 2.x API.
		/// </summary>
		public const string ApiGles2 = "gles2";

		/// <summary>
		/// The Khronos API description.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This is the main discriminant of the KhronosVersion instances. Two KhronoVersion instances
		/// are not comparable if their API doesn't match.
		/// </para>
		public readonly string Api;

		#endregion

		#region Version Numbers

		/// <summary>
		/// Major version number.
		/// </summary>
		public readonly int Major;

		/// <summary>
		/// Minor version number.
		/// </summary>
		public readonly int Minor;

		/// <summary>
		/// Revision version number.
		/// </summary>
		public readonly int Revision;

		#endregion

		#region Version Identifier

		/// <summary>
		/// Get the version identifier of this KhronosVersion.
		/// </summary>
		public virtual int VersionId
		{
			get { return (Major * 100 + Minor * 10 + Revision); }
		}

		#endregion

		#region Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> equals <paramref name="right"/>.
		/// </returns>
		public static bool operator ==(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (true);
			if (ReferenceEquals(left, null))
				return (false);

			return (left.Equals(right));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> doesn't equals <paramref name="right"/>.
		/// </returns>
		public static bool operator !=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (false);

			return (!left.Equals(right));
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is greater than <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator >(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (false);

			return (left.CompareTo(right) > 0);
		}

		/// <summary>
		/// Lower than operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is lower than <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator <(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (true);

			return (left.CompareTo(right) < 0);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is greater than or equal to <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator >=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (false);

			return (left.CompareTo(right) >= 0);
		}

		/// <summary>
		/// Lower than or equal to operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is lower than or equal to <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator <=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (true);

			return (left.CompareTo(right) <= 0);
		}

		#endregion

		#region String Parsing

		/// <summary>
		/// Parse a KhronosVersion from a string.
		/// </summary>
		/// <param name="input">
		/// A <see cref="String"/> that specifies the API version.
		/// </param>
		/// <returns>
		/// It returns a <see cref="KhronosVersion"/> based on the pattern recognized in <paramref name="input"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="input"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no pattern is recognized in <paramref name="input"/>.
		/// </exception>
		public static KhronosVersion Parse(string input)
		{
			if (input == null)
				throw new ArgumentNullException("input");

			// Determine version value (support up to 3 version numbers)
			Match versionMatch = Regex.Match(input, @"(?<Major>\d+)\.(?<Minor>\d+)(\.(?<Rev>\d+))?( .*)?");
			if (versionMatch.Success == false)
				throw new ArgumentException("unrecognized pattern", "input");

			int versionMajor = Int32.Parse(versionMatch.Groups["Major"].Value);
			int versionMinor = Int32.Parse(versionMatch.Groups["Minor"].Value);
			int versionRev = versionMatch.Groups["Rev"].Success ? Int32.Parse(versionMatch.Groups["Rev"].Value) : 0;
			string api = ApiGl;

			if (Regex.IsMatch(input, "ES")) {
				switch (versionMajor) {
					case 1:
						api = ApiGles1;
						break;
					case 2:
					default:
						api = ApiGles2;
						break;
				}
			}

			return (new KhronosVersion(versionMajor, versionMinor, versionRev, api));
		}

		#endregion

		#region Object Overrides

		///<summary>
		/// Converts this PIXELFORMATDESCRIPTOR into a human-legible string representation.
		///</summary>
		///<returns>
		/// The string representation of this instance.
		///</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("{0}.{1}", Major, Minor);
			if (Revision != 0)
				sb.AppendFormat("{0}", Revision);
			if (String.IsNullOrEmpty(Api) == false)
				sb.AppendFormat(" API={0}", Api);

			return (sb.ToString());
		}

		#endregion

		#region IEquatable<KhronosVersion> Implementation

		/// <summary>
		/// Returns a boolean value indicating whether this instance is equal to <paramref name="other"/>.
		/// </summary>
		/// <param name="other">
		/// The KhronosVersion to be compared with this KhronosVersion.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="other"/> equals to this instance.
		/// </returns>
		public bool Equals(KhronosVersion other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);

			return ((Api == other.Api) && (Major == other.Major) && (Minor == other.Minor && (Revision == other.Revision)));
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (ReferenceEquals(this, obj))
				return (true);
			if (!(obj is KhronosVersion))
				return (false);

			return (Equals((KhronosVersion)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = base.GetHashCode();

				result = (result * 397) ^ Api.GetHashCode();
				result = (result * 397) ^ Major.GetHashCode();
				result = (result * 397) ^ Minor.GetHashCode();
				result = (result * 397) ^ Revision.GetHashCode();

				return result;
			}
		}

		#endregion

		#region IComparable<KhronosVersion> Implementation

		/// <summary>
		/// Compares this instance to a specified KhronosVersion and returns an integer
		/// that indicates whether the value of this instance is less than, equal to, or
		/// greater than the value of the specified KhronosVersion.
		/// </summary>
		/// <param name="other">
		/// A <see cref="KhronosVersion"/> to compare.
		/// </param>
		/// <returns>
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="other"/> does not match.
		/// </exception>
		public int CompareTo(KhronosVersion other)
		{
			if (ReferenceEquals(this, other))
				return (0);
			if (ReferenceEquals(null, other))
				return (+1);

			if (Api != other.Api)
				throw new InvalidOperationException("different API version are not comparable");

			int majorCompareTo = Major.CompareTo(other.Major);
			if (majorCompareTo != 0)
				return (majorCompareTo);

			int minorCompareTo = Minor.CompareTo(other.Minor);
			if (minorCompareTo != 0)
				return (minorCompareTo);

			int revCompareTo = Revision.CompareTo(other.Revision);
			if (revCompareTo != 0)
				return (revCompareTo);

			return (0);
		}

		#endregion
	}

	/// <summary>
	/// Designer converter for <see cref="KhronosVersion"/> properties.
	/// </summary>
	internal class KhronosVersionConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type destinationType)
		{
			return (destinationType == typeof(string) || base.CanConvertTo(context, destinationType));
		}

		public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{
			if (Object.ReferenceEquals(value, null))
				return base.ConvertFrom(context, culture, value);
			
			Type valueType = value.GetType();

			if (valueType == typeof(string)) {
				try {
					string valueString = (string)value;

					if (valueString == String.Empty)
						return (null);

					return (KhronosVersion.Parse(valueString));
				} catch (Exception exception) {
					throw new NotSupportedException("unable to parse the value", exception);
				}
			}

			// Base implementation
			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return (destinationType == typeof(string) || base.CanConvertTo(context, destinationType));
		}

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string)) {
				KhronosVersion version = (KhronosVersion)value;

				if (version == null)
					return ("Current");

				return (version.ToString());
			}

			// Base implementation
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}


// Copyright (C) 2016 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace BindingsGen
{
	/// <summary>
	/// Minimal interface required for generating code from a specification source.
	/// </summary>
	public interface ISpecContext
	{
		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		string Class { get; }

		/// <summary>
		/// The set of API supported by generated class.
		/// </summary>
		string[] SupportedApi { get; }

		/// <summary>
		/// Determine whether an API element is supported by the generated class.
		/// </summary>
		/// <param name="api">
		/// A <see cref="String"/> that specify the regular expression of the API element to be evaluated.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="api"/> specify a supported API.
		/// </returns>
		bool IsSupportedApi(string api);

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		GLSpecs.Registry Registry { get; }

		/// <summary>
		/// The extension names dictionary.
		/// </summary>
		GLSpecs.SpecWordsDictionary ExtensionsDictionary { get; }

		/// <summary>
		/// The words dictionary.
		/// </summary>
		GLSpecs.SpecWordsDictionary WordsDictionary { get; }
	}
}

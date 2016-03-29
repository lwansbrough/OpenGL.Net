
// Copyright (C) 2015-2016 Luca Piccioni
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenCL specification context.
	/// </summary>
	class OpenClContext : ISpecContext
	{
		#region Constructors

		/// <summary>
		/// Construct a OpenClContext.
		/// </summary>
		/// <param name="class">
		/// A <see cref="String"/> that specifies the actual specification to build.
		/// </param>
		/// <param name="registryPath">
		/// A <see cref="String"/> that specifies the path of the OpenCL specification to parse.
		/// </param>
		public OpenClContext(string @class, string registryPath)
		{
			// Store the class
			_Class = "Cl";
			// Set supported APIs
			List<string> apis = new List<string>();

			apis.Add(_Class.ToLower());

			_SupportedApi = apis.ToArray();
			// Loads the extension dictionary
			_ExtensionsDictionary = SpecWordsDictionary.Load("BindingsGen.GLSpecs.ExtWords.xml");
			// Loads the words dictionary
			_WordsDictionary = SpecWordsDictionary.Load(String.Format("BindingsGen.GLSpecs.{0}Words.xml", @class));
			// Load and parse OpenCL specification
			_Registry = new Registry();
			CompileRegistry(registryPath);
			_Registry.Link(this);
		}

		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		private readonly string _Class;

		/// <summary>
		/// The set of API supported by generated class.
		/// </summary>
		private readonly string[] _SupportedApi;

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		private readonly Registry _Registry;

		/// <summary>
		/// The extension names dictionary.
		/// </summary>
		private readonly SpecWordsDictionary _ExtensionsDictionary;

		/// <summary>
		/// The words dictionary.
		/// </summary>
		private readonly SpecWordsDictionary _WordsDictionary;

		#endregion

		#region Specification Parser

		/// <summary>
		/// 
		/// </summary>
		/// <param name="registryPath">
		/// A <see cref="String"/> that specifies the path of the OpenCL specification to parse.
		/// </param>
		private void CompileRegistry(string registryPath)
		{
			_Registry.CommandBlocks.Add(new CommandBlock());
			
			// Parse enumerations
			using (StreamReader sr = new StreamReader(registryPath)) {
				string line;

				while ((line  = sr.ReadLine()) != null)
					ProcessEnumLine(sr, line);
			}

			// Parse methods
			using (StreamReader sr = new StreamReader(registryPath)) {
				string line;

				while ((line  = sr.ReadLine()) != null)
					ProcessCommandLine(sr, line);
			}

			// Customization
			FeatureCommand commonFeatures = new FeatureCommand();

			commonFeatures.Api = "cl";

			Feature featVersion100 = _Registry.Features.Find(delegate (Feature item) {
				return (item.Number == "100");
			});

			EnumerantGroup errorCodesGroup = _Registry.Groups.Find(delegate (EnumerantGroup item) { return (item.Name == "ErrorCode"); });
			foreach (Enumerant enumerant in errorCodesGroup.Enums)
				commonFeatures.Enums.Add(new FeatureCommand.Item(enumerant.Name));
			featVersion100.Requirements.Add(commonFeatures);
		}

		#region Enumerations

		private void ProcessEnumLine(StreamReader sr, string line)
		{
			Match match;

			if ((match = _SemanticComment.Match(line)).Success) {
				string semantic = match.Groups["Semantic"].Value.Trim();
				bool bitfield;

				if (bitfield = semantic.EndsWith(_SemanticBitfield))
					semantic.Substring(0, semantic.Length - _SemanticBitfield.Length);

				if (TypeMap.CsTypeMap.IsMappedType(semantic)) {
					// Strongly-typed enumeration
					EnumerantGroup enumerantGroup = new EnumerantGroup();

					enumerantGroup.Name = semantic;     // XXX Style
					_Registry.Groups.Add(enumerantGroup);
					enumerantGroup.Enums.AddRange(ProcessEnumBlock(sr));
					GenerateEnumerantBlockFromGroup(enumerantGroup, bitfield);
				} else if (semantic == "Error Codes") {
					EnumerantGroup enumerantGroup = new EnumerantGroup();

					enumerantGroup.Name = "ErrorCode";	// Emulates Gl
					_Registry.Groups.Add(enumerantGroup);
					enumerantGroup.Enums.AddRange(ProcessEnumBlock(sr));
					GenerateEnumerantBlockFromGroup(enumerantGroup, bitfield);
				} else if (semantic == "OpenCL Version") {
					ProcessEnumVersion(sr);
				}
			}
		}

		private List<Enumerant> ProcessEnumBlock(StreamReader sr)
		{
			List<Enumerant> enumBlock = new List<Enumerant>();
			string line;

			while ((line = sr.ReadLine()) != null) {
				if (line == String.Empty)
					return (enumBlock);     // End of the block

				Match match;

				if ((match = _RegexEnumStatement.Match(line)).Success) {
					Enumerant enumerant = new Enumerant();
					string enumerantName = match.Groups["EnumName"].Value.Trim();
					string enumerantValue = match.Groups["EnumValue"].Value.Trim();

					enumerant.Name = enumerantName;
					enumerant.Value = enumerantValue;
					enumerant.Api = "cl";

					enumBlock.Add(enumerant);
				}
			}

			return (enumBlock);
		}

		private void GenerateEnumerantBlockFromGroup(EnumerantGroup enumerantGroup, bool bitfield)
		{
			EnumerantBlock enumerantBlock = new EnumerantBlock();

			enumerantBlock.Namespace = "cl";
			enumerantBlock.Type = bitfield ? "bitmask" : null;
			enumerantBlock.Group = enumerantGroup.Name;
			enumerantBlock.Enums.AddRange(enumerantGroup.Enums);

			_Registry.Enums.Add(enumerantBlock);
		}

		private void ProcessEnumVersion(StreamReader sr)
		{
			string line;

			while ((line = sr.ReadLine()) != null) {
				if (line == String.Empty)
					return;     // End of the block

				Match match;

				if ((match = _RegexVersionStatement.Match(line)).Success) {
					int major = Int32.Parse(match.Groups["Major"].Value);
					int minor = Int32.Parse(match.Groups["Minor"].Value);

					Feature version = new Feature();

					version.Api = "cl";
					version.Name = String.Format("CL_VERSION_{0}_{1}", major, minor);
					version.Number = (major * 100 + minor * 10).ToString();
					version.Version = String.Format("{0}.{1}", major, minor);

					_Registry.Features.Add(version);
				}
			}
		}

		private static readonly Regex _SemanticComment = new Regex(@"/\*(?<Semantic>.*?)\*/");

		private const string _SemanticBitfield = " - bitfield";

		private static readonly Regex _RegexEnumStatement = new Regex(@"#define (?<EnumName>CL_[\w\d_]+) +(?<EnumValue>[\w_\dA-Fx\-\+]+)( +/\*.*\*/)?");

		private static readonly Regex _RegexVersionStatement = new Regex(@"#define CL_VERSION_(?<Major>\d)_(?<Minor>\d) +1");

		#endregion

		#region Commands

		private void ProcessCommandLine(StreamReader sr, string line)
		{
			// No command line?
			if (line.StartsWith("extern CL_API_ENTRY ") == false)
				return;

			// Compose command line
			StringBuilder commandBuilder = new StringBuilder();

			commandBuilder.Append(line + " ");

			while ((line = sr.ReadLine()) != null) {
				commandBuilder.Append(line + " ");
				if (line.EndsWith(";"))
					break;
			}

			// Process command
			ProcessCommandLine(commandBuilder.ToString());
		}

		private void ProcessCommandLine(string line)
		{
			// Remove prefix
			line = line.Substring(CommandPrefix.Length);
			// Remove double spaces
			line = Regex.Replace(line, " +", " ");
			// Remove tokens
			line = Regex.Replace(line, "CL_API_CALL", String.Empty);
			// Parse tokens
			Match match = _RegexCommand.Match(line);

			if (match.Success == false) {
				return;
			}

			string returnType = match.Groups["Return"].Value;
			string commandName = match.Groups["Name"].Value;
			string commandArgsString = match.Groups["Args"].Value;
			string feature = match.Groups["Feature"].Value;

			// Parse feature
			Feature commandFeature = null;

			if ((match = _RegexCommandFeature.Match(feature)).Success) {
				int featureMajor = Int32.Parse(match.Groups["Major"].Value);
				int featureMinor = Int32.Parse(match.Groups["Minor"].Value);
				string featureNumber = (featureMajor * 100 + featureMinor * 10).ToString();

				commandFeature = _Registry.Features.Find(delegate (Feature item) {
					return (item.Number == featureNumber);
				});

				if (commandFeature == null) {
					commandFeature = new Feature();
					commandFeature.Api = "cl";
					commandFeature.Name = String.Format("CL_VERSION_{0}_{1}", featureMajor, featureMinor);
					commandFeature.Version = String.Format("{0}.{1}", featureMajor, featureMinor);
					commandFeature.Number = featureNumber;

					_Registry.Features.Add(commandFeature);
				}
			}

			if (commandFeature == null) {
				return;
			}

			// Parse command
			CommandBlock commandBlock = _Registry.CommandBlocks[0];
			Command command = new Command();
			List<CommandParameter> commandParams = new List<CommandParameter>();

			command.Prototype = new CommandPrototype();
			command.Prototype.Name = commandName;
			command.Prototype.Type = returnType;

			// Parse command arguments
			string[] commandArgsTokens = Regex.Split(commandArgsString, @",(?=[^\)]*(?:\(|$))");

			for (int i = 0; i < commandArgsTokens.Length; i++) {
				string commandArgToken = commandArgsTokens[i];

				if ((match = _RegexCommandArg.Match(commandArgToken)).Success == false) {
					continue;
				}

				string commandArgType = match.Groups["ArgType"].Value.Trim();
				string commandArgName = match.Groups["ArgName"].Value.Trim();

				if (commandArgType.Contains("CL_CALLBACK")) {
					string callback = commandArgsTokens[i].Trim();

					// Remove dup spaces
					callback = Regex.Replace(callback, " +", " ");

					// Callback special management
					if      (callback == "void (CL_CALLBACK * /* pfn_notify */)(const char *, const void *, size_t, void *)") {
						commandArgType = "CL_CALLBACK_NOTIFY";
						commandArgName = "pfn_notify";
					} else if (callback == "void (CL_CALLBACK * /* pfn_notify */)(cl_program /* program */, void * /* user_data */)") {
						commandArgType = "CL_CALLBACK_PROGRAM";
						commandArgName = "pfn_notify";
					} else if (callback == "void (CL_CALLBACK * /* pfn_notify */)(cl_event, cl_int, void *)") {
						commandArgType = "CL_CALLBACK_EVENT";
						commandArgName = "pfn_notify";
					} else if (callback == "void (CL_CALLBACK * /*user_func*/)(void *)") {
						commandArgType = "CL_USER_FUNC";
						commandArgName = "user_func";
					} else if (callback == "void (CL_CALLBACK * /*pfn_notify*/)( cl_mem /* memobj */, void* /*user_data*/)") {
						commandArgType = "CL_CALLBACK_MEM_OBJECT";
						commandArgName = "pfn_notify";
					} else if (callback == "void (CL_CALLBACK * /*pfn_free_func*/)(cl_command_queue /* queue */, cl_uint /* num_svm_pointers */ void *[] /* svm_pointers[] */ void * /* user_data */)") {
						commandArgType = "CL_SVM_FREE_FUNCT";
						commandArgName = "pfn_free_func";
					} else
						throw new NotImplementedException();
				}

				// Remove const qualifiers
				commandArgType = Regex.Replace(commandArgType, "const ", String.Empty);
				// Remove dup spaces
				commandArgType = Regex.Replace(commandArgType, " +", " ");

				CommandParameter commandParameter = new CommandParameter();

				commandParameter.Group = commandArgType;
				commandParameter.Length = null;
				commandParameter.Type = commandArgType;
				// commandParameter.TypeDecorators = null;
				commandParameter.Name = commandArgName;

				command.Parameters.Add(commandParameter);
			}

			// Ensure arguments with unique names
			List<CommandParameter> commandParameters = new List<CommandParameter>(command.Parameters);

			for (int i = 0; i < commandParameters.Count; i++) {
				List<CommandParameter> instances = commandParameters.FindAll(delegate (CommandParameter item) { return (item.Name == commandParameters[i].Name); });

				if (instances.Count == 1)
					continue;

				for (int j = 0; j < instances.Count; j++)
					instances[j].Name = String.Format("{0}{1}", instances[j].Name, j + 1);
			}

			// Add command/enum requirement
			FeatureCommand commandFeatureCommand = new FeatureCommand();

			commandFeatureCommand.Api = "cl";

			foreach (CommandParameter commandParameter in command.Parameters) {
				EnumerantGroup enumerantGroup = _Registry.Groups.Find(delegate (EnumerantGroup item) { return (item.Name == commandParameter.Group); });
				if (enumerantGroup == null)
					continue;

				foreach (Enumerant enumerant in enumerantGroup.Enums)
					commandFeatureCommand.Enums.Add(new FeatureCommand.Item(enumerant.Name));
			}
			commandFeatureCommand.Commands.Add(new FeatureCommand.Item(command.Prototype.Name));

			commandFeature.Requirements.Add(commandFeatureCommand);

			commandBlock.Commands.Add(command);
		}

		private const string CommandPrefix = "extern CL_API_ENTRY ";

		private static readonly Regex _RegexCommand = new Regex(
			@"(?<Return>[\w\d_]+) +" +
			@"(?<Name>[\w\d_]+)\((?<Args>.*)\) +" +
			@"(?<Feature>[\w\d_]+);"
		);

		private static readonly Regex _RegexCommandArg = new Regex(
			@"(?<ArgType>[\w\d_ \*]+) +/\* (?<ArgName>[\w\d_]+) \*/"
		);

		private static readonly Regex _RegexCommandFeature = new Regex(
			@"CL_API_SUFFIX__VERSION_(?<Major>\d+)_(?<Minor>\d+)"
		);

		#endregion

		#endregion

		#region ISpecContext Implementation

		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		public string Class { get { return (_Class); } }

		/// <summary>
		/// The set of API supported by generated class.
		/// </summary>
		public string[] SupportedApi { get { return (_SupportedApi); } }

		/// <summary>
		/// Determine whether an API element is supported by the generated class.
		/// </summary>
		/// <param name="api">
		/// A <see cref="String"/> that specify the regular expression of the API element to be evaluated.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="api"/> specify a supported API.
		/// </returns>
		public bool IsSupportedApi(string api)
		{
			if (api == null)
				throw new ArgumentNullException("api");

			string regexApi = String.Format("^{0}$", api);

			foreach (string supportedApi in _SupportedApi) {
				if (Regex.IsMatch(supportedApi, regexApi))
					return (true);
			}
				

			return (false);
		}

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		public Registry Registry { get { return (_Registry); } }

		/// <summary>
		/// The extension names dictionary.
		/// </summary>
		public SpecWordsDictionary ExtensionsDictionary { get { return (_ExtensionsDictionary); } }

		/// <summary>
		/// The words dictionary.
		/// </summary>
		public SpecWordsDictionary WordsDictionary { get { return (_WordsDictionary); } }

		#endregion
	}
}

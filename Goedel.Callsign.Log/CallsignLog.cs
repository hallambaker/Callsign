
//  Copyright (c) 2016 by .
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  
//  
//  This file was automatically generated at 3/16/2021 1:10:45 AM
//   
//  Changes to this file may be overwritten without warning
//  
//  Generator:  protogen version 3.0.0.566
//      Goedel Script Version : 0.1   Generated 
//      Goedel Schema Version : 0.1   Generated
//  
//      Copyright : © 2015-2019
//  
//  Build Platform: Win32NT 10.0.18362.0
//  
//  
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Goedel.Protocol;


#pragma warning disable IDE1006


using Goedel.Cryptography.Jose;
using Goedel.Cryptography.Dare;
using Goedel.Mesh;


namespace Goedel.Callsign.Log {


	/// <summary>
	///
	/// Entries that may appear in the Callsign registry log. Three types of entry 
	/// are currently defined: Entries relating to registration and transfer of callsigns,
	/// Entries relating to descriptions of callsign character pages and entries relating
	/// to cross notarization of the log by third parties.
	/// </summary>
	public abstract partial class CallsignEntry : global::Goedel.Protocol.JsonObject {

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag =>__Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "CallsignEntry";

		/// <summary>
        /// Dictionary mapping tags to factory methods
        /// </summary>
		public static Dictionary<string, JsonFactoryDelegate> _TagDictionary=> _tagDictionary;
		static Dictionary<string, JsonFactoryDelegate> _tagDictionary = 
				new Dictionary<string, JsonFactoryDelegate> () {

			{"Callsign", Callsign._Factory},
			{"Registration", Registration._Factory},
			{"Page", Page._Factory},
			{"Range", Range._Factory},
			{"Variant", Variant._Factory},
			{"Notarization", Notarization._Factory}			};

        [ModuleInitializer]
        internal static void _Initialize() => AddDictionary(ref _tagDictionary);


		/// <summary>
        /// Construct an instance from the specified tagged JsonReader stream.
        /// </summary>
        /// <param name="jsonReader">Input stream</param>
        /// <param name="result">The created object</param>
        public static void Deserialize(JsonReader jsonReader, out JsonObject result) => 
			result = jsonReader.ReadTaggedObject(_TagDictionary);

		}



		// Service Dispatch Classes



		// Transaction Classes
	/// <summary>
	///
	/// A callsign entry
	/// </summary>
	public partial class Callsign : CallsignEntry {
        /// <summary>
        ///The callsign identifier in canonical form used for query.
        /// </summary>

		public virtual string						Id  {get; set;}
        /// <summary>
        ///The callsign identifier in the prefered presentation form.
        /// </summary>

		public virtual string						Presentation  {get; set;}
        /// <summary>
        ///The UDF of the holder's root of trust
        /// </summary>

		public virtual string						Holder  {get; set;}
        /// <summary>
        ///The callsign or DNS address of the service provider
        /// </summary>

		public virtual string						Service  {get; set;}
        /// <summary>
        ///Address(es) of a DNS service that resolves the authoritative domain 
        ///'id.mesh'.
        /// </summary>

		public virtual List<string>				Dns  {get; set;}
        /// <summary>
        ///The Mesh Account profile to which the callsign belongs.
        /// </summary>

		public virtual ProfileAccount						Account  {get; set;}
		
		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag => __Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "Callsign";

		/// <summary>
        /// Factory method
        /// </summary>
        /// <returns>Object of this type</returns>
		public static new JsonObject _Factory () => new Callsign();


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// </summary>
        /// <param name="writer">Output stream</param>
        /// <param name="wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="first">If true, item is the first entry in a list.</param>
		public override void Serialize (Writer writer, bool wrap, ref bool first) =>
			SerializeX (writer, wrap, ref first);


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// Unlike the Serlialize() method, this method is not inherited from the
        /// parent class allowing a specific version of the method to be called.
        /// </summary>
        /// <param name="_writer">Output stream</param>
        /// <param name="_wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="_first">If true, item is the first entry in a list.</param>
		public new void SerializeX (Writer _writer, bool _wrap, ref bool _first) {
			PreEncode();
			if (_wrap) {
				_writer.WriteObjectStart ();
				}
			if (Id != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Id", 1);
					_writer.WriteString (Id);
				}
			if (Presentation != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Presentation", 1);
					_writer.WriteString (Presentation);
				}
			if (Holder != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Holder", 1);
					_writer.WriteString (Holder);
				}
			if (Service != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Service", 1);
					_writer.WriteString (Service);
				}
			if (Dns != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Dns", 1);
				_writer.WriteArrayStart ();
				bool _firstarray = true;
				foreach (var _index in Dns) {
					_writer.WriteArraySeparator (ref _firstarray);
					_writer.WriteString (_index);
					}
				_writer.WriteArrayEnd ();
				}

			if (Account != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Account", 1);
					Account.Serialize (_writer, false);
				}
			if (_wrap) {
				_writer.WriteObjectEnd ();
				}
			}

        /// <summary>
        /// Deserialize a tagged stream
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
		/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
        /// <returns>The created object.</returns>		
        public static new Callsign FromJson (JsonReader jsonReader, bool tagged=true) {
			if (jsonReader == null) {
				return null;
				}
			if (tagged) {
				var Out = jsonReader.ReadTaggedObject (_TagDictionary);
				return Out as Callsign;
				}
		    var Result = new Callsign ();
			Result.Deserialize (jsonReader);
			Result.PostDecode();
			return Result;
			}

        /// <summary>
        /// Having read a tag, process the corresponding value data.
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
        /// <param name="tag">The tag</param>
		public override void DeserializeToken (JsonReader jsonReader, string tag) {
			
			switch (tag) {
				case "Id" : {
					Id = jsonReader.ReadString ();
					break;
					}
				case "Presentation" : {
					Presentation = jsonReader.ReadString ();
					break;
					}
				case "Holder" : {
					Holder = jsonReader.ReadString ();
					break;
					}
				case "Service" : {
					Service = jsonReader.ReadString ();
					break;
					}
				case "Dns" : {
					// Have a sequence of values
					bool _Going = jsonReader.StartArray ();
					Dns = new List <string> ();
					while (_Going) {
						string _Item = jsonReader.ReadString ();
						Dns.Add (_Item);
						_Going = jsonReader.NextArray ();
						}
					break;
					}
				case "Account" : {
					// An untagged structure
					Account = new ProfileAccount ();
					Account.Deserialize (jsonReader);
 
					break;
					}
				default : {
					break;
					}
				}
			// check up that all the required elements are present
			}


		}

	/// <summary>
	///
	/// A callsign registration
	/// </summary>
	public partial class Registration : CallsignEntry {
        /// <summary>
        ///Unique registration identifier
        /// </summary>

		public virtual string						Id  {get; set;}
        /// <summary>
        ///Envelope containing the requested callsign signed by a key authorized under
        ///the registered profile.
        /// </summary>

		public virtual Enveloped<Callsign>						SignedCallsign  {get; set;}
        /// <summary>
        ///The UTC time instant that the claim was submitted.
        /// </summary>

		public virtual DateTime?						Submitted  {get; set;}
        /// <summary>
        ///Callsign of the registrar that made the registration request
        /// </summary>

		public virtual string						Registrar  {get; set;}
        /// <summary>
        ///If present, specifies a previous registration with the same identifier.
        /// </summary>

		public virtual string						PriorId  {get; set;}
        /// <summary>
        ///Reason for creating a registration:
        ///Initial/ Update/ Voluntary/ Administrative/ Revoke
        /// </summary>

		public virtual string						Reason  {get; set;}
		
		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag => __Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "Registration";

		/// <summary>
        /// Factory method
        /// </summary>
        /// <returns>Object of this type</returns>
		public static new JsonObject _Factory () => new Registration();


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// </summary>
        /// <param name="writer">Output stream</param>
        /// <param name="wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="first">If true, item is the first entry in a list.</param>
		public override void Serialize (Writer writer, bool wrap, ref bool first) =>
			SerializeX (writer, wrap, ref first);


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// Unlike the Serlialize() method, this method is not inherited from the
        /// parent class allowing a specific version of the method to be called.
        /// </summary>
        /// <param name="_writer">Output stream</param>
        /// <param name="_wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="_first">If true, item is the first entry in a list.</param>
		public new void SerializeX (Writer _writer, bool _wrap, ref bool _first) {
			PreEncode();
			if (_wrap) {
				_writer.WriteObjectStart ();
				}
			if (Id != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Id", 1);
					_writer.WriteString (Id);
				}
			if (SignedCallsign != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("SignedCallsign", 1);
					SignedCallsign.Serialize (_writer, false);
				}
			if (Submitted != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Submitted", 1);
					_writer.WriteDateTime (Submitted);
				}
			if (Registrar != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Registrar", 1);
					_writer.WriteString (Registrar);
				}
			if (PriorId != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("PriorId", 1);
					_writer.WriteString (PriorId);
				}
			if (Reason != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Reason", 1);
					_writer.WriteString (Reason);
				}
			if (_wrap) {
				_writer.WriteObjectEnd ();
				}
			}

        /// <summary>
        /// Deserialize a tagged stream
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
		/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
        /// <returns>The created object.</returns>		
        public static new Registration FromJson (JsonReader jsonReader, bool tagged=true) {
			if (jsonReader == null) {
				return null;
				}
			if (tagged) {
				var Out = jsonReader.ReadTaggedObject (_TagDictionary);
				return Out as Registration;
				}
		    var Result = new Registration ();
			Result.Deserialize (jsonReader);
			Result.PostDecode();
			return Result;
			}

        /// <summary>
        /// Having read a tag, process the corresponding value data.
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
        /// <param name="tag">The tag</param>
		public override void DeserializeToken (JsonReader jsonReader, string tag) {
			
			switch (tag) {
				case "Id" : {
					Id = jsonReader.ReadString ();
					break;
					}
				case "SignedCallsign" : {
					// An untagged structure
					SignedCallsign = new Enveloped<Callsign> ();
					SignedCallsign.Deserialize (jsonReader);
 
					break;
					}
				case "Submitted" : {
					Submitted = jsonReader.ReadDateTime ();
					break;
					}
				case "Registrar" : {
					Registrar = jsonReader.ReadString ();
					break;
					}
				case "PriorId" : {
					PriorId = jsonReader.ReadString ();
					break;
					}
				case "Reason" : {
					Reason = jsonReader.ReadString ();
					break;
					}
				default : {
					break;
					}
				}
			// check up that all the required elements are present
			}


		}

	/// <summary>
	/// </summary>
	public partial class Page : CallsignEntry {
        /// <summary>
        ///Character page identifier
        /// </summary>

		public virtual string						Id  {get; set;}
        /// <summary>
        ///Additional allowed pages.
        /// </summary>

		public virtual string						Allow  {get; set;}
        /// <summary>
        ///Characters permitted within this code page.
        /// </summary>

		public virtual List<Range>				Ranges  {get; set;}
        /// <summary>
        ///Canonicalization mappings to be performed.
        /// </summary>

		public virtual List<Variant>				Mappings  {get; set;}
		
		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag => __Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "Page";

		/// <summary>
        /// Factory method
        /// </summary>
        /// <returns>Object of this type</returns>
		public static new JsonObject _Factory () => new Page();


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// </summary>
        /// <param name="writer">Output stream</param>
        /// <param name="wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="first">If true, item is the first entry in a list.</param>
		public override void Serialize (Writer writer, bool wrap, ref bool first) =>
			SerializeX (writer, wrap, ref first);


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// Unlike the Serlialize() method, this method is not inherited from the
        /// parent class allowing a specific version of the method to be called.
        /// </summary>
        /// <param name="_writer">Output stream</param>
        /// <param name="_wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="_first">If true, item is the first entry in a list.</param>
		public new void SerializeX (Writer _writer, bool _wrap, ref bool _first) {
			PreEncode();
			if (_wrap) {
				_writer.WriteObjectStart ();
				}
			if (Id != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Id", 1);
					_writer.WriteString (Id);
				}
			if (Allow != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Allow", 1);
					_writer.WriteString (Allow);
				}
			if (Ranges != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Ranges", 1);
				_writer.WriteArrayStart ();
				bool _firstarray = true;
				foreach (var _index in Ranges) {
					_writer.WriteArraySeparator (ref _firstarray);
					// This is an untagged structure. Cannot inherit.
                    //_writer.WriteObjectStart();
                    //_writer.WriteToken(_index._Tag, 1);
					bool firstinner = true;
					_index.Serialize (_writer, true, ref firstinner);
                    //_writer.WriteObjectEnd();
					}
				_writer.WriteArrayEnd ();
				}

			if (Mappings != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Mappings", 1);
				_writer.WriteArrayStart ();
				bool _firstarray = true;
				foreach (var _index in Mappings) {
					_writer.WriteArraySeparator (ref _firstarray);
					// This is an untagged structure. Cannot inherit.
                    //_writer.WriteObjectStart();
                    //_writer.WriteToken(_index._Tag, 1);
					bool firstinner = true;
					_index.Serialize (_writer, true, ref firstinner);
                    //_writer.WriteObjectEnd();
					}
				_writer.WriteArrayEnd ();
				}

			if (_wrap) {
				_writer.WriteObjectEnd ();
				}
			}

        /// <summary>
        /// Deserialize a tagged stream
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
		/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
        /// <returns>The created object.</returns>		
        public static new Page FromJson (JsonReader jsonReader, bool tagged=true) {
			if (jsonReader == null) {
				return null;
				}
			if (tagged) {
				var Out = jsonReader.ReadTaggedObject (_TagDictionary);
				return Out as Page;
				}
		    var Result = new Page ();
			Result.Deserialize (jsonReader);
			Result.PostDecode();
			return Result;
			}

        /// <summary>
        /// Having read a tag, process the corresponding value data.
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
        /// <param name="tag">The tag</param>
		public override void DeserializeToken (JsonReader jsonReader, string tag) {
			
			switch (tag) {
				case "Id" : {
					Id = jsonReader.ReadString ();
					break;
					}
				case "Allow" : {
					Allow = jsonReader.ReadString ();
					break;
					}
				case "Ranges" : {
					// Have a sequence of values
					bool _Going = jsonReader.StartArray ();
					Ranges = new List <Range> ();
					while (_Going) {
						// an untagged structure.
						var _Item = new  Range ();
						_Item.Deserialize (jsonReader);
						// var _Item = new Range (jsonReader);
						Ranges.Add (_Item);
						_Going = jsonReader.NextArray ();
						}
					break;
					}
				case "Mappings" : {
					// Have a sequence of values
					bool _Going = jsonReader.StartArray ();
					Mappings = new List <Variant> ();
					while (_Going) {
						// an untagged structure.
						var _Item = new  Variant ();
						_Item.Deserialize (jsonReader);
						// var _Item = new Variant (jsonReader);
						Mappings.Add (_Item);
						_Going = jsonReader.NextArray ();
						}
					break;
					}
				default : {
					break;
					}
				}
			// check up that all the required elements are present
			}


		}

	/// <summary>
	/// </summary>
	public partial class Range : CallsignEntry {
		bool								__First = false;
		private int						_First;
        /// <summary>
        ///The first character in the range (inclusive)
        /// </summary>

		public virtual int						First {
			get => _First;
			set {_First = value; __First = true; }
			}
		bool								__Last = false;
		private int						_Last;
        /// <summary>
        ///The last character in the range (inclusive)
        /// </summary>

		public virtual int						Last {
			get => _Last;
			set {_Last = value; __Last = true; }
			}
		
		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag => __Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "Range";

		/// <summary>
        /// Factory method
        /// </summary>
        /// <returns>Object of this type</returns>
		public static new JsonObject _Factory () => new Range();


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// </summary>
        /// <param name="writer">Output stream</param>
        /// <param name="wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="first">If true, item is the first entry in a list.</param>
		public override void Serialize (Writer writer, bool wrap, ref bool first) =>
			SerializeX (writer, wrap, ref first);


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// Unlike the Serlialize() method, this method is not inherited from the
        /// parent class allowing a specific version of the method to be called.
        /// </summary>
        /// <param name="_writer">Output stream</param>
        /// <param name="_wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="_first">If true, item is the first entry in a list.</param>
		public new void SerializeX (Writer _writer, bool _wrap, ref bool _first) {
			PreEncode();
			if (_wrap) {
				_writer.WriteObjectStart ();
				}
			if (__First){
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("First", 1);
					_writer.WriteInteger32 (First);
				}
			if (__Last){
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Last", 1);
					_writer.WriteInteger32 (Last);
				}
			if (_wrap) {
				_writer.WriteObjectEnd ();
				}
			}

        /// <summary>
        /// Deserialize a tagged stream
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
		/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
        /// <returns>The created object.</returns>		
        public static new Range FromJson (JsonReader jsonReader, bool tagged=true) {
			if (jsonReader == null) {
				return null;
				}
			if (tagged) {
				var Out = jsonReader.ReadTaggedObject (_TagDictionary);
				return Out as Range;
				}
		    var Result = new Range ();
			Result.Deserialize (jsonReader);
			Result.PostDecode();
			return Result;
			}

        /// <summary>
        /// Having read a tag, process the corresponding value data.
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
        /// <param name="tag">The tag</param>
		public override void DeserializeToken (JsonReader jsonReader, string tag) {
			
			switch (tag) {
				case "First" : {
					First = jsonReader.ReadInteger32 ();
					break;
					}
				case "Last" : {
					Last = jsonReader.ReadInteger32 ();
					break;
					}
				default : {
					break;
					}
				}
			// check up that all the required elements are present
			}


		}

	/// <summary>
	/// </summary>
	public partial class Variant : CallsignEntry {
		bool								__Source = false;
		private int						_Source;
        /// <summary>
        ///The first character to be mapped.
        /// </summary>

		public virtual int						Source {
			get => _Source;
			set {_Source = value; __Source = true; }
			}
		bool								__Count = false;
		private int						_Count;
        /// <summary>
        ///The number of characters to be mapped (default is 1).
        /// </summary>

		public virtual int						Count {
			get => _Count;
			set {_Count = value; __Count = true; }
			}
		bool								__Target = false;
		private int						_Target;
        /// <summary>
        ///The character the character Source is to be mapped to. If count is
        ///greater than 1, the character Source+n is mapped to Target+n.
        /// </summary>

		public virtual int						Target {
			get => _Target;
			set {_Target = value; __Target = true; }
			}
		
		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag => __Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "Variant";

		/// <summary>
        /// Factory method
        /// </summary>
        /// <returns>Object of this type</returns>
		public static new JsonObject _Factory () => new Variant();


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// </summary>
        /// <param name="writer">Output stream</param>
        /// <param name="wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="first">If true, item is the first entry in a list.</param>
		public override void Serialize (Writer writer, bool wrap, ref bool first) =>
			SerializeX (writer, wrap, ref first);


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// Unlike the Serlialize() method, this method is not inherited from the
        /// parent class allowing a specific version of the method to be called.
        /// </summary>
        /// <param name="_writer">Output stream</param>
        /// <param name="_wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="_first">If true, item is the first entry in a list.</param>
		public new void SerializeX (Writer _writer, bool _wrap, ref bool _first) {
			PreEncode();
			if (_wrap) {
				_writer.WriteObjectStart ();
				}
			if (__Source){
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Source", 1);
					_writer.WriteInteger32 (Source);
				}
			if (__Count){
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Count", 1);
					_writer.WriteInteger32 (Count);
				}
			if (__Target){
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Target", 1);
					_writer.WriteInteger32 (Target);
				}
			if (_wrap) {
				_writer.WriteObjectEnd ();
				}
			}

        /// <summary>
        /// Deserialize a tagged stream
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
		/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
        /// <returns>The created object.</returns>		
        public static new Variant FromJson (JsonReader jsonReader, bool tagged=true) {
			if (jsonReader == null) {
				return null;
				}
			if (tagged) {
				var Out = jsonReader.ReadTaggedObject (_TagDictionary);
				return Out as Variant;
				}
		    var Result = new Variant ();
			Result.Deserialize (jsonReader);
			Result.PostDecode();
			return Result;
			}

        /// <summary>
        /// Having read a tag, process the corresponding value data.
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
        /// <param name="tag">The tag</param>
		public override void DeserializeToken (JsonReader jsonReader, string tag) {
			
			switch (tag) {
				case "Source" : {
					Source = jsonReader.ReadInteger32 ();
					break;
					}
				case "Count" : {
					Count = jsonReader.ReadInteger32 ();
					break;
					}
				case "Target" : {
					Target = jsonReader.ReadInteger32 ();
					break;
					}
				default : {
					break;
					}
				}
			// check up that all the required elements are present
			}


		}

	/// <summary>
	/// </summary>
	public partial class Notarization : CallsignEntry {
        /// <summary>
        ///Enveloped witness value of a specific append only log.
        ///Note that the need for n signatures could be avoided through Merkle Tree
        ///type techniques, but this is unnecessary.
        ///The log entry in which the Notarization appears SHOULD be signed.
        /// </summary>

		public virtual Enveloped<Witness>						Entries  {get; set;}
		
		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public override string _Tag => __Tag;

		/// <summary>
        /// Tag identifying this class
        /// </summary>
		public new const string __Tag = "Notarization";

		/// <summary>
        /// Factory method
        /// </summary>
        /// <returns>Object of this type</returns>
		public static new JsonObject _Factory () => new Notarization();


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// </summary>
        /// <param name="writer">Output stream</param>
        /// <param name="wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="first">If true, item is the first entry in a list.</param>
		public override void Serialize (Writer writer, bool wrap, ref bool first) =>
			SerializeX (writer, wrap, ref first);


        /// <summary>
        /// Serialize this object to the specified output stream.
        /// Unlike the Serlialize() method, this method is not inherited from the
        /// parent class allowing a specific version of the method to be called.
        /// </summary>
        /// <param name="_writer">Output stream</param>
        /// <param name="_wrap">If true, output is wrapped with object
        /// start and end sequences '{ ... }'.</param>
        /// <param name="_first">If true, item is the first entry in a list.</param>
		public new void SerializeX (Writer _writer, bool _wrap, ref bool _first) {
			PreEncode();
			if (_wrap) {
				_writer.WriteObjectStart ();
				}
			if (Entries != null) {
				_writer.WriteObjectSeparator (ref _first);
				_writer.WriteToken ("Entries", 1);
					Entries.Serialize (_writer, false);
				}
			if (_wrap) {
				_writer.WriteObjectEnd ();
				}
			}

        /// <summary>
        /// Deserialize a tagged stream
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
		/// <param name="tagged">If true, the input is wrapped in a tag specifying the type</param>
        /// <returns>The created object.</returns>		
        public static new Notarization FromJson (JsonReader jsonReader, bool tagged=true) {
			if (jsonReader == null) {
				return null;
				}
			if (tagged) {
				var Out = jsonReader.ReadTaggedObject (_TagDictionary);
				return Out as Notarization;
				}
		    var Result = new Notarization ();
			Result.Deserialize (jsonReader);
			Result.PostDecode();
			return Result;
			}

        /// <summary>
        /// Having read a tag, process the corresponding value data.
        /// </summary>
        /// <param name="jsonReader">The input stream</param>
        /// <param name="tag">The tag</param>
		public override void DeserializeToken (JsonReader jsonReader, string tag) {
			
			switch (tag) {
				case "Entries" : {
					// An untagged structure
					Entries = new Enveloped<Witness> ();
					Entries.Deserialize (jsonReader);
 
					break;
					}
				default : {
					break;
					}
				}
			// check up that all the required elements are present
			}


		}

	}


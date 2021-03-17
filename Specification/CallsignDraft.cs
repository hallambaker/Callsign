using  System.Text;
using  Goedel.CallSign.Log;
using  Goedel.Callsign.Test;
using  Goedel.Protocol;
using  Goedel.Utilities;
 #pragma warning disable IDE0022
 #pragma warning disable IDE0060
 #pragma warning disable IDE1006
using System;
using System.IO;
using System.Collections.Generic;
using Goedel.Registry;
namespace Goedel.Callsign.Specification {
	public partial class Examples : global::Goedel.Registry.Script {

		 public static Examples Instance (StreamWriter output) => new Examples () {_Output = output};
		

		//
		// MakeAllExamples
		//
		public void MakeAllExamples (Examples Examples) {
			 Colophon(Examples);
			 WriteCharacterPageDigits(Examples);
			 WriteCharacterPageLatin(Examples);
			 RegisterAlice(Examples);
			 UpdateAlice(Examples);
			 IoTAlice(Examples);
			 WriteNotarize(Examples);
			}
		

		//
		// Colophon
		//
		public static void Colophon(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\Colophon.md");
			Examples._Output = _Output;
			Examples._Colophon(Examples);
			}
		public void _Colophon(Examples Examples) {

				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The examples in this document were created on {1}. \n{0}", _Indent, DateTime.Now.ToString());
				_Output.Write ("Out of {1} examples,\n{0}", _Indent, CountTotal);
				if (  (ErrorCountTotal ==0) ) {
					_Output.Write ("all passed.\n{0}", _Indent);
					} else {
					_Output.Write ("{1} failed.\n{0}", _Indent, ErrorCountTotal);
					}
				_Output.Write ("\n{0}", _Indent);
					}
		

		//
		// WriteCharacterPageDigits
		//
		public static void WriteCharacterPageDigits(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\CharacterPageDigits.md");
			Examples._Output = _Output;
			Examples._WriteCharacterPageDigits(Examples);
			}
		public void _WriteCharacterPageDigits(Examples Examples) {

				 var CharacterPage = Examples.CharacterPage;
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Examples.CharacterPageDigits);
				_Output.Write ("~~~~\n{0}", _Indent);
					}
		

		//
		// WriteCharacterPageLatin
		//
		public static void WriteCharacterPageLatin(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\CharacterPageLatin.md");
			Examples._Output = _Output;
			Examples._WriteCharacterPageLatin(Examples);
			}
		public void _WriteCharacterPageLatin(Examples Examples) {

				 var CharacterPage = Examples.CharacterPage;
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Examples.CharacterPageLatin);
				_Output.Write ("~~~~\n{0}", _Indent);
					}
		

		//
		// RegisterAlice
		//
		public static void RegisterAlice(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\RegisterAlice.md");
			Examples._Output = _Output;
			Examples._RegisterAlice(Examples);
			}
		public void _RegisterAlice(Examples Examples) {

				 var Registrations = Examples.Registrations;
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("Alice registers the callsign {1} it has the canonical form\n{0}", _Indent, Registrations.CallsignAlice.Presentation);
				_Output.Write ("{1}.\n{0}", _Indent, Registrations.CallsignAlice.Id);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.CallsignAlice);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The registrar receives the request and forwards it to the registry which creates a \n{0}", _Indent);
				_Output.Write ("registration record that is enrolled in the callsign log:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.RegistrationAlice);
				_Output.Write ("~~~~\n{0}", _Indent);
					}
		

		//
		// UpdateAlice
		//
		public static void UpdateAlice(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\UpdateAlice.md");
			Examples._Output = _Output;
			Examples._UpdateAlice(Examples);
			}
		public void _UpdateAlice(Examples Examples) {

				 var Registrations = Examples.Registrations;
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("Alice decides to change her service provider to {1}. She\n{0}", _Indent, Registrations.CallsignAlice2.Service);
				_Output.Write ("also decides that her callsign looks better with an initial capital and so changes the \n{0}", _Indent);
				_Output.Write ("presentation form to {1}. This change does not\n{0}", _Indent, Registrations.CallsignAlice2.Presentation);
				_Output.Write ("require require a new callsign to be registered as this has tghe same canonical form\n{0}", _Indent);
				_Output.Write ("{1}.\n{0}", _Indent, Registrations.CallsignAlice2.Id);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.CallsignAlice2);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The registrar receives the request and forwards it to the registry which creates a \n{0}", _Indent);
				_Output.Write ("registration record that is enrolled in the callsign log:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.RegistrationAlice2);
				_Output.Write ("~~~~\n{0}", _Indent);
					}
		

		//
		// IoTAlice
		//
		public static void IoTAlice(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\IoTAlice.md");
			Examples._Output = _Output;
			Examples._IoTAlice(Examples);
			}
		public void _IoTAlice(Examples Examples) {

				 var Policies = Examples.Policies;
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("Alice adds an Internet connected Thermostat to her home. The thermostat has a built in Web\n{0}", _Indent);
				_Output.Write ("server to allow the settings to be set by a Web browser. During the onboarding process, the\n{0}", _Indent);
				_Output.Write ("thermostat is assigned a domain name {{Policies.ThermostatDns}}\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("Alice's Mesh Service Provider maintains an authoritative DNS server for Alice's Callsign\n{0}", _Indent);
				_Output.Write ("DNS zone {{Policies.AliceDns}}. The IP addresses of this server are specified in the callsign\n{0}", _Indent);
				_Output.Write ("registration of her Mesh Service Provider:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.CallsignProvider2);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The authoritative DNS server publishes a link from which a Mesh DNS Profile specifying the\n{0}", _Indent);
				_Output.Write ("security policy for the zone MAY be obtained:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("[This is probably a prefixed TXT record of some sort.]\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The security policy for the zone states that the DNS zone is signed using DNSSEC and \n{0}", _Indent);
				_Output.Write ("the thermostat supports TLS/1.2 transport layer security:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Policies.AliceZone);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("A non Mesh-aware browser can access the Web site and establish a TLS connection to the \n{0}", _Indent);
				_Output.Write ("thermostat provided that 1) the browser uses a DNS service that supports use of Mesh callsign\n{0}", _Indent);
				_Output.Write ("zones and 2) the device provides a certificate set that allows the browser to build a \n{0}", _Indent);
				_Output.Write ("valid path to a root it trusts.\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("A Mesh aware browser can access the Web site directly and enforce the security policy\n{0}", _Indent);
				_Output.Write ("directly. Thus preventing a downgrade attack to an insecure site.\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
					}
		

		//
		// WriteNotarize
		//
		public static void WriteNotarize(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\WriteNotarize.md");
			Examples._Output = _Output;
			Examples._WriteNotarize(Examples);
			}
		public void _WriteNotarize(Examples Examples) {

				 var Registrations = Examples.Registrations;
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The first time that the Mesh service provider {1} \n{0}", _Indent, Registrations.CallsignProvider1.Presentation);
				_Output.Write ("requests Notarization by the Registry, it creates a witness token on its local log:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.Notarization1.GetWitness());
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The witness value is signed by {1} to create \n{0}", _Indent, Registrations.CallsignProvider1.Presentation);
				_Output.Write ("a Notarization of the witness value:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.Notarization1);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The Notarization value is sent to the registry which enrolls the Notarization in its local\n{0}", _Indent);
				_Output.Write ("log, creates a Witness value on the entry containing the provider Notarization, and returns\n{0}", _Indent);
				_Output.Write ("its own Notarization token containing the Witness value it has most recently created.\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The next time that the service provider requests Notarization, it creates a Witness token as \n{0}", _Indent);
				_Output.Write ("before and includes a Proof path to the previous token:\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("{1}\n{0}", _Indent, Registrations.Notarization2);
				_Output.Write ("~~~~\n{0}", _Indent);
				_Output.Write ("\n{0}", _Indent);
				if (  (Registrations.Notarization2?.Proof?.Path == null) ) {
					_Output.Write ("[NB, generation and verification of proof is not currently supported in the reference code]\n{0}", _Indent);
					 Examples.TestFail();
					}
				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("This time, the Registry verifies the proof path before entering the token.\n{0}", _Indent);
					}
		}
	}

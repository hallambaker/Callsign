//  Copyright © 2021 by Threshold Secrets Llc.
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

using Goedel.Utilities;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Goedel.Callsign;
using Goedel.Callsign.Registry;
using Goedel.Callsign.Registrar;
using Goedel.Mesh;
using Goedel.Cryptography;
using Goedel.Cryptography.Dare;
using Xunit;

namespace Goedel.Callsign.Test {
    public partial class Registrations {
        public Callsign CallsignQuartermaster;
        public Registration RegistrationQuartermaster;


        public Callsign CallsignProvider1;
        public Registration RegistrationProvider1;

        public Callsign CallsignProvider2;
        public Registration RegistrationProvider2;


        public Callsign CallsignAlice;
        public Registration RegistrationAlice;

        public Callsign CallsignAlice2;
        public Registration RegistrationAlice2;

        string udfQ;
        KeyPair keyQ;

        string udfP1;
        KeyPair keyP1;

        string udfP2;
        KeyPair keyP2;

        public RegistryServer RegistryServer;
        public RegistrarServer ProviderServer1;
        public RegistrarServer ProviderServer2;

        public List<Notarization> NotarizationsProvider1 = new List<Notarization>();
        public List<Notarization> NotarizationsProvider2 = new List<Notarization>();
        List<Notarization> NotarizationsQuartermaster = new List<Notarization>();


        public Notarization Notarization1 => NotarizationsProvider1[0];
        public Notarization Notarization2 => NotarizationsProvider1[1];

        /// <summary>
        /// Create the character page for digits for the documentation
        /// </summary>
        [Fact]
        public void RegistrationFromDraft() {
            udfQ = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignQuartermaster);
            keyQ = UDF.DeriveKey(udfQ, KeySecurity.Exportable);

            udfP1 = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignProvider0);
            keyP1 = UDF.DeriveKey(udfP1, KeySecurity.Exportable);

            udfP2 = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignProvider1);
            keyP2 = UDF.DeriveKey(udfP2, KeySecurity.Exportable);

            CallsignQuartermaster = new Callsign(CallsignConstants.CallsignQuartermaster) {
                Service = "@" + CallsignConstants.CallsignProvider0,
                Dns = new List<string> { "10.1.1.1", "10.1.1.2", "2001:db8::0001" },
                Holder = keyP1.KeyIdentifier
                };
            Enveloped<CallsignEntry>.Envelope(CallsignQuartermaster, keyQ);

            CallsignProvider1 = new Callsign(CallsignConstants.CallsignProvider0) {
                Service = "@" + CallsignConstants.CallsignProvider0,
                Dns = new List<string> { "10.1.1.1", "10.1.1.2", "2001:db8::0001" },
                Holder = keyP1.KeyIdentifier
                };

            Enveloped<CallsignEntry>.Envelope(CallsignProvider1, keyP1);

            CallsignProvider2 = new Callsign(CallsignConstants.CallsignProvider1) {
                Service = "@" + CallsignConstants.CallsignProvider1,
                Dns = new List<string> { "10.2.1.1", "10.2.1.2", "2001:db8::1001" },
                Holder = keyP2.KeyIdentifier
                };

            Enveloped<CallsignEntry>.Envelope(CallsignProvider2, keyP2);




            RegistryServer = new RegistryServer(CallsignQuartermaster, RegistrationQuartermaster, keyQ, create:true);
            ProviderServer1 = new RegistrarServer(CallsignProvider1, RegistrationProvider1, keyQ, create: true);
            ProviderServer2 = new RegistrarServer(CallsignProvider2, RegistrationProvider2, keyP2, create: true);

            Notarize(RegistryServer, NotarizationsQuartermaster);


            Notarize(ProviderServer1, NotarizationsProvider1);



            var udfA = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignAlice);
            var keyA = UDF.DeriveKey(udfA, KeySecurity.Exportable);

            //var udfB = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignBob);
            //var keyB = UDF.DeriveKey(udfA, KeySecurity.Exportable);



            CallsignAlice = new Callsign(CallsignConstants.CallsignAlice) {
                Service = CallsignProvider1.Presentation,
                Holder = keyA.KeyIdentifier
                };

            Enveloped<CallsignEntry>.Envelope(CallsignAlice, keyA);
            RegistrationAlice = new Registration(CallsignAlice);

            RegistryServer.Enter(RegistrationAlice);


            Notarize(ProviderServer1, NotarizationsProvider1);


            CallsignAlice2 = new Callsign(CallsignConstants.CallsignAlice1) {
                Service = CallsignProvider2.Presentation,
                Holder = keyA.KeyIdentifier
                };

            Enveloped<CallsignEntry>.Envelope(CallsignAlice2, keyA);
            RegistrationAlice2 = new Registration(CallsignAlice2);

            RegistryServer.Enter(RegistrationAlice2);

            Notarize(ProviderServer2, NotarizationsProvider2);


            }



        void Notarize(CallsignServer initiator, List<Notarization> trace) {

            var previous = trace.Count > 0 ? trace[^1] : null;

            var notarization = initiator.CreateNotarization(previous);
            RegistryServer.EnterNotarization(notarization);

            trace.Add(notarization);

            }

        }
    }

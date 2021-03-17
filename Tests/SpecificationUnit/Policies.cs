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
using Goedel.Mesh;
using Goedel.Cryptography;
using Goedel.Cryptography.Dare;
using Xunit;

namespace Goedel.Callsign.Test {
    public partial class Policies {

        public string AliceDns => CallsignConstants.CallsignAlice + "." 
            + CallsignConstants.CallsignDomain;
        public string ThermostatDns => "hvac." + AliceDns;
        public ProfileDns AliceZone;


        /// <summary>
        /// Create the character page for digits for the documentation
        /// </summary>
        [Fact]
        public void Thermostat() {
            var udfDns = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignAlice);
            var keyDns = UDF.DeriveKey(udfDns, KeySecurity.Exportable);
            var udfTls = UDF.TestKey(CryptoAlgorithmId.Ed448, CallsignConstants.CallsignAlice);
            var keyTls = UDF.DeriveKey(udfTls, KeySecurity.Exportable);

            var dnsPolicy = new SecurityPolicy() {
                CName = new List<string> { AliceDns },
                Protocol = new List<string> { "dns" },
                Enhancements = new List<string> { "dnssec" },
                Roots = new List<KeyData> { new KeyData(keyDns) }
                };
            
            var tlsPolicy = new SecurityPolicy() {
                CName = new List<string> { ThermostatDns },
                Protocol = new List<string> { "http", "https" },
                Enhancements = new List<string> { "tls1.2" },
                Roots = new List<KeyData> { new KeyData(keyTls) },
                Require = true
                };

            AliceZone = new ProfileDns() {
                SecurityPolicies = new List<SecurityPolicy> { dnsPolicy, tlsPolicy }
                };
            }

        }
    }

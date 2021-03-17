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

using System;
using System.Collections.Generic;

using Goedel.Callsign;
using Goedel.Test;

using Xunit;

namespace Goedel.Callsign.Test {
    public partial class CharacterPage {

        public Page CharacterPageDigits;
        public Page CharacterPageLatin;


        public readonly string[][] CannonicalLatin = new string[][] {
            new  string[] {"alice" , "Alice", "ALICE", "aLICE", "A_LI_CE__", " Alice "},
            new  string[] {"bob" , "BOB", "Bob", "B O B"},
            new  string[] {"goedel" , "Goedel", "gödel", "Gödel"},
            new  string[] { "weierstrass", "Weierstrass", "weierstraß", "Weierstraß"},
            };

        /// <summary>
        /// Create the character page for digits for the documentation
        /// </summary>
        [Fact]
        public void CheckCannonicalization() {
            foreach (var test in CannonicalLatin) {
                Check(test);
                }
            }


        void Check(string[] vector) {
            var valid = vector[0];
            foreach (var test in vector) {
                Callsign.Canonicalize(test).TestEqual(valid);
                }

            }

        }
    }

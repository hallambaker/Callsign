//  Copyright � 2021 by Threshold Secrets Llc.
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



namespace Goedel.Callsign.Specification {
    public partial class Examples {

        public static Page CharacterPageDigits;
        public static Page CharacterPageLatin;

        static Examples() {
            _ = Goedel.Cryptography.Core.Initialization.Initialized;
            MakeCharacterPageDigits();
            MakeCharacterPageLatin();
            Callsign.AddPage(CharacterPageDigits);
            Callsign.AddPage(CharacterPageLatin);
            Callsign.MakeIndex();
            }


        /// <summary>
        /// Create the character page for digits for the documentation
        /// </summary>

        public static void MakeCharacterPageDigits() {



            CharacterPageDigits = new() {
                Id = CallsignConstants.CharacterPageDigitsId,
                CharacterSpans = new List<CharacterSpan>(),
                };
            CharacterPageDigits.CharacterSpans.Add(MakeRange ('0','9'));
            CharacterPageDigits.CharacterSpans.Add(MakeVariant(' ', ""));
            CharacterPageDigits.CharacterSpans.Add(MakeVariant('_', ""));
            }

        /// <summary>
        /// Create the character page for Latin characters for the documentation
        /// </summary>

        public static void MakeCharacterPageLatin() {
            CharacterPageLatin = new() {
                Id = CallsignConstants.CharacterPageLatinId,
                Allow = new List<string> {
                    CallsignConstants.CharacterPageDigitsId
                    },
                CharacterSpans = new List<CharacterSpan>(),
                };
            CharacterPageLatin.CharacterSpans.Add(MakeRange('a', 'z'));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('A', 'Z', 'a'));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "aa"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "c"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "d"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "n"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "oe"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "x"));
            //CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "y"));
            //CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "p"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "ss"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "aa"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "c"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "n"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "oe"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "-"));
            //CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "y"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('�', "y"));
            }


        static CharacterSpan MakeRange(char c) => new CharacterSpan() {
            First = (int) c,
            Last = (int)c
            };

        static CharacterSpan MakeRange(char c1, char c2) => new CharacterSpan() {
            First = (int)c1,
            Last = (int)c2
            };

        static MapString MakeVariant(char c, string target) => new MapString() {
            First = (int) c,
            Target = target

            };
        static MapChar MakeVariant(char c1, char c2, char target) => new MapChar() {
            First = c1,
            Last = c2,
            Target = target
            };
        }
    }

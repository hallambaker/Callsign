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
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('À', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Á', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Â', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ã', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ä', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Å', "aa"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Æ', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ç', "c"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('È', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('É', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ê', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ë', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ì', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Í', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Î', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ï', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ð', "d"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ñ', "n"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ò', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ó', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ô', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Õ', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ö', "oe"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('×', "x"));
            //CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ø', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ù', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ú', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Û', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ü', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('Ý', "y"));
            //CharacterPageLatin.CharacterSpans.Add(MakeVariant('Þ', "p"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ß', "ss"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('à', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('á', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('â', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ã', "a"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ä', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('å', "aa"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('æ', "ae"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ç', "c"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('è', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('é', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ê', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ë', "e"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ì', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('í', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('î', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ï', "i"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ð', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ñ', "n"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ò', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ó', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ô', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('õ', "o"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ö', "oe"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('÷', "-"));
            //CharacterPageLatin.CharacterSpans.Add(MakeVariant('ø', "y"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ù', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ú', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('û', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ü', "u"));
            CharacterPageLatin.CharacterSpans.Add(MakeVariant('ý', "y"));
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

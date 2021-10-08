using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder {
    public partial class DecoderApp :Form {
        public DecoderApp() {
            InitializeComponent();
        }

        private void buttonDecodeHandleClick(object sender, EventArgs e) {
            string decodedText = "";
            foreach(string letter in textToDecode.Text.Split('-')) {
                decodedText = decodedText + decodeLetter(Convert.ToDouble(letter), letterToDecode.Text);
            }
            decodeValue.Text = decodedText;
            copiedDecodeAlert.Visible = true;
            Clipboard.SetText(decodedText);
        }

        private void buttonCodeHandleClick(object sender, EventArgs e) {
            string codedText = "";
            Console.WriteLine(letterToCode.Text);
            foreach(char letter in textToCode.Text) {
                codedText = codedText + codifyLetter(letter.ToString(), letterToCode.Text).ToString() + "-";
            }
            string newCoded = codedText.Remove(codedText.Length - 1);
            codedValue.Text = newCoded;
            Clipboard.SetText(newCoded);
            copiedCodeAlert.Visible = true;
        }

        private double codifyLetter(string letter, string key) {
            List<string> abecedario = new List<string>() { "a", "b","c", "d", "e", "f", "g", "h", "i", "j", "k",
                "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            double position = 0;
            double multipliedPosition = 0;
            foreach(string element in abecedario) {
                if(element == letter) {
                    position = abecedario.IndexOf(element);
                }
                if(element == key.ToLower()) {
                    multipliedPosition = abecedario.IndexOf(element);
                }
            }
            multipliedPosition = multipliedPosition * 0.5;
            return position / 2 + 1.0 + multipliedPosition;
        }

        private string decodeLetter(double letter, string key) {
            List<string> abecedario = new List<string>() { "a", "b","c", "d", "e", "f", "g", "h", "i", "j", "k",
                "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            double multipliedPosition = 0;
            foreach(string element in abecedario) {
                if(element == key.ToLower()) {
                    multipliedPosition = abecedario.IndexOf(element);
                }
            }
            double result = letter * 2 - multipliedPosition - 2;
            foreach(string element in abecedario) {
                if(abecedario.IndexOf(element) == result) {
                    return element;
                }
            }
            return "";
        }
    }
}

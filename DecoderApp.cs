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
            decodeValue.Text = textToDecode.Text + "  " + letterToDecode.Text;
            copiedDecodeAlert.Visible = true;
            Clipboard.SetText("Hello, decoded value");
        }

        private void buttonCodeHandleClick(object sender, EventArgs e) {
            string codedText = "";
            foreach(char letter in textToCode.Text) {
                codedText = codedText + codifyLetter(letter.ToString(), letterToCode.Text).ToString() + " ";
            }
            codedValue.Text = codedText;
            Clipboard.SetText(codedText);
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
                if(element == key) {
                    multipliedPosition = abecedario.IndexOf(element);
                }
            }
            multipliedPosition = multipliedPosition * 0.5;
            return position / 2 + 1.0 + multipliedPosition;
        }

     
    }
}

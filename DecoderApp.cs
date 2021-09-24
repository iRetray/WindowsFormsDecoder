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
            codedValue.Text = textToCode.Text + "  " + letterToCode.Text;
            copiedCodeAlert.Visible = true;
            Clipboard.SetText("Hello, coded value");
        }
    }
}

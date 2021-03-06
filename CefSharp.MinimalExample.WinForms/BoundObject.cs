﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public class BoundObject
    {
        public BoundObject() {
            _message = "Hi hosted webpage!";
        }
        private String _message;
        public string MyProperty {
            get { return _message; }
            set { _message = value; }
        }
        public void MyMethod(String message) {
            MessageBox.Show("Message from webpage:\n" + message, "Hosting .NET Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void PostMessage(String message) {
            MessageBox.Show("Message from webpage via postMessage API:\n" + message, "Hosting .NET Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

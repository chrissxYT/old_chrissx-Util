using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace chrissx_Util.IO
{
    public static class Keyboard
    {
        /// <summary>
        /// The string that specifies the A-key.
        /// </summary>
        public static readonly string KEY_A = "A";

        /// <summary>
        /// The string that specifies the B-key.
        /// </summary>
        public static readonly string KEY_B = "B";

        /// <summary>
        /// The string that specifies the C-key.
        /// </summary>
        public static readonly string KEY_C = "C";

        /// <summary>
        /// The string that specifies the D-key.
        /// </summary>
        public static readonly string KEY_D = "D";

        /// <summary>
        /// The string that specifies the E-key.
        /// </summary>
        public static readonly string KEY_E = "E";

        /// <summary>
        /// The string that specifies the F-key.
        /// </summary>
        public static readonly string KEY_F = "F";

        /// <summary>
        /// The string that specifies the G-key.
        /// </summary>
        public static readonly string KEY_G = "G";

        /// <summary>
        /// The string that specifies the H-key.
        /// </summary>
        public static readonly string KEY_H = "H";

        /// <summary>
        /// The string that specifies the I-key.
        /// </summary>
        public static readonly string KEY_I = "I";

        /// <summary>
        /// The string that specifies the J-key.
        /// </summary>
        public static readonly string KEY_J = "J";

        /// <summary>
        /// The string that specifies the K-key.
        /// </summary>
        public static readonly string KEY_K = "K";

        /// <summary>
        /// The string that specifies the L-key.
        /// </summary>
        public static readonly string KEY_L = "L";

        /// <summary>
        /// The string that specifies the M-key.
        /// </summary>
        public static readonly string KEY_M = "M";

        /// <summary>
        /// The string that specifies the N-key.
        /// </summary>
        public static readonly string KEY_N = "N";

        /// <summary>
        /// The string that specifies the O-key.
        /// </summary>
        public static readonly string KEY_O = "O";

        /// <summary>
        /// The string that specifies the P-key.
        /// </summary>
        public static readonly string KEY_P = "P";

        /// <summary>
        /// The string that specifies the Q-key.
        /// </summary>
        public static readonly string KEY_Q = "Q";

        /// <summary>
        /// The string that specifies the R-key.
        /// </summary>
        public static readonly string KEY_R = "R";

        /// <summary>
        /// The string that specifies the S-key.
        /// </summary>
        public static readonly string KEY_S = "S";

        /// <summary>
        /// The string that specifies the T-key.
        /// </summary>
        public static readonly string KEY_T = "T";

        /// <summary>
        /// The string that specifies the U-key.
        /// </summary>
        public static readonly string KEY_U = "U";

        /// <summary>
        /// The string that specifies the V-key.
        /// </summary>
        public static readonly string KEY_V = "V";

        /// <summary>
        /// The string that specifies the W-key.
        /// </summary>
        public static readonly string KEY_W = "W";

        /// <summary>
        /// The string that specifies the X-key.
        /// </summary>
        public static readonly string KEY_X = "X";

        /// <summary>
        /// The string that specifies the Y-key.
        /// </summary>
        public static readonly string KEY_Y = "Y";

        /// <summary>
        /// The string that specifies the Z-key.
        /// </summary>
        public static readonly string KEY_Z = "Z";



        /// <summary>
        /// The string that specifies the Backspace-key.
        /// </summary>
        public static readonly string KEY_BACKSPACE = "{BS}";

        /// <summary>
        /// The string that specifies the Break-key.
        /// </summary>
        public static readonly string KEY_BREAK = "{BREAK}";

        /// <summary>
        /// The string that specifies the Capslock-key.
        /// </summary>
        public static readonly string KEY_CAPSLOCK = "{CAPSLOCK}";

        /// <summary>
        /// The string that specifies the Delete-key.
        /// </summary>
        public static readonly string KEY_DELETE = "{DEL}";

        /// <summary>
        /// The string that specifies the Down-key.
        /// </summary>
        public static readonly string KEY_DOWN = "{DOWN}";

        /// <summary>
        /// The string that specifies the End-key.
        /// </summary>
        public static readonly string KEY_END = "{END}";

        /// <summary>
        /// The string that specifies the Enter-key.
        /// </summary>
        public static readonly string KEY_ENTER = "{ENTER}";

        /// <summary>
        /// The string that specifies the Esc-key.
        /// </summary>
        public static readonly string KEY_ESC = "{ESC}";

        /// <summary>
        /// The string that specifies the Help-key.
        /// </summary>
        public static readonly string KEY_HELP = "{HELP}";

        /// <summary>
        /// The string that specifies the Start-key.
        /// </summary>
        public static readonly string KEY_START = "{HOME}";

        /// <summary>
        /// The string that specifies the Paste-key.
        /// </summary>
        public static readonly string KEY_PASTE = "{INS}";

        /// <summary>
        /// The string that specifies the Left-key.
        /// </summary>
        public static readonly string KEY_LEFT = "{LEFT}";

        /// <summary>
        /// The string that specifies the Num-key.
        /// </summary>
        public static readonly string KEY_NUM = "{NUMLOCK}";

        /// <summary>
        /// The string that specifies the PictureDown-key.
        /// </summary>
        public static readonly string KEY_PICTURE_DOWN = "{PGDN}";

        /// <summary>
        /// The string that specifies the PictureUp-key.
        /// </summary>
        public static readonly string KEY_PICTURE_UP = "{PGUP}";

        /// <summary>
        /// The string that specifies the Print-key.
        /// </summary>
        public static readonly string KEY_PRINT = "{PRTSC}";

        /// <summary>
        /// The string that specifies the Right-key.
        /// </summary>
        public static readonly string KEY_RIGHT = "{RIGHT}";

        /// <summary>
        /// The string that specifies the Scroll-key.
        /// </summary>
        public static readonly string KEY_SCROLL = "{SCROLLLOCK}";

        /// <summary>
        /// The string that specifies the Tab-key.
        /// </summary>
        public static readonly string KEY_TAB = "{TAB}";

        /// <summary>
        /// The string that specifies the Up-key.
        /// </summary>
        public static readonly string KEY_UP = "{UP}";



        /// <summary>
        /// The string that specifies the F1-key.
        /// </summary>
        public static readonly string KEY_F1 = "{F1}";

        /// <summary>
        /// The string that specifies the F2-key.
        /// </summary>
        public static readonly string KEY_F2 = "{F2}";

        /// <summary>
        /// The string that specifies the F3-key.
        /// </summary>
        public static readonly string KEY_F3 = "{F3}";

        /// <summary>
        /// The string that specifies the F4-key.
        /// </summary>
        public static readonly string KEY_F4 = "{F4}";

        /// <summary>
        /// The string that specifies the F5-key.
        /// </summary>
        public static readonly string KEY_F5 = "{F5}";

        /// <summary>
        /// The string that specifies the F6-key.
        /// </summary>
        public static readonly string KEY_F6 = "{F6}";

        /// <summary>
        /// The string that specifies the F7-key.
        /// </summary>
        public static readonly string KEY_F7 = "{F7}";

        /// <summary>
        /// The string that specifies the F8-key.
        /// </summary>
        public static readonly string KEY_F8 = "{F8}";

        /// <summary>
        /// The string that specifies the F9-key.
        /// </summary>
        public static readonly string KEY_F9 = "{F9}";

        /// <summary>
        /// The string that specifies the F10-key.
        /// </summary>
        public static readonly string KEY_F10 = "{F10}";

        /// <summary>
        /// The string that specifies the F11-key.
        /// </summary>
        public static readonly string KEY_F11 = "{F11}";

        /// <summary>
        /// The string that specifies the F12-key.
        /// </summary>
        public static readonly string KEY_F12 = "{F12}";

        /// <summary>
        /// The string that specifies the F13-key.
        /// </summary>
        public static readonly string KEY_F13 = "{F13}";

        /// <summary>
        /// The string that specifies the F14-key.
        /// </summary>
        public static readonly string KEY_F14 = "{F14}";

        /// <summary>
        /// The string that specifies the F15-key.
        /// </summary>
        public static readonly string KEY_F15 = "{F15}";

        /// <summary>
        /// The string that specifies the F16-key.
        /// </summary>
        public static readonly string KEY_F16 = "{F16}";



        /// <summary>
        /// The string that specifies the Add-key.
        /// </summary>
        public static readonly string KEY_ADD = "{ADD}";

        /// <summary>
        /// The string that specifies the Subtract-key.
        /// </summary>
        public static readonly string KEY_SUBTRACT = "{SUBTRACT}";

        /// <summary>
        /// The string that specifies the Multiply-key.
        /// </summary>
        public static readonly string KEY_MULTIPLY = "{MULTIPLY}";

        /// <summary>
        /// The string that specifies the Divide-key.
        /// </summary>
        public static readonly string KEY_DIVIDE = "{DEVIDE}";



        /// <summary>
        /// The string that specifies the Shift-key.
        /// </summary>
        public static readonly string KEY_SHIFT = "+";

        /// <summary>
        /// The string that specifies the Strg-key.
        /// </summary>
        public static readonly string KEY_STRG = "^";

        /// <summary>
        /// The string that specifies the Alt-key.
        /// </summary>
        public static readonly string KEY_ALT = "%";

        /// <summary>
        /// The string that specifies the 1-key.
        /// </summary>
        public static readonly string KEY_1 = "1";

        /// <summary>
        /// The string that specifies the 2-key.
        /// </summary>
        public static readonly string KEY_2 = "2";

        /// <summary>
        /// The string that specifies the 3-key.
        /// </summary>
        public static readonly string KEY_3 = "3";

        /// <summary>
        /// The string that specifies the 4-key.
        /// </summary>
        public static readonly string KEY_4 = "4";

        /// <summary>
        /// The string that specifies the 5-key.
        /// </summary>
        public static readonly string KEY_5 = "5";

        /// <summary>
        /// The string that specifies the 6-key.
        /// </summary>
        public static readonly string KEY_6 = "6";

        /// <summary>
        /// The string that specifies the 7-key.
        /// </summary>
        public static readonly string KEY_7 = "7";

        /// <summary>
        /// The string that specifies the 8-key.
        /// </summary>
        public static readonly string KEY_8 = "8";

        /// <summary>
        /// The string that specifies the 9-key.
        /// </summary>
        public static readonly string KEY_9 = "9";

        /// <summary>
        /// The string that specifies the 0-key.
        /// </summary>
        public static readonly string KEY_0 = "0";



        /// <summary>
        /// Sends the keystroke(s).
        /// </summary>
        /// <param name="key">The key(s) to send</param>
        /// <returns>True if sending worked, false if an error occured</returns>
        public static bool SendKeystroke(string key)
        {
            try
            {
                SendKeys.Send(key);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Sends all the keys in the array.
        /// </summary>
        /// <param name="keys">The keys to send</param>
        /// <returns>True if sending worked, false if an error occured</returns>
        public static bool SendKeystrokes(string[] keys)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string k in keys)
                sb.Append(k);
            return SendKeystroke(sb.ToString());
        }

        /// <summary>
        /// Send all the keys in the array.
        /// </summary>
        /// <param name="keys">The keys to send</param>
        /// <returns>True if sending worked, false if an error occured</returns>
        public static bool SendKeystrokes(List<string> keys)
        {
            return SendKeystrokes(keys.ToArray());
        }



        private static readonly Dictionary<short, string> keyCodes = new Dictionary<short, string>()
        {
            {1, "LBUTTON"},{2, "RBUTTON"},{3, "CANCEL"},{4, "MBUTTON"},{5, "XBUTTON1"},{6, "XBUTTON2"},{7, "UNDEFINED"},{8, "BACK"},{9, "TAB"},{0x0A, "RESERVED"},{0x0B, "RESERVED"},{0x0C, "CLEAR"},{0x0D, "RETURN"},
            {0x0E, "UNDEFINED"},{0x0F, "UNDEFINED"},{0x10, "SHIFT"},{0x11, "CONTROL"},{93, "MENU"},{0x13, "PAUSE"},{0x14, "CAPITAL"},{0x15, "KANA/HANGUEL/HANGUL"},{0x16, "UNDEFINED"},{0x17, "JUNJA"},{0x18, "FINAL"},{0x19, "HANJA/VK_KANJI"},
            {0x1A, "UNDEFINED"},{0x1B, "ESCAPE"},{0x1C, "CONVERT"},{0x1D, "NONCONVERT"},{0x1E, "ACCEPT"},{0x1F, "MODECHANGE"},{0x20, "SPACE"},{0x21, "PRIOR"},{0x22, "NEXT"},{0x23, "END"},{0x24, "HOME"},{0x25, "LEFT"},{0x26, "UP"},{0x27, "RIGHT"},
            {0x28, "DOWN"},{0x29, "SELECT"},{0x2A, "PRINT"},{0x2B, "EXECUTE"},{0x2C, "SNAPSHOT"},{0x2D, "INSERT"},{0x30, "0"},{0x31, "1"},{0x32, "2"},{0x33, "3"},{0x34, "4"},{0x35, "5"},{0x36, "6"},{0x37, "7"},{0x38, "8"},{0x39, "9"},
            {0x40, "UNDEFINED"},{0x41, "A"},{0x42, "B"},{0x43, "C"},{0x44, "D"},{0x45, "E"},{0x46, "F"},{0x47, "G"},{0x48, "H"},{0x49, "I"},{0x4A, "J"},{0x4B, "K"},{0x4C, "L"},{0x4D, "M"},{0x4E, "N"},{0x4F, "O"},{0x50, "P"},{0x51, "Q"},{0x52, "R"},
            {0x53, "S"},{0x54, "T"},{0x55, "U"},{0x56, "V"},{0x57, "W"},{0x58, "X"},{0x59, "Y"},{0x5A, "Z"},{0x5B, "LWIN"},{0x5C, "RWIN"},{0x60, "NUMPAD0"},{0x61, "NUMPAD1"},{0x62, "NUMPAD2"},{0x63, "NUMPAD3"},{0x64, "NUMPAD4"},{0x65, "NUMPAD5"},
            {0x66, "NUMPAD6"},{0x67, "NUMPAD7"},{0x68, "NUMPAD8"},{0x69, "NUMPAD9"},{0x70, "F1"},{0x71, "F2"},{0x72, "F3"},{0x73, "F4"},{0x74, "F5"},{0x75, "F6"},{0x76, "F7"},{0x77, "F8"},{0x78, "F9"},{0x79, "F10"},{0x7A, "F11"},{0x7B, "F12"},
            {0xA0, "LSHIFT"},{0xA1, "RSHIFT"},{0xA2, "LCONTROL"},{0xA3, "RCONTROL"},{111, "/"},{106, "*"},{109, "-"},{107, "+"},{164, "ALT"},{165, "ALTGR"},{186, "Ü"},{187, "+"},{188, ","},{189, "-"},{190, "."},{191, "#"},{192, "Ö"},{222, "Ä"},
            {46, "DEL"}
        };

        /// <summary>
        /// Gets the name of the key.
        /// </summary>
        /// <param name="key">The key to get the name for</param>
        /// <returns>The name of the key</returns>
        public static string GetKeyName(short key)
        {
            if (keyCodes.ContainsKey(key))
                return keyCodes[key];
            else
                return key.ToString();
        }

        /// <summary>
        /// Checks if the given key is pressed.
        /// </summary>
        /// <param name="key">The key to check</param>
        /// <returns>Whether the key is pressed or not</returns>
        public static bool IsPressed(int key)
        {
            return GetAsyncKeyState(key) == short.MinValue + 1;
        }

        /// <summary>
        /// Gets the state of the given key.
        /// </summary>
        /// <param name="vKey">The key to get the state of</param>
        /// <returns>The current state of the key</returns>
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Int32 vKey);
    }
}

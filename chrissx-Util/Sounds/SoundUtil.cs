using System.Globalization;
using System.Speech.Synthesis;

namespace chrissx_Util.Sounds
{
    public static class SoundUtil
    {
        /// <summary>
        /// Speechsynthesizes the text with the voice.
        /// </summary>
        /// <param name="text">The text to speak</param>
        /// <param name="culture">The culture of the voice to use</param>
        public static void Speak(string text, CultureInfo culture)
        {
            using(SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, culture);
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.Speak(text);
            }
        }

        /// <summary>
        /// Speechsynthesizes the text with the voice asynchronious.
        /// </summary>
        /// <param name="text">The text to speak</param>
        /// <param name="culture">The culture of the voice to use</param>
        public static void SpeakAsync(string text, CultureInfo culture)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, culture);
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.SpeakAsync(text);
            }
        }
    }
}

using System;
using System.Windows;
using System.Windows.Controls;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Text;
using System.Media;
using System.IO;
using Microsoft.Win32;

namespace Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        private static string defaultfilepath = @"C:\JasmineAung\test.wav";
        private static StringBuilder results = new StringBuilder();
        private static bool ReadComplete;
        SpeechSynthesizer synth;
        SpeechRecognitionEngine sre;
        PromptBuilder pBuilder = new PromptBuilder();

        SoundPlayer m_SoundPlayer = new SoundPlayer();


        #endregion Variables

        public MainWindow()
        {
            InitializeComponent();
        }

        #region  Event handler 

        public void Reset_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            txtInput.Text = txtOutput.Text = "";
        }

        public void Record_Click(object sender, EventArgs e)
        {
            synth = new SpeechSynthesizer();
            if (txtInput.Text != "")    //if text area is not empty 
            {
                synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);

                // Configure the audio output. 
                synth.SetOutputToWaveFile(defaultfilepath, new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));

                // Build a prompt.                              
                pBuilder.AppendText(txtInput.Text);

                // Speak the prompt.
                synth.SpeakAsync(pBuilder);

            }
            else
            {
                MessageBox.Show("Please enter some text in the textbox", "Message", MessageBoxButton.OK);
            }

        }

        public void Replay_Click(object sender, EventArgs e)
        {
            replay(defaultfilepath);
        }

        public void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            try
            {
                if (result.GetValueOrDefault())
                {
                    string _file = dlg.FileName;
                    txtDoctoOpen.Text = _file;
                    replay(_file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error : {0}", ex), "Warning", MessageBoxButton.OK);
            }
        }

        public void SaveTemplate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save Template");
        }
        
        public void Getlist_Click(object sender, EventArgs e)
        {
            ProcessListPage win2 = new ProcessListPage();
            win2.Show();
            this.Close();
        }

        public void GetKeyboard_Click(object sender, EventArgs e)
        {
            Voicekeyboard keyboard = new Voicekeyboard();
            keyboard.Show();
            this.Close();
        }
        #endregion

        #region Methods
        private void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            synth.Dispose();
            Label lblMsg = (Label)this.FindName("lblMsg");
            lblMsg.Content = "Recording Complete";
        }

        private void replay(string filepath)
        {
            sre = new SpeechRecognitionEngine();
            Grammar gr = new DictationGrammar();
            sre.LoadGrammar(gr);
            sre.SetInputToWaveFile(filepath);
            sre.BabbleTimeout = new TimeSpan(Int32.MaxValue);
            sre.InitialSilenceTimeout = new TimeSpan(Int32.MaxValue);
            sre.EndSilenceTimeout = new TimeSpan(100000000);
            sre.EndSilenceTimeoutAmbiguous = new TimeSpan(100000000);

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            sre.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(recognizer_RecognizeCompleted);

            ReadComplete = false;
            sre.RecognizeAsync();


            /***Replay****/
            System.Media.SoundPlayer m_SoundPlayer = new System.Media.SoundPlayer(filepath);
            m_SoundPlayer.Play();
            sre.RecognizeAsyncStop();
            sre.Dispose();
        }

        // Handle the SpeechRecognized event.
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result != null && e.Result.Text != null)
            {
                results.Append(e.Result.Text);
            }
            else
            {
                results.Append("Recognized text not available.");
            }
        }

        // Handle the RecognizeCompleted event.
        static void recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                results.Append(String.Format("{0} : {1}", e.Error.GetType().Name, e.Error.Message));
            }
            if (e.Cancelled)
            {
                results.Append("Operation cancelled.");
            }
            if (e.InputStreamEnded)
            {
                results.Append("End of stream encountered.");
            }
           
        }

        private void WriteResult()
        {
            txtOutput.Text = results.ToString();
            results.Clear();
        }
    }
    #endregion Methods
}


using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;
using WMPDXMLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Gestor_De_Musica
{
    public partial class Form1 : Form
    {

        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private string[] musicFiles;
        private int currentIndex = 0;
        private bool isPlaying = false;


        public Form1()
        {
            InitializeComponent();

            wmp.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(Wmp_PlayStateChange);
            wmp.MediaError += new _WMPOCXEvents_MediaErrorEventHandler(Wmp_MediaError);

            //CargarMusica(@"C:\Users\yonat\OneDrive\Desktop\Musica"); // Ruta de la carpeta de música
        }



        private void Wmp_PlayStateChange(int newState)
        {
            if (newState == (int)WMPPlayState.wmppsPlaying)
            {
                MessageBox.Show("Reproduciendo: " + Path.GetFileName(musicFiles[currentIndex]));
            }
            else if (newState == (int)WMPPlayState.wmppsStopped)
            {
                MessageBox.Show("La reproducción ha finalizado.");
            }
        }

        private void Wmp_MediaError(object pMediaObject)
        {
            MessageBox.Show("Error al reproducir el archivo.");
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecciona una carpeta de música";
                folderDialog.ShowNewFolderButton = false; // Evita crear nuevas carpetas

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.LastFolder = selectedPath;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Carpeta seleccionada: " + selectedPath);
                    CargarMusica(selectedPath); // Cargar la música desde la carpeta elegida
                }

                string lastFolder = Properties.Settings.Default.LastFolder;
                if (!string.IsNullOrEmpty(lastFolder) && Directory.Exists(lastFolder))
                {

                    CargarMusica(lastFolder);
                }

            }
        }


        private void CargarMusica(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                musicFiles = Directory.GetFiles(folderPath, "*.mp3");
                if (musicFiles.Length > 0)
                {
                    listBox1.Items.Clear(); // Limpiar la lista
                    foreach (var file in musicFiles)
                    {
                        listBox1.Items.Add(Path.GetFileName(file)); // Agregar solo el nombre del archivo
                    }
                    //MessageBox.Show($"Archivos encontrados: {musicFiles.Length}");
                    wmp.URL = musicFiles[0]; // Cargar la primera canción
                                             //MessageBox.Show($"Reproduciendo: {wmp.URL}"); // Verificar la URL antes de reproducir

                    wmp.controls.play();
                    ReproducirCancion(0);
                }
            }
            else
            {
                MessageBox.Show("La carpeta no existe.");
            }
        }

        private void ReproducirCancion(int index)
        {
            if (musicFiles != null && musicFiles.Length > 0)
            {
                currentIndex = index;
                wmp.URL = musicFiles[currentIndex];
                wmp.settings.volume = 100;
                wmp.controls.play();

                isPlaying = true;

                listBox1.SelectedIndex = currentIndex;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (musicFiles != null && currentIndex < musicFiles.Length - 1)
            {
                ReproducirCancion(currentIndex + 1);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (musicFiles != null && currentIndex > 0)
            {
                ReproducirCancion(currentIndex - 1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                ReproducirCancion(listBox1.SelectedIndex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_PlayPause(object sender, EventArgs e)
        {
            if (isPlaying == true)
            {
                wmp.controls.stop();
                isPlaying = false;
            }
            else
            {
                ReproducirCancion(currentIndex);
                wmp.controls.play();
                isPlaying = true;
            }
        }

    }
}

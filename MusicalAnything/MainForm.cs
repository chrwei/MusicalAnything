using MusicalAnything.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicalAnything {
    public partial class MainForm : Form {
        SavedTokenHandler settings;
        IWMPPlaylist playlist;

        public MainForm() {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            SongList.DisplayMember = "Title";
            SongList.ValueMember = "Path";

            playlist = Player.playlistCollection.newPlaylist("list");

            
        }

        private void CurrentDomain_ProcessExit(object sender, EventArgs e) {
            MusicalAnything.Properties.Settings.Default.Saved = settings.GetSettings();
            MusicalAnything.Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            settings = new SavedTokenHandler(MusicalAnything.Properties.Settings.Default.Saved);

            if(settings.GetToken("PlayMin") == null) {
                settings.SetToken("PlayMin", "300");
            }
            if (settings.GetToken("PlayMax") == null) {
                settings.SetToken("PlayMax", "360");
            }
            if (settings.GetToken("PauseMin") == null) {
                settings.SetToken("PauseMin", "15");
            }
            if (settings.GetToken("PauseMax") == null) {
                settings.SetToken("PauseMax", "30");
            }
            if (settings.GetToken("SourcePath") == null) {
                settings.SetToken("SourcePath", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            }

            PlayMinBox.Text = settings.GetToken("PlayMin");
            PlayMaxBox.Text = settings.GetToken("PlayMax");
            PauseMinBox.Text = settings.GetToken("PauseMin");
            PauseMaxBox.Text = settings.GetToken("PauseMax");

            if (settings.GetToken("SourcePath") != "") {
                SourceBtn.Text = settings.GetToken("SourcePath");
                if (Directory.Exists(settings.GetToken("SourcePath"))){
                    RefreshBtn.PerformClick();
                } else {
                    MessageBox.Show("Source folder " + settings.GetToken("SourcePath") + " is not accessible, choose another folder before playing");
                }
            }

        }

        private void SourceBtn_Click(object sender, EventArgs e) {
            var f = new FolderBrowserDialog();
            if (Directory.Exists(settings.GetToken("SourcePath"))) {
                f.SelectedPath = settings.GetToken("SourcePath");
            }
            if (f.ShowDialog() == DialogResult.OK) {
                settings.SetToken("SourcePath", f.SelectedPath);
                SourceBtn.Text = f.SelectedPath;
                RefreshBtn.PerformClick();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            SongList.Items.Clear();
            playlist.clear();
            Player.settings.setMode("shuffle", true);

            StatusLabel.Text = "Loading, Please Wait";
            Thread t = new Thread(LoadSongList);
            t.IsBackground = true;
            t.Start();
        }

        private void LoadSongList() {
            var dir = new DirectoryInfo(settings.GetToken("SourcePath"));
            foreach (var f in dir.EnumerateFiles("*.mp3", SearchOption.AllDirectories)) {
                try {
                    var t = new MediaDisplay(f);
                    if (t.Media.Tag.Title != null) {
                        playlist.appendItem(Player.newMedia(f.FullName));
                        Invoke((MethodInvoker)(() => SongList.Items.Add(t)));
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            if (EnablePauseCheck.Checked) {
                Invoke((MethodInvoker)(() => {
                    PauseTimer.Enabled = true;
                    StatusLabel.Text = "Autoplay Enabled, please wait";
                }));
            }
        }

        private void PlayPauseBtn_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            int next = 0;
            if ((int)Player.playState <= 1 || (int)Player.playState >= 10 || Player.playState == WMPLib.WMPPlayState.wmppsMediaEnded) { //not playing or paused, check for selected file and play it
                Player.currentPlaylist = playlist;
                Player.Ctlcontrols.play();
                PlayPauseBtn.Text = "Pause";
                StatusLabel.Text = "";
                next = rnd.Next(int.Parse(PlayMinBox.Text), int.Parse(PlayMaxBox.Text));
            } else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused) { //pauses, resume
                Player.Ctlcontrols.play();
                PlayPauseBtn.Text = "Pause";
                try {
                    if (int.Parse(PlayMinBox.Text) < int.Parse(PlayMaxBox.Text)) {
                        next = rnd.Next(int.Parse(PlayMinBox.Text), int.Parse(PlayMaxBox.Text));
                    }
                } catch { }
            } else { //playing in some form, pause it
                Player.Ctlcontrols.pause();
                PlayPauseBtn.Text = "Play";
                try {
                    if (int.Parse(PauseMinBox.Text) < int.Parse(PauseMaxBox.Text)) {
                        next = rnd.Next(int.Parse(PauseMinBox.Text), int.Parse(PauseMaxBox.Text));
                    }
                } catch {}
            }
            NextEvent = DateTime.Now.AddSeconds(next);
        }

        private void Player_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e) {
            var m = e.item as IWMPMedia;
            foreach (MediaDisplay s in SongList.Items) {
                if (m.sourceURL == s.Path) {
                    SongList.SelectedItem = s;
                    if (SongList.SelectedIndex > 3)
                        SongList.TopIndex = SongList.SelectedIndex - 3;
                    TitleBox.Text = s.Media.Tag.Title;
                    ArtistBox.Text = s.Media.Tag.FirstPerformer;
                    AlbumBox.Text = s.Media.Tag.Album;
                    FilenameBox.Text = s.Path;
                    break;
                }
            }
        }

        DateTime NextEvent = DateTime.Now;
        private void PauseTimer_Tick(object sender, EventArgs e) {
            if(DateTime.Now >= NextEvent) {
                PlayPauseBtn.PerformClick();
            }
            if (EnablePauseCheck.Checked) {
                if(PlayPauseBtn.Text == "Pause") {
                    PauseTimeLbl.Text = "";
                } else {
                    PauseTimeLbl.Text = "Starting in " + (NextEvent.Subtract(DateTime.Now).TotalSeconds.ToString("N0"));
                }
            }
        }

        private void PlayPauseBox_TextChanged(object sender, EventArgs e) {
            var t = sender as TextBox;
            switch (t.Name) {
                case "PlayMinBox":
                    settings.SetToken("PlayMin", PlayMinBox.Text);
                    break;
                case "PlayMaxBox":
                    settings.SetToken("PlayMax", PlayMaxBox.Text);
                    break;
                case "PauseMinBox":
                    settings.SetToken("PauseMin", PauseMinBox.Text);
                    break;
                case "PauseMaxBox":
                    settings.SetToken("PauseMax", PauseMaxBox.Text);
                    break;
            }
        }

        private void EnablePauseCheck_CheckedChanged(object sender, EventArgs e) {
            if (EnablePauseCheck.Checked) {
                PauseTimer.Enabled = true;
                PauseTimeLbl.Text = "";
            } else {
                PauseTimer.Enabled= false;
                PauseTimeLbl.Text = "Pause Disabled";
            }
        }

        private void SkipBtn_Click(object sender, EventArgs e) {
            Player.Ctlcontrols.next();
        }

        private void DeleteBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Remove file from folder?  There is no undo.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                var m = Player.currentMedia;
                foreach (MediaDisplay s in SongList.Items) {
                    if (m.sourceURL == s.Path) {
                        SongList.Items.Remove(s);
                        break;
                    }
                }
                var p = m.sourceURL;
                Player.Ctlcontrols.next();
                playlist.removeItem(m);
                //delay and try to delete until the player releases the lock
                new Thread(() => {
                    while (File.Exists(p)) {
                        Thread.Sleep(100);
                        try {
                            File.Delete(p);
                        } catch { 
                            //don't show errors
                        }
                    }
                }).Start();
            }
        }

        private void SongList_MouseDoubleClick(object sender, MouseEventArgs e) {
            var s = SongList.SelectedItem as MediaDisplay;
            for (int i = 0; i < playlist.count; i++) {
                if (playlist.Item[i].sourceURL == s.Path) {
                    Player.Ctlcontrols.playItem(playlist.Item[i]);
                    PlayPauseBtn.Text = "Pause";
                    break;
                }
            }
        }
    }

    class MediaDisplay {
        public MediaDisplay(FileInfo File) {
            Media = TagLib.File.Create(File.FullName);
            if (Media.Tag.Title != null) {
                if (Media.Tag.Title == "") {
                    Media.Tag.Title = File.Name;
                }
            }
        }
        public TagLib.File Media;
        public string Title { get { return Media.Tag.Title; } } 
        public string Path { get { return Media.Name; } }
    }
}

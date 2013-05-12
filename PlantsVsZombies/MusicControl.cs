using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PlantsVsZombies
{
    class MusicControl
    {
        #region 音乐控制
        public static uint SND_ASYNC = 0x0001;
        public static uint SND_FILENAME = 0x00020000;
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand,
        string lpstrReturnString, uint uReturnLength, uint hWndCallback);
        public static void OpenBackMusic()
        {
            mciSendString(@"open ""Music/GAME开场曲.mp3"" alias temp_alias", null, 0, 0);
        }
        public static void stopBackMusic()
        {
            mciSendString("stop temp_alias", null, 0, 0); //必须加temp_alias
        }
        public static void playBackMusic()
        {

            mciSendString("play temp_alias repeat", null, 0, 0);
        }
        public static void closeBackMusic()
        {
            mciSendString(@"close temp_alias", null, 0, 0);
        }


        public static void OpenButtonMusic()
        {
            mciSendString(@"open ""Music/buttondown.mp3"" alias temp", null, 0, 0);
        }
        public static void stopButtonMusic()
        {
            mciSendString("stop temp", null, 0, 0); //必须加temp_alias
        }
        public static void playButtonMusic()
        {

            mciSendString("play temp repeat", null, 0, 0);
        }
        public static void closeButtonMusic()
        {
            mciSendString(@"close temp", null, 0, 0);
        }
        #endregion
    }
}

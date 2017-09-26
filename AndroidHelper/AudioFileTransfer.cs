using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidHelper
{
    public class AudioFileTransfer
    {
        /// <summary>
        /// 发送英文语音
        /// </summary>
        /// <returns></returns>
        public bool SendEnglishAudio(string fileName)
        {
            try
            {
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 发送中文语音
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SendChineseAudio(string fileName)
        {
            try
            {
                return true;
            }
            catch { return false; }
       }

        /// <summary>
        /// 开启文件服务器(使得)
        /// </summary>
        /// <returns></returns>
        public bool StartAudioHttpServer()
        {
            try
            {
            }
            catch { }
        }
        
    }
}

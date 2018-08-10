using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceAndCallBack
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int curDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }



        public VideoPost() {}

        public VideoPost(string title, string sendByUsername, string videoUrl, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Property VideoUrl is a member of VideoPost
            this.VideoURL = videoUrl;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(curDuration < Length)
            {
                curDuration++;
                Console.WriteLine("Video at {0} s", curDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0} s", curDuration);
                curDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3} : {4}", this.ID, this.Title, this.VideoURL, this.SendByUsername, this.Length);
        }

    }
}

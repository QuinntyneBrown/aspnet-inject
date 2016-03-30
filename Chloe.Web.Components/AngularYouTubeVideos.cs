using Chloe.Components.Contracts;
using System.Collections;
using System.Collections.Generic;
using System;
using Chloe.Http.Contracts;

namespace Chloe.Web
{
    public class AngularYouTubeVideos: IAngularYouTubeVideos
    {
        public AngularYouTubeVideos(IChloeHttpClient client)
        {
            this.Videos = new HashSet<IYouTubeVideo>();
            this.client = client;
        }

        public IAngularYouTubeVideos Invoke()
        {
            var entity = new AngularYouTubeVideos(this.client);
            ICollection<YouTubeVideo> result = this.client.Get<ICollection<YouTubeVideo>>("http://www.angular.video/api/youTubeVideo/get");
            foreach(var video  in result) { entity.Videos.Add(video); }            
            return entity;
        }
        
        public ICollection<IYouTubeVideo> Videos { get; set; }
        private IChloeHttpClient client { get; set; }
    }

}
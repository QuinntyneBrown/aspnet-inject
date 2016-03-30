using Chloe.Components.Contracts;
using System.Collections;
using System.Collections.Generic;
using System;
using Chloe.Http.Contracts;
using Chloe.Web.Components;

namespace Chloe.Web
{
    public class AngularYouTubeVideos: BaseComponent<IAngularYouTubeVideos>, IAngularYouTubeVideos
    {
        public AngularYouTubeVideos(IChloeHttpClient client)
        {
            this.Videos = new HashSet<IYouTubeVideo>();
            this.client = client;
        }

        public override IAngularYouTubeVideos Invoke()
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
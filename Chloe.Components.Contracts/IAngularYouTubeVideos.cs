using System.Collections.Generic;

namespace Chloe.Components.Contracts
{
    public interface IAngularYouTubeVideos: IComponent<IAngularYouTubeVideos>
    {
        ICollection<IYouTubeVideo> Videos { get; set; }
    }
}

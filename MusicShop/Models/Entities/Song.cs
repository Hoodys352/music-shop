using System;

namespace MusicShop.Models.Entities
{
    public class Song
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Length { get; set; }

        //Fully-defined relationship with Tracklist
        public Guid TracklistId { get; set; }
        public Tracklist Tracklist { get; set; }
    }
}